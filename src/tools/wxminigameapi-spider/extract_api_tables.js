const fs = require("fs");
const path = require("path");
const cheerio = require("cheerio");

const apiDir = path.resolve(__dirname, "docs", "api");
const outFile = path.resolve(__dirname, "docs", "api.md");

function htmlTableToMarkdown($, table) {
  let md = "";
  const rows = $(table).find("tr");
  rows.each((i, row) => {
    const cells = $(row).find("th,td");
    let line = "|";
    cells.each((j, cell) => {
      line +=
        " " +
        $(cell).text().replace(/\n/g, " ").replace(/\s+/g, " ").trim() +
        " |";
    });
    md += line + "\n";
    if (i === 0) {
      // header separator
      md += "|" + " --- |".repeat(cells.length) + "\n";
    }
  });
  return md;
}

function extractApiName($) {
  // 尝试用 h1 或 title
  let name = $("h1").first().text().trim();
  if (!name) {
    name = $("title").text().trim();
  }
  if (name.startsWith("#")) {
    name = name.replace("#", "").trim();
  }
  return name || "未知API";
}

function extractApiDesc($) {
  // 尝试用 h2, h3, p, 或第一个 table 前的文本
  let desc = $("h2, h3, p").first().text().trim();
  if (!desc) {
    // 找到 table 前的文本节点
    const table = $("table").first();
    let prev = table.prev();
    while (prev.length && !desc) {
      if (prev.text()) desc = prev.text().trim();
      prev = prev.prev();
    }
  }
  return desc || "";
}

function processApiFile(filePath) {
  const html = fs.readFileSync(filePath, "utf-8");
  const $ = cheerio.load(html);
  const table = $("table").first();
  const name = extractApiName($);
  const desc = extractApiDesc($);
  if (!table.length) {
    return { name, desc, mdTable: null };
  }
  const mdTable = htmlTableToMarkdown($, table);
  return { name, desc, mdTable };
}

function main() {
  const files = fs.readdirSync(apiDir).filter((f) => f.endsWith(".html"));
  let md = "# 微信小游戏 API 整理\n\n";
  for (const file of files) {
    const filePath = path.join(apiDir, file);
    const api = processApiFile(filePath);
    md += `\n### ${api.name}\n\n`;
    if (api.mdTable) {
      if (api.desc) md += api.desc + "\n\n";
      md += api.mdTable + "\n";
    } else {
      md += `[Link](api/${file})\n\n`;
    }
  }
  fs.writeFileSync(outFile, md, "utf-8");
  console.log("已生成", outFile);
}

main();
