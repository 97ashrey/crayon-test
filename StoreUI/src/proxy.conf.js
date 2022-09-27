const PROXY_CONFIG = [
  {
    context: [
      "/products",
    ],
    target: "https://localhost:7289",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
