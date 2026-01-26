const axios = require("axios");
const cheerio = require("cheerio");
const fs = require("fs");
const path = require("path");
const puppeteer = require("puppeteer");

const baseUrl = "https://developers.weixin.qq.com/minigame/dev/api/";
const docsDir = path.resolve(__dirname, "docs");
const apiDir = path.join(docsDir, "api");
const apiUrlsFile = path.join(docsDir, "api-urls.md");

function ensureDirSync(dir) {
  if (!fs.existsSync(dir)) {
    fs.mkdirSync(dir, { recursive: true });
  }
}

async function fetchApiList() {
  const res = await axios.get(baseUrl);
  const $ = cheerio.load(res.data);
  // 1. 解析左侧导航栏，获取所有 API 链接
  const apiLinks = [];
  $("a").each((i, el) => {
    const href = $(el).attr("href");
    if (href && href.startsWith("/minigame/dev/api/")) {
      // 只保留 # 前部分
      const url = "https://developers.weixin.qq.com" + href.split("#")[0];
      apiLinks.push(url);
    }
  });
  return [...new Set(apiLinks)];
}

async function downloadApiPage(apiUrl, filePath) {
  if (fs.existsSync(filePath)) {
    console.log(`[已存在] 跳过: ${filePath}`);
    return;
  }
  let browser;
  try {
    browser = await puppeteer.launch({ headless: true });
    const page = await browser.newPage();
    await page.goto(apiUrl, { waitUntil: "networkidle2", timeout: 60000 });
    // 等待主要内容渲染
    await page.waitForSelector(".theme-container", { timeout: 30000 });
    const html = await page.content();
    fs.writeFileSync(filePath, html, "utf-8");
    console.log(`[已下载] ${apiUrl} -> ${filePath}`);
  } catch (e) {
    console.error(`[下载失败] ${apiUrl}:`, e.message);
  } finally {
    if (browser) await browser.close();
  }
}

async function main() {
  ensureDirSync(docsDir);
  ensureDirSync(apiDir);
  const apiLinks = await fetchApiList();
  // 保存 API 列表到 markdown
  const mdList = apiLinks.map((url) => `- [${url}](${url})`).join("\n");
  fs.writeFileSync(
    apiUrlsFile,
    "# 微信小游戏 API 链接\n\n" + mdList + "\n",
    "utf-8",
  );
  // 下载每个 API 页面
  for (const url of apiLinks) {
    // 取最后一段作为文件名
    const match = url.match(/\/([^\/]+)\/?$/);
    let apiName = match ? match[1] : "index";
    // 处理特殊字符
    apiName = apiName.replace(/[^a-zA-Z0-9_-]/g, "_");
    const filePath = path.join(apiDir, `${apiName}.html`);
    await downloadApiPage(url, filePath);
    // 可加延时防止被封
    // await new Promise(r => setTimeout(r, 200));
  }
}

main();
