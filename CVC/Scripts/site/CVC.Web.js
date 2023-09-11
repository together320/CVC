var alphanumericKeyboard = {
    'normal': [
        '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
        '{tab} q w e r t y u i o p [ ] \\',
        'a s d f g h j k l ; \' {accept}',
        '{shift} z x c v b n m , . / {shift}',
        ' {space} {left} {right} {cancel}'
    ],
    'shift': [
        '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
        '{tab} Q W E R T Y U I O P { } |',
        'A S D F G H J K L : " {accept}',
        '{shift} Z X C V B N M < > ? {shift}', 
        ' {space} {left} {right} {cancel}'
    ]
};

var numricKeyboard = {
    'normal': [
        '7 8 9',
        '4 5 6',
        '1 2 3',
        '{bksp} 0 .',
        '{a} {c}'
    ]

};

var numricWithoutDecimalKeyboard = {
    'normal': [
        '7 8 9',
        '4 5 6',
        '1 2 3',
        '{bksp} 0',
        '{a} {c}'
    ]

};



var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLoginDetailsDialog = /** @class */ (function (_super) {
            __extends(UserLoginDetailsDialog, _super);
            function UserLoginDetailsDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Report.UserLoginDetailsForm(_this.idPrefix);
                return _this;
            }
            UserLoginDetailsDialog.prototype.getFormKey = function () { return Report.UserLoginDetailsForm.formKey; };
            UserLoginDetailsDialog.prototype.getIdProperty = function () { return Report.UserLoginDetailsRow.idProperty; };
            UserLoginDetailsDialog.prototype.getLocalTextPrefix = function () { return Report.UserLoginDetailsRow.localTextPrefix; };
            UserLoginDetailsDialog.prototype.getService = function () { return Report.UserLoginDetailsService.baseUrl; };
            UserLoginDetailsDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], UserLoginDetailsDialog);
            return UserLoginDetailsDialog;
        }(Serenity.EntityDialog));
        Report.UserLoginDetailsDialog = UserLoginDetailsDialog;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLoginDetailsGrid = /** @class */ (function (_super) {
            __extends(UserLoginDetailsGrid, _super);
            function UserLoginDetailsGrid(container) {
                return _super.call(this, container) || this;
            }
            UserLoginDetailsGrid.prototype.getColumnsKey = function () { return 'Report.UserLoginDetails'; };
            UserLoginDetailsGrid.prototype.getDialogType = function () { return Report.UserLoginDetailsDialog; };
            UserLoginDetailsGrid.prototype.getIdProperty = function () { return Report.UserLoginDetailsRow.idProperty; };
            UserLoginDetailsGrid.prototype.getLocalTextPrefix = function () { return Report.UserLoginDetailsRow.localTextPrefix; };
            UserLoginDetailsGrid.prototype.getService = function () { return Report.UserLoginDetailsService.baseUrl; };
            UserLoginDetailsGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], UserLoginDetailsGrid);
            return UserLoginDetailsGrid;
        }(Serenity.EntityGrid));
        Report.UserLoginDetailsGrid = UserLoginDetailsGrid;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var BatchLogDialog = /** @class */ (function (_super) {
            __extends(BatchLogDialog, _super);
            function BatchLogDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Report.BatchLogForm(_this.idPrefix);
                return _this;
            }
            BatchLogDialog.prototype.getFormKey = function () { return Report.BatchLogForm.formKey; };
            BatchLogDialog.prototype.getIdProperty = function () { return Report.BatchLogRow.idProperty; };
            BatchLogDialog.prototype.getLocalTextPrefix = function () { return Report.BatchLogRow.localTextPrefix; };
            BatchLogDialog.prototype.getNameProperty = function () { return Report.BatchLogRow.nameProperty; };
            BatchLogDialog.prototype.getService = function () { return Report.BatchLogService.baseUrl; };
            BatchLogDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], BatchLogDialog);
            return BatchLogDialog;
        }(Serenity.EntityDialog));
        Report.BatchLogDialog = BatchLogDialog;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var BatchLogGrid = /** @class */ (function (_super) {
            __extends(BatchLogGrid, _super);
            function BatchLogGrid(container) {
                return _super.call(this, container) || this;
            }
            BatchLogGrid.prototype.getColumnsKey = function () { return 'Report.BatchLog'; };
            BatchLogGrid.prototype.getDialogType = function () { return Report.BatchLogDialog; };
            BatchLogGrid.prototype.getIdProperty = function () { return Report.BatchLogRow.idProperty; };
            BatchLogGrid.prototype.getLocalTextPrefix = function () { return Report.BatchLogRow.localTextPrefix; };
            BatchLogGrid.prototype.getService = function () { return Report.BatchLogService.baseUrl; };
            BatchLogGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], BatchLogGrid);
            return BatchLogGrid;
        }(Serenity.EntityGrid));
        Report.BatchLogGrid = BatchLogGrid;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var BatchLogArchiveGrid = /** @class */ (function (_super) {
            __extends(BatchLogArchiveGrid, _super);
            function BatchLogArchiveGrid(container) {
                return _super.call(this, container) || this;
            }
            BatchLogArchiveGrid.prototype.getColumnsKey = function () { return 'Report.BatchLogArchive'; };
            BatchLogArchiveGrid.prototype.getDialogType = function () { return Report.BatchLogArchiveDialog; };
            BatchLogArchiveGrid.prototype.getIdProperty = function () { return Report.BatchLogArchiveRow.idProperty; };
            BatchLogArchiveGrid.prototype.getLocalTextPrefix = function () { return Report.BatchLogArchiveRow.localTextPrefix; };
            BatchLogArchiveGrid.prototype.getService = function () { return Report.BatchLogArchiveService.baseUrl; };
            BatchLogArchiveGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], BatchLogArchiveGrid);
            return BatchLogArchiveGrid;
        }(Serenity.EntityGrid));
        Report.BatchLogArchiveGrid = BatchLogArchiveGrid;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogDialog = /** @class */ (function (_super) {
            __extends(AuditLogDialog, _super);
            function AuditLogDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Report.AuditLogForm(_this.idPrefix);
                return _this;
            }
            AuditLogDialog.prototype.getFormKey = function () { return Report.AuditLogForm.formKey; };
            AuditLogDialog.prototype.getIdProperty = function () { return Report.AuditLogRow.idProperty; };
            AuditLogDialog.prototype.getLocalTextPrefix = function () { return Report.AuditLogRow.localTextPrefix; };
            AuditLogDialog.prototype.getNameProperty = function () { return Report.AuditLogRow.nameProperty; };
            AuditLogDialog.prototype.getService = function () { return Report.AuditLogService.baseUrl; };

            AuditLogDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], AuditLogDialog);
            return AuditLogDialog;
        }(Serenity.EntityDialog));
        Report.AuditLogDialog = AuditLogDialog;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogArchiveDialog = /** @class */ (function (_super) {
            __extends(AuditLogArchiveDialog, _super);
            function AuditLogArchiveDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Report.AuditLogArchiveForm(_this.idPrefix);
                return _this;
            }
            AuditLogArchiveDialog.prototype.getFormKey = function () { return Report.AuditLogArchiveForm.formKey; };
            AuditLogArchiveDialog.prototype.getIdProperty = function () { return Report.AuditLogArchiveRow.idProperty; };
            AuditLogArchiveDialog.prototype.getLocalTextPrefix = function () { return Report.AuditLogArchiveRow.localTextPrefix; };
            AuditLogArchiveDialog.prototype.getNameProperty = function () { return Report.AuditLogArchiveRow.nameProperty; };
            AuditLogArchiveDialog.prototype.getService = function () { return Report.AuditLogArchiveService.baseUrl; };

            AuditLogArchiveDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], AuditLogArchiveDialog);
            return AuditLogArchiveDialog;
        }(Serenity.EntityDialog));
        Report.AuditLogArchiveDialog = AuditLogArchiveDialog;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogGrid = /** @class */ (function (_super) {
            __extends(AuditLogGrid, _super);
            function AuditLogGrid(container) {
                return _super.call(this, container) || this;
            }
            AuditLogGrid.prototype.getColumnsKey = function () { return 'Report.AuditLog'; };
            AuditLogGrid.prototype.getDialogType = function () { return Report.AuditLogDialog; };
            AuditLogGrid.prototype.getIdProperty = function () { return Report.AuditLogRow.idProperty; };
            AuditLogGrid.prototype.getLocalTextPrefix = function () { return Report.AuditLogRow.localTextPrefix; };
            AuditLogGrid.prototype.getService = function () { return Report.AuditLogService.baseUrl; };
            AuditLogGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "add-button"; }), 1);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };

            AuditLogGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], AuditLogGrid);
            return AuditLogGrid;
        }(Serenity.EntityGrid));
        Report.AuditLogGrid = AuditLogGrid;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogArchiveGrid = /** @class */ (function (_super) {
            __extends(AuditLogArchiveGrid, _super);
            function AuditLogArchiveGrid(container) {
                return _super.call(this, container) || this;
            }
            AuditLogArchiveGrid.prototype.getColumnsKey = function () { return 'Report.AuditLogArchive'; };
            AuditLogArchiveGrid.prototype.getDialogType = function () { return Report.AuditLogArchiveDialog; };
            AuditLogArchiveGrid.prototype.getIdProperty = function () { return Report.AuditLogArchiveRow.idProperty; };
            AuditLogArchiveGrid.prototype.getLocalTextPrefix = function () { return Report.AuditLogArchiveRow.localTextPrefix; };
            AuditLogArchiveGrid.prototype.getService = function () { return Report.AuditLogArchiveService.baseUrl; };
            AuditLogArchiveGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "add-button"; }), 1);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };

            AuditLogArchiveGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], AuditLogArchiveGrid);
            return AuditLogArchiveGrid;
        }(Serenity.EntityGrid));
        Report.AuditLogArchiveGrid = AuditLogArchiveGrid;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogDialog = /** @class */ (function (_super) {
            __extends(UserLogDialog, _super);
            function UserLogDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Report.UserLogForm(_this.idPrefix);
                return _this;
            }
            UserLogDialog.prototype.getFormKey = function () { return Report.UserLogForm.formKey; };
            UserLogDialog.prototype.getIdProperty = function () { return Report.UserLogRow.idProperty; };
            UserLogDialog.prototype.getLocalTextPrefix = function () { return Report.UserLogRow.localTextPrefix; };
            UserLogDialog.prototype.getNameProperty = function () { return Report.UserLogRow.nameProperty; };
            UserLogDialog.prototype.getService = function () { return Report.UserLogService.baseUrl; };

            UserLogDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], UserLogDialog);
            return UserLogDialog;
        }(Serenity.EntityDialog));
        Report.UserLogDialog = UserLogDialog;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));



var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogArchiveDialog = /** @class */ (function (_super) {
            __extends(UserLogArchiveDialog, _super);
            function UserLogArchiveDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Report.UserLogArchiveForm(_this.idPrefix);
                return _this;
            }
            UserLogArchiveDialog.prototype.getFormKey = function () { return Report.UserLogArchiveForm.formKey; };
            UserLogArchiveDialog.prototype.getIdProperty = function () { return Report.UserLogArchiveRow.idProperty; };
            UserLogArchiveDialog.prototype.getLocalTextPrefix = function () { return Report.UserLogArchiveRow.localTextPrefix; };
            UserLogArchiveDialog.prototype.getNameProperty = function () { return Report.UserLogArchiveRow.nameProperty; };
            UserLogArchiveDialog.prototype.getService = function () { return Report.UserLogArchiveService.baseUrl; };

            UserLogArchiveDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], UserLogArchiveDialog);
            return UserLogArchiveDialog;
        }(Serenity.EntityDialog));
        Report.UserLogArchiveDialog = UserLogArchiveDialog;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogGrid = /** @class */ (function (_super) {
            __extends(UserLogGrid, _super);
            function UserLogGrid(container) {
                return _super.call(this, container) || this;
            }
            UserLogGrid.prototype.getColumnsKey = function () { return 'Report.UserLog'; };
            UserLogGrid.prototype.getDialogType = function () { return Report.UserLogDialog; };
            UserLogGrid.prototype.getIdProperty = function () { return Report.UserLogRow.idProperty; };
            UserLogGrid.prototype.getLocalTextPrefix = function () { return Report.UserLogRow.localTextPrefix; };
            UserLogGrid.prototype.getService = function () { return Report.UserLogService.baseUrl; };
            UserLogGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "add-button"; }), 1);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };

            UserLogGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], UserLogGrid);
            return UserLogGrid;
        }(Serenity.EntityGrid));
        Report.UserLogGrid = UserLogGrid;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogArchiveGrid = /** @class */ (function (_super) {
            __extends(UserLogArchiveGrid, _super);
            function UserLogArchiveGrid(container) {
                return _super.call(this, container) || this;
            }
            UserLogArchiveGrid.prototype.getColumnsKey = function () { return 'Report.UserLogArchive'; };
            UserLogArchiveGrid.prototype.getDialogType = function () { return Report.UserLogArchiveDialog; };
            UserLogArchiveGrid.prototype.getIdProperty = function () { return Report.UserLogArchiveRow.idProperty; };
            UserLogArchiveGrid.prototype.getLocalTextPrefix = function () { return Report.UserLogArchiveRow.localTextPrefix; };
            UserLogArchiveGrid.prototype.getService = function () { return Report.UserLogArchiveService.baseUrl; };
            UserLogArchiveGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "add-button"; }), 1);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };

            UserLogArchiveGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], UserLogArchiveGrid);
            return UserLogArchiveGrid;
        }(Serenity.EntityGrid));
        Report.UserLogArchiveGrid = UserLogArchiveGrid;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogDialog = /** @class */ (function (_super) {
            __extends(AlarmLogDialog, _super);
            function AlarmLogDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Report.AlarmLogForm(_this.idPrefix);
                return _this;
            }
            AlarmLogDialog.prototype.getFormKey = function () { return Report.AlarmLogForm.formKey; };
            AlarmLogDialog.prototype.getIdProperty = function () { return Report.AlarmLogRow.idProperty; };
            AlarmLogDialog.prototype.getLocalTextPrefix = function () { return Report.AlarmLogRow.localTextPrefix; };
            AlarmLogDialog.prototype.getNameProperty = function () { return Report.AlarmLogRow.nameProperty; };
            AlarmLogDialog.prototype.getService = function () { return Report.AlarmLogService.baseUrl; };
            AlarmLogDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], AlarmLogDialog);
            return AlarmLogDialog;
        }(Serenity.EntityDialog));
        Report.AlarmLogDialog = AlarmLogDialog;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogArchiveDialog = /** @class */ (function (_super) {
            __extends(AlarmLogArchiveDialog, _super);
            function AlarmLogArchiveDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Report.AlarmLogArchiveForm(_this.idPrefix);
                return _this;
            }
            AlarmLogArchiveDialog.prototype.getFormKey = function () { return Report.AlarmLogArchiveForm.formKey; };
            AlarmLogArchiveDialog.prototype.getIdProperty = function () { return Report.AlarmLogArchiveRow.idProperty; };
            AlarmLogArchiveDialog.prototype.getLocalTextPrefix = function () { return Report.AlarmLogArchiveRow.localTextPrefix; };
            AlarmLogArchiveDialog.prototype.getNameProperty = function () { return Report.AlarmLogArchiveRow.nameProperty; };
            AlarmLogArchiveDialog.prototype.getService = function () { return Report.AlarmLogArchiveService.baseUrl; };
            AlarmLogArchiveDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], AlarmLogArchiveDialog);
            return AlarmLogArchiveDialog;
        }(Serenity.EntityDialog));
        Report.AlarmLogArchiveDialog = AlarmLogArchiveDialog;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogGrid = /** @class */ (function (_super) {
            __extends(AlarmLogGrid, _super);
            function AlarmLogGrid(container) {
                return _super.call(this, container) || this;
            }
            AlarmLogGrid.prototype.getColumnsKey = function () { return 'Report.AlarmLog'; };
            AlarmLogGrid.prototype.getDialogType = function () { return Report.AlarmLogDialog; };
            AlarmLogGrid.prototype.getIdProperty = function () { return Report.AlarmLogRow.idProperty; };
            AlarmLogGrid.prototype.getLocalTextPrefix = function () { return Report.AlarmLogRow.localTextPrefix; };
            AlarmLogGrid.prototype.getService = function () { return Report.AlarmLogService.baseUrl; };
            AlarmLogGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "add-button"; }), 1);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            AlarmLogGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], AlarmLogGrid);
            return AlarmLogGrid;
        }(Serenity.EntityGrid));
        Report.AlarmLogGrid = AlarmLogGrid;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        // alert("k");
        var va = $(".slick-cell l1 r1").html();
        // alert(va);
        var AlarmLogArchiveGrid = /** @class */ (function (_super) {
            __extends(AlarmLogArchiveGrid, _super);
            function AlarmLogArchiveGrid(container) {
                return _super.call(this, container) || this;
            }
            AlarmLogArchiveGrid.prototype.getColumnsKey = function () { return 'Report.AlarmLogArchive'; };
            AlarmLogArchiveGrid.prototype.getDialogType = function () { return Report.AlarmLogArchiveDialog; };
            AlarmLogArchiveGrid.prototype.getIdProperty = function () { return Report.AlarmLogArchiveRow.idProperty; };
            AlarmLogArchiveGrid.prototype.getLocalTextPrefix = function () { return Report.AlarmLogArchiveRow.localTextPrefix; };
            AlarmLogArchiveGrid.prototype.getService = function () { return Report.AlarmLogArchiveService.baseUrl; };
            AlarmLogArchiveGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "add-button"; }), 1);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            AlarmLogArchiveGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], AlarmLogArchiveGrid);
            return AlarmLogArchiveGrid;
        }(Serenity.EntityGrid));
        Report.AlarmLogArchiveGrid = AlarmLogArchiveGrid;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var TabletDetailsDialog = /** @class */ (function (_super) {
            __extends(TabletDetailsDialog, _super);
            function TabletDetailsDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new PackSettings.TabletDetailsForm(_this.idPrefix);
                return _this;
            }
            TabletDetailsDialog.prototype.getFormKey = function () { return PackSettings.TabletDetailsForm.formKey; };
            TabletDetailsDialog.prototype.getIdProperty = function () { return PackSettings.TabletDetailsRow.idProperty; };
            TabletDetailsDialog.prototype.getLocalTextPrefix = function () { return PackSettings.TabletDetailsRow.localTextPrefix; };
            TabletDetailsDialog.prototype.getNameProperty = function () { return PackSettings.TabletDetailsRow.nameProperty; };
            TabletDetailsDialog.prototype.getService = function () { return PackSettings.TabletDetailsService.baseUrl; };

            TabletDetailsDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            TabletDetailsDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            TabletDetailsDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };
            TabletDetailsDialog.prototype.onDialogOpen = function () {
                $("input[name='TabletStrength'],input[name='TabletLength'],input[name='TabletThickness'],input[name='TabletWidth']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '7 8 9',
                            '4 5 6',
                            '1 2 3',
                            '{bksp} 0',
                            '{a} {c}'
                        ]

                    }
                })

                $("input[name='TabletName']").keyboard({
                    usePreview: false,
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })
            }

            TabletDetailsDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], TabletDetailsDialog);
            return TabletDetailsDialog;
        }(Serenity.EntityDialog));
        PackSettings.TabletDetailsDialog = TabletDetailsDialog;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var TabletDetailsGrid = /** @class */ (function (_super) {
            __extends(TabletDetailsGrid, _super);
            function TabletDetailsGrid(container) {
                return _super.call(this, container) || this;
            }
            TabletDetailsGrid.prototype.getColumnsKey = function () { return 'PackSettings.TabletDetails'; };
            TabletDetailsGrid.prototype.getDialogType = function () { return PackSettings.TabletDetailsDialog; };
            TabletDetailsGrid.prototype.getIdProperty = function () { return PackSettings.TabletDetailsRow.idProperty; };
            TabletDetailsGrid.prototype.getLocalTextPrefix = function () { return PackSettings.TabletDetailsRow.localTextPrefix; };
            TabletDetailsGrid.prototype.getService = function () { return PackSettings.TabletDetailsService.baseUrl; };
            TabletDetailsGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnTabletDetailsImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),
                            //style: 'height:29px',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('tabletDetails');

                            },
                        }
                    );
                }
                return buttons;
            };
            TabletDetailsGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], TabletDetailsGrid);
            return TabletDetailsGrid;
        }(Serenity.EntityGrid));
        PackSettings.TabletDetailsGrid = TabletDetailsGrid;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var PackDialog = /** @class */ (function (_super) {
            __extends(PackDialog, _super);
            function PackDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new PackSettings.PackForm(_this.idPrefix);
                return _this;
            }
            PackDialog.prototype.getFormKey = function () { return PackSettings.PackForm.formKey; };
            PackDialog.prototype.getIdProperty = function () { return PackSettings.PackRow.idProperty; };
            PackDialog.prototype.getLocalTextPrefix = function () { return PackSettings.PackRow.localTextPrefix; };
            PackDialog.prototype.getNameProperty = function () { return PackSettings.PackRow.nameProperty; };
            PackDialog.prototype.getService = function () { return PackSettings.PackService.baseUrl; };

            PackDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            PackDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            PackDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };


            PackDialog.prototype.onDialogOpen = function () {
                $("input[name='TabletCount'],input[name='NumberOfCottonPieces'],input[name='CottonLength'],input[name='NumberOfDesicantPieces']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '7 8 9',
                            '4 5 6',
                            '1 2 3',
                            '{bksp} 0',
                            '{a} {c}'
                        ]

                    }
                })


                $("input[name='PackName']").keyboard({
                    usePreview: false,
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })
            }


            PackDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], PackDialog);
            return PackDialog;
        }(Serenity.EntityDialog));
        PackSettings.PackDialog = PackDialog;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var PackGrid = /** @class */ (function (_super) {
            __extends(PackGrid, _super);
            function PackGrid(container) {
                return _super.call(this, container) || this;
            }
            PackGrid.prototype.getColumnsKey = function () { return 'PackSettings.Pack'; };
            PackGrid.prototype.getDialogType = function () { return PackSettings.PackDialog; };
            PackGrid.prototype.getIdProperty = function () { return PackSettings.PackRow.idProperty; };
            PackGrid.prototype.getLocalTextPrefix = function () { return PackSettings.PackRow.localTextPrefix; };
            PackGrid.prototype.getService = function () { return PackSettings.PackService.baseUrl; };
            PackGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnPackImportAccess").val() =="True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //cssClass: 'stampe',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('pack');
                            }
                        });
                }

                return buttons;
            };
            PackGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], PackGrid);
            return PackGrid;
        }(Serenity.EntityGrid));
        PackSettings.PackGrid = PackGrid;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var OutsertDialog = /** @class */ (function (_super) {
            __extends(OutsertDialog, _super);
            function OutsertDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new PackSettings.OutsertForm(_this.idPrefix);
                return _this;
            }
            OutsertDialog.prototype.getFormKey = function () { return PackSettings.OutsertForm.formKey; };
            OutsertDialog.prototype.getIdProperty = function () { return PackSettings.OutsertRow.idProperty; };
            OutsertDialog.prototype.getLocalTextPrefix = function () { return PackSettings.OutsertRow.localTextPrefix; };
            OutsertDialog.prototype.getNameProperty = function () { return PackSettings.OutsertRow.nameProperty; };
            OutsertDialog.prototype.getService = function () { return PackSettings.OutsertService.baseUrl; };

            OutsertDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            OutsertDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            OutsertDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };
            OutsertDialog.prototype.onDialogOpen = function () {
                $("input[name='OutsertName']").keyboard({
                    usePreview: false,
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })

                $("input[name='OutsertLength'],input[name='OutsertWidth'],input[name='OutsertThickness']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '7 8 9',
                            '4 5 6',
                            '1 2 3',
                            '{bksp} 0',
                            '{a} {c}'
                        ]

                    }
                })

            }

            OutsertDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], OutsertDialog);
            return OutsertDialog;
        }(Serenity.EntityDialog));
        PackSettings.OutsertDialog = OutsertDialog;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var OutsertGrid = /** @class */ (function (_super) {
            __extends(OutsertGrid, _super);
            function OutsertGrid(container) {
                return _super.call(this, container) || this;
            }
            OutsertGrid.prototype.getColumnsKey = function () { return 'PackSettings.Outsert'; };
            OutsertGrid.prototype.getDialogType = function () { return PackSettings.OutsertDialog; };
            OutsertGrid.prototype.getIdProperty = function () { return PackSettings.OutsertRow.idProperty; };
            OutsertGrid.prototype.getLocalTextPrefix = function () { return PackSettings.OutsertRow.localTextPrefix; };
            OutsertGrid.prototype.getService = function () { return PackSettings.OutsertService.baseUrl; };
            OutsertGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnOutsertImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            // cssClass: 'stampe',
                            // icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('outsert');
                            }
                        });
                }

                return buttons;
            };
            OutsertGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], OutsertGrid);
            return OutsertGrid;
        }(Serenity.EntityGrid));
        PackSettings.OutsertGrid = OutsertGrid;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var LabelDialog = /** @class */ (function (_super) {
            __extends(LabelDialog, _super);
            function LabelDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new PackSettings.LabelForm(_this.idPrefix);
                return _this;
            }
            LabelDialog.prototype.getFormKey = function () { return PackSettings.LabelForm.formKey; };
            LabelDialog.prototype.getIdProperty = function () { return PackSettings.LabelRow.idProperty; };
            LabelDialog.prototype.getLocalTextPrefix = function () { return PackSettings.LabelRow.localTextPrefix; };
            LabelDialog.prototype.getNameProperty = function () { return PackSettings.LabelRow.nameProperty; };
            LabelDialog.prototype.getService = function () { return PackSettings.LabelService.baseUrl; };

            LabelDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            LabelDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            LabelDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };

            LabelDialog.prototype.onDialogOpen = function () {
                $("input[name='LabelName'],input[name='LabelType']").keyboard({
                    usePreview: false,
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })

                $("input[name='LabelHeight'],input[name='LabelLength']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '7 8 9',
                            '4 5 6',
                            '1 2 3',
                            '{bksp} 0',
                            '{a} {c}'
                        ]

                    }
                })
            }

            LabelDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], LabelDialog);
            return LabelDialog;
        }(Serenity.EntityDialog));
        PackSettings.LabelDialog = LabelDialog;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var LabelGrid = /** @class */ (function (_super) {
            __extends(LabelGrid, _super);
            function LabelGrid(container) {
                return _super.call(this, container) || this;
            }
            LabelGrid.prototype.getColumnsKey = function () { return 'PackSettings.Label'; };
            LabelGrid.prototype.getDialogType = function () { return PackSettings.LabelDialog; };
            LabelGrid.prototype.getIdProperty = function () { return PackSettings.LabelRow.idProperty; };
            LabelGrid.prototype.getLocalTextPrefix = function () { return PackSettings.LabelRow.localTextPrefix; };
            LabelGrid.prototype.getService = function () { return PackSettings.LabelService.baseUrl; };
            LabelGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnLabelImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            // cssClass: 'stampe',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('label');
                            }
                        });

                }

                return buttons;
            };
            LabelGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], LabelGrid);
            return LabelGrid;
        }(Serenity.EntityGrid));
        PackSettings.LabelGrid = LabelGrid;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var EndOfLineDialog = /** @class */ (function (_super) {
            __extends(EndOfLineDialog, _super);
            function EndOfLineDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new PackSettings.EndOfLineForm(_this.idPrefix);
                return _this;
            }
            EndOfLineDialog.prototype.getFormKey = function () { return PackSettings.EndOfLineForm.formKey; };
            EndOfLineDialog.prototype.getIdProperty = function () { return PackSettings.EndOfLineRow.idProperty; };
            EndOfLineDialog.prototype.getLocalTextPrefix = function () { return PackSettings.EndOfLineRow.localTextPrefix; };
            EndOfLineDialog.prototype.getNameProperty = function () { return PackSettings.EndOfLineRow.nameProperty; };
            EndOfLineDialog.prototype.getService = function () { return PackSettings.EndOfLineService.baseUrl; };

            EndOfLineDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            EndOfLineDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            EndOfLineDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };
            
            EndOfLineDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], EndOfLineDialog);
            return EndOfLineDialog;
        }(Serenity.EntityDialog));
        PackSettings.EndOfLineDialog = EndOfLineDialog;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var EndOfLineGrid = /** @class */ (function (_super) {
            __extends(EndOfLineGrid, _super);
            function EndOfLineGrid(container) {
                return _super.call(this, container) || this;
            }
            EndOfLineGrid.prototype.getColumnsKey = function () { return 'PackSettings.EndOfLine'; };
            EndOfLineGrid.prototype.getDialogType = function () { return PackSettings.EndOfLineDialog; };
            EndOfLineGrid.prototype.getIdProperty = function () { return PackSettings.EndOfLineRow.idProperty; };
            EndOfLineGrid.prototype.getLocalTextPrefix = function () { return PackSettings.EndOfLineRow.localTextPrefix; };
            EndOfLineGrid.prototype.getService = function () { return PackSettings.EndOfLineService.baseUrl; };
            EndOfLineGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnEndOfLineImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            // cssClass: 'stampe',
                            // icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('endOfLine');
                            }
                        });

                }
                return buttons;
            };
            EndOfLineGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], EndOfLineGrid);
            return EndOfLineGrid;
        }(Serenity.EntityGrid));
        PackSettings.EndOfLineGrid = EndOfLineGrid;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var DesiccantDialog = /** @class */ (function (_super) {
            __extends(DesiccantDialog, _super);
            function DesiccantDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new PackSettings.DesiccantForm(_this.idPrefix);
                return _this;
            }
            DesiccantDialog.prototype.getFormKey = function () { return PackSettings.DesiccantForm.formKey; };
            DesiccantDialog.prototype.getIdProperty = function () { return PackSettings.DesiccantRow.idProperty; };
            DesiccantDialog.prototype.getLocalTextPrefix = function () { return PackSettings.DesiccantRow.localTextPrefix; };
            DesiccantDialog.prototype.getNameProperty = function () { return PackSettings.DesiccantRow.nameProperty; };
            DesiccantDialog.prototype.getService = function () { return PackSettings.DesiccantService.baseUrl; };


            DesiccantDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };

           

            DesiccantDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            DesiccantDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };
            DesiccantDialog.prototype.onDialogOpen = function () {
                $("input[name='Grammage'],input[name='LengthOrHeight'],input[name='DiameterOrWidth']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '7 8 9',
                            '4 5 6',
                            '1 2 3',
                            '{bksp} 0',
                            '{a} {c}'
                        ]

                    }
                })

                $("input[name='DesiccantName']").keyboard({
                    usePreview: false,
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })

            }

            DesiccantDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], DesiccantDialog);
            return DesiccantDialog;
        }(Serenity.EntityDialog));
        PackSettings.DesiccantDialog = DesiccantDialog;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var DesiccantGrid = /** @class */ (function (_super) {
            __extends(DesiccantGrid, _super);
            function DesiccantGrid(container) {
                return _super.call(this, container) || this;
            }
            DesiccantGrid.prototype.getColumnsKey = function () { return 'PackSettings.Desiccant'; };
            DesiccantGrid.prototype.getDialogType = function () { return PackSettings.DesiccantDialog; };
            DesiccantGrid.prototype.getIdProperty = function () { return PackSettings.DesiccantRow.idProperty; };
            DesiccantGrid.prototype.getLocalTextPrefix = function () { return PackSettings.DesiccantRow.localTextPrefix; };
            DesiccantGrid.prototype.getService = function () { return PackSettings.DesiccantService.baseUrl; };
            DesiccantGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));

                if ($("#hdnDesiccantImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //cssClass: 'stampe',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('desiccant');
                            }
                        });
                }
                return buttons;
            };
            DesiccantGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], DesiccantGrid);
            return DesiccantGrid;
        }(Serenity.EntityGrid));
        PackSettings.DesiccantGrid = DesiccantGrid;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var CottonDialog = /** @class */ (function (_super) {
            __extends(CottonDialog, _super);
            function CottonDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new PackSettings.CottonForm(_this.idPrefix);
                return _this;
            }
            CottonDialog.prototype.getFormKey = function () { return PackSettings.CottonForm.formKey; };
            CottonDialog.prototype.getIdProperty = function () { return PackSettings.CottonRow.idProperty; };
            CottonDialog.prototype.getLocalTextPrefix = function () { return PackSettings.CottonRow.localTextPrefix; };
            CottonDialog.prototype.getNameProperty = function () { return PackSettings.CottonRow.nameProperty; };
            CottonDialog.prototype.getService = function () { return PackSettings.CottonService.baseUrl; };

            CottonDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            CottonDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            CottonDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };

            CottonDialog.prototype.onDialogOpen = function () {
                $("input[name='GmOrYard']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '7 8 9',
                            '4 5 6',
                            '1 2 3',
                            '{bksp} 0',
                            '{a} {c}'
                        ]

                    }
                })

                $("input[name='CottonName']").keyboard({
                    usePreview: false,
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })
            }

            CottonDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], CottonDialog);
            return CottonDialog;
        }(Serenity.EntityDialog));
        PackSettings.CottonDialog = CottonDialog;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var CottonGrid = /** @class */ (function (_super) {
            __extends(CottonGrid, _super);
            function CottonGrid(container) {
                return _super.call(this, container) || this;
            }
            CottonGrid.prototype.getColumnsKey = function () { return 'PackSettings.Cotton'; };
            CottonGrid.prototype.getDialogType = function () { return PackSettings.CottonDialog; };
            CottonGrid.prototype.getIdProperty = function () { return PackSettings.CottonRow.idProperty; };
            CottonGrid.prototype.getLocalTextPrefix = function () { return PackSettings.CottonRow.localTextPrefix; };
            CottonGrid.prototype.getService = function () { return PackSettings.CottonService.baseUrl; };
            CottonGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnCottonImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //style: 'height:29px',
                            // icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('cotton');

                            },
                        }
                    );
                }
                return buttons;
            };
            CottonGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], CottonGrid);
            return CottonGrid;
        }(Serenity.EntityGrid));
        PackSettings.CottonGrid = CottonGrid;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var CapDialog = /** @class */ (function (_super) {
            __extends(CapDialog, _super);
            function CapDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new PackSettings.CapForm(_this.idPrefix);
                return _this;
            }
            CapDialog.prototype.getFormKey = function () { return PackSettings.CapForm.formKey; };
            CapDialog.prototype.getIdProperty = function () { return PackSettings.CapRow.idProperty; };
            CapDialog.prototype.getLocalTextPrefix = function () { return PackSettings.CapRow.localTextPrefix; };
            CapDialog.prototype.getNameProperty = function () { return PackSettings.CapRow.nameProperty; };
            CapDialog.prototype.getService = function () { return PackSettings.CapService.baseUrl; };

            CapDialog.prototype.onSaveSuccess = function (response) {
                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }
                this.dialogClose();
            };


            CapDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            CapDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
              
                   



            };
            CapDialog.prototype.onDialogOpen = function () {
             
                    $("input[name='CapCc'],input[name='CapDiameter'],input[name='CapHeight']").keyboard({
                        layout: 'custom',
                        customLayout: {
                            'normal': [
                                '7 8 9',
                                '4 5 6',
                                '1 2 3',
                                '{bksp} 0',
                                '{a} {c}'
                            ]

                        }        

                    })

                    $("input[name='CapName']").keyboard({
                        usePreview: false,
                        layout: 'custom',
                        customLayout: {
                            'normal': [
                                '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                                '{tab} q w e r t y u i o p [ ] \\',
                                'a s d f g h j k l ; \' {accept}',
                                '{shift} z x c v b n m , . / {shift}',
                                ' {space} {left} {right} {cancel}'
                            ],
                            'shift': [
                                '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                                '{tab} Q W E R T Y U I O P { } |',
                                'A S D F G H J K L : " {accept}',
                                '{shift} Z X C V B N M < > ? {shift}',
                                ' {space} {left} {right} {cancel}'
                            ]
                        },

                    })
               
            }

            //CapDialog.prototype.afterLoadEntity = function () {
            //    _super.prototype.afterLoadEntity.call(this);

            //    $("input:text").keyboard({
            //        usePreview: false,
            //        layout: 'custom',
            //        customLayout: {
            //            'normal': [
            //                '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
            //                '{tab} q w e r t y u i o p [ ] \\',
            //                'a s d f g h j k l ; \' {accept}',
            //                '{shift} z x c v b n m , . / {shift}',
            //                ' {space} {left} {right} {cancel}'
            //            ],
            //            'shift': [
            //                '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
            //                '{tab} Q W E R T Y U I O P { } |',
            //                'A S D F G H J K L : " {accept}',
            //                '{shift} Z X C V B N M < > ? {shift}',
            //                ' {space} {left} {right} {cancel}'
            //            ]
            //        },

            //    })
            //}

            CapDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], CapDialog);
            return CapDialog;
        }(Serenity.EntityDialog));
        PackSettings.CapDialog = CapDialog;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var CapGrid = /** @class */ (function (_super) {
            __extends(CapGrid, _super);
            function CapGrid(container) {
                return _super.call(this, container) || this;
            }
            CapGrid.prototype.getColumnsKey = function () { return 'PackSettings.Cap'; };
            CapGrid.prototype.getDialogType = function () { return PackSettings.CapDialog; };
            CapGrid.prototype.getIdProperty = function () { return PackSettings.CapRow.idProperty; };
            CapGrid.prototype.getLocalTextPrefix = function () { return PackSettings.CapRow.localTextPrefix; };
            CapGrid.prototype.getService = function () { return PackSettings.CapService.baseUrl; };
            CapGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnCapImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            // cssClass: 'stampe',
                            // icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('cap');
                            }
                        });
                }
                return buttons;
            };
            CapGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], CapGrid);
            return CapGrid;
        }(Serenity.EntityGrid));
        PackSettings.CapGrid = CapGrid;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var BottleDialog = /** @class */ (function (_super) {
            __extends(BottleDialog, _super);
            function BottleDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new PackSettings.BottleForm(_this.idPrefix);
                return _this;
            }
            BottleDialog.prototype.getFormKey = function () { return PackSettings.BottleForm.formKey; };
            BottleDialog.prototype.getIdProperty = function () { return PackSettings.BottleRow.idProperty; };
            BottleDialog.prototype.getLocalTextPrefix = function () { return PackSettings.BottleRow.localTextPrefix; };
            BottleDialog.prototype.getNameProperty = function () { return PackSettings.BottleRow.nameProperty; };
            BottleDialog.prototype.getService = function () { return PackSettings.BottleService.baseUrl; };

            BottleDialog.prototype.onSavSuccess = function (response) {

                    if (response.IsStatus) {
                        $("#infoModalBody").text(response.Data)
                        $("#modal-info").modal('show');
                    }
                    else {
                        Q.notifySuccess("Record Saved Successfully");
                    }

              
                this.dialogClose();


            };

         


            BottleDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            BottleDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                //this.toolbar.findButton("delete-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };

            BottleDialog.prototype.onDialogOpen = function () {
            
                    $("input[name='BottleCc'],input[name='BottleDiameter'],input[name='BottleHeight'],input[name='BottleMouthOpeningId'],input[name='BottleMouthOpeningOd']").keyboard({
                        layout: 'custom',
                        customLayout: {
                            'normal': [
                                '7 8 9',
                                '4 5 6',
                                '1 2 3',
                                '{bksp} 0',
                                '{a} {c}'
                            ]

                        }                  
                    })

                    $("input[name='BottleName']").keyboard({
                        usePreview: false,
                        layout: 'custom',
                        customLayout: {
                            'normal': [
                                '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                                '{tab} q w e r t y u i o p [ ] \\',
                                'a s d f g h j k l ; \' {accept}',
                                '{shift} z x c v b n m , . / {shift}',
                                ' {space} {left} {right} {cancel}'
                            ],
                            'shift': [
                                '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                                '{tab} Q W E R T Y U I O P { } |',
                                'A S D F G H J K L : " {accept}',
                                '{shift} Z X C V B N M < > ? {shift}',
                                ' {space} {left} {right} {cancel}'
                            ]
                        },

                    })
                    
            }

            BottleDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], BottleDialog);
            return BottleDialog;
        }(Serenity.EntityDialog));
        PackSettings.BottleDialog = BottleDialog;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var BottleGrid = /** @class */ (function (_super) {
            __extends(BottleGrid, _super);
            function BottleGrid(container) {
                return _super.call(this, container) || this;
            }

            BottleGrid.prototype.getColumnsKey = function () { return 'PackSettings.Bottle'; };
            BottleGrid.prototype.getDialogType = function () { return PackSettings.BottleDialog; };
            BottleGrid.prototype.getIdProperty = function () { return PackSettings.BottleRow.idProperty; };
            BottleGrid.prototype.getLocalTextPrefix = function () { return PackSettings.BottleRow.localTextPrefix; };
            BottleGrid.prototype.getService = function () {
             //   console.log(response);
                return PackSettings.BottleService.baseUrl;
            };


            BottleGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));

                if ($("#hdnBottleImportAccess").val() == "True") {
                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            // cssClass: 'stampe',
                            // icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('bottle');
                            }
                        });
                }
                return buttons;
            };





            BottleGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], BottleGrid);

            return BottleGrid;
        }(Serenity.EntityGrid));
        PackSettings.BottleGrid = BottleGrid;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ViewsDialog = /** @class */ (function (_super) {
            __extends(ViewsDialog, _super);
            function ViewsDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new ModuleManagement.ViewsForm(_this.idPrefix);
                return _this;
            }
            ViewsDialog.prototype.getFormKey = function () { return ModuleManagement.ViewsForm.formKey; };
            ViewsDialog.prototype.getIdProperty = function () { return ModuleManagement.ViewsRow.idProperty; };
            ViewsDialog.prototype.getLocalTextPrefix = function () { return ModuleManagement.ViewsRow.localTextPrefix; };
            ViewsDialog.prototype.getNameProperty = function () { return ModuleManagement.ViewsRow.nameProperty; };
            ViewsDialog.prototype.getService = function () { return ModuleManagement.ViewsService.baseUrl; };
            ViewsDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], ViewsDialog);
            return ViewsDialog;
        }(Serenity.EntityDialog));
        ModuleManagement.ViewsDialog = ViewsDialog;
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ViewsGrid = /** @class */ (function (_super) {
            __extends(ViewsGrid, _super);
            function ViewsGrid(container) {
                return _super.call(this, container) || this;
            }
            ViewsGrid.prototype.getColumnsKey = function () { return 'ModuleManagement.Views'; };
            ViewsGrid.prototype.getDialogType = function () { return ModuleManagement.ViewsDialog; };
            ViewsGrid.prototype.getIdProperty = function () { return ModuleManagement.ViewsRow.idProperty; };
            ViewsGrid.prototype.getLocalTextPrefix = function () { return ModuleManagement.ViewsRow.localTextPrefix; };
            ViewsGrid.prototype.getService = function () { return ModuleManagement.ViewsService.baseUrl; };
            ViewsGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ViewsGrid);
            return ViewsGrid;
        }(Serenity.EntityGrid));
        ModuleManagement.ViewsGrid = ViewsGrid;
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ViewFieldDialog = /** @class */ (function (_super) {
            __extends(ViewFieldDialog, _super);
            function ViewFieldDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new ModuleManagement.ViewFieldForm(_this.idPrefix);
                return _this;
            }
            ViewFieldDialog.prototype.getFormKey = function () { return ModuleManagement.ViewFieldForm.formKey; };
            ViewFieldDialog.prototype.getIdProperty = function () { return ModuleManagement.ViewFieldRow.idProperty; };
            ViewFieldDialog.prototype.getLocalTextPrefix = function () { return ModuleManagement.ViewFieldRow.localTextPrefix; };
            ViewFieldDialog.prototype.getNameProperty = function () { return ModuleManagement.ViewFieldRow.nameProperty; };
            ViewFieldDialog.prototype.getService = function () { return ModuleManagement.ViewFieldService.baseUrl; };
            ViewFieldDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], ViewFieldDialog);
            return ViewFieldDialog;
        }(Serenity.EntityDialog));
        ModuleManagement.ViewFieldDialog = ViewFieldDialog;
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ViewFieldGrid = /** @class */ (function (_super) {
            __extends(ViewFieldGrid, _super);
            function ViewFieldGrid(container) {
                return _super.call(this, container) || this;
            }
            ViewFieldGrid.prototype.getColumnsKey = function () { return 'ModuleManagement.ViewField'; };
            ViewFieldGrid.prototype.getDialogType = function () { return ModuleManagement.ViewFieldDialog; };
            ViewFieldGrid.prototype.getIdProperty = function () { return ModuleManagement.ViewFieldRow.idProperty; };
            ViewFieldGrid.prototype.getLocalTextPrefix = function () { return ModuleManagement.ViewFieldRow.localTextPrefix; };
            ViewFieldGrid.prototype.getService = function () { return ModuleManagement.ViewFieldService.baseUrl; };
            ViewFieldGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ViewFieldGrid);
            return ViewFieldGrid;
        }(Serenity.EntityGrid));
        ModuleManagement.ViewFieldGrid = ViewFieldGrid;
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ModuleDialog = /** @class */ (function (_super) {
            __extends(ModuleDialog, _super);
            function ModuleDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new ModuleManagement.ModuleForm(_this.idPrefix);
                return _this;
            }
            ModuleDialog.prototype.getFormKey = function () { return ModuleManagement.ModuleForm.formKey; };
            ModuleDialog.prototype.getIdProperty = function () { return ModuleManagement.ModuleRow.idProperty; };
            ModuleDialog.prototype.getLocalTextPrefix = function () { return ModuleManagement.ModuleRow.localTextPrefix; };
            ModuleDialog.prototype.getNameProperty = function () { return ModuleManagement.ModuleRow.nameProperty; };
            ModuleDialog.prototype.getService = function () { return ModuleManagement.ModuleService.baseUrl; };
            ModuleDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], ModuleDialog);
            return ModuleDialog;
        }(Serenity.EntityDialog));
        ModuleManagement.ModuleDialog = ModuleDialog;
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ModuleGrid = /** @class */ (function (_super) {
            __extends(ModuleGrid, _super);
            function ModuleGrid(container) {
                return _super.call(this, container) || this;
            }
            ModuleGrid.prototype.getColumnsKey = function () { return 'ModuleManagement.Module'; };
            ModuleGrid.prototype.getDialogType = function () { return ModuleManagement.ModuleDialog; };
            ModuleGrid.prototype.getIdProperty = function () { return ModuleManagement.ModuleRow.idProperty; };
            ModuleGrid.prototype.getLocalTextPrefix = function () { return ModuleManagement.ModuleRow.localTextPrefix; };
            ModuleGrid.prototype.getService = function () { return ModuleManagement.ModuleService.baseUrl; };
            ModuleGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ModuleGrid);
            return ModuleGrid;
        }(Serenity.EntityGrid));
        ModuleManagement.ModuleGrid = ModuleGrid;
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var SignUpPanel = /** @class */ (function (_super) {
            __extends(SignUpPanel, _super);
            function SignUpPanel(container) {
                var _this = _super.call(this, container) || this;
                _this.form = new Membership.SignUpForm(_this.idPrefix);
                _this.form.ConfirmEmail.addValidationRule(_this.uniqueName, function (e) {
                    if (_this.form.ConfirmEmail.value !== _this.form.Email.value) {
                        return Q.text('Validation.EmailConfirm');
                    }
                });
                _this.form.ConfirmPassword.addValidationRule(_this.uniqueName, function (e) {
                    if (_this.form.ConfirmPassword.value !== _this.form.Password.value) {
                        return Q.text('Validation.PasswordConfirm');
                    }
                });
                _this.byId('SubmitButton').click(function (e) {
                    e.preventDefault();
                    if (!_this.validateForm()) {
                        return;
                    }
                    Q.serviceCall({
                        url: Q.resolveUrl('~/Account/SignUp'),
                        request: {
                            DisplayName: _this.form.DisplayName.value,
                            Email: _this.form.Email.value,
                            Password: _this.form.Password.value
                        },
                        onSuccess: function (response) {
                            Q.information(Q.text('Forms.Membership.SignUp.Success'), function () {
                                window.location.href = Q.resolveUrl('~/');
                            });
                        }
                    });
                });
                return _this;
            }
            SignUpPanel.prototype.getFormKey = function () { return Membership.SignUpForm.formKey; };
            SignUpPanel = __decorate([
                Serenity.Decorators.registerClass()
            ], SignUpPanel);
            return SignUpPanel;
        }(Serenity.PropertyPanel));
        Membership.SignUpPanel = SignUpPanel;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ResetPasswordPanel = /** @class */ (function (_super) {
            __extends(ResetPasswordPanel, _super);
            function ResetPasswordPanel(container) {
                var _this = _super.call(this, container) || this;
                _this.form = new Membership.ResetPasswordForm(_this.idPrefix);
                _this.form.NewPassword.addValidationRule(_this.uniqueName, function (e) {
                    if (_this.form.ConfirmPassword.value.length < 1) {
                        return Q.format(Q.text('Validation.MinRequiredPasswordLength'), 1);
                    }
                });
                _this.form.ConfirmPassword.addValidationRule(_this.uniqueName, function (e) {
                    if (_this.form.ConfirmPassword.value !== _this.form.NewPassword.value) {
                        return Q.text('Validation.PasswordConfirm');
                    }
                });
                _this.byId('SubmitButton').click(function (e) {
                    e.preventDefault();
                    if (!_this.validateForm()) {
                        return;
                    }
                    var request = _this.getSaveEntity();
                    request.Token = _this.byId('Token').val();
                    Q.serviceCall({
                        url: Q.resolveUrl('~/Account/ResetPassword'),
                        request: request,
                        onSuccess: function (response) {
                            Q.information(Q.text('Forms.Membership.ResetPassword.Success'), function () {
                                window.location.href = Q.resolveUrl('~/Account/Login');
                            });
                        }
                    });
                });
                return _this;
            }
            ResetPasswordPanel.prototype.getFormKey = function () { return Membership.ResetPasswordForm.formKey; };
            ResetPasswordPanel = __decorate([
                Serenity.Decorators.registerClass()
            ], ResetPasswordPanel);
            return ResetPasswordPanel;
        }(Serenity.PropertyPanel));
        Membership.ResetPasswordPanel = ResetPasswordPanel;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ForgotPasswordPanel = /** @class */ (function (_super) {
            __extends(ForgotPasswordPanel, _super);
            function ForgotPasswordPanel(container) {
                var _this = _super.call(this, container) || this;
                _this.form = new Membership.ForgotPasswordForm(_this.idPrefix);
                _this.byId('SubmitButton').click(function (e) {
                    e.preventDefault();
                    if (!_this.validateForm()) {
                        return;
                    }
                    var request = _this.getSaveEntity();
                    Q.serviceCall({
                        url: Q.resolveUrl('~/Account/ForgotPassword'),
                        request: request,
                        onSuccess: function (response) {
                            Q.information(Q.text('Forms.Membership.ForgotPassword.Success'), function () {
                                window.location.href = Q.resolveUrl('~/');
                            });
                        }
                    });
                });
                return _this;
            }


            ForgotPasswordPanel.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
               
            }



            ForgotPasswordPanel.prototype.getFormKey = function () { return Membership.ForgotPasswordForm.formKey; };
            ForgotPasswordPanel = __decorate([
                Serenity.Decorators.registerClass()
            ], ForgotPasswordPanel);
            return ForgotPasswordPanel;
        }(Serenity.PropertyPanel));
        Membership.ForgotPasswordPanel = ForgotPasswordPanel;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ChangePasswordPanel = /** @class */ (function (_super) {
            __extends(ChangePasswordPanel, _super);
            function ChangePasswordPanel(container) {
                var _this = _super.call(this, container) || this;
                _this.form = new Membership.ChangePasswordForm(_this.idPrefix);
                _this.form.NewPassword.addValidationRule(_this.uniqueName, function (e) {
                    if (_this.form.w('ConfirmPassword', Serenity.PasswordEditor).value.length < 1) {
                        return Q.format(Q.text('Validation.MinRequiredPasswordLength'), 1);
                    }
                });
                _this.form.ConfirmPassword.addValidationRule(_this.uniqueName, function (e) {
                    if (_this.form.ConfirmPassword.value !== _this.form.NewPassword.value) {
                        return Q.text('Validation.PasswordConfirm');
                    }
                });
                _this.byId('SubmitButton').click(function (e) {
                    e.preventDefault();
                    if (!_this.validateForm()) {
                        return;
                    }
                    var request = _this.getSaveEntity();
                    Q.serviceCall({
                        url: Q.resolveUrl('~/Account/ChangePassword'),
                        request: request,
                        onSuccess: function (response) {
                            Q.information(Q.text('Forms.Membership.ChangePassword.Success'), function () {
                                window.location.href = Q.resolveUrl('~/');
                            });
                        }
                    });
                });
                return _this;
            }
            ChangePasswordPanel.prototype.getFormKey = function () { return Membership.ChangePasswordForm.formKey; };
            ChangePasswordPanel = __decorate([
                Serenity.Decorators.registerClass()
            ], ChangePasswordPanel);
            return ChangePasswordPanel;
        }(Serenity.PropertyPanel));
        Membership.ChangePasswordPanel = ChangePasswordPanel;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsParameterDialog = /** @class */ (function (_super) {
            __extends(RecipeSettingsParameterDialog, _super);
            function RecipeSettingsParameterDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.RecipeSettingsParameterForm(_this.idPrefix);
                return _this;
            }
            RecipeSettingsParameterDialog.prototype.getFormKey = function () { return MachineCustomization.RecipeSettingsParameterForm.formKey; };
            RecipeSettingsParameterDialog.prototype.getIdProperty = function () { return MachineCustomization.RecipeSettingsParameterRow.idProperty; };
            RecipeSettingsParameterDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.RecipeSettingsParameterRow.localTextPrefix; };
            RecipeSettingsParameterDialog.prototype.getService = function () { return MachineCustomization.RecipeSettingsParameterService.baseUrl; };
            RecipeSettingsParameterDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], RecipeSettingsParameterDialog);
            return RecipeSettingsParameterDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.RecipeSettingsParameterDialog = RecipeSettingsParameterDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsParameterGrid = /** @class */ (function (_super) {
            __extends(RecipeSettingsParameterGrid, _super);
            function RecipeSettingsParameterGrid(container) {
                return _super.call(this, container) || this;
            }
            RecipeSettingsParameterGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.RecipeSettingsParameter'; };
            RecipeSettingsParameterGrid.prototype.getDialogType = function () { return MachineCustomization.RecipeSettingsParameterDialog; };
            RecipeSettingsParameterGrid.prototype.getIdProperty = function () { return MachineCustomization.RecipeSettingsParameterRow.idProperty; };
            RecipeSettingsParameterGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.RecipeSettingsParameterRow.localTextPrefix; };
            RecipeSettingsParameterGrid.prototype.getService = function () { return MachineCustomization.RecipeSettingsParameterService.baseUrl; };
            RecipeSettingsParameterGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], RecipeSettingsParameterGrid);
            return RecipeSettingsParameterGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.RecipeSettingsParameterGrid = RecipeSettingsParameterGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsDialog = /** @class */ (function (_super) {
            __extends(RecipeSettingsDialog, _super);
            function RecipeSettingsDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.RecipeSettingsForm(_this.idPrefix);
                return _this;
            }
            RecipeSettingsDialog.prototype.getFormKey = function () { return MachineCustomization.RecipeSettingsForm.formKey; };
            RecipeSettingsDialog.prototype.getIdProperty = function () { return MachineCustomization.RecipeSettingsRow.idProperty; };
            RecipeSettingsDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.RecipeSettingsRow.localTextPrefix; };
            RecipeSettingsDialog.prototype.getNameProperty = function () { return MachineCustomization.RecipeSettingsRow.nameProperty; };
            RecipeSettingsDialog.prototype.getService = function () { return MachineCustomization.RecipeSettingsService.baseUrl; };
            RecipeSettingsDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            RecipeSettingsDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            RecipeSettingsDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], RecipeSettingsDialog);
            return RecipeSettingsDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.RecipeSettingsDialog = RecipeSettingsDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsGrid = /** @class */ (function (_super) {
            __extends(RecipeSettingsGrid, _super);
            function RecipeSettingsGrid(container) {
                return _super.call(this, container) || this;
            }
            RecipeSettingsGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.RecipeSettings'; };
            RecipeSettingsGrid.prototype.getDialogType = function () { return MachineCustomization.RecipeSettingsDialog; };
            RecipeSettingsGrid.prototype.getIdProperty = function () { return MachineCustomization.RecipeSettingsRow.idProperty; };
            RecipeSettingsGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.RecipeSettingsRow.localTextPrefix; };
            RecipeSettingsGrid.prototype.getService = function () { return MachineCustomization.RecipeSettingsService.baseUrl; };
            RecipeSettingsGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            RecipeSettingsGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], RecipeSettingsGrid);
            return RecipeSettingsGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.RecipeSettingsGrid = RecipeSettingsGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineVideoDialog = /** @class */ (function (_super) {
            __extends(MachineVideoDialog, _super);
            function MachineVideoDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineVideoForm(_this.idPrefix);
                return _this;
            }
            MachineVideoDialog.prototype.getFormKey = function () { return MachineCustomization.MachineVideoForm.formKey; };
            MachineVideoDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineVideoRow.idProperty; };
            MachineVideoDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineVideoRow.localTextPrefix; };
            MachineVideoDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineVideoRow.nameProperty; };
            MachineVideoDialog.prototype.getService = function () { return MachineCustomization.MachineVideoService.baseUrl; };
            MachineVideoDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], MachineVideoDialog);
            return MachineVideoDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineVideoDialog = MachineVideoDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineVideoGrid = /** @class */ (function (_super) {
            __extends(MachineVideoGrid, _super);
            function MachineVideoGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineVideoGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineVideo'; };
            MachineVideoGrid.prototype.getDialogType = function () { return MachineCustomization.MachineVideoDialog; };
            MachineVideoGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineVideoRow.idProperty; };
            MachineVideoGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineVideoRow.localTextPrefix; };
            MachineVideoGrid.prototype.getService = function () { return MachineCustomization.MachineVideoService.baseUrl; };
            MachineVideoGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            MachineVideoGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineVideoGrid);
            return MachineVideoGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineVideoGrid = MachineVideoGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineUserDialog = /** @class */ (function (_super) {
            __extends(MachineUserDialog, _super);
            function MachineUserDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineUserForm(_this.idPrefix);
                return _this;
            }
            MachineUserDialog.prototype.getFormKey = function () { return MachineCustomization.MachineUserForm.formKey; };
            MachineUserDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineUserRow.idProperty; };
            MachineUserDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineUserRow.localTextPrefix; };
            MachineUserDialog.prototype.getService = function () { return MachineCustomization.MachineUserService.baseUrl; };
            MachineUserDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], MachineUserDialog);
            return MachineUserDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineUserDialog = MachineUserDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineUserGrid = /** @class */ (function (_super) {
            __extends(MachineUserGrid, _super);
            function MachineUserGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineUserGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineUser'; };
            MachineUserGrid.prototype.getDialogType = function () { return MachineCustomization.MachineUserDialog; };
            MachineUserGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineUserRow.idProperty; };
            MachineUserGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineUserRow.localTextPrefix; };
            MachineUserGrid.prototype.getService = function () { return MachineCustomization.MachineUserService.baseUrl; };
            MachineUserGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            MachineUserGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineUserGrid);
            return MachineUserGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineUserGrid = MachineUserGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineSpecificationDialog = /** @class */ (function (_super) {
            __extends(MachineSpecificationDialog, _super);
            function MachineSpecificationDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineSpecificationForm(_this.idPrefix);
                return _this;
            }
            MachineSpecificationDialog.prototype.getFormKey = function () { return MachineCustomization.MachineSpecificationForm.formKey; };
            MachineSpecificationDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineSpecificationRow.idProperty; };
            MachineSpecificationDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineSpecificationRow.localTextPrefix; };
            MachineSpecificationDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineSpecificationRow.nameProperty; };
            MachineSpecificationDialog.prototype.getService = function () { return MachineCustomization.MachineSpecificationService.baseUrl; };
            MachineSpecificationDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            MachineSpecificationDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            MachineSpecificationDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], MachineSpecificationDialog);
            return MachineSpecificationDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineSpecificationDialog = MachineSpecificationDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineSpecificationGrid = /** @class */ (function (_super) {
            __extends(MachineSpecificationGrid, _super);
            function MachineSpecificationGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineSpecificationGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineSpecification'; };
            MachineSpecificationGrid.prototype.getDialogType = function () { return MachineCustomization.MachineSpecificationDialog; };
            MachineSpecificationGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineSpecificationRow.idProperty; };
            MachineSpecificationGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineSpecificationRow.localTextPrefix; };
            MachineSpecificationGrid.prototype.getService = function () { return MachineCustomization.MachineSpecificationService.baseUrl; };
            MachineSpecificationGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            MachineSpecificationGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineSpecificationGrid);
            return MachineSpecificationGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineSpecificationGrid = MachineSpecificationGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineSparePartDialog = /** @class */ (function (_super) {
            __extends(MachineSparePartDialog, _super);
            function MachineSparePartDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineSparePartForm(_this.idPrefix);
                return _this;
            }
            MachineSparePartDialog.prototype.getFormKey = function () { return MachineCustomization.MachineSparePartForm.formKey; };
            MachineSparePartDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineSparePartRow.idProperty; };
            MachineSparePartDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineSparePartRow.localTextPrefix; };
            MachineSparePartDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineSparePartRow.nameProperty; };
            MachineSparePartDialog.prototype.getService = function () { return MachineCustomization.MachineSparePartService.baseUrl; };
            MachineSparePartDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            MachineSparePartDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            MachineSparePartDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], MachineSparePartDialog);
            return MachineSparePartDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineSparePartDialog = MachineSparePartDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineSparePartGrid = /** @class */ (function (_super) {
            __extends(MachineSparePartGrid, _super);
            function MachineSparePartGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineSparePartGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineSparePart'; };
            MachineSparePartGrid.prototype.getDialogType = function () { return MachineCustomization.MachineSparePartDialog; };
            MachineSparePartGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineSparePartRow.idProperty; };
            MachineSparePartGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineSparePartRow.localTextPrefix; };
            MachineSparePartGrid.prototype.getService = function () { return MachineCustomization.MachineSparePartService.baseUrl; };
            MachineSparePartGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            MachineSparePartGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineSparePartGrid);
            return MachineSparePartGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineSparePartGrid = MachineSparePartGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeParameterDialog = /** @class */ (function (_super) {
            __extends(MachineRecipeParameterDialog, _super);
            function MachineRecipeParameterDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineRecipeParameterForm(_this.idPrefix);
                //_this.machineRecipeParameterGrid = new CVC.MachineCustomization.MachineRecipeParameterGrid($('#GridDiv'));
                //_this.machineRecipeParameterGrid.dialogOpen();
                return _this;
            }

            MachineRecipeParameterDialog.prototype.getFormKey = function () { return MachineCustomization.MachineRecipeParameterForm.formKey; };
            MachineRecipeParameterDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineRecipeParameterRow.idProperty; };
            MachineRecipeParameterDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineRecipeParameterRow.localTextPrefix; };
            MachineRecipeParameterDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineRecipeParameterRow.nameProperty; };
            MachineRecipeParameterDialog.prototype.getService = function () { return MachineCustomization.MachineRecipeParameterService.baseUrl; };
            MachineRecipeParameterDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], MachineRecipeParameterDialog);
            return MachineRecipeParameterDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineRecipeParameterDialog = MachineRecipeParameterDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeParameterGrid = /** @class */ (function (_super) {
            __extends(MachineRecipeParameterGrid, _super);
            function MachineRecipeParameterGrid(container) {
                var _this = _super.call(this, container) || this;
                _this.toolbar.findButton("add-button").remove();
                return _this;
            }
            MachineRecipeParameterGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineRecipeParameter'; };
            MachineRecipeParameterGrid.prototype.getDialogType = function () { return MachineCustomization.MachineRecipeParameterDialog; };
            MachineRecipeParameterGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineRecipeParameterRow.idProperty; };
            MachineRecipeParameterGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineRecipeParameterRow.localTextPrefix; };
            MachineRecipeParameterGrid.prototype.getService = function () { return MachineCustomization.MachineRecipeParameterService.baseUrl; };
            MachineRecipeParameterGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineRecipeParameterGrid);
            return MachineRecipeParameterGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineRecipeParameterGrid = MachineRecipeParameterGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeDialog = /** @class */ (function (_super) {
            __extends(MachineRecipeDialog, _super);
            function MachineRecipeDialog() {
                var _this = _super.call(this) || this;
                _this.form = new MachineCustomization.MachineRecipeForm(_this.idPrefix);
                //this.form.RecipeName.element.toggleClass("disabled", this.isNewOrDeleted());
                //_this.form.MachineId.value = 1;
                //_this.form.StatusId.value = 1;
                //_this.form.RecipeSettingsId.value = 1;
                return _this;
                //Q.initDetailEditor(this, this.form.)
            }
            MachineRecipeDialog.prototype.getFormKey = function () { return MachineCustomization.MachineRecipeForm.formKey; };
            MachineRecipeDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineRecipeRow.idProperty; };
            MachineRecipeDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineRecipeRow.localTextPrefix; };
            MachineRecipeDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineRecipeRow.nameProperty; };
            MachineRecipeDialog.prototype.getService = function () { return MachineCustomization.MachineRecipeService.baseUrl; };
            MachineRecipeDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "delete-button"; }), 1);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "undo-delete-button"; }), 1);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "localization-button"; }), 1);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "clone-button"; }), 1);
                return buttons;
            };
            MachineRecipeDialog.prototype.onSaveSuccess = function (response) {
                if (this.isNew()) {
                  
                    Q.notifySuccess("Recipe Created Successfully");                            
                    $("#txtRecipeName").val($('[name=RecipeName]').eq(0).val());
                   
                }
                else {
                    Q.notifySuccess("Recipe Updated Successfully");
                }
                   
               
                  
            };

            //start keyboard 01/02/2019 5.49pm

            MachineRecipeDialog.prototype.onDialogOpen = function () {

                //var date = new Date();
                //date.setDate(date.getDate());

                //$('.hasDatepicker').datepicker({
                //    startDate: date
                //});
                //$(function () {
                //    $('.hasDatepicker').datetimepicker({
                //        minDate: new Date()
                //    });
                //});
                // $(':text').blur();
                // $(".editor").click(function () {
              
               
                $("input[name='RecipeName'],input[name='Description']").keyboard({
                    layout: 'custom',
                    usePreview: false,
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right}'
                        ],
                        'shift': [
                            '~ ! @@ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right}'
                        ]
                    }
                })
                    .addCaret({
                        caretClass: '',
                        // *** for future use ***
                        // data-attribute containing the character(s) next to the caret
                        charAttr: 'data-character',
                        // # character(s) next to the caret (can be negative for RTL)
                        // default is 1 which shows the character to the right of the caret
                        // setting this to -1 shows the character to the left
                        charIndex: -1,
                        // tweak caret position & height
                        offsetX: 0,
                        offsetY: 0,
                        adjustHt: 0
                    });

                //  });


            };


                //end keyboard 01/02/2019 5.49pm

            MachineRecipeDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], MachineRecipeDialog);
            return MachineRecipeDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineRecipeDialog = MachineRecipeDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var SelectableEntityGrid = /** @class */ (function (_super) {
        __extends(SelectableEntityGrid, _super);
        function SelectableEntityGrid() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        SelectableEntityGrid.prototype.getSlickOptions = function () {
            var opt = _super.prototype.getSlickOptions.call(this);
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selected";
            opt.enableCellNavigation = true;
          //  opt.selectionMode = 'single';
           // opt.enableRowSelection = true;
            return opt;
        };
        SelectableEntityGrid.prototype.createSlickGrid = function () {
            var grid = _super.prototype.createSlickGrid.call(this);
            grid.setSelectionModel(new Slick.RowSelectionModel());
            return grid;
        };
        SelectableEntityGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], SelectableEntityGrid);
        return SelectableEntityGrid;
    }(Serenity.EntityGrid));
    CVC.SelectableEntityGrid = SelectableEntityGrid;
})(CVC || (CVC = {}));
/// <reference path="SelectableEntityGrid.ts" />
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeGrid = /** @class */ (function (_super) {
            __extends(MachineRecipeGrid, _super);
            function MachineRecipeGrid(container) {
                var _this = _super.call(this, container) || this;
                _this.toolbar.findButton("refresh-button").remove();
                _this.toolbar.findButton("column-picker-button").remove();
                _this.toolbar.findButton("add-button").remove();
              
                return _this;
                //this.slickGrid.setOptions({ enableAddRow: true });
            }
            MachineRecipeGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineRecipe'; };
            MachineRecipeGrid.prototype.getDialogType = function () { return MachineCustomization.MachineRecipeDialog; };
            MachineRecipeGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineRecipeRow.idProperty; };
            MachineRecipeGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineRecipeRow.localTextPrefix; };
            MachineRecipeGrid.prototype.getService = function () { return MachineCustomization.MachineRecipeService.baseUrl; };


           

            //getButtons() {
            //    var buttons = super.getButtons();
            //    buttons.push(
            //        {
            //            title: 'Add New Recipe',
            //            cssClass: 'add-button',
            //            onClick: () => {
            //                this.slickGrid.onAddNewRow.subscribe(function (e, args) {
            //                    var item = { RecipeName: "", Description: "" };
            //                    args.grid.getData().splice(args.grid.getDataLength(), 1, item);
            //                    args.grid.invalidateRow(args.grid.getDataLength() - 1);
            //                    args.grid.updateRowCount();
            //                    args.grid.render();
            //                    //var item = { RecipeName: "", Description: "" };
            //                    //$.extend(item, args.item);
            //                    //data.push(item);
            //                    //grid.invalidateRows([data.length - 1]);
            //                    //grid.updateRowCount();
            //                    //grid.render();
            //                });
            //            }
            //        }
            //    );
            //    return buttons;
            //}
            MachineRecipeGrid.prototype.getDefaultSortBy = function () {
                return [MachineCustomization.MachineRecipeRow.Fields.RecipeName];
            };
            MachineRecipeGrid.prototype.getInitialTitle = function () {
                return null;
            };

         

            MachineRecipeGrid.prototype.getColumns = function () {
                var _this = this;
                var columns = _super.prototype.getColumns.call(this);
              
                if ($("#hdnRecipeId").length == 0) {
                    var applycolumn = {
                        name: 'Download Report',
                        field: 'IsApplied',
                        width: 300,
                        sortable: false,

                        format: function (ctx) {
                            return Q.outerHtml($('<button/>')
                                .addClass('target-text')
                                .attr('height', 50)
                                .attr('onclick', 'DownloadRecipeReport(' + ctx.item.MachineRecipeId + ');')
                                .text('Download Report'));
                        }
                    }
                    columns.splice(2, 0, applycolumn);
                }


                
                    //var applycolumn = {
                    //    name: 'Download Report1',
                    //    field: 'IsDefaultRecipe',
                    //   // width: 300,
                    //   // sortable: false,
                    //    format: function (ctx) {
                    //        console.log(ctx.item.MachineRecipeId + "  " + ctx.item.IsDefaultRecipe)

                    //        if (ctx.item.IsDefaultRecipe != true) {
                               
                    //            var item = ctx.item.IsDefaultRecipe;  //data for that row
                    //            return "<input type='checkbox' checked>";
                    //        }
                    //        else {
                    //            var item = ctx.item.IsDefaultRecipe;  //data for that row
                    //            return "<input type='checkbox' checked>";
                    //        }
                           
                    //    },
                    //    //format: function (ctx) {
                    //    //    return Q.outerHtml($('<checkbox/>')
                    //    //        .addClass('target-text')
                    //    //        .attr('height', 50)
                    //    //        .attr('onclick', 'DownloadRecipeReport(' + ctx.item.MachineRecipeId + ');')
                    //    //        .text('Download Report1'));
                    //    //}
                    //}
                    //columns.splice(4, 0, applycolumn);
                

                return columns;
            };

               
           

            MachineRecipeGrid.prototype.onClick = function (e, row, cell) {
                debugger;
                _super.prototype.onClick.call(this, e, row, cell);
                var item = this.itemAt(row);
                
                //sessionStorage.setItem("RecipeId", item.MachineRecipeId.toString());
                //sessionStorage.setItem("RecipeName", item.RecipeName);
                //Serenity.SubDialogHelper.triggerDataChange(this);
                //$("#txtRecipeName").val(item.RecipeName);
                //$("#hdnRecipeId").val(item.MachineRecipeId.toString());
                var RecipeAction = "ApplyRecipe";
                if (cell == "3") {
                    RecipeAction = "DefaultRecipe";
                }
                

                if ($("#hdnRecipeId").length > 0) {
                    this.element.dialog().dialog('close');
                    $("[role=dialog]").hide();
                    var machine = {
                        "MacineRecipeId": item.MachineRecipeId, "RecipeAction": RecipeAction };
                    jQuery.support.cors = true;
                    $.ajax({
                        url: Q.resolveUrl('~/api/Batch/ApplyRecipe'),
                        data: machine,
                        type: 'POST',
                        dataType: 'json',
                        success: function (data) {
                            $(".ui-widget-overlay").hide();
                            if (RecipeAction == "DefaultRecipe") {
                                Q.notifySuccess("Default Recipe Set Successfully");
                            }
                            else {
                                Q.notifySuccess("Recipe Apllied Successfully");
                            }
                          
                            fillview(false);
                        },
                        error: function (x, y, z) {
                            alert(x + '\n' + y + '\n' + z);
                        }
                    });
                }
                else {
                    //new CVC.MachineCustomization.MachineRecipeParameterGrid($('#GridDiv'), {}).init();
                    //var dlg = new CVC.MachineCustomization.MachineRecipeParameterDialog();
                    //dlg.dialogTitle = 'Recipe Parameters';
                    //dlg.dialogOpen();
                    //new Administration.RolePermissionDialog({
                    //    roleID: 1,
                    //    title: "hjghj"
                    //}).dialogOpen();
                }
            };
            MachineRecipeGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineRecipeGrid);
            return MachineRecipeGrid;
        }(CVC.SelectableEntityGrid));
        MachineCustomization.MachineRecipeGrid = MachineRecipeGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineParameterDialog = /** @class */ (function (_super) {
            __extends(MachineParameterDialog, _super);
            function MachineParameterDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineParameterForm(_this.idPrefix);
                return _this;
            }
            MachineParameterDialog.prototype.getFormKey = function () { return MachineCustomization.MachineParameterForm.formKey; };
            MachineParameterDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineParameterRow.idProperty; };
            MachineParameterDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineParameterRow.localTextPrefix; };
            MachineParameterDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineParameterRow.nameProperty; };
            MachineParameterDialog.prototype.getService = function () { return MachineCustomization.MachineParameterService.baseUrl; };

            MachineParameterDialog.prototype.onSaveSuccess = function (response) {
                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }

                this.dialogClose();
            };

            // Change the dialog title
            MachineParameterDialog.prototype.updateTitle = function () {
                this.dialogTitle = "New Entity Field"
            }

            MachineParameterDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            MachineParameterDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };

            MachineParameterDialog.prototype.afterLoadEntity = function () {
                var _this = this;
                _super.prototype.afterLoadEntity.call(this);
                //this.form.MDBPath.addValidationRule(this.uniqueName, function (e) {                   
                //        return "Password must be at least 7 characters!";
                //});

                if (this.form.IsBitWise.value == true) {
                    $('.BitWiseIndex').show();
                    this.form.BitWiseIndex.element.toggleClass('required', true);
                }
                else {
                    $('.BitWiseIndex').hide();
                    this.form.BitWiseIndex.element.toggleClass('required', false);
                }

                if (this.form.Is32Bit.value == true) {
                    $('.Bit32RowId').show();
                    this.form.Bit32RowId.element.toggleClass('required', true);
                }
                else {
                    $('.Bit32RowId').hide();
                    this.form.Bit32RowId.element.toggleClass('required', false);
                }

                if (this.form.IsWrite.value == true) {
                    $('.QueryTypeRowId').show();
                    //this.form.QueryTypeRowId.element.toggleClass('required', true);
                }
                else {
                    $('.QueryTypeRowId').hide();
                    // this.form.QueryTypeRowId.element.toggleClass('required', false);
                }


                if (this.form.Type.value == 49 && this.form.IsRead.value == true) {
                    $('.ReadMachineParameterId').show();
                }
                else {
                    $('.ReadMachineParameterId').hide();
                }


                if (this.form.Type.value == 49) {
                    $('.IsBatchStartRequired').show();
                }
                else {
                    $('.IsBatchStartRequired').hide();
                }

                if (this.form.OperationType.value == 50 || this.form.OperationType.value == 51 || this.form.OperationType.value == 52 || this.form.OperationType.value == 53) {
                    $('.OperationValue').show();
                    this.form.OperationValue.element.toggleClass('required', true);
                }
                else {
                    $('.OperationValue').hide();
                    this.form.OperationValue.element.toggleClass('required', false);
                }

                //changes added By Vinayak On 03.08.2018

                //if (this.form.MachineId.value == 7) {
                //    //alert('ok')
                //    $('.OperationType').hide();
                //    $('.Type').hide();
                //    $('.QueryTypeRowId').hide();
                //    $('.IsStopAt').hide();
                //    $('.IsBitWise').hide();
                //    $('.Is32Bit').hide();
                //    $('.RowId').hide();
                //    $('.IsShowAsMessage').hide();
                //    $('.IsResetOnBatchCreate').hide();
                //    $('.IsBatchStartRequired').hide();
                //    $('.DisableParameterId').hide();
                //    $('.DisableParameterValue').hide();
                //    $('.IsStopOnBatchStop').hide();
                //    $('.IsLabelRoll').hide();
                //    $('.ReloadMachineParameterId').hide();
                //    //this.form.OperationType.element.closest('.category').hide();

                //    // var ele = this.OperationType.find(".category-title:contains('" + MDB + "')").parent();
                //    // ele.toggle(false); //hidden by default
                //    this.form.BitWiseIndex.element.toggleClass('required', false);
                //}
                //else {
                //    //alert('pk')
                //    $('.OperationType').show();
                //    $('.Type').show();
                //    $('.QueryTypeRowId').show();
                //    $('.IsStopAt').show();
                //    $('.IsBitWise').show();
                //    $('.Is32Bit').show();
                //    $('.RowId').show();
                //    $('.IsShowAsMessage').show();
                //    $('.IsResetOnBatchCreate').show();
                //    $('.IsBatchStartRequired').show();
                //    $('.DisableParameterId').show();
                //    $('.DisableParameterValue').show();
                //    $('.IsStopOnBatchStop').show();
                //    $('.IsLabelRoll').show();
                //    $('.ReloadMachineParameterId').show();
                //    //this.form.OperationType.element.closest('.category').show();
                //    this.form.BitWiseIndex.element.toggleClass('required', true);
                //}


                var localfrm = this.form;
                var ProtocolTypeID = 0;

              //  this.form.MachineId.Value =2;
                //changes added By Vinayak On 03.08.2018
                  this.form.MachineId.element.toggleClass('disabled', true);

                var colName_ele = this.form.ColumnName.element;
                var colName_ele_id = colName_ele.attr("id");
                var colName_alter_ele_id = colName_ele_id + '_Alter';

                this.form.MachineId.changeSelect2(function (e) {
                    $.ajax({
                        async: false,
                        type: "GET",
                        url: Q.resolveUrl('~/api/CommonApi/GetProtocolID?id=' + localfrm.MachineId.value),
                        //  url: Q.resolveUrl('~/api/Batch/GetProtocolID'),
                        data: { "MachineId": 7 },
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (response) {
                            ProtocolTypeID = response;
                            reportDetails = response;
                        },
                        failure: function (response) {
                            alert(response.responseText);
                        },
                        error: function (response) {
                            alert(response.responseText);
                        }
                    });

                    // added by Denis for RS 3.7 dated 7/20/2021
                    MachineCustomization.MachineService.Retrieve({ EntityId: localfrm.MachineId.value, ColumnSelection: 1, IncludeColumns: ["TableId", "MachineName", "IsRealTime"] }, function (response) {
                        // Get the object id of the table assigned to Business Entity(machine)
                        var TableId = response.Entity.TableId;
                        var IsRealTime = response.Entity.IsRealTime ?? false;

                        // DataTypeId is needed to be NotNull on the RealTime Mode.
                        _this.form.DataTypeId.element.toggleClass("required", IsRealTime)
                        // ColumnName is needed to be NotNull on the DB Related Mode.
                        _this.form.ColumnName.element.toggleClass("required", !IsRealTime)

                        // Switch form style to RealTime/DBRelated. 
                        _this.form.IsUseUnit.element.closest('.category').toggle(IsRealTime)
                        _this.form.ColumnName.element.closest('.category').toggle(!IsRealTime)
                        _this.form.Type.element.closest('.category').toggle(IsRealTime)

                        /* Managing the Category-links
                         * According to show/hide Categories
                         * */
                        // MDB category link
                        $("a[href$='Category5']").toggle(IsRealTime)
                        $("a[href$='Category5']").next().toggle(IsRealTime)
                        // Details for DB related category link
                        $("a[href$='Category3']").toggle(!IsRealTime)
                        $("a[href$='Category3']").next().toggle(!IsRealTime)
                        // Details for Realtime category link
                        $("a[href$='Category2']").toggle(IsRealTime)
                        $("a[href$='Category2']").next().toggle(IsRealTime)

                        if ($("#" + colName_alter_ele_id).length) {
                            // Remove the prior column id select
                            $("#" + colName_alter_ele_id).remove();

                            // Show ColumnName element
                            colName_ele.css({ "position": "unset" });
                        }

                        if (IsRealTime) {
                            // ColumnName and PickListId are not necessary on RealTime Mode.
                            _this.form.ColumnName.set_value("");
                            _this.form.PickListId.set_value("");
                        } else {
                            // Get All columns by table object id.
                            var res = MachineCustomization.MachineParameterService.FetchAllColumns({ TableId }, function (response) {
                                var col_optionArr = res.responseJSON.Entities.reduce(function (init, current) { return (init + '<option value="' + current.ColumnName + '">' + current.ColumnName + '</option>'); }, "");
                                col_optionArr = '<option value="">--select--</option>' + col_optionArr
                                var col_select_ele_str = '<select id="' + colName_alter_ele_id + '" class="' + colName_ele.attr("class") + '">' +
                                    col_optionArr +
                                    '</select>';
                                $("#" + colName_alter_ele_id).remove();
                                // Insert column id select after ColumnName element.
                                $(col_select_ele_str).insertAfter("#" + colName_ele_id);
                                // Hide ColumnName element in order to show only Select element instead of.
                                colName_ele.css({ "position": "absolute", "left": "-999em" });

                                // Set the value of ColumnName element to the value of the Select element
                                $("#" + colName_alter_ele_id).on('change', function () {
                                    var value = $("#" + colName_alter_ele_id).val();
                                    value = (value != "") ? value : null
                                    _this.form.ColumnName.set_value(value);
                                });

                                if (!_this.isNew() && _this.entity.ColumnName) {
                                    $("#" + colName_alter_ele_id).val(_this.entity.ColumnName)
                                }
                            })
                        }

                        // even though the machine is realtime one, if ProtocalTypeID is 1, MDB category is not necessary
                        if (ProtocolTypeID == 1) {
                            Q.notifySuccess("Protocal type id is 1.")
                            // MDB category link
                            _this.form.Type.element.closest('.category').toggle(false)
                            $("a[href$='Category5']").toggle(false)
                            $("a[href$='Category5']").next().toggle(false)

                            localfrm.MachineId.element.toggleClass('required', true);
                        }
                        if (ProtocolTypeID == 4) {
                            Q.notifySuccess("Protocal type id is 4.")
                            // MDB category link
                            _this.form.Type.element.closest('.category').toggle(true)
                            $("a[href$='Category5']").toggle(true)
                            $("a[href$='Category5']").next().toggle(true)

                            localfrm.MachineId.element.toggleClass('required', false);
                        }
                    })

                    /*if (ProtocolTypeID == 1) {
                        Q.notifySuccess("Protocal type id is 1.")
                        $('.OperationType').hide();
                        $('.Type').hide();
                        $('.QueryTypeRowId').hide();
                        $('.IsStopAt').hide();
                        $('.IsBitWise').hide();
                        $('.Is32Bit').hide();
                        $('.RowId').hide();
                        $('.IsShowAsMessage').hide();
                        $('.IsResetOnBatchCreate').hide();
                        $('.IsBatchStartRequired').hide();
                        $('.DisableParameterId').hide();
                        $('.DisableParameterValue').hide();
                        $('.IsStopOnBatchStop').hide();
                        $('.IsLabelRoll').hide();
                        $('.ReloadMachineParameterId').hide();
                        $("[name='CVC_MachineCustomization_MachineParameterDialog4_Category4'],[name='CVC_MachineCustomization_MachineParameterDialog8_Category4']").attr("style", "display:none");
                        localfrm.MachineId.element.toggleClass('required', true);
                    }
                    if (ProtocolTypeID == 4) {
                        Q.notifySuccess("Protocal type id is 4.")
                        $('.OperationType').show();
                        $('.Type').show();
                        $('.QueryTypeRowId').show();
                        $('.IsStopAt').show();
                        $('.IsBitWise').show();
                        $('.Is32Bit').show();
                        $('.RowId').show();
                        $('.IsShowAsMessage').show();
                        $('.IsResetOnBatchCreate').show();
                        $('.IsBatchStartRequired').show();
                        $('.DisableParameterId').show();
                        $('.DisableParameterValue').show();
                        $('.IsStopOnBatchStop').show();
                        $('.IsLabelRoll').show();
                        $('.ReloadMachineParameterId').show();
                        $("[name='CVC_MachineCustomization_MachineParameterDialog4_Category4'],[name='CVC_MachineCustomization_MachineParameterDialog8_Category4']").attr("style", "display:block");
                        localfrm.MachineId.element.toggleClass('required', false);
                    }*/
                });

                //changes ended By Vinayak On 03.08.2018

                this.form.OperationType.changeSelect2(function (e) {
                    if (localfrm.OperationType.value == 50 || localfrm.OperationType.value == 51 || localfrm.OperationType.value == 52 || localfrm.OperationType.value == 53) {
                        $('.OperationValue').show();
                        localfrm.OperationValue.element.toggleClass('required', true);
                    }
                    else {
                        $('.OperationValue').hide();
                        localfrm.OperationValue.element.toggleClass('required', false);
                    }
                });

                this.form.Type.changeSelect2(function (e) {
                    if (localfrm.IsRead.value == true && localfrm.Type.value == 49) {
                        $('.ReadMachineParameterId').show();
                    }
                    else {
                        $('.ReadMachineParameterId').hide();
                    }
                    if (localfrm.Type.value == 49) {
                        $('.IsBatchStartRequired').show();
                    }
                    else {
                        $('.IsBatchStartRequired').hide();
                    }
                });

                this.form.IsBitWise.change(function (e) {
                    if (localfrm.IsBitWise.value == true) {
                        $('.BitWiseIndex').show();
                        localfrm.BitWiseIndex.element.toggleClass('required', true);
                    }
                    else {
                        $('.BitWiseIndex').hide();
                        localfrm.BitWiseIndex.element.toggleClass('required', false);
                    }
                });

                this.form.IsWrite.change(function (e) {
                    if (localfrm.IsWrite.value == true) {
                        $('.QueryTypeRowId').show();
                        //localfrm.QueryTypeRowId.element.toggleClass('required', true);
                    }
                    else {
                        $('.QueryTypeRowId').hide();
                        //localfrm.QueryTypeRowId.element.toggleClass('required', false);
                    }
                });

                this.form.IsRead.change(function (e) {
                    if (localfrm.IsRead.value == true && this.form.Type.value == 49) {
                        $('.ReadMachineParameterId').show();
                    }
                    else {
                        $('.ReadMachineParameterId').hide();
                    }
                });


                this.form.Is32Bit.change(function (e) {
                    if (localfrm.Is32Bit.value == true) {
                        $('.Bit32RowId').show();
                        localfrm.Bit32RowId.element.toggleClass('required', true);
                    }
                    else {
                        $('.Bit32RowId').hide();
                        localfrm.Bit32RowId.element.toggleClass('required', false);
                    }
                });

                if (this.isNew()) {
                    if ($("#MachineId").val()) {
                        //this.form.MachineId.value = $("#MachineId").val();
                        this.form.MachineId.set_value($("#MachineId").val());
                        /* NOTE
                         * Author: JSGURU
                         * 
                         * I tried to trigger the changeSelect2 event of the MachineId element with element.triggerHandler("changeSelect2")
                         * But it did not work.
                         * It worked with element.triggerHandler("change")
                         */
                        this.form.MachineId.element.triggerHandler("change");

                        // Disable the MachineId element not to change Machine
                        Serenity.EditorUtils.setReadOnly(this.form.MachineId, true);
                    }

                    //this.form.MachineId.get_items()[5].id;
                    // s2id_CVC_MachineCustomization_MachineParameterDialog11_MachineId
                    // $("#s2id_CVC_MachineCustomization_MachineParameterDialog11_MachineId").trigger("change"); //if there is some change handler you've set
                } else {
                    if (this.form.MachineId.value)
                        this.form.MachineId.element.triggerHandler("change")
                }
            };

            MachineParameterDialog.prototype.onDialogOpen = function () {
                if (!this.isNew())
                    Serenity.EditorUtils.setReadOnly(this.form.MachineId, true)
                //    $("input[name='ParameterName'],input[name='Description']").keyboard({
            //        layout: 'custom',
            //        customLayout: alphanumericKeyboard

            //    })
            //    $("input[name='Min'],input[name='Max'],input[name='DisableParameterValue']").keyboard({
            //        layout: 'custom',
            //        customLayout: numricKeyboard

            //    })

            //    $("input[name='RowId']").keyboard({
            //        layout: 'custom',
            //        customLayout: numricWithoutDecimalKeyboard

            //    })

            }

            MachineParameterDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], MachineParameterDialog);
            return MachineParameterDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineParameterDialog = MachineParameterDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineParameterGrid = /** @class */ (function (_super) {
            __extends(MachineParameterGrid, _super);
            function MachineParameterGrid(container) {
                var _this = _super.call(this, container) || this;

                // Change the grid title
                _this.setTitle("Entity Field");
                return _this;
            }
            MachineParameterGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineParameter'; };
            MachineParameterGrid.prototype.getDialogType = function () { return MachineCustomization.MachineParameterDialog; };
            MachineParameterGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineParameterRow.idProperty; };
            MachineParameterGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineParameterRow.localTextPrefix; };
            MachineParameterGrid.prototype.getService = function () { return MachineCustomization.MachineParameterService.baseUrl; };
            MachineParameterGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);

                // Change the caption of 'add-button'
                var newBtn = Q.first(buttons, x => x.cssClass == "add-button");
                newBtn.title = Q.text("New Entity Field")

                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnIsImportAccessForMachineParameter").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //cssClass: 'stampe',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('machineParameter');
                            }
                        });
                }
                //buttons.push(
                //    {
                //        title: Q.text("Test"),	// *** Get button text from translation
                //        cssClass: 'stampe',
                //        icon: 'fa-print',
                //        onClick: () => {

                //            test('fire');

                //        },
                //    }
                //);
                return buttons;
            };

            MachineParameterGrid.prototype.onViewSubmit = function () {
                if (!_super.prototype.onViewSubmit.call(this)) {
                    return false;
                }
                var request = this.view.params;
                var machineId = $("#MachineId").val()/*$("#hdnMachineId").val()*/;
                request.EqualityFilter.MachineId = machineId;

                return true;
            };

            MachineParameterGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineParameterGrid);
            return MachineParameterGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineParameterGrid = MachineParameterGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));

//var CVC;

//(function (CVC) {
//    var Report;
//    (function (Report) {
//        var MachineParameterGrid = /** @class */ (function (_super) {
//            __extends(MachineParameterGrid, _super);
//            function MachineParameterGrid(container) {
//                var _this = _super.call(this, container) || this;
//                _this.reportType = 3;
//                return _this;
//            }
//            MachineParameterGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineParameter'; };
//            MachineParameterGrid.prototype.getDialogType = function () { return MachineCustomization.MachineParameterDialog; };
//            MachineParameterGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineParameterRow.idProperty; };
//            MachineParameterGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineParameterRow.localTextPrefix; };
//            MachineParameterGrid.prototype.getService = function () { return MachineCustomization.MachineParameterService.baseUrl; };
//            MachineParameterGrid.prototype.getButtons = function () {
//                return [];
//            };
//            MachineParameterGrid.prototype.createQuickSearchInput = function () {
//            };
//            MachineParameterGrid.prototype.setTitle = function () {
//            };
//            MachineParameterGrid.prototype.onViewSubmit = function () {
//                if (!_super.prototype.onViewSubmit.call(this)) {
//                    return false;
//                }
//                var request = this.view.params;
//               var machineId = $("#MachineId").val()/*$("#hdnMachineId").val()*/;
//               alert(machineId);
//                request.EqualityFilter.MachineId = machineId;
//                return true;
//                         };
//            MachineParameterGrid = __decorate([
//                Serenity.Decorators.registerClass()
//            ], MachineParameterGrid);
//            return MachineParameterGrid;
//        }(CVC.DynamicEntityGrid));
//        MachineCustomization.MachineParameterGrid = MachineParameterGrid;
//    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
//})(CVC || (CVC = {}));




var CVC;
(function (CVC) {
    var DynamicEntityGrid = /** @class */ (function (_super) {
        __extends(DynamicEntityGrid, _super);
        function DynamicEntityGrid() {
            var _this = _super !== null && _super.apply(this, arguments) || this;

            _this.reportType = 0;

            return _this;
        }
        DynamicEntityGrid.prototype.getColumns = function () {

            var loadedColumns = loadColumns(this.getService(), this.getColumnsKey()).Columns;

            return this.propertyItemsToSlickColumns(loadedColumns);
            //return _super.prototype.getColumns.call(this);
        };
        DynamicEntityGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], DynamicEntityGrid);


        function loadColumns(url, columnName) {
            // strUrl is whatever URL you need to call
            var strUrl = '/Services/' + url + '/getColumns', strReturn = "";

            jQuery.ajax({
                url: strUrl,
                data: {
                    Name: columnName
                },
                success: function (html) {
                    strReturn = html;
                },
                async: false
            });
            return strReturn;
        }

        return DynamicEntityGrid;
    }(Serenity.EntityGrid));
    CVC.DynamicEntityGrid = DynamicEntityGrid;
})(CVC || (CVC = {}));



var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineMaintenanceScheduleDialog = /** @class */ (function (_super) {
            __extends(MachineMaintenanceScheduleDialog, _super);
            function MachineMaintenanceScheduleDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineMaintenanceScheduleForm(_this.idPrefix);
                return _this;
            }
            MachineMaintenanceScheduleDialog.prototype.getFormKey = function () { return MachineCustomization.MachineMaintenanceScheduleForm.formKey; };
            MachineMaintenanceScheduleDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineMaintenanceScheduleRow.idProperty; };
            MachineMaintenanceScheduleDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineMaintenanceScheduleRow.localTextPrefix; };
            MachineMaintenanceScheduleDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineMaintenanceScheduleRow.nameProperty; };
            MachineMaintenanceScheduleDialog.prototype.getService = function () { return MachineCustomization.MachineMaintenanceScheduleService.baseUrl; };
            MachineMaintenanceScheduleDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            MachineMaintenanceScheduleDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            MachineMaintenanceScheduleDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], MachineMaintenanceScheduleDialog);
            return MachineMaintenanceScheduleDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineMaintenanceScheduleDialog = MachineMaintenanceScheduleDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineMaintenanceScheduleGrid = /** @class */ (function (_super) {
            __extends(MachineMaintenanceScheduleGrid, _super);
            function MachineMaintenanceScheduleGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineMaintenanceScheduleGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineMaintenanceSchedule'; };
            MachineMaintenanceScheduleGrid.prototype.getDialogType = function () { return MachineCustomization.MachineMaintenanceScheduleDialog; };
            MachineMaintenanceScheduleGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineMaintenanceScheduleRow.idProperty; };
            MachineMaintenanceScheduleGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineMaintenanceScheduleRow.localTextPrefix; };
            MachineMaintenanceScheduleGrid.prototype.getService = function () { return MachineCustomization.MachineMaintenanceScheduleService.baseUrl; };
            MachineMaintenanceScheduleGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            MachineMaintenanceScheduleGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineMaintenanceScheduleGrid);
            return MachineMaintenanceScheduleGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineMaintenanceScheduleGrid = MachineMaintenanceScheduleGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineUserDialog = /** @class */ (function (_super) {
            __extends(MachineLineUserDialog, _super);
            function MachineLineUserDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineLineUserForm(_this.idPrefix);
                return _this;
            }
            MachineLineUserDialog.prototype.getFormKey = function () { return MachineCustomization.MachineLineUserForm.formKey; };
            MachineLineUserDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineLineUserRow.idProperty; };
            MachineLineUserDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineLineUserRow.localTextPrefix; };
            MachineLineUserDialog.prototype.getService = function () { return MachineCustomization.MachineLineUserService.baseUrl; };
            MachineLineUserDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            MachineLineUserDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            MachineLineUserDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], MachineLineUserDialog);
            return MachineLineUserDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineLineUserDialog = MachineLineUserDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineUserGrid = /** @class */ (function (_super) {
            __extends(MachineLineUserGrid, _super);
            function MachineLineUserGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineLineUserGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineLineUser'; };
            MachineLineUserGrid.prototype.getDialogType = function () { return MachineCustomization.MachineLineUserDialog; };
            MachineLineUserGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineLineUserRow.idProperty; };
            MachineLineUserGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineLineUserRow.localTextPrefix; };
            MachineLineUserGrid.prototype.getService = function () { return MachineCustomization.MachineLineUserService.baseUrl; };
            MachineLineUserGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            MachineLineUserGrid.prototype.getInitialTitle = function () {
                return null;
            };
            MachineLineUserGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineLineUserGrid);
            return MachineLineUserGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineLineUserGrid = MachineLineUserGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineDialog = /** @class */ (function (_super) {
            __extends(MachineLineDialog, _super);
            function MachineLineDialog() {
                var _this = _super.call(this) || this;
                _this.form = new MachineCustomization.MachineLineForm(_this.idPrefix);
                //this.machineGrid = new MachineGrid(this.byId("MachineGrid"));
                _this.lineUsersGrid = new MachineCustomization.MachineLineUserGrid(_this.byId("MachineLineUsersGrid"));
                _this.lineMaintenanceGrid = new MachineCustomization.LineMaintenanceScheduleGrid(_this.byId("MachineLineMaintenanceGrid"));
                return _this;
            }
            MachineLineDialog.prototype.getFormKey = function () { return MachineCustomization.MachineLineForm.formKey; };
            MachineLineDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineLineRow.idProperty; };
            MachineLineDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineLineRow.localTextPrefix; };
            MachineLineDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineLineRow.nameProperty; };
            MachineLineDialog.prototype.getService = function () { return MachineCustomization.MachineLineService.baseUrl; };

            MachineLineDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };

            MachineLineDialog.prototype.getToolbarButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                buttons.push({
                    title: 'Edit',
                    cssClass: 'edit-button',
                    onClick: function () {
                        Serenity.EditorUtils.setReadonly(_this.element.find('.editor'), false);
                        _this.element.find('sup').show();
                        _this.saveAndCloseButton.show();
                        buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "edit-button"; }), 1);
                    }
                });
                return buttons;
            };
            MachineLineDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                Serenity.EditorUtils.setReadonly(this.element.find('.editor'), true);
                this.element.find('sup').hide();
                this.deleteButton.hide();
                this.saveAndCloseButton.hide();
            };
            //MachineLineDialog.prototype.afterLoadEntity = function () {
            //    _super.prototype.afterLoadEntity.call(this);
            //    //this.machineGrid.MachineLineId = this.entityId;

            //    $("input[name='LineName'],input[name='LineRatedSpeed']").keyboard({
            //        layout: 'custom',
            //        customLayout: alphanumericKeyboard
            //    })

            //    $("input[name='NumberOfMachines']").keyboard({
            //        layout: 'custom',
            //        customLayout: numricWithoutDecimalKeyboard
            //    })

            //};

            MachineLineDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], MachineLineDialog);
            return MachineLineDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineLineDialog = MachineLineDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineGrid = /** @class */ (function (_super) {
            __extends(MachineLineGrid, _super);
            function MachineLineGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineLineGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineLine'; };
            MachineLineGrid.prototype.getDialogType = function () { return MachineCustomization.MachineLineDialog; };
            MachineLineGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineLineRow.idProperty; };
            MachineLineGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineLineRow.localTextPrefix; };
            MachineLineGrid.prototype.getService = function () { return MachineCustomization.MachineLineService.baseUrl; };
            MachineLineGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            MachineLineGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineLineGrid);
            return MachineLineGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineLineGrid = MachineLineGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHistoryDialog = /** @class */ (function (_super) {
            __extends(MachineHistoryDialog, _super);
            function MachineHistoryDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineHistoryForm(_this.idPrefix);
                return _this;
            }
            MachineHistoryDialog.prototype.getFormKey = function () { return MachineCustomization.MachineHistoryForm.formKey; };
            MachineHistoryDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineHistoryRow.idProperty; };
            MachineHistoryDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineHistoryRow.localTextPrefix; };
            MachineHistoryDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineHistoryRow.nameProperty; };
            MachineHistoryDialog.prototype.getService = function () { return MachineCustomization.MachineHistoryService.baseUrl; };
            MachineHistoryDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            MachineHistoryDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            MachineHistoryDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], MachineHistoryDialog);
            return MachineHistoryDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineHistoryDialog = MachineHistoryDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHistoryGrid = /** @class */ (function (_super) {
            __extends(MachineHistoryGrid, _super);
            function MachineHistoryGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineHistoryGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineHistory'; };
            MachineHistoryGrid.prototype.getDialogType = function () { return MachineCustomization.MachineHistoryDialog; };
            MachineHistoryGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineHistoryRow.idProperty; };
            MachineHistoryGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineHistoryRow.localTextPrefix; };
            MachineHistoryGrid.prototype.getService = function () { return MachineCustomization.MachineHistoryService.baseUrl; };
            MachineHistoryGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            MachineHistoryGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineHistoryGrid);
            return MachineHistoryGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineHistoryGrid = MachineHistoryGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHelpFileDialog = /** @class */ (function (_super) {
            __extends(MachineHelpFileDialog, _super);
            function MachineHelpFileDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineHelpFileForm(_this.idPrefix);
                return _this;
            }
            MachineHelpFileDialog.prototype.getFormKey = function () { return MachineCustomization.MachineHelpFileForm.formKey; };
            MachineHelpFileDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineHelpFileRow.idProperty; };
            MachineHelpFileDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineHelpFileRow.localTextPrefix; };
            MachineHelpFileDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineHelpFileRow.nameProperty; };
            MachineHelpFileDialog.prototype.getService = function () { return MachineCustomization.MachineHelpFileService.baseUrl; };
            MachineHelpFileDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            MachineHelpFileDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            MachineHelpFileDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], MachineHelpFileDialog);
            return MachineHelpFileDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineHelpFileDialog = MachineHelpFileDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHelpFileGrid = /** @class */ (function (_super) {
            __extends(MachineHelpFileGrid, _super);
            function MachineHelpFileGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineHelpFileGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineHelpFile'; };
            MachineHelpFileGrid.prototype.getDialogType = function () { return MachineCustomization.MachineHelpFileDialog; };
            MachineHelpFileGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineHelpFileRow.idProperty; };
            MachineHelpFileGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineHelpFileRow.localTextPrefix; };
            MachineHelpFileGrid.prototype.getService = function () { return MachineCustomization.MachineHelpFileService.baseUrl; };
            MachineHelpFileGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            MachineHelpFileGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineHelpFileGrid);
            return MachineHelpFileGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.MachineHelpFileGrid = MachineHelpFileGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineDialog = /** @class */ (function (_super) {
            __extends(MachineDialog, _super);
            function MachineDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineForm(_this.idPrefix);
                return _this;
            }
            MachineDialog.prototype.getFormKey = function () { return MachineCustomization.MachineForm.formKey; };
            MachineDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineRow.idProperty; };
            MachineDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineRow.localTextPrefix; };
            MachineDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineRow.nameProperty; };
            MachineDialog.prototype.getService = function () { return MachineCustomization.MachineService.baseUrl; };

            MachineDialog.prototype.onSaveSuccess = function (response) {
                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }
                this.dialogClose();
            };

            // Change the dialog title
            MachineDialog.prototype.updateTitle = function() {
                this.dialogTitle = "New Business Entity"
            }

            MachineDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);

                buttons.push({
                    title: "Update",
                    cssClass: "machine-update",
                    icon: 'fa-save text-purple',
                    onClick: () => {
                        this.save()
                    }
                })

                return buttons;
            };
            MachineDialog.prototype.updateInterface = function () {
                var _this = this;
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();

                //CVC.DialogUtils.holdingDialogAfterUpdate(this.element)

                var tableId_ele = this.form.TableId.element
                var tableId_ele_id = tableId_ele.attr("id")
                var tableId_alter_ele_id = tableId_ele_id + '_Alter'

                // added by Denis for RS 3.3 dated 7/20/2021
                var result = MachineCustomization.MachineService.FetchAllTables({}, response => {
                    var optionArr = result.responseJSON.Entities.reduce((init, current) => (init + '<option value="' + current.ObjectId + '">' + current.Name + '</option>'), "")
                    optionArr = '<option value="">--select--</option>' + optionArr

                    var select_ele_str = '<select id="' + tableId_alter_ele_id + '" class="' + tableId_ele.attr("class") + '">' +
                        optionArr +
                        '</select>'

                    // hiding TableId element and locating select element(table name dropdown)
                    $(select_ele_str).insertAfter("#" + tableId_ele_id)
                    tableId_ele.css({ "position": "absolute", "left": "-999em" })

                    var isRealTime = _this.entity.IsRealTime ? true : false
                    IsRealTimeFunc(isRealTime)

                    // added by Denis for RS 3.4 dated 7/20/2021
                    // Whenever the select value changing, set the value of the TableId element to the select value.
                    $("#" + tableId_alter_ele_id).on('change', () => {
                        var value = $("#" + tableId_alter_ele_id).val()
                        var tableName = $("#" + tableId_alter_ele_id + " option:selected").text()
                        value = (value != "") ? value : null
                        _this.form.TableId.set_value(value)
                        _this.form.TableName.set_value(tableName)
                    })

                    // It is needed on the Edit mode.
                    if (_this.entity.TableId) {
                        $("#" + tableId_alter_ele_id).val(_this.entity.TableId)
                    }
                })

                // added by Denis for RS 3.5 dated 7/20/2021
                // When IsRealTime is ON/OFF, disable/enable the table name dropdown.
                this.form.IsRealTime.change((e) => {
                    var isRealTime = _this.form.IsRealTime.value
                    /* Managing the Category-links
                     * According to show/hide Categories
                     * */
                    $("a[href$='Category2']").toggle(isRealTime)
                    $("a[href$='Category2']").prev().toggle(isRealTime)
                    $("a[href$='Category3']").toggle(isRealTime)
                    $("a[href$='Category3']").prev().toggle(isRealTime)

                    IsRealTimeFunc(isRealTime)
                })

                var IsRealTimeFunc = function (isRealTime) {
                    if (isRealTime) {
                        $("#" + tableId_alter_ele_id).css({ "opacity": "0.6", "pointer-events": "none" })
                        $("#" + tableId_alter_ele_id).val('').trigger("change")
                    }
                    else {
                        $("#" + tableId_alter_ele_id).css({ "opacity": "1", "pointer-events": "auto" })
                    }

                    // It is needed on the Edit mode.
                    if (_this.entityId) {
                        // On the Edit mode, "Is Realtime" checkbox and "Table Name" dropdown should be disabled.
                        Serenity.EditorUtils.setReadOnly(_this.form.IsRealTime, true)
                        $("#" + tableId_alter_ele_id).css({ "opacity": "0.6", "pointer-events": "none" })
                    }

                    // Toggle Required Fields according to machine type (Realtime Machine and DB Related Machine)
                    _this.form.AccessIpAddress.element.toggleClass("required", isRealTime)
                    _this.form.MachineSequence.element.toggleClass("required", isRealTime)
                    _this.form.PlcMake.element.toggleClass("required", isRealTime)
                    _this.form.TableId.element.toggleClass("required", !isRealTime)

                    // Toggle the For Realtime Machine category
                    _this.form.AccessIpAddress.element.closest('.category').toggle(isRealTime)
                    // Toggle the PLC category
                    _this.form.PlcMake.element.closest('.category').toggle(isRealTime)
                }
            };

            MachineDialog.prototype.onDialogOpen = function () {
                var waitForEl = function (selector, callback) {
                    var ele = $(selector)
                    if (ele.length) {
                        callback(ele);
                    } else {
                        setTimeout(function () {
                            waitForEl(selector, callback);
                        }, 100);
                    }
                };

                var isRealTime = this.form.IsRealTime.value

                /* Managing the Category-links
                 * According to show/hide Categories
                 * */
                $("a[href$='Category2']").toggle(isRealTime)
                $("a[href$='Category2']").prev().toggle(isRealTime)
                $("a[href$='Category3']").toggle(isRealTime)
                $("a[href$='Category3']").prev().toggle(isRealTime)

                // It is needed on the Edit mode.
                if (this.entityId) {
                    //CVC.DialogUtils.holdingDialogAfterUpdate(this.element)

                    // Hide default Update button and Show my custom Update button
                    $(".save-and-close-button").hide()

                    $("div[class*='panel-hidden']").removeClass("panel-hidden")
                    $("div[class*='panel-hidden']").removeClass((index, css) => {
                        return (css.match(/(^|\s)panel-hidden\S+/g) || []).join(' ');
                    })

                    if ($(".s-MachineCustomization-MachineDialog").length > 1) {
                        // Remove the Prior One
                        $(".s-MachineCustomization-MachineDialog").first().remove()
                    }

                    // Move the MachineDialog to the Machine Details Tab
                    // Machine Details Tab is one of 5 Tabs - Machine Details, Machine Communication, Machine Parameter, IPC Parameter and Alarm
                            //$("#tabMachineDetails").html($(".s-MachineCustomization-MachineDialog:last"))
                    waitForEl("#tabMachineDetails", function (ele) {
                        ele.html($(".s-MachineCustomization-MachineDialog:last"))
                    })
                    //$("#divMachineDetailsDisplay").html($(".s-MachineCustomization-MachineDialog:last").clone(false))
                } else {
                    // Hide my custome Update button and Show the default Save button
                    $(".machine-update").hide()
                }
            }


            MachineDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], MachineDialog);
            return MachineDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.MachineDialog = MachineDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
 
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var  MachineGrid = /** @class */ (function (_super) {
            __extends(MachineGrid, _super);
            function MachineGrid(container) {
                var _this = _super.call(this, container) || this;

                // Change the grid title
                _this.setTitle("Business Entity")

                var grid = _this.slickGrid;
                var priorMachineId = 0;
                //  var view = grid.options.view;

                //  console.log('data', grid.getData().getPagingInfo());
                //  console.log('data', grid);
                grid.getData().onPagingInfoChanged.subscribe(function (e) {
                    setTimeout(() => {
                        grid.setSelectedRows([0]);
                        grid.setActiveCell([]);
                    }, 100);
                });

                // setTimeout(() => this.slickGrid.setSelectedRows([0]), 400);
                // setTimeout(() => this.slickGrid.setSelectedRows([0]), 400);

                grid.onSelectedRowsChanged.subscribe(function () {
                    var selectedRow = grid.getSelectedRows()[0];
                    var record = grid.getDataItem(selectedRow);
                    currentReportType = record.Id;

                    // It is very Important to avoid double ajax calls.
                    if (priorMachineId == record.MachineId) return
                    priorMachineId = record.MachineId

                    // Direct to Machine Edit Mode.
                    window.location.href = "/MachineCustomization/Machine#edit/" + record.MachineId
                    
                    jQuery.get('/MachineCustomization/Machine/GetMachineDetails?machineId=' + record.MachineId, function (data) {

                        $("#divMachineDetails").html(data);
                        //$("#hdnMachineId").val(data.MachineId);
                        //$("#txtMachineName").val(data.MachineName);
                        //$("#txtMachineSequence").val(data.MachineSequence);
                        //$("#txtAccessIp").val(data.AccessIPAddress);
                        //$("#txtDescription").val(data.Description);
                        //$("#txtModelNumber").val(data.ModelNumber);
                        //$("#txtSerialNumber").val(data.SerialNumber);
                        //$("#txtMake").val(data.Make);
                        //$("#txtYear").val(data.Year);
                        //$("#txtPLCMake").val(data.PlcMake);
                        //$("#txtPLCModelNumber").val(data.PlcModelNumber);
                        //$("#txtPLCSerialNumber").val(data.PlcSerialNumber);
                        //$("#txtPLCAddress").val(data.PLCAddress);

                        /*
                        $("#lblMachineName").text($("#txtMachineName").val());
                        $("#lblMachineSequence").text($("#txtMachineSequence").val());
                        $("#lblAccessIp").text($("#txtAccessIp").val());
                        $("#lblDescription").text($("#txtDescription").val());
                        $("#lblModelNumber").text($("#txtModelNumber").val());
                        $("#lblSerialNumber").text($("#txtSerialNumber").val());
                        $("#lblMake").text($("#txtMake").val());
                        $("#lblYear").text($("#txtYear").val());
                        $("#lblPLCMake").text($("#txtPLCMake").val());
                        $("#lblPLCModelNumber").text($("#txtPLCModelNumber").val());
                        $("#lblPLCSerialNumber").text($("#txtPLCSerialNumber").val());
                        $("#lblPLCAddress").text($("#txtPLCAddress").val());
                        $("#lblStatus").text($("#ddlStatus option:selected").text());

                        $("#MachineName").text($("#txtMachineName").val());
                        $("#MachineSequence").text($("#txtMachineSequence").val());
                        $("#AccessIpAddress").text($("#txtAccessIp").val());
                        $("#Description").text($("#txtDescription").val());
                        $("#ModelNumber").text($("#txtModelNumber").val());
                        $("#SerialNumber").text($("#txtSerialNumber").val());
                        $("#Make").text($("#txtMake").val());
                        $("#Year").text($("#txtYear").val());
                        $("#PlcMake").text($("#txtPLCMake").val());
                        $("#PlcModelNumber").text($("#txtPLCModelNumber").val());
                        $("#PlcSerialNumber").text($("#txtPLCSerialNumber").val());
                        $("#PlcAddress").text($("#txtPLCAddress").val());
                        $("#StatusId").text($("#ddlStatus option:selected").text());*/

                        $("#divMachineDetails").attr("style","display:block");

                        //  Q.blockUndo();
                        //initializeForm();
                    });
                });




                return _this;
            }
            //MachineGrid.PageChanged.subscribe(function (e, args) {
            //    alert("ddd");
            //    if (args.cell == 3) { // Assuming that your checkbox is 3rd column
            //        //Your check box change event 
            //    }
            //});

            MachineGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.Machine'; };
            MachineGrid.prototype.getDialogType = function () { return MachineCustomization.MachineDialog; };
            MachineGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineRow.idProperty; };
            MachineGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineRow.localTextPrefix; };
            MachineGrid.prototype.getService = function () { return MachineCustomization.MachineService.baseUrl; };
            MachineGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);

                // Change the caption of 'add-button'
                var newBtn = Q.first(buttons, x => x.cssClass == "add-button");
                newBtn.title = Q.text("New Entity")

                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));

                if ($("#hdnMachineImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            // cssClass: 'stampe',
                            // icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('machine');
                            }
                        });
                }

                return buttons;
            };

            //MachineGrid.prototype.getRows = function () {
            //    var _this = this;
            //    console.log(_this);
            //    return rows;
            //};

            // After loaded the grid data, replacing table object id with table name.
            //MachineGrid.prototype.createView = function () {
            //    var view = _super.prototype.createView.call(this);
            //    view.onDataLoaded.subscribe(function (e, ui) {
            //        var result = MachineCustomization.MachineService.FetchAllTables({}, function (response) {
            //            var tableIdObj = result.responseJSON.Entities.reduce(function (init, ele) { init[ele.ObjectId] = ele.Name; return init; }, {});
            //            $('.table-id').each(function (num, ele) { $(ele).text(tableIdObj[$(ele).text()]); });
            //        });
            //        //Q.notifyInfo($('.table-id').first().text());
            //    });
            //    return view;
            //}


            MachineGrid.prototype.getSlickOptions = function () {
                var opt = _super.prototype.getSlickOptions.call(this);
                opt.enableTextSelectionOnCells = true;
                //  opt.selectedCellCssClass = "slickgrid-row-selected";
                opt.enableCellNavigation = true;
                opt.autoHeight = false;
                return opt;
            };

            //MachineGrid.prototype.getInitialTitle = function () {
            //    return null;
            //};
            MachineGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineGrid);
            return MachineGrid;
        }(CVC.SelectableEntityGrid));
        MachineCustomization.MachineGrid = MachineGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineMaintenanceScheduleDialog = /** @class */ (function (_super) {
            __extends(LineMaintenanceScheduleDialog, _super);
            function LineMaintenanceScheduleDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.LineMaintenanceScheduleForm(_this.idPrefix);
                return _this;
            }
            LineMaintenanceScheduleDialog.prototype.getFormKey = function () { return MachineCustomization.LineMaintenanceScheduleForm.formKey; };
            LineMaintenanceScheduleDialog.prototype.getIdProperty = function () { return MachineCustomization.LineMaintenanceScheduleRow.idProperty; };
            LineMaintenanceScheduleDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.LineMaintenanceScheduleRow.localTextPrefix; };
            LineMaintenanceScheduleDialog.prototype.getNameProperty = function () { return MachineCustomization.LineMaintenanceScheduleRow.nameProperty; };
            LineMaintenanceScheduleDialog.prototype.getService = function () { return MachineCustomization.LineMaintenanceScheduleService.baseUrl; };
            LineMaintenanceScheduleDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            LineMaintenanceScheduleDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            LineMaintenanceScheduleDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], LineMaintenanceScheduleDialog);
            return LineMaintenanceScheduleDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.LineMaintenanceScheduleDialog = LineMaintenanceScheduleDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineMaintenanceScheduleGrid = /** @class */ (function (_super) {
            __extends(LineMaintenanceScheduleGrid, _super);
            function LineMaintenanceScheduleGrid(container) {
                return _super.call(this, container) || this;
            }
            LineMaintenanceScheduleGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.LineMaintenanceSchedule'; };
            LineMaintenanceScheduleGrid.prototype.getDialogType = function () { return MachineCustomization.LineMaintenanceScheduleDialog; };
            LineMaintenanceScheduleGrid.prototype.getIdProperty = function () { return MachineCustomization.LineMaintenanceScheduleRow.idProperty; };
            LineMaintenanceScheduleGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.LineMaintenanceScheduleRow.localTextPrefix; };
            LineMaintenanceScheduleGrid.prototype.getService = function () { return MachineCustomization.LineMaintenanceScheduleService.baseUrl; };
            LineMaintenanceScheduleGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            LineMaintenanceScheduleGrid.prototype.getInitialTitle = function () {
                return null;
            };
            LineMaintenanceScheduleGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], LineMaintenanceScheduleGrid);
            return LineMaintenanceScheduleGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.LineMaintenanceScheduleGrid = LineMaintenanceScheduleGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmResetIdDialog = /** @class */ (function (_super) {
            __extends(AlarmResetIdDialog, _super);
            function AlarmResetIdDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.AlarmResetIdForm(_this.idPrefix);
                return _this;
            }
            AlarmResetIdDialog.prototype.getFormKey = function () { return MachineCustomization.AlarmResetIdForm.formKey; };
            AlarmResetIdDialog.prototype.getIdProperty = function () { return MachineCustomization.AlarmResetIdRow.idProperty; };
            AlarmResetIdDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.AlarmResetIdRow.localTextPrefix; };
            AlarmResetIdDialog.prototype.getService = function () { return MachineCustomization.AlarmResetIdService.baseUrl; };
            AlarmResetIdDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], AlarmResetIdDialog);
            return AlarmResetIdDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.AlarmResetIdDialog = AlarmResetIdDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmResetIdGrid = /** @class */ (function (_super) {
            __extends(AlarmResetIdGrid, _super);
            function AlarmResetIdGrid(container) {
                return _super.call(this, container) || this;
            }
            AlarmResetIdGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.AlarmResetId'; };
            AlarmResetIdGrid.prototype.getDialogType = function () { return MachineCustomization.AlarmResetIdDialog; };
            AlarmResetIdGrid.prototype.getIdProperty = function () { return MachineCustomization.AlarmResetIdRow.idProperty; };
            AlarmResetIdGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.AlarmResetIdRow.localTextPrefix; };
            AlarmResetIdGrid.prototype.getService = function () { return MachineCustomization.AlarmResetIdService.baseUrl; };
            AlarmResetIdGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            AlarmResetIdGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], AlarmResetIdGrid);
            return AlarmResetIdGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.AlarmResetIdGrid = AlarmResetIdGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmDialog = /** @class */ (function (_super) {
            __extends(AlarmDialog, _super);
            function AlarmDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.AlarmForm(_this.idPrefix);
                return _this;
            }
            AlarmDialog.prototype.getFormKey = function () { return MachineCustomization.AlarmForm.formKey; };
            AlarmDialog.prototype.getIdProperty = function () { return MachineCustomization.AlarmRow.idProperty; };
            AlarmDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.AlarmRow.localTextPrefix; };
            AlarmDialog.prototype.getNameProperty = function () { return MachineCustomization.AlarmRow.nameProperty; };
            AlarmDialog.prototype.getService = function () { return MachineCustomization.AlarmService.baseUrl; };

            AlarmDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };

     

            AlarmDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            AlarmDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                //this.toolbar.findButton("delete-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };

            //AlarmDialog.prototype.onDialogOpen = function () {

            //    _super.prototype.afterLoadEntity.call(this);
            //    $("input[name='AlarmName'],input[name='Message'],input[name='Description']").keyboard({
            //        layout: 'custom',
            //        customLayout: alphanumericKeyboard
            //    })


            //}

            AlarmDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);

                if (this.isNew()) {
                   this.form.MachineId.value = $("#MachineId").val()/*$("#hdnMachineId").val()*/;
                    //this.form.MachineId.get_items()[5].id;
                    this.form.MachineId.element.triggerHandler("change"); //if there is some change handler you've set
                }
                this.form.MachineId.changeSelect2(function () {
                    alert("hhhh");
                });

            };





            AlarmDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], AlarmDialog);
            return AlarmDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.AlarmDialog = AlarmDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmGrid = /** @class */ (function (_super) {
            __extends(AlarmGrid, _super);
            function AlarmGrid(container) {
                return _super.call(this, container) || this;
            }
            AlarmGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.Alarm'; };
            AlarmGrid.prototype.getDialogType = function () { return MachineCustomization.AlarmDialog; };
            AlarmGrid.prototype.getIdProperty = function () { return MachineCustomization.AlarmRow.idProperty; };
            AlarmGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.AlarmRow.localTextPrefix; };
            AlarmGrid.prototype.getService = function () { return MachineCustomization.AlarmService.baseUrl; };
            AlarmGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnIsImportAccessForAlarm").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //style: 'height:29px',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('alarm');

                            }
                        }
                    );
                }
                return buttons;
            };

            AlarmGrid.prototype.onViewSubmit = function () {
                if (!_super.prototype.onViewSubmit.call(this)) {
                    return false;
                }
                var request = this.view.params;
                var machineId = $("#MachineId").val()/*$("#hdnMachineId").val()*/;
                request.EqualityFilter.MachineId = machineId;

                return true;
            };


            AlarmGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], AlarmGrid);
            return AlarmGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.AlarmGrid = AlarmGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Machine;
    (function (Machine) {
        var MachineRecipeCheckEditor = /** @class */ (function (_super) {
            __extends(MachineRecipeCheckEditor, _super);
            function MachineRecipeCheckEditor() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineRecipeCheckEditor = __decorate([
                Serenity.Decorators.registerEditor([Serenity.IGetEditValue, Serenity.ISetEditValue])
            ], MachineRecipeCheckEditor);
            return MachineRecipeCheckEditor;
        }(Serenity.DataGrid));
        Machine.MachineRecipeCheckEditor = MachineRecipeCheckEditor;
    })(Machine = CVC.Machine || (CVC.Machine = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Machine;
    (function (Machine) {
        var MachineRecipeDialog = /** @class */ (function (_super) {
            __extends(MachineRecipeDialog, _super);
            function MachineRecipeDialog() {
                var _this = _super.call(this) || this;
                //var _this = _super.call(this, opt) || this;
                //alert("test");
                _this.machineRecipeGrid = new CVC.MachineCustomization.MachineRecipeGrid(_this.byId("MachineRecipeGrid"));

                //machine.MachineRecipeService.List({
                //    Skip: _this.options.Skip
                //}, function (response) {
                //    _this.permissions.value = response.Entities.map(function (x) { return x.toString(); });
                //});
               // alert(_this.options.Skip);
                return _this;
            }


            //nar16jan2019
            //MachineRecipeDialog.prototype.getColumns = function () {
            //    var _this = this;
            //    var columns = _super.prototype.getColumns.call(this);
               
            //        var applycolumn = {
            //            name: 'Download Report',
            //            field: 'IsApplied',
            //            width: 300,
            //            sortable: false,

            //            format: function (ctx) {
            //                return Q.outerHtml($('<button/>')
            //                    .addClass('target-text')
            //                    .attr('height', 50)
            //                    //.attr('onclick', 'DownloadRecipeReport(' + ctx.item.MachineRecipeId + ');')
            //                    .text('Download Report'));
            //            }
            //        }
            //        columns.splice(2, 0, applycolumn);
                


              

            //    return columns;
            //};


            //nar16jan2019end





            //Machine.MachineRecipeService.List({
            //    Skip: _this.options.Skip
            //}
            MachineRecipeDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                //this.MachineRecipeGrid. = this.entityId;
            };
            MachineRecipeDialog.prototype.onDialogClose = function () {
                Serenity.SubDialogHelper.triggerDataChange(this);
                _super.prototype.onDialogClose.call(this);
            };
            MachineRecipeDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineRecipeDialog);
            return MachineRecipeDialog;
        }(Serenity.EntityDialog));
        Machine.MachineRecipeDialog = MachineRecipeDialog;
    })(Machine = CVC.Machine || (CVC.Machine = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var ProtocolDialog = /** @class */ (function (_super) {
            __extends(ProtocolDialog, _super);
            function ProtocolDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new ExternalApplicationInterface.ProtocolForm(_this.idPrefix);
                return _this;
            }
            ProtocolDialog.prototype.getFormKey = function () { return ExternalApplicationInterface.ProtocolForm.formKey; };
            ProtocolDialog.prototype.getIdProperty = function () { return ExternalApplicationInterface.ProtocolRow.idProperty; };
            ProtocolDialog.prototype.getLocalTextPrefix = function () { return ExternalApplicationInterface.ProtocolRow.localTextPrefix; };
            ProtocolDialog.prototype.getNameProperty = function () { return ExternalApplicationInterface.ProtocolRow.nameProperty; };
            ProtocolDialog.prototype.getService = function () { return ExternalApplicationInterface.ProtocolService.baseUrl; };

            ProtocolDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            ProtocolDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);

                return buttons;
            };
            ProtocolDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };

            ProtocolDialog.prototype.onDialogOpen = function () {
                $("input[name='ProtocolName']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })

            }

            ProtocolDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], ProtocolDialog);
            return ProtocolDialog;
        }(Serenity.EntityDialog));
        ExternalApplicationInterface.ProtocolDialog = ProtocolDialog;
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var ProtocolGrid = /** @class */ (function (_super) {
            __extends(ProtocolGrid, _super);
            function ProtocolGrid(container) {
                return _super.call(this, container) || this;
            }
            ProtocolGrid.prototype.getColumnsKey = function () { return 'ExternalApplicationInterface.Protocol'; };
            ProtocolGrid.prototype.getDialogType = function () { return ExternalApplicationInterface.ProtocolDialog; };
            ProtocolGrid.prototype.getIdProperty = function () { return ExternalApplicationInterface.ProtocolRow.idProperty; };
            ProtocolGrid.prototype.getLocalTextPrefix = function () { return ExternalApplicationInterface.ProtocolRow.localTextPrefix; };
            ProtocolGrid.prototype.getService = function () { return ExternalApplicationInterface.ProtocolService.baseUrl; };
            ProtocolGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnProtocolImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //  style: 'height:29px',
                            // icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('protocol');

                            },
                        }
                    );
                }
                return buttons;
            };


            ProtocolGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ProtocolGrid);
            return ProtocolGrid;
        }(Serenity.EntityGrid));
        ExternalApplicationInterface.ProtocolGrid = ProtocolGrid;
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var MachineCommunicationDialog = /** @class */ (function (_super) {
            __extends(MachineCommunicationDialog, _super);
            function MachineCommunicationDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new ExternalApplicationInterface.MachineCommunicationForm(_this.idPrefix);

                // console.log(_this.form.__proto__.MachineId);



                return _this;
            }

            //MachineCommunicationDialog.MachineCommunicationForm.MachineId.ChangeSelect2(e => {
            //    console.log('sdf');
            //});

            MachineCommunicationDialog.prototype.getFormKey = function () { return ExternalApplicationInterface.MachineCommunicationForm.formKey; };
            MachineCommunicationDialog.prototype.getIdProperty = function () { return ExternalApplicationInterface.MachineCommunicationRow.idProperty; };
            MachineCommunicationDialog.prototype.getLocalTextPrefix = function () { return ExternalApplicationInterface.MachineCommunicationRow.localTextPrefix; };
            MachineCommunicationDialog.prototype.getNameProperty = function () { return ExternalApplicationInterface.MachineCommunicationRow.nameProperty; };
            MachineCommunicationDialog.prototype.getService = function () { return ExternalApplicationInterface.MachineCommunicationService.baseUrl; };

            MachineCommunicationDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            MachineCommunicationDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            MachineCommunicationDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();

            };


            MachineCommunicationDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);

                if (this.isNew()) {
                    this.form.MachineId.value = $("#MachineId").val()/*$("#hdnMachineId").val()*/;
                    //this.form.MachineId.get_items()[5].id;
                 //   this.form.MachineId.element.triggerHandler("change"); //if there is some change handler you've set
                }
                var localfrm = this.form;

               // localfrm.MachineId.element.toggleClass('readonly',true);
             //   localfrm.MDBPath.element.toggleClass('required', true);


                //this.form.MDBPath.addValidationRule(this.uniqueName, function (e) {                   
                //        return "Password must be at least 7 characters!";
                //}); 
              //  console.log("mcom", this.form.SecurityModeId.itemById[74].text);

                var protocolTypeId = this.form.ProtocolTypeId.value;
                if (protocolTypeId != "") {
                    var protocolTypeName = this.form.ProtocolTypeId.itemById[this.form.ProtocolTypeId.value].text;
                    if (protocolTypeName.toLowerCase() == "mdb") {
                        showMDBFields(localfrm);
                    }
                    else {
                        hideMDBFields(localfrm);
                    }

                    if (protocolTypeName.toLowerCase() == "opc ua client") {
                        showOpcUaClientFields(localfrm);
                    }
                    else {
                        hideOpcUaClientFields(localfrm);
                    }

                    if (this.form.SecurityModeId.value != "") {
                        var securityModeName = this.form.SecurityModeId.itemById[this.form.SecurityModeId.value].text;

                        if (securityModeName.toLowerCase() == "sign" || securityModeName.toLowerCase() == "signandencrypt") {
                            showSecurityPolicyForOpcUaClient(localfrm);
                        }
                        else {
                            hideSecurityPolicyForOpcUaClient(localfrm);
                        }
                    }

                    if (this.form.UserIdentityId.value != "") {

                        var userIdentityName = this.form.UserIdentityId.itemById[this.form.UserIdentityId.value].text;

                        if (userIdentityName.toLowerCase() == "username") {
                            showUserAuthentcationForOpcUaClient(localfrm);
                        }
                        else {
                            hideUserAuthentcationForOpcUaClient(localfrm);
                        }
                    }

                    if (protocolTypeName.toLowerCase() == "siemens s7 net") {
                        showSiemensS7Fields(localfrm);
                    }
                    else {
                        hideSiemensS7Fields(localfrm);
                    }

                }
                else {
                    hideMDBFields(localfrm);
                    hideOpcUaClientFields(localfrm);
                    hideSiemensS7Fields(localfrm);
                }

                this.form.ProtocolTypeId.changeSelect2(function (e) {
//var text=this.toolbar.element.find(".Protocol").getWidget(Serenity.LookupEditor).get_text();
//var text1=this.form.ProtocolTypeId.get_text();
//console.log(text1);

                    if (e.added.text.toLowerCase() == "mdb") {
                        showMDBFields(localfrm);
                    }
                    else {
                        hideMDBFields(localfrm);
                    }

                    if (e.added.text.toLowerCase() == "opc ua client") {
                        showOpcUaClientFields(localfrm);
                    }
                    else {
                        hideOpcUaClientFields(localfrm);
                    }

                    if (e.added.text.toLowerCase() == "siemens s7 net") {
                        showSiemensS7Fields(localfrm);
                    }
                    else {
                        hideSiemensS7Fields(localfrm);
                    }


                });
                //this.form.MachineId.changeSelect2(function (e) {
                //    console.log('dfgdfg');
                //});
                // these fields are only required in new record mode
                //this.form.Password.element.toggleClass('required', this.isNew())
                //    .closest('.field').find('sup').toggle(this.isNew());
                //this.form.PasswordConfirm.element.toggleClass('required', this.isNew())
                //    .closest('.field').find('sup').toggle(this.isNew());
           
                this.form.SecurityModeId.changeSelect2(function (e) {
                    if (e.added.text.toLowerCase() == "sign" || e.added.text.toLowerCase() == "signandencrypt") {
                        showSecurityPolicyForOpcUaClient(localfrm);
                    }
                    else {
                        hideSecurityPolicyForOpcUaClient(localfrm);

                    }
                    
                });

                this.form.UserIdentityId.changeSelect2(function (e) {
                    if (e.added.text.toLowerCase() == "username") {
                        showUserAuthentcationForOpcUaClient(localfrm);
                    }
                    else {
                        hideUserAuthentcationForOpcUaClient(localfrm);

                    }

                });
               
                
            };

            function showMDBFields(localfrm) {
                $('.MDBPath').show();
                localfrm.MDBPath.element.toggleClass('required', true);
            }

            function hideMDBFields(localfrm) {
                $('.MDBPath').hide();
                localfrm.MDBPath.element.toggleClass('required', false);
            }

            function showOpcUaClientFields(localfrm) {
                localfrm.SecurityModeId.element.closest('.category').toggle(true);
                localfrm.UserIdentityId.element.closest('.category').toggle(true);
                $('.SecurityModeId').show();
                $('.UserIdentityId').show();
            }

            function hideOpcUaClientFields(localfrm) {
                localfrm.SecurityModeId.element.closest('.category').toggle(false);
                localfrm.UserIdentityId.element.closest('.category').toggle(false);
                $('.SecurityModeId').hide();
                $('.SecurityPolicyId').hide();
                $('.UserIdentityId').hide();
                $('.UserName').hide();
                $('.Password').hide();
            }

            function showSecurityPolicyForOpcUaClient(localfrm) {
                $('.SecurityPolicyId').show();
                localfrm.SecurityPolicyId.element.toggleClass('required', true);

            }

            function hideSecurityPolicyForOpcUaClient(localfrm) {
                $('.SecurityPolicyId').hide();
                localfrm.SecurityPolicyId.element.toggleClass('required', false);

            }

            function showUserAuthentcationForOpcUaClient(localfrm) {
                $('.UserName').show();
                $('.Password').show();
                localfrm.UserName.element.toggleClass('required', true);
                localfrm.Password.element.toggleClass('required', true);

            }

            function hideUserAuthentcationForOpcUaClient(localfrm) {
                $('.UserName').hide();
                $('.Password').hide();
                localfrm.UserName.element.toggleClass('required', false);
                localfrm.Password.element.toggleClass('required', false);

            }

            function showSiemensS7Fields(localfrm) {
                localfrm.CpuTypeId.element.closest('.category').toggle(true);
                $('.CpuTypeId').show();
                $('.Rack').show();
                $('.Slot').show();
                localfrm.CpuTypeId.element.toggleClass('required', true);
                localfrm.Rack.element.toggleClass('required', true);
                localfrm.Slot.element.toggleClass('required', true);

            }

            function hideSiemensS7Fields(localfrm) {
                localfrm.CpuTypeId.element.closest('.category').toggle(false);
                $('.CpuTypeId').hide();
                $('.Rack').hide();
                $('.Slot').hide();
            }


            MachineCommunicationDialog.prototype.onDialogOpen = function () {
                $("input[name='IpAddress'],input[name='TcpipPort'],input[name='PollRate'],input[name='Rack'],input[name='Slot']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '7 8 9',
                            '4 5 6',
                            '1 2 3',
                            '{bksp} 0 .',
                            '{a} {c}'
                        ]

                    }
                })


                $("input[name='MDBPath'],input[name='UserName'],input[name='Password']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })
            }





            MachineCommunicationDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], MachineCommunicationDialog);
            return MachineCommunicationDialog;
        }(Serenity.EntityDialog));
        ExternalApplicationInterface.MachineCommunicationDialog = MachineCommunicationDialog;
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var MachineCommunicationGrid = /** @class */ (function (_super) {
            __extends(MachineCommunicationGrid, _super);
            function MachineCommunicationGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineCommunicationGrid.prototype.getColumnsKey = function () { return 'ExternalApplicationInterface.MachineCommunication'; };
            MachineCommunicationGrid.prototype.getDialogType = function () { return ExternalApplicationInterface.MachineCommunicationDialog; };
            MachineCommunicationGrid.prototype.getIdProperty = function () { return ExternalApplicationInterface.MachineCommunicationRow.idProperty; };
            MachineCommunicationGrid.prototype.getLocalTextPrefix = function () { return ExternalApplicationInterface.MachineCommunicationRow.localTextPrefix; };
            MachineCommunicationGrid.prototype.getService = function () { return ExternalApplicationInterface.MachineCommunicationService.baseUrl; };
            MachineCommunicationGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], MachineCommunicationGrid);

            MachineCommunicationGrid.prototype.onClick = function (e, row, cell) {
                _super.prototype.onClick.call(this, e, row, cell);
                var machineCommunicationGrid = this;
                setTimeout(function () { machineCommunicationGrid.refresh(); }, 2500);
            };

            MachineCommunicationGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnIsImportAccessForMachineCommunication").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            // style: 'height:29px',
                            // icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('machineCommunication');

                            },
                        }
                    );
                }
                return buttons;
            };


            MachineCommunicationGrid.prototype.getColumns = function () {
                var _this = this;
                //var buttons = _super.prototype.getButtons.call(this);
                var columns = _super.prototype.getColumns.call(this);

                var applyConnectColumn = {
                    name: 'Connect',
                    field: 'IsConnected',
                    width: 100,
                    sortable: false,

                    format: function (ctx) {
                        if (ctx.item.ProtocolName.toLowerCase() == "opc ua client" && ctx.item.IsConnected != true) {

                            return Q.outerHtml($('<button/>')
                                .addClass('btn btn-primary')
                                .attr('height', 40)
                                .attr('style', 'padding:3px 12px')

                                .attr('onclick', 'connectToOpcUaClient(' + ctx.item.MachineId + ',"gg"); ')
                                .text('Connect'));
                        }
                    }
                };

                var applyFetchColumn = {
                    name: 'Fetch',
                    field: 'IsFetch',
                    width: 200,
                    sortable: false,

                    format: function (ctx) {
                        if (ctx.item.ProtocolName !== undefined) {
                            if (ctx.item.ProtocolName.toLowerCase() == "opc ua client" && ctx.item.IsConnected == true) {

                                return Q.outerHtml($('<button/>')
                                    .addClass('btn btn-primary')
                                    .attr('height', 40)
                                    .attr('style', 'padding:3px 12px')

                                    .attr('onclick', 'fetch(' + ctx.item.MachineId + '); ')
                                    .text('Fetch Address Space'));
                            }
                        }
                    }
                }

                columns.splice(6, 0, applyConnectColumn);
                columns.splice(7, 0, applyFetchColumn);
                return columns;
            };

            MachineCommunicationGrid.prototype.onViewSubmit = function () {
                if (!_super.prototype.onViewSubmit.call(this)) {
                    return false;
                }
                var request = this.view.params;
                var machineId = $("#MachineId").val()/*$("#hdnMachineId").val()*/;
                request.EqualityFilter.MachineId = machineId;

                return true;
            };


            return MachineCommunicationGrid;
        }(Serenity.EntityGrid));
        ExternalApplicationInterface.MachineCommunicationGrid = MachineCommunicationGrid;
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var IpcParameterDialog = /** @class */ (function (_super) {
            __extends(IpcParameterDialog, _super);
            function IpcParameterDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new ExternalApplicationInterface.IpcParameterForm(_this.idPrefix);
                return _this;
            }
            IpcParameterDialog.prototype.getFormKey = function () { return ExternalApplicationInterface.IpcParameterForm.formKey; };
            IpcParameterDialog.prototype.getIdProperty = function () { return ExternalApplicationInterface.IpcParameterRow.idProperty; };
            IpcParameterDialog.prototype.getLocalTextPrefix = function () { return ExternalApplicationInterface.IpcParameterRow.localTextPrefix; };
            IpcParameterDialog.prototype.getNameProperty = function () { return ExternalApplicationInterface.IpcParameterRow.nameProperty; };
            IpcParameterDialog.prototype.getService = function () { return ExternalApplicationInterface.IpcParameterService.baseUrl; };

            IpcParameterDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            IpcParameterDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };

            IpcParameterDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };
           
            IpcParameterDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);

                if (this.isNew()) {
                    this.form.MachineId.value = $("#MachineId").val()/*$("#hdnMachineId").val()*/;
                    //this.form.MachineId.get_items()[5].id;
                    this.form.MachineId.element.triggerHandler("change"); //if there is some change handler you've set
                }



                var localfrm = this.form;
               // var machineId = this.form.MachineId.Value;
               // $('<a class="btn btn-primary" style="margin-left:20px">Fetch Node<\/a>')
                  //  .insertAfter(this.form.IpcAddress.element)  // <======================
                  //  .click(() => myFunction(1));


                if (this.form.IsBitWise.value == true) {
                    $('.BitWiseIndex').show();
                    this.form.BitWiseIndex.element.toggleClass('required', true);
                }
                else {
                    $('.BitWiseIndex').hide();
                    this.form.BitWiseIndex.element.toggleClass('required', false);
                }

                if (this.form.Is32Bit.value == true) {
                    $('.Bit32Address').show();
                    this.form.Bit32Address.element.toggleClass('required', true);
                }
                else {
                    $('.Bit32Address').hide();
                    this.form.Bit32Address.element.toggleClass('required', false);
                }

                this.form.IsBitWise.change(function (e) {
                    if (localfrm.IsBitWise.value == true) {
                        $('.BitWiseIndex').show();
                        localfrm.BitWiseIndex.element.toggleClass('required', true);
                    }
                    else {
                        $('.BitWiseIndex').hide();
                        localfrm.BitWiseIndex.element.toggleClass('required', false);
                    }
                });

                this.form.Is32Bit.change(function (e) {
                    if (localfrm.Is32Bit.value == true) {
                        $('.Bit32Address').show();
                        localfrm.Bit32Address.element.toggleClass('required', true);
                    }
                    else {
                        $('.Bit32Address').hide();
                        localfrm.Bit32Address.element.toggleClass('required', false);
                    }
                });

                this.form.MachineId.changeSelect2(function (e) {
                    alert("fired ipc");
                    var machineId = localfrm.MachineId.value;
                    var protocolName = "";
                    $.ajax({
                        url: Q.resolveUrl('~/Common/GetProtocolTypeByMachineId'),
                        type: 'GET',
                        async: true,
                        data: { "machineId": machineId },
                        success: function (response) {
                            protocolName = response;
                            if (protocolName.toLowerCase() == "opc ua client") {
                                $('.IpcAddress').hide();
                                $('.NodeId').show();
                                $('.AttributeId').show();
                            }
                            else {
                                $('.IpcAddress').show();
                                $('.NodeId').hide();
                                //$('.AttributeId').hide();

                            }

                        },
                        error: function (x, y, z) {

                        }
                    });

                });


            };

          
            IpcParameterDialog.prototype.onDialogOpen = function () {
                $("input[name='IpcAddress'],input[name='DisableParameterValueIPC'],input[name='StartNumber'],input[name='StartNumber'],input[name='EndNumber'],input[name='IncrementalNumber'],input[name='HeartBeatFailedTime'],input[name='OperationValueIPC']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '7 8 9',
                            '4 5 6',
                            '1 2 3',
                            '{bksp} 0 .',
                            '{a} {c}'
                        ]

                    }
                })


                $("input[name='IpcParameterName']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })

            }
            IpcParameterDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], IpcParameterDialog);
            return IpcParameterDialog;
        }(Serenity.EntityDialog));
        ExternalApplicationInterface.IpcParameterDialog = IpcParameterDialog;
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var IpcParameterGrid = /** @class */ (function (_super) {
            __extends(IpcParameterGrid, _super);
            function IpcParameterGrid(container) {
                return _super.call(this, container) || this;
            }
            IpcParameterGrid.prototype.getColumnsKey = function () { return 'ExternalApplicationInterface.IpcParameter'; };
            IpcParameterGrid.prototype.getDialogType = function () { return ExternalApplicationInterface.IpcParameterDialog; };
            IpcParameterGrid.prototype.getIdProperty = function () { return ExternalApplicationInterface.IpcParameterRow.idProperty; };
            IpcParameterGrid.prototype.getLocalTextPrefix = function () { return ExternalApplicationInterface.IpcParameterRow.localTextPrefix; };
            IpcParameterGrid.prototype.getService = function () { return ExternalApplicationInterface.IpcParameterService.baseUrl; };

            IpcParameterGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnIsImportAccessForIpcParameter").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //style: 'height:29px',
                            // icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('ipcParameter');

                            }
                        }
                    );
                }
                return buttons;
            };

            IpcParameterGrid.prototype.onViewSubmit = function () {
                if (!_super.prototype.onViewSubmit.call(this)) {
                    return false;
                }
                var request = this.view.params;
                var machineId = $("#MachineId").val()/*$("#hdnMachineId").val()*/;
                request.EqualityFilter.MachineId = machineId;
                return true;
            };


            IpcParameterGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], IpcParameterGrid);
            return IpcParameterGrid;
        }(Serenity.EntityGrid));
        ExternalApplicationInterface.IpcParameterGrid = IpcParameterGrid;
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var TranslationGrid = /** @class */ (function (_super) {
            __extends(TranslationGrid, _super);
            function TranslationGrid(container) {
                var _this = _super.call(this, container) || this;
                _this.element.on('keyup.' + _this.uniqueName + ' change.' + _this.uniqueName, 'input.custom-text', function (e) {
                    var value = Q.trimToNull($(e.target).val());
                    if (value === '') {
                        value = null;
                    }
                    _this.view.getItemById($(e.target).data('key')).CustomText = value;
                    _this.hasChanges = true;
                });
                return _this;
            }
            TranslationGrid.prototype.getIdProperty = function () { return "Key"; };
            TranslationGrid.prototype.getLocalTextPrefix = function () { return "Configuration.Translation"; };
            TranslationGrid.prototype.getService = function () { return Configuration.TranslationService.baseUrl; };
            TranslationGrid.prototype.onClick = function (e, row, cell) {
                var _this = this;
                _super.prototype.onClick.call(this, e, row, cell);
                if (e.isDefaultPrevented()) {
                    return;
                }
                var item = this.itemAt(row);
                var done;
                if ($(e.target).hasClass('source-text')) {
                    e.preventDefault();
                    done = function () {
                        item.CustomText = item.SourceText;
                        _this.view.updateItem(item.Key, item);
                        _this.hasChanges = true;
                    };
                    if (Q.isTrimmedEmpty(item.CustomText) ||
                        (Q.trimToEmpty(item.CustomText) === Q.trimToEmpty(item.SourceText))) {
                        done();
                        return;
                    }
                    Q.confirm(Q.text('Db.Administration.Translation.OverrideConfirmation'), done);
                    return;
                }
                if ($(e.target).hasClass('target-text')) {
                    e.preventDefault();
                    done = function () {
                        item.CustomText = item.TargetText;
                        _this.view.updateItem(item.Key, item);
                        _this.hasChanges = true;
                    };
                    if (Q.isTrimmedEmpty(item.CustomText) ||
                        (Q.trimToEmpty(item.CustomText) === Q.trimToEmpty(item.TargetText))) {
                        done();
                        return;
                    }
                    Q.confirm(Q.text('Db.Administration.Translation.OverrideConfirmation'), done);
                    return;
                }
            };
            TranslationGrid.prototype.getColumns = function () {
                var columns = [];
                columns.push({ field: 'Key', width: 300, sortable: false });
                columns.push({
                    field: 'SourceText',
                    width: 300,
                    sortable: false,
                    format: function (ctx) {
                        return Q.outerHtml($('<a/>')
                            .addClass('source-text')
                            .text(ctx.value || ''));
                    }
                });
                columns.push({
                    field: 'CustomText',
                    width: 300,
                    sortable: false,
                    format: function (ctx) {
                        return Q.outerHtml($('<input/>')
                            .addClass('custom-text')
                            .attr('value', ctx.value)
                            .attr('type', 'text')
                            .attr('data-key', ctx.item.Key));
                    }
                });
                columns.push({
                    field: 'TargetText',
                    width: 300,
                    sortable: false,
                    format: function (ctx) {
                        return Q.outerHtml($('<a/>')
                            .addClass('target-text')
                            .text(ctx.value || ''));
                    }
                });
                return columns;
            };
            TranslationGrid.prototype.createToolbarExtensions = function () {
                var _this = this;
                _super.prototype.createToolbarExtensions.call(this);
                var opt = {
                    lookupKey: 'Administration.Language'
                };
                this.sourceLanguage = Serenity.Widget.create({
                    type: Serenity.LookupEditor,
                    element: function (el) {
                        return el.appendTo(_this.toolbar.element).attr('placeholder', '--- ' +
                            Q.text('Db.Administration.Translation.SourceLanguage') + ' ---');
                    },
                    options: opt
                });
                this.sourceLanguage.changeSelect2(function (e) {
                    if (_this.hasChanges) {
                        _this.saveChanges(_this.targetLanguageKey).then(function () { return _this.refresh(); });
                    }
                    else {
                        _this.refresh();
                    }
                });
                this.targetLanguage = Serenity.Widget.create({
                    type: Serenity.LookupEditor,
                    element: function (el) {
                        return el.appendTo(_this.toolbar.element).attr('placeholder', '--- ' +
                            Q.text('Db.Administration.Translation.TargetLanguage') + ' ---');
                    },
                    options: opt
                });
                this.targetLanguage.changeSelect2(function (e) {
                    if (_this.hasChanges) {
                        _this.saveChanges(_this.targetLanguageKey).then(function () { return _this.refresh(); });
                    }
                    else {
                        _this.refresh();
                    }
                });
            };
            TranslationGrid.prototype.saveChanges = function (language) {
                var _this = this;
                var translations = {};
                for (var _i = 0, _a = this.getItems(); _i < _a.length; _i++) {
                    var item = _a[_i];
                    translations[item.Key] = item.CustomText;
                }
                return Promise.resolve(Configuration.TranslationService.Update({
                    TargetLanguageID: language,
                    Translations: translations
                })).then(function () {
                    _this.hasChanges = false;
                    language = Q.trimToNull(language) || 'invariant';
                    Q.notifySuccess('User translations in "' + language +
                        '" language are saved to "user.texts.' +
                        language + '.json" ' + 'file under "~/App_Data/texts/"', '');
                });
            };
            TranslationGrid.prototype.onViewSubmit = function () {
                var request = this.view.params;
                request.SourceLanguageID = this.sourceLanguage.value;
                this.targetLanguageKey = this.targetLanguage.value || '';
                request.TargetLanguageID = this.targetLanguageKey;
                this.hasChanges = false;
                return _super.prototype.onViewSubmit.call(this);
            };
            TranslationGrid.prototype.getButtons = function () {
                var _this = this;
                return [{
                    title: Q.text('Db.Administration.Translation.SaveChangesButton'),
                    onClick: function (e) { return _this.saveChanges(_this.targetLanguageKey).then(function () { return _this.refresh(); }); },
                    cssClass: 'apply-changes-button'
                }];
            };
            TranslationGrid.prototype.createQuickSearchInput = function () {
                var _this = this;
                Serenity.GridUtils.addQuickSearchInputCustom(this.toolbar.element, function (field, searchText) {
                    _this.searchText = searchText;
                    _this.view.setItems(_this.view.getItems(), true);
                });
            };
            TranslationGrid.prototype.onViewFilter = function (item) {
                if (!_super.prototype.onViewFilter.call(this, item)) {
                    return false;
                }
                if (!this.searchText) {
                    return true;
                }
                var sd = Select2.util.stripDiacritics;
                var searching = sd(this.searchText).toLowerCase();
                function match(str) {
                    if (!str)
                        return false;
                    return str.toLowerCase().indexOf(searching) >= 0;
                }
                return Q.isEmptyOrNull(searching) || match(item.Key) || match(item.SourceText) ||
                    match(item.TargetText) || match(item.CustomText);
            };
            TranslationGrid.prototype.usePager = function () {
                return false;
            };
            TranslationGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], TranslationGrid);
            return TranslationGrid;
        }(Serenity.EntityGrid));
        Configuration.TranslationGrid = TranslationGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var SupplierDialog = /** @class */ (function (_super) {
            __extends(SupplierDialog, _super);
            function SupplierDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.SupplierForm(_this.idPrefix);
                return _this;
            }
            SupplierDialog.prototype.getFormKey = function () { return Configuration.SupplierForm.formKey; };
            SupplierDialog.prototype.getIdProperty = function () { return Configuration.SupplierRow.idProperty; };
            SupplierDialog.prototype.getLocalTextPrefix = function () { return Configuration.SupplierRow.localTextPrefix; };
            SupplierDialog.prototype.getNameProperty = function () { return Configuration.SupplierRow.nameProperty; };
            SupplierDialog.prototype.getService = function () { return Configuration.SupplierService.baseUrl; };

            SupplierDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            SupplierDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            SupplierDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };

            //SupplierDialog.prototype.onDialogOpen = function () {
            //    $("input[name='MobileCode'],input[name='PinCode'],input[name='MobileNumber']").keyboard({
            //        layout: 'custom',
            //        customLayout: numricWithoutDecimalKeyboard

            //    })

            //    $("input[name='SupplierName'],input[name='SupplierAddress']").keyboard({
            //        layout: 'custom',
            //        customLayout: alphanumericKeyboard

            //    })

            //}

            SupplierDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], SupplierDialog);
            return SupplierDialog;
        }(Serenity.EntityDialog));
        Configuration.SupplierDialog = SupplierDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var SupplierGrid = /** @class */ (function (_super) {
            __extends(SupplierGrid, _super);
            function SupplierGrid(container) {
                return _super.call(this, container) || this;
            }
            SupplierGrid.prototype.getColumnsKey = function () { return 'Configuration.Supplier'; };
            SupplierGrid.prototype.getDialogType = function () { return Configuration.SupplierDialog; };
            SupplierGrid.prototype.getIdProperty = function () { return Configuration.SupplierRow.idProperty; };
            SupplierGrid.prototype.getLocalTextPrefix = function () { return Configuration.SupplierRow.localTextPrefix; };
            SupplierGrid.prototype.getService = function () { return Configuration.SupplierService.baseUrl; };

            SupplierGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnSupplierImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //style: 'height:29px',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('supplier');

                            },
                        }
                    );
                }
                return buttons;
            };


            SupplierGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], SupplierGrid);
            return SupplierGrid;
        }(Serenity.EntityGrid));
        Configuration.SupplierGrid = SupplierGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var StatusDialog = /** @class */ (function (_super) {
            __extends(StatusDialog, _super);
            function StatusDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.StatusForm(_this.idPrefix);
                return _this;
            }
            StatusDialog.prototype.getFormKey = function () { return Configuration.StatusForm.formKey; };
            StatusDialog.prototype.getIdProperty = function () { return Configuration.StatusRow.idProperty; };
            StatusDialog.prototype.getLocalTextPrefix = function () { return Configuration.StatusRow.localTextPrefix; };
            StatusDialog.prototype.getNameProperty = function () { return Configuration.StatusRow.nameProperty; };
            StatusDialog.prototype.getService = function () { return Configuration.StatusService.baseUrl; };
            StatusDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], StatusDialog);
            return StatusDialog;
        }(Serenity.EntityDialog));
        Configuration.StatusDialog = StatusDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var StatusGrid = /** @class */ (function (_super) {
            __extends(StatusGrid, _super);
            function StatusGrid(container) {
                return _super.call(this, container) || this;
            }
            StatusGrid.prototype.getColumnsKey = function () { return 'Configuration.Status'; };
            StatusGrid.prototype.getDialogType = function () { return Configuration.StatusDialog; };
            StatusGrid.prototype.getIdProperty = function () { return Configuration.StatusRow.idProperty; };
            StatusGrid.prototype.getLocalTextPrefix = function () { return Configuration.StatusRow.localTextPrefix; };
            StatusGrid.prototype.getService = function () { return Configuration.StatusService.baseUrl; };
            StatusGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], StatusGrid);
            return StatusGrid;
        }(Serenity.EntityGrid));
        Configuration.StatusGrid = StatusGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var ShiftDialog = /** @class */ (function (_super) {
            __extends(ShiftDialog, _super);
            function ShiftDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.ShiftForm(_this.idPrefix);
                return _this;
            }
            ShiftDialog.prototype.getFormKey = function () { return Configuration.ShiftForm.formKey; };
            ShiftDialog.prototype.getIdProperty = function () { return Configuration.ShiftRow.idProperty; };
            ShiftDialog.prototype.getLocalTextPrefix = function () { return Configuration.ShiftRow.localTextPrefix; };
            ShiftDialog.prototype.getNameProperty = function () { return Configuration.ShiftRow.nameProperty; };
            ShiftDialog.prototype.getService = function () { return Configuration.ShiftService.baseUrl; };

            ShiftDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };



            ShiftDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            ShiftDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };



            //ShiftDialog.prototype.onDialogOpen = function () {
            //    $("input[name='ShiftName'],input[name='StartTime'],input[name='EndTime']").keyboard({
            //        layout: 'custom',
            //        customLayout: {
            //            'normal': [
            //                '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
            //                '{tab} q w e r t y u i o p [ ] \\',
            //                'a s d f g h j k l ; \' {accept}',
            //                '{shift} z x c v b n m , . / {shift}',
            //                ' {space} {left} {right} {cancel}'
            //            ],
            //            'shift': [
            //                '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
            //                '{tab} Q W E R T Y U I O P { } |',
            //                'A S D F G H J K L : " {accept}',
            //                '{shift} Z X C V B N M < > ? {shift}',
            //                ' {space} {left} {right} {cancel}'
            //            ]
            //        },

            //    })

            //}

            ShiftDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], ShiftDialog);
            return ShiftDialog;
        }(Serenity.EntityDialog));
        Configuration.ShiftDialog = ShiftDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var ShiftGrid = /** @class */ (function (_super) {
            __extends(ShiftGrid, _super);
            function ShiftGrid(container) {
                return _super.call(this, container) || this;
            }
            ShiftGrid.prototype.getColumnsKey = function () { return 'Configuration.Shift'; };
            ShiftGrid.prototype.getDialogType = function () { return Configuration.ShiftDialog; };
            ShiftGrid.prototype.getIdProperty = function () { return Configuration.ShiftRow.idProperty; };
            ShiftGrid.prototype.getLocalTextPrefix = function () { return Configuration.ShiftRow.localTextPrefix; };
            ShiftGrid.prototype.getService = function () { return Configuration.ShiftService.baseUrl; };
            ShiftGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnShiftImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            // cssClass: 'stampe',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('shift');
                            }
                        });

                }
                return buttons;
            };
            ShiftGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ShiftGrid);
            return ShiftGrid;
        }(Serenity.EntityGrid));
        Configuration.ShiftGrid = ShiftGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueRoleAccessDialog = /** @class */ (function (_super) {
            __extends(PickListValueRoleAccessDialog, _super);
            function PickListValueRoleAccessDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.PickListValueRoleAccessForm(_this.idPrefix);
                return _this;
            }
            PickListValueRoleAccessDialog.prototype.getFormKey = function () { return Configuration.PickListValueRoleAccessForm.formKey; };
            PickListValueRoleAccessDialog.prototype.getIdProperty = function () { return Configuration.PickListValueRoleAccessRow.idProperty; };
            PickListValueRoleAccessDialog.prototype.getLocalTextPrefix = function () { return Configuration.PickListValueRoleAccessRow.localTextPrefix; };
            PickListValueRoleAccessDialog.prototype.getService = function () { return Configuration.PickListValueRoleAccessService.baseUrl; };
            PickListValueRoleAccessDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], PickListValueRoleAccessDialog);
            return PickListValueRoleAccessDialog;
        }(Serenity.EntityDialog));
        Configuration.PickListValueRoleAccessDialog = PickListValueRoleAccessDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueRoleAccessGrid = /** @class */ (function (_super) {
            __extends(PickListValueRoleAccessGrid, _super);
            function PickListValueRoleAccessGrid(container) {
                return _super.call(this, container) || this;
            }
            PickListValueRoleAccessGrid.prototype.getColumnsKey = function () { return 'Configuration.PickListValueRoleAccess'; };
            PickListValueRoleAccessGrid.prototype.getDialogType = function () { return Configuration.PickListValueRoleAccessDialog; };
            PickListValueRoleAccessGrid.prototype.getIdProperty = function () { return Configuration.PickListValueRoleAccessRow.idProperty; };
            PickListValueRoleAccessGrid.prototype.getLocalTextPrefix = function () { return Configuration.PickListValueRoleAccessRow.localTextPrefix; };
            PickListValueRoleAccessGrid.prototype.getService = function () { return Configuration.PickListValueRoleAccessService.baseUrl; };
            PickListValueRoleAccessGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], PickListValueRoleAccessGrid);
            return PickListValueRoleAccessGrid;
        }(Serenity.EntityGrid));
        Configuration.PickListValueRoleAccessGrid = PickListValueRoleAccessGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueDialog = /** @class */ (function (_super) {
            __extends(PickListValueDialog, _super);
            function PickListValueDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.PickListValueForm(_this.idPrefix);
                return _this;
            }
            PickListValueDialog.prototype.getFormKey = function () { return Configuration.PickListValueForm.formKey; };
            PickListValueDialog.prototype.getIdProperty = function () { return Configuration.PickListValueRow.idProperty; };
            PickListValueDialog.prototype.getLocalTextPrefix = function () { return Configuration.PickListValueRow.localTextPrefix; };
            PickListValueDialog.prototype.getNameProperty = function () { return Configuration.PickListValueRow.nameProperty; };
            PickListValueDialog.prototype.getService = function () { return Configuration.PickListValueService.baseUrl; };
            PickListValueDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            PickListValueDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };

            //PickListValueDialog.prototype.onDialogOpen = function () {
            //    $("input[name='PickListValueName']").keyboard({
            //        layout: 'custom',
            //        customLayout: alphanumericKeyboard

            //    })

            //}

            PickListValueDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], PickListValueDialog);
            return PickListValueDialog;
        }(Serenity.EntityDialog));
        Configuration.PickListValueDialog = PickListValueDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueGrid = /** @class */ (function (_super) {
            __extends(PickListValueGrid, _super);
            function PickListValueGrid(container) {
                return _super.call(this, container) || this;
            }
            PickListValueGrid.prototype.getColumnsKey = function () { return 'Configuration.PickListValue'; };
            PickListValueGrid.prototype.getDialogType = function () { return Configuration.PickListValueDialog; };
            PickListValueGrid.prototype.getIdProperty = function () { return Configuration.PickListValueRow.idProperty; };
            PickListValueGrid.prototype.getLocalTextPrefix = function () { return Configuration.PickListValueRow.localTextPrefix; };
            PickListValueGrid.prototype.getService = function () { return Configuration.PickListValueService.baseUrl; };
            PickListValueGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnPickListValueImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            cssClass: 'export-xlsx-button',
                            // icon: 'fa-file-excel-o',
                            onClick: () => {

                                importFile('pickListValue');
                            }
                        });
                }
                return buttons;
            };


            PickListValueGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], PickListValueGrid);
            return PickListValueGrid;
        }(Serenity.EntityGrid));
        Configuration.PickListValueGrid = PickListValueGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListDialog = /** @class */ (function (_super) {
            __extends(PickListDialog, _super);
            function PickListDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.PickListForm(_this.idPrefix);
                return _this;
            }
            PickListDialog.prototype.getFormKey = function () { return Configuration.PickListForm.formKey; };
            PickListDialog.prototype.getIdProperty = function () { return Configuration.PickListRow.idProperty; };
            PickListDialog.prototype.getLocalTextPrefix = function () { return Configuration.PickListRow.localTextPrefix; };
            PickListDialog.prototype.getNameProperty = function () { return Configuration.PickListRow.nameProperty; };
            PickListDialog.prototype.getService = function () { return Configuration.PickListService.baseUrl; };

            PickListDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            PickListDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], PickListDialog);
            return PickListDialog;
        }(Serenity.EntityDialog));
        Configuration.PickListDialog = PickListDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListGrid = /** @class */ (function (_super) {
            __extends(PickListGrid, _super);
            function PickListGrid(container) {
                return _super.call(this, container) || this;
            }
            PickListGrid.prototype.getColumnsKey = function () { return 'Configuration.PickList'; };
            PickListGrid.prototype.getDialogType = function () { return Configuration.PickListDialog; };
            PickListGrid.prototype.getIdProperty = function () { return Configuration.PickListRow.idProperty; };
            PickListGrid.prototype.getLocalTextPrefix = function () { return Configuration.PickListRow.localTextPrefix; };
            PickListGrid.prototype.getService = function () { return Configuration.PickListService.baseUrl; };
            PickListGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], PickListGrid);
            return PickListGrid;
        }(Serenity.EntityGrid));
        Configuration.PickListGrid = PickListGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var LanguageDialog = /** @class */ (function (_super) {
            __extends(LanguageDialog, _super);
            function LanguageDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.LanguageForm(_this.idPrefix);
                return _this;
            }
            LanguageDialog.prototype.getFormKey = function () { return Configuration.LanguageForm.formKey; };
            LanguageDialog.prototype.getIdProperty = function () { return Configuration.LanguageRow.idProperty; };
            LanguageDialog.prototype.getLocalTextPrefix = function () { return Configuration.LanguageRow.localTextPrefix; };
            LanguageDialog.prototype.getNameProperty = function () { return Configuration.LanguageRow.nameProperty; };
            LanguageDialog.prototype.getService = function () { return Configuration.LanguageService.baseUrl; };

            LanguageDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            LanguageDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], LanguageDialog);
            return LanguageDialog;
        }(Serenity.EntityDialog));
        Configuration.LanguageDialog = LanguageDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var LanguageGrid = /** @class */ (function (_super) {
            __extends(LanguageGrid, _super);
            function LanguageGrid(container) {
                return _super.call(this, container) || this;
            }
            LanguageGrid.prototype.getColumnsKey = function () { return "Configuration.Language"; };
            LanguageGrid.prototype.getDialogType = function () { return Configuration.LanguageDialog; };
            LanguageGrid.prototype.getIdProperty = function () { return Configuration.LanguageRow.idProperty; };
            LanguageGrid.prototype.getLocalTextPrefix = function () { return Configuration.LanguageRow.localTextPrefix; };
            LanguageGrid.prototype.getService = function () { return Configuration.LanguageService.baseUrl; };
            LanguageGrid.prototype.getDefaultSortBy = function () {
                return [Configuration.LanguageRow.Fields.LanguageName];
            };
            LanguageGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            LanguageGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], LanguageGrid);
            return LanguageGrid;
        }(Serenity.EntityGrid));
        Configuration.LanguageGrid = LanguageGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var EnvironmentVariablesDialog = /** @class */ (function (_super) {
            __extends(EnvironmentVariablesDialog, _super);
            function EnvironmentVariablesDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.EnvironmentVariablesForm(_this.idPrefix);
                return _this;
            }
            EnvironmentVariablesDialog.prototype.getFormKey = function () { return Configuration.EnvironmentVariablesForm.formKey; };
            EnvironmentVariablesDialog.prototype.getIdProperty = function () { return Configuration.EnvironmentVariablesRow.idProperty; };
            EnvironmentVariablesDialog.prototype.getLocalTextPrefix = function () { return Configuration.EnvironmentVariablesRow.localTextPrefix; };
            EnvironmentVariablesDialog.prototype.getNameProperty = function () { return Configuration.EnvironmentVariablesRow.nameProperty; };
            EnvironmentVariablesDialog.prototype.getService = function () { return Configuration.EnvironmentVariablesService.baseUrl; };

            EnvironmentVariablesDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            EnvironmentVariablesDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            EnvironmentVariablesDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                //this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };

            EnvironmentVariablesDialog.prototype.afterLoadEntity = function () {

              
                _super.prototype.afterLoadEntity.call(this);
             
                var localfrm = this.form;
         
                if (this.form.IsUnLockAfterTime.value == true) {
                    $('.UnLockTime').show();
                    this.form.UnLockTime.element.toggleClass('required', true);
                }
                else { 
                    $('.UnLockTime').hide();
                    this.form.UnLockTime.element.toggleClass('required', false);
                }

                this.form.IsUnLockAfterTime.change(function (e) {
                    if (localfrm.IsUnLockAfterTime.value == true) {
                        $('.UnLockTime').show();
                        localfrm.UnLockTime.element.toggleClass('required', true);
                    }
                    else {
                        $('.UnLockTime').hide();
                        localfrm.UnLockTime.element.toggleClass('required', false);
                    }
                });
               
             //  .attr('data-toggle', "tooltip").attr('title', "Min: 0  Max: 23");

                $("input[name='BackupFrequencyNoOfDaya']").attr('min', 1).attr('max', 7).attr('data-toggle', "tooltip").attr('title', "Min: 1  Max: 7");
                $("input[name='BackupTime']").attr('min', 0).attr('max', 23).attr('data-toggle', "tooltip").attr('title', "Min: 0  Max: 23");
                $("input[name='SessionTimeOut']").attr('min', 1).attr('max', 60).attr('data-toggle', "tooltip").attr('title', "Min: 1  Max: 60");
                $("input[name='LastPeriodRetained']").attr('min', 1).attr('max', 365).attr('data-toggle', "tooltip").attr('title', "Min: 1  Max: 365");
                $("input[name='PasswordExpiryInDays']").attr('min', 15).attr('max', 120).attr('data-toggle', "tooltip").attr('title', "Min: 15  Max: 120");
                $("input[name='PasswordExpiryNotification']").attr('min', 0).attr('max', 15).attr('data-toggle', "tooltip").attr('title', "Min: 0  Max: 15");
                $("input[name='PasswordMinLength'],input[name='PasswordMaxLength']").attr('min', 4).attr('max', 16).attr('data-toggle', "tooltip").attr('title', "Min: 4  Max: 16");
                $("input[name='MinAlphaChars'],input[name='MinNumericChars'],input[name='MinSpecialChars'],input[name='MinCapitalLetter']").attr('min', 1).attr('data-toggle', "tooltip").attr('title', "Min: 1");

                
                $('[data-toggle="tooltip"]').tooltip();   
                $("input[name='BackupFolder'],input[name='ArchivalPath']").keyboard({
                    usePreview: false,
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })

                $("input[name='BackupFrequencyNoOfDaya'],input[name='BackupTime'],input[name='SessionTimeOut'],input[name='DatabaseLimit'],input[name='PasswordMaxLength'],input[name='PasswordMinLength'],input[name='MinNumericChars'],input[name='PasswordMinLength'],input[name='MinSpecialChars'],input[name='MinCapitalLetter'],input[name='PasswordExpiryInDays'],input[name='LockInAttempt'],input[name='UnLockTime'],input[name='MinAlphaChars'],input[name='LastPeriodRetained'],input[name='PasswordExpiryNotification'],input[name='PreviousPasswordLimit']")
                    .keyboard({
                    layout: 'custom',
                        customLayout: {
                          
                        'normal': [
                            
                            '7 8 9',
                            '4 5 6',
                            '1 2 3',
                            '{bksp} 0',
                            '{a} {c}'
                            ],
                           

                    },                   
                acceptValid: true,
                    validate: function (keyboard, value, isClosing) {
                        // console.log($(keyboard)[0].el.min);

                        var min = $(keyboard)[0].el.min;
                        var max = $(keyboard)[0].el.max;
                        if (parseFloat(value) > parseFloat(max)) {
                            //Q.alert("Value Cannot be greater than " + max);
                            return false;
                        }
                        if (parseFloat(value) < parseFloat(min)) {
                            //Q.alert("Value Cannot be less than " + min);
                            return false;
                        }

                        return true;
                    }
                    })
               
             
            };

            EnvironmentVariablesDialog.prototype.onDialogOpen = function () {
               
            }

            EnvironmentVariablesDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], EnvironmentVariablesDialog);
            return EnvironmentVariablesDialog;
        }(Serenity.EntityDialog));
        Configuration.EnvironmentVariablesDialog = EnvironmentVariablesDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var EnvironmentVariablesGrid = /** @class */ (function (_super) {
            __extends(EnvironmentVariablesGrid, _super);
            function EnvironmentVariablesGrid(container) {
                return _super.call(this, container) || this;
            }
            EnvironmentVariablesGrid.prototype.getColumnsKey = function () { return 'Configuration.EnvironmentVariables'; };
            EnvironmentVariablesGrid.prototype.getDialogType = function () { return Configuration.EnvironmentVariablesDialog; };
            EnvironmentVariablesGrid.prototype.getIdProperty = function () { return Configuration.EnvironmentVariablesRow.idProperty; };
            EnvironmentVariablesGrid.prototype.getLocalTextPrefix = function () { return Configuration.EnvironmentVariablesRow.localTextPrefix; };
            EnvironmentVariablesGrid.prototype.getService = function () { return Configuration.EnvironmentVariablesService.baseUrl; };
            EnvironmentVariablesGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], EnvironmentVariablesGrid);
            return EnvironmentVariablesGrid;
        }(Serenity.EntityGrid));
        Configuration.EnvironmentVariablesGrid = EnvironmentVariablesGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DepartmentDialog = /** @class */ (function (_super) {
            __extends(DepartmentDialog, _super);
            function DepartmentDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.DepartmentForm(_this.idPrefix);
                return _this;
            }
            DepartmentDialog.prototype.getFormKey = function () { return Configuration.DepartmentForm.formKey; };
            DepartmentDialog.prototype.getIdProperty = function () { return Configuration.DepartmentRow.idProperty; };
            DepartmentDialog.prototype.getLocalTextPrefix = function () { return Configuration.DepartmentRow.localTextPrefix; };
            DepartmentDialog.prototype.getNameProperty = function () { return Configuration.DepartmentRow.nameProperty; };
            DepartmentDialog.prototype.getService = function () { return Configuration.DepartmentService.baseUrl; };

            DepartmentDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            DepartmentDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            DepartmentDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };


            //DepartmentDialog.prototype.onDialogOpen = function () {
            //    $("input[name='DepartmentCode'],input[name='DepartmentName']").keyboard({
            //        layout: 'custom',
            //        customLayout: alphanumericKeyboard

            //    })

            //}

            DepartmentDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], DepartmentDialog);
            return DepartmentDialog;
        }(Serenity.EntityDialog));
        Configuration.DepartmentDialog = DepartmentDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DepartmentGrid = /** @class */ (function (_super) {
            __extends(DepartmentGrid, _super);
            function DepartmentGrid(container) {
                return _super.call(this, container) || this;
            }
            DepartmentGrid.prototype.getColumnsKey = function () { return 'Configuration.Department'; };
            DepartmentGrid.prototype.getDialogType = function () { return Configuration.DepartmentDialog; };
            DepartmentGrid.prototype.getIdProperty = function () { return Configuration.DepartmentRow.idProperty; };
            DepartmentGrid.prototype.getLocalTextPrefix = function () { return Configuration.DepartmentRow.localTextPrefix; };
            DepartmentGrid.prototype.getService = function () { return Configuration.DepartmentService.baseUrl; };
            DepartmentGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnDepartmentImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //cssClass: 'stampe',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('department');
                            }
                        });
                }

                return buttons;
            };
            DepartmentGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], DepartmentGrid);
            return DepartmentGrid;
        }(Serenity.EntityGrid));
        Configuration.DepartmentGrid = DepartmentGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DataTypeDialog = /** @class */ (function (_super) {
            __extends(DataTypeDialog, _super);
            function DataTypeDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.DataTypeForm(_this.idPrefix);
                return _this;
            }
            DataTypeDialog.prototype.getFormKey = function () { return Configuration.DataTypeForm.formKey; };
            DataTypeDialog.prototype.getIdProperty = function () { return Configuration.DataTypeRow.idProperty; };
            DataTypeDialog.prototype.getLocalTextPrefix = function () { return Configuration.DataTypeRow.localTextPrefix; };
            DataTypeDialog.prototype.getNameProperty = function () { return Configuration.DataTypeRow.nameProperty; };
            DataTypeDialog.prototype.getService = function () { return Configuration.DataTypeService.baseUrl; };
            DataTypeDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            DataTypeDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            DataTypeDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], DataTypeDialog);
            return DataTypeDialog;
        }(Serenity.EntityDialog));
        Configuration.DataTypeDialog = DataTypeDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DataTypeGrid = /** @class */ (function (_super) {
            __extends(DataTypeGrid, _super);
            function DataTypeGrid(container) {
                return _super.call(this, container) || this;
            }
            DataTypeGrid.prototype.getColumnsKey = function () { return 'Configuration.DataType'; };
            DataTypeGrid.prototype.getDialogType = function () { return Configuration.DataTypeDialog; };
            DataTypeGrid.prototype.getIdProperty = function () { return Configuration.DataTypeRow.idProperty; };
            DataTypeGrid.prototype.getLocalTextPrefix = function () { return Configuration.DataTypeRow.localTextPrefix; };
            DataTypeGrid.prototype.getService = function () { return Configuration.DataTypeService.baseUrl; };
            DataTypeGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            DataTypeGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], DataTypeGrid);
            return DataTypeGrid;
        }(Serenity.EntityGrid));
        Configuration.DataTypeGrid = DataTypeGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CurrencyDialog = /** @class */ (function (_super) {
            __extends(CurrencyDialog, _super);
            function CurrencyDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.CurrencyForm(_this.idPrefix);
                return _this;
            }
            CurrencyDialog.prototype.getFormKey = function () { return Configuration.CurrencyForm.formKey; };
            CurrencyDialog.prototype.getIdProperty = function () { return Configuration.CurrencyRow.idProperty; };
            CurrencyDialog.prototype.getLocalTextPrefix = function () { return Configuration.CurrencyRow.localTextPrefix; };
            CurrencyDialog.prototype.getNameProperty = function () { return Configuration.CurrencyRow.nameProperty; };
            CurrencyDialog.prototype.getService = function () { return Configuration.CurrencyService.baseUrl; };
            CurrencyDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            CurrencyDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            CurrencyDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], CurrencyDialog);
            return CurrencyDialog;
        }(Serenity.EntityDialog));
        Configuration.CurrencyDialog = CurrencyDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CurrencyGrid = /** @class */ (function (_super) {
            __extends(CurrencyGrid, _super);
            function CurrencyGrid(container) {
                return _super.call(this, container) || this;
            }
            CurrencyGrid.prototype.getColumnsKey = function () { return 'Configuration.Currency'; };
            CurrencyGrid.prototype.getDialogType = function () { return Configuration.CurrencyDialog; };
            CurrencyGrid.prototype.getIdProperty = function () { return Configuration.CurrencyRow.idProperty; };
            CurrencyGrid.prototype.getLocalTextPrefix = function () { return Configuration.CurrencyRow.localTextPrefix; };
            CurrencyGrid.prototype.getService = function () { return Configuration.CurrencyService.baseUrl; };
            CurrencyGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            CurrencyGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], CurrencyGrid);
            return CurrencyGrid;
        }(Serenity.EntityGrid));
        Configuration.CurrencyGrid = CurrencyGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CompanyDialog = /** @class */ (function (_super) {
            __extends(CompanyDialog, _super);
            function CompanyDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.CompanyForm(_this.idPrefix);
                return _this;
            }
            CompanyDialog.prototype.getFormKey = function () { return Configuration.CompanyForm.formKey; };
            CompanyDialog.prototype.getIdProperty = function () { return Configuration.CompanyRow.idProperty; };
            CompanyDialog.prototype.getLocalTextPrefix = function () { return Configuration.CompanyRow.localTextPrefix; };
            CompanyDialog.prototype.getNameProperty = function () { return Configuration.CompanyRow.nameProperty; };
            CompanyDialog.prototype.getService = function () { return Configuration.CompanyService.baseUrl; };

            CompanyDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };

            CompanyDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            CompanyDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
               this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };
            CompanyDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                $("input[name='CompanyName'],input[name='Address'],input[name='Website']").keyboard({
                    usePreview: false,
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })

                var cus = {
                    'normal': [
                        '7 8 9',
                        '4 5 6',
                        '1 2 3',
                        '{bksp} 0',
                        '{a} {c}'
                    ]

                };
                $("input[name='PinCode']").keyboard({
                    layout: 'custom',
                    customLayout: cus
                    //customLayout: {
                    //    'normal': [
                    //        '7 8 9',
                    //        '4 5 6',
                    //        '1 2 3',
                    //        '{bksp} 0',
                    //        '{a} {c}'
                    //    ]

                    //}
                })

            }

            CompanyDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive(),
                Serenity.Decorators.panel()
            ], CompanyDialog);
            return CompanyDialog;
        }(Serenity.EntityDialog));
        Configuration.CompanyDialog = CompanyDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CompanyGrid = /** @class */ (function (_super) {
            __extends(CompanyGrid, _super);
            function CompanyGrid(container) {
                return _super.call(this, container) || this;
            }
            CompanyGrid.prototype.getColumnsKey = function () { return 'Configuration.Company'; };
            CompanyGrid.prototype.getDialogType = function () { return Configuration.CompanyDialog; };
            CompanyGrid.prototype.getIdProperty = function () { return Configuration.CompanyRow.idProperty; };
            CompanyGrid.prototype.getLocalTextPrefix = function () { return Configuration.CompanyRow.localTextPrefix; };
            CompanyGrid.prototype.getService = function () { return Configuration.CompanyService.baseUrl; };
            CompanyGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], CompanyGrid);
            return CompanyGrid;
        }(Serenity.EntityGrid));
        Configuration.CompanyGrid = CompanyGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CityDetailsDialog = /** @class */ (function (_super) {
            __extends(CityDetailsDialog, _super);
            function CityDetailsDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.CityDetailsForm(_this.idPrefix);
                return _this;
            }
            CityDetailsDialog.prototype.getFormKey = function () { return Configuration.CityDetailsForm.formKey; };
            CityDetailsDialog.prototype.getIdProperty = function () { return Configuration.CityDetailsRow.idProperty; };
            CityDetailsDialog.prototype.getLocalTextPrefix = function () { return Configuration.CityDetailsRow.localTextPrefix; };
            CityDetailsDialog.prototype.getNameProperty = function () { return Configuration.CityDetailsRow.nameProperty; };
            CityDetailsDialog.prototype.getService = function () { return Configuration.CityDetailsService.baseUrl; };

            CityDetailsDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data);
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            CityDetailsDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            CityDetailsDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };




            //CityDetailsDialog.prototype.onDialogOpen = function () {
            //    $("input[name='City']").keyboard({
            //        layout: 'custom',
            //        customLayout: alphanumericKeyboard

            //    })

            //}


            CityDetailsDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], CityDetailsDialog);
            return CityDetailsDialog;
        }(Serenity.EntityDialog));
        Configuration.CityDetailsDialog = CityDetailsDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CityDetailsGrid = /** @class */ (function (_super) {
            __extends(CityDetailsGrid, _super);
            function CityDetailsGrid(container) {
                return _super.call(this, container) || this;
            }
            CityDetailsGrid.prototype.getColumnsKey = function () { return 'Configuration.CityDetails'; };
            CityDetailsGrid.prototype.getDialogType = function () { return Configuration.CityDetailsDialog; };
            CityDetailsGrid.prototype.getIdProperty = function () { return Configuration.CityDetailsRow.idProperty; };
            CityDetailsGrid.prototype.getLocalTextPrefix = function () { return Configuration.CityDetailsRow.localTextPrefix; };
            CityDetailsGrid.prototype.getService = function () { return Configuration.CityDetailsService.baseUrl; };
            CityDetailsGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnCityImportAccess").val() =='True') {
                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            cssClass: 'export-xlsx-button',
                            // icon: 'fa-file-excel-o',
                            onClick: () => {

                                importFile('cityDetails');
                            }
                        });
                }

                return buttons;
            };
            CityDetailsGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], CityDetailsGrid);
            return CityDetailsGrid;
        }(Serenity.EntityGrid));
        Configuration.CityDetailsGrid = CityDetailsGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var LanguageList;
    (function (LanguageList) {
        function getValue() {
            var result = [];
            for (var _i = 0, _a = CVC.Configuration.LanguageRow.getLookup().items; _i < _a.length; _i++) {
                var k = _a[_i];
                if (k.LanguageId !== 'en') {
                    result.push([k.Id.toString(), k.LanguageName]);
                }
            }
            return result;
        }
        LanguageList.getValue = getValue;
    })(LanguageList = CVC.LanguageList || (CVC.LanguageList = {}));
})(CVC || (CVC = {}));
/// <reference path="../Common/Helpers/LanguageList.ts" />
var CVC;
(function (CVC) {
    var ScriptInitialization;
    (function (ScriptInitialization) {
        Q.Config.responsiveDialogs = true;
        Q.Config.rootNamespaces.push('CVC');
        Serenity.EntityDialog.defaultLanguageList = CVC.LanguageList.getValue;
    })(ScriptInitialization = CVC.ScriptInitialization || (CVC.ScriptInitialization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var UserPreferenceStorage = /** @class */ (function () {
            function UserPreferenceStorage() {
            }
            UserPreferenceStorage.prototype.getItem = function (key) {
                var value;
                Common.UserPreferenceService.Retrieve({
                    PreferenceType: "UserPreferenceStorage",
                    Name: key
                }, function (response) { return value = response.Value; }, {
                        async: false
                    });
                return value;
            };
            UserPreferenceStorage.prototype.setItem = function (key, data) {
                Common.UserPreferenceService.Update({
                    PreferenceType: "UserPreferenceStorage",
                    Name: key,
                    Value: data
                });
            };
            return UserPreferenceStorage;
        }());
        Common.UserPreferenceStorage = UserPreferenceStorage;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var PdfExportHelper;
        (function (PdfExportHelper) {
            function toAutoTableColumns(srcColumns, columnStyles, columnTitles) {
                return srcColumns.map(function (src) {
                    var col = {
                        dataKey: src.id || src.field,
                        title: src.name || ''
                    };
                    if (columnTitles && columnTitles[col.dataKey] != null)
                        col.title = columnTitles[col.dataKey];
                    var style = {};
                    if ((src.cssClass || '').indexOf("align-right") >= 0)
                        style.halign = 'right';
                    else if ((src.cssClass || '').indexOf("align-center") >= 0)
                        style.halign = 'center';
                    columnStyles[col.dataKey] = style;
                    return col;
                });
            }
            function toAutoTableData(entities, keys, srcColumns) {
                var el = document.createElement('span');
                var row = 0;
                return entities.map(function (item) {
                    var dst = {};
                    for (var cell = 0; cell < srcColumns.length; cell++) {
                        var src = srcColumns[cell];
                        var fld = src.field || '';
                        var key = keys[cell];
                        var txt = void 0;
                        var html = void 0;
                        if (src.formatter) {
                            html = src.formatter(row, cell, item[fld], src, item);
                        }
                        else if (src.format) {
                            html = src.format({ row: row, cell: cell, item: item, value: item[fld] });
                        }
                        else {
                            dst[key] = item[fld];
                            continue;
                        }
                        if (!html || (html.indexOf('<') < 0 && html.indexOf('&') < 0))
                            dst[key] = html;
                        else {
                            el.innerHTML = html;
                            if (el.children.length == 1 &&
                                $(el.children[0]).is(":input")) {
                                dst[key] = $(el.children[0]).val();
                            }
                            else if (el.children.length == 1 &&
                                $(el.children).is('.check-box')) {
                                dst[key] = $(el.children).hasClass("checked") ? "X" : "";
                            }
                            else
                                dst[key] = el.textContent || '';
                        }
                    }
                    row++;
                    return dst;
                });
            }
            function exportToPdf(options) {
                myoptions = options;
                var reportName = (options.grid.$displayName);
                debugger
                var dateEmpty = false;
                var i = 0;
                var fromDate = "";
                var toDate = "";

                if (reportName == "Audit Log" || reportName == "Audit Log Archive")
                {
                    var batchId = $("#CVC_Report_AuditLogGrid0_QuickFilter_BatchId").val();

                    $(".hasDatepicker").each(function () {

                        if ($(this).val() == "") {
                            dateEmpty = true;
                        }
                        if (i == 0) {
                            fromDate = ($(this).val());
                        }
                        else {
                            toDate = ($(this).val());
                        }
                        i++;

                    });


                    if (batchId=="" && fromDate == "" && toDate == "") {
                         Q.alert("Please select either Batch Number or From Date and To Date");
                            return false;                        
                    }
                    else {

                        if (batchId == "") {
                            if (dateEmpty) {
                                Q.alert("Please select appropriate date range for print");
                                return false;
                            }
                            else {

                                if ($.datepicker.parseDate('mm/dd/yy', fromDate) <= $.datepicker.parseDate('mm/dd/yy', toDate)) {
                                    //  alert("oak");
                                }
                                else {

                                    Q.alert("From Date should be less than or equal to To Date");
                                    return false;

                                }
                            }

                        }
                        else {
                            if (fromDate != "" || toDate!="") {

                                if (dateEmpty) {
                                    Q.alert("Please select appropriate date range for print");
                                    return false;
                                }

                                if ($.datepicker.parseDate('mm/dd/yy', fromDate) <= $.datepicker.parseDate('mm/dd/yy', toDate)) {
                                     // alert("oak");
                                }
                                else {

                                    Q.alert("From Date should be less than or equal to To Date");
                                    return false;

                                }
                            }


                        }
                       
                    }

                }
                else {
                    $(".hasDatepicker").each(function () {

                        if ($(this).val() == "") {
                            dateEmpty = true;
                        }
                        if (i == 0) {
                            fromDate = ($(this).val());
                        }
                        else {
                            toDate = ($(this).val());
                        }
                        i++;

                    });
                    if (dateEmpty) {
                        Q.alert("Please select appropriate date range for print");
                        return false;
                    }
                    else {

                        if ($.datepicker.parseDate('mm/dd/yy', fromDate) <= $.datepicker.parseDate('mm/dd/yy', toDate)) {
                            //  alert("oak");
                        }
                        else {

                            Q.alert("From Date should be less than or equal to To Date");
                            return false;

                        }
                    }

                }

               $("#AuthenticationtModal").modal('show');
              
               return false;
                showLoader();
                var reportDetails;

                var machine = {};
                $.ajax({
                    async: false,
                    type: "POST",
                    url: Q.resolveUrl('~/api/Batch/GetReportDetails'),
                    data: JSON.stringify(machine),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        reportDetails = response;
                       // alert("response");
                      
                    },
                    failure: function (response) {
                        alert(response.responseText);
                      
                    },
                    error: function (response) {
                        alert(response.responseText);
                       
                    },
                    complete: function (response) {
                      //  alert("complete");
                    }
                });

                if (reportDetails.Serial == null) {
                    reportDetails.Serial = ""
                }

                if (reportDetails.Model == null) {
                    reportDetails.Model = ""
                }
                var g = options.grid;
                if (!options.onViewSubmit())
                    return;
                includeAutoTable();
                var request = Q.deepClone(g.view.params);
                request.Take = 0;
                request.Skip = 0;
                var sortBy = g.view.sortBy;
                if (sortBy != null)
                    request.Sort = sortBy;
                var gridColumns = g.slickGrid.getColumns();
                gridColumns = gridColumns.filter(function (x) { return x.id !== "__select__"; });
                request.IncludeColumns = [];
                for (var _i = 0, gridColumns_1 = gridColumns; _i < gridColumns_1.length; _i++) {
                    var column = gridColumns_1[_i];
                    request.IncludeColumns.push(column.id || column.field);
                }
                Q.serviceCall({
                    url: g.view.url,
                    request: request,
                    onSuccess: function (response) {
                        hideLoader();
                        var doc = new jsPDF('l', 'pt');
                        var srcColumns = gridColumns;
                        var columnStyles = {};
                        var columns = toAutoTableColumns(srcColumns, columnStyles, options.columnTitles);
                        var keys = columns.map(function (x) { return x.dataKey; });
                        var entities = response.Entities || [];
                        var data = toAutoTableData(entities, keys, srcColumns);
                        doc.setFontSize(options.titleFontSize || 10);
                        doc.setFontStyle('bold');
                        var reportTitle = options.reportTitle || g.getTitle() || "Report";
                        doc.autoTableText(reportTitle, doc.internal.pageSize.width / 2, options.titleTop || 25, { halign: 'center' });
                        var totalPagesExp = "{{T}}";
                        var pageNumbers = options.pageNumbers == null || options.pageNumbers;
                        var autoOptions = $.extend({
                            margin: { top: 60, left: 25, right: 25, bottom: pageNumbers ? 25 : 30 },
                            startY: 60,
                            styles: {
                                fontSize: 8,
                                overflow: 'linebreak',
                                cellPadding: 2,
                                valign: 'middle'
                            },
                            columnStyles: columnStyles
                        }, options.tableOptions);
                        if (pageNumbers) {
                            var footer = function (data) {
                                var str = data.pageCount;
                                // Total page number plugin only available in jspdf v1.0+
                                if (typeof doc.putTotalPages === 'function') {
                                    str = str + " / " + totalPagesExp;
                                }
                                doc.autoTableText(str, doc.internal.pageSize.width / 2, doc.internal.pageSize.height - autoOptions.margin.bottom, {
                                    halign: 'center'
                                });
                            };
                            autoOptions.afterPageContent = footer;
                        }
                        // Print header of page
                        if (options.printDateTimeHeader == null || options.printDateTimeHeader) {


                            var beforePage = function (data) {
                                doc.setFontSize(options.titleFontSize || 10);
                                doc.setFontStyle('bold');
                                doc.autoTableText(reportTitle, doc.internal.pageSize.width / 2, options.titleTop || 25, { halign: 'center' });

                                doc.setFontStyle('normal');
                                doc.setFontSize(8);
                                // Date and time of the report
                                doc.autoTableText("Equipment Name: " + reportDetails.MachineName, doc.internal.pageSize.width - autoOptions.margin.right, 10, {
                                    halign: 'right'
                                });

                                //doc.autoTableText("Serial Number: " + reportDetails.Serial, doc.internal.pageSize.width - autoOptions.margin.right, 20, {
                                //    halign: 'right'
                                //});

                                //doc.autoTableText("Model Number: " + reportDetails.Model, doc.internal.pageSize.width - autoOptions.margin.right, 30, {
                                //    halign: 'right'
                                //});
                                //EquipmentId
                                doc.autoTableText("Equipment ID: " + reportDetails.Serial, doc.internal.pageSize.width - autoOptions.margin.right, 20, {
                                    halign: 'right'
                                });


                                //changes added By Vinayak On 31.07.2018

                                doc.autoTableText("Page Number: " + doc.internal.getNumberOfPages() + " of " + totalPagesExp, doc.internal.pageSize.width - autoOptions.margin.right, 30, {
                                    halign: 'right'
                                });

                               //changes ended By Vinayak On 31.07.2018



                                doc.autoTableText(reportDetails.comname, autoOptions.margin.left + 45, 10, {
                                    halign: 'left'
                                });
                               
                                //doc.autoTableText(reportDetails.address, autoOptions.margin.left + 45, 20, {
                                //    halign: 'left'
                                //});

                                //doc.addImage('data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3NTc3Nzc3NjU3Ny01Nzc3NzUuNzUrLTc4LS01LzU1ODAvNzY3NS03KzU1KzU3LS0tN//AABEIACgAKAMBEQACEQEDEQH/xAAaAAEBAQADAQAAAAAAAAAAAAAGBQQCAwcB/8QAMxAAAQMCAgcFBwUAAAAAAAAAAQIDBAURABIGBxMhMVGRIkFhcaEUFSMyQmKBFiSxwdH/xAAbAQADAQEAAwAAAAAAAAAAAAAEBQYDAgABB//EAC0RAAEDAgQEBAcBAAAAAAAAAAEAAgMEEQUSITEGEyJRMnGRoRUjM0FhwfAU/9oADAMBAAIRAxEAPwAvpdHdn6XswkO3U7smmwTuQVG393xpiUvLJd9ghKJvywl8fVJBER1EyqSFSiew4ygJSgeKTe/UYh5eJnZ+lmiaCmFrqVI1R1BLlo9WhuI5uNrQegvgtnE8JHUyy4NO4LPN1W1KHS5koymZMhlKVtMRwbuAfPe/fbgBxxtFxBDLK1gFgd146nIChaEry1R5vN2XI5VbmQR/pwzrBduYoCpb0KpWoz9I0xFbmRnpMVCRLaDPC6bJQFn6U57XOCcSc2V74GnVe6L6Qcvg1m6Th8ul2EUE32Xs3ZHhe9/XCY4DRZb5fdGCdyvo1sL91Fxyir9tzZAtK/25Va/HiDbfl3+eFx4bZzNH9PutRUm2ynxtbFXRIC5VOgus33ttZkKt4Ek+owW7h6C1mGxXAqCsmh1OiLm1iXFlKdbjpSmPZOUFtw3ufuFgkjnfjgmunka1jCN/0hJ23icU+j02JUJWxmKKkTaa9GWzySlwEqB7j8T0GMMfnmgqXyAeEjX+8l1QAGJrUMkap6wmZkjT4TkUnc+4VJWB4oANz5HpjNnEVOY7uFndkSad104XoZTf0crR9K8rQ7ftSgMwevfaH87rct2EbcWmNZzyNO34W3KaG5V5yzqy0jXUBGeRGaj37UwOhSLcwn5ieQIHnikdj1I2LMDc9kOIH7J7Op0GlNvMxbJDMGPDQjvtnWvMfE8euE0VVLUuYXdys6zIyItXQxLjQqtAfkvJbIcUjf3hYym/IXsfxi14nijkoyB4kvwpkvNzW6UzffMdhTiWXninds2QCo9SB64+VRRB8gaTZUV+yBVCvUb3jZ7R1oykEo2LzyBvJubtC4Kr772J8cV8OFycnMJ7A+vruvYp2k3Ka0+RJks7WXEVDWrg2twKNu47uHliVqYGRy8tjsy80BQWWoyK1OmFeZL742QO6zaBlT1sT5EYp4GiOmawDZT1a7mS2WbQ2EKnpTDbk/FRmU47n33CUnd1thrE500vXqqqoa2KCwSaLNqOj7T7FSSqY3Bs24Ui72X6XOSkqTY34g3B4XwgxLDWGfK3QnZKWyubquCtZGjiU5i7JSrvBjquMC/A624tt5rv/S1Ea/p9NqclxulBUSBkKM7iRtXOZ+3+cU+EcORNs+fUrKSZ7tlPhVp+O20H0B9u1rk9tI8+/wDONKqkYJHALSehbIxsjRYr/9k=', 'jpg', autoOptions.margin.left, 10, 40, 40);
                                doc.addImage('data:image/' + reportDetails.logotype + ';base64,' + reportDetails.logo, reportDetails.logotype, autoOptions.margin.left, 10, 40, 40);
                            };

                            var afterPage = function (data) {
                                doc.setFontStyle('normal');
                                doc.setFontSize(8);
                                // Date and time of the report
                                doc.autoTableText("Report Generated By:" + reportDetails.generatedby, autoOptions.margin.left, doc.internal.pageSize.height - 35, {
                                    halign: 'left'
                                });
                                doc.autoTableText("Generation Date Time:" + Q.formatDate(new Date(), "dd-MM-yyyy HH:mm"), autoOptions.margin.left, doc.internal.pageSize.height - 20, {
                                    halign: 'left'
                                });


                                doc.autoTableText("Checked By:_________________", doc.internal.pageSize.width - autoOptions.margin.right, doc.internal.pageSize.height - 35, {
                                    halign: 'right'
                                });
                                doc.autoTableText("Report Approved By:_________________", doc.internal.pageSize.width - autoOptions.margin.right, doc.internal.pageSize.height - 20, {
                                    halign: 'right'
                                });
                            };
                            autoOptions.afterPageContent = afterPage;
                            autoOptions.beforePageContent = beforePage;
                        }
                        doc.autoTable(columns, data, autoOptions);
                        if (typeof doc.putTotalPages === 'function') {
                            doc.putTotalPages(totalPagesExp);
                        }
                        if (!options.output || options.output == "file") {
                            var fileName = options.fileName || options.reportTitle || "{0}_{1}.pdf";
                            fileName = Q.format(fileName, g.getTitle() || "report", Q.formatDate(new Date(), "yyyyMMdd_HHmm"));
                            doc.save(fileName);
                            return;
                        }
                        if (options.autoPrint)
                            doc.autoPrint();
                        var output = options.output;
                        if (output == 'newwindow' || '_blank')
                            output = 'dataurlnewwindow';
                        else if (output == 'window')
                            output = 'datauri';
                        doc.output(output);

                       
                    }
                    
                });
               
            }

            function showLoader() {
                $('.loader').removeClass('hidden');
            }
            function hideLoader() {
                $('.loader').addClass('hidden');
            }
            PdfExportHelper.exportToPdf = exportToPdf;
            function createToolButton(options) {
                return {
                    title: options.title || '',
                    hint: options.hint || 'PDF',
                    cssClass: 'export-pdf-button',
                    onClick: function () { return exportToPdf(options); },
                    separator: options.separator
                };
            }
            PdfExportHelper.createToolButton = createToolButton;
            function includeJsPDF() {
                if (typeof jsPDF !== "undefined")
                    return;
                var script = $("jsPDFScript");
                if (script.length > 0)
                    return;
                $("<script/>")
                    .attr("type", "text/javascript")
                    .attr("id", "jsPDFScript")
                    .attr("src", Q.resolveUrl("~/Scripts/jspdf.min.js"))
                    .appendTo(document.head);
            }
            function includeAutoTable() {
                includeJsPDF();
                if (typeof jsPDF === "undefined" ||
                    typeof jsPDF.API == "undefined" ||
                    typeof jsPDF.API.autoTable !== "undefined")
                    return;
                var script = $("jsPDFAutoTableScript");
                if (script.length > 0)
                    return;
                $("<script/>")
                    .attr("type", "text/javascript")
                    .attr("id", "jsPDFAutoTableScript")
                    .attr("src", Q.resolveUrl("~/Scripts/jspdf.plugin.autotable.min.js"))
                    .appendTo(document.head);
            }
        })(PdfExportHelper = Common.PdfExportHelper || (Common.PdfExportHelper = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var ReportDialog = /** @class */ (function (_super) {
            __extends(ReportDialog, _super);
            function ReportDialog(options) {
                var _this = _super.call(this, options) || this;
                _this.updateInterface();
                _this.loadReport(_this.options.reportKey);
                return _this;
            }
            ReportDialog.prototype.getDialogButtons = function () {
                return null;
            };
            ReportDialog.prototype.createPropertyGrid = function () {
                this.propertyGrid && this.byId('PropertyGrid').html('').attr('class', '');
                this.propertyGrid = new Serenity.PropertyGrid(this.byId('PropertyGrid'), {
                    idPrefix: this.idPrefix,
                    useCategories: true,
                    items: this.report.Properties
                }).init(null);
            };
            ReportDialog.prototype.loadReport = function (reportKey) {
                var _this = this;
                Q.serviceCall({
                    url: Q.resolveUrl('~/Report/Retrieve'),
                    request: {
                        ReportKey: reportKey
                    },
                    onSuccess: function (response) {
                        _this.report = response;
                        _this.element.dialog().dialog('option', 'title', _this.report.Title);
                        _this.createPropertyGrid();
                        _this.propertyGrid.load(_this.report.InitialSettings || {});
                        _this.updateInterface();
                        _this.dialogOpen();
                    }
                });
            };
            ReportDialog.prototype.updateInterface = function () {
                this.toolbar.findButton('print-preview-button')
                    .toggle(this.report && !this.report.IsDataOnlyReport);
                this.toolbar.findButton('export-pdf-button')
                    .toggle(this.report && !this.report.IsDataOnlyReport);
                this.toolbar.findButton('export-xlsx-button')
                    .toggle(this.report && this.report.IsDataOnlyReport);
            };
            ReportDialog.prototype.executeReport = function (target, ext, download) {
                if (!this.validateForm()) {
                    return;
                }
                var opt = {};
                this.propertyGrid.save(opt);
                Common.ReportHelper.execute({
                    download: download,
                    reportKey: this.report.ReportKey,
                    extension: ext,
                    target: target,
                    params: opt
                });
            };
            ReportDialog.prototype.getToolbarButtons = function () {
                var _this = this;
                return [
                    {
                        title: 'Preview',
                        cssClass: 'print-preview-button',
                        onClick: function () { return _this.executeReport('_blank', null, false); }
                    },
                    {
                        title: 'PDF',
                        cssClass: 'export-pdf-button',
                        onClick: function () { return _this.executeReport('_blank', 'pdf', true); }
                    },
                    {
                        title: 'Excel',
                        cssClass: 'export-xlsx-button',
                        onClick: function () { return _this.executeReport('_blank', 'xlsx', true); }
                    }
                ];
            };
            return ReportDialog;
        }(Serenity.TemplatedDialog));
        Common.ReportDialog = ReportDialog;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var ReportHelper;
        (function (ReportHelper) {
            function createToolButton(options) {
                return {
                    title: Q.coalesce(options.title, 'Report'),
                    cssClass: Q.coalesce(options.cssClass, 'print-button'),
                    icon: options.icon,
                    onClick: function () {
                        ReportHelper.execute(options);
                    }
                };
            }
            ReportHelper.createToolButton = createToolButton;
            function execute(options) {
                var opt = options.getParams ? options.getParams() : options.params;
                Q.postToUrl({
                    url: '~/Report/' + (options.download ? 'Download' : 'Render'),
                    params: {
                        key: options.reportKey,
                        ext: Q.coalesce(options.extension, 'pdf'),
                        opt: opt ? $.toJSON(opt) : ''
                    },
                    target: Q.coalesce(options.target, '_blank')
                });
            }
            ReportHelper.execute = execute;
        })(ReportHelper = Common.ReportHelper || (Common.ReportHelper = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var ReportPage = /** @class */ (function (_super) {
            __extends(ReportPage, _super);
            function ReportPage(element) {
                var _this = _super.call(this, element) || this;
                $('.report-link', element).click(function (e) { return _this.reportLinkClick(e); });
                $('div.line', element).click(function (e) { return _this.categoryClick(e); });
                new Serenity.QuickSearchInput($('.s-QuickSearchBar input', element), {
                    onSearch: function (field, text, done) {
                        _this.updateMatchFlags(text);
                        done(true);
                    }
                });
                return _this;
            }
            ReportPage.prototype.updateMatchFlags = function (text) {
                var liList = $('.report-list', this.element).find('li').removeClass('non-match');
                text = Q.trimToNull(text);
                if (!text) {
                    liList.children('ul').hide();
                    liList.show().removeClass('expanded');
                    return;
                }
                text = Select2.util.stripDiacritics(text).toUpperCase();
                var reportItems = liList.filter('.report-item');
                reportItems.each(function (ix, e) {
                    var x = $(e);
                    var title = Select2.util.stripDiacritics(Q.coalesce(x.text(), '').toUpperCase());
                    if (title.indexOf(text) < 0) {
                        x.addClass('non-match');
                    }
                });
                var matchingItems = reportItems.not('.non-match');
                var visibles = matchingItems.parents('li').add(matchingItems);
                var nonVisibles = liList.not(visibles);
                nonVisibles.hide().addClass('non-match');
                visibles.show();
                if (visibles.length <= 100) {
                    liList.children('ul').show();
                    liList.addClass('expanded');
                }
            };
            ReportPage.prototype.categoryClick = function (e) {
                var li = $(e.target).closest('li');
                if (li.hasClass('expanded')) {
                    li.find('ul').hide('fast');
                    li.removeClass('expanded');
                    li.find('li').removeClass('expanded');
                }
                else {
                    li.addClass('expanded');
                    li.children('ul').show('fast');
                    if (li.children('ul').children('li').length === 1 && !li.children('ul').children('li').hasClass('expanded')) {
                        li.children('ul').children('li').children('.line').click();
                    }
                }
            };
            ReportPage.prototype.reportLinkClick = function (e) {
                e.preventDefault();
                new Common.ReportDialog({
                    reportKey: $(e.target).data('key')
                }).dialogOpen();
            };
            return ReportPage;
        }(Serenity.Widget));
        Common.ReportPage = ReportPage;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var LanguageSelection = /** @class */ (function (_super) {
            __extends(LanguageSelection, _super);
            function LanguageSelection(select, currentLanguage) {
                var _this = _super.call(this, select) || this;
                currentLanguage = Q.coalesce(currentLanguage, 'en');
                _this.change(function (e) {
                    $.cookie('LanguagePreference', select.val(), {
                        path: Q.Config.applicationPath,
                        expires: 365
                    });
                    window.location.reload(true);
                });
                Q.getLookupAsync('Configuration.Language').then(function (x) {
                    if (!Q.any(x.items, function (z) { return z.LanguageId === currentLanguage; })) {
                        var idx = currentLanguage.lastIndexOf('-');
                        if (idx >= 0) {
                            currentLanguage = currentLanguage.substr(0, idx);
                            if (!Q.any(x.items, function (y) { return y.LanguageId === currentLanguage; })) {
                                currentLanguage = 'en';
                            }
                        }
                        else {
                            currentLanguage = 'en';
                        }
                    }
                    for (var _i = 0, _a = x.items; _i < _a.length; _i++) {
                        var l = _a[_i];
                        Q.addOption(select, l.LanguageId, l.LanguageName);
                    }
                    select.val(currentLanguage);
                });
                return _this;
            }
            return LanguageSelection;
        }(Serenity.Widget));
        Common.LanguageSelection = LanguageSelection;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var SidebarSearch = /** @class */ (function (_super) {
            __extends(SidebarSearch, _super);
            function SidebarSearch(input, menuUL) {
                var _this = _super.call(this, input) || this;
                new Serenity.QuickSearchInput(input, {
                    onSearch: function (field, text, success) {
                        _this.updateMatchFlags(text);
                        success(true);
                    }
                });
                _this.menuUL = menuUL;
                return _this;
            }
            SidebarSearch.prototype.updateMatchFlags = function (text) {
                var liList = this.menuUL.find('li').removeClass('non-match');
                text = Q.trimToNull(text);
                if (text == null) {
                    liList.show();
                    liList.removeClass('expanded');
                    return;
                }
                var parts = text.replace(',', ' ').split(' ').filter(function (x) { return !Q.isTrimmedEmpty(x); });
                for (var i = 0; i < parts.length; i++) {
                    parts[i] = Q.trimToNull(Select2.util.stripDiacritics(parts[i]).toUpperCase());
                }
                var items = liList;
                items.each(function (idx, e) {
                    var x = $(e);
                    var title = Select2.util.stripDiacritics(Q.coalesce(x.text(), '').toUpperCase());
                    for (var _i = 0, parts_1 = parts; _i < parts_1.length; _i++) {
                        var p = parts_1[_i];
                        if (p != null && !(title.indexOf(p) !== -1)) {
                            x.addClass('non-match');
                            break;
                        }
                    }
                });
                var matchingItems = items.not('.non-match');
                var visibles = matchingItems.parents('li').add(matchingItems);
                var nonVisibles = liList.not(visibles);
                nonVisibles.hide().addClass('non-match');
                visibles.show();
                liList.addClass('expanded');
            };
            return SidebarSearch;
        }(Serenity.Widget));
        Common.SidebarSearch = SidebarSearch;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var ThemeSelection = /** @class */ (function (_super) {
            __extends(ThemeSelection, _super);
            function ThemeSelection(select) {
                var _this = _super.call(this, select) || this;
                _this.change(function (e) {
                    $.cookie('ThemePreference', select.val(), {
                        path: Q.Config.applicationPath,
                        expires: 365
                    });
                    $('body').removeClass('skin-' + _this.getCurrentTheme());
                    $('body').addClass('skin-' + select.val());
                });
                Q.addOption(select, 'blue', Q.text('Site.Layout.ThemeBlue'));
                Q.addOption(select, 'blue-light', Q.text('Site.Layout.ThemeBlueLight'));
                Q.addOption(select, 'purple', Q.text('Site.Layout.ThemePurple'));
                Q.addOption(select, 'purple-light', Q.text('Site.Layout.ThemePurpleLight'));
                Q.addOption(select, 'red', Q.text('Site.Layout.ThemeRed'));
                Q.addOption(select, 'red-light', Q.text('Site.Layout.ThemeRedLight'));
                Q.addOption(select, 'green', Q.text('Site.Layout.ThemeGreen'));
                Q.addOption(select, 'green-light', Q.text('Site.Layout.ThemeGreenLight'));
                Q.addOption(select, 'yellow', Q.text('Site.Layout.ThemeYellow'));
                Q.addOption(select, 'yellow-light', Q.text('Site.Layout.ThemeYellowLight'));
                Q.addOption(select, 'black', Q.text('Site.Layout.ThemeBlack'));
                Q.addOption(select, 'black-light', Q.text('Site.Layout.ThemeBlackLight'));
                select.val(_this.getCurrentTheme());
                return _this;
            }
            ThemeSelection.prototype.getCurrentTheme = function () {
                var skinClass = Q.first(($('body').attr('class') || '').split(' '), function (x) { return Q.startsWith(x, 'skin-'); });
                if (skinClass) {
                    return skinClass.substr(5);
                }
                return 'blue';
            };
            return ThemeSelection;
        }(Serenity.Widget));
        Common.ThemeSelection = ThemeSelection;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var BasicProgressDialog = /** @class */ (function (_super) {
        __extends(BasicProgressDialog, _super);
        function BasicProgressDialog() {
            var _this = _super.call(this) || this;
            _this.byId('ProgressBar').progressbar({
                max: 100,
                value: 0,
                change: function (e, v) {
                    _this.byId('ProgressLabel').text(_this.value + ' / ' + _this.max);
                }
            });
            return _this;
        }
        Object.defineProperty(BasicProgressDialog.prototype, "max", {
            get: function () {
                return this.byId('ProgressBar').progressbar().progressbar('option', 'max');
            },
            set: function (value) {
                this.byId('ProgressBar').progressbar().progressbar('option', 'max', value);
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(BasicProgressDialog.prototype, "value", {
            get: function () {
                return this.byId('ProgressBar').progressbar('value');
            },
            set: function (value) {
                this.byId('ProgressBar').progressbar().progressbar('value', value);
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(BasicProgressDialog.prototype, "title", {
            get: function () {
                return this.element.dialog().dialog('option', 'title');
            },
            set: function (value) {
                this.element.dialog().dialog('option', 'title', value);
            },
            enumerable: true,
            configurable: true
        });
        BasicProgressDialog.prototype.getDialogOptions = function () {
            var _this = this;
            var opt = _super.prototype.getDialogOptions.call(this);
            opt.title = Q.text('Site.BasicProgressDialog.PleaseWait');
            opt.width = 600;
            opt.buttons = [{
                text: Q.text('Dialogs.CancelButton'),
                click: function () {
                    _this.cancelled = true;
                    _this.element.closest('.ui-dialog')
                        .find('.ui-dialog-buttonpane .ui-button')
                        .attr('disabled', 'disabled')
                        .css('opacity', '0.5');
                    _this.element.dialog('option', 'title', Q.trimToNull(_this.cancelTitle) ||
                        Q.text('Site.BasicProgressDialog.CancelTitle'));
                }
            }];
            return opt;
        };
        BasicProgressDialog.prototype.initDialog = function () {
            _super.prototype.initDialog.call(this);
            this.element.closest('.ui-dialog').find('.ui-dialog-titlebar-close').hide();
        };
        BasicProgressDialog.prototype.getTemplate = function () {
            return ("<div class='s-DialogContent s-BasicProgressDialogContent'>" +
                "<div id='~_StatusText' class='status-text' ></div>" +
                "<div id='~_ProgressBar' class='progress-bar'>" +
                "<div id='~_ProgressLabel' class='progress-label' ></div>" +
                "</div>" +
                "</div>");
        };
        return BasicProgressDialog;
    }(Serenity.TemplatedDialog));
    CVC.BasicProgressDialog = BasicProgressDialog;
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var BulkServiceAction = /** @class */ (function () {
            function BulkServiceAction() {
            }
            BulkServiceAction.prototype.createProgressDialog = function () {
                this.progressDialog = new CVC.BasicProgressDialog();
                this.progressDialog.dialogOpen();
                this.progressDialog.max = this.keys.length;
                this.progressDialog.value = 0;
            };
            BulkServiceAction.prototype.getConfirmationFormat = function () {
                return Q.text('Site.BulkServiceAction.ConfirmationFormat');
            };
            BulkServiceAction.prototype.getConfirmationMessage = function (targetCount) {
                return Q.format(this.getConfirmationFormat(), targetCount);
            };
            BulkServiceAction.prototype.confirm = function (targetCount, action) {
                Q.confirm(this.getConfirmationMessage(targetCount), action);
            };
            BulkServiceAction.prototype.getNothingToProcessMessage = function () {
                return Q.text('Site.BulkServiceAction.NothingToProcess');
            };
            BulkServiceAction.prototype.nothingToProcess = function () {
                Q.notifyError(this.getNothingToProcessMessage());
            };
            BulkServiceAction.prototype.getParallelRequests = function () {
                return 1;
            };
            BulkServiceAction.prototype.getBatchSize = function () {
                return 1;
            };
            BulkServiceAction.prototype.startParallelExecution = function () {
                this.createProgressDialog();
                this.successCount = 0;
                this.errorCount = 0;
                this.pendingRequests = 0;
                this.completedRequests = 0;
                this.errorCount = 0;
                this.errorByKey = {};
                this.queue = this.keys.slice();
                this.queueIndex = 0;
                var parallelRequests = this.getParallelRequests();
                while (parallelRequests-- > 0) {
                    this.executeNextBatch();
                }
            };
            BulkServiceAction.prototype.serviceCallCleanup = function () {
                this.pendingRequests--;
                this.completedRequests++;
                var title = Q.text((this.progressDialog.cancelled ?
                    'Site.BasicProgressDialog.CancelTitle' : 'Site.BasicProgressDialog.PleaseWait'));
                title += ' (';
                if (this.successCount > 0) {
                    title += Q.format(Q.text('Site.BulkServiceAction.SuccessCount'), this.successCount);
                }
                if (this.errorCount > 0) {
                    if (this.successCount > 0) {
                        title += ', ';
                    }
                    title += Q.format(Q.text('Site.BulkServiceAction.ErrorCount'), this.errorCount);
                }
                this.progressDialog.title = title + ')';
                this.progressDialog.value = this.successCount + this.errorCount;
                if (!this.progressDialog.cancelled && this.progressDialog.value < this.keys.length) {
                    this.executeNextBatch();
                }
                else if (this.pendingRequests === 0) {
                    this.progressDialog.dialogClose();
                    this.showResults();
                    if (this.done) {
                        this.done();
                        this.done = null;
                    }
                }
            };
            BulkServiceAction.prototype.executeForBatch = function (batch) {
            };
            BulkServiceAction.prototype.executeNextBatch = function () {
                var batchSize = this.getBatchSize();
                var batch = [];
                while (true) {
                    if (batch.length >= batchSize) {
                        break;
                    }
                    if (this.queueIndex >= this.queue.length) {
                        break;
                    }
                    batch.push(this.queue[this.queueIndex++]);
                }
                if (batch.length > 0) {
                    this.pendingRequests++;
                    this.executeForBatch(batch);
                }
            };
            BulkServiceAction.prototype.getAllHadErrorsFormat = function () {
                return Q.text('Site.BulkServiceAction.AllHadErrorsFormat');
            };
            BulkServiceAction.prototype.showAllHadErrors = function () {
                Q.notifyError(Q.format(this.getAllHadErrorsFormat(), this.errorCount));
            };
            BulkServiceAction.prototype.getSomeHadErrorsFormat = function () {
                return Q.text('Site.BulkServiceAction.SomeHadErrorsFormat');
            };
            BulkServiceAction.prototype.showSomeHadErrors = function () {
                Q.notifyWarning(Q.format(this.getSomeHadErrorsFormat(), this.successCount, this.errorCount));
            };
            BulkServiceAction.prototype.getAllSuccessFormat = function () {
                return Q.text('Site.BulkServiceAction.AllSuccessFormat');
            };
            BulkServiceAction.prototype.showAllSuccess = function () {
                Q.notifySuccess(Q.format(this.getAllSuccessFormat(), this.successCount));
            };
            BulkServiceAction.prototype.showResults = function () {
                if (this.errorCount === 0 && this.successCount === 0) {
                    this.nothingToProcess();
                    return;
                }
                if (this.errorCount > 0 && this.successCount === 0) {
                    this.showAllHadErrors();
                    return;
                }
                if (this.errorCount > 0) {
                    this.showSomeHadErrors();
                    return;
                }
                this.showAllSuccess();
            };
            BulkServiceAction.prototype.execute = function (keys) {
                var _this = this;
                this.keys = keys;
                if (this.keys.length === 0) {
                    this.nothingToProcess();
                    return;
                }
                this.confirm(this.keys.length, function () { return _this.startParallelExecution(); });
            };
            BulkServiceAction.prototype.get_successCount = function () {
                return this.successCount;
            };
            BulkServiceAction.prototype.set_successCount = function (value) {
                this.successCount = value;
            };
            BulkServiceAction.prototype.get_errorCount = function () {
                return this.errorCount;
            };
            BulkServiceAction.prototype.set_errorCount = function (value) {
                this.errorCount = value;
            };
            return BulkServiceAction;
        }());
        Common.BulkServiceAction = BulkServiceAction;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var DialogUtils;
    (function (DialogUtils) {
        function pendingChangesConfirmation(element, hasPendingChanges) {
            element.on('dialogbeforeclose panelbeforeclose', function (e) {
                if (!Serenity.WX.hasOriginalEvent(e) || !hasPendingChanges()) {
                    return;
                }
                e.preventDefault();
                Q.confirm('You have pending changes. Save them?', function () { return element.find('div.save-and-close-button').click(); }, {
                    onNo: function () {
                        if (element.hasClass('ui-dialog-content'))
                            element.dialog('close');
                        else if (element.hasClass('s-Panel'))
                            Serenity.TemplatedDialog.closePanel(element);
                    }
                });
            });
        }
        DialogUtils.pendingChangesConfirmation = pendingChangesConfirmation;
        function holdingDialogAfterUpdate(element) {
            element.on('dialogbeforeclose panelbeforeclose', function (e) {
                if (!Serenity.WX.hasOriginalEvent(e)) {
                    return;
                }
                e.preventDefault();
            });
        }
        DialogUtils.holdingDialogAfterUpdate = holdingDialogAfterUpdate;
    })(DialogUtils = CVC.DialogUtils || (CVC.DialogUtils = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var EnumSelectFormatter = /** @class */ (function () {
            function EnumSelectFormatter() {
                this.allowClear = true;
            }
            EnumSelectFormatter.prototype.format = function (ctx) {
                var enumType = Serenity.EnumTypeRegistry.get(this.enumKey);
                var sb = "<select>";
                if (this.allowClear) {
                    sb += '<option value="">';
                    sb += Q.htmlEncode(this.emptyItemText || Q.text("Controls.SelectEditor.EmptyItemText"));
                    sb += '</option>';
                }
                for (var _i = 0, _a = Object.keys(enumType).filter(function (v) { return !isNaN(parseInt(v, 10)); }); _i < _a.length; _i++) {
                    var x = _a[_i];
                    sb += '<option value="' + x + '"';
                    if (x == ctx.value)
                        sb += " selected";
                    var name = enumType[x];
                    sb += ">";
                    sb += Q.htmlEncode(Q.tryGetText("Enums." + this.enumKey + "." + name) || name);
                    sb += "</option>";
                }
                sb += "</select>";
                return sb;
            };
            __decorate([
                Serenity.Decorators.option()
            ], EnumSelectFormatter.prototype, "enumKey", void 0);
            __decorate([
                Serenity.Decorators.option()
            ], EnumSelectFormatter.prototype, "allowClear", void 0);
            __decorate([
                Serenity.Decorators.option()
            ], EnumSelectFormatter.prototype, "emptyItemText", void 0);
            EnumSelectFormatter = __decorate([
                Serenity.Decorators.registerFormatter()
            ], EnumSelectFormatter);
            return EnumSelectFormatter;
        }());
        Common.EnumSelectFormatter = EnumSelectFormatter;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var ExcelExportHelper;
        (function (ExcelExportHelper) {
            function createToolButton(options) {
                return {
                    hint: Q.coalesce(options.title, 'Excel'),
                    title: Q.coalesce(options.hint, ''),
                    cssClass: 'export-xlsx-button',
                    onClick: function () {
                        if (!options.onViewSubmit()) {
                            return;
                        }
                        var grid = options.grid;
                        var request = Q.deepClone(grid.getView().params);
                        request.Take = 0;
                        request.Skip = 0;
                        var sortBy = grid.getView().sortBy;
                        if (sortBy) {
                            request.Sort = sortBy;
                        }
                        request.IncludeColumns = [];
                        var columns = grid.getGrid().getColumns();
                        for (var _i = 0, columns_1 = columns; _i < columns_1.length; _i++) {
                            var column = columns_1[_i];
                            request.IncludeColumns.push(column.id || column.field);
                        }
                        Q.postToService({ service: options.service, request: request, target: '_blank' });
                    },
                    separator: options.separator
                };
            }
            ExcelExportHelper.createToolButton = createToolButton;
        })(ExcelExportHelper = Common.ExcelExportHelper || (Common.ExcelExportHelper = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var GridEditorBase = /** @class */ (function (_super) {
            __extends(GridEditorBase, _super);
            function GridEditorBase(container) {
                var _this = _super.call(this, container) || this;
                _this.nextId = 1;
                return _this;
            }
            GridEditorBase.prototype.getIdProperty = function () { return "__id"; };
            GridEditorBase.prototype.id = function (entity) {
                return entity[this.getIdProperty()];
            };
            GridEditorBase.prototype.getNextId = function () {
                return "`" + this.nextId++;
            };
            GridEditorBase.prototype.setNewId = function (entity) {
                entity[this.getIdProperty()] = this.getNextId();
            };
            GridEditorBase.prototype.save = function (opt, callback) {
                var _this = this;
                var request = opt.request;
                var row = Q.deepClone(request.Entity);
                var id = this.id(row);
                if (id == null) {
                    row[this.getIdProperty()] = this.getNextId();
                }
                if (!this.validateEntity(row, id)) {
                    return;
                }
                var items = this.view.getItems().slice();
                if (id == null) {
                    items.push(row);
                }
                else {
                    var index = Q.indexOf(items, function (x) { return _this.id(x) === id; });
                    items[index] = Q.deepClone({}, items[index], row);
                }
                this.setEntities(items);
                callback({});
            };
            GridEditorBase.prototype.deleteEntity = function (id) {
                this.view.deleteItem(id);
                return true;
            };
            GridEditorBase.prototype.validateEntity = function (row, id) {
                return true;
            };
            GridEditorBase.prototype.setEntities = function (items) {
                this.view.setItems(items, true);
            };
            GridEditorBase.prototype.getNewEntity = function () {
                return {};
            };
            GridEditorBase.prototype.getButtons = function () {
                var _this = this;
                return [{
                    title: this.getAddButtonCaption(),
                    cssClass: 'add-button',
                    onClick: function () {
                        _this.createEntityDialog(_this.getItemType(), function (dlg) {
                            var dialog = dlg;
                            dialog.onSave = function (opt, callback) { return _this.save(opt, callback); };
                            dialog.loadEntityAndOpenDialog(_this.getNewEntity());
                        });
                    }
                }];
            };
            GridEditorBase.prototype.editItem = function (entityOrId) {
                var _this = this;
                var id = entityOrId;
                var item = this.view.getItemById(id);
                this.createEntityDialog(this.getItemType(), function (dlg) {
                    var dialog = dlg;
                    dialog.onDelete = function (opt, callback) {
                        if (!_this.deleteEntity(id)) {
                            return;
                        }
                        callback({});
                    };
                    dialog.onSave = function (opt, callback) { return _this.save(opt, callback); };
                    dialog.loadEntityAndOpenDialog(item);
                });
                ;
            };
            GridEditorBase.prototype.getEditValue = function (property, target) {
                target[property.name] = this.value;
            };
            GridEditorBase.prototype.setEditValue = function (source, property) {
                this.value = source[property.name];
            };
            Object.defineProperty(GridEditorBase.prototype, "value", {
                get: function () {
                    var p = this.getIdProperty();
                    return this.view.getItems().map(function (x) {
                        var y = Q.deepClone(x);
                        var id = y[p];
                        if (id && id.toString().charAt(0) == '`')
                            delete y[p];
                        return y;
                    });
                },
                set: function (value) {
                    var _this = this;
                    var p = this.getIdProperty();
                    this.view.setItems((value || []).map(function (x) {
                        var y = Q.deepClone(x);
                        if (y[p] == null)
                            y[p] = "`" + _this.getNextId();
                        return y;
                    }), true);
                },
                enumerable: true,
                configurable: true
            });
            GridEditorBase.prototype.getGridCanLoad = function () {
                return false;
            };
            GridEditorBase.prototype.usePager = function () {
                return false;
            };
            GridEditorBase.prototype.getInitialTitle = function () {
                return null;
            };
            GridEditorBase.prototype.createQuickSearchInput = function () {
            };
            GridEditorBase = __decorate([
                Serenity.Decorators.registerClass([Serenity.IGetEditValue, Serenity.ISetEditValue]),
                Serenity.Decorators.editor(),
                Serenity.Decorators.element("<div/>")
            ], GridEditorBase);
            return GridEditorBase;
        }(Serenity.EntityGrid));
        Common.GridEditorBase = GridEditorBase;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var GridEditorDialog = /** @class */ (function (_super) {
            __extends(GridEditorDialog, _super);
            function GridEditorDialog() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            GridEditorDialog.prototype.getIdProperty = function () { return "__id"; };
            GridEditorDialog.prototype.destroy = function () {
                this.onSave = null;
                this.onDelete = null;
                _super.prototype.destroy.call(this);
            };
            GridEditorDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                // apply changes button doesn't work properly with in-memory grids yet
                if (this.applyChangesButton) {
                    this.applyChangesButton.hide();
                }
            };
            GridEditorDialog.prototype.saveHandler = function (options, callback) {
                this.onSave && this.onSave(options, callback);
            };
            GridEditorDialog.prototype.deleteHandler = function (options, callback) {
                this.onDelete && this.onDelete(options, callback);
            };
            GridEditorDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], GridEditorDialog);
            return GridEditorDialog;
        }(Serenity.EntityDialog));
        Common.GridEditorDialog = GridEditorDialog;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelRollDialog = /** @class */ (function (_super) {
            __extends(LabelRollDialog, _super);
            function LabelRollDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Batch.LabelRollForm(_this.idPrefix);
                return _this;
            }
            LabelRollDialog.prototype.getFormKey = function () { return Batch.LabelRollForm.formKey; };
            LabelRollDialog.prototype.getIdProperty = function () { return Batch.LabelRollRow.idProperty; };
            LabelRollDialog.prototype.getLocalTextPrefix = function () { return Batch.LabelRollRow.localTextPrefix; };
            LabelRollDialog.prototype.getNameProperty = function () { return Batch.LabelRollRow.nameProperty; };
            LabelRollDialog.prototype.getService = function () { return Batch.LabelRollService.baseUrl; };


          
            LabelRollDialog.prototype.onDialogOpen = function () {


                var keypara = [
                    '7 8 9',
                    '4 5 6',
                    '1 2 3',
                    '{bksp} - 0 ',
                    '{a} {c}'
                ];

                $(':text').blur();
                $(".editor").click(function () {

                    $("input[name='LabelRollNumber'],input[name='NumberOfLabels']")
                        //$("input.editor[type=text]")
                        .keyboard({
                            layout: 'custom',
                            customLayout: {
                                'normal': [
                                    '7 8 9',
                                    '4 5 6',
                                    '1 2 3',
                                    '{bksp} 0',
                                    '{a} {c}'
                                ]

                            }
                        })
                        .addTyping({
                            showTyping: true,
                            delay: 250
                        })
                        .addCaret({
                            caretClass: '',
                            // *** for future use ***
                            // data-attribute containing the character(s) next to the caret
                            charAttr: 'data-character',
                            // # character(s) next to the caret (can be negative for RTL)
                            // default is 1 which shows the character to the right of the caret
                            // setting this to -1 shows the character to the left
                            charIndex: -1,
                            // tweak caret position & height
                            offsetX: 0,
                            offsetY: 0,
                            adjustHt: 0
                        });

                    // Typing Extension
                    $('.icon').click(function () {
                        var kb = $(this).prev().getkeyboard();
                        // typeIn( text, delay, callback );
                        kb.reveal().typeIn(simulateTyping, 500, function () {
                            // do something after text is added
                            // kb.accept();
                        });
                    });
                });


                $("input[name='Remark']")
                    .keyboard({
                        layout: 'custom',
                        customLayout: {
                            'normal': [
                                '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                                '{tab} q w e r t y u i o p [ ] \\',
                                'a s d f g h j k l ; \' {accept}',
                                '{shift} z x c v b n m , . / {shift}',
                                ' {space} {left} {right}'
                            ],
                            'shift': [
                                '~ ! @@ # $ % ^ & * ( ) _ + {bksp}',
                                '{tab} Q W E R T Y U I O P { } |',
                                'A S D F G H J K L : " {accept}',
                                '{shift} Z X C V B N M < > ? {shift}',
                                ' {space} {left} {right}'
                            ]
                        }
                    })
                    .addTyping({
                        showTyping: true,
                        delay: 250
                    })
                    .addCaret({
                        caretClass: '',
                        // *** for future use ***
                        // data-attribute containing the character(s) next to the caret
                        charAttr: 'data-character',
                        // # character(s) next to the caret (can be negative for RTL)
                        // default is 1 which shows the character to the right of the caret
                        // setting this to -1 shows the character to the left
                        charIndex: -1,
                        // tweak caret position & height
                        offsetX: 0,
                        offsetY: 0,
                        adjustHt: 0
                    });

                // Typing Extension
                $('.icon').click(function () {
                    var kb = $(this).prev().getkeyboard();
                    // typeIn( text, delay, callback );
                    kb.reveal().typeIn(simulateTyping, 500, function () {
                        // do something after text is added
                        // kb.accept();
                    });
                });
            };





            LabelRollDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], LabelRollDialog);
            return LabelRollDialog;
        }(Serenity.EntityDialog));
        Batch.LabelRollDialog = LabelRollDialog;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));

 //Commented  on 19 Oct 2018 11.27 am start region
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelRollGrid = /** @class */ (function (_super) {
            __extends(LabelRollGrid, _super);
            function LabelRollGrid(container) {
                var _this = _super.call(this, container) || this;
                _this.toolbar.findButton("refresh-button").remove();
                _this.toolbar.findButton("column-picker-button").remove();
                return _this;
            }
            LabelRollGrid.prototype.getColumnsKey = function () { return 'Batch.LabelRoll'; };
            LabelRollGrid.prototype.getDialogType = function () { return Batch.LabelRollDialog; };
            LabelRollGrid.prototype.getIdProperty = function () { return Batch.LabelRollRow.idProperty; };
            LabelRollGrid.prototype.getLocalTextPrefix = function () { return Batch.LabelRollRow.localTextPrefix; };
            LabelRollGrid.prototype.getService = function () { return Batch.LabelRollService.baseUrl; };
            LabelRollGrid.prototype.getInitialTitle = function () {
                return null;
            };
            LabelRollGrid.prototype.onClick = function (e, row, cell) {
                _super.prototype.onClick.call(this, e, row, cell);
                var lrollgrid = this;
                setTimeout(function () { lrollgrid.refresh(); }, 2500);
            };
            //LabelRollGrid.prototype.onClick = function (e) {
            //  base
            //    var lrollgrid = this;
            //    setTimeout(function () { lrollgrid.refresh(); }, 2500);
            //};

            LabelRollGrid.prototype.getColumns = function () {
                var _this = this;
                //var buttons = _super.prototype.getButtons.call(this);
                var columns = _super.prototype.getColumns.call(this);
                var applycolumn = {
                    name: 'Action' /*'Apply Roll'*/,
                    // field: 'IsApplied',
                    width: 300,
                    sortable: false,

                    format: function (ctx) {
                        // console.log(ctx.item.Remark);

                        if (ctx.item.IsApplied != true) {
                            if (ctx.item.LabelRemaining == "0") {
                                return Q.outerHtml($('<button/>')
                                    .addClass('target-text')
                                    .attr('disabled', 'disabled')
                                    .attr('height', 50)
                                    .attr('onclick', 'ApplyRemoveRollClick(this,' + ctx.item.LabelRollId + ',true);')
                                    .text('Apply Roll'));
                            }
                            else {
                                return Q.outerHtml($('<button/>')
                                    .addClass('target-text')
                                    // .attr('disabled','disabled')
                                    .attr('height', 50)
                                    .attr('onclick', 'ApplyRemoveRollClick(this,' + ctx.item.LabelRollId + ',true);')
                                    .text('Apply Roll')
                                    .attr('disabled', !isModifyLabelRoll));
                            }

                        }
                        else {

                            return Q.outerHtml($('<button/>')
                                .addClass('target-text')
                                .attr('height', 50)
                                .attr('onclick', 'ApplyRemoveRollClick(this,' + ctx.item.LabelRollId + ',false);')
                                .text('Remove Roll')
                                .attr('disabled', !isModifyLabelRoll));

                        }
                    }

                    //format: function (ctx) {
                    //    if (ctx.value != true) {
                    //        return Q.outerHtml($('<button/>')
                    //            .addClass('target-text')
                    //            .attr('height', 50)
                    //            .attr('onclick', 'ApplyRemoveRollClick(this,' + ctx.item.LabelRollId + ',true);')
                    //            .text('Apply Roll'));
                    //    }
                    //    else {
                    //        return Q.outerHtml($('<button/>')
                    //            .addClass('target-text')
                    //            .attr('height', 50)
                    //            .attr('onclick', 'ApplyRemoveRollClick(this,' + ctx.item.LabelRollId + ',false);')
                    //            .text('Remove Roll'));
                    //    }
                    //}
                }
                columns.splice(1, 0, applycolumn);
                return columns;
            };

            LabelRollGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], LabelRollGrid);
            return LabelRollGrid;
        }(Serenity.EntityGrid));
        Batch.LabelRollGrid = LabelRollGrid;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
//Commented  on 19 Oct 2018 11.27 am end region

var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelReconciliationDialog = /** @class */ (function (_super) {
            __extends(LabelReconciliationDialog, _super);
            function LabelReconciliationDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Batch.LabelReconciliationForm(_this.idPrefix);
                return _this;
            }
            LabelReconciliationDialog.prototype.getFormKey = function () { return Batch.LabelReconciliationForm.formKey; };
            LabelReconciliationDialog.prototype.getIdProperty = function () { return Batch.LabelReconciliationRow.idProperty; };
            LabelReconciliationDialog.prototype.getLocalTextPrefix = function () { return Batch.LabelReconciliationRow.localTextPrefix; };
            LabelReconciliationDialog.prototype.getService = function () { return Batch.LabelReconciliationService.baseUrl; };
            LabelReconciliationDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], LabelReconciliationDialog);
            return LabelReconciliationDialog;
        }(Serenity.EntityDialog));
        Batch.LabelReconciliationDialog = LabelReconciliationDialog;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelReconciliationGrid = /** @class */ (function (_super) {
            __extends(LabelReconciliationGrid, _super);
            function LabelReconciliationGrid(container) {
                return _super.call(this, container) || this;
            }
            LabelReconciliationGrid.prototype.getColumnsKey = function () { return 'Batch.LabelReconciliation'; };
            LabelReconciliationGrid.prototype.getDialogType = function () { return Batch.LabelReconciliationDialog; };
            LabelReconciliationGrid.prototype.getIdProperty = function () { return Batch.LabelReconciliationRow.idProperty; };
            LabelReconciliationGrid.prototype.getLocalTextPrefix = function () { return Batch.LabelReconciliationRow.localTextPrefix; };
            LabelReconciliationGrid.prototype.getService = function () { return Batch.LabelReconciliationService.baseUrl; };
            LabelReconciliationGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], LabelReconciliationGrid);
            return LabelReconciliationGrid;
        }(Serenity.EntityGrid));
        Batch.LabelReconciliationGrid = LabelReconciliationGrid;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelLostDialog = /** @class */ (function (_super) {
            __extends(LabelLostDialog, _super);
            function LabelLostDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Batch.LabelLostForm(_this.idPrefix);
                return _this;
            }
            LabelLostDialog.prototype.getFormKey = function () { return Batch.LabelLostForm.formKey; };
            LabelLostDialog.prototype.getIdProperty = function () { return Batch.LabelLostRow.idProperty; };
            LabelLostDialog.prototype.getLocalTextPrefix = function () { return Batch.LabelLostRow.localTextPrefix; };
            LabelLostDialog.prototype.getNameProperty = function () { return Batch.LabelLostRow.nameProperty; };
            LabelLostDialog.prototype.getService = function () { return Batch.LabelLostService.baseUrl; };
            LabelLostDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], LabelLostDialog);
            return LabelLostDialog;
        }(Serenity.EntityDialog));
        Batch.LabelLostDialog = LabelLostDialog;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelLostGrid = /** @class */ (function (_super) {
            __extends(LabelLostGrid, _super);
            function LabelLostGrid(container) {
                return _super.call(this, container) || this;
            }
            LabelLostGrid.prototype.getColumnsKey = function () { return 'Batch.LabelLost'; };
            LabelLostGrid.prototype.getDialogType = function () { return Batch.LabelLostDialog; };
            LabelLostGrid.prototype.getIdProperty = function () { return Batch.LabelLostRow.idProperty; };
            LabelLostGrid.prototype.getLocalTextPrefix = function () { return Batch.LabelLostRow.localTextPrefix; };
            LabelLostGrid.prototype.getService = function () { return Batch.LabelLostService.baseUrl; };
            LabelLostGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], LabelLostGrid);
            return LabelLostGrid;
        }(Serenity.EntityGrid));
        Batch.LabelLostGrid = LabelLostGrid;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRunDataDialog = /** @class */ (function (_super) {
            __extends(BatchRunDataDialog, _super);
            function BatchRunDataDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Batch.BatchRunDataForm(_this.idPrefix);
                return _this;
            }
            BatchRunDataDialog.prototype.getFormKey = function () { return Batch.BatchRunDataForm.formKey; };
            BatchRunDataDialog.prototype.getIdProperty = function () { return Batch.BatchRunDataRow.idProperty; };
            BatchRunDataDialog.prototype.getLocalTextPrefix = function () { return Batch.BatchRunDataRow.localTextPrefix; };
            BatchRunDataDialog.prototype.getNameProperty = function () { return Batch.BatchRunDataRow.nameProperty; };
            BatchRunDataDialog.prototype.getService = function () { return Batch.BatchRunDataService.baseUrl; };
            BatchRunDataDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], BatchRunDataDialog);
            return BatchRunDataDialog;
        }(Serenity.EntityDialog));
        Batch.BatchRunDataDialog = BatchRunDataDialog;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRunDataGrid = /** @class */ (function (_super) {
            __extends(BatchRunDataGrid, _super);
            function BatchRunDataGrid(container) {
                return _super.call(this, container) || this;
            }
            BatchRunDataGrid.prototype.getColumnsKey = function () { return 'Batch.BatchRunData'; };
            BatchRunDataGrid.prototype.getDialogType = function () { return Batch.BatchRunDataDialog; };
            BatchRunDataGrid.prototype.getIdProperty = function () { return Batch.BatchRunDataRow.idProperty; };
            BatchRunDataGrid.prototype.getLocalTextPrefix = function () { return Batch.BatchRunDataRow.localTextPrefix; };
            BatchRunDataGrid.prototype.getService = function () { return Batch.BatchRunDataService.baseUrl; };
            BatchRunDataGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], BatchRunDataGrid);
            return BatchRunDataGrid;
        }(Serenity.EntityGrid));
        Batch.BatchRunDataGrid = BatchRunDataGrid;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRecipeModifyDialog = /** @class */ (function (_super) {
            __extends(BatchRecipeModifyDialog, _super);
            function BatchRecipeModifyDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Batch.BatchRecipeModifyForm(_this.idPrefix);
                return _this;
            }
            BatchRecipeModifyDialog.prototype.getFormKey = function () { return Batch.BatchRecipeModifyForm.formKey; };
            BatchRecipeModifyDialog.prototype.getIdProperty = function () { return Batch.BatchRecipeModifyRow.idProperty; };
            BatchRecipeModifyDialog.prototype.getLocalTextPrefix = function () { return Batch.BatchRecipeModifyRow.localTextPrefix; };
            BatchRecipeModifyDialog.prototype.getNameProperty = function () { return Batch.BatchRecipeModifyRow.nameProperty; };
            BatchRecipeModifyDialog.prototype.getService = function () { return Batch.BatchRecipeModifyService.baseUrl; };
            BatchRecipeModifyDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], BatchRecipeModifyDialog);
            return BatchRecipeModifyDialog;
        }(Serenity.EntityDialog));
        Batch.BatchRecipeModifyDialog = BatchRecipeModifyDialog;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRecipeModifyGrid = /** @class */ (function (_super) {
            __extends(BatchRecipeModifyGrid, _super);
            function BatchRecipeModifyGrid(container) {
                return _super.call(this, container) || this;
            }
            BatchRecipeModifyGrid.prototype.getColumnsKey = function () { return 'Batch.BatchRecipeModify'; };
            BatchRecipeModifyGrid.prototype.getDialogType = function () { return Batch.BatchRecipeModifyDialog; };
            BatchRecipeModifyGrid.prototype.getIdProperty = function () { return Batch.BatchRecipeModifyRow.idProperty; };
            BatchRecipeModifyGrid.prototype.getLocalTextPrefix = function () { return Batch.BatchRecipeModifyRow.localTextPrefix; };
            BatchRecipeModifyGrid.prototype.getService = function () { return Batch.BatchRecipeModifyService.baseUrl; };
            BatchRecipeModifyGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], BatchRecipeModifyGrid);
            return BatchRecipeModifyGrid;
        }(Serenity.EntityGrid));
        Batch.BatchRecipeModifyGrid = BatchRecipeModifyGrid;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchMachineWiseDialog = /** @class */ (function (_super) {
            __extends(BatchMachineWiseDialog, _super);
            function BatchMachineWiseDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Batch.BatchMachineWiseForm(_this.idPrefix);
                return _this;
            }
            BatchMachineWiseDialog.prototype.getFormKey = function () { return Batch.BatchMachineWiseForm.formKey; };
            BatchMachineWiseDialog.prototype.getIdProperty = function () { return Batch.BatchMachineWiseRow.idProperty; };
            BatchMachineWiseDialog.prototype.getLocalTextPrefix = function () { return Batch.BatchMachineWiseRow.localTextPrefix; };
            BatchMachineWiseDialog.prototype.getService = function () { return Batch.BatchMachineWiseService.baseUrl; };
            BatchMachineWiseDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], BatchMachineWiseDialog);
            return BatchMachineWiseDialog;
        }(Serenity.EntityDialog));
        Batch.BatchMachineWiseDialog = BatchMachineWiseDialog;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchMachineWiseGrid = /** @class */ (function (_super) {
            __extends(BatchMachineWiseGrid, _super);
            function BatchMachineWiseGrid(container) {
                return _super.call(this, container) || this;
            }
            BatchMachineWiseGrid.prototype.getColumnsKey = function () { return 'Batch.BatchMachineWise'; };
            BatchMachineWiseGrid.prototype.getDialogType = function () { return Batch.BatchMachineWiseDialog; };
            BatchMachineWiseGrid.prototype.getIdProperty = function () { return Batch.BatchMachineWiseRow.idProperty; };
            BatchMachineWiseGrid.prototype.getLocalTextPrefix = function () { return Batch.BatchMachineWiseRow.localTextPrefix; };
            BatchMachineWiseGrid.prototype.getService = function () { return Batch.BatchMachineWiseService.baseUrl; };
            BatchMachineWiseGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], BatchMachineWiseGrid);
            return BatchMachineWiseGrid;
        }(Serenity.EntityGrid));
        Batch.BatchMachineWiseGrid = BatchMachineWiseGrid;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogDialog = /** @class */ (function (_super) {
            __extends(BatchLogDialog, _super);
            function BatchLogDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Batch.BatchLogForm(_this.idPrefix);
                return _this;
            }
            BatchLogDialog.prototype.getFormKey = function () { return Batch.BatchLogForm.formKey; };
            BatchLogDialog.prototype.getIdProperty = function () { return Batch.BatchLogRow.idProperty; };
            BatchLogDialog.prototype.getLocalTextPrefix = function () { return Batch.BatchLogRow.localTextPrefix; };
            BatchLogDialog.prototype.getNameProperty = function () { return Batch.BatchLogRow.nameProperty; };
            BatchLogDialog.prototype.getService = function () { return Batch.BatchLogService.baseUrl; };
            BatchLogDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], BatchLogDialog);
            return BatchLogDialog;
        }(Serenity.EntityDialog));
        Batch.BatchLogDialog = BatchLogDialog;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogArchiveDialog = /** @class */ (function (_super) {
            __extends(BatchLogArchiveDialog, _super);
            function BatchLogArchiveDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Batch.BatchLogArchiveForm(_this.idPrefix);
                return _this;
            }
            BatchLogArchiveDialog.prototype.getFormKey = function () { return Batch.BatchLogArchiveForm.formKey; };
            BatchLogArchiveDialog.prototype.getIdProperty = function () { return Batch.BatchLogArchiveRow.idProperty; };
            BatchLogArchiveDialog.prototype.getLocalTextPrefix = function () { return Batch.BatchLogArchiveRow.localTextPrefix; };
            BatchLogArchiveDialog.prototype.getNameProperty = function () { return Batch.BatchLogArchiveRow.nameProperty; };
            BatchLogArchiveDialog.prototype.getService = function () { return Batch.BatchLogArchiveService.baseUrl; };
            BatchLogArchiveDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], BatchLogArchiveDialog);
            return BatchLogArchiveDialog;
        }(Serenity.EntityDialog));
        Batch.BatchLogArchiveDialog = BatchLogArchiveDialog;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogGrid = /** @class */ (function (_super) {
            __extends(BatchLogGrid, _super);
            function BatchLogGrid(container) {
                return _super.call(this, container) || this;
            }
            BatchLogGrid.prototype.getColumnsKey = function () { return 'Batch.BatchLog'; };
            BatchLogGrid.prototype.getDialogType = function () { return Batch.BatchLogDialog; };
            BatchLogGrid.prototype.getIdProperty = function () { return Batch.BatchLogRow.idProperty; };
            BatchLogGrid.prototype.getLocalTextPrefix = function () { return Batch.BatchLogRow.localTextPrefix; };
            BatchLogGrid.prototype.getService = function () { return Batch.BatchLogService.baseUrl; };
           
            BatchLogGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], BatchLogGrid);
            return BatchLogGrid;
        }(Serenity.EntityGrid));
        Batch.BatchLogGrid = BatchLogGrid;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchDialog = /** @class */ (function (_super) {
            __extends(BatchDialog, _super);
            function BatchDialog() {
                debugger;
                var _this = _super.call(this) || this;
                _this.form = new Batch.BatchForm(_this.idPrefix);
                console.log(_this.form);
                _this.toolbar.findButton("edit-permissions-button").remove();
                _this.toolbar.findButton("undo-delete-button").remove();
                _this.toolbar.findButton("localization-button").remove();
                _this.toolbar.findButton("clone-button").remove();
                _this.toolbar.findButton("delete-button").remove();
                _this.form.MachineLineId.value = 1;
                _this.form.StatusId.value = 1;
              
                _this.form.BatchVersion.value = isReloadBatch == true ? "Reload Batch" : "New Batch";
                //_this.form.BatchStatus.value = "Batch Created";
               // _this.form.PackId.value = 14;
               // var lookup = Q.getLookup<PackRow>("PackId");
                //this.form.CS2LookupField.filterField = "Item";
                //this.form.CS2LookupField.filterValue = this.form.yourItemField.value;
                return _this;
                //this.form.CreatedBy.value = user.;
                //this.form.CreatedDate = DefaultValue("now");
                //this.form.UpdatedBy.value = Authorization.userDefinition.UserId;
                //this.form.UpdatedDate.value = Date.now().toString();
            }
            BatchDialog.prototype.getFormKey = function () { return Batch.BatchForm.formKey; };
            BatchDialog.prototype.getIdProperty = function () { return Batch.BatchRow.idProperty; };
            BatchDialog.prototype.getLocalTextPrefix = function () { return Batch.BatchRow.localTextPrefix; };
            BatchDialog.prototype.getNameProperty = function () { return Batch.BatchRow.nameProperty; };
            BatchDialog.prototype.getService = function () { return Batch.BatchService.baseUrl; };
            BatchDialog.prototype.onSaveSuccess = function (response) {
                packList = null;
                repackBatchList = null;
                 if (this.isNew()) {
                     Q.notifySuccess("Batch Created Successfully");
                     ShowLoader(); 
                     GetBatchDetails();
                     fillview(true);
                    // location.reload();

                }
                else {
                     Q.notifySuccess("Batch Updated Successfully");
                     $("#lblTotalBottles").text($("input[name='BatchSize']").val());
                     $("#lblPack").text($("input[name='BatchStatus']").val());
                    // GetBatchDetails();
                }
             
                //    // check that this is an insert
                //    //if (this.isNew()) {
                //    //    Q.notifySuccess("Just inserted a category with ID: " + response.EntityId);
                //    //    // you could also open a new dialog
                //    //    // new Northwind.CategoryDialog().loadByIdAndOpenDialog(response.EntityId);
                //    //    // but let's better load inserted record using Retrieve service
                //    //    Northwind.CategoryService.Retrieve(<any>{
                //    //        EntityId: response.EntityId
                //    //    }, resp => {
                //    //        Q.notifyInfo("Looks like the category you added has name: " + resp.Entity.CategoryName);
                //    //    });
                //    //}
                //    Q.
                this.dialogClose();

                //if (this.isNew()) {

                //    Q.notifySuccess("Recipe Created Successfully");
                  

                //}
                //else {
                //    Q.notifySuccess("Recipe Updated Successfully");
                //}

            };
            BatchDialog.prototype.onDialogClose = function () { Serenity.SubDialogHelper.triggerDataChange(this); _super.prototype.onDialogClose.call(this); };
           

            BatchDialog.prototype.onDialogOpen = function () {

                //var date = new Date();
                //date.setDate(date.getDate());

                //$('.hasDatepicker').datepicker({
                //    startDate: date
                //});
                //$(function () {
                //    $('.hasDatepicker').datetimepicker({
                //        minDate: new Date()
                //    });
                //});
                var keypara = [
                    '7 8 9',
                    '4 5 6',
                    '1 2 3',
                    '{bksp} - 0 ',
                    '{a} {c}'
                ];

                $(':text').blur();
                $(".editor").click(function () {
                    //$('.select2-results').on('select2:select', function (e) {
                    //    alert("ff");
                    //});
                    //setTimeout(function () {
                    //   $("#s2id_autogen1_search").val("tes");
                    //  $("#s2id_autogen1_search").trigger("keyup");
                    // console.log("asdas");
                    // }, 60000)

                    //var availableTags = [
                    //    "napk",
                    //    "TestPack",

                    //];
                    //// s2id_autogen1_search
                    //$(".select2-search input[type='text']").change(function () {
                    //    debugger;
                    //    console.log("Handler for .keypress() called.");
                    //});
                    //debugger;
                    //$(".select2-search").click(function () {
                    //    alert("dsd");

                    //});
                    function select2_search($el, term) {
                        console.log($el);
                        debugger;
                        $el.select2('open');
                        debugger;
                        // Get the search box within the dropdown or the selection
                        // Dropdown = single, Selection = multiple
                        var $search = $el.data('select2').dropdown.$search || $el.data('select2').selection.$search;
                        // This is undocumented and may change in the future

                        $search.val(term);
                        $search.trigger('input');
                        setTimeout(function () { $('.select2-results__option').trigger("mouseup"); }, 500);
                    }
                   
                    //$("#s2id_autogen1_search")
                    //    // $(".select2-search input[type='text']")
                    //    .keyboard({
                    //        usePreview: false,
                    //        layout: 'custom',
                    //        customLayout: {
                    //            'normal': [
                    //                '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                    //                '{tab} q w e r t y u i o p [ ] \\',
                    //                'a s d f g h j k l ; \' {accept}',
                    //                '{shift} z x c v b n m , . / {shift}',
                    //                ' {space} {left} {right}'
                    //            ],
                    //            'shift': [
                    //                '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                    //                '{tab} Q W E R T Y U I O P { } |',
                    //                'A S D F G H J K L : " {accept}',
                    //                '{shift} Z X C V B N M < > ? {shift}',
                    //                ' {space} {left} {right}'
                    //            ]
                    //        },
                    //        accepted: function (event, keyboard, el) {
                    //            debugger;
                    //          //  var $select = $($('select')[0]);
                    //          //  console.log($select);
                    //            //  console.log($('.select2-results'), $select);
                    //         //   select2_search($select, 'pack1');


                    //            //$('.select2-results').on('select2:select', function (e) {
                    //            //    alert("ff");
                    //            //});

                    //            // $('.select2-results').val('pack1')
                    //            // console.log($('.select2-results').val());
                    //            //  $("#s2id_autogen1_search").val('t');

                    //            //var packCode = $("#s2id_autogen1_search");

                    //            //packCode.val(keyboard.$preview.val());
                    //            //packCode.focus();
                    //            //packCode.trigger(jQuery.Event('keyup', { keycode: 13 }));
                    //            //;
                    //            //}, change: function (event, keyboard, el) {
                    //            //    $('.select2-results').on('select2:select', function (e) {
                    //            //        alert("ff");
                    //            //    });
                    //            //    console.log('5');
                    //            //   // $('.select2-results').val('pack1')
                    //            //  //  console.log('> This change callback is called on every user interaction');
                    //            //   // console.log('  A `keyboardChange` event was also triggered on the original input');
                    //            //  //  console.log('  The value is now ' + keyboard.$preview.val());
                    //            //   // $("#s2id_autogen1_search").val('t');
                    //            //  //  $("#s2id_autogen1_search").trigger('change');

                    //            //  //  $(".select2-search input[type='text']").val(keyboard.$preview.val()).trigger('keyup')

                    //        }
                    //    });                   
                   
                 

                    $("input[name='NumberOfBottles'],input[name='BatchSize']")
                        //$("input.editor[type=text]")
                        .keyboard({
                            usePreview: false,
                            layout: 'custom',
                            customLayout: {
                                'normal': [
                                    '7 8 9',
                                    '4 5 6',
                                    '1 2 3',
                                    '{bksp} 0',
                                    '{a} {c}'
                                ]

                            },
                            acceptValid: true,
                            validate: function (keyboard, value, isClosing) {
                               // console.log($(keyboard)[0].el.min);
                             
                                var min = $(keyboard)[0].el.min;
                                var max = $(keyboard)[0].el.max;
                                if (parseFloat(value) > parseFloat(max)) {
                                    //Q.alert("Value Cannot be greater than " + max);
                                    return false;
                                }
                                if (parseFloat(value) < parseFloat(min)) {
                                    //Q.alert("Value Cannot be less than " + min);
                                    return false;
                                }

                                return true;
                            }
                        })
                        .addTyping({
                            showTyping: true,
                            delay: 250
                        })
                        .addCaret({
                            caretClass: '',
                            // *** for future use ***
                            // data-attribute containing the character(s) next to the caret
                            charAttr: 'data-character',
                            // # character(s) next to the caret (can be negative for RTL)
                            // default is 1 which shows the character to the right of the caret
                            // setting this to -1 shows the character to the left
                            charIndex: -1,
                            // tweak caret position & height
                            offsetX: 0,
                            offsetY: 0,
                            adjustHt: 0
                        });

                    // Typing Extension
                    $('.icon').click(function () {
                       
                        var kb = $(this).prev().getkeyboard();
                        // typeIn( text, delay, callback );
                        kb.reveal().typeIn(simulateTyping, 500, function () {
                            // do something after text is added
                            // kb.accept();
                        });
                    });
                });

            

                $("input[name='BatchName']")
                       .keyboard({
                            usePreview: false,
                            layout: 'custom',
                            customLayout: {
                                'normal': [
                                    '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                                    '{tab} q w e r t y u i o p [ ] \\',
                                    'a s d f g h j k l ; \' {accept}',
                                    '{shift} z x c v b n m , . / {shift}',
                                    ' {space} {left} {right} {cancel}'
                                ],
                                'shift': [
                                    '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                                    '{tab} Q W E R T Y U I O P { } |',
                                    'A S D F G H J K L : " {accept}',
                                    '{shift} Z X C V B N M < > ? {shift}',
                                    ' {space} {left} {right} {cancel}'
                                ]
                           }, 
                         
                    })

                    .autocomplete({
                        source: repackBatchList, minLength: 0
                    }).bind('focus', function () {
                        if (!$(this).val().trim())
                            $(this).keydown();
                    })
                    // position options added after v1.23.4
                    .addAutocomplete({
                        //position: {
                        //    of: null,        // when null, element will default to kb.$keyboard
                        //    my: 'right top', // 'center top', (position under keyboard)
                        //    at: 'left top',  // 'center bottom',
                        //    collision: 'flip'
                        //}
                        position: {
                            of: null,        // when null, element will default to kb.$keyboard
                            my: 'right top', // 'center top', (position under keyboard)
                            at: 'left top',  // 'center bottom',
                            collision: 'flip'
                        }
                    })
                    
             
              
                $("input[name='BatchStatus']")
                    .keyboard({
                        usePreview: false,
                        layout: 'custom',
                        customLayout: {
                            'normal': [
                                '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                                '{tab} q w e r t y u i o p [ ] \\',
                                'a s d f g h j k l ; \' {accept}',
                                '{shift} z x c v b n m , . / {shift}',
                                ' {space} {left} {right} {cancel}'
                            ],
                            'shift': [
                                '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                                '{tab} Q W E R T Y U I O P { } |',
                                'A S D F G H J K L : " {accept}',
                                '{shift} Z X C V B N M < > ? {shift}',
                                ' {space} {left} {right} {cancel}'
                            ]
                        },
                       

                    })
                   // .keyboard({ layout: 'qwerty' })
                    //.autocomplete({
                      
                    //    source: packList
                    //})

               .autocomplete({
                   source: packList, minLength: 0
                }).bind('focus', function () {
                    if (!$(this).val().trim())
                        $(this).keydown();
                })
                    // position options added after v1.23.4
                    .addAutocomplete({
                        //position: {
                        //    of: null,        // when null, element will default to kb.$keyboard
                        //    my: 'right top', // 'center top', (position under keyboard)
                        //    at: 'left top',  // 'center bottom',
                        //    collision: 'flip'
                        //}
                        position: {
                            of: null,        // when null, element will default to kb.$keyboard
                            my: 'left top', // 'center top', (position under keyboard)
                            at: 'right top',  // 'center bottom',
                            collision: 'flip'
                        }
                    })
                    .addTyping();
             

                    // Typing Extension
                   $('.icon').click(function () {
                        var kb = $(this).prev().getkeyboard();
                         typeIn( text, delay, callback );
                        kb.reveal().typeIn(simulateTyping, 500, function () {
                            // do something after text is added
                             kb.accept();
                        });
                    }); 
            };

            BatchDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            BatchDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], BatchDialog);
            return BatchDialog;
        }(Serenity.EntityDialog));
        Batch.BatchDialog = BatchDialog;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchGrid = /** @class */ (function (_super) {
            __extends(BatchGrid, _super);
            function BatchGrid(container) {
                return _super.call(this, container) || this;
            }
            BatchGrid.prototype.getColumnsKey = function () { return 'Batch.Batch'; };
            BatchGrid.prototype.getDialogType = function () { return Batch.BatchDialog; };
            BatchGrid.prototype.getIdProperty = function () { return Batch.BatchRow.idProperty; };
            BatchGrid.prototype.getLocalTextPrefix = function () { return Batch.BatchRow.localTextPrefix; };
            BatchGrid.prototype.getService = function () { return Batch.BatchService.baseUrl; };
            BatchGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "add-button"; }), 1);

                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };

            BatchGrid.prototype.getColumns = function () {
                var _this = this;
                //var buttons = _super.prototype.getButtons.call(this);
                var columns = _super.prototype.getColumns.call(this);
                
                var applycolumn = {
                    name: 'Download Report',
                    field: 'IsApplied',
                    width: 300,
                    sortable: false,

                    format: function (ctx) {
                        return Q.outerHtml($('<button/>')
                            .addClass('target-text')
                            .attr('height', 50)
                            .attr('onclick', 'DownloadBatchReport(' + ctx.item.BatchId + ');')
                            .text('Download Report'));
                    }
                }
                var applycolumn1 = {
                    name: 'Repack',
                    field: 'IsApplied1',
                    width: 300,
                    sortable: false,

                    format: function (ctx) {
                        console.log(ctx);
                        if ((ctx.item.ParentId == undefined || ctx.item.ParentId == null) && (ctx.item.BatchStatus == "Batch Ended") &&( (ctx.item.RepackStatus == "Repack Done") || (ctx.item.RepackStatus == "Taken for Repack") || (ctx.item.RepackStatus == "Not Repacked"))) {
                            //var repackId = ctx.item.RepackStatus == ('Not Repacked' || 'Repack Done') ? 1 : 2;
                            var repackId = 0;
                            if ((ctx.item.RepackStatus == 'Not Repacked') || (ctx.item.RepackStatus == 'Repack Done')) {
                                repackId = 1;
                            }
                            else {
                                repackId = 2;
                            }
                            return Q.outerHtml($('<button/>')
                                .addClass('target-text')
                                .attr('height', 50)
                                // .attr('onclick', 'Repack(' + ctx.item.BatchId + ',"nnn");')

                                .attr('onclick', 'Repack(' + ctx.item.BatchId + ',' + repackId + ');')
                                .text(ctx.item.RepackStatus == 'Taken for Repack' ? 'Cancel Repack' : 'Repack'));
                        }
                    }
                }
               
                columns.splice(1, 0, applycolumn);
               columns.splice(11, 0, applycolumn1);
                return columns;
            };


            //BatchGrid.prototype.getColumns = function () {
            //    var columns = [];
            //    columns.push({ field: 'RepackStatus', width: 300, sortable: false });
            //    columns.push({
            //        field: 'SourceText',
            //        width: 300,
            //        sortable: false,
            //        format: function (ctx) {
            //            return Q.outerHtml($('<a/>')
            //                .addClass('source-text')
            //                .text(ctx.value || ''));
            //        }
            //    });
                //columns.push({
                //    field: 'CustomText',
                //    width: 300,
                //    sortable: false,
                //    format: function (ctx) {
                //        return Q.outerHtml($('<input/>')
                //            .addClass('custom-text')
                //            .attr('value', ctx.value)
                //            .attr('type', 'text')
                //            .attr('data-key', ctx.item.Key));
                //    }
                //});
                //columns.push({
                //    field: 'TargetText',
                //    width: 300,
                //    sortable: false,
                //    format: function (ctx) {
                //        return Q.outerHtml($('<a/>')
                //            .addClass('target-text')
                //            .text(ctx.value || ''));
                //    }
                //});
               // return columns;
           // };
          
            BatchGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], BatchGrid);
            return BatchGrid;
        }(Serenity.EntityGrid));
        Batch.BatchGrid = BatchGrid;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ViewsAccessDialog = /** @class */ (function (_super) {
            __extends(ViewsAccessDialog, _super);
            function ViewsAccessDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Administration.ViewsAccessForm(_this.idPrefix);
                return _this;
            }
            ViewsAccessDialog.prototype.getFormKey = function () { return Administration.ViewsAccessForm.formKey; };
            ViewsAccessDialog.prototype.getIdProperty = function () { return Administration.ViewsAccessRow.idProperty; };
            ViewsAccessDialog.prototype.getLocalTextPrefix = function () { return Administration.ViewsAccessRow.localTextPrefix; };
            ViewsAccessDialog.prototype.getService = function () { return Administration.ViewsAccessService.baseUrl; };
            ViewsAccessDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], ViewsAccessDialog);
            return ViewsAccessDialog;
        }(Serenity.EntityDialog));
        Administration.ViewsAccessDialog = ViewsAccessDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ViewsAccessGrid = /** @class */ (function (_super) {
            __extends(ViewsAccessGrid, _super);
            function ViewsAccessGrid(container) {
                return _super.call(this, container) || this;
            }
            ViewsAccessGrid.prototype.getColumnsKey = function () { return 'Administration.ViewsAccess'; };
            ViewsAccessGrid.prototype.getDialogType = function () { return Administration.ViewsAccessDialog; };
            ViewsAccessGrid.prototype.getIdProperty = function () { return Administration.ViewsAccessRow.idProperty; };
            ViewsAccessGrid.prototype.getLocalTextPrefix = function () { return Administration.ViewsAccessRow.localTextPrefix; };
            ViewsAccessGrid.prototype.getService = function () { return Administration.ViewsAccessService.baseUrl; };
            ViewsAccessGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ViewsAccessGrid);
            return ViewsAccessGrid;
        }(Serenity.EntityGrid));
        Administration.ViewsAccessGrid = ViewsAccessGrid;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ViewFieldAccessDialog = /** @class */ (function (_super) {
            __extends(ViewFieldAccessDialog, _super);
            function ViewFieldAccessDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Administration.ViewFieldAccessForm(_this.idPrefix);
                return _this;
            }
            ViewFieldAccessDialog.prototype.getFormKey = function () { return Administration.ViewFieldAccessForm.formKey; };
            ViewFieldAccessDialog.prototype.getIdProperty = function () { return Administration.ViewFieldAccessRow.idProperty; };
            ViewFieldAccessDialog.prototype.getLocalTextPrefix = function () { return Administration.ViewFieldAccessRow.localTextPrefix; };
            ViewFieldAccessDialog.prototype.getService = function () { return Administration.ViewFieldAccessService.baseUrl; };
            ViewFieldAccessDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], ViewFieldAccessDialog);
            return ViewFieldAccessDialog;
        }(Serenity.EntityDialog));
        Administration.ViewFieldAccessDialog = ViewFieldAccessDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ViewFieldAccessGrid = /** @class */ (function (_super) {
            __extends(ViewFieldAccessGrid, _super);
            function ViewFieldAccessGrid(container) {
                return _super.call(this, container) || this;
            }
            ViewFieldAccessGrid.prototype.getColumnsKey = function () { return 'Administration.ViewFieldAccess'; };
            ViewFieldAccessGrid.prototype.getDialogType = function () { return Administration.ViewFieldAccessDialog; };
            ViewFieldAccessGrid.prototype.getIdProperty = function () { return Administration.ViewFieldAccessRow.idProperty; };
            ViewFieldAccessGrid.prototype.getLocalTextPrefix = function () { return Administration.ViewFieldAccessRow.localTextPrefix; };
            ViewFieldAccessGrid.prototype.getService = function () { return Administration.ViewFieldAccessService.baseUrl; };
            ViewFieldAccessGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ViewFieldAccessGrid);
            return ViewFieldAccessGrid;
        }(Serenity.EntityGrid));
        Administration.ViewFieldAccessGrid = ViewFieldAccessGrid;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleCheckEditor = /** @class */ (function (_super) {
            __extends(RoleCheckEditor, _super);
            function RoleCheckEditor(div) {
                return _super.call(this, div) || this;
            }
            RoleCheckEditor.prototype.createToolbarExtensions = function () {
                var _this = this;
                _super.prototype.createToolbarExtensions.call(this);
                Serenity.GridUtils.addQuickSearchInputCustom(this.toolbar.element, function (field, text) {
                    _this.searchText = Select2.util.stripDiacritics(text || '').toUpperCase();
                    _this.view.setItems(_this.view.getItems(), true);
                });
            };
            RoleCheckEditor.prototype.getButtons = function () {
                return [];
            };
            RoleCheckEditor.prototype.getTreeItems = function () {
                return Administration.RoleRow.getLookup().items.map(function (role) {
                    return ({
                        id: role.RoleId.toString(),
                        text: role.RoleName
                    });
                });
            };
            RoleCheckEditor.prototype.onViewFilter = function (item) {
                return _super.prototype.onViewFilter.call(this, item) &&
                    (Q.isEmptyOrNull(this.searchText) ||
                        Select2.util.stripDiacritics(item.text || '')
                            .toUpperCase().indexOf(this.searchText) >= 0);
            };
            RoleCheckEditor = __decorate([
                Serenity.Decorators.registerEditor()
            ], RoleCheckEditor);
            return RoleCheckEditor;
        }(Serenity.CheckTreeEditor));
        Administration.RoleCheckEditor = RoleCheckEditor;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserRoleDialog = /** @class */ (function (_super) {
            __extends(UserRoleDialog, _super);
            function UserRoleDialog(opt) {
                var _this = _super.call(this, opt) || this;
                debugger;
                _this.permissions = new Administration.RoleCheckEditor(_this.byId('Roles'));
                Administration.UserRoleService.List({
                    UserID: _this.options.userID
                }, function (response) {
                    _this.permissions.value = response.Entities.map(function (x) { return x.toString(); });
                });
                return _this;
            }       
            UserRoleDialog.prototype.getDialogOptions = function () {
                var _this = this;
                var opt = _super.prototype.getDialogOptions.call(this);
                opt.buttons = [{
                    text: Q.text('Dialogs.OkButton'),
                    click: function () {
                        Q.serviceRequest('Administration/UserRole/Update', {
                            UserID: _this.options.userID,
                            Roles: _this.permissions.value.map(function (x) { return parseInt(x, 10); })
                        }, function (response) {
                            _this.dialogClose();
                            Q.notifySuccess(Q.text('Site.UserRoleDialog.SaveSuccess'));
                        });
                    }
                }, {
                    text: Q.text('Dialogs.CancelButton'),
                    click: function () { return _this.dialogClose(); }
                }];
                opt.title = Q.format(Q.text('Site.UserRoleDialog.DialogTitle'), this.options.username);
                return opt;
            };
            UserRoleDialog.prototype.getTemplate = function () {
                return "<div id='~_Roles'></div>";
            };

            UserRoleDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], UserRoleDialog);
            return UserRoleDialog;
        }(Serenity.TemplatedDialog));
        Administration.UserRoleDialog = UserRoleDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var PermissionCheckEditor = /** @class */ (function (_super) {
            __extends(PermissionCheckEditor, _super);
            function PermissionCheckEditor(container, opt) {
                var _this = _super.call(this, container, opt) || this;
                _this._rolePermissions = {};
                _this._implicitPermissions = {};
                var titleByKey = {};
                var permissionKeys = _this.getSortedGroupAndPermissionKeys(titleByKey);
                var items = permissionKeys.map(function (key) {
                    return ({
                        Key: key,
                        ParentKey: _this.getParentKey(key),
                        Title: titleByKey[key],
                        GrantRevoke: null,
                        IsGroup: key.charAt(key.length - 1) === ':'
                    });
                });
                _this.byParentKey = Q.toGrouping(items, function (x) { return x.ParentKey; });
                _this.setItems(items);
                return _this;
            }
            PermissionCheckEditor.prototype.getIdProperty = function () { return "Key"; };
            PermissionCheckEditor.prototype.getItemGrantRevokeClass = function (item, grant) {
                if (!item.IsGroup) {
                    return ((item.GrantRevoke === grant) ? ' checked' : '');
                }
                var desc = this.getDescendants(item, true);
                var granted = desc.filter(function (x) { return x.GrantRevoke === grant; });
                if (!granted.length) {
                    return '';
                }
                if (desc.length === granted.length) {
                    return 'checked';
                }
                return 'checked partial';
            };
            PermissionCheckEditor.prototype.roleOrImplicit = function (key) {
                if (this._rolePermissions[key])
                    return true;
                for (var _i = 0, _a = Object.keys(this._rolePermissions); _i < _a.length; _i++) {
                    var k = _a[_i];
                    var d = this._implicitPermissions[k];
                    if (d && d[key])
                        return true;
                }
                for (var _b = 0, _c = Object.keys(this._implicitPermissions); _b < _c.length; _b++) {
                    var i = _c[_b];
                    var item = this.view.getItemById(i);
                    if (item && item.GrantRevoke == true) {
                        var d = this._implicitPermissions[i];
                        if (d && d[key])
                            return true;
                    }
                }
            };
            PermissionCheckEditor.prototype.getItemEffectiveClass = function (item) {
                var _this = this;
                if (item.IsGroup) {
                    var desc = this.getDescendants(item, true);
                    var grantCount = Q.count(desc, function (x) {
                        return x.GrantRevoke === true ||
                            (x.GrantRevoke == null && _this.roleOrImplicit(x.Key));
                    });
                    if (grantCount === desc.length || desc.length === 0) {
                        return 'allow';
                    }
                    if (grantCount === 0) {
                        return 'deny';
                    }
                    return 'partial';
                }
                var granted = item.GrantRevoke === true ||
                    (item.GrantRevoke == null && this.roleOrImplicit(item.Key));
                return (granted ? ' allow' : ' deny');
            };
            PermissionCheckEditor.prototype.getColumns = function () {
                var _this = this;
                var columns = [{
                    name: Q.text('Site.UserPermissionDialog.Permission'),
                    field: 'Title',
                    format: Serenity.SlickFormatting.treeToggle(function () { return _this.view; }, function (x) { return x.Key; }, function (ctx) {
                        var item = ctx.item;
                        var klass = _this.getItemEffectiveClass(item);
                        return '<span class="effective-permission ' + klass + '">' + Q.htmlEncode(ctx.value) + '</span>';
                    }),
                    width: 495,
                    sortable: false
                }, {
                    name: Q.text('Site.UserPermissionDialog.Grant'), field: 'Grant',
                    format: function (ctx) {
                        var item1 = ctx.item;
                        var klass1 = _this.getItemGrantRevokeClass(item1, true);
                        return "<span class='check-box grant no-float " + klass1 + "'></span>";
                    },
                    width: 65,
                    sortable: false,
                    headerCssClass: 'align-center',
                    cssClass: 'align-center'
                }];
                if (this.options.showRevoke) {
                    columns.push({
                        name: Q.text('Site.UserPermissionDialog.Revoke'), field: 'Revoke',
                        format: function (ctx) {
                            var item2 = ctx.item;
                            var klass2 = _this.getItemGrantRevokeClass(item2, false);
                            return '<span class="check-box revoke no-float ' + klass2 + '"></span>';
                        },
                        width: 65,
                        sortable: false,
                        headerCssClass: 'align-center',
                        cssClass: 'align-center'
                    });
                }
                return columns;
            };
            PermissionCheckEditor.prototype.setItems = function (items) {
                Serenity.SlickTreeHelper.setIndents(items, function (x) { return x.Key; }, function (x) { return x.ParentKey; }, false);
                this.view.setItems(items, true);
            };
            PermissionCheckEditor.prototype.onViewSubmit = function () {
                return false;
            };
            PermissionCheckEditor.prototype.onViewFilter = function (item) {
                var _this = this;
                if (!_super.prototype.onViewFilter.call(this, item)) {
                    return false;
                }
                if (!Serenity.SlickTreeHelper.filterById(item, this.view, function (x) { return x.ParentKey; }))
                    return false;
                if (this.searchText) {
                    return this.matchContains(item) || item.IsGroup && Q.any(this.getDescendants(item, false), function (x) { return _this.matchContains(x); });
                }
                return true;
            };
            PermissionCheckEditor.prototype.matchContains = function (item) {
                return Select2.util.stripDiacritics(item.Title || '').toLowerCase().indexOf(this.searchText) >= 0;
            };
            PermissionCheckEditor.prototype.getDescendants = function (item, excludeGroups) {
                var result = [];
                var stack = [item];
                while (stack.length > 0) {
                    var i = stack.pop();
                    var children = this.byParentKey[i.Key];
                    if (!children)
                        continue;
                    for (var _i = 0, children_1 = children; _i < children_1.length; _i++) {
                        var child = children_1[_i];
                        if (!excludeGroups || !child.IsGroup) {
                            result.push(child);
                        }
                        stack.push(child);
                    }
                }
                return result;
            };
            PermissionCheckEditor.prototype.onClick = function (e, row, cell) {
                _super.prototype.onClick.call(this, e, row, cell);
                if (!e.isDefaultPrevented()) {
                    Serenity.SlickTreeHelper.toggleClick(e, row, cell, this.view, function (x) { return x.Key; });
                }
                if (e.isDefaultPrevented()) {
                    return;
                }
                var target = $(e.target);
                var grant = target.hasClass('grant');
                if (grant || target.hasClass('revoke')) {
                    e.preventDefault();
                    var item = this.itemAt(row);
                    var checkedOrPartial = target.hasClass('checked') || target.hasClass('partial');
                    if (checkedOrPartial) {
                        grant = null;
                    }
                    else {
                        grant = grant !== checkedOrPartial;
                    }
                    if (item.IsGroup) {
                        for (var _i = 0, _a = this.getDescendants(item, true); _i < _a.length; _i++) {
                            var d = _a[_i];
                            d.GrantRevoke = grant;
                        }
                    }
                    else
                        item.GrantRevoke = grant;
                    this.slickGrid.invalidate();
                }
            };
            PermissionCheckEditor.prototype.getParentKey = function (key) {
                if (key.charAt(key.length - 1) === ':') {
                    key = key.substr(0, key.length - 1);
                }
                var idx = key.lastIndexOf(':');
                if (idx >= 0) {
                    return key.substr(0, idx + 1);
                }
                return null;
            };
            PermissionCheckEditor.prototype.getButtons = function () {
                return [];
            };
            PermissionCheckEditor.prototype.createToolbarExtensions = function () {
                var _this = this;
                _super.prototype.createToolbarExtensions.call(this);
                Serenity.GridUtils.addQuickSearchInputCustom(this.toolbar.element, function (field, text) {
                    _this.searchText = Select2.util.stripDiacritics(Q.trimToNull(text) || '').toLowerCase();
                    _this.view.setItems(_this.view.getItems(), true);
                });
            };
            PermissionCheckEditor.prototype.getSortedGroupAndPermissionKeys = function (titleByKey) {
                var keys = Q.getRemoteData('Administration.PermissionKeys').Entities;
                var titleWithGroup = {};
                for (var _i = 0, keys_1 = keys; _i < keys_1.length; _i++) {
                    var k = keys_1[_i];
                    var s = k;
                    if (!s) {
                        continue;
                    }
                    if (s.charAt(s.length - 1) == ':') {
                        s = s.substr(0, s.length - 1);
                        if (s.length === 0) {
                            continue;
                        }
                    }
                    if (titleByKey[s]) {
                        continue;
                    }
                    titleByKey[s] = Q.coalesce(Q.tryGetText('Permission.' + s), s);
                    var parts = s.split(':');
                    var group = '';
                    var groupTitle = '';
                    for (var i = 0; i < parts.length - 1; i++) {
                        group = group + parts[i] + ':';
                        var txt = Q.tryGetText('Permission.' + group);
                        if (txt == null) {
                            txt = parts[i];
                        }
                        titleByKey[group] = txt;
                        groupTitle = groupTitle + titleByKey[group] + ':';
                        titleWithGroup[group] = groupTitle;
                    }
                    titleWithGroup[s] = groupTitle + titleByKey[s];
                }
                keys = Object.keys(titleByKey);
                keys = keys.sort(function (x, y) { return Q.turkishLocaleCompare(titleWithGroup[x], titleWithGroup[y]); });
                return keys;
            };
            Object.defineProperty(PermissionCheckEditor.prototype, "value", {
                get: function () {
                    var result = [];
                    for (var _i = 0, _a = this.view.getItems(); _i < _a.length; _i++) {
                        var item = _a[_i];
                        if (item.GrantRevoke != null && item.Key.charAt(item.Key.length - 1) != ':') {
                            result.push({ PermissionKey: item.Key, Granted: item.GrantRevoke });
                        }
                    }
                    return result;
                },
                set: function (value) {
                    for (var _i = 0, _a = this.view.getItems(); _i < _a.length; _i++) {
                        var item = _a[_i];
                        item.GrantRevoke = null;
                    }
                    if (value != null) {
                        for (var _b = 0, value_1 = value; _b < value_1.length; _b++) {
                            var row = value_1[_b];
                            var r = this.view.getItemById(row.PermissionKey);
                            if (r) {
                                r.GrantRevoke = Q.coalesce(row.Granted, true);
                            }
                        }
                    }
                    this.setItems(this.getItems());
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PermissionCheckEditor.prototype, "rolePermissions", {
                get: function () {
                    return Object.keys(this._rolePermissions);
                },
                set: function (value) {
                    this._rolePermissions = {};
                    if (value) {
                        for (var _i = 0, value_2 = value; _i < value_2.length; _i++) {
                            var k = value_2[_i];
                            this._rolePermissions[k] = true;
                        }
                    }
                    this.setItems(this.getItems());
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PermissionCheckEditor.prototype, "implicitPermissions", {
                set: function (value) {
                    this._implicitPermissions = {};
                    if (value) {
                        for (var _i = 0, _a = Object.keys(value); _i < _a.length; _i++) {
                            var k = _a[_i];
                            this._implicitPermissions[k] = this._implicitPermissions[k] || {};
                            var l = value[k];
                            if (l) {
                                for (var _b = 0, l_1 = l; _b < l_1.length; _b++) {
                                    var s = l_1[_b];
                                    this._implicitPermissions[k][s] = true;
                                }
                            }
                        }
                    }
                },
                enumerable: true,
                configurable: true
            });
            PermissionCheckEditor = __decorate([
                Serenity.Decorators.registerEditor([Serenity.IGetEditValue, Serenity.ISetEditValue])
            ], PermissionCheckEditor);
            return PermissionCheckEditor;
        }(Serenity.DataGrid));
        Administration.PermissionCheckEditor = PermissionCheckEditor;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserPermissionDialog = /** @class */ (function (_super) {
            __extends(UserPermissionDialog, _super);
            function UserPermissionDialog(opt) {
                var _this = _super.call(this, opt) || this;
                _this.permissions = new Administration.PermissionCheckEditor(_this.byId('Permissions'), {
                    showRevoke: true
                });
                Administration.UserPermissionService.List({
                    UserID: _this.options.userID,
                    Module: null,
                    Submodule: null
                }, function (response) {
                    _this.permissions.value = response.Entities;
                });
                Administration.UserPermissionService.ListRolePermissions({
                    UserID: _this.options.userID,
                    Module: null,
                    Submodule: null,
                }, function (response) {
                    _this.permissions.rolePermissions = response.Entities;
                });
                _this.permissions.implicitPermissions = Q.getRemoteData('Administration.ImplicitPermissions');
                return _this;
            }
            UserPermissionDialog.prototype.getDialogOptions = function () {
                var _this = this;
                var opt = _super.prototype.getDialogOptions.call(this);
                opt.buttons = [
                    {
                        text: Q.text('Dialogs.OkButton'),
                        click: function (e) {
                            Administration.UserPermissionService.Update({
                                UserID: _this.options.userID,
                                Permissions: _this.permissions.value,
                                Module: null,
                                Submodule: null
                            }, function (response) {
                                _this.dialogClose();
                                window.setTimeout(function () { return Q.notifySuccess(Q.text('Site.UserPermissionDialog.SaveSuccess')); }, 0);
                            });
                        }
                    }, {
                        text: Q.text('Dialogs.CancelButton'),
                        click: function () { return _this.dialogClose(); }
                    }
                ];
                opt.title = Q.format(Q.text('Site.UserPermissionDialog.DialogTitle'), this.options.username);
                return opt;
            };
            UserPermissionDialog.prototype.getTemplate = function () {
                return '<div id="~_Permissions"></div>';
            };
            UserPermissionDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], UserPermissionDialog);

            UserPermissionDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
               
                this.toolbar.findButton("delete-button").remove();
            };

            return UserPermissionDialog;
        }(Serenity.TemplatedDialog));
        Administration.UserPermissionDialog = UserPermissionDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserDialog = /** @class */ (function (_super) {
            __extends(UserDialog, _super);
            function UserDialog() {
                var _this = _super.call(this) || this;
                _this.form = new Administration.UserForm(_this.idPrefix);
                _this.form.Password.addValidationRule(_this.uniqueName, function (e) {
                    if (_this.form.Password.value.length < 1)
                        return "Password must be at least 1 characters!";
                });
                _this.form.PasswordConfirm.addValidationRule(_this.uniqueName, function (e) {
                    if (_this.form.Password.value != _this.form.PasswordConfirm.value)
                        return "The passwords entered doesn't match!";
                });
                return _this;
            }
            UserDialog.prototype.getFormKey = function () { return Administration.UserForm.formKey; };
            UserDialog.prototype.getIdProperty = function () { return Administration.UserRow.idProperty; };
            UserDialog.prototype.getIsActiveProperty = function () { return Administration.UserRow.isActiveProperty; };
            UserDialog.prototype.getLocalTextPrefix = function () { return Administration.UserRow.localTextPrefix; };
            UserDialog.prototype.getNameProperty = function () { return Administration.UserRow.nameProperty; };
            UserDialog.prototype.getService = function () { return Administration.UserService.baseUrl; };

            UserDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };



            UserDialog.prototype.getToolbarButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.push({
                    title: Q.text('Site.UserDialog.EditRolesButton'),
                    cssClass: 'edit-roles-button',
                    icon: 'icon-people text-blue',
                    onClick: function () {
                        new Administration.UserRoleDialog({
                            userID: _this.entity.UserId,
                            username: _this.entity.Username
                        }).dialogOpen();
                    }
                });
                //buttons.push({
                //    title: Q.text('Site.UserDialog.EditPermissionsButton'),
                //    cssClass: 'edit-permissions-button',
                //    icon: 'icon-lock-open text-green',
                //    onClick: () => {
                //        new Administration.UserPermissionDialog({
                //            userID: this.entity.UserId,
                //            username: this.entity.Username
                //        }).dialogOpen();
                //    }
                //});
                return buttons;
            };
            UserDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
              
                this.toolbar.findButton('edit-roles-button').toggleClass('disabled', this.isNewOrDeleted());
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
                this.toolbar.findButton("delete-button").remove();
            };
            UserDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                // these fields are only required in new record mode
                this.form.Password.element.toggleClass('required', this.isNew())
                    .closest('.field').find('sup').toggle(this.isNew());
                this.form.PasswordConfirm.element.toggleClass('required', this.isNew())
                    .closest('.field').find('sup').toggle(this.isNew());
            };

            UserDialog.prototype.onDialogOpen = function () {
                if (this.isNew()) {
                    $("input[name='Username']").keyboard({
                        usePreview: false,
                        layout: 'custom',
                        customLayout: {
                            'normal': [
                                '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                                '{tab} q w e r t y u i o p [ ] \\',
                                'a s d f g h j k l ; \' {accept}',
                                '{shift} z x c v b n m , . / {shift}',
                                ' {space} {left} {right} {cancel}'
                            ],
                            'shift': [
                                '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                                '{tab} Q W E R T Y U I O P { } |',
                                'A S D F G H J K L : " {accept}',
                                '{shift} Z X C V B N M < > ? {shift}',
                                ' {space} {left} {right} {cancel}'
                            ]
                        },

                    })

                }
                $("input[name='EmployeeId'],input[name='FirstName'],input[name='LastName'],input[name='Designation'],input[name='Email'],input[name='Password'],input[name='PasswordConfirm'],input[name='Address'],input[name='QuestionAns']").keyboard({
                    usePreview: false,
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })

                $("input[name='MobileCode'],input[name='MobileNumber'],input[name='PinCode']").keyboard({
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '7 8 9',
                            '4 5 6',
                            '1 2 3',
                            '{bksp} 0',
                            '{a} {c}'
                        ]

                    }
                })

            }

            UserDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.panel()
            ], UserDialog);
            return UserDialog;
        }(Serenity.EntityDialog));
        Administration.UserDialog = UserDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserGrid = /** @class */ (function (_super) {
            __extends(UserGrid, _super);
            function UserGrid(container) {
                return _super.call(this, container) || this;
            }
            UserGrid.prototype.getColumnsKey = function () { return "Administration.User"; };
            UserGrid.prototype.getDialogType = function () { return Administration.UserDialog; };
            UserGrid.prototype.getIdProperty = function () { return Administration.UserRow.idProperty; };
            UserGrid.prototype.getIsActiveProperty = function () { return Administration.UserRow.isActiveProperty; };
            UserGrid.prototype.getLocalTextPrefix = function () { return Administration.UserRow.localTextPrefix; };
            UserGrid.prototype.getService = function () { return Administration.UserService.baseUrl; };
            UserGrid.prototype.getDefaultSortBy = function () {
                return [Administration.UserRow.Fields.Username];
            };
            UserGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));

                if ($("#hdnUserImportAccess").val() == "True") {
                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //cssClass: 'stampe',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('userManagement');
                            },
                        });
                }

                return buttons;
            };
            UserGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], UserGrid);
            return UserGrid;
        }(Serenity.EntityGrid));
        Administration.UserGrid = UserGrid;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Authorization;
    (function (Authorization) {
        Object.defineProperty(Authorization, 'userDefinition', {
            get: function () {
                return Q.getRemoteData('UserData');
            }
        });
        function hasPermission(permissionKey) {
            var ud = Authorization.userDefinition;
            return ud.Username === 'admin' || !!ud.Permissions[permissionKey];
        }
        Authorization.hasPermission = hasPermission;
    })(Authorization = CVC.Authorization || (CVC.Authorization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
      //  debugger;
        var RolePermissionDialog = /** @class */ (function (_super) {
            __extends(RolePermissionDialog, _super);
            function RolePermissionDialog(opt) {
                var _this = _super.call(this, opt) || this;
                _this.permissions = new Administration.PermissionCheckEditor(_this.byId('Permissions'), {
                    showRevoke: false
                });
                Administration.RolePermissionService.List({
                    RoleID: _this.options.roleID,
                    Module: null,
                    Submodule: null
                }, function (response) {
                    _this.permissions.value = response.Entities.map(function (x) { return ({ PermissionKey: x }); });
                });
                _this.permissions.implicitPermissions = Q.getRemoteData('Administration.ImplicitPermissions');
                return _this;
            }
            RolePermissionDialog.prototype.getDialogOptions = function () {
                var _this = this;
                var opt = _super.prototype.getDialogOptions.call(this);
                opt.buttons = [
                    {
                        text: Q.text('Dialogs.OkButton'),
                        click: function (e) {
                            Administration.RolePermissionService.Update({
                                RoleID: _this.options.roleID,
                                Permissions: _this.permissions.value.map(function (x) { return x.PermissionKey; }),
                                Module: null,
                                Submodule: null
                            }, function (response) {
                                _this.dialogClose();
                                window.setTimeout(function () { return Q.notifySuccess(Q.text('Site.RolePermissionDialog.SaveSuccess')); }, 0);
                            });
                        }
                    }, {
                        text: Q.text('Dialogs.CancelButton'),
                        click: function () { return _this.dialogClose(); }
                    }
                ];
                opt.title = Q.format(Q.text('Site.RolePermissionDialog.DialogTitle'), this.options.title);
                return opt;
            };
            RolePermissionDialog.prototype.getTemplate = function () {
                return '<div id="~_Permissions"></div>';
            };
            
            RolePermissionDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], RolePermissionDialog);
            return RolePermissionDialog;
        }(Serenity.TemplatedDialog));
        Administration.RolePermissionDialog = RolePermissionDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleDialog = /** @class */ (function (_super) {
            __extends(RoleDialog, _super);
            function RoleDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Administration.RoleForm(_this.idPrefix);
                return _this;
            }
            RoleDialog.prototype.getFormKey = function () { return Administration.RoleForm.formKey; };
            RoleDialog.prototype.getIdProperty = function () { return Administration.RoleRow.idProperty; };
            RoleDialog.prototype.getLocalTextPrefix = function () { return Administration.RoleRow.localTextPrefix; };
            RoleDialog.prototype.getNameProperty = function () { return Administration.RoleRow.nameProperty; };
            RoleDialog.prototype.getService = function () { return Administration.RoleService.baseUrl; };
            //RoleDialog.prototype.getToolbarButtons()
            //{
            //    let buttons = super.getToolbarButtons();
            //    buttons.push({
            //        title: Q.text('Site.RolePermissionDialog.EditButton'),
            //        cssClass: 'edit-permissions-button',
            //        icon: 'icon-lock-open text-green',
            //        onClick: () =>
            //        {
            //            new Administration.RolePermissionDialog({
            //                roleID: this.entity.RoleId,
            //                title: this.entity.RoleName
            //            }).dialogOpen();
            //        }
            //    });
            //    return buttons;
            //}

            RoleDialog.prototype.onSaveSuccess = function (response) {


                if (response.IsStatus) {
                    $("#infoModalBody").text(response.Data)
                    $("#modal-info").modal('show');
                }
                else {
                    Q.notifySuccess("Record Saved Successfully");
                }


                this.dialogClose();


            };


            RoleDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                buttons.push({
                    title: Q.text('Site.RolePermissionDialog.EditButton'),
                    cssClass: 'edit-permissions-button',
                    icon: 'icon-lock-open text-green',
                    onClick: () => {
                       
                        new Administration.RolePermissionDialog({
                            roleID: this.entity.RoleId,
                            title: this.entity.RoleName
                        }).dialogOpen();
                    }
                });
                return buttons;
            };
            RoleDialog.prototype.updateInterface = function () {
                debugger;
                _super.prototype.updateInterface.call(this);
              
                if ($("#hdnRoleId").val() != 1) {
                    
                    this.toolbar.findButton("edit-permissions-button").remove();
                }
               this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
               this.toolbar.findButton("delete-button").remove();
            };
           

            RoleDialog.prototype.onSaveSuccess = function (response) {
                // check that this is an insert
                if (this.isNew()) {
                    //Q.notifySuccess("Just inserted a category with ID: " + response.EntityId);
                    // you could also open a new dialog
                    // new Northwind.CategoryDialog().loadByIdAndOpenDialog(response.EntityId);
                    // but let's better load inserted record using Retrieve service
                    //Northwind.CategoryService.Retrieve(<any>{
                    //    EntityId: response.EntityId
                    //}, resp => {
                    //    Q.notifyInfo("Looks like the category you added has name: " + resp.Entity.CategoryName);
                    //});
                    //var AdminAuditLogRowNew = new AdminAuditLogRow();
                    //AdminAuditLogRowNew.
                    //var saverequest = new SaveRequest<AdminAuditLogRow>();
                    //saverequest.Entity. 
                }
            };

            RoleDialog.prototype.onDialogOpen = function () {
                $("input[name='RoleName']").keyboard({
                    usePreview: false,
                    layout: 'custom',
                    customLayout: {
                        'normal': [
                            '` 1 2 3 4 5 6 7 8 9 0 - = {bksp}',
                            '{tab} q w e r t y u i o p [ ] \\',
                            'a s d f g h j k l ; \' {accept}',
                            '{shift} z x c v b n m , . / {shift}',
                            ' {space} {left} {right} {cancel}'
                        ],
                        'shift': [
                            '~ ! @ # $ % ^ & * ( ) _ + {bksp}',
                            '{tab} Q W E R T Y U I O P { } |',
                            'A S D F G H J K L : " {accept}',
                            '{shift} Z X C V B N M < > ? {shift}',
                            ' {space} {left} {right} {cancel}'
                        ]
                    },

                })

            }

            RoleDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], RoleDialog);
            return RoleDialog;
        }(Serenity.EntityDialog));
        Administration.RoleDialog = RoleDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleGrid = /** @class */ (function (_super) {
            __extends(RoleGrid, _super);
            function RoleGrid(container) {
                return _super.call(this, container) || this;
            }
            RoleGrid.prototype.getColumnsKey = function () { return "Administration.Role"; };
            RoleGrid.prototype.getDialogType = function () { return Administration.RoleDialog; };
            RoleGrid.prototype.getIdProperty = function () { return Administration.RoleRow.idProperty; };
            RoleGrid.prototype.getLocalTextPrefix = function () { return Administration.RoleRow.localTextPrefix; };
            RoleGrid.prototype.getService = function () { return Administration.RoleService.baseUrl; };
            RoleGrid.prototype.getDefaultSortBy = function () {
                return [Administration.RoleRow.Fields.RoleName];
            };
            RoleGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                if ($("#hdnRoleImportAccess").val() == "True") {

                    buttons.push(
                        {
                            title: Q.text(""),	// *** Get button text from translation
                            //style: 'height:29px',
                            //icon: 'fa-file',
                            cssClass: 'export-xlsx-button',

                            onClick: () => {

                                importFile('role');

                            },
                        }
                    );
                }
                return buttons;
            };
          

            RoleGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], RoleGrid);
            return RoleGrid;
        }(Serenity.EntityGrid));
        Administration.RoleGrid = RoleGrid;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ModuleAccessDialog = /** @class */ (function (_super) {
            __extends(ModuleAccessDialog, _super);
            function ModuleAccessDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Administration.ModuleAccessForm(_this.idPrefix);
                return _this;
            }
            ModuleAccessDialog.prototype.getFormKey = function () { return Administration.ModuleAccessForm.formKey; };
            ModuleAccessDialog.prototype.getIdProperty = function () { return Administration.ModuleAccessRow.idProperty; };
            ModuleAccessDialog.prototype.getLocalTextPrefix = function () { return Administration.ModuleAccessRow.localTextPrefix; };
            ModuleAccessDialog.prototype.getService = function () { return Administration.ModuleAccessService.baseUrl; };
            ModuleAccessDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], ModuleAccessDialog);
            return ModuleAccessDialog;
        }(Serenity.EntityDialog));
        Administration.ModuleAccessDialog = ModuleAccessDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ModuleAccessGrid = /** @class */ (function (_super) {
            __extends(ModuleAccessGrid, _super);
            function ModuleAccessGrid(container) {
                return _super.call(this, container) || this;
            }
            ModuleAccessGrid.prototype.getColumnsKey = function () { return 'Administration.ModuleAccess'; };
            ModuleAccessGrid.prototype.getDialogType = function () { return Administration.ModuleAccessDialog; };
            ModuleAccessGrid.prototype.getIdProperty = function () { return Administration.ModuleAccessRow.idProperty; };
            ModuleAccessGrid.prototype.getLocalTextPrefix = function () { return Administration.ModuleAccessRow.localTextPrefix; };
            ModuleAccessGrid.prototype.getService = function () { return Administration.ModuleAccessService.baseUrl; };
            ModuleAccessGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ModuleAccessGrid);
            return ModuleAccessGrid;
        }(Serenity.EntityGrid));
        Administration.ModuleAccessGrid = ModuleAccessGrid;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var AdminFormDialog = /** @class */ (function (_super) {
            __extends(AdminFormDialog, _super);
            function AdminFormDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Administration.AdminFormForm(_this.idPrefix);
                return _this;
            }
            AdminFormDialog.prototype.getFormKey = function () { return Administration.AdminFormForm.formKey; };
            AdminFormDialog.prototype.getIdProperty = function () { return Administration.AdminFormRow.idProperty; };
            AdminFormDialog.prototype.getLocalTextPrefix = function () { return Administration.AdminFormRow.localTextPrefix; };
            AdminFormDialog.prototype.getNameProperty = function () { return Administration.AdminFormRow.nameProperty; };
            AdminFormDialog.prototype.getService = function () { return Administration.AdminFormService.baseUrl; };
            AdminFormDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], AdminFormDialog);
            return AdminFormDialog;
        }(Serenity.EntityDialog));
        Administration.AdminFormDialog = AdminFormDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var AdminFormGrid = /** @class */ (function (_super) {
            __extends(AdminFormGrid, _super);
            function AdminFormGrid(container) {
                return _super.call(this, container) || this;
            }
            AdminFormGrid.prototype.getColumnsKey = function () { return 'Administration.AdminForm'; };
            AdminFormGrid.prototype.getDialogType = function () { return Administration.AdminFormDialog; };
            AdminFormGrid.prototype.getIdProperty = function () { return Administration.AdminFormRow.idProperty; };
            AdminFormGrid.prototype.getLocalTextPrefix = function () { return Administration.AdminFormRow.localTextPrefix; };
            AdminFormGrid.prototype.getService = function () { return Administration.AdminFormService.baseUrl; };
            AdminFormGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], AdminFormGrid);
            return AdminFormGrid;
        }(Serenity.EntityGrid));
        Administration.AdminFormGrid = AdminFormGrid;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var AdminFormForm = /** @class */ (function (_super) {
            __extends(AdminFormForm, _super);
            function AdminFormForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            AdminFormForm.formKey = 'Administration.AdminForm';
            return AdminFormForm;
        }(Serenity.PrefixedContext));
        Administration.AdminFormForm = AdminFormForm;
        [,
            ['FormName', function () { return Serenity.StringEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(AdminFormForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var AdminFormRow;
        (function (AdminFormRow) {
            AdminFormRow.idProperty = 'AdminFormId';
            AdminFormRow.nameProperty = 'FormName';
            AdminFormRow.localTextPrefix = 'Administration.AdminForm';
            var Fields;
            (function (Fields) {
            })(Fields = AdminFormRow.Fields || (AdminFormRow.Fields = {}));
            [
                'AdminFormId',
                'FormName'
            ].forEach(function (x) { return Fields[x] = x; });
        })(AdminFormRow = Administration.AdminFormRow || (Administration.AdminFormRow = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var AdminFormService;
        (function (AdminFormService) {
            AdminFormService.baseUrl = 'Administration/AdminForm';
            var Methods;
            (function (Methods) {
            })(Methods = AdminFormService.Methods || (AdminFormService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AdminFormService[x] = function (r, s, o) {
                    return Q.serviceRequest(AdminFormService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = AdminFormService.baseUrl + '/' + x;
            });
        })(AdminFormService = Administration.AdminFormService || (Administration.AdminFormService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var LanguageForm = /** @class */ (function (_super) {
            __extends(LanguageForm, _super);
            function LanguageForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            LanguageForm.formKey = 'Configuration.Language';
            return LanguageForm;
        }(Serenity.PrefixedContext));
        Configuration.LanguageForm = LanguageForm;
        [['LanguageId', function () { return Serenity.StringEditor; }], ['LanguageName', function () { return Serenity.StringEditor; }]].forEach(function (x) { return Object.defineProperty(LanguageForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var LanguageRow;
        (function (LanguageRow) {
            LanguageRow.idProperty = 'Id';
            LanguageRow.nameProperty = 'LanguageName';
            LanguageRow.localTextPrefix = 'Configuration.Language';
            LanguageRow.lookupKey = 'Configuration.Language';
            function getLookup() {
                return Q.getLookup('Configuration.Language');
            }
            LanguageRow.getLookup = getLookup;
            var Fields;
            (function (Fields) {
            })(Fields = LanguageRow.Fields || (LanguageRow.Fields = {}));
            [
                'Id',
                'LanguageId',
                'LanguageName'
            ].forEach(function (x) { return Fields[x] = x; });
        })(LanguageRow = Configuration.LanguageRow || (Configuration.LanguageRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var LanguageService;
        (function (LanguageService) {
            LanguageService.baseUrl = 'Configuration/Language';
            var Methods;
            (function (Methods) {
            })(Methods = LanguageService.Methods || (LanguageService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                LanguageService[x] = function (r, s, o) {
                    return Q.serviceRequest(LanguageService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = LanguageService.baseUrl + '/' + x;
            });
        })(LanguageService = Configuration.LanguageService || (Configuration.LanguageService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ModuleAccessForm = /** @class */ (function (_super) {
            __extends(ModuleAccessForm, _super);
            function ModuleAccessForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ModuleAccessForm.formKey = 'Administration.ModuleAccess';
            return ModuleAccessForm;
        }(Serenity.PrefixedContext));
        Administration.ModuleAccessForm = ModuleAccessForm;
        [,
            ['ModuleId', function () { return Serenity.IntegerEditor; }],
            ['RoleId', function () { return Serenity.IntegerEditor; }],
            ['IsAccess', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }],
            ['IsRealTime', function () { return Serenity.BooleanEditor }],          // added manually
            ['TableId', function () { return Serenity.IntegerEditor }]              // added manually
        ].forEach(function (x) {
            return Object.defineProperty(ModuleAccessForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ModuleAccessRow;
        (function (ModuleAccessRow) {
            ModuleAccessRow.idProperty = 'ModuleAccessId';
            ModuleAccessRow.localTextPrefix = 'Administration.ModuleAccess';
            var Fields;
            (function (Fields) {
            })(Fields = ModuleAccessRow.Fields || (ModuleAccessRow.Fields = {}));
            [
                'ModuleAccessId',
                'ModuleId',
                'RoleId',
                'IsAccess',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'ModuleModuleName',
                'ModuleMachineId',
                'ModuleStatusId',
                'ModuleCreatedBy',
                'ModuleCreatedDate',
                'ModuleUpdatedBy',
                'ModuleUpdatedDate',
                'RoleRoleName',
                'RoleStatusId',
                'RoleIsHidden',
                'RoleParentRoleId',
                'RoleCreatedBy',
                'RoleCreatedDate',
                'RoleUpdatedBy',
                'RoleUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(ModuleAccessRow = Administration.ModuleAccessRow || (Administration.ModuleAccessRow = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ModuleAccessService;
        (function (ModuleAccessService) {
            ModuleAccessService.baseUrl = 'Administration/ModuleAccess';
            var Methods;
            (function (Methods) {
            })(Methods = ModuleAccessService.Methods || (ModuleAccessService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ModuleAccessService[x] = function (r, s, o) {
                    return Q.serviceRequest(ModuleAccessService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = ModuleAccessService.baseUrl + '/' + x;
            });
        })(ModuleAccessService = Administration.ModuleAccessService || (Administration.ModuleAccessService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleForm = /** @class */ (function (_super) {
            __extends(RoleForm, _super);
            function RoleForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            RoleForm.formKey = 'Administration.Role';
            return RoleForm;
        }(Serenity.PrefixedContext));
        Administration.RoleForm = RoleForm;
        [['RoleName', function () { return Serenity.StringEditor; }],
        ['IsHidden', function () { return Serenity.BooleanEditor; }],
        ['ParentRoleId', function () { return Serenity.IntegerEditor; }],
        ['StatusId', function () { return Serenity.IntegerEditor; }],
        ['CreatedBy', function () { return Serenity.IntegerEditor; }],
        ['CreatedDate', function () { return Serenity.DateEditor; }],
        ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
        ['UpdatedDate', function () { return Serenity.DateEditor; }]].
            forEach(function (x) { return Object.defineProperty(RoleForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RolePermissionRow;
        (function (RolePermissionRow) {
            RolePermissionRow.idProperty = 'RolePermissionId';
            RolePermissionRow.nameProperty = 'PermissionKey';
            RolePermissionRow.localTextPrefix = 'Administration.RolePermission';
            var Fields;
            (function (Fields) {
            })(Fields = RolePermissionRow.Fields || (RolePermissionRow.Fields = {}));
            [
                'RolePermissionId',
                'RoleId',
                'PermissionKey',
                'RoleRoleName'
            ].forEach(function (x) { return Fields[x] = x; });
        })(RolePermissionRow = Administration.RolePermissionRow || (Administration.RolePermissionRow = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RolePermissionService;
        (function (RolePermissionService) {
            RolePermissionService.baseUrl = 'Administration/RolePermission';
            var Methods;
            (function (Methods) {
            })(Methods = RolePermissionService.Methods || (RolePermissionService.Methods = {}));
            [
                'Update',
                'List'
            ].forEach(function (x) {
                RolePermissionService[x] = function (r, s, o) {
                    return Q.serviceRequest(RolePermissionService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = RolePermissionService.baseUrl + '/' + x;
            });
        })(RolePermissionService = Administration.RolePermissionService || (Administration.RolePermissionService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleRow;
        (function (RoleRow) {
            RoleRow.idProperty = 'RoleId';
            RoleRow.nameProperty = 'RoleName';
            RoleRow.localTextPrefix = 'Administration.Role';
            RoleRow.lookupKey = 'Administration.Role';
            function getLookup() {
                return Q.getLookup('Administration.Role');
            }
            RoleRow.getLookup = getLookup;
            var Fields;
            (function (Fields) {
            })(Fields = RoleRow.Fields || (RoleRow.Fields = {}));
            [
                'RoleId',
                'RoleName',
                'StatusId',
                'IsHidden',
                'ParentRoleId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'RolesRoleName'
            ].forEach(function (x) { return Fields[x] = x; });
        })(RoleRow = Administration.RoleRow || (Administration.RoleRow = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleService;
        (function (RoleService) {
            RoleService.baseUrl = 'Administration/Role';
            var Methods;
            (function (Methods) {
            })(Methods = RoleService.Methods || (RoleService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                RoleService[x] = function (r, s, o) {
                    return Q.serviceRequest(RoleService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = RoleService.baseUrl + '/' + x;
            });
        })(RoleService = Administration.RoleService || (Administration.RoleService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var TranslationService;
        (function (TranslationService) {
            TranslationService.baseUrl = 'Configuration/Translation';
            var Methods;
            (function (Methods) {
            })(Methods = TranslationService.Methods || (TranslationService.Methods = {}));
            [
                'List',
                'Update'
            ].forEach(function (x) {
                TranslationService[x] = function (r, s, o) {
                    return Q.serviceRequest(TranslationService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = TranslationService.baseUrl + '/' + x;
            });
        })(TranslationService = Configuration.TranslationService || (Configuration.TranslationService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserForm = /** @class */ (function (_super) {
            __extends(UserForm, _super);
            function UserForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            UserForm.formKey = 'Administration.User';
            return UserForm;
        }(Serenity.PrefixedContext));
        Administration.UserForm = UserForm;
        [['Username', function () { return Serenity.StringEditor; }],
        ['FirstName', function () { return Serenity.StringEditor; }],
        ['LastName', function () { return Serenity.StringEditor; }],
        ['Email', function () { return Serenity.EmailEditor; }],
        ['UserImage', function () { return Serenity.ImageUploadEditor; }],
        ['Password', function () { return Serenity.PasswordEditor; }],
        ['PasswordConfirm', function () { return Serenity.PasswordEditor; }],
        ['EmployeeId', function () { return Serenity.StringEditor; }],
        ['DepartmentId', function () { return Serenity.IntegerEditor; }],
        ['Designation', function () { return Serenity.StringEditor; }],
        ['MobileCode', function () { return Serenity.IntegerEditor; }],
        ['MobileNumber', function () { return Serenity.IntegerEditor; }],
        ['Address', function () { return Serenity.StringEditor; }],
        ['CityId', function () { return Serenity.IntegerEditor; }],
        ['PinCode', function () { return Serenity.StringEditor; }],
        ['RoleId', function () { return Serenity.IntegerEditor; }],
        ['PasswordExpiryDate', function () { return Serenity.DateEditor; }],
        ['IsForgotPassword', function () { return Serenity.IntegerEditor; }],
        ['IsPasswordChangeOnLogin', function () { return Serenity.IntegerEditor; }],
        ['IsUserHidden', function () { return Serenity.IntegerEditor; }],
        ['BirthDate', function () { return Serenity.DateEditor; }],
        ['StatusId', function () { return Serenity.IntegerEditor; }],
        ['CreatedBy', function () { return Serenity.IntegerEditor; }],
        ['CreatedDate', function () { return Serenity.DateEditor; }],
        ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
        ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) { return Object.defineProperty(UserForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserPermissionRow;
        (function (UserPermissionRow) {
            UserPermissionRow.idProperty = 'UserPermissionId';
            UserPermissionRow.nameProperty = 'PermissionKey';
            UserPermissionRow.localTextPrefix = 'Administration.UserPermission';
            var Fields;
            (function (Fields) {
            })(Fields = UserPermissionRow.Fields || (UserPermissionRow.Fields = {}));
            [
                'UserPermissionId',
                'UserId',
                'PermissionKey',
                'Granted',
                'Username',
                'User'
            ].forEach(function (x) { return Fields[x] = x; });
        })(UserPermissionRow = Administration.UserPermissionRow || (Administration.UserPermissionRow = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserPermissionService;
        (function (UserPermissionService) {
            UserPermissionService.baseUrl = 'Administration/UserPermission';
            var Methods;
            (function (Methods) {
            })(Methods = UserPermissionService.Methods || (UserPermissionService.Methods = {}));
            [
                'Update',
                'List',
                'ListRolePermissions',
                'ListPermissionKeys'
            ].forEach(function (x) {
                UserPermissionService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserPermissionService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = UserPermissionService.baseUrl + '/' + x;
            });
        })(UserPermissionService = Administration.UserPermissionService || (Administration.UserPermissionService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserRoleRow;
        (function (UserRoleRow) {
            UserRoleRow.idProperty = 'UserRoleId';
            UserRoleRow.localTextPrefix = 'Administration.UserRole';
            var Fields;
            (function (Fields) {
            })(Fields = UserRoleRow.Fields || (UserRoleRow.Fields = {}));
            [
                'UserRoleId',
                'UserId',
                'RoleId',
                'Username',
                'User',
                'EmployeeId',
                'DepartmentId',
                'Designation',
                'MobileCode',
                'MobileNumber',
                'Address',
                'CityId',
                'PinCode',
                //'RoleId',
                'PasswordExpiryDate',
                'IsForgotPassword',
                'IsPasswordChangeOnLogin',
                'IsUserHidden',
                'BirthDate',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(UserRoleRow = Administration.UserRoleRow || (Administration.UserRoleRow = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserRoleService;
        (function (UserRoleService) {
            UserRoleService.baseUrl = 'Administration/UserRole';
            var Methods;
            (function (Methods) {
            })(Methods = UserRoleService.Methods || (UserRoleService.Methods = {}));
            [
                'Update',
                'List'
            ].forEach(function (x) {
                UserRoleService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserRoleService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = UserRoleService.baseUrl + '/' + x;
            });
        })(UserRoleService = Administration.UserRoleService || (Administration.UserRoleService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserRow;
        (function (UserRow) {
            UserRow.idProperty = 'UserId';
            UserRow.isActiveProperty = 'StatusId';
            UserRow.nameProperty = 'Username';
            UserRow.localTextPrefix = 'Administration.User';
            UserRow.lookupKey = 'Administration.User';
            function getLookup() {
                return Q.getLookup('Administration.User');
            }
            UserRow.getLookup = getLookup;
            var Fields;
            (function (Fields) {
            })(Fields = UserRow.Fields || (UserRow.Fields = {}));
            [
                'UserId',
                'Username',
                'FirstName',
                'LastName',
                'PasswordHash',
                'PasswordSalt',
                'Email',
                'UserImage',
                'StatusId',
                'Password',
                'PasswordConfirm'
            ].forEach(function (x) { return Fields[x] = x; });
        })(UserRow = Administration.UserRow || (Administration.UserRow = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserService;
        (function (UserService) {
            UserService.baseUrl = 'Administration/User';
            var Methods;
            (function (Methods) {
            })(Methods = UserService.Methods || (UserService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Undelete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                UserService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = UserService.baseUrl + '/' + x;
            });
        })(UserService = Administration.UserService || (Administration.UserService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ViewFieldAccessForm = /** @class */ (function (_super) {
            __extends(ViewFieldAccessForm, _super);
            function ViewFieldAccessForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ViewFieldAccessForm.formKey = 'Administration.ViewFieldAccess';
            return ViewFieldAccessForm;
        }(Serenity.PrefixedContext));
        Administration.ViewFieldAccessForm = ViewFieldAccessForm;
        [,
            ['ViewFieldId', function () { return Serenity.IntegerEditor; }],
            ['RoleId', function () { return Serenity.IntegerEditor; }],
            ['IsView', function () { return Serenity.IntegerEditor; }],
            ['IsReadOnly', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(ViewFieldAccessForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ViewFieldAccessRow;
        (function (ViewFieldAccessRow) {
            ViewFieldAccessRow.idProperty = 'ViewFieldAccessId';
            ViewFieldAccessRow.localTextPrefix = 'Administration.ViewFieldAccess';
            var Fields;
            (function (Fields) {
            })(Fields = ViewFieldAccessRow.Fields || (ViewFieldAccessRow.Fields = {}));
            [
                'ViewFieldAccessId',
                'ViewFieldId',
                'RoleId',
                'IsView',
                'IsReadOnly',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'ViewFieldViewsId',
                'ViewFieldViewFieldName',
                'ViewFieldIpcParameterId',
                'ViewFieldStatusId',
                'ViewFieldCreatedBy',
                'ViewFieldCreatedDate',
                'ViewFieldUpdatedBy',
                'ViewFieldUpdatedDate',
                'RoleRoleName',
                'RoleStatusId',
                'RoleIsHidden',
                'RoleParentRoleId',
                'RoleCreatedBy',
                'RoleCreatedDate',
                'RoleUpdatedBy',
                'RoleUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(ViewFieldAccessRow = Administration.ViewFieldAccessRow || (Administration.ViewFieldAccessRow = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ViewFieldAccessService;
        (function (ViewFieldAccessService) {
            ViewFieldAccessService.baseUrl = 'Administration/ViewFieldAccess';
            var Methods;
            (function (Methods) {
            })(Methods = ViewFieldAccessService.Methods || (ViewFieldAccessService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ViewFieldAccessService[x] = function (r, s, o) {
                    return Q.serviceRequest(ViewFieldAccessService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = ViewFieldAccessService.baseUrl + '/' + x;
            });
        })(ViewFieldAccessService = Administration.ViewFieldAccessService || (Administration.ViewFieldAccessService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ViewsAccessForm = /** @class */ (function (_super) {
            __extends(ViewsAccessForm, _super);
            function ViewsAccessForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ViewsAccessForm.formKey = 'Administration.ViewsAccess';
            return ViewsAccessForm;
        }(Serenity.PrefixedContext));
        Administration.ViewsAccessForm = ViewsAccessForm;
        [,
            ['ViewsId', function () { return Serenity.IntegerEditor; }],
            ['RoleId', function () { return Serenity.IntegerEditor; }],
            ['IsView', function () { return Serenity.IntegerEditor; }],
            ['IsEdit', function () { return Serenity.IntegerEditor; }],
            ['IsAdd', function () { return Serenity.IntegerEditor; }],
            ['IsDelete', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(ViewsAccessForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ViewsAccessRow;
        (function (ViewsAccessRow) {
            ViewsAccessRow.idProperty = 'ViewsAccessId';
            ViewsAccessRow.localTextPrefix = 'Administration.ViewsAccess';
            var Fields;
            (function (Fields) {
            })(Fields = ViewsAccessRow.Fields || (ViewsAccessRow.Fields = {}));
            [
                'ViewsAccessId',
                'ViewsId',
                'RoleId',
                'IsView',
                'IsEdit',
                'IsAdd',
                'IsDelete',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'ViewsModuleId',
                'ViewsViewName',
                'ViewsIsAccessFieldWise',
                'ViewsStatusId',
                'ViewsCreatedBy',
                'ViewsCreatedDate',
                'ViewsUpdatedBy',
                'ViewsUpdatedDate',
                'RoleRoleName',
                'RoleStatusId',
                'RoleIsHidden',
                'RoleParentRoleId',
                'RoleCreatedBy',
                'RoleCreatedDate',
                'RoleUpdatedBy',
                'RoleUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(ViewsAccessRow = Administration.ViewsAccessRow || (Administration.ViewsAccessRow = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ViewsAccessService;
        (function (ViewsAccessService) {
            ViewsAccessService.baseUrl = 'Administration/ViewsAccess';
            var Methods;
            (function (Methods) {
            })(Methods = ViewsAccessService.Methods || (ViewsAccessService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ViewsAccessService[x] = function (r, s, o) {
                    return Q.serviceRequest(ViewsAccessService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = ViewsAccessService.baseUrl + '/' + x;
            });
        })(ViewsAccessService = Administration.ViewsAccessService || (Administration.ViewsAccessService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchForm = /** @class */ (function (_super) {
            __extends(BatchForm, _super);
            function BatchForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            BatchForm.formKey = 'Batch.Batch';
            return BatchForm;
        }(Serenity.PrefixedContext));
        Batch.BatchForm = BatchForm;
        [,
            ['BatchName', function () { return Serenity.StringEditor; }],        
            ['PackId', function () { return Serenity.IntegerEditor; }],
            ['BatchStartDateTime', function () { return Serenity.DateEditor; }],
            ['BatchEndDateTime', function () { return Serenity.DateEditor; }],
            ['MachineLineId', function () { return Serenity.IntegerEditor; }],
            ['BatchStatus', function () { return Serenity.StringEditor; }],
            ['BatchSize', function () { return Serenity.IntegerEditor; }],
            ['BatchFor', function () { return Serenity.IntegerEditor; }],
            ['NumberOfBottles', function () { return Serenity.IntegerEditor; }],
            ['TotalGoodBottles', function () { return Serenity.IntegerEditor; }],
            ['TotalRejectedBottles', function () { return Serenity.IntegerEditor; }],
            ['ProductionSpeed', function () { return Serenity.StringEditor; }],
            ['ExpiryDate', function () { return Serenity.DateEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }],
            ['BatchVersion', function () { return Serenity.StringEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(BatchForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogForm = /** @class */ (function (_super) {
            __extends(BatchLogForm, _super);
            function BatchLogForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            BatchLogForm.formKey = 'Batch.BatchLog';
            return BatchLogForm;
        }(Serenity.PrefixedContext));
        Batch.BatchLogForm = BatchLogForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['BatchId', function () { return Serenity.IntegerEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['UserId', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDateTime', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(BatchLogForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogArchiveForm = /** @class */ (function (_super) {
            __extends(BatchLogArchiveForm, _super);
            function BatchLogArchiveForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            BatchLogArchiveForm.formKey = 'Batch.BatchLogArchive';
            return BatchLogArchiveForm;
        }(Serenity.PrefixedContext));
        Batch.BatchLogArchiveForm = BatchLogArchiveForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['BatchId', function () { return Serenity.IntegerEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['UserId', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDateTime', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(BatchLogArchiveForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogRow;
        (function (BatchLogRow) {
            BatchLogRow.idProperty = 'BatchLogId';
            BatchLogRow.nameProperty = 'Description';
            BatchLogRow.localTextPrefix = 'Batch.BatchLog';
            var Fields;
            (function (Fields) {
            })(Fields = BatchLogRow.Fields || (BatchLogRow.Fields = {}));
            [
                'BatchLogId',
                'MachineId',
                'BatchId',
                'Description',
                'UserId',
                'UpdatedDateTime'
            ].forEach(function (x) { return Fields[x] = x; });
        })(BatchLogRow = Batch.BatchLogRow || (Batch.BatchLogRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogArchiveRow;
        (function (BatchLogArchiveRow) {
            BatchLogArchiveRow.idProperty = 'BatchLogArchiveId';
            BatchLogArchiveRow.nameProperty = 'Description';
            BatchLogArchiveRow.localTextPrefix = 'Batch.BatchLogArchive';
            var Fields;
            (function (Fields) {
            })(Fields = BatchLogArchiveRow.Fields || (BatchLogArchiveRow.Fields = {}));
            [
                'BatchLogArchiveId',
                'MachineId',
                'BatchId',
                'Description',
                'UserId',
                'UpdatedDateTime'
            ].forEach(function (x) { return Fields[x] = x; });
        })(BatchLogArchiveRow = Batch.BatchLogArchiveRow || (Batch.BatchLogArchiveRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogService;
        (function (BatchLogService) {
            BatchLogService.baseUrl = 'Batch/BatchLog';
            var Methods;
            (function (Methods) {
            })(Methods = BatchLogService.Methods || (BatchLogService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                BatchLogService[x] = function (r, s, o) {
                    return Q.serviceRequest(BatchLogService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = BatchLogService.baseUrl + '/' + x;
            });
        })(BatchLogService = Batch.BatchLogService || (Batch.BatchLogService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));



var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogArchiveService;
        (function (BatchLogArchiveService) {
            BatchLogArchiveService.baseUrl = 'Batch/BatchLogArchive';
            var Methods;
            (function (Methods) {
            })(Methods = BatchLogArchiveService.Methods || (BatchLogArchiveService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                BatchLogArchiveService[x] = function (r, s, o) {
                    return Q.serviceRequest(BatchLogArchiveService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = BatchLogArchiveService.baseUrl + '/' + x;
            });
        })(BatchLogArchiveService = Batch.BatchLogArchiveService || (Batch.BatchLogArchiveService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchMachineWiseForm = /** @class */ (function (_super) {
            __extends(BatchMachineWiseForm, _super);
            function BatchMachineWiseForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            BatchMachineWiseForm.formKey = 'Batch.BatchMachineWise';
            return BatchMachineWiseForm;
        }(Serenity.PrefixedContext));
        Batch.BatchMachineWiseForm = BatchMachineWiseForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['BatchId', function () { return Serenity.IntegerEditor; }],
            ['RecipeId', function () { return Serenity.IntegerEditor; }],
            ['IsMachineInUse', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(BatchMachineWiseForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchMachineWiseRow;
        (function (BatchMachineWiseRow) {
            BatchMachineWiseRow.idProperty = 'BatchMachineId';
            BatchMachineWiseRow.localTextPrefix = 'Batch.BatchMachineWise';
            var Fields;
            (function (Fields) {
            })(Fields = BatchMachineWiseRow.Fields || (BatchMachineWiseRow.Fields = {}));
            [
                'BatchMachineId',
                'MachineId',
                'BatchId',
                'RecipeId',
                'IsMachineInUse',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate',
                'BatchBatchName',
                'BatchPackId',
                'BatchBatchStartDateTime',
                'BatchBatchVersion',
                'BatchBatchEndDateTime',
                'BatchMachineLineId',
                'BatchBatchStatus',
                'BatchBatchSize',
                'BatchBatchFor',
                'BatchNumberOfBottles',
                'BatchTotalGoodBottles',
                'BatchTotalRejectedBottles',
                'BatchProductionSpeed',
                'BatchExpiryDate',
                'BatchStatusId',
                'BatchCreatedBy',
                'BatchCreatedDate',
                'BatchUpdatedBy',
                'BatchUpdatedDate',
                'RecipeMachineId',
                'RecipeRecipeSettingsId',
                'RecipeRecipeName',
                'RecipeStatusId',
                'RecipeCreatedBy',
                'RecipeCreatedDate',
                'RecipeUpdatedBy',
                'RecipeUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(BatchMachineWiseRow = Batch.BatchMachineWiseRow || (Batch.BatchMachineWiseRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchMachineWiseService;
        (function (BatchMachineWiseService) {
            BatchMachineWiseService.baseUrl = 'Batch/BatchMachineWise';
            var Methods;
            (function (Methods) {
            })(Methods = BatchMachineWiseService.Methods || (BatchMachineWiseService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                BatchMachineWiseService[x] = function (r, s, o) {
                    return Q.serviceRequest(BatchMachineWiseService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = BatchMachineWiseService.baseUrl + '/' + x;
            });
        })(BatchMachineWiseService = Batch.BatchMachineWiseService || (Batch.BatchMachineWiseService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRecipeModifyForm = /** @class */ (function (_super) {
            __extends(BatchRecipeModifyForm, _super);
            function BatchRecipeModifyForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            BatchRecipeModifyForm.formKey = 'Batch.BatchRecipeModify';
            return BatchRecipeModifyForm;
        }(Serenity.PrefixedContext));
        Batch.BatchRecipeModifyForm = BatchRecipeModifyForm;
        [,
            ['BatchMachineId', function () { return Serenity.IntegerEditor; }],
            ['RecipeSettingsParameterId', function () { return Serenity.IntegerEditor; }],
            ['OldValue', function () { return Serenity.StringEditor; }],
            ['NewValue', function () { return Serenity.StringEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(BatchRecipeModifyForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRecipeModifyRow;
        (function (BatchRecipeModifyRow) {
            BatchRecipeModifyRow.idProperty = 'BatchRecipeModifyId';
            BatchRecipeModifyRow.nameProperty = 'OldValue';
            BatchRecipeModifyRow.localTextPrefix = 'Batch.BatchRecipeModify';
            var Fields;
            (function (Fields) {
            })(Fields = BatchRecipeModifyRow.Fields || (BatchRecipeModifyRow.Fields = {}));
            [
                'BatchRecipeModifyId',
                'BatchMachineId',
                'RecipeSettingsParameterId',
                'OldValue',
                'NewValue',
                'UpdatedBy',
                'UpdatedDate',
                'BatchMachineMachineId',
                'BatchMachineBatchId',
                'BatchMachineRecipeId',
                'BatchMachineIsMachineInUse',
                'BatchMachineStatusId',
                'BatchMachineCreatedBy',
                'BatchMachineCreatedDate',
                'BatchMachineUpdatedBy',
                'BatchMachineUpdatedDate',
                'RecipeSettingsParameterRecipeSettingsId',
                'RecipeSettingsParameterIpcParameterId',
                'RecipeSettingsParameterIsFetchOnSelfSet',
                'RecipeSettingsParameterStatusId',
                'RecipeSettingsParameterCreatedBy',
                'RecipeSettingsParameterCreatedDate',
                'RecipeSettingsParameterUpdatedBy',
                'RecipeSettingsParameterUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(BatchRecipeModifyRow = Batch.BatchRecipeModifyRow || (Batch.BatchRecipeModifyRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRecipeModifyService;
        (function (BatchRecipeModifyService) {
            BatchRecipeModifyService.baseUrl = 'Batch/BatchRecipeModify';
            var Methods;
            (function (Methods) {
            })(Methods = BatchRecipeModifyService.Methods || (BatchRecipeModifyService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                BatchRecipeModifyService[x] = function (r, s, o) {
                    return Q.serviceRequest(BatchRecipeModifyService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = BatchRecipeModifyService.baseUrl + '/' + x;
            });
        })(BatchRecipeModifyService = Batch.BatchRecipeModifyService || (Batch.BatchRecipeModifyService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRow;
        (function (BatchRow) {
            BatchRow.idProperty = 'BatchId';
            BatchRow.nameProperty = 'BatchName';
            BatchRow.localTextPrefix = 'Batch.Batch';
            var Fields;
            (function (Fields) {
            })(Fields = BatchRow.Fields || (BatchRow.Fields = {}));
            [
                'BatchId',
                'BatchName',
                'PackId',
                'BatchStartDateTime',
                'BatchVersion',
                'BatchEndDateTime',
                'MachineLineId',
                'BatchStatus',
                'BatchSize',
                'BatchFor',
                'NumberOfBottles',
                'TotalGoodBottles',
                'TotalRejectedBottles',
                'ProductionSpeed',
                'ExpiryDate',
                'StatusId',
               
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'BatchForPickListId',
                'BatchForPickListValueName',
                'BatchForStatusId',
                'BatchForCreatedBy',
                'BatchForCreatedDate',
                'BatchForUpdatedBy',
                'BatchForUpdatedDate',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(BatchRow = Batch.BatchRow || (Batch.BatchRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRunDataForm = /** @class */ (function (_super) {
            __extends(BatchRunDataForm, _super);
            function BatchRunDataForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            BatchRunDataForm.formKey = 'Batch.BatchRunData';
            return BatchRunDataForm;
        }(Serenity.PrefixedContext));
        Batch.BatchRunDataForm = BatchRunDataForm;
        [,
            ['BatchMachineWiseId', function () { return Serenity.IntegerEditor; }],
            ['IpcParameterId', function () { return Serenity.IntegerEditor; }],
            ['IpcParameterValue', function () { return Serenity.StringEditor; }],
            ['UpdatedDateTime', function () { return Serenity.DateEditor; }],
            ['LoggedInUser', function () { return Serenity.IntegerEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(BatchRunDataForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRunDataRow;
        (function (BatchRunDataRow) {
            BatchRunDataRow.idProperty = 'BatchRunDataId';
            BatchRunDataRow.nameProperty = 'IpcParameterValue';
            BatchRunDataRow.localTextPrefix = 'Batch.BatchRunData';
            var Fields;
            (function (Fields) {
            })(Fields = BatchRunDataRow.Fields || (BatchRunDataRow.Fields = {}));
            [
                'BatchRunDataId',
                'BatchMachineWiseId',
                'IpcParameterId',
                'IpcParameterValue',
                'UpdatedDateTime',
                'LoggedInUser',
                'BatchMachineWiseMachineId',
                'BatchMachineWiseBatchId',
                'BatchMachineWiseRecipeId',
                'BatchMachineWiseIsMachineInUse',
                'BatchMachineWiseStatusId',
                'BatchMachineWiseCreatedBy',
                'BatchMachineWiseCreatedDate',
                'BatchMachineWiseUpdatedBy',
                'BatchMachineWiseUpdatedDate',
                'IpcParameterMachineId',
                'IpcParameterIpcParameterName',
                'IpcParameterMachineParameterId',
                'IpcParameterIpcAddress',
                'IpcParameterIsChangeInRuntime',
                'IpcParameterStatusId',
                'IpcParameterCreatedBy',
                'IpcParameterCreatedDate',
                'IpcParameterUpdatedBy',
                'IpcParameterUpdatedDate',
                'LoggedInUserEmployeeId',
                'LoggedInUserFirstName',
                'LoggedInUserLastName',
                'LoggedInUserDepartmentId',
                'LoggedInUserDesignation',
                'LoggedInUserMobileCode',
                'LoggedInUserMobileNumber',
                'LoggedInUserEmail',
                'LoggedInUserUsername',
                'LoggedInUserPasswordHash',
                'LoggedInUserPasswordSalt',
                'LoggedInUserUserImage',
                'LoggedInUserAddress',
                'LoggedInUserCityId',
                'LoggedInUserPinCode',
                'LoggedInUserRoleId',
                'LoggedInUserPasswordExpiryDate',
                'LoggedInUserIsForgotPassword',
                'LoggedInUserIsPasswordChangeOnLogin',
                'LoggedInUserIsUserHidden',
                'LoggedInUserStatusId',
                'LoggedInUserCreatedBy',
                'LoggedInUserCreatedDate',
                'LoggedInUserUpdatedBy',
                'LoggedInUserUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(BatchRunDataRow = Batch.BatchRunDataRow || (Batch.BatchRunDataRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRunDataService;
        (function (BatchRunDataService) {
            BatchRunDataService.baseUrl = 'Batch/BatchRunData';
            var Methods;
            (function (Methods) {
            })(Methods = BatchRunDataService.Methods || (BatchRunDataService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                BatchRunDataService[x] = function (r, s, o) {
                    return Q.serviceRequest(BatchRunDataService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = BatchRunDataService.baseUrl + '/' + x;
            });
        })(BatchRunDataService = Batch.BatchRunDataService || (Batch.BatchRunDataService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchService;
        (function (BatchService) {
            BatchService.baseUrl = 'Batch/Batch';
            var Methods;
            (function (Methods) {
            })(Methods = BatchService.Methods || (BatchService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                BatchService[x] = function (r, s, o) {
                    return Q.serviceRequest(BatchService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = BatchService.baseUrl + '/' + x;
            });
        })(BatchService = Batch.BatchService || (Batch.BatchService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelLostForm = /** @class */ (function (_super) {
            __extends(LabelLostForm, _super);
            function LabelLostForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            LabelLostForm.formKey = 'Batch.LabelLost';
            return LabelLostForm;
        }(Serenity.PrefixedContext));
        Batch.LabelLostForm = LabelLostForm;
        [,
            ['LabelRecId', function () { return Serenity.IntegerEditor; }],
            ['ActivityId', function () { return Serenity.IntegerEditor; }],
            ['ActivityText', function () { return Serenity.StringEditor; }],
            ['NumberOfLabels', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(LabelLostForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelLostRow;
        (function (LabelLostRow) {
            LabelLostRow.idProperty = 'LabelLostId';
            LabelLostRow.nameProperty = 'ActivityText';
            LabelLostRow.localTextPrefix = 'Batch.LabelLost';
            var Fields;
            (function (Fields) {
            })(Fields = LabelLostRow.Fields || (LabelLostRow.Fields = {}));
            [
                'LabelLostId',
                'LabelRecId',
                'ActivityId',
                'ActivityText',
                'NumberOfLabels',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'LabelRecBatchId',
                'LabelRecMachineId',
                'LabelRecLabelRollId',
                'LabelRecRejectedLabels',
                'LabelRecLabelLost',
                'LabelRecNoLabelOnRoll',
                'LabelRecLabelBalance',
                'LabelRecStatusId',
                'LabelRecCreatedBy',
                'LabelRecCreatedDate',
                'LabelRecUpdatedBy',
                'LabelRecUpdatedDate',
                'ActivityPickListId',
                'ActivityPickListValueName',
                'ActivityStatusId',
                'ActivityCreatedBy',
                'ActivityCreatedDate',
                'ActivityUpdatedBy',
                'ActivityUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(LabelLostRow = Batch.LabelLostRow || (Batch.LabelLostRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelLostService;
        (function (LabelLostService) {
            LabelLostService.baseUrl = 'Batch/LabelLost';
            var Methods;
            (function (Methods) {
            })(Methods = LabelLostService.Methods || (LabelLostService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                LabelLostService[x] = function (r, s, o) {
                    return Q.serviceRequest(LabelLostService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = LabelLostService.baseUrl + '/' + x;
            });
        })(LabelLostService = Batch.LabelLostService || (Batch.LabelLostService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelReconciliationForm = /** @class */ (function (_super) {
            __extends(LabelReconciliationForm, _super);
            function LabelReconciliationForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            LabelReconciliationForm.formKey = 'Batch.LabelReconciliation';
            return LabelReconciliationForm;
        }(Serenity.PrefixedContext));
        Batch.LabelReconciliationForm = LabelReconciliationForm;
        [,
            ['BatchId', function () { return Serenity.IntegerEditor; }],
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['LabelRollId', function () { return Serenity.IntegerEditor; }],
            ['RejectedLabels', function () { return Serenity.IntegerEditor; }],
            ['LabelLost', function () { return Serenity.IntegerEditor; }],
            ['NoLabelOnRoll', function () { return Serenity.IntegerEditor; }],
            ['LabelBalance', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(LabelReconciliationForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelReconciliationRow;
        (function (LabelReconciliationRow) {
            LabelReconciliationRow.idProperty = 'LabelRecId';
            LabelReconciliationRow.localTextPrefix = 'Batch.LabelReconciliation';
            var Fields;
            (function (Fields) {
            })(Fields = LabelReconciliationRow.Fields || (LabelReconciliationRow.Fields = {}));
            [
                'LabelRecId',
                'BatchId',
                'MachineId',
                'LabelRollId',
                'RejectedLabels',
                'LabelLost',
                'NoLabelOnRoll',
                'LabelBalance',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'BatchBatchName',
                'BatchPackId',
                'BatchBatchStartDateTime',
                'BatchBatchVersion',
                'BatchBatchEndDateTime',
                'BatchMachineLineId',
                'BatchBatchStatus',
                'BatchBatchSize',
                'BatchBatchFor',
                'BatchNumberOfBottles',
                'BatchTotalGoodBottles',
                'BatchTotalRejectedBottles',
                'BatchProductionSpeed',
                'BatchExpiryDate',
                'BatchStatusId',
                'BatchCreatedBy',
                'BatchCreatedDate',
                'BatchUpdatedBy',
                'BatchUpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate',
                'LabelRollBatchId',
                'LabelRollMachineId',
                'LabelRollLabelRollNumber',
                'LabelRollNumberOfLabels',
                'LabelRollRemark',
                'LabelRollStatusId',
                'LabelRollCreatedBy',
                'LabelRollCreatedDate',
                'LabelRollUpdatedBy',
                'LabelRollUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(LabelReconciliationRow = Batch.LabelReconciliationRow || (Batch.LabelReconciliationRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelReconciliationService;
        (function (LabelReconciliationService) {
            LabelReconciliationService.baseUrl = 'Batch/LabelReconciliation';
            var Methods;
            (function (Methods) {
            })(Methods = LabelReconciliationService.Methods || (LabelReconciliationService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                LabelReconciliationService[x] = function (r, s, o) {
                    return Q.serviceRequest(LabelReconciliationService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = LabelReconciliationService.baseUrl + '/' + x;
            });
        })(LabelReconciliationService = Batch.LabelReconciliationService || (Batch.LabelReconciliationService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelRollForm = /** @class */ (function (_super) {
            __extends(LabelRollForm, _super);
            function LabelRollForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            LabelRollForm.formKey = 'Batch.LabelRoll';
            return LabelRollForm;
        }(Serenity.PrefixedContext));
        Batch.LabelRollForm = LabelRollForm;
        [,
            ['BatchId', function () { return Serenity.IntegerEditor; }],
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['LabelRollNumber', function () { return Serenity.IntegerEditor; }],
            ['NumberOfLabels', function () { return Serenity.IntegerEditor; }],
            ['Remark', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(LabelRollForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelRollRow;
        (function (LabelRollRow) {
            LabelRollRow.idProperty = 'LabelRollId';
            LabelRollRow.nameProperty = 'Remark';
            LabelRollRow.localTextPrefix = 'Batch.LabelRoll';
            var Fields;
            (function (Fields) {
            })(Fields = LabelRollRow.Fields || (LabelRollRow.Fields = {}));
            [
                'LabelRollId',
                'BatchId',
                'MachineId',
                'LabelRollNumber',
                'NumberOfLabels',
                'Remark',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(LabelRollRow = Batch.LabelRollRow || (Batch.LabelRollRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var LabelRollService;
        (function (LabelRollService) {
            LabelRollService.baseUrl = 'Batch/LabelRoll';
            var Methods;
            (function (Methods) {
            })(Methods = LabelRollService.Methods || (LabelRollService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                LabelRollService[x] = function (r, s, o) {
                    return Q.serviceRequest(LabelRollService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = LabelRollService.baseUrl + '/' + x;
            });
        })(LabelRollService = Batch.LabelRollService || (Batch.LabelRollService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var UserPreferenceRow;
        (function (UserPreferenceRow) {
            UserPreferenceRow.idProperty = 'UserPreferenceId';
            UserPreferenceRow.nameProperty = 'Name';
            UserPreferenceRow.localTextPrefix = 'Common.UserPreference';
            var Fields;
            (function (Fields) {
            })(Fields = UserPreferenceRow.Fields || (UserPreferenceRow.Fields = {}));
            [
                'UserPreferenceId',
                'UserId',
                'PreferenceType',
                'Name',
                'Value'
            ].forEach(function (x) { return Fields[x] = x; });
        })(UserPreferenceRow = Common.UserPreferenceRow || (Common.UserPreferenceRow = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var UserPreferenceService;
        (function (UserPreferenceService) {
            UserPreferenceService.baseUrl = 'Common/UserPreference';
            var Methods;
            (function (Methods) {
            })(Methods = UserPreferenceService.Methods || (UserPreferenceService.Methods = {}));
            [
                'Update',
                'Retrieve'
            ].forEach(function (x) {
                UserPreferenceService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserPreferenceService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = UserPreferenceService.baseUrl + '/' + x;
            });
        })(UserPreferenceService = Common.UserPreferenceService || (Common.UserPreferenceService = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CityDetailsForm = /** @class */ (function (_super) {
            __extends(CityDetailsForm, _super);
            function CityDetailsForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            CityDetailsForm.formKey = 'Configuration.CityDetails';
            return CityDetailsForm;
        }(Serenity.PrefixedContext));
        Configuration.CityDetailsForm = CityDetailsForm;
        [,
            ['Country', function () { return Serenity.StringEditor; }],
            ['State', function () { return Serenity.StringEditor; }],
            ['City', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(CityDetailsForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CityDetailsRow;
        (function (CityDetailsRow) {
            CityDetailsRow.idProperty = 'CityDetailsId';
            CityDetailsRow.nameProperty = 'Country';
            CityDetailsRow.localTextPrefix = 'Configuration.CityDetails';
            var Fields;
            (function (Fields) {
            })(Fields = CityDetailsRow.Fields || (CityDetailsRow.Fields = {}));
            [
                'CityDetailsId',
                'Country',
                'State',
                'City',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(CityDetailsRow = Configuration.CityDetailsRow || (Configuration.CityDetailsRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CityDetailsService;
        (function (CityDetailsService) {
            CityDetailsService.baseUrl = 'Configuration/CityDetails';
            var Methods;
            (function (Methods) {
            })(Methods = CityDetailsService.Methods || (CityDetailsService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                CityDetailsService[x] = function (r, s, o) {
                    return Q.serviceRequest(CityDetailsService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = CityDetailsService.baseUrl + '/' + x;
            });
        })(CityDetailsService = Configuration.CityDetailsService || (Configuration.CityDetailsService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CompanyForm = /** @class */ (function (_super) {
            __extends(CompanyForm, _super);
            function CompanyForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            CompanyForm.formKey = 'Configuration.Company';
            return CompanyForm;
        }(Serenity.PrefixedContext));
        Configuration.CompanyForm = CompanyForm;
        [,
            ['CompanyName', function () { return Serenity.StringEditor; }],
            ['Address', function () { return Serenity.StringEditor; }],
            ['CityId', function () { return Serenity.IntegerEditor; }],
            ['PinCode', function () { return Serenity.StringEditor; }],
            ['Website', function () { return Serenity.StringEditor; }],
            ['CompanyLogo', function () { return Serenity.StringEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(CompanyForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CompanyRow;
        (function (CompanyRow) {
            CompanyRow.idProperty = 'CompanyId';
            CompanyRow.nameProperty = 'CompanyName';
            CompanyRow.localTextPrefix = 'Configuration.Company';
            var Fields;
            (function (Fields) {
            })(Fields = CompanyRow.Fields || (CompanyRow.Fields = {}));
            [
                'CompanyId',
                'CompanyName',
                'Address',
                'CityId',
                'PinCode',
                'Website',
                'CompanyLogo',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'CityCountry',
                'CityState',
                'City',
                'CityStatusId',
                'CityCreatedBy',
                'CityCreatedDate',
                'CityUpdatedBy',
                'CityUpdatedDate',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(CompanyRow = Configuration.CompanyRow || (Configuration.CompanyRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CompanyService;
        (function (CompanyService) {
            CompanyService.baseUrl = 'Configuration/Company';
            var Methods;
            (function (Methods) {
            })(Methods = CompanyService.Methods || (CompanyService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                CompanyService[x] = function (r, s, o) {
                    return Q.serviceRequest(CompanyService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = CompanyService.baseUrl + '/' + x;
            });
        })(CompanyService = Configuration.CompanyService || (Configuration.CompanyService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CurrencyForm = /** @class */ (function (_super) {
            __extends(CurrencyForm, _super);
            function CurrencyForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            CurrencyForm.formKey = 'Configuration.Currency';
            return CurrencyForm;
        }(Serenity.PrefixedContext));
        Configuration.CurrencyForm = CurrencyForm;
        [,
            ['CountryName', function () { return Serenity.StringEditor; }],
            ['CurrencyType', function () { return Serenity.StringEditor; }],
            ['Symbol', function () { return Serenity.StringEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(CurrencyForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CurrencyRow;
        (function (CurrencyRow) {
            CurrencyRow.idProperty = 'CurrencyId';
            CurrencyRow.nameProperty = 'CountryName';
            CurrencyRow.localTextPrefix = 'Configuration.Currency';
            var Fields;
            (function (Fields) {
            })(Fields = CurrencyRow.Fields || (CurrencyRow.Fields = {}));
            [
                'CurrencyId',
                'CountryName',
                'CurrencyType',
                'Symbol',
                'Description',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate',
                'CreatedByFullName'
            ].forEach(function (x) { return Fields[x] = x; });
        })(CurrencyRow = Configuration.CurrencyRow || (Configuration.CurrencyRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CurrencyService;
        (function (CurrencyService) {
            CurrencyService.baseUrl = 'Configuration/Currency';
            var Methods;
            (function (Methods) {
            })(Methods = CurrencyService.Methods || (CurrencyService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                CurrencyService[x] = function (r, s, o) {
                    return Q.serviceRequest(CurrencyService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = CurrencyService.baseUrl + '/' + x;
            });
        })(CurrencyService = Configuration.CurrencyService || (Configuration.CurrencyService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DepartmentForm = /** @class */ (function (_super) {
            __extends(DepartmentForm, _super);
            function DepartmentForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            DepartmentForm.formKey = 'Configuration.Department';
            return DepartmentForm;
        }(Serenity.PrefixedContext));
        Configuration.DepartmentForm = DepartmentForm;
        [,
            ['DepartmentCode', function () { return Serenity.StringEditor; }],
            ['DepartmentName', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(DepartmentForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DepartmentRow;
        (function (DepartmentRow) {
            DepartmentRow.idProperty = 'DepartmentId';
            DepartmentRow.nameProperty = 'DepartmentCode';
            DepartmentRow.localTextPrefix = 'Configuration.Department';
            var Fields;
            (function (Fields) {
            })(Fields = DepartmentRow.Fields || (DepartmentRow.Fields = {}));
            [
                'DepartmentId',
                'DepartmentCode',
                'DepartmentName',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(DepartmentRow = Configuration.DepartmentRow || (Configuration.DepartmentRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DepartmentService;
        (function (DepartmentService) {
            DepartmentService.baseUrl = 'Configuration/Department';
            var Methods;
            (function (Methods) {
            })(Methods = DepartmentService.Methods || (DepartmentService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                DepartmentService[x] = function (r, s, o) {
                    return Q.serviceRequest(DepartmentService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = DepartmentService.baseUrl + '/' + x;
            });
        })(DepartmentService = Configuration.DepartmentService || (Configuration.DepartmentService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var EnvironmentVariablesForm = /** @class */ (function (_super) {
            __extends(EnvironmentVariablesForm, _super);
            function EnvironmentVariablesForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            EnvironmentVariablesForm.formKey = 'Configuration.EnvironmentVariables';
            return EnvironmentVariablesForm;
        }(Serenity.PrefixedContext));
        Configuration.EnvironmentVariablesForm = EnvironmentVariablesForm;
        [,
            ['ReportLocation', function () { return Serenity.StringEditor; }],
            ['BackupFolder', function () { return Serenity.StringEditor; }],
            ['BackupFrequencyNoOfDaya', function () { return Serenity.IntegerEditor; }],
            ['TimeZoneId', function () { return Serenity.StringEditor; }],
            ['TimeZoneName', function () { return Serenity.StringEditor; }],
            ['ScreenTimeOut', function () { return Serenity.IntegerEditor; }],
            ['IsPasswordChangeRequired', function () { return Serenity.IntegerEditor; }],
            ['PasswordMinLength', function () { return Serenity.IntegerEditor; }],
            ['PasswordMaxLength', function () { return Serenity.IntegerEditor; }],
            ['MinAlphaChars', function () { return Serenity.IntegerEditor; }],
            ['MinNumericChars', function () { return Serenity.IntegerEditor; }],
            ['MinSpecialChars', function () { return Serenity.IntegerEditor; }],
            ['PasswordExpiryInDays', function () { return Serenity.IntegerEditor; }],
            ['CurrencyId', function () { return Serenity.IntegerEditor; }],
            ['LanguageId', function () { return Serenity.IntegerEditor; }],
            ['SessionTimeOut', function () { return Serenity.IntegerEditor; }],
            ['DateTimeFormat', function () { return Serenity.StringEditor; }],
            ['NumberFormat', function () { return Serenity.StringEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }],
            ['UnLockTime', function () { return Serenity.IntegerEditor; }],
            ['IsUnLockAfterTime', function () { return Serenity.BooleanEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(EnvironmentVariablesForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var EnvironmentVariablesRow;
        (function (EnvironmentVariablesRow) {
            EnvironmentVariablesRow.idProperty = 'EnvVariableId';
            EnvironmentVariablesRow.nameProperty = 'ReportLocation';
            EnvironmentVariablesRow.localTextPrefix = 'Configuration.EnvironmentVariables';
            var Fields;
            (function (Fields) {
            })(Fields = EnvironmentVariablesRow.Fields || (EnvironmentVariablesRow.Fields = {}));
            [
                'EnvVariableId',
                'ReportLocation',
                'BackupFolder',
                'BackupFrequencyNoOfDaya',
                'TimeZoneId',
                'TimeZoneName',
                'ScreenTimeOut',
                'IsPasswordChangeRequired',
                'PasswordMinLength',
                'PasswordMaxLength',
                'MinAlphaChars',
                'MinNumericChars',
                'MinSpecialChars',
                'PasswordExpiryInDays',
                'CurrencyId',
                'LanguageId',
                'SessionTimeOut',
                'DateTimeFormat',
                'NumberFormat',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(EnvironmentVariablesRow = Configuration.EnvironmentVariablesRow || (Configuration.EnvironmentVariablesRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var EnvironmentVariablesService;
        (function (EnvironmentVariablesService) {
            EnvironmentVariablesService.baseUrl = 'Configuration/EnvironmentVariables';
            var Methods;
            (function (Methods) {
            })(Methods = EnvironmentVariablesService.Methods || (EnvironmentVariablesService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                EnvironmentVariablesService[x] = function (r, s, o) {
                    return Q.serviceRequest(EnvironmentVariablesService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = EnvironmentVariablesService.baseUrl + '/' + x;
            });
        })(EnvironmentVariablesService = Configuration.EnvironmentVariablesService || (Configuration.EnvironmentVariablesService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListForm = /** @class */ (function (_super) {
            __extends(PickListForm, _super);
            function PickListForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            PickListForm.formKey = 'Configuration.PickList';
            return PickListForm;
        }(Serenity.PrefixedContext));
        Configuration.PickListForm = PickListForm;
        [,
            ['PickListName', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(PickListForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListRow;
        (function (PickListRow) {
            PickListRow.idProperty = 'PickListId';
            PickListRow.nameProperty = 'PickListName';
            PickListRow.localTextPrefix = 'Configuration.PickList';
            var Fields;
            (function (Fields) {
            })(Fields = PickListRow.Fields || (PickListRow.Fields = {}));
            [
                'PickListId',
                'PickListName',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(PickListRow = Configuration.PickListRow || (Configuration.PickListRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListService;
        (function (PickListService) {
            PickListService.baseUrl = 'Configuration/PickList';
            var Methods;
            (function (Methods) {
            })(Methods = PickListService.Methods || (PickListService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                PickListService[x] = function (r, s, o) {
                    return Q.serviceRequest(PickListService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = PickListService.baseUrl + '/' + x;
            });
        })(PickListService = Configuration.PickListService || (Configuration.PickListService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueForm = /** @class */ (function (_super) {
            __extends(PickListValueForm, _super);
            function PickListValueForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            PickListValueForm.formKey = 'Configuration.PickListValue';
            return PickListValueForm;
        }(Serenity.PrefixedContext));
        Configuration.PickListValueForm = PickListValueForm;
        [,
            ['PickListId', function () { return Serenity.IntegerEditor; }],
            ['PickListValueName', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(PickListValueForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueRoleAccessForm = /** @class */ (function (_super) {
            __extends(PickListValueRoleAccessForm, _super);
            function PickListValueRoleAccessForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            PickListValueRoleAccessForm.formKey = 'Configuration.PickListValueRoleAccess';
            return PickListValueRoleAccessForm;
        }(Serenity.PrefixedContext));
        Configuration.PickListValueRoleAccessForm = PickListValueRoleAccessForm;
        [,
            ['PickListValueId', function () { return Serenity.IntegerEditor; }],
            ['RoleId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(PickListValueRoleAccessForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueRoleAccessRow;
        (function (PickListValueRoleAccessRow) {
            PickListValueRoleAccessRow.idProperty = 'PickListValueRoleAccessId';
            PickListValueRoleAccessRow.localTextPrefix = 'Configuration.PickListValueRoleAccess';
            var Fields;
            (function (Fields) {
            })(Fields = PickListValueRoleAccessRow.Fields || (PickListValueRoleAccessRow.Fields = {}));
            [
                'PickListValueRoleAccessId',
                'PickListValueId',
                'RoleId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'PickListValuePickListId',
                'PickListValuePickListValueName',
                'PickListValueStatusId',
                'PickListValueCreatedBy',
                'PickListValueCreatedDate',
                'PickListValueUpdatedBy',
                'PickListValueUpdatedDate',
                'RoleRoleName',
                'RoleStatusId',
                'RoleIsHidden',
                'RoleParentRoleId',
                'RoleCreatedBy',
                'RoleCreatedDate',
                'RoleUpdatedBy',
                'RoleUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(PickListValueRoleAccessRow = Configuration.PickListValueRoleAccessRow || (Configuration.PickListValueRoleAccessRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueRoleAccessService;
        (function (PickListValueRoleAccessService) {
            PickListValueRoleAccessService.baseUrl = 'Configuration/PickListValueRoleAccess';
            var Methods;
            (function (Methods) {
            })(Methods = PickListValueRoleAccessService.Methods || (PickListValueRoleAccessService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                PickListValueRoleAccessService[x] = function (r, s, o) {
                    return Q.serviceRequest(PickListValueRoleAccessService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = PickListValueRoleAccessService.baseUrl + '/' + x;
            });
        })(PickListValueRoleAccessService = Configuration.PickListValueRoleAccessService || (Configuration.PickListValueRoleAccessService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueRow;
        (function (PickListValueRow) {
            PickListValueRow.idProperty = 'PickListValueId';
            PickListValueRow.nameProperty = 'PickListValueName';
            PickListValueRow.localTextPrefix = 'Configuration.PickListValue';
            var Fields;
            (function (Fields) {
            })(Fields = PickListValueRow.Fields || (PickListValueRow.Fields = {}));
            [
                'PickListValueId',
                'PickListId',
                'PickListValueName',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(PickListValueRow = Configuration.PickListValueRow || (Configuration.PickListValueRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueService;
        (function (PickListValueService) {
            PickListValueService.baseUrl = 'Configuration/PickListValue';
            var Methods;
            (function (Methods) {
            })(Methods = PickListValueService.Methods || (PickListValueService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                PickListValueService[x] = function (r, s, o) {
                    return Q.serviceRequest(PickListValueService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = PickListValueService.baseUrl + '/' + x;
            });
        })(PickListValueService = Configuration.PickListValueService || (Configuration.PickListValueService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var ShiftForm = /** @class */ (function (_super) {
            __extends(ShiftForm, _super);
            function ShiftForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ShiftForm.formKey = 'Configuration.Shift';
            return ShiftForm;
        }(Serenity.PrefixedContext));
        Configuration.ShiftForm = ShiftForm;
        [,
            ['ShiftName', function () { return Serenity.StringEditor; }],
            ['StartTime', function () { return Serenity.StringEditor; }],
            ['EndTime', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(ShiftForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var ShiftRow;
        (function (ShiftRow) {
            ShiftRow.idProperty = 'ShiftId';
            ShiftRow.nameProperty = 'ShiftName';
            ShiftRow.localTextPrefix = 'Configuration.Shift';
            var Fields;
            (function (Fields) {
            })(Fields = ShiftRow.Fields || (ShiftRow.Fields = {}));
            [
                'ShiftId',
                'ShiftName',
                'StartTime',
                'EndTime',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName'
            ].forEach(function (x) { return Fields[x] = x; });
        })(ShiftRow = Configuration.ShiftRow || (Configuration.ShiftRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var ShiftService;
        (function (ShiftService) {
            ShiftService.baseUrl = 'Configuration/Shift';
            var Methods;
            (function (Methods) {
            })(Methods = ShiftService.Methods || (ShiftService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ShiftService[x] = function (r, s, o) {
                    return Q.serviceRequest(ShiftService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = ShiftService.baseUrl + '/' + x;
            });
        })(ShiftService = Configuration.ShiftService || (Configuration.ShiftService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var StatusForm = /** @class */ (function (_super) {
            __extends(StatusForm, _super);
            function StatusForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            StatusForm.formKey = 'Configuration.Status';
            return StatusForm;
        }(Serenity.PrefixedContext));
        Configuration.StatusForm = StatusForm;
        [,
            ['StatusName', function () { return Serenity.StringEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(StatusForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var StatusRow;
        (function (StatusRow) {
            StatusRow.idProperty = 'StatusId';
            StatusRow.nameProperty = 'StatusName';
            StatusRow.localTextPrefix = 'Configuration.Status';
            var Fields;
            (function (Fields) {
            })(Fields = StatusRow.Fields || (StatusRow.Fields = {}));
            [
                'StatusId',
                'StatusName'
            ].forEach(function (x) { return Fields[x] = x; });
        })(StatusRow = Configuration.StatusRow || (Configuration.StatusRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var StatusService;
        (function (StatusService) {
            StatusService.baseUrl = 'Configuration/Status';
            var Methods;
            (function (Methods) {
            })(Methods = StatusService.Methods || (StatusService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                StatusService[x] = function (r, s, o) {
                    return Q.serviceRequest(StatusService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = StatusService.baseUrl + '/' + x;
            });
        })(StatusService = Configuration.StatusService || (Configuration.StatusService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var SupplierForm = /** @class */ (function (_super) {
            __extends(SupplierForm, _super);
            function SupplierForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            SupplierForm.formKey = 'Configuration.Supplier';
            return SupplierForm;
        }(Serenity.PrefixedContext));
        Configuration.SupplierForm = SupplierForm;
        [,
            ['SupplierName', function () { return Serenity.StringEditor; }],
            ['SupplierAddress', function () { return Serenity.StringEditor; }],
            ['CityCountry', function () { return Serenity.StringEditor; }],
            ['CityId', function () { return Serenity.IntegerEditor; }],
            ['PinCode', function () { return Serenity.StringEditor; }],
            ['MobileCode', function () { return Serenity.IntegerEditor; }],
            ['MobileNumber', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(SupplierForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var SupplierRow;
        (function (SupplierRow) {
            SupplierRow.idProperty = 'SupplierId';
            SupplierRow.nameProperty = 'SupplierName';
            SupplierRow.localTextPrefix = 'Configuration.Supplier';
            var Fields;
            (function (Fields) {
            })(Fields = SupplierRow.Fields || (SupplierRow.Fields = {}));
            [
                'SupplierId',
                'SupplierName',
                'SupplierAddress',
                'CityId',
                'PinCode',
                'MobileCode',
                'MobileNumber',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CityCountry',
                'CityState',
                'City',
                'CityStatusId',
                'CityCreatedBy',
                'CityCreatedDate',
                'CityUpdatedBy',
                'CityUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(SupplierRow = Configuration.SupplierRow || (Configuration.SupplierRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var SupplierService;
        (function (SupplierService) {
            SupplierService.baseUrl = 'Configuration/Supplier';
            var Methods;
            (function (Methods) {
            })(Methods = SupplierService.Methods || (SupplierService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                SupplierService[x] = function (r, s, o) {
                    return Q.serviceRequest(SupplierService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = SupplierService.baseUrl + '/' + x;
            });
        })(SupplierService = Configuration.SupplierService || (Configuration.SupplierService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var IpcParameterForm = /** @class */ (function (_super) {
            __extends(IpcParameterForm, _super);
            function IpcParameterForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            IpcParameterForm.formKey = 'ExternalApplicationInterface.IpcParameter';
            return IpcParameterForm;
        }(Serenity.PrefixedContext));
        ExternalApplicationInterface.IpcParameterForm = IpcParameterForm;
        [,
            ['MachineId', function () { return Serenity.LookupEditor; }],
            ['IpcParameterName', function () { return Serenity.StringEditor; }],
            ['MachineParameterId', function () { return Serenity.IntegerEditor; }],
            ['IpcAddress', function () { return Serenity.StringEditor; }],
            ['IsChangeInRuntime', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }],
            ['IsBitWise', function () { return Serenity.BooleanEditor; }],
            ['BitWiseIndex', function () { return Serenity.IntegerEditor; }],
            ['Is32Bit', function () { return Serenity.BooleanEditor; }],
            ['Bit32Address', function () { return Serenity.StringEditor; }],
            ['IsWordSwap', function () { return Serenity.BooleanEditor; }],
            ['IsByteSwap', function () { return Serenity.BooleanEditor; }],
        ].forEach(function (x) {
            return Object.defineProperty(IpcParameterForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var IpcParameterRow;
        (function (IpcParameterRow) {
            IpcParameterRow.idProperty = 'IpcParameterId';
            IpcParameterRow.nameProperty = 'IpcParameterName';
            IpcParameterRow.localTextPrefix = 'ExternalApplicationInterface.IpcParameter';
            var Fields;
            (function (Fields) {
            })(Fields = IpcParameterRow.Fields || (IpcParameterRow.Fields = {}));
            [
                'IpcParameterId',
                'MachineId',
                'IpcParameterName',
                'MachineParameterId',
                'IpcAddress',
                'IsChangeInRuntime',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(IpcParameterRow = ExternalApplicationInterface.IpcParameterRow || (ExternalApplicationInterface.IpcParameterRow = {}));
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var IpcParameterService;
        (function (IpcParameterService) {
            IpcParameterService.baseUrl = 'ExternalApplicationInterface/IpcParameter';
            var Methods;
            (function (Methods) {
            })(Methods = IpcParameterService.Methods || (IpcParameterService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                IpcParameterService[x] = function (r, s, o) {
                    return Q.serviceRequest(IpcParameterService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = IpcParameterService.baseUrl + '/' + x;
            });
        })(IpcParameterService = ExternalApplicationInterface.IpcParameterService || (ExternalApplicationInterface.IpcParameterService = {}));
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var MachineCommunicationForm = /** @class */ (function (_super) {
            __extends(MachineCommunicationForm, _super);
            function MachineCommunicationForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineCommunicationForm.formKey = 'ExternalApplicationInterface.MachineCommunication';



            return MachineCommunicationForm;
        }(Serenity.PrefixedContext));
        ExternalApplicationInterface.MachineCommunicationForm = MachineCommunicationForm;
        [,
            ['ProtocolTypeId', function () { return Serenity.LookupEditor; }],
            ['MachineId', function () { return Serenity.LookupEditor; }],
            ['IpAddress', function () { return Serenity.StringEditor; }],
            ['TcpipPort', function () { return Serenity.IntegerEditor; }],
            ['PollRate', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }],
            ['MDBPath', function () { return Serenity.StringEditor; }],
            ['SecurityModeId', function () { return Serenity.LookupEditor; }],
            ['SecurityPolicyId', function () { return Serenity.LookupEditor; }],
            ['UserIdentityId', function () { return Serenity.LookupEditor; }],
            ['UserName', function () { return Serenity.StringEditor; }],
            ['Password', function () { return Serenity.StringEditor; }],
            ['CpuTypeId', function () { return Serenity.LookupEditor; }],
            ['Rack', function () { return Serenity.IntegerEditor; }],
            ['Slot', function () { return Serenity.IntegerEditor; }],




        ].forEach(function (x) {
            return Object.defineProperty(MachineCommunicationForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var MachineCommunicationRow;
        (function (MachineCommunicationRow) {
            MachineCommunicationRow.idProperty = 'MachineCommunicatonId';
            MachineCommunicationRow.nameProperty = 'IpAddress';
            MachineCommunicationRow.localTextPrefix = 'ExternalApplicationInterface.MachineCommunication';
            var Fields;
            (function (Fields) {
            })(Fields = MachineCommunicationRow.Fields || (MachineCommunicationRow.Fields = {}));
            [
                'MachineCommunicatonId',
                'ProtocolTypeId',
                'MachineId',
                'IpAddress',
                'TcpipPort',
                'PollRate',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineCommunicationRow = ExternalApplicationInterface.MachineCommunicationRow || (ExternalApplicationInterface.MachineCommunicationRow = {}));
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var MachineCommunicationService;
        (function (MachineCommunicationService) {
            MachineCommunicationService.baseUrl = 'ExternalApplicationInterface/MachineCommunication';
            var Methods;
            (function (Methods) {
            })(Methods = MachineCommunicationService.Methods || (MachineCommunicationService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineCommunicationService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineCommunicationService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineCommunicationService.baseUrl + '/' + x;
            });
        })(MachineCommunicationService = ExternalApplicationInterface.MachineCommunicationService || (ExternalApplicationInterface.MachineCommunicationService = {}));
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var ProtocolForm = /** @class */ (function (_super) {
            __extends(ProtocolForm, _super);
            function ProtocolForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ProtocolForm.formKey = 'ExternalApplicationInterface.Protocol';
            return ProtocolForm;
        }(Serenity.PrefixedContext));
        ExternalApplicationInterface.ProtocolForm = ProtocolForm;
        [,
            ['ProtocolName', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(ProtocolForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var ProtocolRow;
        (function (ProtocolRow) {
            ProtocolRow.idProperty = 'ProtocolId';
            ProtocolRow.nameProperty = 'ProtocolName';
            ProtocolRow.localTextPrefix = 'ExternalApplicationInterface.Protocol';
            var Fields;
            (function (Fields) {
            })(Fields = ProtocolRow.Fields || (ProtocolRow.Fields = {}));
            [
                'ProtocolId',
                'ProtocolName',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(ProtocolRow = ExternalApplicationInterface.ProtocolRow || (ExternalApplicationInterface.ProtocolRow = {}));
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var ProtocolService;
        (function (ProtocolService) {
            ProtocolService.baseUrl = 'ExternalApplicationInterface/Protocol';
            var Methods;
            (function (Methods) {
            })(Methods = ProtocolService.Methods || (ProtocolService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ProtocolService[x] = function (r, s, o) {
                    return Q.serviceRequest(ProtocolService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = ProtocolService.baseUrl + '/' + x;
            });
        })(ProtocolService = ExternalApplicationInterface.ProtocolService || (ExternalApplicationInterface.ProtocolService = {}));
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmForm = /** @class */ (function (_super) {
            __extends(AlarmForm, _super);
            function AlarmForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            AlarmForm.formKey = 'MachineCustomization.Alarm';
            return AlarmForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.AlarmForm = AlarmForm;
        [,
            ['AlarmName', function () { return Serenity.StringEditor; }],
            ['MachineId', function () { return Serenity.LookupEditor; }],
           // ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['IpcParameterId', function () { return Serenity.IntegerEditor; }],
            ['Message', function () { return Serenity.StringEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['IsResetRequired', function () { return Serenity.BooleanEditor; }],
            ['IsCommentRequired', function () { return Serenity.BooleanEditor; }],
            ['IsMachineRequiredToStop', function () { return Serenity.BooleanEditor; }],
            ['MachineStopIpcParameterId', function () { return Serenity.IntegerEditor; }],
            ['IsCountForReject', function () { return Serenity.BooleanEditor; }],
            ['BitValue', function () { return Serenity.BooleanEditor; }],
            ['IsCheckAtMachineStart', function () { return Serenity.BooleanEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(AlarmForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmResetIdForm = /** @class */ (function (_super) {
            __extends(AlarmResetIdForm, _super);
            function AlarmResetIdForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            AlarmResetIdForm.formKey = 'MachineCustomization.AlarmResetId';
            return AlarmResetIdForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.AlarmResetIdForm = AlarmResetIdForm;
        [,
            ['AlarmId', function () { return Serenity.IntegerEditor; }],
            ['RoleId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(AlarmResetIdForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmResetIdRow;
        (function (AlarmResetIdRow) {
            AlarmResetIdRow.idProperty = 'AlarmResetRoleId';
            AlarmResetIdRow.localTextPrefix = 'MachineCustomization.AlarmResetId';
            var Fields;
            (function (Fields) {
            })(Fields = AlarmResetIdRow.Fields || (AlarmResetIdRow.Fields = {}));
            [
                'AlarmResetRoleId',
                'AlarmId',
                'RoleId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(AlarmResetIdRow = MachineCustomization.AlarmResetIdRow || (MachineCustomization.AlarmResetIdRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmResetIdService;
        (function (AlarmResetIdService) {
            AlarmResetIdService.baseUrl = 'MachineCustomization/AlarmResetId';
            var Methods;
            (function (Methods) {
            })(Methods = AlarmResetIdService.Methods || (AlarmResetIdService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AlarmResetIdService[x] = function (r, s, o) {
                    return Q.serviceRequest(AlarmResetIdService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = AlarmResetIdService.baseUrl + '/' + x;
            });
        })(AlarmResetIdService = MachineCustomization.AlarmResetIdService || (MachineCustomization.AlarmResetIdService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmRow;
        (function (AlarmRow) {
            AlarmRow.idProperty = 'AlarmId';
            AlarmRow.nameProperty = 'AlarmName';
            AlarmRow.localTextPrefix = 'MachineCustomization.Alarm';
            var Fields;
            (function (Fields) {
            })(Fields = AlarmRow.Fields || (AlarmRow.Fields = {}));
            [
                'AlarmId',
                'AlarmName',
                'MachineId',
                'IpcParameterId',
                'Message',
                'Description',
                'IsResetRequired',
                'IsCommentRequired',
                'IsMachineRequiredToStop',
                'MachineStopIpcParameterId',
                'IsCountForReject',
                'BitValue',
                'IsCheckAtMachineStart',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'MachineStopIpcParameterMachineId',
                'MachineStopIpcParameterIpcParameterName',
                'MachineStopIpcParameterMachineParameterId',
                'MachineStopIpcParameterIpcAddress',
                'MachineStopIpcParameterIsChangeInRuntime',
                'MachineStopIpcParameterStatusId',
                'MachineStopIpcParameterCreatedBy',
                'MachineStopIpcParameterCreatedDate',
                'MachineStopIpcParameterUpdatedBy',
                'MachineStopIpcParameterUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByBirthDate',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByBirthDate',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(AlarmRow = MachineCustomization.AlarmRow || (MachineCustomization.AlarmRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmService;
        (function (AlarmService) {
            AlarmService.baseUrl = 'MachineCustomization/Alarm';
            var Methods;
            (function (Methods) {
            })(Methods = AlarmService.Methods || (AlarmService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AlarmService[x] = function (r, s, o) {
                    return Q.serviceRequest(AlarmService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = AlarmService.baseUrl + '/' + x;
            });
        })(AlarmService = MachineCustomization.AlarmService || (MachineCustomization.AlarmService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DataTypeForm = /** @class */ (function (_super) {
            __extends(DataTypeForm, _super);
            function DataTypeForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            DataTypeForm.formKey = 'Configuration.DataType';
            return DataTypeForm;
        }(Serenity.PrefixedContext));
        Configuration.DataTypeForm = DataTypeForm;
        [,
            ['DataTypeName', function () { return Serenity.StringEditor; }],
            ['TypeId', function () { return Serenity.IntegerEditor; }],
            ['Bit', function () { return Serenity.IntegerEditor; }],
            ['IsSigned', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(DataTypeForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DataTypeRow;
        (function (DataTypeRow) {
            DataTypeRow.idProperty = 'DataTypeId';
            DataTypeRow.nameProperty = 'DataTypeName';
            DataTypeRow.localTextPrefix = 'Configuration.DataType';
            var Fields;
            (function (Fields) {
            })(Fields = DataTypeRow.Fields || (DataTypeRow.Fields = {}));
            [
                'DataTypeId',
                'DataTypeName',
                'TypeId',
                'Bit',
                'IsSigned',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(DataTypeRow = Configuration.DataTypeRow || (Configuration.DataTypeRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DataTypeService;
        (function (DataTypeService) {
            DataTypeService.baseUrl = 'Configuration/DataType';
            var Methods;
            (function (Methods) {
            })(Methods = DataTypeService.Methods || (DataTypeService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                DataTypeService[x] = function (r, s, o) {
                    return Q.serviceRequest(DataTypeService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = DataTypeService.baseUrl + '/' + x;
            });
        })(DataTypeService = Configuration.DataTypeService || (Configuration.DataTypeService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineMaintenanceScheduleForm = /** @class */ (function (_super) {
            __extends(LineMaintenanceScheduleForm, _super);
            function LineMaintenanceScheduleForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            LineMaintenanceScheduleForm.formKey = 'MachineCustomization.LineMaintenanceSchedule';
            return LineMaintenanceScheduleForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.LineMaintenanceScheduleForm = LineMaintenanceScheduleForm;
        [,
            ['MachineLineId', function () { return Serenity.IntegerEditor; }],
            ['StartDateTime', function () { return Serenity.DateEditor; }],
            ['EndDateTime', function () { return Serenity.DateEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['Remark', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(LineMaintenanceScheduleForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineMaintenanceScheduleRow;
        (function (LineMaintenanceScheduleRow) {
            LineMaintenanceScheduleRow.idProperty = 'LineMainSchId';
            LineMaintenanceScheduleRow.nameProperty = 'Description';
            LineMaintenanceScheduleRow.localTextPrefix = 'MachineCustomization.LineMaintenanceSchedule';
            var Fields;
            (function (Fields) {
            })(Fields = LineMaintenanceScheduleRow.Fields || (LineMaintenanceScheduleRow.Fields = {}));
            [
                'LineMainSchId',
                'MachineLineId',
                'StartDateTime',
                'EndDateTime',
                'Description',
                'Remark',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(LineMaintenanceScheduleRow = MachineCustomization.LineMaintenanceScheduleRow || (MachineCustomization.LineMaintenanceScheduleRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineMaintenanceScheduleService;
        (function (LineMaintenanceScheduleService) {
            LineMaintenanceScheduleService.baseUrl = 'MachineCustomization/LineMaintenanceSchedule';
            var Methods;
            (function (Methods) {
            })(Methods = LineMaintenanceScheduleService.Methods || (LineMaintenanceScheduleService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                LineMaintenanceScheduleService[x] = function (r, s, o) {
                    return Q.serviceRequest(LineMaintenanceScheduleService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = LineMaintenanceScheduleService.baseUrl + '/' + x;
            });
        })(LineMaintenanceScheduleService = MachineCustomization.LineMaintenanceScheduleService || (MachineCustomization.LineMaintenanceScheduleService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineForm = /** @class */ (function (_super) {
            __extends(MachineForm, _super);
            function MachineForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineForm.formKey = 'MachineCustomization.Machine';
            return MachineForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineForm = MachineForm;
        [,
            ['MachineLineId', function () { return Serenity.IntegerEditor; }],
            ['MachineName', function () { return Serenity.StringEditor; }],
            ['ModelNumber', function () { return Serenity.StringEditor; }],
            ['SerialNumber', function () { return Serenity.StringEditor; }],
            ['Make', function () { return Serenity.StringEditor; }],
            ['Year', function () { return Serenity.IntegerEditor; }],
            ['PlcMake', function () { return Serenity.StringEditor; }],
            ['PlcModelNumber', function () { return Serenity.StringEditor; }],
            ['PlcSerialNumber', function () { return Serenity.StringEditor; }],
            ['PlcAddress', function () { return Serenity.StringEditor; }],
            ['AccessIpAddress', function () { return Serenity.StringEditor; }],
            ['MachineSequence', function () { return Serenity.IntegerEditor; }],
            ['MachineImage', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }],
            ['IsRealTime', function () { return Serenity.BooleanEditor }],          // added by JSGURU manually
            ['TableId', function () { return Serenity.IntegerEditor }],             // added by JSGURU manually
            ['TableName', function () { return Serenity.StringEditor; }]            // added by JSGURU manually
        ].forEach(function (x) {
            return Object.defineProperty(MachineForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHelpFileForm = /** @class */ (function (_super) {
            __extends(MachineHelpFileForm, _super);
            function MachineHelpFileForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineHelpFileForm.formKey = 'MachineCustomization.MachineHelpFile';
            return MachineHelpFileForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineHelpFileForm = MachineHelpFileForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['FileName', function () { return Serenity.StringEditor; }],
            ['FileContent', function () { return Serenity.StringEditor; }],
            ['FileLength', function () { return Serenity.IntegerEditor; }],
            ['FileExtension', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineHelpFileForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHelpFileRow;
        (function (MachineHelpFileRow) {
            MachineHelpFileRow.idProperty = 'MachineHelpFileId';
            MachineHelpFileRow.nameProperty = 'FileName';
            MachineHelpFileRow.localTextPrefix = 'MachineCustomization.MachineHelpFile';
            var Fields;
            (function (Fields) {
            })(Fields = MachineHelpFileRow.Fields || (MachineHelpFileRow.Fields = {}));
            [
                'MachineHelpFileId',
                'MachineId',
                'FileName',
                'FileContent',
                'FileLength',
                'FileExtension',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineHelpFileRow = MachineCustomization.MachineHelpFileRow || (MachineCustomization.MachineHelpFileRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHelpFileService;
        (function (MachineHelpFileService) {
            MachineHelpFileService.baseUrl = 'MachineCustomization/MachineHelpFile';
            var Methods;
            (function (Methods) {
            })(Methods = MachineHelpFileService.Methods || (MachineHelpFileService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineHelpFileService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineHelpFileService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineHelpFileService.baseUrl + '/' + x;
            });
        })(MachineHelpFileService = MachineCustomization.MachineHelpFileService || (MachineCustomization.MachineHelpFileService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHistoryForm = /** @class */ (function (_super) {
            __extends(MachineHistoryForm, _super);
            function MachineHistoryForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineHistoryForm.formKey = 'MachineCustomization.MachineHistory';
            return MachineHistoryForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineHistoryForm = MachineHistoryForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['IssueStartDate', function () { return Serenity.DateEditor; }],
            ['IssueCloseDate', function () { return Serenity.DateEditor; }],
            ['ProblemNatureId', function () { return Serenity.IntegerEditor; }],
            ['SparePartId', function () { return Serenity.IntegerEditor; }],
            ['ProblemDescription', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineHistoryForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHistoryRow;
        (function (MachineHistoryRow) {
            MachineHistoryRow.idProperty = 'MachineHistoryId';
            MachineHistoryRow.nameProperty = 'ProblemDescription';
            MachineHistoryRow.localTextPrefix = 'MachineCustomization.MachineHistory';
            var Fields;
            (function (Fields) {
            })(Fields = MachineHistoryRow.Fields || (MachineHistoryRow.Fields = {}));
            [
                'MachineHistoryId',
                'MachineId',
                'IssueStartDate',
                'IssueCloseDate',
                'ProblemNatureId',
                'SparePartId',
                'ProblemDescription',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate',
                'ProblemNaturePickListId',
                'ProblemNaturePickListValueName',
                'ProblemNatureStatusId',
                'ProblemNatureCreatedBy',
                'ProblemNatureCreatedDate',
                'ProblemNatureUpdatedBy',
                'ProblemNatureUpdatedDate',
                'SparePartMachineId',
                'SparePartPartNumber',
                'SparePartPartName',
                'SparePartPartDescription',
                'SparePartNoOfUnitsRequired',
                'SparePartPartImage',
                'SparePartStatusId',
                'SparePartCreatedBy',
                'SparePartCreatedDate',
                'SparePartUpdatedBy',
                'SparePartUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineHistoryRow = MachineCustomization.MachineHistoryRow || (MachineCustomization.MachineHistoryRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHistoryService;
        (function (MachineHistoryService) {
            MachineHistoryService.baseUrl = 'MachineCustomization/MachineHistory';
            var Methods;
            (function (Methods) {
            })(Methods = MachineHistoryService.Methods || (MachineHistoryService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineHistoryService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineHistoryService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineHistoryService.baseUrl + '/' + x;
            });
        })(MachineHistoryService = MachineCustomization.MachineHistoryService || (MachineCustomization.MachineHistoryService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineForm = /** @class */ (function (_super) {
            __extends(MachineLineForm, _super);
            function MachineLineForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineLineForm.formKey = 'MachineCustomization.MachineLine';
            return MachineLineForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineLineForm = MachineLineForm;
        [,
            ['LineName', function () { return Serenity.StringEditor; }],
            ['LineRatedSpeed', function () { return Serenity.StringEditor; }],
            ['NumberOfMachines', function () { return Serenity.IntegerEditor; }],
            ['InstalledDate', function () { return Serenity.DateEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineLineForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineRow;
        (function (MachineLineRow) {
            MachineLineRow.idProperty = 'MachineLineId';
            MachineLineRow.nameProperty = 'LineName';
            MachineLineRow.localTextPrefix = 'MachineCustomization.MachineLine';
            var Fields;
            (function (Fields) {
            })(Fields = MachineLineRow.Fields || (MachineLineRow.Fields = {}));
            [
                'MachineLineId',
                'LineName',
                'LineRatedSpeed',
                'NumberOfMachines',
                'InstalledDate',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate',
                'StatusStatusName'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineLineRow = MachineCustomization.MachineLineRow || (MachineCustomization.MachineLineRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineService;
        (function (MachineLineService) {
            MachineLineService.baseUrl = 'MachineCustomization/MachineLine';
            var Methods;
            (function (Methods) {
            })(Methods = MachineLineService.Methods || (MachineLineService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineLineService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineLineService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineLineService.baseUrl + '/' + x;
            });
        })(MachineLineService = MachineCustomization.MachineLineService || (MachineCustomization.MachineLineService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineUserForm = /** @class */ (function (_super) {
            __extends(MachineLineUserForm, _super);
            function MachineLineUserForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineLineUserForm.formKey = 'MachineCustomization.MachineLineUser';
            return MachineLineUserForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineLineUserForm = MachineLineUserForm;
        [,
            ['MachineLineId', function () { return Serenity.IntegerEditor; }],
            ['UserId', function () { return Serenity.IntegerEditor; }],
            ['ShiftId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineLineUserForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineUserRow;
        (function (MachineLineUserRow) {
            MachineLineUserRow.idProperty = 'MachineLineUserId';
            MachineLineUserRow.localTextPrefix = 'MachineCustomization.MachineLineUser';
            var Fields;
            (function (Fields) {
            })(Fields = MachineLineUserRow.Fields || (MachineLineUserRow.Fields = {}));
            [
                'MachineLineUserId',
                'MachineLineId',
                'UserId',
                'ShiftId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineLineUserRow = MachineCustomization.MachineLineUserRow || (MachineCustomization.MachineLineUserRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineUserService;
        (function (MachineLineUserService) {
            MachineLineUserService.baseUrl = 'MachineCustomization/MachineLineUser';
            var Methods;
            (function (Methods) {
            })(Methods = MachineLineUserService.Methods || (MachineLineUserService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineLineUserService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineLineUserService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineLineUserService.baseUrl + '/' + x;
            });
        })(MachineLineUserService = MachineCustomization.MachineLineUserService || (MachineCustomization.MachineLineUserService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineMaintenanceScheduleForm = /** @class */ (function (_super) {
            __extends(MachineMaintenanceScheduleForm, _super);
            function MachineMaintenanceScheduleForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineMaintenanceScheduleForm.formKey = 'MachineCustomization.MachineMaintenanceSchedule';
            return MachineMaintenanceScheduleForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineMaintenanceScheduleForm = MachineMaintenanceScheduleForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['StartDateTime', function () { return Serenity.DateEditor; }],
            ['EndDateTime', function () { return Serenity.DateEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineMaintenanceScheduleForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineMaintenanceScheduleRow;
        (function (MachineMaintenanceScheduleRow) {
            MachineMaintenanceScheduleRow.idProperty = 'MachineMainSchId';
            MachineMaintenanceScheduleRow.nameProperty = 'Description';
            MachineMaintenanceScheduleRow.localTextPrefix = 'MachineCustomization.MachineMaintenanceSchedule';
            var Fields;
            (function (Fields) {
            })(Fields = MachineMaintenanceScheduleRow.Fields || (MachineMaintenanceScheduleRow.Fields = {}));
            [
                'MachineMainSchId',
                'MachineId',
                'StartDateTime',
                'EndDateTime',
                'Description',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineMaintenanceScheduleRow = MachineCustomization.MachineMaintenanceScheduleRow || (MachineCustomization.MachineMaintenanceScheduleRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineMaintenanceScheduleService;
        (function (MachineMaintenanceScheduleService) {
            MachineMaintenanceScheduleService.baseUrl = 'MachineCustomization/MachineMaintenanceSchedule';
            var Methods;
            (function (Methods) {
            })(Methods = MachineMaintenanceScheduleService.Methods || (MachineMaintenanceScheduleService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineMaintenanceScheduleService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineMaintenanceScheduleService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineMaintenanceScheduleService.baseUrl + '/' + x;
            });
        })(MachineMaintenanceScheduleService = MachineCustomization.MachineMaintenanceScheduleService || (MachineCustomization.MachineMaintenanceScheduleService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineParameterForm = /** @class */ (function (_super) {
            __extends(MachineParameterForm, _super);
            function MachineParameterForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineParameterForm.formKey = 'MachineCustomization.MachineParameter';
            return MachineParameterForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineParameterForm = MachineParameterForm;
        [,
            ['MachineId', function () { return Serenity.LookupEditor; }],
            ['ColumnName', function () { return Serenity.StringEditor }],               // added by JSGURU manually
            ['PickListId', function () { return Serenity.LookupEditor }],               // added by JSGURU manually
            ['ParameterName', function () { return Serenity.StringEditor; }],
            ['PlcAddress', function () { return Serenity.StringEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['DataTypeId', function () { return Serenity.LookupEditor; }],              // IntegerEditor to LookupEditor        modified by JSGURU
            ['IsRangeUnlimited', function () { return Serenity.BooleanEditor; }],
            ['Min', function () { return Serenity.DecimalEditor; }],
            ['Max', function () { return Serenity.DecimalEditor; }],
            ['IsUseUnit', function () { return Serenity.BooleanEditor; }],
            ['UnitId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }],
            ['Type', function () { return Serenity.LookupEditor; }],
            ['IsRead', function () { return Serenity.BooleanEditor; }],
            ['IsWrite', function () { return Serenity.BooleanEditor; }],
            ['IsBitWise', function () { return Serenity.BooleanEditor; }],
            ['BitWiseIndex', function () { return Serenity.IntegerEditor; }],
            ['QueryTypeRowId', function () { return Serenity.IntegerEditor; }],
            ['OperationType', function () { return Serenity.LookupEditor; }],
            ['OperationValue', function () { return Serenity.DecimalEditor; }],
            ['Is32Bit', function () { return Serenity.BooleanEditor; }],
            ['IsBatchStartRequired', function () { return Serenity.BooleanEditor; }],
            ['Bit32RowId', function () { return Serenity.IntegerEditor; }],
            ['IsStopAt', function () { return Serenity.BooleanEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineParameterForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineParameterRow;
        (function (MachineParameterRow) {
            MachineParameterRow.idProperty = 'MachineParameterId';
            MachineParameterRow.nameProperty = 'ParameterName';
            MachineParameterRow.localTextPrefix = 'MachineCustomization.MachineParameter';
            var Fields;
            (function (Fields) {
            })(Fields = MachineParameterRow.Fields || (MachineParameterRow.Fields = {}));
            [
                'MachineParameterId',
                'MachineId',
                'IsRealTime',               // added by JSGURU manually
                'ColumnName',               // added by JSGURU manually
                'PickListId',               // added by JSGURU manually
                'ParameterName',
                'PlcAddress',
                'Description',
                'DataTypeId',
                'IsRangeUnlimited',
                'Min',
                'Max',
                'IsUseUnit',
                'UnitId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineParameterRow = MachineCustomization.MachineParameterRow || (MachineCustomization.MachineParameterRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineParameterService;
        (function (MachineParameterService) {
            MachineParameterService.baseUrl = 'MachineCustomization/MachineParameter';
            var Methods;
            (function (Methods) {
            })(Methods = MachineParameterService.Methods || (MachineParameterService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List',
                'FetchAllColumns'
            ].forEach(function (x) {
                MachineParameterService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineParameterService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineParameterService.baseUrl + '/' + x;
            });
        })(MachineParameterService = MachineCustomization.MachineParameterService || (MachineCustomization.MachineParameterService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeForm = /** @class */ (function (_super) {
            __extends(MachineRecipeForm, _super);
            function MachineRecipeForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineRecipeForm.formKey = 'MachineCustomization.MachineRecipe';
            return MachineRecipeForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineRecipeForm = MachineRecipeForm;
        [,
            //['MachineId', function () { return Serenity.IntegerEditor; }],
            //['RecipeSettingsId', function () { return Serenity.IntegerEditor; }],
            ['RecipeName', function () { return Serenity.StringEditor; }],
            ['Description', function () { return Serenity.StringEditor; }]
            //['StatusId', function () { return Serenity.IntegerEditor; }],
            //['CreatedBy', function () { return Serenity.IntegerEditor; }],
            //['CreatedDate', function () { return Serenity.DateEditor; }],
            //['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            //['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineRecipeForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeParameterForm = /** @class */ (function (_super) {
            __extends(MachineRecipeParameterForm, _super);
            function MachineRecipeParameterForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineRecipeParameterForm.formKey = 'MachineCustomization.MachineRecipeParameter';
            return MachineRecipeParameterForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineRecipeParameterForm = MachineRecipeParameterForm;
        [,
            ['MachineRecipeId', function () { return Serenity.IntegerEditor; }],
            ['RecipeSettingsParameterId', function () { return Serenity.IntegerEditor; }],
            ['RecipeParameterValue', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineRecipeParameterForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeParameterRow;
        (function (MachineRecipeParameterRow) {
            MachineRecipeParameterRow.idProperty = 'MachineRecipeParameterId';
            MachineRecipeParameterRow.nameProperty = 'RecipeParameterValue';
            MachineRecipeParameterRow.localTextPrefix = 'MachineCustomization.MachineRecipeParameter';
            var Fields;
            (function (Fields) {
            })(Fields = MachineRecipeParameterRow.Fields || (MachineRecipeParameterRow.Fields = {}));
            [
                'MachineRecipeParameterId',
                'MachineRecipeId',
                'RecipeSettingsParameterId',
                'RecipeParameterValue',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'RecipeSettingsParameterRecipeSettingsId',
                'RecipeSettingsParameterIpcParameterId',
                'RecipeSettingsParameterIsFetchOnSelfSet',
                'RecipeSettingsParameterStatusId',
                'RecipeSettingsParameterCreatedBy',
                'RecipeSettingsParameterCreatedDate',
                'RecipeSettingsParameterUpdatedBy',
                'RecipeSettingsParameterUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByBirthDate',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByBirthDate',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate',
                'IsRealTime',                           // added by JSGURU manually
                'TableId'                               // added by JSGURU manually
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineRecipeParameterRow = MachineCustomization.MachineRecipeParameterRow || (MachineCustomization.MachineRecipeParameterRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeParameterService;
        (function (MachineRecipeParameterService) {
            MachineRecipeParameterService.baseUrl = 'MachineCustomization/MachineRecipeParameter';
            var Methods;
            (function (Methods) {
            })(Methods = MachineRecipeParameterService.Methods || (MachineRecipeParameterService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineRecipeParameterService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineRecipeParameterService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineRecipeParameterService.baseUrl + '/' + x;
            });
        })(MachineRecipeParameterService = MachineCustomization.MachineRecipeParameterService || (MachineCustomization.MachineRecipeParameterService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeRow;
        (function (MachineRecipeRow) {
            MachineRecipeRow.idProperty = 'MachineRecipeId';
            MachineRecipeRow.nameProperty = 'RecipeName';
            MachineRecipeRow.localTextPrefix = 'MachineCustomization.MachineRecipe';
            var Fields;
            (function (Fields) {
            })(Fields = MachineRecipeRow.Fields || (MachineRecipeRow.Fields = {}));
            [
                'MachineRecipeId',
                'MachineId',
                'RecipeSettingsId',
                'RecipeName',
                'Description',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByBirthDate',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByBirthDate',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineRecipeRow = MachineCustomization.MachineRecipeRow || (MachineCustomization.MachineRecipeRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeService;
        (function (MachineRecipeService) {
            MachineRecipeService.baseUrl = 'MachineCustomization/MachineRecipe';
            var Methods;
            (function (Methods) {
            })(Methods = MachineRecipeService.Methods || (MachineRecipeService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineRecipeService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineRecipeService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineRecipeService.baseUrl + '/' + x;
            });
        })(MachineRecipeService = MachineCustomization.MachineRecipeService || (MachineCustomization.MachineRecipeService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRow;
        (function (MachineRow) {
            MachineRow.idProperty = 'MachineId';
            MachineRow.nameProperty = 'MachineName';
            MachineRow.localTextPrefix = 'MachineCustomization.Machine';
            var Fields;
            (function (Fields) {
            })(Fields = MachineRow.Fields || (MachineRow.Fields = {}));
            [
                'MachineId',
                'MachineLineId',
                'MachineName',
                'ModelNumber',
                'SerialNumber',
                'Make',
                'Year',
                'PlcMake',
                'PlcModelNumber',
                'PlcSerialNumber',
                'PlcAddress',
                'AccessIpAddress',
                'MachineSequence',
                'MachineImage',
                'StatusId',
                'Description',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineRow = MachineCustomization.MachineRow || (MachineCustomization.MachineRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineService;
        (function (MachineService) {
            MachineService.baseUrl = 'MachineCustomization/Machine';
            var Methods;
            (function (Methods) {
            })(Methods = MachineService.Methods || (MachineService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List',
                'FetchAllTables'        // Fetch object ids of all tables
            ].forEach(function (x) {
                MachineService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineService.baseUrl + '/' + x;
            });
        })(MachineService = MachineCustomization.MachineService || (MachineCustomization.MachineService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineSparePartForm = /** @class */ (function (_super) {
            __extends(MachineSparePartForm, _super);
            function MachineSparePartForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineSparePartForm.formKey = 'MachineCustomization.MachineSparePart';
            return MachineSparePartForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineSparePartForm = MachineSparePartForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['PartNumber', function () { return Serenity.StringEditor; }],
            ['PartName', function () { return Serenity.StringEditor; }],
            ['PartDescription', function () { return Serenity.StringEditor; }],
            ['NoOfUnitsRequired', function () { return Serenity.IntegerEditor; }],
            ['PartImage', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineSparePartForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineSparePartRow;
        (function (MachineSparePartRow) {
            MachineSparePartRow.idProperty = 'MachineSparePartId';
            MachineSparePartRow.nameProperty = 'PartNumber';
            MachineSparePartRow.localTextPrefix = 'MachineCustomization.MachineSparePart';
            var Fields;
            (function (Fields) {
            })(Fields = MachineSparePartRow.Fields || (MachineSparePartRow.Fields = {}));
            [
                'MachineSparePartId',
                'MachineId',
                'PartNumber',
                'PartName',
                'PartDescription',
                'NoOfUnitsRequired',
                'PartImage',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineSparePartRow = MachineCustomization.MachineSparePartRow || (MachineCustomization.MachineSparePartRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineSparePartService;
        (function (MachineSparePartService) {
            MachineSparePartService.baseUrl = 'MachineCustomization/MachineSparePart';
            var Methods;
            (function (Methods) {
            })(Methods = MachineSparePartService.Methods || (MachineSparePartService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineSparePartService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineSparePartService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineSparePartService.baseUrl + '/' + x;
            });
        })(MachineSparePartService = MachineCustomization.MachineSparePartService || (MachineCustomization.MachineSparePartService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineSpecificationForm = /** @class */ (function (_super) {
            __extends(MachineSpecificationForm, _super);
            function MachineSpecificationForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineSpecificationForm.formKey = 'MachineCustomization.MachineSpecification';
            return MachineSpecificationForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineSpecificationForm = MachineSpecificationForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['Details', function () { return Serenity.StringEditor; }],
            ['MachineImage', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineSpecificationForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineSpecificationRow;
        (function (MachineSpecificationRow) {
            MachineSpecificationRow.idProperty = 'MachineSpecId';
            MachineSpecificationRow.nameProperty = 'Description';
            MachineSpecificationRow.localTextPrefix = 'MachineCustomization.MachineSpecification';
            var Fields;
            (function (Fields) {
            })(Fields = MachineSpecificationRow.Fields || (MachineSpecificationRow.Fields = {}));
            [
                'MachineSpecId',
                'MachineId',
                'Description',
                'Details',
                'MachineImage',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineSpecificationRow = MachineCustomization.MachineSpecificationRow || (MachineCustomization.MachineSpecificationRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineSpecificationService;
        (function (MachineSpecificationService) {
            MachineSpecificationService.baseUrl = 'MachineCustomization/MachineSpecification';
            var Methods;
            (function (Methods) {
            })(Methods = MachineSpecificationService.Methods || (MachineSpecificationService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineSpecificationService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineSpecificationService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineSpecificationService.baseUrl + '/' + x;
            });
        })(MachineSpecificationService = MachineCustomization.MachineSpecificationService || (MachineCustomization.MachineSpecificationService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineUserForm = /** @class */ (function (_super) {
            __extends(MachineUserForm, _super);
            function MachineUserForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineUserForm.formKey = 'MachineCustomization.MachineUser';
            return MachineUserForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineUserForm = MachineUserForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['UserId', function () { return Serenity.IntegerEditor; }],
            ['ShiftId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineUserForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineUserRow;
        (function (MachineUserRow) {
            MachineUserRow.idProperty = 'MachineUserId';
            MachineUserRow.localTextPrefix = 'MachineCustomization.MachineUser';
            var Fields;
            (function (Fields) {
            })(Fields = MachineUserRow.Fields || (MachineUserRow.Fields = {}));
            [
                'MachineUserId',
                'MachineId',
                'UserId',
                'ShiftId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'UserEmployeeId',
                'UserFirstName',
                'UserLastName',
                'UserDepartmentId',
                'UserDesignation',
                'UserMobileCode',
                'UserMobileNumber',
                'UserEmail',
                'UserUsername',
                'UserPasswordHash',
                'UserPasswordSalt',
                'UserUserImage',
                'UserAddress',
                'UserCityId',
                'UserPinCode',
                'UserRoleId',
                'UserPasswordExpiryDate',
                'UserIsForgotPassword',
                'UserIsPasswordChangeOnLogin',
                'UserIsUserHidden',
                'UserStatusId',
                'UserCreatedBy',
                'UserCreatedDate',
                'UserUpdatedBy',
                'UserUpdatedDate',
                'ShiftShiftName',
                'ShiftStartTime',
                'ShiftEndTime',
                'ShiftStatusId',
                'ShiftCreatedBy',
                'ShiftCreatedDate',
                'ShiftUpdatedBy',
                'ShiftUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineUserRow = MachineCustomization.MachineUserRow || (MachineCustomization.MachineUserRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineUserService;
        (function (MachineUserService) {
            MachineUserService.baseUrl = 'MachineCustomization/MachineUser';
            var Methods;
            (function (Methods) {
            })(Methods = MachineUserService.Methods || (MachineUserService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineUserService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineUserService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineUserService.baseUrl + '/' + x;
            });
        })(MachineUserService = MachineCustomization.MachineUserService || (MachineCustomization.MachineUserService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineVideoForm = /** @class */ (function (_super) {
            __extends(MachineVideoForm, _super);
            function MachineVideoForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            MachineVideoForm.formKey = 'MachineCustomization.MachineVideo';
            return MachineVideoForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineVideoForm = MachineVideoForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['FileName', function () { return Serenity.StringEditor; }],
            ['FileContent', function () { return Serenity.StringEditor; }],
            ['FileLength', function () { return Serenity.IntegerEditor; }],
            ['FileExtension', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(MachineVideoForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineVideoRow;
        (function (MachineVideoRow) {
            MachineVideoRow.idProperty = 'MachineVideoId';
            MachineVideoRow.nameProperty = 'FileName';
            MachineVideoRow.localTextPrefix = 'MachineCustomization.MachineVideo';
            var Fields;
            (function (Fields) {
            })(Fields = MachineVideoRow.Fields || (MachineVideoRow.Fields = {}));
            [
                'MachineVideoId',
                'MachineId',
                'FileName',
                'FileContent',
                'FileLength',
                'FileExtension',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineVideoRow = MachineCustomization.MachineVideoRow || (MachineCustomization.MachineVideoRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineVideoService;
        (function (MachineVideoService) {
            MachineVideoService.baseUrl = 'MachineCustomization/MachineVideo';
            var Methods;
            (function (Methods) {
            })(Methods = MachineVideoService.Methods || (MachineVideoService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineVideoService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineVideoService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineVideoService.baseUrl + '/' + x;
            });
        })(MachineVideoService = MachineCustomization.MachineVideoService || (MachineCustomization.MachineVideoService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsForm = /** @class */ (function (_super) {
            __extends(RecipeSettingsForm, _super);
            function RecipeSettingsForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            RecipeSettingsForm.formKey = 'MachineCustomization.RecipeSettings';
            return RecipeSettingsForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.RecipeSettingsForm = RecipeSettingsForm;
        [,
            ['RecipeSettingsName', function () { return Serenity.StringEditor; }],
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(RecipeSettingsForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsParameterForm = /** @class */ (function (_super) {
            __extends(RecipeSettingsParameterForm, _super);
            function RecipeSettingsParameterForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            RecipeSettingsParameterForm.formKey = 'MachineCustomization.RecipeSettingsParameter';
            return RecipeSettingsParameterForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.RecipeSettingsParameterForm = RecipeSettingsParameterForm;
        [,
            ['RecipeSettingsId', function () { return Serenity.IntegerEditor; }],
            ['IpcParameterId', function () { return Serenity.IntegerEditor; }],
            ['IsFetchOnSelfSet', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(RecipeSettingsParameterForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsParameterRow;
        (function (RecipeSettingsParameterRow) {
            RecipeSettingsParameterRow.idProperty = 'RecipeParameterId';
            RecipeSettingsParameterRow.localTextPrefix = 'MachineCustomization.RecipeSettingsParameter';
            var Fields;
            (function (Fields) {
            })(Fields = RecipeSettingsParameterRow.Fields || (RecipeSettingsParameterRow.Fields = {}));
            [
                'RecipeParameterId',
                'RecipeSettingsId',
                'IpcParameterId',
                'IsFetchOnSelfSet',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'RecipeSettingsRecipeSettingsName',
                'RecipeSettingsMachineId',
                'RecipeSettingsStatusId',
                'RecipeSettingsCreatedBy',
                'RecipeSettingsCreatedDate',
                'RecipeSettingsUpdatedBy',
                'RecipeSettingsUpdatedDate',
                'IpcParameterMachineId',
                'IpcParameterIpcParameterName',
                'IpcParameterMachineParameterId',
                'IpcParameterIpcAddress',
                'IpcParameterIsChangeInRuntime',
                'IpcParameterStatusId',
                'IpcParameterCreatedBy',
                'IpcParameterCreatedDate',
                'IpcParameterUpdatedBy',
                'IpcParameterUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(RecipeSettingsParameterRow = MachineCustomization.RecipeSettingsParameterRow || (MachineCustomization.RecipeSettingsParameterRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsParameterService;
        (function (RecipeSettingsParameterService) {
            RecipeSettingsParameterService.baseUrl = 'MachineCustomization/RecipeSettingsParameter';
            var Methods;
            (function (Methods) {
            })(Methods = RecipeSettingsParameterService.Methods || (RecipeSettingsParameterService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                RecipeSettingsParameterService[x] = function (r, s, o) {
                    return Q.serviceRequest(RecipeSettingsParameterService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = RecipeSettingsParameterService.baseUrl + '/' + x;
            });
        })(RecipeSettingsParameterService = MachineCustomization.RecipeSettingsParameterService || (MachineCustomization.RecipeSettingsParameterService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsRow;
        (function (RecipeSettingsRow) {
            RecipeSettingsRow.idProperty = 'RecipeSettingsId';
            RecipeSettingsRow.nameProperty = 'RecipeSettingsName';
            RecipeSettingsRow.localTextPrefix = 'MachineCustomization.RecipeSettings';
            var Fields;
            (function (Fields) {
            })(Fields = RecipeSettingsRow.Fields || (RecipeSettingsRow.Fields = {}));
            [
                'RecipeSettingsId',
                'RecipeSettingsName',
                'MachineId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(RecipeSettingsRow = MachineCustomization.RecipeSettingsRow || (MachineCustomization.RecipeSettingsRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsService;
        (function (RecipeSettingsService) {
            RecipeSettingsService.baseUrl = 'MachineCustomization/RecipeSettings';
            var Methods;
            (function (Methods) {
            })(Methods = RecipeSettingsService.Methods || (RecipeSettingsService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                RecipeSettingsService[x] = function (r, s, o) {
                    return Q.serviceRequest(RecipeSettingsService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = RecipeSettingsService.baseUrl + '/' + x;
            });
        })(RecipeSettingsService = MachineCustomization.RecipeSettingsService || (MachineCustomization.RecipeSettingsService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ChangePasswordForm = /** @class */ (function (_super) {
            __extends(ChangePasswordForm, _super);
            function ChangePasswordForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ChangePasswordForm.formKey = 'Membership.ChangePassword';
            return ChangePasswordForm;
        }(Serenity.PrefixedContext));
        Membership.ChangePasswordForm = ChangePasswordForm;
        [['OldPassword', function () { return Serenity.PasswordEditor; }], ['NewPassword', function () { return Serenity.PasswordEditor; }], ['ConfirmPassword', function () { return Serenity.PasswordEditor; }]].forEach(function (x) { return Object.defineProperty(ChangePasswordForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ForgotPasswordForm = /** @class */ (function (_super) {
            __extends(ForgotPasswordForm, _super);
            function ForgotPasswordForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ForgotPasswordForm.formKey = 'Membership.ForgotPassword';
            return ForgotPasswordForm;
        }(Serenity.PrefixedContext));
        Membership.ForgotPasswordForm = ForgotPasswordForm;
        [['Email', function () { return Serenity.EmailEditor; }]].forEach(function (x) { return Object.defineProperty(ForgotPasswordForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var LoginForm = /** @class */ (function (_super) {
            __extends(LoginForm, _super);
            function LoginForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            LoginForm.formKey = 'Membership.Login';
            return LoginForm;
        }(Serenity.PrefixedContext));
        Membership.LoginForm = LoginForm;
        [['Username', function () { return Serenity.StringEditor; }], ['Password', function () { return Serenity.PasswordEditor; }]].forEach(function (x) { return Object.defineProperty(LoginForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ResetPasswordForm = /** @class */ (function (_super) {
            __extends(ResetPasswordForm, _super);
            function ResetPasswordForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ResetPasswordForm.formKey = 'Membership.ResetPassword';
            return ResetPasswordForm;
        }(Serenity.PrefixedContext));
        Membership.ResetPasswordForm = ResetPasswordForm;
        [['NewPassword', function () { return Serenity.PasswordEditor; }], ['ConfirmPassword', function () { return Serenity.PasswordEditor; }]].forEach(function (x) { return Object.defineProperty(ResetPasswordForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var SignUpForm = /** @class */ (function (_super) {
            __extends(SignUpForm, _super);
            function SignUpForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            SignUpForm.formKey = 'Membership.SignUp';
            return SignUpForm;
        }(Serenity.PrefixedContext));
        Membership.SignUpForm = SignUpForm;
        [['DisplayName', function () { return Serenity.StringEditor; }], ['Email', function () { return Serenity.EmailEditor; }], ['ConfirmEmail', function () { return Serenity.EmailEditor; }], ['Password', function () { return Serenity.PasswordEditor; }], ['ConfirmPassword', function () { return Serenity.PasswordEditor; }]].forEach(function (x) { return Object.defineProperty(SignUpForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ModuleForm = /** @class */ (function (_super) {
            __extends(ModuleForm, _super);
            function ModuleForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ModuleForm.formKey = 'ModuleManagement.Module';
            return ModuleForm;
        }(Serenity.PrefixedContext));
        ModuleManagement.ModuleForm = ModuleForm;
        [,
            ['ModuleName', function () { return Serenity.StringEditor; }],
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(ModuleForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ModuleRow;
        (function (ModuleRow) {
            ModuleRow.idProperty = 'ModuleId';
            ModuleRow.nameProperty = 'ModuleName';
            ModuleRow.localTextPrefix = 'ModuleManagement.Module';
            var Fields;
            (function (Fields) {
            })(Fields = ModuleRow.Fields || (ModuleRow.Fields = {}));
            [
                'ModuleId',
                'ModuleName',
                'MachineId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(ModuleRow = ModuleManagement.ModuleRow || (ModuleManagement.ModuleRow = {}));
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ModuleService;
        (function (ModuleService) {
            ModuleService.baseUrl = 'ModuleManagement/Module';
            var Methods;
            (function (Methods) {
            })(Methods = ModuleService.Methods || (ModuleService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ModuleService[x] = function (r, s, o) {
                    return Q.serviceRequest(ModuleService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = ModuleService.baseUrl + '/' + x;
            });
        })(ModuleService = ModuleManagement.ModuleService || (ModuleManagement.ModuleService = {}));
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ViewFieldForm = /** @class */ (function (_super) {
            __extends(ViewFieldForm, _super);
            function ViewFieldForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ViewFieldForm.formKey = 'ModuleManagement.ViewField';
            return ViewFieldForm;
        }(Serenity.PrefixedContext));
        ModuleManagement.ViewFieldForm = ViewFieldForm;
        [,
            ['ViewsId', function () { return Serenity.IntegerEditor; }],
            ['ViewFieldName', function () { return Serenity.StringEditor; }],
            ['IpcParameterId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(ViewFieldForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ViewFieldRow;
        (function (ViewFieldRow) {
            ViewFieldRow.idProperty = 'ViewField';
            ViewFieldRow.nameProperty = 'ViewFieldName';
            ViewFieldRow.localTextPrefix = 'ModuleManagement.ViewField';
            var Fields;
            (function (Fields) {
            })(Fields = ViewFieldRow.Fields || (ViewFieldRow.Fields = {}));
            [
                'ViewField',
                'ViewsId',
                'ViewFieldName',
                'IpcParameterId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'ViewsModuleId',
                'ViewsViewName',
                'ViewsIsAccessFieldWise',
                'ViewsStatusId',
                'ViewsCreatedBy',
                'ViewsCreatedDate',
                'ViewsUpdatedBy',
                'ViewsUpdatedDate',
                'IpcParameterMachineId',
                'IpcParameterIpcParameterName',
                'IpcParameterMachineParameterId',
                'IpcParameterIpcAddress',
                'IpcParameterIsChangeInRuntime',
                'IpcParameterStatusId',
                'IpcParameterCreatedBy',
                'IpcParameterCreatedDate',
                'IpcParameterUpdatedBy',
                'IpcParameterUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByBirthDate',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByBirthDate',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(ViewFieldRow = ModuleManagement.ViewFieldRow || (ModuleManagement.ViewFieldRow = {}));
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ViewFieldService;
        (function (ViewFieldService) {
            ViewFieldService.baseUrl = 'ModuleManagement/ViewField';
            var Methods;
            (function (Methods) {
            })(Methods = ViewFieldService.Methods || (ViewFieldService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ViewFieldService[x] = function (r, s, o) {
                    return Q.serviceRequest(ViewFieldService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = ViewFieldService.baseUrl + '/' + x;
            });
        })(ViewFieldService = ModuleManagement.ViewFieldService || (ModuleManagement.ViewFieldService = {}));
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ViewsForm = /** @class */ (function (_super) {
            __extends(ViewsForm, _super);
            function ViewsForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ViewsForm.formKey = 'ModuleManagement.Views';
            return ViewsForm;
        }(Serenity.PrefixedContext));
        ModuleManagement.ViewsForm = ViewsForm;
        [,
            ['ModuleId', function () { return Serenity.IntegerEditor; }],
            ['ViewName', function () { return Serenity.StringEditor; }],
            ['IsAccessFieldWise', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(ViewsForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ViewsRow;
        (function (ViewsRow) {
            ViewsRow.idProperty = 'ViewsId';
            ViewsRow.nameProperty = 'ViewName';
            ViewsRow.localTextPrefix = 'ModuleManagement.Views';
            var Fields;
            (function (Fields) {
            })(Fields = ViewsRow.Fields || (ViewsRow.Fields = {}));
            [
                'ViewsId',
                'ModuleId',
                'ViewName',
                'IsAccessFieldWise',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'ModuleModuleName',
                'ModuleMachineId',
                'ModuleStatusId',
                'ModuleCreatedBy',
                'ModuleCreatedDate',
                'ModuleUpdatedBy',
                'ModuleUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(ViewsRow = ModuleManagement.ViewsRow || (ModuleManagement.ViewsRow = {}));
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ViewsService;
        (function (ViewsService) {
            ViewsService.baseUrl = 'ModuleManagement/Views';
            var Methods;
            (function (Methods) {
            })(Methods = ViewsService.Methods || (ViewsService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ViewsService[x] = function (r, s, o) {
                    return Q.serviceRequest(ViewsService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = ViewsService.baseUrl + '/' + x;
            });
        })(ViewsService = ModuleManagement.ViewsService || (ModuleManagement.ViewsService = {}));
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var BottleForm = /** @class */ (function (_super) {
            __extends(BottleForm, _super);
            function BottleForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            BottleForm.formKey = 'PackSettings.Bottle';
            return BottleForm;
        }(Serenity.PrefixedContext));
        PackSettings.BottleForm = BottleForm;
        [,
            ['BottleName', function () { return Serenity.StringEditor; }],
            ['BottleCc', function () { return Serenity.StringEditor; }],
            ['ContainerTypeId', function () { return Serenity.IntegerEditor; }],
            ['BottleHeight', function () { return Serenity.StringEditor; }],
            ['BottleDiameter', function () { return Serenity.StringEditor; }],
            ['BottleMouthOpeningId', function () { return Serenity.StringEditor; }],
            ['BottleMouthOpeningOd', function () { return Serenity.StringEditor; }],
            ['SupplierId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(BottleForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var BottleRow;
        (function (BottleRow) {
            BottleRow.idProperty = 'BottleId';
            BottleRow.nameProperty = 'BottleName';
            BottleRow.localTextPrefix = 'PackSettings.Bottle';
            var Fields;
            (function (Fields) {
            })(Fields = BottleRow.Fields || (BottleRow.Fields = {}));
            [
                'BottleId',
                'BottleName',
                'BottleCc',
                'ContainerTypeId',
                'BottleHeight',
                'BottleDiameter',
                'BottleMouthOpeningId',
                'BottleMouthOpeningOd',
                'SupplierId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate',
                'SupplierSupplierName',
                'SupplierSupplierAddress',
                'SupplierCityId',
                'SupplierPinCode',
                'SupplierMobileCode',
                'SupplierMobileNumber',
                'SupplierStatusId',
                'SupplierCreatedBy',
                'SupplierCreatedDate',
                'SupplierUpdatedBy',
                'SupplierUpdatedDate',
                'ContainerTypePickListId',
                'ContainerTypePickListValueName',
                'ContainerTypeStatusId',
                'ContainerTypeCreatedBy',
                'ContainerTypeCreatedDate',
                'ContainerTypeUpdatedBy',
                'ContainerTypeUpdatedDate',
                'UpdatedByFullName',
            ].forEach(function (x) { return Fields[x] = x; });
        })(BottleRow = PackSettings.BottleRow || (PackSettings.BottleRow = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var BottleService;
        (function (BottleService) {
            BottleService.baseUrl = 'PackSettings/Bottle';
            var Methods;
            (function (Methods) {
            })(Methods = BottleService.Methods || (BottleService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                BottleService[x] = function (r, s, o) {
                    return Q.serviceRequest(BottleService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = BottleService.baseUrl + '/' + x;
            });
        })(BottleService = PackSettings.BottleService || (PackSettings.BottleService = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var CapForm = /** @class */ (function (_super) {
            __extends(CapForm, _super);
            function CapForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            CapForm.formKey = 'PackSettings.Cap';
            return CapForm;
        }(Serenity.PrefixedContext));
        PackSettings.CapForm = CapForm;
        [,
            ['CapName', function () { return Serenity.StringEditor; }],
            ['CapCc', function () { return Serenity.StringEditor; }],
            ['CapTypeId', function () { return Serenity.IntegerEditor; }],
            ['CapDiameter', function () { return Serenity.StringEditor; }],
            ['CapHeight', function () { return Serenity.StringEditor; }],
            ['SupplierId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(CapForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var CapRow;
        (function (CapRow) {
            CapRow.idProperty = 'CapId';
            CapRow.nameProperty = 'CapName';
            CapRow.localTextPrefix = 'PackSettings.Cap';
            var Fields;
            (function (Fields) {
            })(Fields = CapRow.Fields || (CapRow.Fields = {}));
            [
                'CapId',
                'CapName',
                'CapCc',
                'CapTypeId',
                'CapDiameter',
                'CapHeight',
                'SupplierId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'CapTypePickListId',
                'CapTypePickListValueName',
                'CapTypeStatusId',
                'CapTypeCreatedBy',
                'CapTypeCreatedDate',
                'CapTypeUpdatedBy',
                'CapTypeUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate',
                'SupplierSupplierName',
                'SupplierSupplierAddress',
                'SupplierCityId',
                'SupplierPinCode',
                'SupplierMobileCode',
                'SupplierMobileNumber',
                'SupplierStatusId',
                'SupplierCreatedBy',
                'SupplierCreatedDate',
                'SupplierUpdatedBy',
                'SupplierUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(CapRow = PackSettings.CapRow || (PackSettings.CapRow = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var CapService;
        (function (CapService) {
            CapService.baseUrl = 'PackSettings/Cap';
            var Methods;
            (function (Methods) {
            })(Methods = CapService.Methods || (CapService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                CapService[x] = function (r, s, o) {
                    return Q.serviceRequest(CapService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = CapService.baseUrl + '/' + x;
            });
        })(CapService = PackSettings.CapService || (PackSettings.CapService = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var CottonForm = /** @class */ (function (_super) {
            __extends(CottonForm, _super);
            function CottonForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            CottonForm.formKey = 'PackSettings.Cotton';
            return CottonForm;
        }(Serenity.PrefixedContext));
        PackSettings.CottonForm = CottonForm;
        [,
            ['CottonName', function () { return Serenity.StringEditor; }],
            ['CottonTypeId', function () { return Serenity.IntegerEditor; }],
            ['GmOrYard', function () { return Serenity.StringEditor; }],
            ['SupplierId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(CottonForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var CottonRow;
        (function (CottonRow) {
            CottonRow.idProperty = 'CottonId';
            CottonRow.nameProperty = 'CottonName';
            CottonRow.localTextPrefix = 'PackSettings.Cotton';
            var Fields;
            (function (Fields) {
            })(Fields = CottonRow.Fields || (CottonRow.Fields = {}));
            [
                'CottonId',
                'CottonName',
                'CottonTypeId',
                'GmOrYard',
                'SupplierId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'CottonStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate',
                'SupplierSupplierName',
                'SupplierSupplierAddress',
                'SupplierCityId',
                'SupplierPinCode',
                'SupplierMobileCode',
                'SupplierMobileNumber',
                'SupplierStatusId',
                'SupplierCreatedBy',
                'SupplierCreatedDate',
                'SupplierUpdatedBy',
                'SupplierUpdatedDate',
                'CapTypePickListId',
                'CapTypePickListValueName',
                'CapTypeStatusId',
                'CapTypeCreatedBy',
                'CapTypeCreatedDate',
                'CapTypeUpdatedBy',
                'CapTypeUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(CottonRow = PackSettings.CottonRow || (PackSettings.CottonRow = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var CottonService;
        (function (CottonService) {
            CottonService.baseUrl = 'PackSettings/Cotton';
            var Methods;
            (function (Methods) {
            })(Methods = CottonService.Methods || (CottonService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                CottonService[x] = function (r, s, o) {
                    return Q.serviceRequest(CottonService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = CottonService.baseUrl + '/' + x;
            });
        })(CottonService = PackSettings.CottonService || (PackSettings.CottonService = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var DesiccantForm = /** @class */ (function (_super) {
            __extends(DesiccantForm, _super);
            function DesiccantForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            DesiccantForm.formKey = 'PackSettings.Desiccant';
            return DesiccantForm;
        }(Serenity.PrefixedContext));
        PackSettings.DesiccantForm = DesiccantForm;
        [,
            ['DesiccantName', function () { return Serenity.StringEditor; }],
            ['DesiccantTypeId', function () { return Serenity.IntegerEditor; }],
            ['Grammage', function () { return Serenity.StringEditor; }],
            ['LengthOrHeight', function () { return Serenity.StringEditor; }],
            ['DiameterOrWidth', function () { return Serenity.StringEditor; }],
            ['Identification', function () { return Serenity.IntegerEditor; }],
            ['SupplierId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(DesiccantForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var DesiccantRow;
        (function (DesiccantRow) {
            DesiccantRow.idProperty = 'DesiccantId';
            DesiccantRow.nameProperty = 'DesiccantName';
            DesiccantRow.localTextPrefix = 'PackSettings.Desiccant';
            var Fields;
            (function (Fields) {
            })(Fields = DesiccantRow.Fields || (DesiccantRow.Fields = {}));
            [
                'DesiccantId',
                'DesiccantName',
                'DesiccantTypeId',
                'Grammage',
                'LengthOrHeight',
                'DiameterOrWidth',
                'Identification',
                'SupplierId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate',
                'SupplierSupplierName',
                'SupplierSupplierAddress',
                'SupplierCityId',
                'SupplierPinCode',
                'SupplierMobileCode',
                'SupplierMobileNumber',
                'SupplierStatusId',
                'SupplierCreatedBy',
                'SupplierCreatedDate',
                'SupplierUpdatedBy',
                'SupplierUpdatedDate',
                'DesiccantTypePickListValueName',
                'DesiccantTypeStatusId',
                'IdentificationPickListValueName',
                'IdentificationStatusId'
            ].forEach(function (x) { return Fields[x] = x; });
        })(DesiccantRow = PackSettings.DesiccantRow || (PackSettings.DesiccantRow = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var DesiccantService;
        (function (DesiccantService) {
            DesiccantService.baseUrl = 'PackSettings/Desiccant';
            var Methods;
            (function (Methods) {
            })(Methods = DesiccantService.Methods || (DesiccantService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                DesiccantService[x] = function (r, s, o) {
                    return Q.serviceRequest(DesiccantService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = DesiccantService.baseUrl + '/' + x;
            });
        })(DesiccantService = PackSettings.DesiccantService || (PackSettings.DesiccantService = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var EndOfLineForm = /** @class */ (function (_super) {
            __extends(EndOfLineForm, _super);
            function EndOfLineForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            EndOfLineForm.formKey = 'PackSettings.EndOfLine';
            return EndOfLineForm;
        }(Serenity.PrefixedContext));
        PackSettings.EndOfLineForm = EndOfLineForm;
        [,
            ['EndOfLineName', function () { return Serenity.StringEditor; }],
            ['CartonLength', function () { return Serenity.StringEditor; }],
            ['CartonHeight', function () { return Serenity.StringEditor; }],
            ['CartonWidth', function () { return Serenity.StringEditor; }],
            ['CartonType', function () { return Serenity.StringEditor; }],
            ['BottleConfiguration', function () { return Serenity.StringEditor; }],
            ['MedicationLength', function () { return Serenity.StringEditor; }],
            ['MedicationWidth', function () { return Serenity.StringEditor; }],
            ['NoOfMedication', function () { return Serenity.StringEditor; }],
            ['InnerShipperBoxType', function () { return Serenity.StringEditor; }],
            ['InnerShipperBoxLength', function () { return Serenity.StringEditor; }],
            ['InnerShipperBoxWidth', function () { return Serenity.StringEditor; }],
            ['InnerShipperBoxHeight', function () { return Serenity.StringEditor; }],
            ['OuterShipperBoxLength', function () { return Serenity.StringEditor; }],
            ['OuterShipperBoxWidth', function () { return Serenity.StringEditor; }],
            ['OuterShipperBoxHeight', function () { return Serenity.StringEditor; }],
            ['InnerShipperMatrix', function () { return Serenity.StringEditor; }],
            ['OuterShipperQuantity', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(EndOfLineForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var EndOfLineRow;
        (function (EndOfLineRow) {
            EndOfLineRow.idProperty = 'EndOfLineId';
            EndOfLineRow.nameProperty = 'EndOfLineName';
            EndOfLineRow.localTextPrefix = 'PackSettings.EndOfLine';
            var Fields;
            (function (Fields) {
            })(Fields = EndOfLineRow.Fields || (EndOfLineRow.Fields = {}));
            [
                'EndOfLineId',
                'EndOfLineName',
                'CartonLength',
                'CartonHeight',
                'CartonWidth',
                'CartonType',
                'BottleConfiguration',
                'MedicationLength',
                'MedicationWidth',
                'NoOfMedication',
                'InnerShipperBoxType',
                'InnerShipperBoxLength',
                'InnerShipperBoxWidth',
                'InnerShipperBoxHeight',
                'OuterShipperBoxLength',
                'OuterShipperBoxWidth',
                'OuterShipperBoxHeight',
                'InnerShipperMatrix',
                'OuterShipperQuantity',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(EndOfLineRow = PackSettings.EndOfLineRow || (PackSettings.EndOfLineRow = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var EndOfLineService;
        (function (EndOfLineService) {
            EndOfLineService.baseUrl = 'PackSettings/EndOfLine';
            var Methods;
            (function (Methods) {
            })(Methods = EndOfLineService.Methods || (EndOfLineService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                EndOfLineService[x] = function (r, s, o) {
                    return Q.serviceRequest(EndOfLineService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = EndOfLineService.baseUrl + '/' + x;
            });
        })(EndOfLineService = PackSettings.EndOfLineService || (PackSettings.EndOfLineService = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var LabelForm = /** @class */ (function (_super) {
            __extends(LabelForm, _super);
            function LabelForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            LabelForm.formKey = 'PackSettings.Label';
            return LabelForm;
        }(Serenity.PrefixedContext));
        PackSettings.LabelForm = LabelForm;
        [,
            ['LabelName', function () { return Serenity.StringEditor; }],
            ['LabelLength', function () { return Serenity.StringEditor; }],
            ['LabelHeight', function () { return Serenity.StringEditor; }],
            ['LabelType', function () { return Serenity.StringEditor; }],
            ['LabelImage', function () { return Serenity.StringEditor; }],
            ['SupplierId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(LabelForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var LabelRow;
        (function (LabelRow) {
            LabelRow.idProperty = 'LabelId';
            LabelRow.nameProperty = 'LabelName';
            LabelRow.localTextPrefix = 'PackSettings.Label';
            var Fields;
            (function (Fields) {
            })(Fields = LabelRow.Fields || (LabelRow.Fields = {}));
            [
                'LabelId',
                'LabelName',
                'LabelLength',
                'LabelHeight',
                'LabelType',
                'LabelImage',
                'SupplierId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'SupplierSupplierName',
                'SupplierSupplierAddress',
                'SupplierCityId',
                'SupplierPinCode',
                'SupplierMobileCode',
                'SupplierMobileNumber',
                'SupplierStatusId',
                'SupplierCreatedBy',
                'SupplierCreatedDate',
                'SupplierUpdatedBy',
                'SupplierUpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(LabelRow = PackSettings.LabelRow || (PackSettings.LabelRow = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var LabelService;
        (function (LabelService) {
            LabelService.baseUrl = 'PackSettings/Label';
            var Methods;
            (function (Methods) {
            })(Methods = LabelService.Methods || (LabelService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                LabelService[x] = function (r, s, o) {
                    return Q.serviceRequest(LabelService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = LabelService.baseUrl + '/' + x;
            });
        })(LabelService = PackSettings.LabelService || (PackSettings.LabelService = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var OutsertForm = /** @class */ (function (_super) {
            __extends(OutsertForm, _super);
            function OutsertForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            OutsertForm.formKey = 'PackSettings.Outsert';
            return OutsertForm;
        }(Serenity.PrefixedContext));
        PackSettings.OutsertForm = OutsertForm;
        [,
            ['OutsertName', function () { return Serenity.StringEditor; }],
            ['OutsertLength', function () { return Serenity.StringEditor; }],
            ['OutsertWidth', function () { return Serenity.StringEditor; }],
            ['OutsertThickness', function () { return Serenity.StringEditor; }],
            ['SupplierId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(OutsertForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var OutsertRow;
        (function (OutsertRow) {
            OutsertRow.idProperty = 'OutsertId';
            OutsertRow.nameProperty = 'OutsertName';
            OutsertRow.localTextPrefix = 'PackSettings.Outsert';
            var Fields;
            (function (Fields) {
            })(Fields = OutsertRow.Fields || (OutsertRow.Fields = {}));
            [
                'OutsertId',
                'OutsertName',
                'OutsertLength',
                'OutsertWidth',
                'OutsertThickness',
                'SupplierId',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate',
                'SupplierSupplierName',
                'SupplierSupplierAddress',
                'SupplierCityId',
                'SupplierPinCode',
                'SupplierMobileCode',
                'SupplierMobileNumber',
                'SupplierStatusId',
                'SupplierCreatedBy',
                'SupplierCreatedDate',
                'SupplierUpdatedBy',
                'SupplierUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(OutsertRow = PackSettings.OutsertRow || (PackSettings.OutsertRow = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var OutsertService;
        (function (OutsertService) {
            OutsertService.baseUrl = 'PackSettings/Outsert';
            var Methods;
            (function (Methods) {
            })(Methods = OutsertService.Methods || (OutsertService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                OutsertService[x] = function (r, s, o) {
                    return Q.serviceRequest(OutsertService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = OutsertService.baseUrl + '/' + x;
            });
        })(OutsertService = PackSettings.OutsertService || (PackSettings.OutsertService = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var PackForm = /** @class */ (function (_super) {
            __extends(PackForm, _super);
            function PackForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            PackForm.formKey = 'PackSettings.Pack';
            return PackForm;
        }(Serenity.PrefixedContext));
        PackSettings.PackForm = PackForm;
        [,
            ['PackName', function () { return Serenity.StringEditor; }],
            ['TabletId', function () { return Serenity.IntegerEditor; }],
            ['TabletCount', function () { return Serenity.IntegerEditor; }],
            ['BottleId', function () { return Serenity.IntegerEditor; }],
            ['CapId', function () { return Serenity.IntegerEditor; }],
            ['CottonId', function () { return Serenity.IntegerEditor; }],
            ['CottonLength', function () { return Serenity.StringEditor; }],
            ['NumberOfCottonPieces', function () { return Serenity.IntegerEditor; }],
            ['DesiccantId', function () { return Serenity.IntegerEditor; }],
            ['NumberOfDesicantPieces', function () { return Serenity.IntegerEditor; }],
            ['OutsertId', function () { return Serenity.IntegerEditor; }],
            ['LabelId', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['EndOfLineId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(PackForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var PackRow;
        (function (PackRow) {
            PackRow.idProperty = 'PackId';
            PackRow.nameProperty = 'PackName';
            PackRow.localTextPrefix = 'PackSettings.Pack';
            var Fields;
            (function (Fields) {
            })(Fields = PackRow.Fields || (PackRow.Fields = {}));
            [
                'PackId',
                'PackName',
                'TabletId',
                'TabletCount',
                'BottleId',
                'CapId',
                'CottonId',
                'CottonLength',
                'NumberOfCottonPieces',
                'DesiccantId',
                'NumberOfDesicantPieces',
                'OutsertId',
                'LabelId',
                'StatusId',
                'EndOfLineId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'LabelLabelName',
                'LabelLabelLength',
                'LabelLabelHeight',
                'LabelLabelType',
                'LabelLabelImage',
                'LabelSupplierId',
                'LabelStatusId',
                'LabelCreatedBy',
                'LabelCreatedDate',
                'LabelUpdatedBy',
                'LabelUpdatedDate',
                'StatusStatusName',
                'EndOfLineEndOfLineName',
                'EndOfLineCartonLength',
                'EndOfLineCartonHeight',
                'EndOfLineCartonWidth',
                'EndOfLineCartonType',
                'EndOfLineBottleConfiguration',
                'EndOfLineMedicationLength',
                'EndOfLineMedicationWidth',
                'EndOfLineNoOfMedication',
                'EndOfLineInnerShipperBoxType',
                'EndOfLineInnerShipperBoxLength',
                'EndOfLineInnerShipperBoxWidth',
                'EndOfLineInnerShipperBoxHeight',
                'EndOfLineOuterShipperBoxLength',
                'EndOfLineOuterShipperBoxWidth',
                'EndOfLineOuterShipperBoxHeight',
                'EndOfLineInnerShipperMatrix',
                'EndOfLineOuterShipperQuantity',
                'EndOfLineStatusId',
                'EndOfLineCreatedBy',
                'EndOfLineCreatedDate',
                'EndOfLineUpdatedBy',
                'EndOfLineUpdatedDate',
                'CreatedByEmployeeId',
                'CreatedByFirstName',
                'CreatedByLastName',
                'CreatedByDepartmentId',
                'CreatedByDesignation',
                'CreatedByMobileCode',
                'CreatedByMobileNumber',
                'CreatedByEmail',
                'CreatedByUsername',
                'CreatedByPasswordHash',
                'CreatedByPasswordSalt',
                'CreatedByUserImage',
                'CreatedByAddress',
                'CreatedByCityId',
                'CreatedByPinCode',
                'CreatedByRoleId',
                'CreatedByPasswordExpiryDate',
                'CreatedByIsForgotPassword',
                'CreatedByIsPasswordChangeOnLogin',
                'CreatedByIsUserHidden',
                'CreatedByStatusId',
                'CreatedBy1',
                'CreatedByCreatedDate',
                'CreatedByUpdatedBy',
                'CreatedByUpdatedDate',
                'UpdatedByEmployeeId',
                'UpdatedByFirstName',
                'UpdatedByLastName',
                'UpdatedByDepartmentId',
                'UpdatedByDesignation',
                'UpdatedByMobileCode',
                'UpdatedByMobileNumber',
                'UpdatedByEmail',
                'UpdatedByUsername',
                'UpdatedByPasswordHash',
                'UpdatedByPasswordSalt',
                'UpdatedByUserImage',
                'UpdatedByAddress',
                'UpdatedByCityId',
                'UpdatedByPinCode',
                'UpdatedByRoleId',
                'UpdatedByPasswordExpiryDate',
                'UpdatedByIsForgotPassword',
                'UpdatedByIsPasswordChangeOnLogin',
                'UpdatedByIsUserHidden',
                'UpdatedByStatusId',
                'UpdatedByCreatedBy',
                'UpdatedByCreatedDate',
                'UpdatedBy1',
                'UpdatedByUpdatedDate',
                'TabletName',
                'BottleName',
                'CapName',
                'CottonName',
                'DesiccantName',
                'OutsertName'
            ].forEach(function (x) { return Fields[x] = x; });
        })(PackRow = PackSettings.PackRow || (PackSettings.PackRow = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var PackService;
        (function (PackService) {
            PackService.baseUrl = 'PackSettings/Pack';
            var Methods;
            (function (Methods) {
            })(Methods = PackService.Methods || (PackService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                PackService[x] = function (r, s, o) {
                    return Q.serviceRequest(PackService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = PackService.baseUrl + '/' + x;
            });
        })(PackService = PackSettings.PackService || (PackSettings.PackService = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var TabletDetailsForm = /** @class */ (function (_super) {
            __extends(TabletDetailsForm, _super);
            function TabletDetailsForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            TabletDetailsForm.formKey = 'PackSettings.TabletDetails';
            return TabletDetailsForm;
        }(Serenity.PrefixedContext));
        PackSettings.TabletDetailsForm = TabletDetailsForm;
        [,
            ['TabletName', function () { return Serenity.StringEditor; }],
            ['TabletStrength', function () { return Serenity.StringEditor; }],
            ['TabletTypeId', function () { return Serenity.IntegerEditor; }],
            ['TabletCharOneId', function () { return Serenity.IntegerEditor; }],
            ['TabletCharTwoId', function () { return Serenity.IntegerEditor; }],
            ['TabletShapeId', function () { return Serenity.IntegerEditor; }],
            ['TabletLength', function () { return Serenity.StringEditor; }],
            ['TabletThickness', function () { return Serenity.StringEditor; }],
            ['TabletWidth', function () { return Serenity.StringEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }],
            ['CreatedBy', function () { return Serenity.IntegerEditor; }],
            ['CreatedDate', function () { return Serenity.DateEditor; }],
            ['UpdatedBy', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDate', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(TabletDetailsForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var TabletDetailsRow;
        (function (TabletDetailsRow) {
            TabletDetailsRow.idProperty = 'TabletDetailsId';
            TabletDetailsRow.nameProperty = 'TabletName';
            TabletDetailsRow.localTextPrefix = 'PackSettings.TabletDetails';
            var Fields;
            (function (Fields) {
            })(Fields = TabletDetailsRow.Fields || (TabletDetailsRow.Fields = {}));
            [
                'TabletDetailsId',
                'TabletName',
                'TabletStrength',
                'TabletTypeId',
                'TabletCharOneId',
                'TabletCharTwoId',
                'TabletShapeId',
                'TabletLength',
                'TabletThickness',
                'TabletWidth',
                'StatusId',
                'CreatedBy',
                'CreatedDate',
                'UpdatedBy',
                'UpdatedDate',
                'StatusStatusName',
                'TabletTypePickListValueName',
                'TabletTypeStatusId',
                'TabletCharOnePickListValueName',
                'TabletCharOneStatusId',
                'TabletCharTwoPickListValueName',
                'TabletCharTwoStatusId',
                'TabletShapePickListValueName',
                'TabletShapeStatusId'
            ].forEach(function (x) { return Fields[x] = x; });
        })(TabletDetailsRow = PackSettings.TabletDetailsRow || (PackSettings.TabletDetailsRow = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var TabletDetailsService;
        (function (TabletDetailsService) {
            TabletDetailsService.baseUrl = 'PackSettings/TabletDetails';
            var Methods;
            (function (Methods) {
            })(Methods = TabletDetailsService.Methods || (TabletDetailsService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                TabletDetailsService[x] = function (r, s, o) {
                    return Q.serviceRequest(TabletDetailsService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = TabletDetailsService.baseUrl + '/' + x;
            });
        })(TabletDetailsService = PackSettings.TabletDetailsService || (PackSettings.TabletDetailsService = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogForm = /** @class */ (function (_super) {
            __extends(AlarmLogForm, _super);
            function AlarmLogForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            AlarmLogForm.formKey = 'Report.AlarmLog';
            return AlarmLogForm;
        }(Serenity.PrefixedContext));
        Report.AlarmLogForm = AlarmLogForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['AlarmId', function () { return Serenity.IntegerEditor; }],
            ['BatchId', function () { return Serenity.IntegerEditor; }],
            ['LoggedUserId', function () { return Serenity.IntegerEditor; }],
            ['Comment', function () { return Serenity.StringEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['AlarmDateTime', function () { return Serenity.DateEditor; }],
            ['PcipAddress', function () { return Serenity.StringEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(AlarmLogForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogArchiveForm = /** @class */ (function (_super) {
            __extends(AlarmLogArchiveForm, _super);
            function AlarmLogArchiveForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            AlarmLogArchiveForm.formKey = 'Report.AlarmLogArchive';
            return AlarmLogArchiveForm;
        }(Serenity.PrefixedContext));
        Report.AlarmLogArchiveForm = AlarmLogArchiveForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['AlarmId', function () { return Serenity.IntegerEditor; }],
            ['BatchId', function () { return Serenity.IntegerEditor; }],
            ['LoggedUserId', function () { return Serenity.IntegerEditor; }],
            ['Comment', function () { return Serenity.StringEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['AlarmDateTime', function () { return Serenity.DateEditor; }],
            ['PcipAddress', function () { return Serenity.StringEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(AlarmLogArchiveForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogRow;
        (function (AlarmLogRow) {
            AlarmLogRow.idProperty = 'AlarmLogId';
            AlarmLogRow.nameProperty = 'Comment';
            AlarmLogRow.localTextPrefix = 'Report.AlarmLog';
            var Fields;
            (function (Fields) {
            })(Fields = AlarmLogRow.Fields || (AlarmLogRow.Fields = {}));
            [
                'AlarmLogId',
                'MachineId',
                'AlarmId',
                'BatchId',
                'LoggedUserId',
                'Comment',
                'Description',
                'AlarmDateTime',
                'PcipAddress'
            ].forEach(function (x) { return Fields[x] = x; });
        })(AlarmLogRow = Report.AlarmLogRow || (Report.AlarmLogRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogArchiveRow;
        (function (AlarmLogArchiveRow) {
            AlarmLogArchiveRow.idProperty = 'AlarmLogArchiveId';
            AlarmLogArchiveRow.nameProperty = 'Comment';
            AlarmLogArchiveRow.localTextPrefix = 'Report.AlarmLogArchive';
            var Fields;
            (function (Fields) {
            })(Fields = AlarmLogArchiveRow.Fields || (AlarmLogArchiveRow.Fields = {}));
            [
                'AlarmLogArchiveId',
                'MachineId',
                'AlarmId',
                'BatchId',
                'LoggedUserId',
                'Comment',
                'Description',
                'AlarmDateTime',
                'PcipAddress'
            ].forEach(function (x) { return Fields[x] = x; });
        })(AlarmLogArchiveRow = Report.AlarmLogArchiveRow || (Report.AlarmLogArchiveRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogService;
        (function (AlarmLogService) {
            AlarmLogService.baseUrl = 'Report/AlarmLog';
            var Methods;
            (function (Methods) {
            })(Methods = AlarmLogService.Methods || (AlarmLogService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AlarmLogService[x] = function (r, s, o) {
                    return Q.serviceRequest(AlarmLogService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = AlarmLogService.baseUrl + '/' + x;
            });
        })(AlarmLogService = Report.AlarmLogService || (Report.AlarmLogService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogArchiveService;
        (function (AlarmLogArchiveService) {
            AlarmLogArchiveService.baseUrl = 'Report/AlarmLogArchive';
            var Methods;
            (function (Methods) {
            })(Methods = AlarmLogArchiveService.Methods || (AlarmLogArchiveService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AlarmLogArchiveService[x] = function (r, s, o) {
                    return Q.serviceRequest(AlarmLogArchiveService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = AlarmLogArchiveService.baseUrl + '/' + x;
            });
        })(AlarmLogArchiveService = Report.AlarmLogArchiveService || (Report.AlarmLogArchiveService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));




var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogForm = /** @class */ (function (_super) {
            __extends(AuditLogForm, _super);
            function AuditLogForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            AuditLogForm.formKey = 'Report.AuditLog';
            return AuditLogForm;
        }(Serenity.PrefixedContext));
        Report.AuditLogForm = AuditLogForm;
        [,
            ['UserId', function () { return Serenity.IntegerEditor; }],
            ['UserName', function () { return Serenity.StringEditor; }],
            ['Action', function () { return Serenity.StringEditor; }],
            ['ChangedOn', function () { return Serenity.DateEditor; }],
            ['TableName', function () { return Serenity.StringEditor; }],
            ['RowId', function () { return Serenity.IntegerEditor; }],
            ['Module', function () { return Serenity.StringEditor; }],
            ['Page', function () { return Serenity.StringEditor; }],
            ['FieldName', function () { return Serenity.StringEditor; }],
            ['OldValue', function () { return Serenity.StringEditor; }],
            ['NewValue', function () { return Serenity.StringEditor; }],
            ['Comments', function () { return Serenity.StringEditor; }],
            ['PcipAddress', function () { return Serenity.StringEditor; }],
            ['BatchId', function () { return Serenity.IntegerEditor; }],
            ['BatchName', function () { return Serenity.StringEditor; }],
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['MachineName', function () { return Serenity.StringEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(AuditLogForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogArchiveForm = /** @class */ (function (_super) {
            __extends(AuditLogArchiveForm, _super);
            function AuditLogArchiveForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            AuditLogArchiveForm.formKey = 'Report.AuditLog';
            return AuditLogArchiveForm;
        }(Serenity.PrefixedContext));
        Report.AuditLogArchiveForm = AuditLogArchiveForm;
        [,
            ['UserId', function () { return Serenity.IntegerEditor; }],
            ['UserName', function () { return Serenity.StringEditor; }],
            ['Action', function () { return Serenity.StringEditor; }],
            ['ChangedOn', function () { return Serenity.DateEditor; }],
            ['TableName', function () { return Serenity.StringEditor; }],
            ['RowId', function () { return Serenity.IntegerEditor; }],
            ['Module', function () { return Serenity.StringEditor; }],
            ['Page', function () { return Serenity.StringEditor; }],
            ['FieldName', function () { return Serenity.StringEditor; }],
            ['OldValue', function () { return Serenity.StringEditor; }],
            ['NewValue', function () { return Serenity.StringEditor; }],
            ['Comments', function () { return Serenity.StringEditor; }],
            ['PcipAddress', function () { return Serenity.StringEditor; }],
            ['BatchId', function () { return Serenity.IntegerEditor; }],
            ['BatchName', function () { return Serenity.StringEditor; }],
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['MachineName', function () { return Serenity.StringEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(AuditLogArchiveForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogRow;
        (function (AuditLogRow) {
            AuditLogRow.idProperty = 'AuditLogId';
            AuditLogRow.nameProperty = 'UserName';
            AuditLogRow.localTextPrefix = 'Report.AuditLog';
            var Fields;
            (function (Fields) {
            })(Fields = AuditLogRow.Fields || (AuditLogRow.Fields = {}));
            [
                'AuditLogId',
                'UserId',
                'UserName',
                'Action',
                'ChangedOn',
                'TableName',
                'RowId',
                'Module',
                'Page',
                'FieldName',
                'OldValue',
                'NewValue',
                'Comments',
                'PcipAddress',
                'BatchId',
                'BatchName',
                'MachineId',
                'MachineName',
                'UserEmployeeId',
                'UserFirstName',
                'UserLastName',
                'UserDepartmentId',
                'UserDesignation',
                'UserMobileCode',
                'UserMobileNumber',
                'UserEmail',
                'UserUsername',
                'UserPasswordHash',
                'UserPasswordSalt',
                'UserUserImage',
                'UserAddress',
                'UserCityId',
                'UserPinCode',
                'UserRoleId',
                'UserPasswordExpiryDate',
                'UserIsForgotPassword',
                'UserIsPasswordChangeOnLogin',
                'UserIsUserHidden',
                'UserStatusId',
                'UserCreatedBy',
                'UserCreatedDate',
                'UserUpdatedBy',
                'UserUpdatedDate',
                'BatchBatchName',
                'BatchPackId',
                'BatchBatchStartDateTime',
                'BatchBatchVersion',
                'BatchBatchEndDateTime',
                'BatchMachineLineId',
                'BatchBatchStatus',
                'BatchBatchSize',
                'BatchBatchFor',
                'BatchNumberOfBottles',
                'BatchTotalGoodBottles',
                'BatchTotalRejectedBottles',
                'BatchProductionSpeed',
                'BatchExpiryDate',
                'BatchStatusId',
                'BatchCreatedBy',
                'BatchCreatedDate',
                'BatchUpdatedBy',
                'BatchUpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(AuditLogRow = Report.AuditLogRow || (Report.AuditLogRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogArchiveRow;
        (function (AuditLogArchiveRow) {
            AuditLogArchiveRow.idProperty = 'AuditLogArchiveId';
            AuditLogArchiveRow.nameProperty = 'UserName';
            AuditLogArchiveRow.localTextPrefix = 'Report.AuditLogArchive';
            var Fields;
            (function (Fields) {
            })(Fields = AuditLogArchiveRow.Fields || (AuditLogArchiveRow.Fields = {}));
            [
                'AuditLogArchiveId',
                'UserId',
                'UserName',
                'Action',
                'ChangedOn',
                'TableName',
                'RowId',
                'Module',
                'Page',
                'FieldName',
                'OldValue',
                'NewValue',
                'Comments',
                'PcipAddress',
                'BatchId',
                'BatchName',
                'MachineId',
                'MachineName',
                'UserEmployeeId',
                'UserFirstName',
                'UserLastName',
                'UserDepartmentId',
                'UserDesignation',
                'UserMobileCode',
                'UserMobileNumber',
                'UserEmail',
                'UserUsername',
                'UserPasswordHash',
                'UserPasswordSalt',
                'UserUserImage',
                'UserAddress',
                'UserCityId',
                'UserPinCode',
                'UserRoleId',
                'UserPasswordExpiryDate',
                'UserIsForgotPassword',
                'UserIsPasswordChangeOnLogin',
                'UserIsUserHidden',
                'UserStatusId',
                'UserCreatedBy',
                'UserCreatedDate',
                'UserUpdatedBy',
                'UserUpdatedDate',
                'BatchBatchName',
                'BatchPackId',
                'BatchBatchStartDateTime',
                'BatchBatchVersion',
                'BatchBatchEndDateTime',
                'BatchMachineLineId',
                'BatchBatchStatus',
                'BatchBatchSize',
                'BatchBatchFor',
                'BatchNumberOfBottles',
                'BatchTotalGoodBottles',
                'BatchTotalRejectedBottles',
                'BatchProductionSpeed',
                'BatchExpiryDate',
                'BatchStatusId',
                'BatchCreatedBy',
                'BatchCreatedDate',
                'BatchUpdatedBy',
                'BatchUpdatedDate',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachineSerialNumber',
                'MachineMake',
                'MachineYear',
                'MachinePlcMake',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachinePlcAddress',
                'MachineAccessIpAddress',
                'MachineMachineSequence',
                'MachineMachineImage',
                'MachineStatusId',
                'MachineDescription',
                'MachineCreatedBy',
                'MachineCreatedDate',
                'MachineUpdatedBy',
                'MachineUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(AuditLogArchiveRow = Report.AuditLogArchiveRow || (Report.AuditLogArchiveRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogService;
        (function (AuditLogService) {
            AuditLogService.baseUrl = 'Report/AuditLog';
            var Methods;
            (function (Methods) {
            })(Methods = AuditLogService.Methods || (AuditLogService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AuditLogService[x] = function (r, s, o) {
                    return Q.serviceRequest(AuditLogService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = AuditLogService.baseUrl + '/' + x;
            });
        })(AuditLogService = Report.AuditLogService || (Report.AuditLogService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogArchiveService;
        (function (AuditLogArchiveService) {
            AuditLogArchiveService.baseUrl = 'Report/AuditLogArchive';
            var Methods;
            (function (Methods) {
            })(Methods = AuditLogArchiveService.Methods || (AuditLogArchiveService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AuditLogArchiveService[x] = function (r, s, o) {
                    return Q.serviceRequest(AuditLogArchiveService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = AuditLogArchiveService.baseUrl + '/' + x;
            });
        })(AuditLogArchiveService = Report.AuditLogArchiveService || (Report.AuditLogArchiveService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var BatchLogForm = /** @class */ (function (_super) {
            __extends(BatchLogForm, _super);
            function BatchLogForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            BatchLogForm.formKey = 'Report.BatchLog';
            return BatchLogForm;
        }(Serenity.PrefixedContext));
        Report.BatchLogForm = BatchLogForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['BatchId', function () { return Serenity.IntegerEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['UserId', function () { return Serenity.IntegerEditor; }],
            ['UpdatedDateTime', function () { return Serenity.DateEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(BatchLogForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var BatchLogRow;
        (function (BatchLogRow) {
            BatchLogRow.idProperty = 'BatchLogId';
            BatchLogRow.nameProperty = 'Description';
            BatchLogRow.localTextPrefix = 'Report.BatchLog';
            var Fields;
            (function (Fields) {
            })(Fields = BatchLogRow.Fields || (BatchLogRow.Fields = {}));
            [
                'BatchLogId',
                'MachineId',
                'BatchId',
                'Description',
                'UserId',
                'UpdatedDateTime'
            ].forEach(function (x) { return Fields[x] = x; });
        })(BatchLogRow = Report.BatchLogRow || (Report.BatchLogRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var BatchLogService;
        (function (BatchLogService) {
            BatchLogService.baseUrl = 'Report/BatchLog';
            var Methods;
            (function (Methods) {
            })(Methods = BatchLogService.Methods || (BatchLogService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                BatchLogService[x] = function (r, s, o) {
                    return Q.serviceRequest(BatchLogService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = BatchLogService.baseUrl + '/' + x;
            });
        })(BatchLogService = Report.BatchLogService || (Report.BatchLogService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLoginDetailsForm = /** @class */ (function (_super) {
            __extends(UserLoginDetailsForm, _super);
            function UserLoginDetailsForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            UserLoginDetailsForm.formKey = 'Report.UserLoginDetails';
            return UserLoginDetailsForm;
        }(Serenity.PrefixedContext));
        Report.UserLoginDetailsForm = UserLoginDetailsForm;
        [,
            ['UserId', function () { return Serenity.IntegerEditor; }],
            ['LoginDatetime', function () { return Serenity.DateEditor; }],
            ['LogoutDatetime', function () { return Serenity.DateEditor; }],
            ['IsOnline', function () { return Serenity.IntegerEditor; }]
        ].forEach(function (x) {
            return Object.defineProperty(UserLoginDetailsForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLoginDetailsRow;
        (function (UserLoginDetailsRow) {
            UserLoginDetailsRow.idProperty = 'UserLoginDetailsId';
            UserLoginDetailsRow.localTextPrefix = 'Report.UserLoginDetails';
            var Fields;
            (function (Fields) {
            })(Fields = UserLoginDetailsRow.Fields || (UserLoginDetailsRow.Fields = {}));
            [
                'UserLoginDetailsId',
                'UserId',
                'LoginDatetime',
                'LogoutDatetime',
                'IsOnline',
                'UserEmployeeId',
                'UserFirstName',
                'UserLastName',
                'UserDepartmentId',
                'UserDesignation',
                'UserMobileCode',
                'UserMobileNumber',
                'UserEmail',
                'UserUsername',
                'UserPasswordHash',
                'UserPasswordSalt',
                'UserUserImage',
                'UserAddress',
                'UserCityId',
                'UserPinCode',
                'UserRoleId',
                'UserPasswordExpiryDate',
                'UserIsForgotPassword',
                'UserIsPasswordChangeOnLogin',
                'UserIsUserHidden',
                'UserStatusId',
                'UserCreatedBy',
                'UserCreatedDate',
                'UserUpdatedBy',
                'UserUpdatedDate'
            ].forEach(function (x) { return Fields[x] = x; });
        })(UserLoginDetailsRow = Report.UserLoginDetailsRow || (Report.UserLoginDetailsRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLoginDetailsService;
        (function (UserLoginDetailsService) {
            UserLoginDetailsService.baseUrl = 'Report/UserLoginDetails';
            var Methods;
            (function (Methods) {
            })(Methods = UserLoginDetailsService.Methods || (UserLoginDetailsService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                UserLoginDetailsService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserLoginDetailsService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = UserLoginDetailsService.baseUrl + '/' + x;
            });
        })(UserLoginDetailsService = Report.UserLoginDetailsService || (Report.UserLoginDetailsService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));



(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogForm = /** @class */ (function (_super) {
            __extends(UserLogForm, _super);
            function UserLogForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            UserLogForm.formKey = 'Report.UserLog';
            return UserLogForm;
        }(Serenity.PrefixedContext));
        Report.UserLogForm = UserLogForm;
        [,
            ['UserLogId', function () { return Serenity.IntegerEditor; }],
            ['UserId', function () { return Serenity.IntegerEditor; }],
            ['UserName', function () { return Serenity.StringEditor; }],
            ['Action', function () { return Serenity.StringEditor; }],
            ['ChangedOn', function () { return Serenity.DateEditor;}],
            
        ].forEach(function (x) {
            return Object.defineProperty(UserLogForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogArchiveForm = /** @class */ (function (_super) {
            __extends(UserLogArchiveForm, _super);
            function UserLogArchiveForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            UserLogArchiveForm.formKey = 'Report.UserLogArchive';
            return UserLogArchiveForm;
        }(Serenity.PrefixedContext));
        Report.UserLogArchiveForm = UserLogArchiveForm;
        [,
            ['UserLogArchiveId', function () { return Serenity.IntegerEditor; }],
            ['UserId', function () { return Serenity.IntegerEditor; }],
            ['UserName', function () { return Serenity.StringEditor; }],
            ['Action', function () { return Serenity.StringEditor; }],
            ['ChangedOn', function () { return Serenity.DateEditor; }],

        ].forEach(function (x) {
            return Object.defineProperty(UserLogArchiveForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogRow;
        (function (UserLogRow) {
            UserLogRow.idProperty = 'UserLogId';
            UserLogRow.nameProperty = 'UserName';
            UserLogRow.localTextPrefix = 'Report.UserLog';
            var Fields;
            (function (Fields) {
            })(Fields = UserLogRow.Fields || (UserLogRow.Fields = {}));
            [
                'UserLogId',
                'UserId',
                'UserName',
                'Action',
                'ChangedOn'
            ].forEach(function (x) { return Fields[x] = x; });
        })(UserLogRow = Report.UserLogRow || (Report.UserLogRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogArchiveRow;
        (function (UserLogArchiveRow) {
            UserLogArchiveRow.idProperty = 'UserLogArchiveId';
            UserLogArchiveRow.nameProperty = 'UserName';
            UserLogArchiveRow.localTextPrefix = 'Report.UserLogArchive';
            var Fields;
            (function (Fields) {
            })(Fields = UserLogArchiveRow.Fields || (UserLogArchiveRow.Fields = {}));
            [
                'UserLogArchiveId',
                'UserId',
                'UserName',
                'Action',
                'ChangedOn'
            ].forEach(function (x) { return Fields[x] = x; });
        })(UserLogArchiveRow = Report.UserLogArchiveRow || (Report.UserLogArchiveRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogService;
        (function (UserLogService) {
            UserLogService.baseUrl = 'Report/UserLog';
            var Methods;
            (function (Methods) {
            })(Methods = UserLogService.Methods || (UserLogService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                UserLogService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserLogService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = UserLogService.baseUrl + '/' + x;
            });
        })(UserLogService = Report.UserLogService || (Report.UserLogService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogArchiveService;
        (function (UserLogArchiveService) {
            UserLogArchiveService.baseUrl = 'Report/UserLogArchive';
            var Methods;
            (function (Methods) {
            })(Methods = UserLogArchiveService.Methods || (UserLogArchiveService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                UserLogArchiveService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserLogArchiveService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = UserLogArchiveService.baseUrl + '/' + x;
            });
        })(UserLogArchiveService = Report.UserLogArchiveService || (Report.UserLogArchiveService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


//# sourceMappingURL=CVC.Web.js.map

$(".ui-datepicker-trigger").click(function () {
    alert("ddd");
});

function downloadPdfReport(options) {
   // myoptions = options;
    var reportName = (options.grid.$displayName);
    var dateEmpty = false;
    var i = 0;
    var fromDate = "";
    var toDate = "";

    if (reportName == "Audit Log" || reportName == "Audit Log Archive") {
        var batchId = $("#CVC_Report_AuditLogGrid0_QuickFilter_BatchId").val();

        $(".hasDatepicker").each(function () {

            if ($(this).val() == "") {
                dateEmpty = true;
            }
            if (i == 0) {
                fromDate = ($(this).val());
            }
            else {
                toDate = ($(this).val());
            }
            i++;

        });


        if (batchId == "" && fromDate == "" && toDate == "") {
            Q.alert("Please select either Batch Number or From Date and To Date");
            return false;
        }
        else {

            if (batchId == "") {
                if (dateEmpty) {
                    Q.alert("Please select appropriate date range for print");
                    return false;
                }
                else {

                    if ($.datepicker.parseDate('mm/dd/yy', fromDate) <= $.datepicker.parseDate('mm/dd/yy', toDate)) {
                        //  alert("oak");
                    }
                    else {

                        Q.alert("From Date should be less than or equal to To Date");
                        return false;

                    }
                }

            }
            else {
                if (fromDate != "" || toDate != "") {

                    if (dateEmpty) {
                        Q.alert("Please select appropriate date range for print");
                        return false;
                    }

                    if ($.datepicker.parseDate('mm/dd/yy', fromDate) <= $.datepicker.parseDate('mm/dd/yy', toDate)) {
                        // alert("oak");
                    }
                    else {

                        Q.alert("From Date should be less than or equal to To Date");
                        return false;

                    }
                }


            }

        }

    }
    else {

        $(".hasDatepicker").each(function () {

            if ($(this).val() == "") {
                dateEmpty = true;
            }
            if (i == 0) {
                fromDate = ($(this).val());
            }
            else {
                toDate = ($(this).val());
            }
            i++;

        });
        if (dateEmpty) {
            Q.alert("Please select appropriate date range for print");
            return false;
        }
        else {
            if ($.datepicker.parseDate('mm/dd/yy', fromDate) <= $.datepicker.parseDate('mm/dd/yy', toDate)) {

            }
            else {

                Q.alert("From Date should be less than or equal to To Date");
                return false;

            }
        }
    }

    var reportDetails;

    var machine = {};
    $.ajax({
        async: false,
        type: "POST",
        url: Q.resolveUrl('~/api/Batch/GetReportDetails'),
        data: JSON.stringify(machine),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            reportDetails = response;

        },
        failure: function (response) {
            alert(response.responseText);

        },
        error: function (response) {
            alert(response.responseText);

        },
        complete: function (response) {
            //  alert("complete");
        }
    });

    if (reportDetails.Serial == null) {
        reportDetails.Serial = ""
    }

    if (reportDetails.Model == null) {
        reportDetails.Model = ""
    }
    var g = options.grid;
    if (!options.onViewSubmit())
        return;
    includeAutoTable();
    var request = Q.deepClone(g.view.params);
    request.Take = 0;
    request.Skip = 0;
    var sortBy = g.view.sortBy;
    if (sortBy != null)
        request.Sort = sortBy;
    var gridColumns = g.slickGrid.getColumns();
    gridColumns = gridColumns.filter(function (x) { return x.id !== "__select__"; });
    request.IncludeColumns = [];
    for (var _i = 0, gridColumns_1 = gridColumns; _i < gridColumns_1.length; _i++) {
        var column = gridColumns_1[_i];
        request.IncludeColumns.push(column.id || column.field);
    }
    Q.serviceCall({
        url: g.view.url,
        request: request,
        onSuccess: function (response) {
            hideLoader();
            var doc = new jsPDF('l', 'pt');
            var srcColumns = gridColumns;
            var columnStyles = {};
            var columns = toAutoTableColumns(srcColumns, columnStyles, options.columnTitles);
            var keys = columns.map(function (x) { return x.dataKey; });
            var entities = response.Entities || [];
            var data = toAutoTableData(entities, keys, srcColumns);
            doc.setFontSize(options.titleFontSize || 10);
            doc.setFontStyle('bold');
            var reportTitle = options.reportTitle || g.getTitle() || "Report";
            doc.autoTableText(reportTitle, doc.internal.pageSize.width / 2, options.titleTop || 25, { halign: 'center' });
            var totalPagesExp = "{{T}}";
            var pageNumbers = options.pageNumbers == null || options.pageNumbers;
            var autoOptions = $.extend({
                margin: { top: 60, left: 25, right: 25, bottom: pageNumbers ? 25 : 30 },
                startY: 60,
                styles: {
                    fontSize: 8,
                    overflow: 'linebreak',
                    cellPadding: 2,
                    valign: 'middle'
                },
                columnStyles: columnStyles
            }, options.tableOptions);
            if (pageNumbers) {
                var footer = function (data) {
                    var str = data.pageCount;
                    // Total page number plugin only available in jspdf v1.0+
                    if (typeof doc.putTotalPages === 'function') {
                        str = str + " / " + totalPagesExp;
                    }
                    doc.autoTableText(str, doc.internal.pageSize.width / 2, doc.internal.pageSize.height - autoOptions.margin.bottom, {
                        halign: 'center'
                    });
                };
                autoOptions.afterPageContent = footer;
            }
            // Print header of page
            if (options.printDateTimeHeader == null || options.printDateTimeHeader) {


                var beforePage = function (data) {
                    doc.setFontSize(options.titleFontSize || 10);
                    doc.setFontStyle('bold');
                    doc.autoTableText(reportTitle, doc.internal.pageSize.width / 2, options.titleTop || 25, { halign: 'center' });

                    doc.setFontStyle('normal');
                    doc.setFontSize(8);
                    // Date and time of the report
                    doc.autoTableText("Equipment Name: " + reportDetails.MachineName, doc.internal.pageSize.width - autoOptions.margin.right, 10, {
                        halign: 'right'
                    });

                    //doc.autoTableText("Serial Number: " + reportDetails.Serial, doc.internal.pageSize.width - autoOptions.margin.right, 20, {
                    //    halign: 'right'
                    //});

                    //doc.autoTableText("Model Number: " + reportDetails.Model, doc.internal.pageSize.width - autoOptions.margin.right, 30, {
                    //    halign: 'right'
                    //});
                    //EquipmentId
                    doc.autoTableText("Equipment ID: " + reportDetails.Serial, doc.internal.pageSize.width - autoOptions.margin.right, 20, {
                        halign: 'right'
                    });


                    //changes added By Vinayak On 31.07.2018

                    doc.autoTableText("Page Number: " + doc.internal.getNumberOfPages() + " of " + totalPagesExp, doc.internal.pageSize.width - autoOptions.margin.right, 30, {
                        halign: 'right'
                    });

                    //changes ended By Vinayak On 31.07.2018



                    doc.autoTableText(reportDetails.comname, autoOptions.margin.left + 45, 10, {
                        halign: 'left'
                    });

                    //doc.autoTableText(reportDetails.address, autoOptions.margin.left + 45, 20, {
                    //    halign: 'left'
                    //});

                    //doc.addImage('data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3NTc3Nzc3NjU3Ny01Nzc3NzUuNzUrLTc4LS01LzU1ODAvNzY3NS03KzU1KzU3LS0tN//AABEIACgAKAMBEQACEQEDEQH/xAAaAAEBAQADAQAAAAAAAAAAAAAGBQQCAwcB/8QAMxAAAQMCAgcFBwUAAAAAAAAAAQIDBAURABIGBxMhMVGRIkFhcaEUFSMyQmKBFiSxwdH/xAAbAQADAQEAAwAAAAAAAAAAAAAEBQYDAgABB//EAC0RAAEDAgQEBAcBAAAAAAAAAAEAAgMEEQUSITEGEyJRMnGRoRUjM0FhwfAU/9oADAMBAAIRAxEAPwAvpdHdn6XswkO3U7smmwTuQVG393xpiUvLJd9ghKJvywl8fVJBER1EyqSFSiew4ygJSgeKTe/UYh5eJnZ+lmiaCmFrqVI1R1BLlo9WhuI5uNrQegvgtnE8JHUyy4NO4LPN1W1KHS5koymZMhlKVtMRwbuAfPe/fbgBxxtFxBDLK1gFgd146nIChaEry1R5vN2XI5VbmQR/pwzrBduYoCpb0KpWoz9I0xFbmRnpMVCRLaDPC6bJQFn6U57XOCcSc2V74GnVe6L6Qcvg1m6Th8ul2EUE32Xs3ZHhe9/XCY4DRZb5fdGCdyvo1sL91Fxyir9tzZAtK/25Va/HiDbfl3+eFx4bZzNH9PutRUm2ynxtbFXRIC5VOgus33ttZkKt4Ek+owW7h6C1mGxXAqCsmh1OiLm1iXFlKdbjpSmPZOUFtw3ufuFgkjnfjgmunka1jCN/0hJ23icU+j02JUJWxmKKkTaa9GWzySlwEqB7j8T0GMMfnmgqXyAeEjX+8l1QAGJrUMkap6wmZkjT4TkUnc+4VJWB4oANz5HpjNnEVOY7uFndkSad104XoZTf0crR9K8rQ7ftSgMwevfaH87rct2EbcWmNZzyNO34W3KaG5V5yzqy0jXUBGeRGaj37UwOhSLcwn5ieQIHnikdj1I2LMDc9kOIH7J7Op0GlNvMxbJDMGPDQjvtnWvMfE8euE0VVLUuYXdys6zIyItXQxLjQqtAfkvJbIcUjf3hYym/IXsfxi14nijkoyB4kvwpkvNzW6UzffMdhTiWXninds2QCo9SB64+VRRB8gaTZUV+yBVCvUb3jZ7R1oykEo2LzyBvJubtC4Kr772J8cV8OFycnMJ7A+vruvYp2k3Ka0+RJks7WXEVDWrg2twKNu47uHliVqYGRy8tjsy80BQWWoyK1OmFeZL742QO6zaBlT1sT5EYp4GiOmawDZT1a7mS2WbQ2EKnpTDbk/FRmU47n33CUnd1thrE500vXqqqoa2KCwSaLNqOj7T7FSSqY3Bs24Ui72X6XOSkqTY34g3B4XwgxLDWGfK3QnZKWyubquCtZGjiU5i7JSrvBjquMC/A624tt5rv/S1Ea/p9NqclxulBUSBkKM7iRtXOZ+3+cU+EcORNs+fUrKSZ7tlPhVp+O20H0B9u1rk9tI8+/wDONKqkYJHALSehbIxsjRYr/9k=', 'jpg', autoOptions.margin.left, 10, 40, 40);
                    doc.addImage('data:image/' + reportDetails.logotype + ';base64,' + reportDetails.logo, reportDetails.logotype, autoOptions.margin.left, 10, 40, 40);
                };

                var afterPage = function (data) {
                    doc.setFontStyle('normal');
                    doc.setFontSize(8);
                    // Date and time of the report
                    doc.autoTableText("Report Generated By:" + reportDetails.generatedby, autoOptions.margin.left, doc.internal.pageSize.height - 35, {
                        halign: 'left'
                    });
                    doc.autoTableText("Generation Date Time:" + Q.formatDate(new Date(), "dd-MM-yyyy HH:mm"), autoOptions.margin.left, doc.internal.pageSize.height - 20, {
                        halign: 'left'
                    });


                    doc.autoTableText("Checked By:_________________", doc.internal.pageSize.width - autoOptions.margin.right, doc.internal.pageSize.height - 35, {
                        halign: 'right'
                    });
                    doc.autoTableText("Report Approved By:_________________", doc.internal.pageSize.width - autoOptions.margin.right, doc.internal.pageSize.height - 20, {
                        halign: 'right'
                    });
                };
                autoOptions.afterPageContent = afterPage;
                autoOptions.beforePageContent = beforePage;
            }
            doc.autoTable(columns, data, autoOptions);
            if (typeof doc.putTotalPages === 'function') {
                doc.putTotalPages(totalPagesExp);
            }
            if (!options.output || options.output == "file") {
                var fileName = options.fileName || options.reportTitle || "{0}_{1}.pdf";
                fileName = Q.format(fileName, g.getTitle() || "report", Q.formatDate(new Date(), "yyyyMMdd_HHmm"));
                doc.save(fileName);
                return;
            }
            if (options.autoPrint)
                doc.autoPrint();
            var output = options.output;
            if (output == 'newwindow' || '_blank')
                output = 'dataurlnewwindow';
            else if (output == 'window')
                output = 'datauri';
            doc.output(output);


        }

    });

}
function includeAutoTable() {
    includeJsPDF();
    if (typeof jsPDF === "undefined" ||
        typeof jsPDF.API == "undefined" ||
        typeof jsPDF.API.autoTable !== "undefined")
        return;
    var script = $("jsPDFAutoTableScript");
    if (script.length > 0)
        return;
    $("<script/>")
        .attr("type", "text/javascript")
        .attr("id", "jsPDFAutoTableScript")
        .attr("src", Q.resolveUrl("~/Scripts/jspdf.plugin.autotable.min.js"))
        .appendTo(document.head);
}
function includeJsPDF() {
    if (typeof jsPDF !== "undefined")
        return;
    var script = $("jsPDFScript");
    if (script.length > 0)
        return;
    $("<script/>")
        .attr("type", "text/javascript")
        .attr("id", "jsPDFScript")
        .attr("src", Q.resolveUrl("~/Scripts/jspdf.min.js"))
        .appendTo(document.head);
}

function toAutoTableColumns(srcColumns, columnStyles, columnTitles) {
    return srcColumns.map(function (src) {
        var col = {
            dataKey: src.id || src.field,
            title: src.name || ''
        };
        if (columnTitles && columnTitles[col.dataKey] != null)
            col.title = columnTitles[col.dataKey];
        var style = {};
        if ((src.cssClass || '').indexOf("align-right") >= 0)
            style.halign = 'right';
        else if ((src.cssClass || '').indexOf("align-center") >= 0)
            style.halign = 'center';
        columnStyles[col.dataKey] = style;
        return col;
    });
}
function toAutoTableData(entities, keys, srcColumns) {
    var el = document.createElement('span');
    var row = 0;
    return entities.map(function (item) {
        var dst = {};
        for (var cell = 0; cell < srcColumns.length; cell++) {
            var src = srcColumns[cell];
            var fld = src.field || '';
            var key = keys[cell];
            var txt = void 0;
            var html = void 0;
            if (src.formatter) {
                html = src.formatter(row, cell, item[fld], src, item);
            }
            else if (src.format) {
                html = src.format({ row: row, cell: cell, item: item, value: item[fld] });
            }
            else {
                dst[key] = item[fld];
                continue;
            }
            if (!html || (html.indexOf('<') < 0 && html.indexOf('&') < 0))
                dst[key] = html;
            else {
                el.innerHTML = html;
                if (el.children.length == 1 &&
                    $(el.children[0]).is(":input")) {
                    dst[key] = $(el.children[0]).val();
                }
                else if (el.children.length == 1 &&
                    $(el.children).is('.check-box')) {
                    dst[key] = $(el.children).hasClass("checked") ? "X" : "";
                }
                else
                    dst[key] = el.textContent || '';
            }
        }
        row++;
        return dst;
    });
}

function hideLoader() {
    $('.loader').addClass('hidden');
}

var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var NewLanguageGrid = /** @class */ (function (_super) {
            __extends(NewLanguageGrid, _super);
            function NewLanguageGrid(container) {
                return _super.call(this, container) || this;
            }
            NewLanguageGrid.prototype.getColumnsKey = function () { return 'Configuration.Language'; };
            NewLanguageGrid.prototype.getDialogType = function () { return Configuration.NewLanguageDialog; };
            NewLanguageGrid.prototype.getIdProperty = function () { return Configuration.NewLanguageRow.idProperty; };
            NewLanguageGrid.prototype.getLocalTextPrefix = function () { return Configuration.NewLanguageRow.localTextPrefix; };
            NewLanguageGrid.prototype.getService = function () { return Configuration.NewLanguageService.baseUrl; };
            NewLanguageGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };
            NewLanguageGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], NewLanguageGrid);
            return NewLanguageGrid;
        }(Serenity.EntityGrid));
        Configuration.NewLanguageGrid = NewLanguageGrid;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));

var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var NewLanguageDialog = /** @class */ (function (_super) {
            __extends(NewLanguageDialog, _super);
            function NewLanguageDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Configuration.NewLanguageForm(_this.idPrefix);
                return _this;
            }
            NewLanguageDialog.prototype.getFormKey = function () { return Configuration.NewLanguageForm.formKey; };
            NewLanguageDialog.prototype.getIdProperty = function () { return Configuration.NewLanguageRow.idProperty; };
            NewLanguageDialog.prototype.getLocalTextPrefix = function () { return Configuration.NewLanguageRow.localTextPrefix; };
            NewLanguageDialog.prototype.getNameProperty = function () { return Configuration.NewLanguageRow.nameProperty; };
            NewLanguageDialog.prototype.getService = function () { return Configuration.NewLanguageService.baseUrl; };
            NewLanguageDialog.prototype.getToolbarButtons = function () {
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "apply-changes-button"; }), 1);
                return buttons;
            };
            NewLanguageDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };


            //NewLanguageDialog.prototype.onDialogOpen = function () {
            //    $("input[name='DepartmentCode'],input[name='DepartmentName']").keyboard({
            //        layout: 'custom',
            //        customLayout: alphanumericKeyboard

            //    })

            //}

            NewLanguageDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], NewLanguageDialog);
            return NewLanguageDialog;
        }(Serenity.EntityDialog));
        Configuration.NewLanguageDialog = NewLanguageDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));




var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var ExceptionLogGrid = /** @class */ (function (_super) {
            __extends(ExceptionLogGrid, _super);
            function ExceptionLogGrid(container) {
                return _super.call(this, container) || this;
            }
            ExceptionLogGrid.prototype.getColumnsKey = function () { return 'Report.ExceptionLog'; };
            ExceptionLogGrid.prototype.getDialogType = function () { return Report.ExceptionLogDialog; };
            ExceptionLogGrid.prototype.getIdProperty = function () { return Report.ExceptionLogRow.idProperty; };
            ExceptionLogGrid.prototype.getLocalTextPrefix = function () { return Report.ExceptionLogRow.localTextPrefix; };
          //  ExceptionLogGrid.prototype.getService = function () { return Report.ExceptionLogService.baseUrl; };
            ExceptionLogGrid.prototype.getButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getButtons.call(this);
                buttons.splice(Q.indexOf(buttons, function (x) { return x.cssClass == "add-button"; }), 1);
                buttons.push(CVC.Common.PdfExportHelper.createToolButton({
                    grid: this,
                    onViewSubmit: function () { return _this.onViewSubmit(); }
                }));
                return buttons;
            };

            ExceptionLogGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ExceptionLogGrid);
            return ExceptionLogGrid;
        }(Serenity.EntityGrid));
        Report.ExceptionLogGrid = ExceptionLogGrid;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var ExceptionLogDialog = /** @class */ (function (_super) {
            __extends(ExceptionLogDialog, _super);
            function ExceptionLogDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Report.ExceptionLogForm(_this.idPrefix);
                return _this;
            }
            ExceptionLogDialog.prototype.getFormKey = function () { return Report.ExceptionLogForm.formKey; };
            ExceptionLogDialog.prototype.getIdProperty = function () { return Report.ExceptionLogRow.idProperty; };
            ExceptionLogDialog.prototype.getLocalTextPrefix = function () { return Report.ExceptionLogRow.localTextPrefix; };
            ExceptionLogDialog.prototype.getNameProperty = function () { return Report.ExceptionLogRow.nameProperty; };
            ExceptionLogDialog.prototype.getService = function () { return Report.ExceptionLogService.baseUrl; };

            ExceptionLogDialog = __decorate([
                Serenity.Decorators.registerClass(),
                Serenity.Decorators.responsive()
            ], ExceptionLogDialog);
            return ExceptionLogDialog;
        }(Serenity.EntityDialog));
        Report.ExceptionLogDialog = ExceptionLogDialog;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

(function (CVC) {
    var Report;
    (function (Report) {
        var ExceptionLogForm = /** @class */ (function (_super) {
            __extends(ExceptionLogForm, _super);
            function ExceptionLogForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            ExceptionLogForm.formKey = 'Report.ExceptionLog';
            return ExceptionLogForm;
        }(Serenity.PrefixedContext));
        Report.ExceptionLogForm = ExceptionLogForm;
        [,
            ['Id', function () { return Serenity.IntegerEditor; }],
            ['Type', function () { return Serenity.StringEditor; }],
            ['Url', function () { return Serenity.StringEditor; }],
            ['Message', function () { return Serenity.StringEditor; }],

        ].forEach(function (x) {
            return Object.defineProperty(ExceptionLogForm.prototype, x[0], {
                get: function () {
                    return this.w(x[0], x[1]());
                },
                enumerable: true,
                configurable: true
            });
        });
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));


var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var ExceptionLogRow;
        (function (ExceptionLogRow) {
            ExceptionLogRow.idProperty = 'Id';
            ExceptionLogRow.nameProperty = 'Message';
            ExceptionLogRow.localTextPrefix = 'Report.ExceptionLog';
            var Fields;
            (function (Fields) {
            })(Fields = ExceptionLogRow.Fields || (ExceptionLogRow.Fields = {}));
            [
                'Id',
                'Type',
                'Url',
                'Message'
            ].forEach(function (x) { return Fields[x] = x; });
        })(ExceptionLogRow = Report.ExceptionLogRow || (Report.ExceptionLogRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));



var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var ExceptionLogService;
        (function (ExceptionLogService) {
            ExceptionLogService.baseUrl = 'Report/ExceptionLog';
            var Methods;
            (function (Methods) {
            })(Methods = ExceptionLogService.Methods || (ExceptionLogService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ExceptionLogService[x] = function (r, s, o) {
                    return Q.serviceRequest(ExceptionLogService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = ExceptionLogService.baseUrl + '/' + x;
            });
        })(ExceptionLogService = Report.ExceptionLogService || (Report.ExceptionLogService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));

function connectToOpcUaClient(machineId, opcUaClientCertificateType) {
    debugger;
    redirectUrlAfterLogin = "";
    autoAcceptUntrustedCertificatesForOpcUaClient = false;
    autoAcceptRejectCertificatesForOpcUaClient = false;
    machineIdForOpcUaClient = machineId;
    showLoader();
    $.ajax({
        async: true,
        type: "GET",
        url: Q.resolveUrl('~/OpcUaClient/connectToOpcUaClient'),
        data: {
            "machineId": machineId, "certificateType": opcUaClientCertificateType
        },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {

           // setTimeout(function () { mgrid.refresh(); }, 2500);

           hideLoader();
            if (response.Item1) {

            }
            else {

                if (response.Item2.includes("Certificate is not trusted")) {
                    requestType = "opcUaClient";
                    autoAcceptUntrustedCertificatesForOpcUaClient = true;
                    autoAcceptRejectCertificatesForOpcUaClient = true;
                    $("#btnInfoCancel").attr("style", "display:block");

                }
                $("#infoModalBody").text(response.Item2);
                $("#modal-info").modal('show');

            }

        },
        failure: function (response) {
            hideLoader();
        },
        error: function (response) {
            hideLoader();
        }
    });

}

function fetch(machineId) {
    window.location.href = "/OPCUaClient/Index?id=" + machineId;
}

function showLoader() {
    $('.loader').removeClass('hidden');
}

function hideLoader() {
    $('.loader').addClass('hidden');
}

function importFile(formName) {
    addAuditLog(formName);
    window.location.href = "/ImportFile/Index?name=" + formName;
}

function addAuditLog(formName) {
    debugger;
    var parameter = {
        "Action": "Import data of " + formName + " form started", "Module": formName, "RequestPanel":"Import"
    };
    $.ajax({
        url: Q.resolveUrl('~/Common/AddAuditLog'),
        type: 'POST',
        async: true,
        data: parameter,
        success: function (data) {
        },
        error: function (x, y, z) {

        }
    });

}

$(".panel-titlebar-close").click(function () {
    alert("Handler for .click() called.");
});

var CVC;
(function (CVC) {
    var DynamicEntityGrid = /** @class */ (function (_super) {
        __extends(DynamicEntityGrid, _super);
        function DynamicEntityGrid() {
            var _this = _super !== null && _super.apply(this, arguments) || this;

            _this.reportType = 0;

            return _this;
        }
        DynamicEntityGrid.prototype.getColumns = function () {

            var loadedColumns = loadColumns(this.getService(), this.getColumnsKey()).Columns;

            return this.propertyItemsToSlickColumns(loadedColumns);
            //return _super.prototype.getColumns.call(this);
        };
        DynamicEntityGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], DynamicEntityGrid);


        function loadColumns(url, columnName) {
            // strUrl is whatever URL you need to call
            var strUrl = '/Services/' + url + '/getColumns', strReturn = "";

            jQuery.ajax({
                url: strUrl,
                data: {
                    Name: columnName
                },
                success: function (html) {
                    strReturn = html;
                },
                async: false
            });
            return strReturn;
        }

        return DynamicEntityGrid;
    }(Serenity.EntityGrid));
    CVC.DynamicEntityGrid = DynamicEntityGrid;
})(CVC || (CVC = {}));







