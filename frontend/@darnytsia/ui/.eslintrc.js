//To learn more about rules see https://typescript-eslint.io/rules/

module.exports = {
  env: {
    browser: true,
    es6: true
  },
  extends: [
    "../../.eslintrc.js"
  ],
  overrides: [{ files: ["*.ts"] }],
  rules: {
    camelcase: [
      "off"
    ],
  }
};
