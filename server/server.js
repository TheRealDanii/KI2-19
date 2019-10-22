const http = require("http");
const https = require("https");
const express = require("express");
const helmet = require("helmet");
const compression = require("compression");
const dotenv = require("dotenv");
const fs = require('fs');
const projects = require('./projects.json');

dotenv.config();

const domain = process.env.DOMAIN;

var app = express();
var httpApp = express();

httpApp.use((req, res) => {
  if (req.secure) {
    next();
  } else {
    res.redirect("https://" + req.hostname + req.url);
    res.end();
  }
});

app.use(helmet());
app.use(compression());

const setupProject = (name) => {
  app.use(`/${name}`, express.static(name));
  console.log(`[+] Pfad /${name} erstellt`);
}

projects.projects.forEach(project => {
  setupProject(project.path)
});

const options = {
  cert: fs.readFileSync(`/etc/letsencrypt/live/${domain}/fullchain.pem`),
  key: fs.readFileSync(`/etc/letsencrypt/live/${domain}/privkey.pem`)
};

const httpServer = http.createServer(httpApp);
const httpsServer = https.createServer(options, app);
httpServer.listen(80, function () {
  console.log(`HTTP Server is up and running ${domain}:80`);
});
httpsServer.listen(443, function () {
  console.log(`HTTPS Server is up and running ${domain}:443`);
});
