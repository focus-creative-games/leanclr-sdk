const fs = require("fs");
const path = require("path");

const apiDir = path.resolve(__dirname, "docs", "api");

fs.readdirSync(apiDir).forEach((file) => {
  if (file.endsWith("_html.html")) {
    const newName = file.replace("_html.html", ".html");
    const oldPath = path.join(apiDir, file);
    const newPath = path.join(apiDir, newName);
    fs.renameSync(oldPath, newPath);
    console.log(`重命名: ${file} -> ${newName}`);
  }
});
