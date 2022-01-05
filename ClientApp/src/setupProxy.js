const createProxyMiddleware = require('http-proxy-middleware');
const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT
  ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}`
  : env.ASPNETCORE_URLS
  ? env.ASPNETCORE_URLS.split(';')[0]
  : 'http://localhost:60774';

module.exports = function (app) {
  app.use(
    '/cat',
    createProxyMiddleware({
      target: target,
      changeOrigin: true,
      secure: false,
    })
  );
};
