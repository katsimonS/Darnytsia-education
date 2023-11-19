define("EdlBook_FormPage", /**SCHEMA_DEPS*/["@darnytsia"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/(darnytsia)/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "Tabs",
				"values": {
					"styleType": "default",
					"mode": "tab",
					"bodyBackgroundColor": "primary-contrast-500",
					"selectedTabTitleColor": "auto",
					"tabTitleColor": "auto",
					"underlineSelectedTabColor": "auto",
					"headerBackgroundColor": "auto"
				}
			},
			{
				"operation": "merge",
				"name": "CardToggleTabPanel",
				"values": {
					"styleType": "default",
					"bodyBackgroundColor": "primary-contrast-500",
					"selectedTabTitleColor": "auto",
					"tabTitleColor": "auto",
					"underlineSelectedTabColor": "auto",
					"headerBackgroundColor": "auto"
				}
			},
			{
				"operation": "merge",
				"name": "Feed",
				"values": {
					"dataSourceName": "PDS",
					"entitySchemaName": "EdlBook"
				}
			},
			{
				"operation": "merge",
				"name": "AttachmentList",
				"values": {
					"columns": [
						{
							"id": "0b2b0090-e91d-4ceb-a89e-2ceee9bbaa1e",
							"code": "AttachmentListDS_Name",
							"caption": "#ResourceString(AttachmentListDS_Name)#",
							"dataValueType": 28,
							"width": 200
						}
					]
				}
			},
			{
				"operation": "insert",
				"name": "BookCase",
				"values": {
					"type": "crt.EntityStageProgressBar",
					"saveOnChange": false,
					"askUserToChangeSchema": true,
					"entityName": "EdlBook"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EdlBookTitle",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"label": "$Resources.Strings.EdlName",
					"control": "$EdlName",
					"labelPosition": "auto",
					"multiline": false,
					"readonly": "$IsEdlNameReadOnly",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EdlBookPublishDate",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.DateTimePicker",
					"label": "$Resources.Strings.DateTimeAttribute_0eayqho",
					"labelPosition": "auto",
					"control": "$DateTimeAttribute_0eayqho",
					"pickerType": "date",
					"visible": false,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "EdlBookStatus",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_m4r9pkj",
					"labelPosition": "auto",
					"control": "$LookupAttribute_m4r9pkj",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "addRecord_f6kqazw",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_f6kqazw_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "EdlBookStatus",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EdlBookCoverType",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_r6alyt3",
					"labelPosition": "auto",
					"control": "$LookupAttribute_r6alyt3",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "addRecord_hyfa5rs",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_hyfa5rs_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "EdlBookCoverType",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EdlBookPageCount",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.NumberInput",
					"label": "$Resources.Strings.NumberAttribute_o92iojb",
					"labelPosition": "auto",
					"control": "$NumberAttribute_o92iojb"
				},
				"parentName": "GeneralInfoTabContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EdlBookDescription",
				"values": {
					"type": "crt.Input",
					"label": "$Resources.Strings.StringAttribute_8shi1l8",
					"labelPosition": "auto",
					"control": "$StringAttribute_8shi1l8",
					"multiline": false
				},
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ExpansionPanel_yht711x",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(ExpansionPanel_yht711x_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": false,
					"titleWidth": 20,
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"fitContent": true
				},
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "GridContainer_6n3zcsl",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": 0
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": []
				},
				"parentName": "ExpansionPanel_yht711x",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_v476b3o",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "GridContainer_6n3zcsl",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridDetailAddBtn_i32abe0",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(GridDetailAddBtn_i32abe0_caption)#",
					"icon": "add-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.CreateRecordRequest",
						"params": {
							"entityName": "EdlBookAuthor",
							"defaultValues": [
								{
									"attributeName": "EdlBook",
									"value": "$Id"
								}
							]
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "FlexContainer_v476b3o",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridDetailRefreshBtn_bnza5sj",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(GridDetailRefreshBtn_bnza5sj_caption)#",
					"icon": "reload-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.LoadDataRequest",
						"params": {
							"config": {
								"loadType": "reload"
							},
							"dataSourceName": "GridDetail_l8d938fDS"
						}
					}
				},
				"parentName": "FlexContainer_v476b3o",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "GridDetailSettingsBtn_woptyhy",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(GridDetailSettingsBtn_woptyhy_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": []
				},
				"parentName": "FlexContainer_v476b3o",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "GridDetailExportDataBtn_lxqno2l",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(GridDetailExportDataBtn_lxqno2l_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "GridDetail_l8d938f"
						}
					}
				},
				"parentName": "GridDetailSettingsBtn_woptyhy",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridDetailImportDataBtn_mhps4nt",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(GridDetailImportDataBtn_mhps4nt_caption)#",
					"icon": "import-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "EdlEntity_144bccb"
						}
					}
				},
				"parentName": "GridDetailSettingsBtn_woptyhy",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "GridDetailSearchFilter_86ig2uq",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(GridDetailSearchFilter_86ig2uq_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"GridDetail_l8d938f"
					]
				},
				"parentName": "FlexContainer_v476b3o",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "GridContainer_u8zmdfp",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": 0
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": []
				},
				"parentName": "ExpansionPanel_yht711x",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EdlBookAuthor",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"selectedRows": "$GridDetail_l8d938f_SelectedRows",
					"_filterOptions": {
						"expose": [],
						"from": "GridDetail_l8d938f_SelectedRows"
					},
					"items": "$GridDetail_l8d938f",
					"primaryColumnName": "GridDetail_l8d938fDS_Id",
					"columns": [
						{
							"id": "6d6cf754-f3cf-93c8-c45c-cc9424c17ca5",
							"code": "GridDetail_l8d938fDS_EdlName",
							"caption": "#ResourceString(GridDetail_l8d938fDS_EdlName)#",
							"dataValueType": 28
						},
						{
							"id": "1705b4f8-3c4e-6ba6-032a-b61f14b3d31c",
							"code": "GridDetail_l8d938fDS_EdlAuthor",
							"path": "EdlAuthor",
							"caption": "#ResourceString(GridDetail_l8d938fDS_EdlAuthor)#",
							"dataValueType": 10,
							"referenceSchemaName": "Contact"
						},
						{
							"id": "44b3f3f4-c5d7-344d-b937-f7e341acf674",
							"code": "GridDetail_l8d938fDS_EdlBook",
							"path": "EdlBook",
							"caption": "#ResourceString(GridDetail_l8d938fDS_EdlBook)#",
							"dataValueType": 10,
							"referenceSchemaName": "EdlBook"
						}
					]
				},
				"parentName": "GridContainer_u8zmdfp",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"Id": {
					"modelConfig": {
						"path": "PDS.Id"
					}
				},
				"IsEdlNameReadOnly": {
					"value": true
				},
				"EdlName": {
					"modelConfig": {
						"path": "PDS.EdlName"
					}
				},
				"DateTimeAttribute_0eayqho": {
					"modelConfig": {
						"path": "PDS.EdlBookPublishDate"
					}
				},
				"NumberAttribute_o92iojb": {
					"modelConfig": {
						"path": "PDS.EdlBookPageCount"
					},
					"validators": {
						"CountValidator": {
							"type": "usr.DGValidator",
							"params": {
								"maxValue": 5000,
								"message": "#ResourceString(PageCount)#"
							}
						}
					}
				},
				"StringAttribute_8shi1l8": {
					"modelConfig": {
						"path": "PDS.EdlBookDescription"
					}
				},
				"LookupAttribute_m4r9pkj": {
					"modelConfig": {
						"path": "PDS.EdlBookStatus"
					}
				},
				"LookupAttribute_r6alyt3": {
					"modelConfig": {
						"path": "PDS.EdlBookCoverType"
					}
				},
				"GridDetail_l8d938f": {
					"isCollection": true,
					"modelConfig": {
						"path": "GridDetail_l8d938fDS"
					},
					"viewModelConfig": {
						"attributes": {
							"GridDetail_l8d938fDS_EdlName": {
								"modelConfig": {
									"path": "GridDetail_l8d938fDS.EdlName"
								}
							},
							"GridDetail_l8d938fDS_EdlAuthor": {
								"modelConfig": {
									"path": "GridDetail_l8d938fDS.EdlAuthor"
								}
							},
							"GridDetail_l8d938fDS_EdlBook": {
								"modelConfig": {
									"path": "GridDetail_l8d938fDS.EdlBook"
								}
							},
							"GridDetail_l8d938fDS_Id": {
								"modelConfig": {
									"path": "GridDetail_l8d938fDS.Id"
								}
							}
						}
					}
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"PDS": {
					"type": "crt.EntityDataSource",
					"config": {
						"entitySchemaName": "EdlBook"
					},
					"scope": "page"
				},
				"GridDetail_l8d938fDS": {
					"type": "crt.EntityDataSource",
					"scope": "viewElement",
					"config": {
						"entitySchemaName": "EdlBookAuthor",
						"attributes": {
							"EdlName": {
								"path": "EdlName"
							},
							"EdlAuthor": {
								"path": "EdlAuthor"
							},
							"EdlBook": {
								"path": "EdlBook"
							}
						}
					}
				}
			},
			"primaryDataSourceName": "PDS",
			"dependencies": {
				"GridDetail_l8d938fDS": [
					{
						"attributePath": "EdlBook",
						"relationPath": "PDS.Id"
					}
				]
			}
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/darnytsia.ui.pages.EdlBook_FormPage()/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{
			"usr.DGValidator": {
				validator: function (config) {
					return function (control) {
						let value = control.value;
						let maxValue = config.maxValue;
						let valueIsCorrect = value <= maxValue;
						var result;
						if (valueIsCorrect) {
							result = null;
						} else {
							result = {
								"usr.DGValidator": { 
									message: config.message
								}
							};
						}
						return result;
					};
				},
				params: [
					{
						name: "maxValue"
					},
					{
						name: "message"
					}
				],
				async: false
			}	
		}/**SCHEMA_VALIDATORS*/
	};
});