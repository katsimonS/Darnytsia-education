require.config({
  paths: {
    "@darnytsia": Terrasoft.getFileContentUrl("Darnytsia.Creatio", "src/js/darnytsia.js"),
    "lodash": Terrasoft.getFileContentUrl("Darnytsia.Creatio", "src/js/lodash.js"),
    "edl-overrides": Terrasoft.getFileContentUrl("Darnytsia.Creatio", "src/js/edl-overrides.js"),
    "@lcz/uk-UA": Terrasoft.getFileContentUrl("Darnytsia.Creatio", "src/lcz/uk-UA.json"),
    "@lcz/en-US": Terrasoft.getFileContentUrl("Darnytsia.Creatio", "src/lcz/en-US.json")
  }
});

define(
  [
    "lodash",
    "edl-overrides",
    "@darnytsia"
  ],
  function(_, _, darnytsia) {
    darnytsia.configure();
  }
);
