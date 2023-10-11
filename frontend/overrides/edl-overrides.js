define('edl-overrides', [], function() {
  Ext.define("Edenlab.EntitySchemaQuery", {
    override: "Terrasoft.EntitySchemaQuery",

    async queryAsync() {
      return new Promise(resolve => this.execute(response => resolve(response), this));
    }
  });

  Ext.define("Edenlab.FilterGroup", {
    override: "Terrasoft.FilterGroup",

    addEqualsFilter(leftExpression, rightExpression, alias) {
      let filter = Terrasoft.createColumnFilterWithParameter(
        Terrasoft.ComparisonType.EQUAL, leftExpression, rightExpression);
      this._addFilterItem(filter, alias);
    },

    addNotEqualsFilter(leftExpression, rightExpression, alias) {
      let filter = Terrasoft.createColumnFilterWithParameter(
        Terrasoft.ComparisonType.NOT_EQUAL, leftExpression, rightExpression);
      this._addFilterItem(filter, alias);
    },

    addExistsFilter(columnPath, alias) {
      let filter = Terrasoft.createExistsFilter(columnPath);
      this._addFilterItem(filter, alias);
      return filter;
    },

    addNotExistsFilter(columnPath, alias) {
      let filter = Terrasoft.createNotExistsFilter(columnPath);
      this._addFilterItem(filter, alias);
      return filter;
    },

    _addFilterItem(filter, alias) {
      if (!!alias) {
        this.add(alias, filter);
      } else {
        this.addItem(filter);
      }
    }
  });

  Ext.define("Edenlab.LookupPage", {
    override: "Terrasoft.LookupPage",

    renderLookupControls: function(config, topPanelConfig) {
      const selectButtonConfig = topPanelConfig?.items?.find(x => x.id === "selectionControlsContainerLookupPage")
        ?.items?.find(x => x.tag === "SelectButton");
      if (selectButtonConfig) {
        selectButtonConfig.enabled = { bindTo: "isAnySelected" };
      }

      this.callParent(arguments);
    }
  });

  const excludedViewModelClassProperties = new Set([
    "attributes",
    "messages",
    "mixins",
    "diff",
    "businessRules",
    "details",
    "entitySchemaName"
  ]);

  Ext.define("Edenlab.ViewModelGenerator", {
    override: "Terrasoft.ViewModelGenerator",

    generate: function(config, callback, scope) {
      this.callParent([config, function (viewModelClass) {
        let tsScope = Array.isArray(config.hierarchy)
          ? config.hierarchy.filter(x => x.methods?.scope).at(-1)?.methods.scope
          : null;
        if (tsScope) {
          viewModelClass.tsScope = tsScope;
        }

        callback.call(scope, viewModelClass);
      }, this]);
    }
  });

  Ext.define("Edenlab.manager.ClientUnitSchema", {
    override: "Terrasoft.manager.ClientUnitSchema",

    areAllSchemaBusinessRulesValid: function () {
      return true;
    },

    validateSchemaMarkerComments: function () {
      return { success: true };
    }
  });

  Ext.define("Edenlab.BaseSchemaModule", {
    override: "Terrasoft.BaseSchemaModule",
    
    createViewModel: function (viewModelClass) {
      let viewModel = this.callParent(arguments);
      if (viewModelClass.tsScope) {
        const tsScope = Object.fromEntries(Object.entries(viewModelClass.tsScope)
          .filter(([ key ]) => !excludedViewModelClassProperties.has(key)));
        viewModel = Ext.apply(viewModel, tsScope);
      }
      return viewModel;
    }
  });

  Ext.define("Edenlab.configuration.DetailModule", {
    override: "Terrasoft.configuration.DetailModule",

    getViewModelConfig: function() {
      let viewModelConfig = this.callParent(arguments);
      Ext.apply(viewModelConfig.values, {
        IsReadOnly: this.detailInfo.isReadOnly
      });
      return viewModelConfig;
    }
  });
});
