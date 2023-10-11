const CopyWebpackPlugin = require('copy-webpack-plugin');

const path = require("path");
const outDirJs = path.resolve(__dirname, "../Pkg/Darnytsia.Creatio/Files/src/js");
const outDirCss = path.resolve(__dirname, "../Pkg/Darnytsia.Creatio/Files/src/css");
const outDirLcz = path.resolve(__dirname, "../Pkg/Darnytsia.Creatio/Files/src/lcz");

module.exports = {
  entry: {
    "darnytsia": "./@darnytsia/index.ts"
  },
  mode: "development",
  module: {
    rules: [
      {
        test: /\.tsx?$/,
        loader: "ts-loader",
        options: { allowTsInNodeModules: true }
      }
    ]
  },
  resolve: {
    extensions: [".tsx", ".ts", ".js", ".json", ".svg"],
    alias: {
      lodash: path.resolve('./overrides/lodash.js'),
    }
  },
  output: {
    path: outDirJs,
    filename: "[name].js",
    libraryTarget: "amd"
  },
  devtool: 'source-map',
  plugins: [
    new CopyWebpackPlugin({
      patterns: [
        {
          from: 'node_modules/@edenlabllc/sdk/build'
        },
        {
          from: '**.json',
          context: '@darnytsia/lcz',
          to: outDirLcz
        },
        {
          from: 'overrides'
        }
      ]
    })
  ],
  watchOptions: {
    ignored: /node_modules/
  }
};
