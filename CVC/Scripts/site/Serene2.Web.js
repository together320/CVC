﻿var __extends = (this && this.__extends) || (function () {
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
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var ProtocolDialog = (function (_super) {
            __extends(ProtocolDialog, _super);
            function ProtocolDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Newcon.ProtocolForm(_this.idPrefix);
                return _this;
            }
            ProtocolDialog.prototype.getFormKey = function () { return Newcon.ProtocolForm.formKey; };
            ProtocolDialog.prototype.getIdProperty = function () { return Newcon.ProtocolRow.idProperty; };
            ProtocolDialog.prototype.getLocalTextPrefix = function () { return Newcon.ProtocolRow.localTextPrefix; };
            ProtocolDialog.prototype.getNameProperty = function () { return Newcon.ProtocolRow.nameProperty; };
            ProtocolDialog.prototype.getService = function () { return Newcon.ProtocolService.baseUrl; };
            return ProtocolDialog;
        }(Serenity.EntityDialog));
        ProtocolDialog = __decorate([
            Serenity.Decorators.registerClass(),
            Serenity.Decorators.responsive()
        ], ProtocolDialog);
        Newcon.ProtocolDialog = ProtocolDialog;
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var ProtocolGrid = (function (_super) {
            __extends(ProtocolGrid, _super);
            function ProtocolGrid(container) {
                return _super.call(this, container) || this;
            }
            ProtocolGrid.prototype.getColumnsKey = function () { return 'Newcon.Protocol'; };
            ProtocolGrid.prototype.getDialogType = function () { return Newcon.ProtocolDialog; };
            ProtocolGrid.prototype.getIdProperty = function () { return Newcon.ProtocolRow.idProperty; };
            ProtocolGrid.prototype.getLocalTextPrefix = function () { return Newcon.ProtocolRow.localTextPrefix; };
            ProtocolGrid.prototype.getService = function () { return Newcon.ProtocolService.baseUrl; };
            return ProtocolGrid;
        }(Serenity.EntityGrid));
        ProtocolGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], ProtocolGrid);
        Newcon.ProtocolGrid = ProtocolGrid;
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var MachineParameterDialog = (function (_super) {
            __extends(MachineParameterDialog, _super);
            function MachineParameterDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Newcon.MachineParameterForm(_this.idPrefix);
                return _this;
            }
            MachineParameterDialog.prototype.getFormKey = function () { return Newcon.MachineParameterForm.formKey; };
            MachineParameterDialog.prototype.getIdProperty = function () { return Newcon.MachineParameterRow.idProperty; };
            MachineParameterDialog.prototype.getLocalTextPrefix = function () { return Newcon.MachineParameterRow.localTextPrefix; };
            MachineParameterDialog.prototype.getNameProperty = function () { return Newcon.MachineParameterRow.nameProperty; };
            MachineParameterDialog.prototype.getService = function () { return Newcon.MachineParameterService.baseUrl; };
            return MachineParameterDialog;
        }(Serenity.EntityDialog));
        MachineParameterDialog = __decorate([
            Serenity.Decorators.registerClass(),
            Serenity.Decorators.responsive()
        ], MachineParameterDialog);
        Newcon.MachineParameterDialog = MachineParameterDialog;
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var MachineParameterGrid = (function (_super) {
            __extends(MachineParameterGrid, _super);
            function MachineParameterGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineParameterGrid.prototype.getColumnsKey = function () { return 'Newcon.MachineParameter'; };
            MachineParameterGrid.prototype.getDialogType = function () { return Newcon.MachineParameterDialog; };
            MachineParameterGrid.prototype.getIdProperty = function () { return Newcon.MachineParameterRow.idProperty; };
            MachineParameterGrid.prototype.getLocalTextPrefix = function () { return Newcon.MachineParameterRow.localTextPrefix; };
            MachineParameterGrid.prototype.getService = function () { return Newcon.MachineParameterService.baseUrl; };
            return MachineParameterGrid;
        }(Serenity.EntityGrid));
        MachineParameterGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], MachineParameterGrid);
        Newcon.MachineParameterGrid = MachineParameterGrid;
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var MachineCommunicationDialog = (function (_super) {
            __extends(MachineCommunicationDialog, _super);
            function MachineCommunicationDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Newcon.MachineCommunicationForm(_this.idPrefix);
                return _this;
            }
            MachineCommunicationDialog.prototype.getFormKey = function () { return Newcon.MachineCommunicationForm.formKey; };
            MachineCommunicationDialog.prototype.getIdProperty = function () { return Newcon.MachineCommunicationRow.idProperty; };
            MachineCommunicationDialog.prototype.getLocalTextPrefix = function () { return Newcon.MachineCommunicationRow.localTextPrefix; };
            MachineCommunicationDialog.prototype.getNameProperty = function () { return Newcon.MachineCommunicationRow.nameProperty; };
            MachineCommunicationDialog.prototype.getService = function () { return Newcon.MachineCommunicationService.baseUrl; };
            return MachineCommunicationDialog;
        }(Serenity.EntityDialog));
        MachineCommunicationDialog = __decorate([
            Serenity.Decorators.registerClass(),
            Serenity.Decorators.responsive()
        ], MachineCommunicationDialog);
        Newcon.MachineCommunicationDialog = MachineCommunicationDialog;
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var MachineCommunicationGrid = (function (_super) {
            __extends(MachineCommunicationGrid, _super);
            function MachineCommunicationGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineCommunicationGrid.prototype.getColumnsKey = function () { return 'Newcon.MachineCommunication'; };
            MachineCommunicationGrid.prototype.getDialogType = function () { return Newcon.MachineCommunicationDialog; };
            MachineCommunicationGrid.prototype.getIdProperty = function () { return Newcon.MachineCommunicationRow.idProperty; };
            MachineCommunicationGrid.prototype.getLocalTextPrefix = function () { return Newcon.MachineCommunicationRow.localTextPrefix; };
            MachineCommunicationGrid.prototype.getService = function () { return Newcon.MachineCommunicationService.baseUrl; };
            return MachineCommunicationGrid;
        }(Serenity.EntityGrid));
        MachineCommunicationGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], MachineCommunicationGrid);
        Newcon.MachineCommunicationGrid = MachineCommunicationGrid;
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var HmiParameterDialog = (function (_super) {
            __extends(HmiParameterDialog, _super);
            function HmiParameterDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Newcon.HmiParameterForm(_this.idPrefix);
                return _this;
            }
            HmiParameterDialog.prototype.getFormKey = function () { return Newcon.HmiParameterForm.formKey; };
            HmiParameterDialog.prototype.getIdProperty = function () { return Newcon.HmiParameterRow.idProperty; };
            HmiParameterDialog.prototype.getLocalTextPrefix = function () { return Newcon.HmiParameterRow.localTextPrefix; };
            HmiParameterDialog.prototype.getNameProperty = function () { return Newcon.HmiParameterRow.nameProperty; };
            HmiParameterDialog.prototype.getService = function () { return Newcon.HmiParameterService.baseUrl; };
            return HmiParameterDialog;
        }(Serenity.EntityDialog));
        HmiParameterDialog = __decorate([
            Serenity.Decorators.registerClass(),
            Serenity.Decorators.responsive()
        ], HmiParameterDialog);
        Newcon.HmiParameterDialog = HmiParameterDialog;
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var HmiParameterGrid = (function (_super) {
            __extends(HmiParameterGrid, _super);
            function HmiParameterGrid(container) {
                return _super.call(this, container) || this;
            }
            HmiParameterGrid.prototype.getColumnsKey = function () { return 'Newcon.HmiParameter'; };
            HmiParameterGrid.prototype.getDialogType = function () { return Newcon.HmiParameterDialog; };
            HmiParameterGrid.prototype.getIdProperty = function () { return Newcon.HmiParameterRow.idProperty; };
            HmiParameterGrid.prototype.getLocalTextPrefix = function () { return Newcon.HmiParameterRow.localTextPrefix; };
            HmiParameterGrid.prototype.getService = function () { return Newcon.HmiParameterService.baseUrl; };
            return HmiParameterGrid;
        }(Serenity.EntityGrid));
        HmiParameterGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], HmiParameterGrid);
        Newcon.HmiParameterGrid = HmiParameterGrid;
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var DataTypeDialog = (function (_super) {
            __extends(DataTypeDialog, _super);
            function DataTypeDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Newcon.DataTypeForm(_this.idPrefix);
                return _this;
            }
            DataTypeDialog.prototype.getFormKey = function () { return Newcon.DataTypeForm.formKey; };
            DataTypeDialog.prototype.getIdProperty = function () { return Newcon.DataTypeRow.idProperty; };
            DataTypeDialog.prototype.getLocalTextPrefix = function () { return Newcon.DataTypeRow.localTextPrefix; };
            DataTypeDialog.prototype.getNameProperty = function () { return Newcon.DataTypeRow.nameProperty; };
            DataTypeDialog.prototype.getService = function () { return Newcon.DataTypeService.baseUrl; };
            return DataTypeDialog;
        }(Serenity.EntityDialog));
        DataTypeDialog = __decorate([
            Serenity.Decorators.registerClass(),
            Serenity.Decorators.responsive()
        ], DataTypeDialog);
        Newcon.DataTypeDialog = DataTypeDialog;
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var DataTypeGrid = (function (_super) {
            __extends(DataTypeGrid, _super);
            function DataTypeGrid(container) {
                return _super.call(this, container) || this;
            }
            DataTypeGrid.prototype.getColumnsKey = function () { return 'Newcon.DataType'; };
            DataTypeGrid.prototype.getDialogType = function () { return Newcon.DataTypeDialog; };
            DataTypeGrid.prototype.getIdProperty = function () { return Newcon.DataTypeRow.idProperty; };
            DataTypeGrid.prototype.getLocalTextPrefix = function () { return Newcon.DataTypeRow.localTextPrefix; };
            DataTypeGrid.prototype.getService = function () { return Newcon.DataTypeService.baseUrl; };
            return DataTypeGrid;
        }(Serenity.EntityGrid));
        DataTypeGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], DataTypeGrid);
        Newcon.DataTypeGrid = DataTypeGrid;
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var SignUpPanel = (function (_super) {
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
            return SignUpPanel;
        }(Serenity.PropertyPanel));
        SignUpPanel = __decorate([
            Serenity.Decorators.registerClass()
        ], SignUpPanel);
        Membership.SignUpPanel = SignUpPanel;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ResetPasswordPanel = (function (_super) {
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
            return ResetPasswordPanel;
        }(Serenity.PropertyPanel));
        ResetPasswordPanel = __decorate([
            Serenity.Decorators.registerClass()
        ], ResetPasswordPanel);
        Membership.ResetPasswordPanel = ResetPasswordPanel;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ForgotPasswordPanel = (function (_super) {
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
            ForgotPasswordPanel.prototype.getFormKey = function () { return Membership.ForgotPasswordForm.formKey; };
            return ForgotPasswordPanel;
        }(Serenity.PropertyPanel));
        ForgotPasswordPanel = __decorate([
            Serenity.Decorators.registerClass()
        ], ForgotPasswordPanel);
        Membership.ForgotPasswordPanel = ForgotPasswordPanel;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ChangePasswordPanel = (function (_super) {
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
            return ChangePasswordPanel;
        }(Serenity.PropertyPanel));
        ChangePasswordPanel = __decorate([
            Serenity.Decorators.registerClass()
        ], ChangePasswordPanel);
        Membership.ChangePasswordPanel = ChangePasswordPanel;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineDialog = (function (_super) {
            __extends(MachineLineDialog, _super);
            function MachineLineDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.MachineLineForm(_this.idPrefix);
                return _this;
            }
            MachineLineDialog.prototype.getFormKey = function () { return MachineCustomization.MachineLineForm.formKey; };
            MachineLineDialog.prototype.getIdProperty = function () { return MachineCustomization.MachineLineRow.idProperty; };
            MachineLineDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineLineRow.localTextPrefix; };
            MachineLineDialog.prototype.getNameProperty = function () { return MachineCustomization.MachineLineRow.nameProperty; };
            MachineLineDialog.prototype.getService = function () { return MachineCustomization.MachineLineService.baseUrl; };
            return MachineLineDialog;
        }(Serenity.EntityDialog));
        MachineLineDialog = __decorate([
            Serenity.Decorators.registerClass(),
            Serenity.Decorators.responsive()
        ], MachineLineDialog);
        MachineCustomization.MachineLineDialog = MachineLineDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineLineGrid = (function (_super) {
            __extends(MachineLineGrid, _super);
            function MachineLineGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineLineGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.MachineLine'; };
            MachineLineGrid.prototype.getDialogType = function () { return MachineCustomization.MachineLineDialog; };
            MachineLineGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineLineRow.idProperty; };
            MachineLineGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineLineRow.localTextPrefix; };
            MachineLineGrid.prototype.getService = function () { return MachineCustomization.MachineLineService.baseUrl; };
            return MachineLineGrid;
        }(Serenity.EntityGrid));
        MachineLineGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], MachineLineGrid);
        MachineCustomization.MachineLineGrid = MachineLineGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var MachineCustomization;
(function (MachineCustomization_1) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineDialog = (function (_super) {
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
            return MachineDialog;
        }(Serenity.EntityDialog));
        MachineDialog = __decorate([
            Serenity.Decorators.registerClass(),
            Serenity.Decorators.responsive()
        ], MachineDialog);
        MachineCustomization.MachineDialog = MachineDialog;
    })(MachineCustomization = MachineCustomization_1.MachineCustomization || (MachineCustomization_1.MachineCustomization = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization_2) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineGrid = (function (_super) {
            __extends(MachineGrid, _super);
            function MachineGrid(container) {
                return _super.call(this, container) || this;
            }
            MachineGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.Machine'; };
            MachineGrid.prototype.getDialogType = function () { return MachineCustomization.MachineDialog; };
            MachineGrid.prototype.getIdProperty = function () { return MachineCustomization.MachineRow.idProperty; };
            MachineGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.MachineRow.localTextPrefix; };
            MachineGrid.prototype.getService = function () { return MachineCustomization.MachineService.baseUrl; };
            return MachineGrid;
        }(Serenity.EntityGrid));
        MachineGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], MachineGrid);
        MachineCustomization.MachineGrid = MachineGrid;
    })(MachineCustomization = MachineCustomization_2.MachineCustomization || (MachineCustomization_2.MachineCustomization = {}));
})(MachineCustomization || (MachineCustomization = {}));
var CVC;
(function (CVC) {
    var LanguageList;
    (function (LanguageList) {
        function getValue() {
            var result = [];
            for (var _i = 0, _a = CVC.Administration.LanguageRow.getLookup().items; _i < _a.length; _i++) {
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
        var UserPreferenceStorage = (function () {
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
                            margin: { top: 25, left: 25, right: 25, bottom: pageNumbers ? 25 : 30 },
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
                                doc.setFontStyle('normal');
                                doc.setFontSize(8);
                                // Date and time of the report
                                doc.autoTableText(Q.formatDate(new Date(), "dd-MM-yyyy HH:mm"), doc.internal.pageSize.width - autoOptions.margin.right, 13, {
                                    halign: 'right'
                                });
                            };
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
        var ReportDialog = (function (_super) {
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
        var ReportPage = (function (_super) {
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
        var LanguageSelection = (function (_super) {
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
                Q.getLookupAsync('Administration.Language').then(function (x) {
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
        var SidebarSearch = (function (_super) {
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
        var ThemeSelection = (function (_super) {
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
    var BasicProgressDialog = (function (_super) {
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
        var BulkServiceAction = (function () {
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
    })(DialogUtils = CVC.DialogUtils || (CVC.DialogUtils = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var EnumSelectFormatter = (function () {
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
            return EnumSelectFormatter;
        }());
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
        var GridEditorBase = (function (_super) {
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
            return GridEditorBase;
        }(Serenity.EntityGrid));
        GridEditorBase = __decorate([
            Serenity.Decorators.registerClass([Serenity.IGetEditValue, Serenity.ISetEditValue]),
            Serenity.Decorators.editor(),
            Serenity.Decorators.element("<div/>")
        ], GridEditorBase);
        Common.GridEditorBase = GridEditorBase;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var GridEditorDialog = (function (_super) {
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
            return GridEditorDialog;
        }(Serenity.EntityDialog));
        GridEditorDialog = __decorate([
            Serenity.Decorators.registerClass()
        ], GridEditorDialog);
        Common.GridEditorDialog = GridEditorDialog;
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleCheckEditor = (function (_super) {
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
                return Administration.RoleRow.getLookup().items.map(function (role) { return ({
                    id: role.RoleId.toString(),
                    text: role.RoleName
                }); });
            };
            RoleCheckEditor.prototype.onViewFilter = function (item) {
                return _super.prototype.onViewFilter.call(this, item) &&
                    (Q.isEmptyOrNull(this.searchText) ||
                        Select2.util.stripDiacritics(item.text || '')
                            .toUpperCase().indexOf(this.searchText) >= 0);
            };
            return RoleCheckEditor;
        }(Serenity.CheckTreeEditor));
        RoleCheckEditor = __decorate([
            Serenity.Decorators.registerEditor()
        ], RoleCheckEditor);
        Administration.RoleCheckEditor = RoleCheckEditor;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserRoleDialog = (function (_super) {
            __extends(UserRoleDialog, _super);
            function UserRoleDialog(opt) {
                var _this = _super.call(this, opt) || this;
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
            return UserRoleDialog;
        }(Serenity.TemplatedDialog));
        UserRoleDialog = __decorate([
            Serenity.Decorators.registerClass()
        ], UserRoleDialog);
        Administration.UserRoleDialog = UserRoleDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var PermissionCheckEditor = (function (_super) {
            __extends(PermissionCheckEditor, _super);
            function PermissionCheckEditor(container, opt) {
                var _this = _super.call(this, container, opt) || this;
                _this._rolePermissions = {};
                _this._implicitPermissions = {};
                var titleByKey = {};
                var permissionKeys = _this.getSortedGroupAndPermissionKeys(titleByKey);
                var items = permissionKeys.map(function (key) { return ({
                    Key: key,
                    ParentKey: _this.getParentKey(key),
                    Title: titleByKey[key],
                    GrantRevoke: null,
                    IsGroup: key.charAt(key.length - 1) === ':'
                }); });
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
                    var grantCount = Q.count(desc, function (x) { return x.GrantRevoke === true ||
                        (x.GrantRevoke == null && _this.roleOrImplicit(x.Key)); });
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
            return PermissionCheckEditor;
        }(Serenity.DataGrid));
        PermissionCheckEditor = __decorate([
            Serenity.Decorators.registerEditor([Serenity.IGetEditValue, Serenity.ISetEditValue])
        ], PermissionCheckEditor);
        Administration.PermissionCheckEditor = PermissionCheckEditor;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserPermissionDialog = (function (_super) {
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
            return UserPermissionDialog;
        }(Serenity.TemplatedDialog));
        UserPermissionDialog = __decorate([
            Serenity.Decorators.registerClass()
        ], UserPermissionDialog);
        Administration.UserPermissionDialog = UserPermissionDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserDialog = (function (_super) {
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
                buttons.push({
                    title: Q.text('Site.UserDialog.EditPermissionsButton'),
                    cssClass: 'edit-permissions-button',
                    icon: 'icon-lock-open text-green',
                    onClick: function () {
                        new Administration.UserPermissionDialog({
                            userID: _this.entity.UserId,
                            username: _this.entity.Username
                        }).dialogOpen();
                    }
                });
                return buttons;
            };
            UserDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton('edit-roles-button').toggleClass('disabled', this.isNewOrDeleted());
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            UserDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                // these fields are only required in new record mode
                this.form.Password.element.toggleClass('required', this.isNew())
                    .closest('.field').find('sup').toggle(this.isNew());
                this.form.PasswordConfirm.element.toggleClass('required', this.isNew())
                    .closest('.field').find('sup').toggle(this.isNew());
            };
            return UserDialog;
        }(Serenity.EntityDialog));
        UserDialog = __decorate([
            Serenity.Decorators.registerClass()
        ], UserDialog);
        Administration.UserDialog = UserDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserGrid = (function (_super) {
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
            return UserGrid;
        }(Serenity.EntityGrid));
        UserGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], UserGrid);
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
        var TranslationGrid = (function (_super) {
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
            TranslationGrid.prototype.getLocalTextPrefix = function () { return "Administration.Translation"; };
            TranslationGrid.prototype.getService = function () { return Administration.TranslationService.baseUrl; };
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
                    format: function (ctx) { return Q.outerHtml($('<input/>')
                        .addClass('custom-text')
                        .attr('value', ctx.value)
                        .attr('type', 'text')
                        .attr('data-key', ctx.item.Key)); }
                });
                columns.push({
                    field: 'TargetText',
                    width: 300,
                    sortable: false,
                    format: function (ctx) { return Q.outerHtml($('<a/>')
                        .addClass('target-text')
                        .text(ctx.value || '')); }
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
                    element: function (el) { return el.appendTo(_this.toolbar.element).attr('placeholder', '--- ' +
                        Q.text('Db.Administration.Translation.SourceLanguage') + ' ---'); },
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
                    element: function (el) { return el.appendTo(_this.toolbar.element).attr('placeholder', '--- ' +
                        Q.text('Db.Administration.Translation.TargetLanguage') + ' ---'); },
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
                return Promise.resolve(Administration.TranslationService.Update({
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
            return TranslationGrid;
        }(Serenity.EntityGrid));
        TranslationGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], TranslationGrid);
        Administration.TranslationGrid = TranslationGrid;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RolePermissionDialog = (function (_super) {
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
            return RolePermissionDialog;
        }(Serenity.TemplatedDialog));
        RolePermissionDialog = __decorate([
            Serenity.Decorators.registerClass()
        ], RolePermissionDialog);
        Administration.RolePermissionDialog = RolePermissionDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleDialog = (function (_super) {
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
            RoleDialog.prototype.getToolbarButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getToolbarButtons.call(this);
                buttons.push({
                    title: Q.text('Site.RolePermissionDialog.EditButton'),
                    cssClass: 'edit-permissions-button',
                    icon: 'icon-lock-open text-green',
                    onClick: function () {
                        new Administration.RolePermissionDialog({
                            roleID: _this.entity.RoleId,
                            title: _this.entity.RoleName
                        }).dialogOpen();
                    }
                });
                return buttons;
            };
            RoleDialog.prototype.updateInterface = function () {
                _super.prototype.updateInterface.call(this);
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
            };
            return RoleDialog;
        }(Serenity.EntityDialog));
        RoleDialog = __decorate([
            Serenity.Decorators.registerClass()
        ], RoleDialog);
        Administration.RoleDialog = RoleDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleGrid = (function (_super) {
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
            return RoleGrid;
        }(Serenity.EntityGrid));
        RoleGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], RoleGrid);
        Administration.RoleGrid = RoleGrid;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var LanguageDialog = (function (_super) {
            __extends(LanguageDialog, _super);
            function LanguageDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new Administration.LanguageForm(_this.idPrefix);
                return _this;
            }
            LanguageDialog.prototype.getFormKey = function () { return Administration.LanguageForm.formKey; };
            LanguageDialog.prototype.getIdProperty = function () { return Administration.LanguageRow.idProperty; };
            LanguageDialog.prototype.getLocalTextPrefix = function () { return Administration.LanguageRow.localTextPrefix; };
            LanguageDialog.prototype.getNameProperty = function () { return Administration.LanguageRow.nameProperty; };
            LanguageDialog.prototype.getService = function () { return Administration.LanguageService.baseUrl; };
            return LanguageDialog;
        }(Serenity.EntityDialog));
        LanguageDialog = __decorate([
            Serenity.Decorators.registerClass()
        ], LanguageDialog);
        Administration.LanguageDialog = LanguageDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var LanguageGrid = (function (_super) {
            __extends(LanguageGrid, _super);
            function LanguageGrid(container) {
                return _super.call(this, container) || this;
            }
            LanguageGrid.prototype.getColumnsKey = function () { return "Administration.Language"; };
            LanguageGrid.prototype.getDialogType = function () { return Administration.LanguageDialog; };
            LanguageGrid.prototype.getIdProperty = function () { return Administration.LanguageRow.idProperty; };
            LanguageGrid.prototype.getLocalTextPrefix = function () { return Administration.LanguageRow.localTextPrefix; };
            LanguageGrid.prototype.getService = function () { return Administration.LanguageService.baseUrl; };
            LanguageGrid.prototype.getDefaultSortBy = function () {
                return [Administration.LanguageRow.Fields.LanguageName];
            };
            return LanguageGrid;
        }(Serenity.EntityGrid));
        LanguageGrid = __decorate([
            Serenity.Decorators.registerClass()
        ], LanguageGrid);
        Administration.LanguageGrid = LanguageGrid;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var LanguageForm = (function (_super) {
            __extends(LanguageForm, _super);
            function LanguageForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return LanguageForm;
        }(Serenity.PrefixedContext));
        LanguageForm.formKey = 'Administration.Language';
        Administration.LanguageForm = LanguageForm;
        [['LanguageId', function () { return Serenity.StringEditor; }], ['LanguageName', function () { return Serenity.StringEditor; }]].forEach(function (x) { return Object.defineProperty(LanguageForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var LanguageRow;
        (function (LanguageRow) {
            LanguageRow.idProperty = 'Id';
            LanguageRow.nameProperty = 'LanguageName';
            LanguageRow.localTextPrefix = 'Administration.Language';
            LanguageRow.lookupKey = 'Administration.Language';
            function getLookup() {
                return Q.getLookup('Administration.Language');
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
        })(LanguageRow = Administration.LanguageRow || (Administration.LanguageRow = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var LanguageService;
        (function (LanguageService) {
            LanguageService.baseUrl = 'Administration/Language';
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
        })(LanguageService = Administration.LanguageService || (Administration.LanguageService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleForm = (function (_super) {
            __extends(RoleForm, _super);
            function RoleForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return RoleForm;
        }(Serenity.PrefixedContext));
        RoleForm.formKey = 'Administration.Role';
        Administration.RoleForm = RoleForm;
        [['RoleName', function () { return Serenity.StringEditor; }]].forEach(function (x) { return Object.defineProperty(RoleForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
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
                'RoleName'
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
    var Administration;
    (function (Administration) {
        var TranslationService;
        (function (TranslationService) {
            TranslationService.baseUrl = 'Administration/Translation';
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
        })(TranslationService = Administration.TranslationService || (Administration.TranslationService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserForm = (function (_super) {
            __extends(UserForm, _super);
            function UserForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return UserForm;
        }(Serenity.PrefixedContext));
        UserForm.formKey = 'Administration.User';
        Administration.UserForm = UserForm;
        [['Username', function () { return Serenity.StringEditor; }], ['DisplayName', function () { return Serenity.StringEditor; }], ['Email', function () { return Serenity.EmailEditor; }], ['UserImage', function () { return Serenity.ImageUploadEditor; }], ['Password', function () { return Serenity.PasswordEditor; }], ['PasswordConfirm', function () { return Serenity.PasswordEditor; }], ['Source', function () { return Serenity.StringEditor; }]].forEach(function (x) { return Object.defineProperty(UserForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
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
                'User'
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
            UserRow.isActiveProperty = 'IsActive';
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
                'Source',
                'PasswordHash',
                'PasswordSalt',
                'DisplayName',
                'Email',
                'UserImage',
                'LastDirectoryUpdate',
                'IsActive',
                'Password',
                'PasswordConfirm',
                'InsertUserId',
                'InsertDate',
                'UpdateUserId',
                'UpdateDate'
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
var Default;
(function (Default_3) {
    var Default;
    (function (Default) {
        var MachineForm = (function (_super) {
            __extends(MachineForm, _super);
            function MachineForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return MachineForm;
        }(Serenity.PrefixedContext));
        MachineForm.formKey = 'Default.Machine';
        Default.MachineForm = MachineForm;
        [,
            ['MachineLineId', function () { return Serenity.IntegerEditor; }],
            ['MachineName', function () { return Serenity.StringEditor; }],
            ['ModelNumber', function () { return Serenity.StringEditor; }],
            ['PlcName', function () { return Serenity.StringEditor; }],
            ['PlcModelNumber', function () { return Serenity.StringEditor; }],
            ['PlcSerialNumber', function () { return Serenity.StringEditor; }],
            ['MachineSequence', function () { return Serenity.IntegerEditor; }],
            ['StatusId', function () { return Serenity.IntegerEditor; }]
        ].forEach(function (x) { return Object.defineProperty(MachineForm.prototype, x[0], {
            get: function () {
                return this.w(x[0], x[1]());
            },
            enumerable: true,
            configurable: true
        }); });
    })(Default = Default_3.Default || (Default_3.Default = {}));
})(Default || (Default = {}));
var CVC;
(function (CVC) {
    var Default;
    (function (Default) {
        var MachineLineForm = (function (_super) {
            __extends(MachineLineForm, _super);
            function MachineLineForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return MachineLineForm;
        }(Serenity.PrefixedContext));
        MachineLineForm.formKey = 'Default.MachineLine';
        Default.MachineLineForm = MachineLineForm;
        [,
            ['LineName', function () { return Serenity.StringEditor; }],
            ['Status', function () { return Serenity.IntegerEditor; }]
        ].forEach(function (x) { return Object.defineProperty(MachineLineForm.prototype, x[0], {
            get: function () {
                return this.w(x[0], x[1]());
            },
            enumerable: true,
            configurable: true
        }); });
    })(Default = CVC.Default || (CVC.Default = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Default;
    (function (Default) {
        var MachineLineRow;
        (function (MachineLineRow) {
            MachineLineRow.idProperty = 'MachineLineId';
            MachineLineRow.nameProperty = 'LineName';
            MachineLineRow.localTextPrefix = 'BatchSetting.MachineLine';
            var Fields;
            (function (Fields) {
            })(Fields = MachineLineRow.Fields || (MachineLineRow.Fields = {}));
            [
                'MachineLineId',
                'LineName',
                'Status'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineLineRow = Default.MachineLineRow || (Default.MachineLineRow = {}));
    })(Default = CVC.Default || (CVC.Default = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Default;
    (function (Default) {
        var MachineLineService;
        (function (MachineLineService) {
            MachineLineService.baseUrl = 'BatchSetting/MachineLine';
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
        })(MachineLineService = Default.MachineLineService || (Default.MachineLineService = {}));
    })(Default = CVC.Default || (CVC.Default = {}));
})(CVC || (CVC = {}));
var Default;
(function (Default_4) {
    var Default;
    (function (Default) {
        var MachineRow;
        (function (MachineRow) {
            MachineRow.idProperty = 'MachineId';
            MachineRow.nameProperty = 'MachineName';
            MachineRow.localTextPrefix = 'BatchSetting.Machine';
            var Fields;
            (function (Fields) {
            })(Fields = MachineRow.Fields || (MachineRow.Fields = {}));
            [
                'MachineId',
                'MachineLineId',
                'MachineName',
                'ModelNumber',
                'PlcName',
                'PlcModelNumber',
                'PlcSerialNumber',
                'MachineSequence',
                'StatusId',
                'MachineLineLineName',
                'MachineLineStatus',
                'StatusStatusName'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineRow = Default.MachineRow || (Default.MachineRow = {}));
    })(Default = Default_4.Default || (Default_4.Default = {}));
})(Default || (Default = {}));
var Default;
(function (Default_5) {
    var Default;
    (function (Default) {
        var MachineService;
        (function (MachineService) {
            MachineService.baseUrl = 'BatchSetting/Machine';
            var Methods;
            (function (Methods) {
            })(Methods = MachineService.Methods || (MachineService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineService.baseUrl + '/' + x;
            });
        })(MachineService = Default.MachineService || (Default.MachineService = {}));
    })(Default = Default_5.Default || (Default_5.Default = {}));
})(Default || (Default = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ChangePasswordForm = (function (_super) {
            __extends(ChangePasswordForm, _super);
            function ChangePasswordForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return ChangePasswordForm;
        }(Serenity.PrefixedContext));
        ChangePasswordForm.formKey = 'Membership.ChangePassword';
        Membership.ChangePasswordForm = ChangePasswordForm;
        [['OldPassword', function () { return Serenity.PasswordEditor; }], ['NewPassword', function () { return Serenity.PasswordEditor; }], ['ConfirmPassword', function () { return Serenity.PasswordEditor; }]].forEach(function (x) { return Object.defineProperty(ChangePasswordForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ForgotPasswordForm = (function (_super) {
            __extends(ForgotPasswordForm, _super);
            function ForgotPasswordForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return ForgotPasswordForm;
        }(Serenity.PrefixedContext));
        ForgotPasswordForm.formKey = 'Membership.ForgotPassword';
        Membership.ForgotPasswordForm = ForgotPasswordForm;
        [['Email', function () { return Serenity.EmailEditor; }]].forEach(function (x) { return Object.defineProperty(ForgotPasswordForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var LoginForm = (function (_super) {
            __extends(LoginForm, _super);
            function LoginForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return LoginForm;
        }(Serenity.PrefixedContext));
        LoginForm.formKey = 'Membership.Login';
        Membership.LoginForm = LoginForm;
        [['Username', function () { return Serenity.StringEditor; }], ['Password', function () { return Serenity.PasswordEditor; }]].forEach(function (x) { return Object.defineProperty(LoginForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ResetPasswordForm = (function (_super) {
            __extends(ResetPasswordForm, _super);
            function ResetPasswordForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return ResetPasswordForm;
        }(Serenity.PrefixedContext));
        ResetPasswordForm.formKey = 'Membership.ResetPassword';
        Membership.ResetPasswordForm = ResetPasswordForm;
        [['NewPassword', function () { return Serenity.PasswordEditor; }], ['ConfirmPassword', function () { return Serenity.PasswordEditor; }]].forEach(function (x) { return Object.defineProperty(ResetPasswordForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var SignUpForm = (function (_super) {
            __extends(SignUpForm, _super);
            function SignUpForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return SignUpForm;
        }(Serenity.PrefixedContext));
        SignUpForm.formKey = 'Membership.SignUp';
        Membership.SignUpForm = SignUpForm;
        [['DisplayName', function () { return Serenity.StringEditor; }], ['Email', function () { return Serenity.EmailEditor; }], ['ConfirmEmail', function () { return Serenity.EmailEditor; }], ['Password', function () { return Serenity.PasswordEditor; }], ['ConfirmPassword', function () { return Serenity.PasswordEditor; }]].forEach(function (x) { return Object.defineProperty(SignUpForm.prototype, x[0], { get: function () { return this.w(x[0], x[1]()); }, enumerable: true, configurable: true }); });
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var DataTypeForm = (function (_super) {
            __extends(DataTypeForm, _super);
            function DataTypeForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return DataTypeForm;
        }(Serenity.PrefixedContext));
        DataTypeForm.formKey = 'Newcon.DataType';
        Newcon.DataTypeForm = DataTypeForm;
        [,
            ['DataType', function () { return Serenity.StringEditor; }]
        ].forEach(function (x) { return Object.defineProperty(DataTypeForm.prototype, x[0], {
            get: function () {
                return this.w(x[0], x[1]());
            },
            enumerable: true,
            configurable: true
        }); });
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var DataTypeRow;
        (function (DataTypeRow) {
            DataTypeRow.idProperty = 'DataTypeId';
            DataTypeRow.nameProperty = 'DataType';
            DataTypeRow.localTextPrefix = 'Newcon.DataType';
            var Fields;
            (function (Fields) {
            })(Fields = DataTypeRow.Fields || (DataTypeRow.Fields = {}));
            [
                'DataTypeId',
                'DataType'
            ].forEach(function (x) { return Fields[x] = x; });
        })(DataTypeRow = Newcon.DataTypeRow || (Newcon.DataTypeRow = {}));
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var DataTypeService;
        (function (DataTypeService) {
            DataTypeService.baseUrl = 'Newcon/DataType';
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
        })(DataTypeService = Newcon.DataTypeService || (Newcon.DataTypeService = {}));
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var HmiParameterForm = (function (_super) {
            __extends(HmiParameterForm, _super);
            function HmiParameterForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return HmiParameterForm;
        }(Serenity.PrefixedContext));
        HmiParameterForm.formKey = 'Newcon.HmiParameter';
        Newcon.HmiParameterForm = HmiParameterForm;
        [,
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['MachineLineId', function () { return Serenity.IntegerEditor; }],
            ['MachineParameterId', function () { return Serenity.IntegerEditor; }],
            ['HmiParameterName', function () { return Serenity.StringEditor; }],
            ['HmiAddress', function () { return Serenity.StringEditor; }],
            ['Status', function () { return Serenity.IntegerEditor; }]
        ].forEach(function (x) { return Object.defineProperty(HmiParameterForm.prototype, x[0], {
            get: function () {
                return this.w(x[0], x[1]());
            },
            enumerable: true,
            configurable: true
        }); });
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var HmiParameterRow;
        (function (HmiParameterRow) {
            HmiParameterRow.idProperty = 'HmiParameterId';
            HmiParameterRow.nameProperty = 'HmiParameterName';
            HmiParameterRow.localTextPrefix = 'Newcon.HmiParameter';
            var Fields;
            (function (Fields) {
            })(Fields = HmiParameterRow.Fields || (HmiParameterRow.Fields = {}));
            [
                'HmiParameterId',
                'MachineId',
                'MachineLineId',
                'MachineParameterId',
                'HmiParameterName',
                'HmiAddress',
                'Status',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachinePlcName',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachineMachineSequence',
                'MachineStatusId',
                'MachineLineLineName',
                'MachineLineStatus',
                'MachineParameterMachineLineId',
                'MachineParameterMachineId',
                'MachineParameterParameterName',
                'MachineParameterPlcAddress',
                'MachineParameterDataTypeId',
                'MachineParameterDescription',
                'MachineParameterIsRead',
                'MachineParameterIsWrite',
                'MachineParameterIsButton'
            ].forEach(function (x) { return Fields[x] = x; });
        })(HmiParameterRow = Newcon.HmiParameterRow || (Newcon.HmiParameterRow = {}));
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var HmiParameterService;
        (function (HmiParameterService) {
            HmiParameterService.baseUrl = 'Newcon/HmiParameter';
            var Methods;
            (function (Methods) {
            })(Methods = HmiParameterService.Methods || (HmiParameterService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                HmiParameterService[x] = function (r, s, o) {
                    return Q.serviceRequest(HmiParameterService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = HmiParameterService.baseUrl + '/' + x;
            });
        })(HmiParameterService = Newcon.HmiParameterService || (Newcon.HmiParameterService = {}));
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var MachineCommunicationForm = (function (_super) {
            __extends(MachineCommunicationForm, _super);
            function MachineCommunicationForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return MachineCommunicationForm;
        }(Serenity.PrefixedContext));
        MachineCommunicationForm.formKey = 'Newcon.MachineCommunication';
        Newcon.MachineCommunicationForm = MachineCommunicationForm;
        [,
            ['ProtocolTypeId', function () { return Serenity.IntegerEditor; }],
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['MachineLineId', function () { return Serenity.IntegerEditor; }],
            ['IpAddress', function () { return Serenity.StringEditor; }],
            ['TcpipPort', function () { return Serenity.IntegerEditor; }],
            ['PollRate', function () { return Serenity.IntegerEditor; }]
        ].forEach(function (x) { return Object.defineProperty(MachineCommunicationForm.prototype, x[0], {
            get: function () {
                return this.w(x[0], x[1]());
            },
            enumerable: true,
            configurable: true
        }); });
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var MachineCommunicationRow;
        (function (MachineCommunicationRow) {
            MachineCommunicationRow.idProperty = 'MachineCommunicatonId';
            MachineCommunicationRow.nameProperty = 'IpAddress';
            MachineCommunicationRow.localTextPrefix = 'Newcon.MachineCommunication';
            var Fields;
            (function (Fields) {
            })(Fields = MachineCommunicationRow.Fields || (MachineCommunicationRow.Fields = {}));
            [
                'MachineCommunicatonId',
                'ProtocolTypeId',
                'MachineId',
                'MachineLineId',
                'IpAddress',
                'TcpipPort',
                'PollRate',
                'ProtocolTypeProtocolName',
                'ProtocolTypeStatus',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachinePlcName',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachineMachineSequence',
                'MachineStatusId',
                'MachineLineLineName',
                'MachineLineStatus'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineCommunicationRow = Newcon.MachineCommunicationRow || (Newcon.MachineCommunicationRow = {}));
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var MachineCommunicationService;
        (function (MachineCommunicationService) {
            MachineCommunicationService.baseUrl = 'Newcon/MachineCommunication';
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
        })(MachineCommunicationService = Newcon.MachineCommunicationService || (Newcon.MachineCommunicationService = {}));
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var MachineParameterForm = (function (_super) {
            __extends(MachineParameterForm, _super);
            function MachineParameterForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return MachineParameterForm;
        }(Serenity.PrefixedContext));
        MachineParameterForm.formKey = 'Newcon.MachineParameter';
        Newcon.MachineParameterForm = MachineParameterForm;
        [,
            ['MachineLineId', function () { return Serenity.IntegerEditor; }],
            ['MachineId', function () { return Serenity.IntegerEditor; }],
            ['ParameterName', function () { return Serenity.StringEditor; }],
            ['PlcAddress', function () { return Serenity.StringEditor; }],
            ['DataTypeId', function () { return Serenity.IntegerEditor; }],
            ['Description', function () { return Serenity.StringEditor; }],
            ['IsRead', function () { return Serenity.BooleanEditor; }],
            ['IsWrite', function () { return Serenity.BooleanEditor; }],
            ['IsButton', function () { return Serenity.BooleanEditor; }]
        ].forEach(function (x) { return Object.defineProperty(MachineParameterForm.prototype, x[0], {
            get: function () {
                return this.w(x[0], x[1]());
            },
            enumerable: true,
            configurable: true
        }); });
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var MachineParameterRow;
        (function (MachineParameterRow) {
            MachineParameterRow.idProperty = 'MachineParameterId';
            MachineParameterRow.nameProperty = 'ParameterName';
            MachineParameterRow.localTextPrefix = 'Newcon.MachineParameter';
            var Fields;
            (function (Fields) {
            })(Fields = MachineParameterRow.Fields || (MachineParameterRow.Fields = {}));
            [
                'MachineParameterId',
                'MachineLineId',
                'MachineId',
                'ParameterName',
                'PlcAddress',
                'DataTypeId',
                'Description',
                'IsRead',
                'IsWrite',
                'IsButton',
                'MachineLineLineName',
                'MachineLineStatus',
                'MachineMachineLineId',
                'MachineMachineName',
                'MachineModelNumber',
                'MachinePlcName',
                'MachinePlcModelNumber',
                'MachinePlcSerialNumber',
                'MachineMachineSequence',
                'MachineStatusId'
            ].forEach(function (x) { return Fields[x] = x; });
        })(MachineParameterRow = Newcon.MachineParameterRow || (Newcon.MachineParameterRow = {}));
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var MachineParameterService;
        (function (MachineParameterService) {
            MachineParameterService.baseUrl = 'Newcon/MachineParameter';
            var Methods;
            (function (Methods) {
            })(Methods = MachineParameterService.Methods || (MachineParameterService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                MachineParameterService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineParameterService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = MachineParameterService.baseUrl + '/' + x;
            });
        })(MachineParameterService = Newcon.MachineParameterService || (Newcon.MachineParameterService = {}));
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var ProtocolForm = (function (_super) {
            __extends(ProtocolForm, _super);
            function ProtocolForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return ProtocolForm;
        }(Serenity.PrefixedContext));
        ProtocolForm.formKey = 'Newcon.Protocol';
        Newcon.ProtocolForm = ProtocolForm;
        [,
            ['ProtocolName', function () { return Serenity.StringEditor; }],
            ['Status', function () { return Serenity.StringEditor; }]
        ].forEach(function (x) { return Object.defineProperty(ProtocolForm.prototype, x[0], {
            get: function () {
                return this.w(x[0], x[1]());
            },
            enumerable: true,
            configurable: true
        }); });
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var ProtocolRow;
        (function (ProtocolRow) {
            ProtocolRow.idProperty = 'ProtocolId';
            ProtocolRow.nameProperty = 'ProtocolName';
            ProtocolRow.localTextPrefix = 'Newcon.Protocol';
            var Fields;
            (function (Fields) {
            })(Fields = ProtocolRow.Fields || (ProtocolRow.Fields = {}));
            [
                'ProtocolId',
                'ProtocolName',
                'Status'
            ].forEach(function (x) { return Fields[x] = x; });
        })(ProtocolRow = Newcon.ProtocolRow || (Newcon.ProtocolRow = {}));
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
var MachineCustomization;
(function (MachineCustomization) {
    var Newcon;
    (function (Newcon) {
        var ProtocolService;
        (function (ProtocolService) {
            ProtocolService.baseUrl = 'Newcon/Protocol';
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
        })(ProtocolService = Newcon.ProtocolService || (Newcon.ProtocolService = {}));
    })(Newcon = MachineCustomization.Newcon || (MachineCustomization.Newcon = {}));
})(MachineCustomization || (MachineCustomization = {}));
//# sourceMappingURL=CVC.Web.js.map
