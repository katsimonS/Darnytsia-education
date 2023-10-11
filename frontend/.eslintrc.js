//To learn more about rules see https://typescript-eslint.io/rules/

module.exports = {
  env: {
    browser: true,
    es6: true
  },
  ignorePatterns: [
    "@darnytsia/entities/*.ts",
    "index.ts",
    "*.js"
  ],
  globals: {
    __dirname: "readonly",
    require: "readonly",
    module: "readonly"
  },
  extends: [
    "eslint:recommended",
    "plugin:@typescript-eslint/recommended",
    "../.eslintrc.js"
  ],
  plugins: ["@typescript-eslint"],
  parser: "@typescript-eslint/parser",
  parserOptions: {
    ecmaVersion: "latest",
    sourceType: "module",
    tsconfigRootDir: __dirname,
    project: "./tsconfig.json"
  },
  overrides: [{ files: ["*.ts"] }],
  rules: {
    //#region Supported

    "@typescript-eslint/array-type": [
      "error",
      { default: "generic" }
    ],
    "@typescript-eslint/ban-tslint-comment": "warn",
    "@typescript-eslint/ban-types": "off",
    "@typescript-eslint/class-literal-property-style": [
      "error",
      "fields"
    ],
    "@typescript-eslint/consistent-indexed-object-style": "error",
    "@typescript-eslint/consistent-type-definitions": "error",
    "@typescript-eslint/consistent-type-exports": "error",
    "@typescript-eslint/explicit-function-return-type": ["warn"],
    "@typescript-eslint/explicit-member-accessibility": ["error"],
    "no-unused-vars": "off",
    "@typescript-eslint/no-unused-vars": [
      "warn",
      {
        argsIgnorePattern: "^_",
        varsIgnorePattern: "^_",
        caughtErrorsIgnorePattern: "^_"
      }
    ],
    "@typescript-eslint/member-delimiter-style": [
      "error",
      {
        multiline: {
          delimiter: "semi",
          requireLast: false
        },
        singleline: {
          delimiter: "comma",
          requireLast: false
        },
        overrides: {
          interface: {
            multiline: {
              delimiter: "none"
            },
            singleline: {
              delimiter: "comma"
            }
          },
          typeLiteral: {
            multiline: {
              delimiter: "none"
            },
            singleline: {
              delimiter: "comma"
            }
          }
        }
      }
    ],
    "@typescript-eslint/method-signature-style": [
      "error",
      "method"
    ],
    "@typescript-eslint/no-empty-interface": ["off"],
    "@typescript-eslint/no-explicit-any": ["off"],
    "@typescript-eslint/no-non-null-asserted-nullish-coalescing": "warn",
    "@typescript-eslint/no-namespace": ["off"],
    "@typescript-eslint/prefer-for-of": ["error"],
    "@typescript-eslint/prefer-literal-enum-member": ["error"],
    "@typescript-eslint/prefer-optional-chain": ["error"],
    "@typescript-eslint/unified-signatures": ["error"],
    "@typescript-eslint/no-non-null-asserted-optional-chain": "off",
    "@typescript-eslint/no-non-null-assertion": "off",

    //#endregion

    //#region Extension

    "no-empty-function": "off",
    "@typescript-eslint/no-empty-function": "off",
    "no-extra-parens": ["off"],
    "@typescript-eslint/no-extra-parens": ["error"],
    "no-shadow": "off",
    "@typescript-eslint/no-shadow": [
      "error",
      { ignoreTypeValueShadow: true }
    ],
    "no-undef": "off",
    quotes: "off",
    "@typescript-eslint/quotes": [
      "error",
      "single"
    ]

    //#endregion
  }
};
