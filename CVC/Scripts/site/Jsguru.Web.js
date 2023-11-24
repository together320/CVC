var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var AdminFormForm = /** @class */ (function (_super) {
            __extends(AdminFormForm, _super);
            function AdminFormForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!AdminFormForm.init) {
                    AdminFormForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    Q.initFormType(AdminFormForm, [
                        'FormName', w0
                    ]);
                }
                return _this;
            }
            AdminFormForm.formKey = 'Administration.AdminForm';
            return AdminFormForm;
        }(Serenity.PrefixedContext));
        Administration.AdminFormForm = AdminFormForm;
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
            AdminFormRow.deletePermission = '';
            AdminFormRow.insertPermission = '';
            AdminFormRow.readPermission = '';
            AdminFormRow.updatePermission = '';
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
            });
        })(AdminFormService = Administration.AdminFormService || (Administration.AdminFormService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var ModuleAccessForm = /** @class */ (function (_super) {
            __extends(ModuleAccessForm, _super);
            function ModuleAccessForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ModuleAccessForm.init) {
                    ModuleAccessForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    Q.initFormType(ModuleAccessForm, [
                        'ModuleId', w0,
                        'RoleId', w0,
                        'IsAccess', w0,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            ModuleAccessForm.formKey = 'Administration.ModuleAccess';
            return ModuleAccessForm;
        }(Serenity.PrefixedContext));
        Administration.ModuleAccessForm = ModuleAccessForm;
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
            ModuleAccessRow.deletePermission = '';
            ModuleAccessRow.insertPermission = '';
            ModuleAccessRow.readPermission = '';
            ModuleAccessRow.updatePermission = '';
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
            });
        })(ModuleAccessService = Administration.ModuleAccessService || (Administration.ModuleAccessService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var RoleForm = /** @class */ (function (_super) {
            __extends(RoleForm, _super);
            function RoleForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!RoleForm.init) {
                    RoleForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(RoleForm, [
                        'RoleName', w0,
                        'ParentRoleId', w1,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            RoleForm.formKey = 'Administration.Role';
            return RoleForm;
        }(Serenity.PrefixedContext));
        Administration.RoleForm = RoleForm;
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
            RolePermissionRow.deletePermission = '';
            RolePermissionRow.insertPermission = '';
            RolePermissionRow.readPermission = '';
            RolePermissionRow.updatePermission = '';
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
            [
                'Update',
                'List'
            ].forEach(function (x) {
                RolePermissionService[x] = function (r, s, o) {
                    return Q.serviceRequest(RolePermissionService.baseUrl + '/' + x, r, s, o);
                };
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
            RoleRow.lookupKey = 'Role';
            function getLookup() {
                return Q.getLookup('Role');
            }
            RoleRow.getLookup = getLookup;
            RoleRow.deletePermission = 'Administration:Role:Modify';
            RoleRow.insertPermission = 'Administration:Role:Modify';
            RoleRow.readPermission = 'Administration:Role:Read';
            RoleRow.updatePermission = 'Administration:Role:Modify';
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
            });
        })(RoleService = Administration.RoleService || (Administration.RoleService = {}));
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Administration;
    (function (Administration) {
        var UserForm = /** @class */ (function (_super) {
            __extends(UserForm, _super);
            function UserForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!UserForm.init) {
                    UserForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.IntegerEditor;
                    var w3 = s.DateEditor;
                    var w4 = s.EmailEditor;
                    var w5 = s.PasswordEditor;
                    var w6 = s.ImageUploadEditor;
                    var w7 = s.BooleanEditor;
                    Q.initFormType(UserForm, [
                        'EmployeeId', w0,
                        'FirstName', w0,
                        'LastName', w0,
                        'DepartmentId', w1,
                        'Designation', w0,
                        'MobileCode', w2,
                        'MobileNumber', w0,
                        'BirthDate', w3,
                        'Email', w4,
                        'Username', w0,
                        'Password', w5,
                        'PasswordConfirm', w5,
                        'RoleId', w1,
                        'UserImage', w6,
                        'Address', w0,
                        'CityId', w1,
                        'PinCode', w0,
                        'StatusId', w1,
                        'QuestionId', w1,
                        'QuestionAns', w0,
                        'IsLockOut', w7,
                        'CreatedBy', w2,
                        'CreatedDate', w3,
                        'UpdatedBy', w2,
                        'UpdatedDate', w3,
                        'IsActiveDirectory', w7
                    ]);
                }
                return _this;
            }
            UserForm.formKey = 'Administration.User';
            return UserForm;
        }(Serenity.PrefixedContext));
        Administration.UserForm = UserForm;
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
            UserPermissionRow.deletePermission = '';
            UserPermissionRow.insertPermission = '';
            UserPermissionRow.readPermission = '';
            UserPermissionRow.updatePermission = '';
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
            [
                'Update',
                'List',
                'ListRolePermissions',
                'ListPermissionKeys'
            ].forEach(function (x) {
                UserPermissionService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserPermissionService.baseUrl + '/' + x, r, s, o);
                };
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
            UserRoleRow.deletePermission = '';
            UserRoleRow.insertPermission = '';
            UserRoleRow.readPermission = '';
            UserRoleRow.updatePermission = '';
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
            [
                'Update',
                'List'
            ].forEach(function (x) {
                UserRoleService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserRoleService.baseUrl + '/' + x, r, s, o);
                };
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
            UserRow.deletePermission = 'Administration:User:Modify';
            UserRow.insertPermission = 'Administration:User:Modify';
            UserRow.readPermission = 'Administration:User:Read';
            UserRow.updatePermission = 'Administration:User:Modify';
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
            function ViewFieldAccessForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ViewFieldAccessForm.init) {
                    ViewFieldAccessForm.init = true;
                    var s = Serenity;
                    var w0 = s.LookupEditor;
                    var w1 = s.BooleanEditor;
                    Q.initFormType(ViewFieldAccessForm, [
                        'ViewFieldId', w0,
                        'RoleId', w0,
                        'IsView', w1,
                        'IsModify', w1,
                        'StatusId', w0
                    ]);
                }
                return _this;
            }
            ViewFieldAccessForm.formKey = 'Administration.ViewFieldAccess';
            return ViewFieldAccessForm;
        }(Serenity.PrefixedContext));
        Administration.ViewFieldAccessForm = ViewFieldAccessForm;
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
            ViewFieldAccessRow.deletePermission = '';
            ViewFieldAccessRow.insertPermission = '';
            ViewFieldAccessRow.readPermission = '';
            ViewFieldAccessRow.updatePermission = '';
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
            function ViewsAccessForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ViewsAccessForm.init) {
                    ViewsAccessForm.init = true;
                    var s = Serenity;
                    var w0 = s.LookupEditor;
                    var w1 = s.BooleanEditor;
                    Q.initFormType(ViewsAccessForm, [
                        'ViewsId', w0,
                        'RoleId', w0,
                        'IsView', w1,
                        'IsModify', w1,
                        'StatusId', w0
                    ]);
                }
                return _this;
            }
            ViewsAccessForm.formKey = 'Administration.ViewsAccess';
            return ViewsAccessForm;
        }(Serenity.PrefixedContext));
        Administration.ViewsAccessForm = ViewsAccessForm;
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
            ViewsAccessRow.deletePermission = '';
            ViewsAccessRow.insertPermission = '';
            ViewsAccessRow.readPermission = '';
            ViewsAccessRow.updatePermission = '';
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
            function BatchForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!BatchForm.init) {
                    BatchForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.LookupEditor;
                    var w3 = s.DateEditor;
                    var w4 = s.DateTimeEditor;
                    Q.initFormType(BatchForm, [
                        'BatchName', w0,
                        'PackId', w1,
                        'MachineLineId', w1,
                        'BatchStatus', w0,
                        'BatchSize', w1,
                        'BatchFor', w2,
                        'ExpiryDate', w3,
                        'StatusId', w1,
                        'CreatedBy', w1,
                        'CreatedDate', w4,
                        'UpdatedBy', w1,
                        'UpdatedDate', w4,
                        'BatchVersion', w0
                    ]);
                }
                return _this;
            }
            BatchForm.formKey = 'Batch.Batch';
            return BatchForm;
        }(Serenity.PrefixedContext));
        Batch.BatchForm = BatchForm;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogForm = /** @class */ (function (_super) {
            __extends(BatchLogForm, _super);
            function BatchLogForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!BatchLogForm.init) {
                    BatchLogForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(BatchLogForm, [
                        'MachineId', w0,
                        'BatchId', w0,
                        'Description', w1,
                        'UserId', w0,
                        'UpdatedDateTime', w2
                    ]);
                }
                return _this;
            }
            BatchLogForm.formKey = 'Batch.BatchLog';
            return BatchLogForm;
        }(Serenity.PrefixedContext));
        Batch.BatchLogForm = BatchLogForm;
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
            BatchLogRow.deletePermission = '';
            BatchLogRow.insertPermission = '';
            BatchLogRow.readPermission = '';
            BatchLogRow.updatePermission = '';
        })(BatchLogRow = Batch.BatchLogRow || (Batch.BatchLogRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchLogService;
        (function (BatchLogService) {
            BatchLogService.baseUrl = 'Batch/BatchLog';
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
            });
        })(BatchLogService = Batch.BatchLogService || (Batch.BatchLogService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchMachineWiseForm = /** @class */ (function (_super) {
            __extends(BatchMachineWiseForm, _super);
            function BatchMachineWiseForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!BatchMachineWiseForm.init) {
                    BatchMachineWiseForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    Q.initFormType(BatchMachineWiseForm, [
                        'MachineId', w0,
                        'BatchId', w0,
                        'RecipeId', w0,
                        'IsMachineInUse', w0,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            BatchMachineWiseForm.formKey = 'Batch.BatchMachineWise';
            return BatchMachineWiseForm;
        }(Serenity.PrefixedContext));
        Batch.BatchMachineWiseForm = BatchMachineWiseForm;
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
            BatchMachineWiseRow.deletePermission = '';
            BatchMachineWiseRow.insertPermission = '';
            BatchMachineWiseRow.readPermission = '';
            BatchMachineWiseRow.updatePermission = '';
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
            function BatchRecipeModifyForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!BatchRecipeModifyForm.init) {
                    BatchRecipeModifyForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(BatchRecipeModifyForm, [
                        'BatchMachineId', w0,
                        'RecipeSettingsParameterId', w0,
                        'OldValue', w1,
                        'NewValue', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            BatchRecipeModifyForm.formKey = 'Batch.BatchRecipeModify';
            return BatchRecipeModifyForm;
        }(Serenity.PrefixedContext));
        Batch.BatchRecipeModifyForm = BatchRecipeModifyForm;
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
            BatchRecipeModifyRow.deletePermission = '';
            BatchRecipeModifyRow.insertPermission = '';
            BatchRecipeModifyRow.readPermission = '';
            BatchRecipeModifyRow.updatePermission = '';
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
            });
        })(BatchRecipeModifyService = Batch.BatchRecipeModifyService || (Batch.BatchRecipeModifyService = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchReportService;
        (function (BatchReportService) {
            BatchReportService.baseUrl = '~/BatchReport';
        })(BatchReportService = Batch.BatchReportService || (Batch.BatchReportService = {}));
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
            BatchRow.lookupKey = 'Batch';
            function getLookup() {
                return Q.getLookup('Batch');
            }
            BatchRow.getLookup = getLookup;
            BatchRow.deletePermission = '';
            BatchRow.insertPermission = '';
            BatchRow.readPermission = '';
            BatchRow.updatePermission = '';
        })(BatchRow = Batch.BatchRow || (Batch.BatchRow = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRow1;
        (function (BatchRow1) {
            BatchRow1.idProperty = 'BatchId';
            BatchRow1.nameProperty = 'BatchName';
            BatchRow1.localTextPrefix = 'Batch.Batch';
            BatchRow1.lookupKey = 'Batch1';
            function getLookup() {
                return Q.getLookup('Batch1');
            }
            BatchRow1.getLookup = getLookup;
            BatchRow1.deletePermission = '';
            BatchRow1.insertPermission = '';
            BatchRow1.readPermission = '';
            BatchRow1.updatePermission = '';
        })(BatchRow1 = Batch.BatchRow1 || (Batch.BatchRow1 = {}));
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchRunDataForm = /** @class */ (function (_super) {
            __extends(BatchRunDataForm, _super);
            function BatchRunDataForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!BatchRunDataForm.init) {
                    BatchRunDataForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(BatchRunDataForm, [
                        'BatchMachineWiseId', w0,
                        'IpcParameterId', w0,
                        'IpcParameterValue', w1,
                        'UpdatedDateTime', w2,
                        'LoggedInUser', w0
                    ]);
                }
                return _this;
            }
            BatchRunDataForm.formKey = 'Batch.BatchRunData';
            return BatchRunDataForm;
        }(Serenity.PrefixedContext));
        Batch.BatchRunDataForm = BatchRunDataForm;
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
            BatchRunDataRow.deletePermission = '';
            BatchRunDataRow.insertPermission = '';
            BatchRunDataRow.readPermission = '';
            BatchRunDataRow.updatePermission = '';
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
            function LabelLostForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!LabelLostForm.init) {
                    LabelLostForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(LabelLostForm, [
                        'LabelRecId', w0,
                        'ActivityId', w0,
                        'ActivityText', w1,
                        'NumberOfLabels', w0,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w2,
                        'UpdatedBy', w0,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            LabelLostForm.formKey = 'Batch.LabelLost';
            return LabelLostForm;
        }(Serenity.PrefixedContext));
        Batch.LabelLostForm = LabelLostForm;
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
            LabelLostRow.deletePermission = '';
            LabelLostRow.insertPermission = '';
            LabelLostRow.readPermission = '';
            LabelLostRow.updatePermission = '';
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
            function LabelReconciliationForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!LabelReconciliationForm.init) {
                    LabelReconciliationForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    Q.initFormType(LabelReconciliationForm, [
                        'BatchId', w0,
                        'MachineId', w0,
                        'LabelRollId', w0,
                        'RejectedLabels', w0,
                        'LabelLost', w0,
                        'NoLabelOnRoll', w0,
                        'LabelBalance', w0,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            LabelReconciliationForm.formKey = 'Batch.LabelReconciliation';
            return LabelReconciliationForm;
        }(Serenity.PrefixedContext));
        Batch.LabelReconciliationForm = LabelReconciliationForm;
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
            LabelReconciliationRow.deletePermission = '';
            LabelReconciliationRow.insertPermission = '';
            LabelReconciliationRow.readPermission = '';
            LabelReconciliationRow.updatePermission = '';
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
            function LabelRollForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!LabelRollForm.init) {
                    LabelRollForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(LabelRollForm, [
                        'BatchId', w0,
                        'MachineId', w0,
                        'LabelRollNumber', w0,
                        'NumberOfLabels', w1,
                        'Remark', w1,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w2,
                        'UpdatedBy', w0,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            LabelRollForm.formKey = 'Batch.LabelRoll';
            return LabelRollForm;
        }(Serenity.PrefixedContext));
        Batch.LabelRollForm = LabelRollForm;
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
            LabelRollRow.lookupKey = 'Batch.LabelRollId';
            function getLookup() {
                return Q.getLookup('Batch.LabelRollId');
            }
            LabelRollRow.getLookup = getLookup;
            LabelRollRow.deletePermission = '?';
            LabelRollRow.insertPermission = '?';
            LabelRollRow.readPermission = '?';
            LabelRollRow.updatePermission = '?';
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
            UserPreferenceRow.deletePermission = '';
            UserPreferenceRow.insertPermission = '';
            UserPreferenceRow.readPermission = '';
            UserPreferenceRow.updatePermission = '';
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
            [
                'Update',
                'Retrieve'
            ].forEach(function (x) {
                UserPreferenceService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserPreferenceService.baseUrl + '/' + x, r, s, o);
                };
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
            function CityDetailsForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!CityDetailsForm.init) {
                    CityDetailsForm.init = true;
                    var s = Serenity;
                    var w0 = s.LookupEditor;
                    var w1 = s.StringEditor;
                    Q.initFormType(CityDetailsForm, [
                        'Country', w0,
                        'State', w0,
                        'City', w1,
                        'StatusId', w0
                    ]);
                }
                return _this;
            }
            CityDetailsForm.formKey = 'Configuration.CityDetails';
            return CityDetailsForm;
        }(Serenity.PrefixedContext));
        Configuration.CityDetailsForm = CityDetailsForm;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CityDetailsRow;
        (function (CityDetailsRow) {
            CityDetailsRow.idProperty = 'CityDetailsId';
            CityDetailsRow.nameProperty = 'City';
            CityDetailsRow.localTextPrefix = 'Configuration.CityDetails';
            CityDetailsRow.lookupKey = 'Configuration.CityDetails';
            function getLookup() {
                return Q.getLookup('Configuration.CityDetails');
            }
            CityDetailsRow.getLookup = getLookup;
            CityDetailsRow.deletePermission = 'Configuration:CityDetails:Modify';
            CityDetailsRow.insertPermission = 'Configuration:CityDetails:Modify';
            CityDetailsRow.readPermission = 'Configuration:CityDetails:Read';
            CityDetailsRow.updatePermission = 'Configuration:CityDetails:Modify';
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
            function CompanyForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!CompanyForm.init) {
                    CompanyForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.ImageUploadEditor;
                    Q.initFormType(CompanyForm, [
                        'CompanyName', w0,
                        'Address', w0,
                        'CityCountry', w1,
                        'CityState', w1,
                        'CityId', w1,
                        'PinCode', w0,
                        'Website', w0,
                        'CompanyLogo', w2
                    ]);
                }
                return _this;
            }
            CompanyForm.formKey = 'Configuration.Company';
            return CompanyForm;
        }(Serenity.PrefixedContext));
        Configuration.CompanyForm = CompanyForm;
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
            CompanyRow.deletePermission = 'Configuration:Company:Modify';
            CompanyRow.insertPermission = 'Configuration:Company:Modify';
            CompanyRow.readPermission = 'Configuration:Company:Read';
            CompanyRow.updatePermission = 'Configuration:Company:Modify';
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
            function CurrencyForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!CurrencyForm.init) {
                    CurrencyForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(CurrencyForm, [
                        'CountryName', w0,
                        'CurrencyType', w0,
                        'Symbol', w0,
                        'Description', w0,
                        'StatusId', w1,
                        'CreatedBy', w1,
                        'CreatedDate', w2,
                        'UpdatedBy', w1,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            CurrencyForm.formKey = 'Configuration.Currency';
            return CurrencyForm;
        }(Serenity.PrefixedContext));
        Configuration.CurrencyForm = CurrencyForm;
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
            CurrencyRow.lookupKey = 'Configuration.Currency';
            function getLookup() {
                return Q.getLookup('Configuration.Currency');
            }
            CurrencyRow.getLookup = getLookup;
            CurrencyRow.deletePermission = 'Lookup';
            CurrencyRow.insertPermission = 'Lookup';
            CurrencyRow.readPermission = 'Lookup';
            CurrencyRow.updatePermission = 'Lookup';
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
            });
        })(CurrencyService = Configuration.CurrencyService || (Configuration.CurrencyService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DataTypeForm = /** @class */ (function (_super) {
            __extends(DataTypeForm, _super);
            function DataTypeForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!DataTypeForm.init) {
                    DataTypeForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(DataTypeForm, [
                        'DataTypeName', w0,
                        'TypeId', w1,
                        'Bit', w1,
                        'IsSigned', w1,
                        'StatusId', w1,
                        'CreatedBy', w1,
                        'CreatedDate', w2,
                        'UpdatedBy', w1,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            DataTypeForm.formKey = 'Configuration.DataType';
            return DataTypeForm;
        }(Serenity.PrefixedContext));
        Configuration.DataTypeForm = DataTypeForm;
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
            DataTypeRow.localTextPrefix = 'MachineCustomization.DataType';
            DataTypeRow.lookupKey = 'Configuration.DataType';
            function getLookup() {
                return Q.getLookup('Configuration.DataType');
            }
            DataTypeRow.getLookup = getLookup;
            DataTypeRow.deletePermission = 'Lookup';
            DataTypeRow.insertPermission = 'Lookup';
            DataTypeRow.readPermission = 'Lookup';
            DataTypeRow.updatePermission = 'Lookup';
        })(DataTypeRow = Configuration.DataTypeRow || (Configuration.DataTypeRow = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DataTypeService;
        (function (DataTypeService) {
            DataTypeService.baseUrl = 'MachineCustomization/DataType';
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
            });
        })(DataTypeService = Configuration.DataTypeService || (Configuration.DataTypeService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DateFormatTypeLookUp;
        (function (DateFormatTypeLookUp) {
            DateFormatTypeLookUp.idProperty = 'DateFormatTypeID';
            DateFormatTypeLookUp.nameProperty = 'DateFormatTypeValue';
            DateFormatTypeLookUp.localTextPrefix = 'Configuration.DateFormatTypeLookUp';
            DateFormatTypeLookUp.lookupKey = 'Configuration.DateFormatType';
            function getLookup() {
                return Q.getLookup('Configuration.DateFormatType');
            }
            DateFormatTypeLookUp.getLookup = getLookup;
            DateFormatTypeLookUp.deletePermission = 'Lookup';
            DateFormatTypeLookUp.insertPermission = 'Lookup';
            DateFormatTypeLookUp.readPermission = 'Lookup';
            DateFormatTypeLookUp.updatePermission = 'Lookup';
        })(DateFormatTypeLookUp = Configuration.DateFormatTypeLookUp || (Configuration.DateFormatTypeLookUp = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var DepartmentForm = /** @class */ (function (_super) {
            __extends(DepartmentForm, _super);
            function DepartmentForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!DepartmentForm.init) {
                    DepartmentForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(DepartmentForm, [
                        'DepartmentCode', w0,
                        'DepartmentName', w0,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            DepartmentForm.formKey = 'Configuration.Department';
            return DepartmentForm;
        }(Serenity.PrefixedContext));
        Configuration.DepartmentForm = DepartmentForm;
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
            DepartmentRow.lookupKey = 'Configuration.Department';
            function getLookup() {
                return Q.getLookup('Configuration.Department');
            }
            DepartmentRow.getLookup = getLookup;
            DepartmentRow.deletePermission = 'Configuration:Department:Modify';
            DepartmentRow.insertPermission = 'Configuration:Department:Modify';
            DepartmentRow.readPermission = 'Configuration:Department:Read';
            DepartmentRow.updatePermission = 'Configuration:Department:Modify';
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
            function EnvironmentVariablesForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!EnvironmentVariablesForm.init) {
                    EnvironmentVariablesForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.BooleanEditor;
                    var w3 = s.LookupEditor;
                    Q.initFormType(EnvironmentVariablesForm, [
                        'BackupFolder', w0,
                        'BackupFrequencyNoOfDaya', w1,
                        'BackupTime', w1,
                        'IsOverWriteBackup', w2,
                        'DatabaseLimit', w1,
                        'ArchivalPath', w0,
                        'LastPeriodRetained', w1,
                        'SessionTimeOut', w1,
                        'IsPasswordChangeRequired', w2,
                        'PasswordMaxLength', w1,
                        'PasswordMinLength', w1,
                        'MinAlphaChars', w1,
                        'MinNumericChars', w1,
                        'MinSpecialChars', w1,
                        'MinCapitalLetter', w1,
                        'PreviousPasswordLimit', w1,
                        'PasswordExpiryInDays', w1,
                        'PasswordExpiryNotification', w1,
                        'LockInAttempt', w1,
                        'IsUnLockAfterTime', w2,
                        'UnLockTime', w1,
                        'DateFormatTypeID', w3,
                        'TimeFormatTypeID', w3,
                        'HourFormatTypeID', w3,
                        'LicenseExpiryNotification', w1
                    ]);
                }
                return _this;
            }
            EnvironmentVariablesForm.formKey = 'Configuration.EnvironmentVariables';
            return EnvironmentVariablesForm;
        }(Serenity.PrefixedContext));
        Configuration.EnvironmentVariablesForm = EnvironmentVariablesForm;
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
            EnvironmentVariablesRow.deletePermission = 'Configuration:EnvironmentVariable:Modify';
            EnvironmentVariablesRow.insertPermission = 'Configuration:EnvironmentVariable:Modify';
            EnvironmentVariablesRow.readPermission = 'Configuration:EnvironmentVariable:Read';
            EnvironmentVariablesRow.updatePermission = 'Configuration:EnvironmentVariable:Modify';
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
            });
        })(EnvironmentVariablesService = Configuration.EnvironmentVariablesService || (Configuration.EnvironmentVariablesService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var LanguageForm = /** @class */ (function (_super) {
            __extends(LanguageForm, _super);
            function LanguageForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!LanguageForm.init) {
                    LanguageForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    Q.initFormType(LanguageForm, [
                        'LanguageId', w0,
                        'LanguageName', w0
                    ]);
                }
                return _this;
            }
            LanguageForm.formKey = 'Configuration.Language';
            return LanguageForm;
        }(Serenity.PrefixedContext));
        Configuration.LanguageForm = LanguageForm;
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
            LanguageRow.localTextPrefix = 'Administration.Language';
            LanguageRow.lookupKey = 'Configuration.Language';
            function getLookup() {
                return Q.getLookup('Configuration.Language');
            }
            LanguageRow.getLookup = getLookup;
            LanguageRow.deletePermission = 'Administration:Translation';
            LanguageRow.insertPermission = 'Administration:Translation';
            LanguageRow.readPermission = 'Administration:Translation';
            LanguageRow.updatePermission = 'Administration:Translation';
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
            });
        })(LanguageService = Configuration.LanguageService || (Configuration.LanguageService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListForm = /** @class */ (function (_super) {
            __extends(PickListForm, _super);
            function PickListForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!PickListForm.init) {
                    PickListForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(PickListForm, [
                        'PickListName', w0,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            PickListForm.formKey = 'Configuration.PickList';
            return PickListForm;
        }(Serenity.PrefixedContext));
        Configuration.PickListForm = PickListForm;
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
            PickListRow.lookupKey = 'Configuration.PickList';
            function getLookup() {
                return Q.getLookup('Configuration.PickList');
            }
            PickListRow.getLookup = getLookup;
            PickListRow.deletePermission = 'Lookup';
            PickListRow.insertPermission = 'Lookup';
            PickListRow.readPermission = 'Lookup';
            PickListRow.updatePermission = 'Lookup';
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
            function PickListValueForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!PickListValueForm.init) {
                    PickListValueForm.init = true;
                    var s = Serenity;
                    var w0 = s.LookupEditor;
                    var w1 = s.StringEditor;
                    Q.initFormType(PickListValueForm, [
                        'PickListId', w0,
                        'PickListValueName', w1,
                        'StatusId', w0
                    ]);
                }
                return _this;
            }
            PickListValueForm.formKey = 'Configuration.PickListValue';
            return PickListValueForm;
        }(Serenity.PrefixedContext));
        Configuration.PickListValueForm = PickListValueForm;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var PickListValueRoleAccessForm = /** @class */ (function (_super) {
            __extends(PickListValueRoleAccessForm, _super);
            function PickListValueRoleAccessForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!PickListValueRoleAccessForm.init) {
                    PickListValueRoleAccessForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    Q.initFormType(PickListValueRoleAccessForm, [
                        'PickListValueId', w0,
                        'RoleId', w0,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            PickListValueRoleAccessForm.formKey = 'Configuration.PickListValueRoleAccess';
            return PickListValueRoleAccessForm;
        }(Serenity.PrefixedContext));
        Configuration.PickListValueRoleAccessForm = PickListValueRoleAccessForm;
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
            PickListValueRoleAccessRow.deletePermission = 'Administration:General';
            PickListValueRoleAccessRow.insertPermission = 'Administration:General';
            PickListValueRoleAccessRow.readPermission = 'Administration:General';
            PickListValueRoleAccessRow.updatePermission = 'Administration:General';
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
            PickListValueRow.lookupKey = 'Configuration.PickListValue';
            function getLookup() {
                return Q.getLookup('Configuration.PickListValue');
            }
            PickListValueRow.getLookup = getLookup;
            PickListValueRow.deletePermission = 'Configuration:PickListValue:Modify';
            PickListValueRow.insertPermission = 'Configuration:PickListValue:Modify';
            PickListValueRow.readPermission = 'Configuration:PickListValue:Read';
            PickListValueRow.updatePermission = 'Configuration:PickListValue:Modify';
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
            function ShiftForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ShiftForm.init) {
                    ShiftForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(ShiftForm, [
                        'ShiftName', w0,
                        'StartTime', w0,
                        'EndTime', w0,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            ShiftForm.formKey = 'Configuration.Shift';
            return ShiftForm;
        }(Serenity.PrefixedContext));
        Configuration.ShiftForm = ShiftForm;
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
            ShiftRow.lookupKey = 'Configuration.Shift';
            function getLookup() {
                return Q.getLookup('Configuration.Shift');
            }
            ShiftRow.getLookup = getLookup;
            ShiftRow.deletePermission = 'Configuration:Shift:Modify';
            ShiftRow.insertPermission = 'Configuration:Shift:Modify';
            ShiftRow.readPermission = 'Configuration:Shift:Read';
            ShiftRow.updatePermission = 'Configuration:Shift:Modify';
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
            function StatusForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!StatusForm.init) {
                    StatusForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    Q.initFormType(StatusForm, [
                        'StatusName', w0
                    ]);
                }
                return _this;
            }
            StatusForm.formKey = 'Configuration.Status';
            return StatusForm;
        }(Serenity.PrefixedContext));
        Configuration.StatusForm = StatusForm;
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
            StatusRow.lookupKey = 'Configuration.Status';
            function getLookup() {
                return Q.getLookup('Configuration.Status');
            }
            StatusRow.getLookup = getLookup;
            StatusRow.deletePermission = 'Lookup';
            StatusRow.insertPermission = 'Lookup';
            StatusRow.readPermission = 'Lookup';
            StatusRow.updatePermission = 'Lookup';
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
            function SupplierForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!SupplierForm.init) {
                    SupplierForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.IntegerEditor;
                    Q.initFormType(SupplierForm, [
                        'SupplierName', w0,
                        'SupplierAddress', w0,
                        'CityCountry', w1,
                        'CityState', w1,
                        'CityId', w1,
                        'PinCode', w0,
                        'MobileCode', w2,
                        'MobileNumber', w0,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            SupplierForm.formKey = 'Configuration.Supplier';
            return SupplierForm;
        }(Serenity.PrefixedContext));
        Configuration.SupplierForm = SupplierForm;
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
            SupplierRow.lookupKey = 'Configuration.Supplier';
            function getLookup() {
                return Q.getLookup('Configuration.Supplier');
            }
            SupplierRow.getLookup = getLookup;
            SupplierRow.deletePermission = 'Configuration:Supplier:Modify';
            SupplierRow.insertPermission = 'Configuration:Supplier:Modify';
            SupplierRow.readPermission = 'Configuration:Supplier:Read';
            SupplierRow.updatePermission = 'Configuration:Supplier:Modify';
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
            });
        })(SupplierService = Configuration.SupplierService || (Configuration.SupplierService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var TimeFormatTypeLookUp;
        (function (TimeFormatTypeLookUp) {
            TimeFormatTypeLookUp.idProperty = 'TimeFormatTypeID';
            TimeFormatTypeLookUp.nameProperty = 'TimeFormatValue';
            TimeFormatTypeLookUp.localTextPrefix = 'Configuration.TimeFormatTypeLookUp';
            TimeFormatTypeLookUp.lookupKey = 'Configuration.TimeFormatType';
            function getLookup() {
                return Q.getLookup('Configuration.TimeFormatType');
            }
            TimeFormatTypeLookUp.getLookup = getLookup;
            TimeFormatTypeLookUp.deletePermission = 'Lookup';
            TimeFormatTypeLookUp.insertPermission = 'Lookup';
            TimeFormatTypeLookUp.readPermission = 'Lookup';
            TimeFormatTypeLookUp.updatePermission = 'Lookup';
        })(TimeFormatTypeLookUp = Configuration.TimeFormatTypeLookUp || (Configuration.TimeFormatTypeLookUp = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var TranslationService;
        (function (TranslationService) {
            TranslationService.baseUrl = 'Configuration/Translation';
            [
                'List',
                'Update'
            ].forEach(function (x) {
                TranslationService[x] = function (r, s, o) {
                    return Q.serviceRequest(TranslationService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(TranslationService = Configuration.TranslationService || (Configuration.TranslationService = {}));
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var IpcParameterForm = /** @class */ (function (_super) {
            __extends(IpcParameterForm, _super);
            function IpcParameterForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!IpcParameterForm.init) {
                    IpcParameterForm.init = true;
                    var s = Serenity;
                    var w0 = s.LookupEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.BooleanEditor;
                    var w3 = s.IntegerEditor;
                    var w4 = s.DecimalEditor;
                    Q.initFormType(IpcParameterForm, [
                        'MachineId', w0,
                        'MachineParameterId', w0,
                        'ProtocolId', w0,
                        'IpcAddress', w1,
                        'NodeId', w1,
                        'AttributeId', w0,
                        'IpcParameterName', w1,
                        'StatusId', w0,
                        'IsBitWise', w2,
                        'BitWiseIndex', w3,
                        'Is32Bit', w2,
                        'Bit32Address', w1,
                        'IsWordSwap', w2,
                        'IsByteSwap', w2,
                        'IsStopATIPC', w2,
                        'IsShowAsMessageIPC', w2,
                        'IsBatchStartRequiredIPC', w2,
                        'IsResetOnBatchCreateIPC', w2,
                        'IsLabelRollIPC', w2,
                        'DisableParameterIdIPC', w0,
                        'DisableParameterValueIPC', w1,
                        'IsStopOnBatchStopIPC', w2,
                        'OperationTypeIPC', w0,
                        'OperationValueIPC', w4,
                        'IsAlarm', w2,
                        'IsMachineSpeed', w2,
                        'IsRefreshMachineSettings', w2,
                        'IsHeartBeat', w2,
                        'HeartBeatFailedTime', w3,
                        'IsHeartBeatSend', w2,
                        'IncrementalNumber', w3,
                        'StartNumber', w3,
                        'EndNumber', w3,
                        'IsWriteToPLC', w2,
                        'IsIndicatorParameter', w2,
                        'IndicatorParameterId', w0,
                        'IsGoodBottles', w2,
                        'IsRejectBottles', w2,
                        'IsBatchSize', w2,
                        'IsCounterReset', w2,
                        'IsConveyer', w2,
                        'IsMissingLabelCounter', w2
                    ]);
                }
                return _this;
            }
            IpcParameterForm.formKey = 'ExternalApplicationInterface.IpcParameter';
            return IpcParameterForm;
        }(Serenity.PrefixedContext));
        ExternalApplicationInterface.IpcParameterForm = IpcParameterForm;
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
            IpcParameterRow.lookupKey = 'ExternalApplicationInterface.IpcParameter';
            function getLookup() {
                return Q.getLookup('ExternalApplicationInterface.IpcParameter');
            }
            IpcParameterRow.getLookup = getLookup;
            IpcParameterRow.deletePermission = 'EAI:IPCParameter:Modify';
            IpcParameterRow.insertPermission = 'EAI:IPCParameter:Modify';
            IpcParameterRow.readPermission = 'EAI:IPCParameter:Read';
            IpcParameterRow.updatePermission = 'EAI:IPCParameter:Modify';
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
            function MachineCommunicationForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineCommunicationForm.init) {
                    MachineCommunicationForm.init = true;
                    var s = Serenity;
                    var w0 = s.LookupEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.IntegerEditor;
                    var w3 = s.PasswordEditor;
                    Q.initFormType(MachineCommunicationForm, [
                        'ProtocolTypeId', w0,
                        'MachineId', w0,
                        'IpAddress', w1,
                        'TcpipPort', w2,
                        'PollRate', w2,
                        'MDBPath', w1,
                        'StatusId', w0,
                        'SecurityModeId', w0,
                        'SecurityPolicyId', w0,
                        'UserIdentityId', w0,
                        'UserName', w1,
                        'Password', w3,
                        'CpuTypeId', w0,
                        'Rack', w2,
                        'Slot', w2
                    ]);
                }
                return _this;
            }
            MachineCommunicationForm.formKey = 'ExternalApplicationInterface.MachineCommunication';
            return MachineCommunicationForm;
        }(Serenity.PrefixedContext));
        ExternalApplicationInterface.MachineCommunicationForm = MachineCommunicationForm;
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ExternalApplicationInterface;
    (function (ExternalApplicationInterface) {
        var MachineCommunicationRow;
        (function (MachineCommunicationRow) {
            MachineCommunicationRow.idProperty = 'MachineCommunicatonId';
            MachineCommunicationRow.nameProperty = 'ProtocolName';
            MachineCommunicationRow.localTextPrefix = 'ExternalApplicationInterface.MachineCommunication';
            MachineCommunicationRow.lookupKey = 'ExternalApplicationInterface.MachineCommunication';
            function getLookup() {
                return Q.getLookup('ExternalApplicationInterface.MachineCommunication');
            }
            MachineCommunicationRow.getLookup = getLookup;
            MachineCommunicationRow.deletePermission = 'EAI:MachineCommunication:Modify';
            MachineCommunicationRow.insertPermission = 'EAI:MachineCommunication:Modify';
            MachineCommunicationRow.readPermission = 'EAI:MachineCommunication:Read';
            MachineCommunicationRow.updatePermission = 'EAI:MachineCommunication:Modify';
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
            function ProtocolForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ProtocolForm.init) {
                    ProtocolForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(ProtocolForm, [
                        'ProtocolName', w0,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            ProtocolForm.formKey = 'ExternalApplicationInterface.Protocol';
            return ProtocolForm;
        }(Serenity.PrefixedContext));
        ExternalApplicationInterface.ProtocolForm = ProtocolForm;
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
            ProtocolRow.lookupKey = 'ExternalApplicationInterface.Protocol';
            function getLookup() {
                return Q.getLookup('ExternalApplicationInterface.Protocol');
            }
            ProtocolRow.getLookup = getLookup;
            ProtocolRow.deletePermission = 'EAI:Protocol:Modify';
            ProtocolRow.insertPermission = 'EAI:Protocol:Modify';
            ProtocolRow.readPermission = 'EAI:Protocol:Read';
            ProtocolRow.updatePermission = 'EAI:Protocol:Modify';
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
            });
        })(ProtocolService = ExternalApplicationInterface.ProtocolService || (ExternalApplicationInterface.ProtocolService = {}));
    })(ExternalApplicationInterface = CVC.ExternalApplicationInterface || (CVC.ExternalApplicationInterface = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmDisplayForm = /** @class */ (function (_super) {
            __extends(AlarmDisplayForm, _super);
            function AlarmDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!AlarmDisplayForm.init) {
                    AlarmDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w2 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w3 = CVC.Common.CustomEditors.FontValueEditor;
                    var w4 = s.BooleanEditor;
                    var w5 = CVC.Common.CustomEditors.ActivationValueEditor;
                    var w6 = CVC.Common.CustomEditors.AppearanceValueEditor;
                    var w7 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    Q.initFormType(AlarmDisplayForm, [
                        'AlarmDisplayName', w0,
                        'BackgroundColor', w1,
                        'BorderStyle', w2,
                        'Font', w3,
                        'FontColorSelected', w1,
                        'FontColorUnselected', w1,
                        'CautionColor', w1,
                        'WarningColor', w1,
                        'EmergencyColor', w1,
                        'IsCheckbox', w4,
                        'Activation', w5,
                        'Appearance', w6,
                        'Alignment', w7,
                        'IsOpenInNewWindow', w4,
                        'IsTooltip', w4,
                        'IsHorizontalScrollBar', w4,
                        'IsVerticalScrollBar', w4,
                        'IsFolderBrowse', w4,
                        'IsAddAttachments', w4,
                        'IsCollapsible', w4
                    ]);
                }
                return _this;
            }
            AlarmDisplayForm.formKey = 'MachineCustomization.AlarmDisplay';
            return AlarmDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.AlarmDisplayForm = AlarmDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmDisplayRow;
        (function (AlarmDisplayRow) {
            AlarmDisplayRow.idProperty = 'AlarmDisplayId';
            AlarmDisplayRow.nameProperty = 'AlarmDisplayName';
            AlarmDisplayRow.localTextPrefix = 'MachineCustomization.AlarmDisplay';
            AlarmDisplayRow.lookupKey = 'MachineCustomization.AlarmDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.AlarmDisplay');
            }
            AlarmDisplayRow.getLookup = getLookup;
            AlarmDisplayRow.deletePermission = 'Administration:General';
            AlarmDisplayRow.insertPermission = 'Administration:General';
            AlarmDisplayRow.readPermission = 'Administration:General';
            AlarmDisplayRow.updatePermission = 'Administration:General';
        })(AlarmDisplayRow = MachineCustomization.AlarmDisplayRow || (MachineCustomization.AlarmDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmDisplayService;
        (function (AlarmDisplayService) {
            AlarmDisplayService.baseUrl = 'MachineCustomization/AlarmDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AlarmDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(AlarmDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(AlarmDisplayService = MachineCustomization.AlarmDisplayService || (MachineCustomization.AlarmDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmForm = /** @class */ (function (_super) {
            __extends(AlarmForm, _super);
            function AlarmForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!AlarmForm.init) {
                    AlarmForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.BooleanEditor;
                    var w3 = s.IntegerEditor;
                    var w4 = s.DateEditor;
                    Q.initFormType(AlarmForm, [
                        'AlarmName', w0,
                        'MachineId', w1,
                        'MachineParameterId', w1,
                        'Message', w0,
                        'Description', w0,
                        'IsResetRequired', w2,
                        'IsCommentRequired', w2,
                        'IsMachineRequiredToStop', w2,
                        'MachineStopMachineParameterId', w1,
                        'IsCountForReject', w2,
                        'BitValue', w2,
                        'IsCheckAtMachineStart', w2,
                        'StatusId', w1,
                        'CreatedBy', w3,
                        'CreatedDate', w4,
                        'UpdatedBy', w3,
                        'UpdatedDate', w4,
                        'IsRefreshMachineSettings', w2,
                        'IsHideEdit', w2,
                        'IsAlarmForCounter', w2
                    ]);
                }
                return _this;
            }
            AlarmForm.formKey = 'MachineCustomization.Alarm';
            return AlarmForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.AlarmForm = AlarmForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmResetIdForm = /** @class */ (function (_super) {
            __extends(AlarmResetIdForm, _super);
            function AlarmResetIdForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!AlarmResetIdForm.init) {
                    AlarmResetIdForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    Q.initFormType(AlarmResetIdForm, [
                        'AlarmId', w0,
                        'RoleId', w0,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            AlarmResetIdForm.formKey = 'MachineCustomization.AlarmResetId';
            return AlarmResetIdForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.AlarmResetIdForm = AlarmResetIdForm;
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
            AlarmResetIdRow.deletePermission = 'Administration:General';
            AlarmResetIdRow.insertPermission = 'Administration:General';
            AlarmResetIdRow.readPermission = 'Administration:General';
            AlarmResetIdRow.updatePermission = 'Administration:General';
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
            AlarmRow.deletePermission = 'MachineCustomization:Alarm:Modify';
            AlarmRow.insertPermission = 'MachineCustomization:Alarm:Modify';
            AlarmRow.readPermission = 'MachineCustomization:Alarm:Read';
            AlarmRow.updatePermission = 'MachineCustomization:Alarm:Modify';
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
            });
        })(AlarmService = MachineCustomization.AlarmService || (MachineCustomization.AlarmService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AttachmentDisplayForm = /** @class */ (function (_super) {
            __extends(AttachmentDisplayForm, _super);
            function AttachmentDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!AttachmentDisplayForm.init) {
                    AttachmentDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w2 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w3 = CVC.Common.CustomEditors.FontValueEditor;
                    var w4 = s.BooleanEditor;
                    var w5 = CVC.Common.CustomEditors.ActivationValueEditor;
                    var w6 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    Q.initFormType(AttachmentDisplayForm, [
                        'AttachmentDisplayName', w0,
                        'BackgroundColor', w1,
                        'BorderStyle', w2,
                        'Font', w3,
                        'IsCheckbox', w4,
                        'FontColorSelected', w1,
                        'FontColorUnselected', w1,
                        'Activation', w5,
                        'Alignment', w6,
                        'IsOpenInNewWindow', w4,
                        'IsTooltip', w4,
                        'IsHorizontalScrollBar', w4,
                        'IsVerticalScrollBar', w4,
                        'IsFolderBrowse', w4,
                        'IsAddAttachments', w4,
                        'IsCollapsible', w4
                    ]);
                }
                return _this;
            }
            AttachmentDisplayForm.formKey = 'MachineCustomization.AttachmentDisplay';
            return AttachmentDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.AttachmentDisplayForm = AttachmentDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AttachmentDisplayRow;
        (function (AttachmentDisplayRow) {
            AttachmentDisplayRow.idProperty = 'AttachmentDisplayId';
            AttachmentDisplayRow.nameProperty = 'AttachmentDisplayName';
            AttachmentDisplayRow.localTextPrefix = 'MachineCustomization.AttachmentDisplay';
            AttachmentDisplayRow.lookupKey = 'MachineCustomization.AttachmentDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.AttachmentDisplay');
            }
            AttachmentDisplayRow.getLookup = getLookup;
            AttachmentDisplayRow.deletePermission = 'Administration:General';
            AttachmentDisplayRow.insertPermission = 'Administration:General';
            AttachmentDisplayRow.readPermission = 'Administration:General';
            AttachmentDisplayRow.updatePermission = 'Administration:General';
        })(AttachmentDisplayRow = MachineCustomization.AttachmentDisplayRow || (MachineCustomization.AttachmentDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AttachmentDisplayService;
        (function (AttachmentDisplayService) {
            AttachmentDisplayService.baseUrl = 'MachineCustomization/AttachmentDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AttachmentDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(AttachmentDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(AttachmentDisplayService = MachineCustomization.AttachmentDisplayService || (MachineCustomization.AttachmentDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ButtonDisplayForm = /** @class */ (function (_super) {
            __extends(ButtonDisplayForm, _super);
            function ButtonDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ButtonDisplayForm.init) {
                    ButtonDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = CVC.Common.CustomEditors.FontValueEditor;
                    var w2 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w3 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w4 = CVC.Common.CustomEditors.ActivationValueEditor;
                    var w5 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    var w6 = s.BooleanEditor;
                    Q.initFormType(ButtonDisplayForm, [
                        'ButtonDisplayName', w0,
                        'Font', w1,
                        'BorderStyle', w2,
                        'FontColorSelected', w3,
                        'FontColorUnselected', w3,
                        'BackgroundColor', w3,
                        'Activation', w4,
                        'Alignment', w5,
                        'IsTooltip', w6,
                        'IsHorizontalScrollBar', w6,
                        'IsVerticalScrollBar', w6,
                        'IsCollapsible', w6
                    ]);
                }
                return _this;
            }
            ButtonDisplayForm.formKey = 'MachineCustomization.ButtonDisplay';
            return ButtonDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.ButtonDisplayForm = ButtonDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ButtonDisplayRow;
        (function (ButtonDisplayRow) {
            ButtonDisplayRow.idProperty = 'ButtonDisplayId';
            ButtonDisplayRow.nameProperty = 'ButtonDisplayName';
            ButtonDisplayRow.localTextPrefix = 'MachineCustomization.ButtonDisplay';
            ButtonDisplayRow.lookupKey = 'MachineCustomization.ButtonDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.ButtonDisplay');
            }
            ButtonDisplayRow.getLookup = getLookup;
            ButtonDisplayRow.deletePermission = 'Administration:General';
            ButtonDisplayRow.insertPermission = 'Administration:General';
            ButtonDisplayRow.readPermission = 'Administration:General';
            ButtonDisplayRow.updatePermission = 'Administration:General';
        })(ButtonDisplayRow = MachineCustomization.ButtonDisplayRow || (MachineCustomization.ButtonDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ButtonDisplayService;
        (function (ButtonDisplayService) {
            ButtonDisplayService.baseUrl = 'MachineCustomization/ButtonDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ButtonDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(ButtonDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(ButtonDisplayService = MachineCustomization.ButtonDisplayService || (MachineCustomization.ButtonDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ContainerDisplayForm = /** @class */ (function (_super) {
            __extends(ContainerDisplayForm, _super);
            function ContainerDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ContainerDisplayForm.init) {
                    ContainerDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w2 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w3 = CVC.Common.CustomEditors.FontValueEditor;
                    var w4 = CVC.Common.CustomEditors.ActivationValueEditor;
                    var w5 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    var w6 = s.BooleanEditor;
                    Q.initFormType(ContainerDisplayForm, [
                        'ContainerDisplayName', w0,
                        'BackgroundColor', w1,
                        'BorderStyle', w2,
                        'Font', w3,
                        'FontColorSelected', w1,
                        'FontColorUnselected', w1,
                        'Activation', w4,
                        'Alignment', w5,
                        'IsOpenInNewWindow', w6,
                        'IsTooltip', w6,
                        'IsHorizontalScrollBar', w6,
                        'IsVerticalScrollBar', w6,
                        'IsCollapsible', w6
                    ]);
                }
                return _this;
            }
            ContainerDisplayForm.formKey = 'MachineCustomization.ContainerDisplay';
            return ContainerDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.ContainerDisplayForm = ContainerDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ContainerDisplayRow;
        (function (ContainerDisplayRow) {
            ContainerDisplayRow.idProperty = 'ContainerDisplayId';
            ContainerDisplayRow.nameProperty = 'ContainerDisplayName';
            ContainerDisplayRow.localTextPrefix = 'MachineCustomization.ContainerDisplay';
            ContainerDisplayRow.lookupKey = 'MachineCustomization.ContainerDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.ContainerDisplay');
            }
            ContainerDisplayRow.getLookup = getLookup;
            ContainerDisplayRow.deletePermission = 'Administration:General';
            ContainerDisplayRow.insertPermission = 'Administration:General';
            ContainerDisplayRow.readPermission = 'Administration:General';
            ContainerDisplayRow.updatePermission = 'Administration:General';
        })(ContainerDisplayRow = MachineCustomization.ContainerDisplayRow || (MachineCustomization.ContainerDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ContainerDisplayService;
        (function (ContainerDisplayService) {
            ContainerDisplayService.baseUrl = 'MachineCustomization/ContainerDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ContainerDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(ContainerDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(ContainerDisplayService = MachineCustomization.ContainerDisplayService || (MachineCustomization.ContainerDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectColorForm = /** @class */ (function (_super) {
            __extends(DisplayObjectColorForm, _super);
            function DisplayObjectColorForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            DisplayObjectColorForm.formKey = 'MachineCustomization.DisplayObjectColor';
            return DisplayObjectColorForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.DisplayObjectColorForm = DisplayObjectColorForm;
        [,
            ['RangeFrom', function () { return Serenity.DecimalEditor; }],
            ['RangeTo', function () { return Serenity.DecimalEditor; }],
            ['Color', function () { return Serenity.StringEditor; }],
            ['ViewsId', function () { return Serenity.IntegerEditor; }]
        ].forEach(function (x) { return Object.defineProperty(DisplayObjectColorForm.prototype, x[0], {
            get: function () {
                return this.w(x[0], x[1]());
            },
            enumerable: true,
            configurable: true
        }); });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectColorRow;
        (function (DisplayObjectColorRow) {
            DisplayObjectColorRow.idProperty = 'ColorId';
            DisplayObjectColorRow.nameProperty = 'Color';
            DisplayObjectColorRow.localTextPrefix = 'MachineCustomization.DisplayObjectColor';
            DisplayObjectColorRow.deletePermission = 'Administration:General';
            DisplayObjectColorRow.insertPermission = 'Administration:General';
            DisplayObjectColorRow.readPermission = 'Administration:General';
            DisplayObjectColorRow.updatePermission = 'Administration:General';
            var Fields;
            (function (Fields) {
            })(Fields = DisplayObjectColorRow.Fields || (DisplayObjectColorRow.Fields = {}));
            [
                'ColorId',
                'RangeFrom',
                'RangeTo',
                'Color',
                'ViewsId',
                'ViewsModuleId',
                'ViewsViewName',
                'ViewsIsAccessFieldWise',
                'ViewsStatusId',
                'ViewsCreatedBy',
                'ViewsCreatedDate',
                'ViewsUpdatedBy',
                'ViewsUpdatedDate',
                'ViewsIsMachineSettings',
                'ViewsIsMachineSummary',
                'ViewsIslabelRoll',
                'ViewsIsCommandPanel',
                'ViewsIsFactorySetting',
                'ViewsDisplayObjectTypeId',
                'ViewsMachineId',
                'ViewsListDisplayId',
                'ViewsFormDisplayId',
                'ViewsButtonDisplayId',
                'ViewsRealtimeParameterDisplayId',
                'ViewsLineChartDisplayId',
                'ViewsPieChartDisplayId',
                'ViewsTreeDisplayId',
                'ViewsAttachmentDisplayId',
                'ViewsAlarmDisplayId',
                'ViewsNotificationDisplayId',
                'ViewsContainerDisplayId'
            ].forEach(function (x) { return Fields[x] = x; });
        })(DisplayObjectColorRow = MachineCustomization.DisplayObjectColorRow || (MachineCustomization.DisplayObjectColorRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectColorService;
        (function (DisplayObjectColorService) {
            DisplayObjectColorService.baseUrl = 'MachineCustomization/DisplayObjectColor';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List',
                'FetchAllColumns'
            ].forEach(function (x) {
                DisplayObjectColorService[x] = function (r, s, o) {
                    return Q.serviceRequest(DisplayObjectColorService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(DisplayObjectColorService = MachineCustomization.DisplayObjectColorService || (MachineCustomization.DisplayObjectColorService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectFieldForm = /** @class */ (function (_super) {
            __extends(DisplayObjectFieldForm, _super);
            function DisplayObjectFieldForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!DisplayObjectFieldForm.init) {
                    DisplayObjectFieldForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = MachineCustomization.DisplayObjectLookupEditor;
                    var w2 = s.LookupEditor;
                    var w3 = s.IntegerEditor;
                    var w4 = s.BooleanEditor;
                    Q.initFormType(DisplayObjectFieldForm, [
                        'ViewFieldName', w0,
                        'ViewsId', w1,
                        'MachineParameterId', w2,
                        'Sequence', w3,
                        'StatusId', w2,
                        'IsPopUpRequired', w4,
                        'IsCommentRequired', w4,
                        'IsAuthenticationRequired', w4,
                        'IsSelectAllRoles', w4,
                        'Roles', w2
                    ]);
                }
                return _this;
            }
            DisplayObjectFieldForm.formKey = 'MachineCustomization.DisplayObjectField';
            return DisplayObjectFieldForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.DisplayObjectFieldForm = DisplayObjectFieldForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectFieldRow;
        (function (DisplayObjectFieldRow) {
            DisplayObjectFieldRow.idProperty = 'ViewField';
            DisplayObjectFieldRow.nameProperty = 'ViewFieldName';
            DisplayObjectFieldRow.localTextPrefix = 'MachineCustomization.DisplayObjectField';
            DisplayObjectFieldRow.deletePermission = 'Administration:General';
            DisplayObjectFieldRow.insertPermission = 'Administration:General';
            DisplayObjectFieldRow.readPermission = 'Administration:General';
            DisplayObjectFieldRow.updatePermission = 'Administration:General';
        })(DisplayObjectFieldRow = MachineCustomization.DisplayObjectFieldRow || (MachineCustomization.DisplayObjectFieldRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectFieldService;
        (function (DisplayObjectFieldService) {
            DisplayObjectFieldService.baseUrl = 'MachineCustomization/DisplayObjectField';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                DisplayObjectFieldService[x] = function (r, s, o) {
                    return Q.serviceRequest(DisplayObjectFieldService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(DisplayObjectFieldService = MachineCustomization.DisplayObjectFieldService || (MachineCustomization.DisplayObjectFieldService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectForm = /** @class */ (function (_super) {
            __extends(DisplayObjectForm, _super);
            function DisplayObjectForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!DisplayObjectForm.init) {
                    DisplayObjectForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = CVC.Common.CustomEditors.DOTypeValueEditor;
                    var w3 = s.IntegerEditor;
                    var w4 = s.DateEditor;
                    Q.initFormType(DisplayObjectForm, [
                        'ViewName', w0,
                        'MachineId', w1,
                        'DisplayObjectTypeId', w2,
                        'StatusId', w1,
                        'ListDisplayId', w1,
                        'FormDisplayId', w1,
                        'ButtonDisplayId', w1,
                        'RealtimeParameterDisplayId', w1,
                        'LineChartDisplayId', w1,
                        'PieChartDisplayId', w1,
                        'TreeDisplayId', w1,
                        'AttachmentDisplayId', w1,
                        'AlarmDisplayId', w1,
                        'NotificationDisplayId', w1,
                        'ContainerDisplayId', w1,
                        'CreatedBy', w3,
                        'CreatedDate', w4,
                        'UpdatedBy', w3,
                        'UpdatedDate', w4
                    ]);
                }
                return _this;
            }
            DisplayObjectForm.formKey = 'MachineCustomization.DisplayObject';
            return DisplayObjectForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.DisplayObjectForm = DisplayObjectForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectRow;
        (function (DisplayObjectRow) {
            DisplayObjectRow.idProperty = 'ViewsId';
            DisplayObjectRow.nameProperty = 'ViewName';
            DisplayObjectRow.localTextPrefix = 'MachineCustomization.DisplayObject';
            DisplayObjectRow.lookupKey = 'MachineCustomization.DisplayObject';
            function getLookup() {
                return Q.getLookup('MachineCustomization.DisplayObject');
            }
            DisplayObjectRow.getLookup = getLookup;
            DisplayObjectRow.deletePermission = 'Administration:General';
            DisplayObjectRow.insertPermission = 'Administration:General';
            DisplayObjectRow.readPermission = 'Administration:General';
            DisplayObjectRow.updatePermission = 'Administration:General';
        })(DisplayObjectRow = MachineCustomization.DisplayObjectRow || (MachineCustomization.DisplayObjectRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectService;
        (function (DisplayObjectService) {
            DisplayObjectService.baseUrl = 'MachineCustomization/DisplayObject';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                DisplayObjectService[x] = function (r, s, o) {
                    return Q.serviceRequest(DisplayObjectService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(DisplayObjectService = MachineCustomization.DisplayObjectService || (MachineCustomization.DisplayObjectService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectTypeColorForm = /** @class */ (function (_super) {
            __extends(DisplayObjectTypeColorForm, _super);
            function DisplayObjectTypeColorForm() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            DisplayObjectTypeColorForm.formKey = 'MachineCustomization.DisplayObjectTypeColor';
            return DisplayObjectTypeColorForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.DisplayObjectTypeColorForm = DisplayObjectTypeColorForm;
        [,
            ['DotColor', function () { return CVC.Common.CustomEditors.ColorPickerEditor; }],
            ['Min', function () { return Serenity.DecimalEditor; }],
            ['Max', function () { return Serenity.DecimalEditor; }],
            ['DisplayObjectTypeId', function () { return Serenity.IntegerEditor; }],
            ['SubTypeId', function () { return Serenity.IntegerEditor; }]
        ].forEach(function (x) { return Object.defineProperty(DisplayObjectTypeColorForm.prototype, x[0], {
            get: function () {
                return this.w(x[0], x[1]());
            },
            enumerable: true,
            configurable: true
        }); });
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectTypeColorRow;
        (function (DisplayObjectTypeColorRow) {
            DisplayObjectTypeColorRow.idProperty = 'DotColorId';
            DisplayObjectTypeColorRow.nameProperty = 'DotColor';
            DisplayObjectTypeColorRow.localTextPrefix = 'MachineCustomization.DisplayObjectTypeColor';
            DisplayObjectTypeColorRow.deletePermission = 'Administration:General';
            DisplayObjectTypeColorRow.insertPermission = 'Administration:General';
            DisplayObjectTypeColorRow.readPermission = 'Administration:General';
            DisplayObjectTypeColorRow.updatePermission = 'Administration:General';
            var Fields;
            (function (Fields) {
            })(Fields = DisplayObjectTypeColorRow.Fields || (DisplayObjectTypeColorRow.Fields = {}));
            [
                'DotColorId',
                'DotColor',
                'Min',
                'Max',
                'DisplayObjectTypeId',
                'SubTypeId'
            ].forEach(function (x) { return Fields[x] = x; });
        })(DisplayObjectTypeColorRow = MachineCustomization.DisplayObjectTypeColorRow || (MachineCustomization.DisplayObjectTypeColorRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectTypeColorService;
        (function (DisplayObjectTypeColorService) {
            DisplayObjectTypeColorService.baseUrl = 'MachineCustomization/DisplayObjectTypeColor';
            var Methods;
            (function (Methods) {
            })(Methods = DisplayObjectTypeColorService.Methods || (DisplayObjectTypeColorService.Methods = {}));
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                DisplayObjectTypeColorService[x] = function (r, s, o) {
                    return Q.serviceRequest(DisplayObjectTypeColorService.baseUrl + '/' + x, r, s, o);
                };
                Methods[x] = DisplayObjectTypeColorService.baseUrl + '/' + x;
            });
        })(DisplayObjectTypeColorService = MachineCustomization.DisplayObjectTypeColorService || (MachineCustomization.DisplayObjectTypeColorService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var FormDisplayForm = /** @class */ (function (_super) {
            __extends(FormDisplayForm, _super);
            function FormDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!FormDisplayForm.init) {
                    FormDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w2 = CVC.Common.CustomEditors.FontValueEditor;
                    var w3 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w4 = s.BooleanEditor;
                    var w5 = CVC.Common.CustomEditors.ActivationValueEditor;
                    var w6 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    Q.initFormType(FormDisplayForm, [
                        'FormDisplayName', w0,
                        'BorderStyle', w1,
                        'Font', w2,
                        'BackgroundColor', w3,
                        'IsCheckbox', w4,
                        'FontColorSelected', w3,
                        'FontColorUnselected', w3,
                        'Activation', w5,
                        'Alignment', w6,
                        'IsTooltip', w4,
                        'IsHorizontalScrollBar', w4,
                        'IsVerticalScrollBar', w4,
                        'IsCollapsible', w4
                    ]);
                }
                return _this;
            }
            FormDisplayForm.formKey = 'MachineCustomization.FormDisplay';
            return FormDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.FormDisplayForm = FormDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var FormDisplayRow;
        (function (FormDisplayRow) {
            FormDisplayRow.idProperty = 'FormDisplayId';
            FormDisplayRow.nameProperty = 'FormDisplayName';
            FormDisplayRow.localTextPrefix = 'MachineCustomization.FormDisplay';
            FormDisplayRow.lookupKey = 'MachineCustomization.FormDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.FormDisplay');
            }
            FormDisplayRow.getLookup = getLookup;
            FormDisplayRow.deletePermission = 'Administration:General';
            FormDisplayRow.insertPermission = 'Administration:General';
            FormDisplayRow.readPermission = 'Administration:General';
            FormDisplayRow.updatePermission = 'Administration:General';
        })(FormDisplayRow = MachineCustomization.FormDisplayRow || (MachineCustomization.FormDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var FormDisplayService;
        (function (FormDisplayService) {
            FormDisplayService.baseUrl = 'MachineCustomization/FormDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                FormDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(FormDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(FormDisplayService = MachineCustomization.FormDisplayService || (MachineCustomization.FormDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineChartDisplayForm = /** @class */ (function (_super) {
            __extends(LineChartDisplayForm, _super);
            function LineChartDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!LineChartDisplayForm.init) {
                    LineChartDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = CVC.Common.CustomEditors.FontValueEditor;
                    var w2 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w3 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w4 = s.BooleanEditor;
                    var w5 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    Q.initFormType(LineChartDisplayForm, [
                        'LineChartDisplayName', w0,
                        'Font', w1,
                        'BorderStyle', w2,
                        'BackgroundColor', w3,
                        'FontColor', w3,
                        'IsLegends', w4,
                        'AxisColor', w3,
                        'IsGridlines', w4,
                        'GridlineColor', w3,
                        'Alignment', w5,
                        'IsTooltip', w4,
                        'IsRealtime', w4,
                        'IsHorizontalScrollBar', w4,
                        'IsVerticalScrollBar', w4,
                        'IsCollapsible', w4
                    ]);
                }
                return _this;
            }
            LineChartDisplayForm.formKey = 'MachineCustomization.LineChartDisplay';
            return LineChartDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.LineChartDisplayForm = LineChartDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineChartDisplayRow;
        (function (LineChartDisplayRow) {
            LineChartDisplayRow.idProperty = 'LineChartDisplayId';
            LineChartDisplayRow.nameProperty = 'LineChartDisplayName';
            LineChartDisplayRow.localTextPrefix = 'MachineCustomization.LineChartDisplay';
            LineChartDisplayRow.lookupKey = 'MachineCustomization.LineChartDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.LineChartDisplay');
            }
            LineChartDisplayRow.getLookup = getLookup;
            LineChartDisplayRow.deletePermission = 'Administration:General';
            LineChartDisplayRow.insertPermission = 'Administration:General';
            LineChartDisplayRow.readPermission = 'Administration:General';
            LineChartDisplayRow.updatePermission = 'Administration:General';
        })(LineChartDisplayRow = MachineCustomization.LineChartDisplayRow || (MachineCustomization.LineChartDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineChartDisplayService;
        (function (LineChartDisplayService) {
            LineChartDisplayService.baseUrl = 'MachineCustomization/LineChartDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                LineChartDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(LineChartDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(LineChartDisplayService = MachineCustomization.LineChartDisplayService || (MachineCustomization.LineChartDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineMaintenanceScheduleForm = /** @class */ (function (_super) {
            __extends(LineMaintenanceScheduleForm, _super);
            function LineMaintenanceScheduleForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!LineMaintenanceScheduleForm.init) {
                    LineMaintenanceScheduleForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    var w2 = s.StringEditor;
                    Q.initFormType(LineMaintenanceScheduleForm, [
                        'MachineLineId', w0,
                        'StartDateTime', w1,
                        'EndDateTime', w1,
                        'Description', w2,
                        'Remark', w2,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            LineMaintenanceScheduleForm.formKey = 'MachineCustomization.LineMaintenanceSchedule';
            return LineMaintenanceScheduleForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.LineMaintenanceScheduleForm = LineMaintenanceScheduleForm;
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
            LineMaintenanceScheduleRow.deletePermission = 'Administration:General';
            LineMaintenanceScheduleRow.insertPermission = 'Administration:General';
            LineMaintenanceScheduleRow.readPermission = 'Administration:General';
            LineMaintenanceScheduleRow.updatePermission = 'Administration:General';
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
            });
        })(LineMaintenanceScheduleService = MachineCustomization.LineMaintenanceScheduleService || (MachineCustomization.LineMaintenanceScheduleService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ListDisplayEditorForm = /** @class */ (function (_super) {
            __extends(ListDisplayEditorForm, _super);
            function ListDisplayEditorForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ListDisplayEditorForm.init) {
                    ListDisplayEditorForm.init = true;
                    var s = Serenity;
                    var w0 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w1 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w2 = s.StringEditor;
                    var w3 = s.IntegerEditor;
                    var w4 = s.BooleanEditor;
                    var w5 = CVC.Common.CustomEditors.ActivationValueEditor;
                    var w6 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    var w7 = CVC.Common.CustomEditors.SortTypeValueEditor;
                    Q.initFormType(ListDisplayEditorForm, [
                        'BackgroundColor', w0,
                        'BorderStyle', w1,
                        'Font', w2,
                        'FontColor', w0,
                        'FontSize', w3,
                        'Checkbox', w4,
                        'FullRowSelect', w4,
                        'Gridlines', w4,
                        'UseWaitCursorOnClick', w4,
                        'Activation', w5,
                        'Alignment', w6,
                        'SortingType', w7,
                        'SortAscDesc', w4,
                        'MultiSelect', w4,
                        'AutoResize', w4,
                        'Collapsible', w4
                    ]);
                }
                return _this;
            }
            ListDisplayEditorForm.formKey = 'MachineCustomization.ListDisplayEditor';
            return ListDisplayEditorForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.ListDisplayEditorForm = ListDisplayEditorForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ListDisplayForm = /** @class */ (function (_super) {
            __extends(ListDisplayForm, _super);
            function ListDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ListDisplayForm.init) {
                    ListDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w3 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w4 = CVC.Common.CustomEditors.FontValueEditor;
                    var w5 = CVC.Common.CustomEditors.NumberInputEditor;
                    var w6 = s.BooleanEditor;
                    var w7 = CVC.Common.CustomEditors.ActivationValueEditor;
                    var w8 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    var w9 = CVC.Common.CustomEditors.SortTypeValueEditor;
                    Q.initFormType(ListDisplayForm, [
                        'ListDisplayName', w0,
                        'ListDisplayId', w1,
                        'BackgroundColor', w2,
                        'BorderStyle', w3,
                        'Font', w4,
                        'FontColor', w2,
                        'FontSize', w5,
                        'Checkbox', w6,
                        'FullRowSelect', w6,
                        'Gridlines', w6,
                        'UseWaitCursorOnClick', w6,
                        'Activation', w7,
                        'Alignment', w8,
                        'SortingType', w9,
                        'SortAscDesc', w6,
                        'MultiSelect', w6,
                        'AutoResize', w6,
                        'Collapsible', w6
                    ]);
                }
                return _this;
            }
            ListDisplayForm.formKey = 'MachineCustomization.ListDisplay';
            return ListDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.ListDisplayForm = ListDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ListDisplayRow;
        (function (ListDisplayRow) {
            ListDisplayRow.idProperty = 'ListDisplayId';
            ListDisplayRow.nameProperty = 'ListDisplayName';
            ListDisplayRow.localTextPrefix = 'MachineCustomization.ListDisplay';
            ListDisplayRow.lookupKey = 'MachineCustomization.ListDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.ListDisplay');
            }
            ListDisplayRow.getLookup = getLookup;
            ListDisplayRow.deletePermission = 'Administration:General';
            ListDisplayRow.insertPermission = 'Administration:General';
            ListDisplayRow.readPermission = 'Administration:General';
            ListDisplayRow.updatePermission = 'Administration:General';
        })(ListDisplayRow = MachineCustomization.ListDisplayRow || (MachineCustomization.ListDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ListDisplayService;
        (function (ListDisplayService) {
            ListDisplayService.baseUrl = 'MachineCustomization/ListDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ListDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(ListDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(ListDisplayService = MachineCustomization.ListDisplayService || (MachineCustomization.ListDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineForm = /** @class */ (function (_super) {
            __extends(MachineForm, _super);
            function MachineForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineForm.init) {
                    MachineForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.BooleanEditor;
                    var w2 = s.IntegerEditor;
                    var w3 = s.LookupEditor;
                    var w4 = s.DateEditor;
                    Q.initFormType(MachineForm, [
                        'MachineName', w0,
                        'IsRealTime', w1,
                        'TableId', w2,
                        'TableName', w0,
                        'MachineLineId', w2,
                        'AccessIpAddress', w0,
                        'MachineSequence', w2,
                        'MachineImage', w0,
                        'Description', w0,
                        'ModelNumber', w0,
                        'SerialNumber', w0,
                        'Make', w0,
                        'Year', w2,
                        'TimerForAlarm', w2,
                        'PlcMake', w0,
                        'PlcModelNumber', w0,
                        'PlcSerialNumber', w0,
                        'PlcAddress', w0,
                        'StatusId', w3,
                        'CreatedBy', w2,
                        'CreatedDate', w4,
                        'UpdatedBy', w2,
                        'UpdatedDate', w4
                    ]);
                }
                return _this;
            }
            MachineForm.formKey = 'MachineCustomization.Machine';
            return MachineForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineForm = MachineForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineHelpFileForm = /** @class */ (function (_super) {
            __extends(MachineHelpFileForm, _super);
            function MachineHelpFileForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineHelpFileForm.init) {
                    MachineHelpFileForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(MachineHelpFileForm, [
                        'MachineId', w0,
                        'FileName', w1,
                        'FileContent', w1,
                        'FileLength', w0,
                        'FileExtension', w1,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w2,
                        'UpdatedBy', w0,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            MachineHelpFileForm.formKey = 'MachineCustomization.MachineHelpFile';
            return MachineHelpFileForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineHelpFileForm = MachineHelpFileForm;
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
            MachineHelpFileRow.deletePermission = 'Administration:General';
            MachineHelpFileRow.insertPermission = 'Administration:General';
            MachineHelpFileRow.readPermission = 'Administration:General';
            MachineHelpFileRow.updatePermission = 'Administration:General';
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
            function MachineHistoryForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineHistoryForm.init) {
                    MachineHistoryForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    var w2 = s.StringEditor;
                    Q.initFormType(MachineHistoryForm, [
                        'MachineId', w0,
                        'IssueStartDate', w1,
                        'IssueCloseDate', w1,
                        'ProblemNatureId', w0,
                        'SparePartId', w0,
                        'ProblemDescription', w2,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            MachineHistoryForm.formKey = 'MachineCustomization.MachineHistory';
            return MachineHistoryForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineHistoryForm = MachineHistoryForm;
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
            MachineHistoryRow.deletePermission = 'Administration:General';
            MachineHistoryRow.insertPermission = 'Administration:General';
            MachineHistoryRow.readPermission = 'Administration:General';
            MachineHistoryRow.updatePermission = 'Administration:General';
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
            function MachineLineForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineLineForm.init) {
                    MachineLineForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.DateEditor;
                    var w3 = s.LookupEditor;
                    Q.initFormType(MachineLineForm, [
                        'LineName', w0,
                        'LineRatedSpeed', w0,
                        'NumberOfMachines', w1,
                        'InstalledDate', w2,
                        'StatusId', w3
                    ]);
                }
                return _this;
            }
            MachineLineForm.formKey = 'MachineCustomization.MachineLine';
            return MachineLineForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineLineForm = MachineLineForm;
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
            MachineLineRow.lookupKey = 'MachineCustomization.MachineLine';
            function getLookup() {
                return Q.getLookup('MachineCustomization.MachineLine');
            }
            MachineLineRow.getLookup = getLookup;
            MachineLineRow.deletePermission = 'MachineCustomization:MachineLine:Modify';
            MachineLineRow.insertPermission = 'MachineCustomization:MachineLine:Modify';
            MachineLineRow.readPermission = 'MachineCustomization:MachineLine:Read';
            MachineLineRow.updatePermission = 'MachineCustomization:MachineLine:Modify';
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
            function MachineLineUserForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineLineUserForm.init) {
                    MachineLineUserForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    Q.initFormType(MachineLineUserForm, [
                        'MachineLineId', w0,
                        'UserId', w0,
                        'ShiftId', w0,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            MachineLineUserForm.formKey = 'MachineCustomization.MachineLineUser';
            return MachineLineUserForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineLineUserForm = MachineLineUserForm;
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
            MachineLineUserRow.deletePermission = 'Administration:General';
            MachineLineUserRow.insertPermission = 'Administration:General';
            MachineLineUserRow.readPermission = 'Administration:General';
            MachineLineUserRow.updatePermission = 'Administration:General';
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
            function MachineMaintenanceScheduleForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineMaintenanceScheduleForm.init) {
                    MachineMaintenanceScheduleForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    var w2 = s.StringEditor;
                    Q.initFormType(MachineMaintenanceScheduleForm, [
                        'MachineId', w0,
                        'StartDateTime', w1,
                        'EndDateTime', w1,
                        'Description', w2,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            MachineMaintenanceScheduleForm.formKey = 'MachineCustomization.MachineMaintenanceSchedule';
            return MachineMaintenanceScheduleForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineMaintenanceScheduleForm = MachineMaintenanceScheduleForm;
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
            MachineMaintenanceScheduleRow.deletePermission = 'Administration:General';
            MachineMaintenanceScheduleRow.insertPermission = 'Administration:General';
            MachineMaintenanceScheduleRow.readPermission = 'Administration:General';
            MachineMaintenanceScheduleRow.updatePermission = 'Administration:General';
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
            function MachineParameterForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineParameterForm.init) {
                    MachineParameterForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.BooleanEditor;
                    var w3 = s.DecimalEditor;
                    var w4 = s.IntegerEditor;
                    var w5 = s.DateEditor;
                    Q.initFormType(MachineParameterForm, [
                        'ParameterName', w0,
                        'MachineId', w1,
                        'Description', w0,
                        'IsRangeUnlimited', w2,
                        'Min', w3,
                        'Max', w3,
                        'AllowDecimalPoint', w2,
                        'IsRead', w2,
                        'IsWrite', w2,
                        'DataTypeId', w1,
                        'IsUseUnit', w2,
                        'UnitId', w1,
                        'ColumnName', w0,
                        'PickListId', w1,
                        'StatusId', w1,
                        'Type', w1,
                        'RowId', w4,
                        'ReadMachineParameterId', w1,
                        'QueryTypeRowId', w4,
                        'IsStopAt', w2,
                        'IsBitWise', w2,
                        'BitWiseIndex', w4,
                        'OperationType', w1,
                        'OperationValue', w3,
                        'Is32Bit', w2,
                        'Bit32RowId', w4,
                        'ReloadMachineParameterId', w1,
                        'IsShowAsMessage', w2,
                        'IsResetOnBatchCreate', w2,
                        'IsBatchStartRequired', w2,
                        'IsLabelRoll', w2,
                        'DisableParameterId', w1,
                        'DisableParameterValue', w0,
                        'IsStopOnBatchStop', w2,
                        'CreatedBy', w4,
                        'CreatedDate', w5,
                        'UpdatedBy', w4,
                        'UpdatedDate', w5
                    ]);
                }
                return _this;
            }
            MachineParameterForm.formKey = 'MachineCustomization.MachineParameter';
            return MachineParameterForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineParameterForm = MachineParameterForm;
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
            MachineParameterRow.lookupKey = 'MachineCustomization.MachineParameter';
            function getLookup() {
                return Q.getLookup('MachineCustomization.MachineParameter');
            }
            MachineParameterRow.getLookup = getLookup;
            MachineParameterRow.deletePermission = 'MachineCustomization:MachineParameter:Modify';
            MachineParameterRow.insertPermission = 'MachineCustomization:MachineParameter:Modify';
            MachineParameterRow.readPermission = 'MachineCustomization:MachineParameter:Read';
            MachineParameterRow.updatePermission = 'MachineCustomization:MachineParameter:Modify';
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
            function MachineRecipeForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineRecipeForm.init) {
                    MachineRecipeForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    Q.initFormType(MachineRecipeForm, [
                        'RecipeName', w0,
                        'Description', w0
                    ]);
                }
                return _this;
            }
            MachineRecipeForm.formKey = 'MachineCustomization.MachineRecipe';
            return MachineRecipeForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineRecipeForm = MachineRecipeForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeParameterForm = /** @class */ (function (_super) {
            __extends(MachineRecipeParameterForm, _super);
            function MachineRecipeParameterForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineRecipeParameterForm.init) {
                    MachineRecipeParameterForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(MachineRecipeParameterForm, [
                        'MachineRecipeId', w0,
                        'RecipeSettingsParameterId', w0,
                        'RecipeParameterValue', w1,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w2,
                        'UpdatedBy', w0,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            MachineRecipeParameterForm.formKey = 'MachineCustomization.MachineRecipeParameter';
            return MachineRecipeParameterForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineRecipeParameterForm = MachineRecipeParameterForm;
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
            MachineRecipeParameterRow.deletePermission = 'MachineCustomization:MachineRecipeParameter:Modify';
            MachineRecipeParameterRow.insertPermission = 'MachineCustomization:MachineRecipeParameter:Modify';
            MachineRecipeParameterRow.readPermission = 'MachineCustomization:MachineRecipeParameter:Read';
            MachineRecipeParameterRow.updatePermission = 'MachineCustomization:MachineRecipeParameter:Modify';
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
            });
        })(MachineRecipeParameterService = MachineCustomization.MachineRecipeParameterService || (MachineCustomization.MachineRecipeParameterService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var MachineRecipeReportService;
        (function (MachineRecipeReportService) {
            MachineRecipeReportService.baseUrl = '~/MachineRecipeReport';
        })(MachineRecipeReportService = MachineCustomization.MachineRecipeReportService || (MachineCustomization.MachineRecipeReportService = {}));
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
            MachineRecipeRow.lookupKey = 'MachineCustomization.MachineRecipe';
            function getLookup() {
                return Q.getLookup('MachineCustomization.MachineRecipe');
            }
            MachineRecipeRow.getLookup = getLookup;
            MachineRecipeRow.deletePermission = 'MachineCustomization:MachineRecipe:Modify';
            MachineRecipeRow.insertPermission = 'MachineCustomization:MachineRecipe:Modify';
            MachineRecipeRow.readPermission = 'MachineCustomization:MachineRecipe:Read';
            MachineRecipeRow.updatePermission = 'MachineCustomization:MachineRecipe:Modify';
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
            MachineRow.lookupKey = 'MachineCustomization.Machine';
            function getLookup() {
                return Q.getLookup('MachineCustomization.Machine');
            }
            MachineRow.getLookup = getLookup;
            MachineRow.deletePermission = 'MachineCustomization:Machine:Modify';
            MachineRow.insertPermission = 'MachineCustomization:Machine:Modify';
            MachineRow.readPermission = 'MachineCustomization:Machine:Read';
            MachineRow.updatePermission = 'MachineCustomization:Machine:Modify';
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
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List',
                'FetchAllTables'
            ].forEach(function (x) {
                MachineService[x] = function (r, s, o) {
                    return Q.serviceRequest(MachineService.baseUrl + '/' + x, r, s, o);
                };
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
            function MachineSparePartForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineSparePartForm.init) {
                    MachineSparePartForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(MachineSparePartForm, [
                        'MachineId', w0,
                        'PartNumber', w1,
                        'PartName', w1,
                        'PartDescription', w1,
                        'NoOfUnitsRequired', w0,
                        'PartImage', w1,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w2,
                        'UpdatedBy', w0,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            MachineSparePartForm.formKey = 'MachineCustomization.MachineSparePart';
            return MachineSparePartForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineSparePartForm = MachineSparePartForm;
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
            MachineSparePartRow.deletePermission = 'Administration:General';
            MachineSparePartRow.insertPermission = 'Administration:General';
            MachineSparePartRow.readPermission = 'Administration:General';
            MachineSparePartRow.updatePermission = 'Administration:General';
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
            function MachineSpecificationForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineSpecificationForm.init) {
                    MachineSpecificationForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(MachineSpecificationForm, [
                        'MachineId', w0,
                        'Description', w1,
                        'Details', w1,
                        'MachineImage', w1,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w2,
                        'UpdatedBy', w0,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            MachineSpecificationForm.formKey = 'MachineCustomization.MachineSpecification';
            return MachineSpecificationForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineSpecificationForm = MachineSpecificationForm;
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
            MachineSpecificationRow.deletePermission = 'Administration:General';
            MachineSpecificationRow.insertPermission = 'Administration:General';
            MachineSpecificationRow.readPermission = 'Administration:General';
            MachineSpecificationRow.updatePermission = 'Administration:General';
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
            function MachineUserForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineUserForm.init) {
                    MachineUserForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    Q.initFormType(MachineUserForm, [
                        'MachineId', w0,
                        'UserId', w0,
                        'ShiftId', w0,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            MachineUserForm.formKey = 'MachineCustomization.MachineUser';
            return MachineUserForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineUserForm = MachineUserForm;
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
            MachineUserRow.deletePermission = 'Administration:General';
            MachineUserRow.insertPermission = 'Administration:General';
            MachineUserRow.readPermission = 'Administration:General';
            MachineUserRow.updatePermission = 'Administration:General';
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
            function MachineVideoForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!MachineVideoForm.init) {
                    MachineVideoForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(MachineVideoForm, [
                        'MachineId', w0,
                        'FileName', w1,
                        'FileContent', w1,
                        'FileLength', w0,
                        'FileExtension', w1,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w2,
                        'UpdatedBy', w0,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            MachineVideoForm.formKey = 'MachineCustomization.MachineVideo';
            return MachineVideoForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.MachineVideoForm = MachineVideoForm;
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
            MachineVideoRow.deletePermission = 'Administration:General';
            MachineVideoRow.insertPermission = 'Administration:General';
            MachineVideoRow.readPermission = 'Administration:General';
            MachineVideoRow.updatePermission = 'Administration:General';
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
            });
        })(MachineVideoService = MachineCustomization.MachineVideoService || (MachineCustomization.MachineVideoService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var NotificationDisplayForm = /** @class */ (function (_super) {
            __extends(NotificationDisplayForm, _super);
            function NotificationDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!NotificationDisplayForm.init) {
                    NotificationDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w2 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w3 = CVC.Common.CustomEditors.FontValueEditor;
                    var w4 = CVC.Common.CustomEditors.ActivationValueEditor;
                    var w5 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    var w6 = s.BooleanEditor;
                    Q.initFormType(NotificationDisplayForm, [
                        'NotificationDisplayName', w0,
                        'BackgroundColor', w1,
                        'BorderStyle', w2,
                        'Font', w3,
                        'FontColorSelected', w1,
                        'FontColorUnselected', w1,
                        'Activation', w4,
                        'Alignment', w5,
                        'IsOpenInNewWindow', w6,
                        'IsTooltip', w6,
                        'IsHorizontalScrollBar', w6,
                        'IsVerticalScrollBar', w6,
                        'IsFolderBrowse', w6,
                        'IsAddAttachments', w6,
                        'IsCollapsible', w6
                    ]);
                }
                return _this;
            }
            NotificationDisplayForm.formKey = 'MachineCustomization.NotificationDisplay';
            return NotificationDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.NotificationDisplayForm = NotificationDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var NotificationDisplayRow;
        (function (NotificationDisplayRow) {
            NotificationDisplayRow.idProperty = 'NotificationDisplayId';
            NotificationDisplayRow.nameProperty = 'NotificationDisplayName';
            NotificationDisplayRow.localTextPrefix = 'MachineCustomization.NotificationDisplay';
            NotificationDisplayRow.lookupKey = 'MachineCustomization.NotificationDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.NotificationDisplay');
            }
            NotificationDisplayRow.getLookup = getLookup;
            NotificationDisplayRow.deletePermission = 'Administration:General';
            NotificationDisplayRow.insertPermission = 'Administration:General';
            NotificationDisplayRow.readPermission = 'Administration:General';
            NotificationDisplayRow.updatePermission = 'Administration:General';
        })(NotificationDisplayRow = MachineCustomization.NotificationDisplayRow || (MachineCustomization.NotificationDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var NotificationDisplayService;
        (function (NotificationDisplayService) {
            NotificationDisplayService.baseUrl = 'MachineCustomization/NotificationDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                NotificationDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(NotificationDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(NotificationDisplayService = MachineCustomization.NotificationDisplayService || (MachineCustomization.NotificationDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PieChartDisplayForm = /** @class */ (function (_super) {
            __extends(PieChartDisplayForm, _super);
            function PieChartDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!PieChartDisplayForm.init) {
                    PieChartDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = CVC.Common.CustomEditors.FontValueEditor;
                    var w2 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w3 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w4 = s.BooleanEditor;
                    var w5 = CVC.Common.CustomEditors.NumberInputEditor;
                    var w6 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    Q.initFormType(PieChartDisplayForm, [
                        'PieChartDisplayName', w0,
                        'Font', w1,
                        'BorderStyle', w2,
                        'BackgroundColor', w3,
                        'FontColor', w3,
                        'IsLegends', w4,
                        'LegendFontSize', w5,
                        'IsShowValuesAsPercentage', w4,
                        'IsShowTotal', w4,
                        'Alignment', w6,
                        'IsTooltip', w4,
                        'IsHorizontalScrollBar', w4,
                        'IsVerticalScrollBar', w4,
                        'IsRealtime', w4
                    ]);
                }
                return _this;
            }
            PieChartDisplayForm.formKey = 'MachineCustomization.PieChartDisplay';
            return PieChartDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.PieChartDisplayForm = PieChartDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PieChartDisplayRow;
        (function (PieChartDisplayRow) {
            PieChartDisplayRow.idProperty = 'PieChartDisplayId';
            PieChartDisplayRow.nameProperty = 'PieChartDisplayName';
            PieChartDisplayRow.localTextPrefix = 'MachineCustomization.PieChartDisplay';
            PieChartDisplayRow.lookupKey = 'MachineCustomization.PieChartDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.PieChartDisplay');
            }
            PieChartDisplayRow.getLookup = getLookup;
            PieChartDisplayRow.deletePermission = 'Administration:General';
            PieChartDisplayRow.insertPermission = 'Administration:General';
            PieChartDisplayRow.readPermission = 'Administration:General';
            PieChartDisplayRow.updatePermission = 'Administration:General';
        })(PieChartDisplayRow = MachineCustomization.PieChartDisplayRow || (MachineCustomization.PieChartDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PieChartDisplayService;
        (function (PieChartDisplayService) {
            PieChartDisplayService.baseUrl = 'MachineCustomization/PieChartDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                PieChartDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(PieChartDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(PieChartDisplayService = MachineCustomization.PieChartDisplayService || (MachineCustomization.PieChartDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PrimaryRelationshipForm = /** @class */ (function (_super) {
            __extends(PrimaryRelationshipForm, _super);
            function PrimaryRelationshipForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!PrimaryRelationshipForm.init) {
                    PrimaryRelationshipForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.TextAreaEditor;
                    Q.initFormType(PrimaryRelationshipForm, [
                        'RelationshipName', w0,
                        'PrimaryBe', w1,
                        'PrimaryEf', w1,
                        'Description', w2,
                        'Status', w1
                    ]);
                }
                return _this;
            }
            PrimaryRelationshipForm.formKey = 'MachineCustomization.PrimaryRelationship';
            return PrimaryRelationshipForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.PrimaryRelationshipForm = PrimaryRelationshipForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PrimaryRelationshipRow;
        (function (PrimaryRelationshipRow) {
            PrimaryRelationshipRow.idProperty = 'PrimaryRelationshipId';
            PrimaryRelationshipRow.nameProperty = 'RelationshipName';
            PrimaryRelationshipRow.localTextPrefix = 'MachineCustomization.PrimaryRelationship';
            PrimaryRelationshipRow.lookupKey = 'MachineCustomization.PrimaryRelationship';
            function getLookup() {
                return Q.getLookup('MachineCustomization.PrimaryRelationship');
            }
            PrimaryRelationshipRow.getLookup = getLookup;
            PrimaryRelationshipRow.deletePermission = 'Administration:General';
            PrimaryRelationshipRow.insertPermission = 'Administration:General';
            PrimaryRelationshipRow.readPermission = 'Administration:General';
            PrimaryRelationshipRow.updatePermission = 'Administration:General';
        })(PrimaryRelationshipRow = MachineCustomization.PrimaryRelationshipRow || (MachineCustomization.PrimaryRelationshipRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PrimaryRelationshipService;
        (function (PrimaryRelationshipService) {
            PrimaryRelationshipService.baseUrl = 'MachineCustomization/PrimaryRelationship';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                PrimaryRelationshipService[x] = function (r, s, o) {
                    return Q.serviceRequest(PrimaryRelationshipService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(PrimaryRelationshipService = MachineCustomization.PrimaryRelationshipService || (MachineCustomization.PrimaryRelationshipService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RealtimeParameterDisplayForm = /** @class */ (function (_super) {
            __extends(RealtimeParameterDisplayForm, _super);
            function RealtimeParameterDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!RealtimeParameterDisplayForm.init) {
                    RealtimeParameterDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = CVC.Common.CustomEditors.FontValueEditor;
                    var w2 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w3 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w4 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    var w5 = s.BooleanEditor;
                    Q.initFormType(RealtimeParameterDisplayForm, [
                        'RealtimeParameterDisplayName', w0,
                        'Font', w1,
                        'BorderStyle', w2,
                        'BackgroundColor', w3,
                        'FontColor', w3,
                        'Alignment', w4,
                        'IsTooltip', w5,
                        'IsHorizontalScrollBar', w5,
                        'IsVerticalScrollBar', w5,
                        'IsCollapsible', w5
                    ]);
                }
                return _this;
            }
            RealtimeParameterDisplayForm.formKey = 'MachineCustomization.RealtimeParameterDisplay';
            return RealtimeParameterDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.RealtimeParameterDisplayForm = RealtimeParameterDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RealtimeParameterDisplayRow;
        (function (RealtimeParameterDisplayRow) {
            RealtimeParameterDisplayRow.idProperty = 'RealtimeParameterDisplayId';
            RealtimeParameterDisplayRow.nameProperty = 'RealtimeParameterDisplayName';
            RealtimeParameterDisplayRow.localTextPrefix = 'MachineCustomization.RealtimeParameterDisplay';
            RealtimeParameterDisplayRow.lookupKey = 'MachineCustomization.RealtimeParameterDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.RealtimeParameterDisplay');
            }
            RealtimeParameterDisplayRow.getLookup = getLookup;
            RealtimeParameterDisplayRow.deletePermission = 'Administration:General';
            RealtimeParameterDisplayRow.insertPermission = 'Administration:General';
            RealtimeParameterDisplayRow.readPermission = 'Administration:General';
            RealtimeParameterDisplayRow.updatePermission = 'Administration:General';
        })(RealtimeParameterDisplayRow = MachineCustomization.RealtimeParameterDisplayRow || (MachineCustomization.RealtimeParameterDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RealtimeParameterDisplayService;
        (function (RealtimeParameterDisplayService) {
            RealtimeParameterDisplayService.baseUrl = 'MachineCustomization/RealtimeParameterDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                RealtimeParameterDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(RealtimeParameterDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(RealtimeParameterDisplayService = MachineCustomization.RealtimeParameterDisplayService || (MachineCustomization.RealtimeParameterDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsForm = /** @class */ (function (_super) {
            __extends(RecipeSettingsForm, _super);
            function RecipeSettingsForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!RecipeSettingsForm.init) {
                    RecipeSettingsForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(RecipeSettingsForm, [
                        'RecipeSettingsName', w0,
                        'MachineId', w1,
                        'StatusId', w1,
                        'CreatedBy', w1,
                        'CreatedDate', w2,
                        'UpdatedBy', w1,
                        'UpdatedDate', w2
                    ]);
                }
                return _this;
            }
            RecipeSettingsForm.formKey = 'MachineCustomization.RecipeSettings';
            return RecipeSettingsForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.RecipeSettingsForm = RecipeSettingsForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RecipeSettingsParameterForm = /** @class */ (function (_super) {
            __extends(RecipeSettingsParameterForm, _super);
            function RecipeSettingsParameterForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!RecipeSettingsParameterForm.init) {
                    RecipeSettingsParameterForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    Q.initFormType(RecipeSettingsParameterForm, [
                        'RecipeSettingsId', w0,
                        'IpcParameterId', w0,
                        'IsFetchOnSelfSet', w0,
                        'StatusId', w0,
                        'CreatedBy', w0,
                        'CreatedDate', w1,
                        'UpdatedBy', w0,
                        'UpdatedDate', w1
                    ]);
                }
                return _this;
            }
            RecipeSettingsParameterForm.formKey = 'MachineCustomization.RecipeSettingsParameter';
            return RecipeSettingsParameterForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.RecipeSettingsParameterForm = RecipeSettingsParameterForm;
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
            RecipeSettingsParameterRow.deletePermission = 'Administration:General';
            RecipeSettingsParameterRow.insertPermission = 'Administration:General';
            RecipeSettingsParameterRow.readPermission = 'Administration:General';
            RecipeSettingsParameterRow.updatePermission = 'Administration:General';
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
            RecipeSettingsRow.deletePermission = 'Administration:General';
            RecipeSettingsRow.insertPermission = 'Administration:General';
            RecipeSettingsRow.readPermission = 'Administration:General';
            RecipeSettingsRow.updatePermission = 'Administration:General';
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
            });
        })(RecipeSettingsService = MachineCustomization.RecipeSettingsService || (MachineCustomization.RecipeSettingsService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ScreenViewsForm = /** @class */ (function (_super) {
            __extends(ScreenViewsForm, _super);
            function ScreenViewsForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ScreenViewsForm.init) {
                    ScreenViewsForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.BooleanEditor;
                    Q.initFormType(ScreenViewsForm, [
                        'ScreenViewName', w0,
                        'PrimaryRelationshipId', w1,
                        'IsNoBer', w2,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            ScreenViewsForm.formKey = 'MachineCustomization.ScreenViews';
            return ScreenViewsForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.ScreenViewsForm = ScreenViewsForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ScreenViewsRow;
        (function (ScreenViewsRow) {
            ScreenViewsRow.idProperty = 'ScreenViewId';
            ScreenViewsRow.nameProperty = 'ScreenViewName';
            ScreenViewsRow.localTextPrefix = 'MachineCustomization.ScreenViews';
            ScreenViewsRow.deletePermission = 'Administration:General';
            ScreenViewsRow.insertPermission = 'Administration:General';
            ScreenViewsRow.readPermission = 'Administration:General';
            ScreenViewsRow.updatePermission = 'Administration:General';
        })(ScreenViewsRow = MachineCustomization.ScreenViewsRow || (MachineCustomization.ScreenViewsRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ScreenViewsService;
        (function (ScreenViewsService) {
            ScreenViewsService.baseUrl = 'MachineCustomization/ScreenViews';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                ScreenViewsService[x] = function (r, s, o) {
                    return Q.serviceRequest(ScreenViewsService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(ScreenViewsService = MachineCustomization.ScreenViewsService || (MachineCustomization.ScreenViewsService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var SecondaryRelationshipForm = /** @class */ (function (_super) {
            __extends(SecondaryRelationshipForm, _super);
            function SecondaryRelationshipForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!SecondaryRelationshipForm.init) {
                    SecondaryRelationshipForm.init = true;
                    var s = Serenity;
                    var w0 = MachineCustomization.PrimaryRelationshipLookupEditor;
                    var w1 = MachineCustomization.SecondaryBELookupEditor;
                    var w2 = MachineCustomization.SecondaryEFLookupEditor;
                    var w3 = s.TextAreaEditor;
                    Q.initFormType(SecondaryRelationshipForm, [
                        'PrimaryRelationshipId', w0,
                        'SecondaryBe', w1,
                        'SecondaryEf', w2,
                        'Description', w3
                    ]);
                }
                return _this;
            }
            SecondaryRelationshipForm.formKey = 'MachineCustomization.SecondaryRelationship';
            return SecondaryRelationshipForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.SecondaryRelationshipForm = SecondaryRelationshipForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var SecondaryRelationshipRow;
        (function (SecondaryRelationshipRow) {
            SecondaryRelationshipRow.idProperty = 'SecondaryRelationshipId';
            SecondaryRelationshipRow.nameProperty = 'Description';
            SecondaryRelationshipRow.localTextPrefix = 'MachineCustomization.SecondaryRelationship';
            SecondaryRelationshipRow.deletePermission = 'Administration:General';
            SecondaryRelationshipRow.insertPermission = 'Administration:General';
            SecondaryRelationshipRow.readPermission = 'Administration:General';
            SecondaryRelationshipRow.updatePermission = 'Administration:General';
        })(SecondaryRelationshipRow = MachineCustomization.SecondaryRelationshipRow || (MachineCustomization.SecondaryRelationshipRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var SecondaryRelationshipService;
        (function (SecondaryRelationshipService) {
            SecondaryRelationshipService.baseUrl = 'MachineCustomization/SecondaryRelationship';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                SecondaryRelationshipService[x] = function (r, s, o) {
                    return Q.serviceRequest(SecondaryRelationshipService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(SecondaryRelationshipService = MachineCustomization.SecondaryRelationshipService || (MachineCustomization.SecondaryRelationshipService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var TreeDisplayForm = /** @class */ (function (_super) {
            __extends(TreeDisplayForm, _super);
            function TreeDisplayForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!TreeDisplayForm.init) {
                    TreeDisplayForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = CVC.Common.CustomEditors.ColorPickerEditor;
                    var w2 = CVC.Common.CustomEditors.BorderStyleValueEditor;
                    var w3 = CVC.Common.CustomEditors.FontValueEditor;
                    var w4 = s.BooleanEditor;
                    var w5 = CVC.Common.CustomEditors.DefaultViewValueEditor;
                    var w6 = CVC.Common.CustomEditors.AlignmentValueEditor;
                    Q.initFormType(TreeDisplayForm, [
                        'TreeDisplayName', w0,
                        'BackgroundColor', w1,
                        'BorderStyle', w2,
                        'Font', w3,
                        'FontColor', w1,
                        'IsFullRowSelect', w4,
                        'LineColor', w1,
                        'DefaultView', w5,
                        'Alignment', w6,
                        'IsTooltip', w4,
                        'IsHorizontalScrollBar', w4,
                        'IsVerticalScrollBar', w4,
                        'IsRealtime', w4
                    ]);
                }
                return _this;
            }
            TreeDisplayForm.formKey = 'MachineCustomization.TreeDisplay';
            return TreeDisplayForm;
        }(Serenity.PrefixedContext));
        MachineCustomization.TreeDisplayForm = TreeDisplayForm;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var TreeDisplayRow;
        (function (TreeDisplayRow) {
            TreeDisplayRow.idProperty = 'TreeDisplayId';
            TreeDisplayRow.nameProperty = 'TreeDisplayName';
            TreeDisplayRow.localTextPrefix = 'MachineCustomization.TreeDisplay';
            TreeDisplayRow.lookupKey = 'MachineCustomization.TreeDisplay';
            function getLookup() {
                return Q.getLookup('MachineCustomization.TreeDisplay');
            }
            TreeDisplayRow.getLookup = getLookup;
            TreeDisplayRow.deletePermission = 'Administration:General';
            TreeDisplayRow.insertPermission = 'Administration:General';
            TreeDisplayRow.readPermission = 'Administration:General';
            TreeDisplayRow.updatePermission = 'Administration:General';
        })(TreeDisplayRow = MachineCustomization.TreeDisplayRow || (MachineCustomization.TreeDisplayRow = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var TreeDisplayService;
        (function (TreeDisplayService) {
            TreeDisplayService.baseUrl = 'MachineCustomization/TreeDisplay';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(function (x) {
                TreeDisplayService[x] = function (r, s, o) {
                    return Q.serviceRequest(TreeDisplayService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(TreeDisplayService = MachineCustomization.TreeDisplayService || (MachineCustomization.TreeDisplayService = {}));
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ChangePasswordForm = /** @class */ (function (_super) {
            __extends(ChangePasswordForm, _super);
            function ChangePasswordForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ChangePasswordForm.init) {
                    ChangePasswordForm.init = true;
                    var s = Serenity;
                    var w0 = s.PasswordEditor;
                    Q.initFormType(ChangePasswordForm, [
                        'OldPassword', w0,
                        'NewPassword', w0,
                        'ConfirmPassword', w0
                    ]);
                }
                return _this;
            }
            ChangePasswordForm.formKey = 'Membership.ChangePassword';
            return ChangePasswordForm;
        }(Serenity.PrefixedContext));
        Membership.ChangePasswordForm = ChangePasswordForm;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ForgotPasswordForm = /** @class */ (function (_super) {
            __extends(ForgotPasswordForm, _super);
            function ForgotPasswordForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ForgotPasswordForm.init) {
                    ForgotPasswordForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.PasswordEditor;
                    Q.initFormType(ForgotPasswordForm, [
                        'Username', w0,
                        'QuestionId', w1,
                        'QuestionAns', w0,
                        'Password', w2,
                        'PasswordConfirm', w2
                    ]);
                }
                return _this;
            }
            ForgotPasswordForm.formKey = 'Membership.ForgotPassword';
            return ForgotPasswordForm;
        }(Serenity.PrefixedContext));
        Membership.ForgotPasswordForm = ForgotPasswordForm;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var LoginForm = /** @class */ (function (_super) {
            __extends(LoginForm, _super);
            function LoginForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!LoginForm.init) {
                    LoginForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.PasswordEditor;
                    var w2 = s.BooleanEditor;
                    Q.initFormType(LoginForm, [
                        'Username', w0,
                        'Password', w1,
                        'IsADUser', w2
                    ]);
                }
                return _this;
            }
            LoginForm.formKey = 'Membership.Login';
            return LoginForm;
        }(Serenity.PrefixedContext));
        Membership.LoginForm = LoginForm;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var Pages;
        (function (Pages) {
            var AccountService;
            (function (AccountService) {
                AccountService.baseUrl = '~/Account';
                [
                    'ChangePassword',
                    'ForgotPassword',
                    'ResetPassword',
                    'SignUp'
                ].forEach(function (x) {
                    AccountService[x] = function (r, s, o) {
                        return Q.serviceRequest(AccountService.baseUrl + '/' + x, r, s, o);
                    };
                });
            })(AccountService = Pages.AccountService || (Pages.AccountService = {}));
        })(Pages = Membership.Pages || (Membership.Pages = {}));
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var ResetPasswordForm = /** @class */ (function (_super) {
            __extends(ResetPasswordForm, _super);
            function ResetPasswordForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ResetPasswordForm.init) {
                    ResetPasswordForm.init = true;
                    var s = Serenity;
                    var w0 = s.PasswordEditor;
                    Q.initFormType(ResetPasswordForm, [
                        'NewPassword', w0,
                        'ConfirmPassword', w0
                    ]);
                }
                return _this;
            }
            ResetPasswordForm.formKey = 'Membership.ResetPassword';
            return ResetPasswordForm;
        }(Serenity.PrefixedContext));
        Membership.ResetPasswordForm = ResetPasswordForm;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Membership;
    (function (Membership) {
        var SignUpForm = /** @class */ (function (_super) {
            __extends(SignUpForm, _super);
            function SignUpForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!SignUpForm.init) {
                    SignUpForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.EmailEditor;
                    var w2 = s.PasswordEditor;
                    Q.initFormType(SignUpForm, [
                        'DisplayName', w0,
                        'Email', w1,
                        'ConfirmEmail', w1,
                        'Password', w2,
                        'ConfirmPassword', w2
                    ]);
                }
                return _this;
            }
            SignUpForm.formKey = 'Membership.SignUp';
            return SignUpForm;
        }(Serenity.PrefixedContext));
        Membership.SignUpForm = SignUpForm;
    })(Membership = CVC.Membership || (CVC.Membership = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Models;
    (function (Models) {
        var TreeViewModelService;
        (function (TreeViewModelService) {
            TreeViewModelService.baseUrl = '~/LDAP';
        })(TreeViewModelService = Models.TreeViewModelService || (Models.TreeViewModelService = {}));
    })(Models = CVC.Models || (CVC.Models = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var ModuleManagement;
    (function (ModuleManagement) {
        var ModuleForm = /** @class */ (function (_super) {
            __extends(ModuleForm, _super);
            function ModuleForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ModuleForm.init) {
                    ModuleForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.IntegerEditor;
                    Q.initFormType(ModuleForm, [
                        'ModuleName', w0,
                        'MachineId', w1,
                        'StatusId', w1,
                        'Sequence', w2,
                        'EquipmentId', w0,
                        'SerialNumber', w0
                    ]);
                }
                return _this;
            }
            ModuleForm.formKey = 'ModuleManagement.Module';
            return ModuleForm;
        }(Serenity.PrefixedContext));
        ModuleManagement.ModuleForm = ModuleForm;
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
            ModuleRow.lookupKey = 'ModuleManagement.Module';
            function getLookup() {
                return Q.getLookup('ModuleManagement.Module');
            }
            ModuleRow.getLookup = getLookup;
            ModuleRow.deletePermission = 'ModuleManagement:Module:Modify';
            ModuleRow.insertPermission = 'ModuleManagement:Module:Modify';
            ModuleRow.readPermission = 'ModuleManagement:Module:Read';
            ModuleRow.updatePermission = 'ModuleManagement:Module:Modify';
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
            function ViewFieldForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ViewFieldForm.init) {
                    ViewFieldForm.init = true;
                    var s = Serenity;
                    var w0 = s.LookupEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.IntegerEditor;
                    Q.initFormType(ViewFieldForm, [
                        'ViewsId', w0,
                        'ViewFieldName', w1,
                        'MachineParameterId', w0,
                        'StatusId', w0,
                        'Sequence', w2
                    ]);
                }
                return _this;
            }
            ViewFieldForm.formKey = 'ModuleManagement.ViewField';
            return ViewFieldForm;
        }(Serenity.PrefixedContext));
        ModuleManagement.ViewFieldForm = ViewFieldForm;
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
            ViewFieldRow.lookupKey = 'ModuleManagement.ViewField';
            function getLookup() {
                return Q.getLookup('ModuleManagement.ViewField');
            }
            ViewFieldRow.getLookup = getLookup;
            ViewFieldRow.deletePermission = 'ModuleManagement:ViewField:Modify';
            ViewFieldRow.insertPermission = 'ModuleManagement:ViewField:Modify';
            ViewFieldRow.readPermission = 'ModuleManagement:ViewField:Read';
            ViewFieldRow.updatePermission = 'ModuleManagement:ViewField:Modify';
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
            function ViewsForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ViewsForm.init) {
                    ViewsForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.BooleanEditor;
                    Q.initFormType(ViewsForm, [
                        'ViewName', w0,
                        'ModuleId', w1,
                        'StatusId', w1,
                        'IsMachineSettings', w2,
                        'IsMachineSummary', w2,
                        'IslabelRoll', w2,
                        'IsCommandPanel', w2
                    ]);
                }
                return _this;
            }
            ViewsForm.formKey = 'ModuleManagement.Views';
            return ViewsForm;
        }(Serenity.PrefixedContext));
        ModuleManagement.ViewsForm = ViewsForm;
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
            ViewsRow.lookupKey = 'ModuleManagement.Views';
            function getLookup() {
                return Q.getLookup('ModuleManagement.Views');
            }
            ViewsRow.getLookup = getLookup;
            ViewsRow.deletePermission = 'ModuleManagement:Views:Modify';
            ViewsRow.insertPermission = 'ModuleManagement:Views:Modify';
            ViewsRow.readPermission = 'ModuleManagement:Views:Read';
            ViewsRow.updatePermission = 'ModuleManagement:Views:Modify';
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
            });
        })(ViewsService = ModuleManagement.ViewsService || (ModuleManagement.ViewsService = {}));
    })(ModuleManagement = CVC.ModuleManagement || (CVC.ModuleManagement = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Modules;
    (function (Modules) {
        var Configuration;
        (function (Configuration) {
            var EnvironmentVariables;
            (function (EnvironmentVariables) {
                var HourFormatTypeLookUp;
                (function (HourFormatTypeLookUp) {
                    HourFormatTypeLookUp.idProperty = 'HourFormatTypeID';
                    HourFormatTypeLookUp.nameProperty = 'HourFormatTypeValue';
                    HourFormatTypeLookUp.localTextPrefix = 'Configuration.HourFormatTypeLookUp';
                    HourFormatTypeLookUp.lookupKey = 'Configuration.HourFormatType';
                    function getLookup() {
                        return Q.getLookup('Configuration.HourFormatType');
                    }
                    HourFormatTypeLookUp.getLookup = getLookup;
                    HourFormatTypeLookUp.deletePermission = 'Lookup';
                    HourFormatTypeLookUp.insertPermission = 'Lookup';
                    HourFormatTypeLookUp.readPermission = 'Lookup';
                    HourFormatTypeLookUp.updatePermission = 'Lookup';
                })(HourFormatTypeLookUp = EnvironmentVariables.HourFormatTypeLookUp || (EnvironmentVariables.HourFormatTypeLookUp = {}));
            })(EnvironmentVariables = Configuration.EnvironmentVariables || (Configuration.EnvironmentVariables = {}));
        })(Configuration = Modules.Configuration || (Modules.Configuration = {}));
    })(Modules = CVC.Modules || (CVC.Modules = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Modules;
    (function (Modules) {
        var Configuration;
        (function (Configuration) {
            var Status;
            (function (Status) {
                var Class1Row;
                (function (Class1Row) {
                    Class1Row.idProperty = 'AttributeId';
                    Class1Row.nameProperty = 'Name';
                    Class1Row.localTextPrefix = 'Configuration.Status1';
                    Class1Row.lookupKey = 'Configuration.Status1';
                    function getLookup() {
                        return Q.getLookup('Configuration.Status1');
                    }
                    Class1Row.getLookup = getLookup;
                    Class1Row.deletePermission = 'Lookup';
                    Class1Row.insertPermission = 'Lookup';
                    Class1Row.readPermission = 'Lookup';
                    Class1Row.updatePermission = 'Lookup';
                })(Class1Row = Status.Class1Row || (Status.Class1Row = {}));
            })(Status = Configuration.Status || (Configuration.Status = {}));
        })(Configuration = Modules.Configuration || (Modules.Configuration = {}));
    })(Modules = CVC.Modules || (CVC.Modules = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Modules;
    (function (Modules) {
        var ExternalApplicationInterface;
        (function (ExternalApplicationInterface) {
            var IpcParameter;
            (function (IpcParameter) {
                var MachineProtocolCommunication;
                (function (MachineProtocolCommunication) {
                    MachineProtocolCommunication.idProperty = 'ProtocolTypeId';
                    MachineProtocolCommunication.nameProperty = 'ProtocolName';
                    MachineProtocolCommunication.localTextPrefix = 'ExternalApplicationInterface.MachineCommunication';
                    MachineProtocolCommunication.lookupKey = 'ExternalApplicationInterface.MachineProtocolCommunication';
                    function getLookup() {
                        return Q.getLookup('ExternalApplicationInterface.MachineProtocolCommunication');
                    }
                    MachineProtocolCommunication.getLookup = getLookup;
                    MachineProtocolCommunication.deletePermission = 'EAI:MachineCommunication:Modify';
                    MachineProtocolCommunication.insertPermission = 'EAI:MachineCommunication:Modify';
                    MachineProtocolCommunication.readPermission = 'EAI:MachineCommunication:Read';
                    MachineProtocolCommunication.updatePermission = 'EAI:MachineCommunication:Modify';
                })(MachineProtocolCommunication = IpcParameter.MachineProtocolCommunication || (IpcParameter.MachineProtocolCommunication = {}));
            })(IpcParameter = ExternalApplicationInterface.IpcParameter || (ExternalApplicationInterface.IpcParameter = {}));
        })(ExternalApplicationInterface = Modules.ExternalApplicationInterface || (Modules.ExternalApplicationInterface = {}));
    })(Modules = CVC.Modules || (CVC.Modules = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Modules;
    (function (Modules) {
        var MachineCustomization;
        (function (MachineCustomization) {
            var SaveRecipe;
            (function (SaveRecipe) {
                var SaveRecipeRow;
                (function (SaveRecipeRow) {
                    SaveRecipeRow.idProperty = 'MachineRecipeId';
                    SaveRecipeRow.nameProperty = 'RecipeName';
                    SaveRecipeRow.localTextPrefix = 'MachineCustomization.SaveRecipe';
                    SaveRecipeRow.lookupKey = 'MachineCustomization.SaveRecipe';
                    function getLookup() {
                        return Q.getLookup('MachineCustomization.SaveRecipe');
                    }
                    SaveRecipeRow.getLookup = getLookup;
                    SaveRecipeRow.deletePermission = 'MachineCustomization:SaveRecipe:Modify';
                    SaveRecipeRow.insertPermission = 'MachineCustomization:SaveRecipe:Modify';
                    SaveRecipeRow.readPermission = 'MachineCustomization:SaveRecipe:Read';
                    SaveRecipeRow.updatePermission = 'MachineCustomization:SaveRecipe:Modify';
                })(SaveRecipeRow = SaveRecipe.SaveRecipeRow || (SaveRecipe.SaveRecipeRow = {}));
            })(SaveRecipe = MachineCustomization.SaveRecipe || (MachineCustomization.SaveRecipe = {}));
        })(MachineCustomization = Modules.MachineCustomization || (Modules.MachineCustomization = {}));
    })(Modules = CVC.Modules || (CVC.Modules = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var BottleForm = /** @class */ (function (_super) {
            __extends(BottleForm, _super);
            function BottleForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!BottleForm.init) {
                    BottleForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(BottleForm, [
                        'BottleName', w0,
                        'BottleCc', w0,
                        'ContainerTypeId', w1,
                        'BottleHeight', w0,
                        'BottleDiameter', w0,
                        'BottleMouthOpeningId', w0,
                        'BottleMouthOpeningOd', w0,
                        'SupplierId', w1,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            BottleForm.formKey = 'PackSettings.Bottle';
            return BottleForm;
        }(Serenity.PrefixedContext));
        PackSettings.BottleForm = BottleForm;
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
            BottleRow.lookupKey = 'PackSettings.Bottle';
            function getLookup() {
                return Q.getLookup('PackSettings.Bottle');
            }
            BottleRow.getLookup = getLookup;
            BottleRow.deletePermission = 'PackSettings:Bottle:Modify';
            BottleRow.insertPermission = 'PackSettings:Bottle:Modify';
            BottleRow.readPermission = 'PackSettings:Bottle:Read';
            BottleRow.updatePermission = 'PackSettings:Bottle:Modify';
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
            function CapForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!CapForm.init) {
                    CapForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(CapForm, [
                        'CapName', w0,
                        'CapCc', w0,
                        'CapTypeId', w1,
                        'CapDiameter', w0,
                        'CapHeight', w0,
                        'SupplierId', w1,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            CapForm.formKey = 'PackSettings.Cap';
            return CapForm;
        }(Serenity.PrefixedContext));
        PackSettings.CapForm = CapForm;
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
            CapRow.lookupKey = 'PackSettings.Cap';
            function getLookup() {
                return Q.getLookup('PackSettings.Cap');
            }
            CapRow.getLookup = getLookup;
            CapRow.deletePermission = 'PackSettings:Cap:Modify';
            CapRow.insertPermission = 'PackSettings:Cap:Modify';
            CapRow.readPermission = 'PackSettings:Cap:Read';
            CapRow.updatePermission = 'PackSettings:Cap:Modify';
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
            function CottonForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!CottonForm.init) {
                    CottonForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(CottonForm, [
                        'CottonName', w0,
                        'CottonTypeId', w1,
                        'GmOrYard', w0,
                        'SupplierId', w1,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            CottonForm.formKey = 'PackSettings.Cotton';
            return CottonForm;
        }(Serenity.PrefixedContext));
        PackSettings.CottonForm = CottonForm;
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
            CottonRow.lookupKey = 'PackSettings.Cotton';
            function getLookup() {
                return Q.getLookup('PackSettings.Cotton');
            }
            CottonRow.getLookup = getLookup;
            CottonRow.deletePermission = 'PackSettings:Cotton:Modify';
            CottonRow.insertPermission = 'PackSettings:Cotton:Modify';
            CottonRow.readPermission = 'PackSettings:Cotton:Read';
            CottonRow.updatePermission = 'PackSettings:Cotton:Modify';
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
            function DesiccantForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!DesiccantForm.init) {
                    DesiccantForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(DesiccantForm, [
                        'DesiccantName', w0,
                        'DesiccantTypeId', w1,
                        'Grammage', w0,
                        'LengthOrHeight', w0,
                        'DiameterOrWidth', w0,
                        'Identification', w1,
                        'SupplierId', w1,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            DesiccantForm.formKey = 'PackSettings.Desiccant';
            return DesiccantForm;
        }(Serenity.PrefixedContext));
        PackSettings.DesiccantForm = DesiccantForm;
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
            DesiccantRow.lookupKey = 'PackSettings.Desiccant';
            function getLookup() {
                return Q.getLookup('PackSettings.Desiccant');
            }
            DesiccantRow.getLookup = getLookup;
            DesiccantRow.deletePermission = 'PackSettings:Desiccant:Modify';
            DesiccantRow.insertPermission = 'PackSettings:Desiccant:Modify';
            DesiccantRow.readPermission = 'PackSettings:Desiccant:Read';
            DesiccantRow.updatePermission = 'PackSettings:Desiccant:Modify';
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
            function EndOfLineForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!EndOfLineForm.init) {
                    EndOfLineForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(EndOfLineForm, [
                        'EndOfLineName', w0,
                        'CartonLength', w0,
                        'CartonHeight', w0,
                        'CartonWidth', w0,
                        'CartonType', w0,
                        'BottleConfiguration', w0,
                        'MedicationLength', w0,
                        'MedicationWidth', w0,
                        'NoOfMedication', w0,
                        'InnerShipperBoxType', w0,
                        'InnerShipperBoxLength', w0,
                        'InnerShipperBoxWidth', w0,
                        'InnerShipperBoxHeight', w0,
                        'OuterShipperBoxLength', w0,
                        'OuterShipperBoxWidth', w0,
                        'OuterShipperBoxHeight', w0,
                        'InnerShipperMatrix', w0,
                        'OuterShipperQuantity', w0,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            EndOfLineForm.formKey = 'PackSettings.EndOfLine';
            return EndOfLineForm;
        }(Serenity.PrefixedContext));
        PackSettings.EndOfLineForm = EndOfLineForm;
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
            EndOfLineRow.lookupKey = 'PackSettings.EndOfLine';
            function getLookup() {
                return Q.getLookup('PackSettings.EndOfLine');
            }
            EndOfLineRow.getLookup = getLookup;
            EndOfLineRow.deletePermission = 'PackSettings:EndOfLine:Modify';
            EndOfLineRow.insertPermission = 'PackSettings:EndOfLine:Modify';
            EndOfLineRow.readPermission = 'PackSettings:EndOfLine:Read';
            EndOfLineRow.updatePermission = 'PackSettings:EndOfLine:Modify';
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
            function LabelForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!LabelForm.init) {
                    LabelForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.ImageUploadEditor;
                    var w2 = s.LookupEditor;
                    Q.initFormType(LabelForm, [
                        'LabelName', w0,
                        'LabelLength', w0,
                        'LabelHeight', w0,
                        'LabelType', w0,
                        'LabelImage', w1,
                        'SupplierId', w2,
                        'StatusId', w2
                    ]);
                }
                return _this;
            }
            LabelForm.formKey = 'PackSettings.Label';
            return LabelForm;
        }(Serenity.PrefixedContext));
        PackSettings.LabelForm = LabelForm;
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
            LabelRow.lookupKey = 'PackSettings.Label';
            function getLookup() {
                return Q.getLookup('PackSettings.Label');
            }
            LabelRow.getLookup = getLookup;
            LabelRow.deletePermission = 'PackSettings:Label:Modify';
            LabelRow.insertPermission = 'PackSettings:Label:Modify';
            LabelRow.readPermission = 'PackSettings:Label:Read';
            LabelRow.updatePermission = 'PackSettings:Label:Modify';
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
            function OutsertForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!OutsertForm.init) {
                    OutsertForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(OutsertForm, [
                        'OutsertName', w0,
                        'OutsertLength', w0,
                        'OutsertWidth', w0,
                        'OutsertThickness', w0,
                        'SupplierId', w1,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            OutsertForm.formKey = 'PackSettings.Outsert';
            return OutsertForm;
        }(Serenity.PrefixedContext));
        PackSettings.OutsertForm = OutsertForm;
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
            OutsertRow.lookupKey = 'PackSettings.Outsert';
            function getLookup() {
                return Q.getLookup('PackSettings.Outsert');
            }
            OutsertRow.getLookup = getLookup;
            OutsertRow.deletePermission = 'PackSettings:Outsert:Modify';
            OutsertRow.insertPermission = 'PackSettings:Outsert:Modify';
            OutsertRow.readPermission = 'PackSettings:Outsert:Read';
            OutsertRow.updatePermission = 'PackSettings:Outsert:Modify';
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
            function PackForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!PackForm.init) {
                    PackForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    var w2 = s.IntegerEditor;
                    Q.initFormType(PackForm, [
                        'PackName', w0,
                        'TabletId', w1,
                        'TabletCount', w2,
                        'BottleId', w1,
                        'CapId', w1,
                        'CottonId', w1,
                        'CottonLength', w0,
                        'NumberOfCottonPieces', w2,
                        'DesiccantId', w1,
                        'NumberOfDesicantPieces', w2,
                        'OutsertId', w1,
                        'LabelId', w1,
                        'EndOfLineId', w1,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            PackForm.formKey = 'PackSettings.Pack';
            return PackForm;
        }(Serenity.PrefixedContext));
        PackSettings.PackForm = PackForm;
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
            PackRow.lookupKey = 'PackSettings.Pack';
            function getLookup() {
                return Q.getLookup('PackSettings.Pack');
            }
            PackRow.getLookup = getLookup;
            PackRow.deletePermission = 'PackSettings:Pack:Modify';
            PackRow.insertPermission = 'PackSettings:Pack:Modify';
            PackRow.readPermission = 'PackSettings:Pack:Read';
            PackRow.updatePermission = 'PackSettings:Pack:Modify';
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
            function TabletDetailsForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!TabletDetailsForm.init) {
                    TabletDetailsForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.LookupEditor;
                    Q.initFormType(TabletDetailsForm, [
                        'TabletName', w0,
                        'TabletStrength', w0,
                        'TabletTypeId', w1,
                        'TabletCharOneId', w1,
                        'TabletCharTwoId', w1,
                        'TabletShapeId', w1,
                        'TabletLength', w0,
                        'TabletThickness', w0,
                        'TabletWidth', w0,
                        'StatusId', w1
                    ]);
                }
                return _this;
            }
            TabletDetailsForm.formKey = 'PackSettings.TabletDetails';
            return TabletDetailsForm;
        }(Serenity.PrefixedContext));
        PackSettings.TabletDetailsForm = TabletDetailsForm;
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
            TabletDetailsRow.lookupKey = 'PackSettings.Tablet';
            function getLookup() {
                return Q.getLookup('PackSettings.Tablet');
            }
            TabletDetailsRow.getLookup = getLookup;
            TabletDetailsRow.deletePermission = 'PackSettings:TabletDetails:Modify';
            TabletDetailsRow.insertPermission = 'PackSettings:TabletDetails:Modify';
            TabletDetailsRow.readPermission = 'PackSettings:TabletDetails:Read';
            TabletDetailsRow.updatePermission = 'PackSettings:TabletDetails:Modify';
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
            });
        })(TabletDetailsService = PackSettings.TabletDetailsService || (PackSettings.TabletDetailsService = {}));
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogArchiveForm = /** @class */ (function (_super) {
            __extends(AlarmLogArchiveForm, _super);
            function AlarmLogArchiveForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!AlarmLogArchiveForm.init) {
                    AlarmLogArchiveForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(AlarmLogArchiveForm, [
                        'MachineId', w0,
                        'AlarmId', w0,
                        'BatchId', w0,
                        'LoggedUserId', w0,
                        'Comment', w1,
                        'Description', w1,
                        'AlarmDateTime', w2,
                        'PcipAddress', w1
                    ]);
                }
                return _this;
            }
            AlarmLogArchiveForm.formKey = 'Report.AlarmLogArchive';
            return AlarmLogArchiveForm;
        }(Serenity.PrefixedContext));
        Report.AlarmLogArchiveForm = AlarmLogArchiveForm;
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
            AlarmLogArchiveRow.deletePermission = 'Report:AlarmLogArchive:Read';
            AlarmLogArchiveRow.insertPermission = 'Report:AlarmLogArchive:Read';
            AlarmLogArchiveRow.readPermission = 'Report:AlarmLogArchive:Read';
            AlarmLogArchiveRow.updatePermission = 'Report:AlarmLogArchive:Read';
        })(AlarmLogArchiveRow = Report.AlarmLogArchiveRow || (Report.AlarmLogArchiveRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogArchiveService;
        (function (AlarmLogArchiveService) {
            AlarmLogArchiveService.baseUrl = 'Report/AlarmLogArchive';
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
            });
        })(AlarmLogArchiveService = Report.AlarmLogArchiveService || (Report.AlarmLogArchiveService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogForm = /** @class */ (function (_super) {
            __extends(AlarmLogForm, _super);
            function AlarmLogForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!AlarmLogForm.init) {
                    AlarmLogForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(AlarmLogForm, [
                        'MachineId', w0,
                        'AlarmId', w0,
                        'BatchId', w0,
                        'LoggedUserId', w0,
                        'Comment', w1,
                        'Description', w1,
                        'AlarmDateTime', w2,
                        'PcipAddress', w1
                    ]);
                }
                return _this;
            }
            AlarmLogForm.formKey = 'Report.AlarmLog';
            return AlarmLogForm;
        }(Serenity.PrefixedContext));
        Report.AlarmLogForm = AlarmLogForm;
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
            AlarmLogRow.deletePermission = 'Report:AlarmLog:Read';
            AlarmLogRow.insertPermission = 'Report:AlarmLog:Read';
            AlarmLogRow.readPermission = 'Report:AlarmLog:Read';
            AlarmLogRow.updatePermission = 'Report:AlarmLog:Read';
        })(AlarmLogRow = Report.AlarmLogRow || (Report.AlarmLogRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AlarmLogService;
        (function (AlarmLogService) {
            AlarmLogService.baseUrl = 'Report/AlarmLog';
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
            });
        })(AlarmLogService = Report.AlarmLogService || (Report.AlarmLogService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogArchiveForm = /** @class */ (function (_super) {
            __extends(AuditLogArchiveForm, _super);
            function AuditLogArchiveForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!AuditLogArchiveForm.init) {
                    AuditLogArchiveForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(AuditLogArchiveForm, [
                        'UserId', w0,
                        'UserName', w1,
                        'Action', w1,
                        'ChangedOn', w2,
                        'TableName', w1,
                        'RowId', w0,
                        'Module', w1,
                        'Page', w1,
                        'FieldName', w1,
                        'OldValue', w1,
                        'NewValue', w1,
                        'Comments', w1,
                        'PcipAddress', w1,
                        'BatchId', w0,
                        'BatchName', w1,
                        'MachineId', w0,
                        'MachineName', w1
                    ]);
                }
                return _this;
            }
            AuditLogArchiveForm.formKey = 'Report.AuditLogArchive';
            return AuditLogArchiveForm;
        }(Serenity.PrefixedContext));
        Report.AuditLogArchiveForm = AuditLogArchiveForm;
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
            AuditLogArchiveRow.deletePermission = 'Report:AuditLogArchive:Read';
            AuditLogArchiveRow.insertPermission = 'Report:AuditLogArchive:Read';
            AuditLogArchiveRow.readPermission = 'Report:AuditLogArchive:Read';
            AuditLogArchiveRow.updatePermission = 'Report:AuditLogArchive:Read';
        })(AuditLogArchiveRow = Report.AuditLogArchiveRow || (Report.AuditLogArchiveRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogArchiveService;
        (function (AuditLogArchiveService) {
            AuditLogArchiveService.baseUrl = 'Report/AuditLogArchive';
            [
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AuditLogArchiveService[x] = function (r, s, o) {
                    return Q.serviceRequest(AuditLogArchiveService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(AuditLogArchiveService = Report.AuditLogArchiveService || (Report.AuditLogArchiveService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogForm = /** @class */ (function (_super) {
            __extends(AuditLogForm, _super);
            function AuditLogForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!AuditLogForm.init) {
                    AuditLogForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    var w3 = s.LookupEditor;
                    Q.initFormType(AuditLogForm, [
                        'UserId', w0,
                        'UserName', w1,
                        'Action', w1,
                        'ChangedOn', w2,
                        'TableName', w1,
                        'RowId', w0,
                        'Module', w1,
                        'Page', w1,
                        'FieldName', w1,
                        'OldValue', w1,
                        'NewValue', w1,
                        'Comments', w1,
                        'PcipAddress', w1,
                        'BatchId', w0,
                        'BatchName', w1,
                        'MachineId', w3,
                        'MachineName', w1
                    ]);
                }
                return _this;
            }
            AuditLogForm.formKey = 'Report.AuditLog';
            return AuditLogForm;
        }(Serenity.PrefixedContext));
        Report.AuditLogForm = AuditLogForm;
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
            AuditLogRow.deletePermission = 'Report:AuditLog:Read';
            AuditLogRow.insertPermission = 'Report:AuditLog:Read';
            AuditLogRow.readPermission = 'Report:AuditLog:Read';
            AuditLogRow.updatePermission = 'Report:AuditLog:Read';
        })(AuditLogRow = Report.AuditLogRow || (Report.AuditLogRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var AuditLogService;
        (function (AuditLogService) {
            AuditLogService.baseUrl = 'Report/AuditLog';
            [
                'Retrieve',
                'List'
            ].forEach(function (x) {
                AuditLogService[x] = function (r, s, o) {
                    return Q.serviceRequest(AuditLogService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(AuditLogService = Report.AuditLogService || (Report.AuditLogService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var BatchLogArchiveForm = /** @class */ (function (_super) {
            __extends(BatchLogArchiveForm, _super);
            function BatchLogArchiveForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!BatchLogArchiveForm.init) {
                    BatchLogArchiveForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(BatchLogArchiveForm, [
                        'MachineId', w0,
                        'BatchId', w0,
                        'Description', w1,
                        'UserId', w0,
                        'UpdatedDateTime', w2
                    ]);
                }
                return _this;
            }
            BatchLogArchiveForm.formKey = 'Report.BatchLogArchive';
            return BatchLogArchiveForm;
        }(Serenity.PrefixedContext));
        Report.BatchLogArchiveForm = BatchLogArchiveForm;
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var BatchLogArchiveRow;
        (function (BatchLogArchiveRow) {
            BatchLogArchiveRow.idProperty = 'BatchLogArchiveId';
            BatchLogArchiveRow.nameProperty = 'Description';
            BatchLogArchiveRow.localTextPrefix = 'Report.BatchLogArchive';
            BatchLogArchiveRow.deletePermission = 'Administration:General';
            BatchLogArchiveRow.insertPermission = 'Administration:General';
            BatchLogArchiveRow.readPermission = 'Administration:General';
            BatchLogArchiveRow.updatePermission = 'Administration:General';
        })(BatchLogArchiveRow = Report.BatchLogArchiveRow || (Report.BatchLogArchiveRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var BatchLogArchiveService;
        (function (BatchLogArchiveService) {
            BatchLogArchiveService.baseUrl = 'Report/BatchLogArchive';
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
            });
        })(BatchLogArchiveService = Report.BatchLogArchiveService || (Report.BatchLogArchiveService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var BatchLogForm = /** @class */ (function (_super) {
            __extends(BatchLogForm, _super);
            function BatchLogForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!BatchLogForm.init) {
                    BatchLogForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.StringEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(BatchLogForm, [
                        'MachineId', w0,
                        'BatchId', w0,
                        'Description', w1,
                        'UserId', w0,
                        'UpdatedDateTime', w2
                    ]);
                }
                return _this;
            }
            BatchLogForm.formKey = 'Report.BatchLog';
            return BatchLogForm;
        }(Serenity.PrefixedContext));
        Report.BatchLogForm = BatchLogForm;
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
            BatchLogRow.deletePermission = 'Report:BatchLog:Read';
            BatchLogRow.insertPermission = 'Report:BatchLog:Read';
            BatchLogRow.readPermission = 'Report:BatchLog:Read';
            BatchLogRow.updatePermission = 'Report:BatchLog:Read';
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
            });
        })(BatchLogService = Report.BatchLogService || (Report.BatchLogService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var ExceptionLogForm = /** @class */ (function (_super) {
            __extends(ExceptionLogForm, _super);
            function ExceptionLogForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!ExceptionLogForm.init) {
                    ExceptionLogForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    Q.initFormType(ExceptionLogForm, [
                        'Id', w0,
                        'Type', w0,
                        'Url', w0,
                        'Message', w0
                    ]);
                }
                return _this;
            }
            ExceptionLogForm.formKey = 'Report.ExceptionLog';
            return ExceptionLogForm;
        }(Serenity.PrefixedContext));
        Report.ExceptionLogForm = ExceptionLogForm;
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
            ExceptionLogRow.deletePermission = 'Report:ExceptionLog:Read';
            ExceptionLogRow.insertPermission = 'Report:ExceptionLog:Read';
            ExceptionLogRow.readPermission = 'Report:ExceptionLog:Read';
            ExceptionLogRow.updatePermission = 'Report:ExceptionLog:Read';
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
            });
        })(ExceptionLogService = Report.ExceptionLogService || (Report.ExceptionLogService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogArchiveForm = /** @class */ (function (_super) {
            __extends(UserLogArchiveForm, _super);
            function UserLogArchiveForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!UserLogArchiveForm.init) {
                    UserLogArchiveForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(UserLogArchiveForm, [
                        'UserLogArchiveId', w0,
                        'UserId', w1,
                        'UserName', w0,
                        'Action', w0,
                        'ChangedOn', w2
                    ]);
                }
                return _this;
            }
            UserLogArchiveForm.formKey = 'Report.UserLogArchive';
            return UserLogArchiveForm;
        }(Serenity.PrefixedContext));
        Report.UserLogArchiveForm = UserLogArchiveForm;
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
            UserLogArchiveRow.deletePermission = 'Report:UserLogArchive:Read';
            UserLogArchiveRow.insertPermission = 'Report:UserLogArchive:Read';
            UserLogArchiveRow.readPermission = 'Report:UserLogArchive:Read';
            UserLogArchiveRow.updatePermission = 'Report:UserLogArchive:Read';
        })(UserLogArchiveRow = Report.UserLogArchiveRow || (Report.UserLogArchiveRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogArchiveService;
        (function (UserLogArchiveService) {
            UserLogArchiveService.baseUrl = 'Report/UserLogArchive';
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
            });
        })(UserLogArchiveService = Report.UserLogArchiveService || (Report.UserLogArchiveService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogForm = /** @class */ (function (_super) {
            __extends(UserLogForm, _super);
            function UserLogForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!UserLogForm.init) {
                    UserLogForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(UserLogForm, [
                        'UserLogId', w0,
                        'UserId', w1,
                        'UserName', w0,
                        'Action', w0,
                        'ChangedOn', w2
                    ]);
                }
                return _this;
            }
            UserLogForm.formKey = 'Report.UserLog';
            return UserLogForm;
        }(Serenity.PrefixedContext));
        Report.UserLogForm = UserLogForm;
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
            UserLogRow.deletePermission = 'Report:UserLog:Read';
            UserLogRow.insertPermission = 'Report:UserLog:Read';
            UserLogRow.readPermission = 'Report:UserLog:Read';
            UserLogRow.updatePermission = 'Report:UserLog:Read';
        })(UserLogRow = Report.UserLogRow || (Report.UserLogRow = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLogService;
        (function (UserLogService) {
            UserLogService.baseUrl = 'Report/UserLog';
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
            });
        })(UserLogService = Report.UserLogService || (Report.UserLogService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Report;
    (function (Report) {
        var UserLoginDetailsForm = /** @class */ (function (_super) {
            __extends(UserLoginDetailsForm, _super);
            function UserLoginDetailsForm(prefix) {
                var _this = _super.call(this, prefix) || this;
                if (!UserLoginDetailsForm.init) {
                    UserLoginDetailsForm.init = true;
                    var s = Serenity;
                    var w0 = s.IntegerEditor;
                    var w1 = s.DateEditor;
                    Q.initFormType(UserLoginDetailsForm, [
                        'UserId', w0,
                        'LoginDatetime', w1,
                        'LogoutDatetime', w1,
                        'IsOnline', w0
                    ]);
                }
                return _this;
            }
            UserLoginDetailsForm.formKey = 'Report.UserLoginDetails';
            return UserLoginDetailsForm;
        }(Serenity.PrefixedContext));
        Report.UserLoginDetailsForm = UserLoginDetailsForm;
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
            UserLoginDetailsRow.deletePermission = '';
            UserLoginDetailsRow.insertPermission = '';
            UserLoginDetailsRow.readPermission = '';
            UserLoginDetailsRow.updatePermission = '';
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
            });
        })(UserLoginDetailsService = Report.UserLoginDetailsService || (Report.UserLoginDetailsService = {}));
    })(Report = CVC.Report || (CVC.Report = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Texts;
    (function (Texts) {
        CVC['Texts'] = Q.proxyTexts(Texts, '', { Db: { Administration: { AdminForm: { AdminFormId: 1, FormName: 1 }, Language: { Id: 1, LanguageId: 1, LanguageName: 1 }, ModuleAccess: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, IsAccess: 1, ModuleAccessId: 1, ModuleCreatedBy: 1, ModuleCreatedDate: 1, ModuleId: 1, ModuleMachineId: 1, ModuleModuleName: 1, ModuleStatusId: 1, ModuleUpdatedBy: 1, ModuleUpdatedDate: 1, RoleCreatedBy: 1, RoleCreatedDate: 1, RoleId: 1, RoleIsHidden: 1, RoleParentRoleId: 1, RoleRoleName: 1, RoleStatusId: 1, RoleUpdatedBy: 1, RoleUpdatedDate: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, Role: { CreatedBy: 1, CreatedDate: 1, IsHidden: 1, ParentRoleId: 1, RecordAddedSource: 1, RoleId: 1, RoleName: 1, RolesRoleName: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedDate: 1 }, RolePermission: { PermissionKey: 1, RoleId: 1, RolePermissionId: 1, RoleRoleName: 1 }, Translation: { CustomText: 1, EntityPlural: 1, Key: 1, OverrideConfirmation: 1, SaveChangesButton: 1, SourceLanguage: 1, SourceText: 1, TargetLanguage: 1, TargetText: 1 }, User: { Address: 1, BirthDate: 1, City: 1, CityCountry: 1, CityId: 1, CityState: 1, CreatedBy: 1, CreatedDate: 1, DepartmentId: 1, DepartmentName: 1, Designation: 1, Email: 1, EmployeeId: 1, FirstName: 1, IsActiveDirectory: 1, IsForgotPassword: 1, IsLockOut: 1, IsPasswordChangeOnLogin: 1, IsUserHidden: 1, LastName: 1, MobileCode: 1, MobileNumber: 1, MobileNumberString: 1, Password: 1, PasswordConfirm: 1, PasswordExpiryDate: 1, PasswordHash: 1, PasswordSalt: 1, PinCode: 1, QuestionAns: 1, QuestionId: 1, RecordAddedSource: 1, RoleId: 1, RolesRoleName: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedDate: 1, UserId: 1, UserImage: 1, Username: 1 }, UserPermission: { Granted: 1, PermissionKey: 1, User: 1, UserId: 1, UserPermissionId: 1, Username: 1 }, UserRole: { RoleId: 1, User: 1, UserId: 1, UserRoleId: 1, Username: 1 }, ViewFieldAccess: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, IsModify: 1, IsView: 1, RoleCreatedBy: 1, RoleCreatedDate: 1, RoleId: 1, RoleIsHidden: 1, RoleParentRoleId: 1, RoleRoleName: 1, RoleStatusId: 1, RoleUpdatedBy: 1, RoleUpdatedDate: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1, ViewFieldAccessId: 1, ViewFieldCreatedBy: 1, ViewFieldCreatedDate: 1, ViewFieldId: 1, ViewFieldStatusId: 1, ViewFieldUpdatedBy: 1, ViewFieldUpdatedDate: 1, ViewFieldViewFieldName: 1, ViewFieldViewsId: 1 }, ViewsAccess: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, IsModify: 1, IsView: 1, RoleCreatedBy: 1, RoleCreatedDate: 1, RoleId: 1, RoleIsHidden: 1, RoleParentRoleId: 1, RoleRoleName: 1, RoleStatusId: 1, RoleUpdatedBy: 1, RoleUpdatedDate: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1, ViewsAccessId: 1, ViewsCreatedBy: 1, ViewsCreatedDate: 1, ViewsId: 1, ViewsIsAccessFieldWise: 1, ViewsModuleId: 1, ViewsStatusId: 1, ViewsUpdatedBy: 1, ViewsUpdatedDate: 1, ViewsViewName: 1 } }, Batch: { Batch: { BatchEndDateTime: 1, BatchFor: 1, BatchForCreatedBy: 1, BatchForCreatedDate: 1, BatchForPickListId: 1, BatchForPickListValueName: 1, BatchForStatusId: 1, BatchForUpdatedBy: 1, BatchForUpdatedDate: 1, BatchId: 1, BatchLatestVersion: 1, BatchName: 1, BatchSize: 1, BatchStartDateTime: 1, BatchStatus: 1, BatchVersion: 1, Comments: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, ExpiryDate: 1, MachineLineId: 1, NumberOfBottles: 1, PackId: 1, ParentId: 1, ProductionSpeed: 1, RepackStatus: 1, StatusId: 1, TotalGoodBottles: 1, TotalRejectedBottles: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, BatchLog: { BatchId: 1, BatchLogId: 1, Description: 1, MachineId: 1, UpdatedDateTime: 1, UserId: 1 }, BatchMachineWise: { BatchBatchEndDateTime: 1, BatchBatchFor: 1, BatchBatchName: 1, BatchBatchSize: 1, BatchBatchStartDateTime: 1, BatchBatchStatus: 1, BatchCreatedBy: 1, BatchCreatedDate: 1, BatchExpiryDate: 1, BatchId: 1, BatchMachineId: 1, BatchMachineLineId: 1, BatchNumberOfBottles: 1, BatchPackId: 1, BatchProductionSpeed: 1, BatchStatusId: 1, BatchTotalGoodBottles: 1, BatchTotalRejectedBottles: 1, BatchUpdatedBy: 1, BatchUpdatedDate: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, IsMachineInUse: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, RecipeCreatedBy: 1, RecipeCreatedDate: 1, RecipeId: 1, RecipeMachineId: 1, RecipeRecipeName: 1, RecipeRecipeSettingsId: 1, RecipeStatusId: 1, RecipeUpdatedBy: 1, RecipeUpdatedDate: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, BatchRecipeModify: { BatchMachineBatchId: 1, BatchMachineCreatedBy: 1, BatchMachineCreatedDate: 1, BatchMachineId: 1, BatchMachineIsMachineInUse: 1, BatchMachineMachineId: 1, BatchMachineRecipeId: 1, BatchMachineStatusId: 1, BatchMachineUpdatedBy: 1, BatchMachineUpdatedDate: 1, BatchRecipeModifyId: 1, NewValue: 1, OldValue: 1, RecipeSettingsParameterCreatedBy: 1, RecipeSettingsParameterCreatedDate: 1, RecipeSettingsParameterId: 1, RecipeSettingsParameterIpcParameterId: 1, RecipeSettingsParameterIsFetchOnSelfSet: 1, RecipeSettingsParameterRecipeSettingsId: 1, RecipeSettingsParameterStatusId: 1, RecipeSettingsParameterUpdatedBy: 1, RecipeSettingsParameterUpdatedDate: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, BatchRunData: { BatchMachineWiseBatchId: 1, BatchMachineWiseCreatedBy: 1, BatchMachineWiseCreatedDate: 1, BatchMachineWiseId: 1, BatchMachineWiseIsMachineInUse: 1, BatchMachineWiseMachineId: 1, BatchMachineWiseRecipeId: 1, BatchMachineWiseStatusId: 1, BatchMachineWiseUpdatedBy: 1, BatchMachineWiseUpdatedDate: 1, BatchRunDataId: 1, IpcParameterCreatedBy: 1, IpcParameterCreatedDate: 1, IpcParameterId: 1, IpcParameterIpcAddress: 1, IpcParameterIpcParameterName: 1, IpcParameterIsChangeInRuntime: 1, IpcParameterMachineId: 1, IpcParameterMachineParameterId: 1, IpcParameterStatusId: 1, IpcParameterUpdatedBy: 1, IpcParameterUpdatedDate: 1, IpcParameterValue: 1, LoggedInUser: 1, LoggedInUserAddress: 1, LoggedInUserCityId: 1, LoggedInUserCreatedBy: 1, LoggedInUserCreatedDate: 1, LoggedInUserDepartmentId: 1, LoggedInUserDesignation: 1, LoggedInUserEmail: 1, LoggedInUserEmployeeId: 1, LoggedInUserFirstName: 1, LoggedInUserIsForgotPassword: 1, LoggedInUserIsPasswordChangeOnLogin: 1, LoggedInUserIsUserHidden: 1, LoggedInUserLastName: 1, LoggedInUserMobileCode: 1, LoggedInUserMobileNumber: 1, LoggedInUserPasswordExpiryDate: 1, LoggedInUserPasswordHash: 1, LoggedInUserPasswordSalt: 1, LoggedInUserPinCode: 1, LoggedInUserRoleId: 1, LoggedInUserStatusId: 1, LoggedInUserUpdatedBy: 1, LoggedInUserUpdatedDate: 1, LoggedInUserUserImage: 1, LoggedInUserUsername: 1, UpdatedDateTime: 1 }, LabelLost: { ActivityCreatedBy: 1, ActivityCreatedDate: 1, ActivityId: 1, ActivityPickListId: 1, ActivityPickListValueName: 1, ActivityStatusId: 1, ActivityText: 1, ActivityUpdatedBy: 1, ActivityUpdatedDate: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, LabelLostId: 1, LabelRecBatchId: 1, LabelRecCreatedBy: 1, LabelRecCreatedDate: 1, LabelRecId: 1, LabelRecLabelBalance: 1, LabelRecLabelLost: 1, LabelRecLabelRollId: 1, LabelRecMachineId: 1, LabelRecNoLabelOnRoll: 1, LabelRecRejectedLabels: 1, LabelRecStatusId: 1, LabelRecUpdatedBy: 1, LabelRecUpdatedDate: 1, NumberOfLabels: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, LabelReconciliation: { BatchBatchEndDateTime: 1, BatchBatchFor: 1, BatchBatchName: 1, BatchBatchSize: 1, BatchBatchStartDateTime: 1, BatchBatchStatus: 1, BatchCreatedBy: 1, BatchCreatedDate: 1, BatchExpiryDate: 1, BatchId: 1, BatchMachineLineId: 1, BatchNumberOfBottles: 1, BatchPackId: 1, BatchProductionSpeed: 1, BatchStatusId: 1, BatchTotalGoodBottles: 1, BatchTotalRejectedBottles: 1, BatchUpdatedBy: 1, BatchUpdatedDate: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, LabelBalance: 1, LabelLost: 1, LabelRecId: 1, LabelRollBatchId: 1, LabelRollCreatedBy: 1, LabelRollCreatedDate: 1, LabelRollId: 1, LabelRollLabelRollNumber: 1, LabelRollMachineId: 1, LabelRollNumberOfLabels: 1, LabelRollRemark: 1, LabelRollStatusId: 1, LabelRollUpdatedBy: 1, LabelRollUpdatedDate: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, NoLabelOnRoll: 1, RejectedLabels: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, LabelRoll: { BatchId: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, IsApplied: 1, LabelRemaining: 1, LabelRollId: 1, LabelRollNumber: 1, MachineId: 1, NumberOfLabels: 1, NumberOfLabelsUsed: 1, Remark: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 } }, Common: { UserPreference: { Name: 1, PreferenceType: 1, UserId: 1, UserPreferenceId: 1, Value: 1 } }, Configuration: { CityDetails: { City: 1, CityDetailsId: 1, Country: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, RecordAddedSource: 1, State: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, Company: { Address: 1, City: 1, CityCountry: 1, CityCreatedBy: 1, CityCreatedDate: 1, CityId: 1, CityState: 1, CityStatusId: 1, CityUpdatedBy: 1, CityUpdatedDate: 1, CompanyId: 1, CompanyLogo: 1, CompanyName: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByFullName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, PinCode: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByFullName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1, Website: 1 }, Currency: { CountryName: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByFullName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, CurrencyId: 1, CurrencyType: 1, Description: 1, StatusId: 1, StatusStatusName: 1, Symbol: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, DateFormatTypeLookUp: { DateFormatTypeID: 1, DateFormatTypeValue: 1 }, Department: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, DepartmentCode: 1, DepartmentId: 1, DepartmentName: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, EnvironmentVariables: { ArchivalPath: 1, BackupFolder: 1, BackupFrequencyNoOfDaya: 1, BackupTime: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, CurrencyId: 1, DatabaseLimit: 1, DateFormatTypeID: 1, DateFormatTypeValue: 1, DateTimeFormat: 1, EnvVariableId: 1, HourFormatTypeID: 1, HourFormatTypeValue: 1, IsOverWriteBackup: 1, IsPasswordChangeRequired: 1, IsUnLockAfterTime: 1, LanguageId: 1, LastPeriodRetained: 1, LicenseExpiryNotification: 1, LockInAttempt: 1, MinAlphaChars: 1, MinCapitalLetter: 1, MinNumericChars: 1, MinSpecialChars: 1, NumberFormat: 1, PasswordExpiryInDays: 1, PasswordExpiryNotification: 1, PasswordMaxLength: 1, PasswordMinLength: 1, PreviousPasswordLimit: 1, ReportLocation: 1, ScreenTimeOut: 1, SessionTimeOut: 1, TimeFormatTypeID: 1, TimeFormatValue: 1, TimeZoneId: 1, TimeZoneName: 1, UnLockTime: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, HourFormatTypeLookUp: { HourFormatTypeID: 1, HourFormatTypeValue: 1 }, PickList: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, PickListId: 1, PickListName: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, PickListValue: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, PickListId: 1, PickListName: 1, PickListValueId: 1, PickListValueName: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, PickListValueRoleAccess: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, PickListValueCreatedBy: 1, PickListValueCreatedDate: 1, PickListValueId: 1, PickListValuePickListId: 1, PickListValuePickListValueName: 1, PickListValueRoleAccessId: 1, PickListValueStatusId: 1, PickListValueUpdatedBy: 1, PickListValueUpdatedDate: 1, RoleCreatedBy: 1, RoleCreatedDate: 1, RoleId: 1, RoleIsHidden: 1, RoleParentRoleId: 1, RoleRoleName: 1, RoleStatusId: 1, RoleUpdatedBy: 1, RoleUpdatedDate: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, Shift: { CreatedBy: 1, CreatedDate: 1, EndTime: 1, RecordAddedSource: 1, ShiftId: 1, ShiftName: 1, StartTime: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedDate: 1 }, Status: { StatusId: 1, StatusName: 1 }, Status1: { AttributeId: 1, Name: 1 }, Supplier: { City: 1, CityCountry: 1, CityCreatedBy: 1, CityCreatedDate: 1, CityId: 1, CityState: 1, CityStatusId: 1, CityUpdatedBy: 1, CityUpdatedDate: 1, CreatedBy: 1, CreatedDate: 1, MobileCode: 1, MobileNumber: 1, PinCode: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, SupplierAddress: 1, SupplierId: 1, SupplierName: 1, UpdatedBy: 1, UpdatedDate: 1 }, TimeFormatTypeLookUp: { TimeFormatTypeID: 1, TimeFormatValue: 1 } }, ExternalApplicationInterface: { IpcParameter: { AttributeId: 1, Bit32Address: 1, BitWiseIndex: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, DisableParameterIdIPC: 1, DisableParameterValueIPC: 1, EndNumber: 1, HeartBeatFailedTime: 1, IncrementalNumber: 1, IndicatorParameterId: 1, IpcAddress: 1, IpcParameterId: 1, IpcParameterName: 1, Is32Bit: 1, IsAlarm: 1, IsBatchSize: 1, IsBatchStartRequiredIPC: 1, IsBitWise: 1, IsByteSwap: 1, IsChangeInRuntime: 1, IsConveyer: 1, IsCounterReset: 1, IsGoodBottles: 1, IsHeartBeat: 1, IsHeartBeatSend: 1, IsIndicatorParameter: 1, IsLabelRollIPC: 1, IsMachineSpeed: 1, IsMissingLabelCounter: 1, IsRefreshMachineSettings: 1, IsRejectBottles: 1, IsResetOnBatchCreateIPC: 1, IsShowAsMessageIPC: 1, IsStopATIPC: 1, IsStopOnBatchStopIPC: 1, IsWordSwap: 1, IsWriteToPLC: 1, MachineId: 1, MachineMachineName: 1, MachineParameterId: 1, MachineParameterName: 1, NodeId: 1, OperationTypeIPC: 1, OperationValueIPC: 1, ProtocolId: 1, RecordAddedSource: 1, StartNumber: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, MachineCommunication: { CpuTypeId: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, IpAddress: 1, IsConnected: 1, MDBPath: 1, MachineCommunicatonId: 1, MachineId: 1, MachineMachineName: 1, Password: 1, PollRate: 1, ProtocolName: 1, ProtocolTypeId: 1, Rack: 1, RecordAddedSource: 1, SecurityModeId: 1, SecurityPolicyId: 1, Slot: 1, StatusId: 1, StatusStatusName: 1, TcpipPort: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1, UserIdentityId: 1, UserName: 1 }, Protocol: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, ProtocolId: 1, ProtocolName: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 } }, MachineCustomization: { Alarm: { AlarmId: 1, AlarmName: 1, BitValue: 1, BitValueString: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByBirthDate: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, Description: 1, IsAlarmForCounter: 1, IsCheckAtMachineStart: 1, IsCheckAtMachineStartString: 1, IsCommentRequired: 1, IsCommentRequiredString: 1, IsCountForReject: 1, IsCountForRejectString: 1, IsHideEdit: 1, IsMachineRequiredToStop: 1, IsMachineRequiredToStopString: 1, IsRefreshMachineSettings: 1, IsResetRequired: 1, IsResetRequiredString: 1, MachineId: 1, MachineMachineName: 1, MachineParameterId: 1, MachineParameterMachineParameterName: 1, MachineStopMachineParameterId: 1, MachineStopMachineParameterMachineId: 1, MachineStopMachineParameterMachineParameterName: 1, Message: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByBirthDate: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, AlarmDisplay: { Activation: 1, AlarmDisplayId: 1, AlarmDisplayName: 1, Alignment: 1, Appearance: 1, BackgroundColor: 1, BorderStyle: 1, CautionColor: 1, EmergencyColor: 1, Font: 1, FontColorSelected: 1, FontColorUnselected: 1, IsAddAttachments: 1, IsCheckbox: 1, IsCollapsible: 1, IsFolderBrowse: 1, IsHorizontalScrollBar: 1, IsOpenInNewWindow: 1, IsTooltip: 1, IsVerticalScrollBar: 1, WarningColor: 1 }, AlarmResetId: { AlarmId: 1, AlarmResetRoleId: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, RoleId: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, AttachmentDisplay: { Activation: 1, Alignment: 1, AttachmentDisplayId: 1, AttachmentDisplayName: 1, BackgroundColor: 1, BorderStyle: 1, Font: 1, FontColorSelected: 1, FontColorUnselected: 1, IsAddAttachments: 1, IsCheckbox: 1, IsCollapsible: 1, IsFolderBrowse: 1, IsHorizontalScrollBar: 1, IsOpenInNewWindow: 1, IsTooltip: 1, IsVerticalScrollBar: 1 }, ButtonDisplay: { Activation: 1, Alignment: 1, BackgroundColor: 1, BorderStyle: 1, ButtonDisplayId: 1, ButtonDisplayName: 1, Font: 1, FontColorSelected: 1, FontColorUnselected: 1, IsCollapsible: 1, IsHorizontalScrollBar: 1, IsTooltip: 1, IsVerticalScrollBar: 1 }, ContainerDisplay: { Activation: 1, Alignment: 1, BackgroundColor: 1, BorderStyle: 1, ContainerDisplayId: 1, ContainerDisplayName: 1, Font: 1, FontColorSelected: 1, FontColorUnselected: 1, IsCollapsible: 1, IsHorizontalScrollBar: 1, IsOpenInNewWindow: 1, IsTooltip: 1, IsVerticalScrollBar: 1 }, DataType: { Bit: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, DataTypeId: 1, DataTypeName: 1, IsSigned: 1, StatusId: 1, StatusStatusName: 1, TypeId: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, DisplayObject: { AlarmDisplayId: 1, AlarmDisplayName: 1, AttachmentDisplayId: 1, AttachmentDisplayName: 1, ButtonDisplayId: 1, ButtonDisplayName: 1, ContainerDisplayId: 1, ContainerDisplayName: 1, CreatedBy: 1, CreatedByUsername: 1, CreatedDate: 1, DisplayObjectStyle: 1, DisplayObjectTypeId: 1, FormDisplayId: 1, FormDisplayName: 1, IsAccessFieldWise: 1, IsCommandPanel: 1, IsFactorySetting: 1, IsMachineSettings: 1, IsMachineSummary: 1, IslabelRoll: 1, LineChartDisplayId: 1, LineChartDisplayName: 1, ListDisplayId: 1, ListDisplayName: 1, MachineId: 1, MachineMachineName: 1, ModuleId: 1, NotificationDisplayId: 1, NotificationDisplayName: 1, PieChartDisplayId: 1, PieChartDisplayName: 1, RealtimeParameterDisplayId: 1, RealtimeParameterDisplayName: 1, StatusId: 1, StatusStatusName: 1, TreeDisplayId: 1, TreeDisplayName: 1, UpdatedBy: 1, UpdatedByUsername: 1, UpdatedDate: 1, ViewName: 1, ViewsId: 1 }, DisplayObjectField: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByBirthDate: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsActiveDirectory: 1, CreatedByIsForgotPassword: 1, CreatedByIsLockOut: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByLockOutDateTime: 1, CreatedByLogInAttempt: 1, CreatedByMachineId: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByQuestionAns: 1, CreatedByQuestionId: 1, CreatedByRecordAddedSource: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, IsAuthenticationRequired: 1, IsCommentRequired: 1, IsPopUpRequired: 1, IsSelectAllRoles: 1, MachineName: 1, MachineParameterAllowDecimalPoint: 1, MachineParameterBit32RowId: 1, MachineParameterBitWiseIndex: 1, MachineParameterColumnName: 1, MachineParameterCreatedBy: 1, MachineParameterCreatedDate: 1, MachineParameterDataTypeId: 1, MachineParameterDescription: 1, MachineParameterDisableParameterId: 1, MachineParameterDisableParameterValue: 1, MachineParameterId: 1, MachineParameterIs32Bit: 1, MachineParameterIsBatchStartRequired: 1, MachineParameterIsBitWise: 1, MachineParameterIsLabelRoll: 1, MachineParameterIsRangeUnlimited: 1, MachineParameterIsRead: 1, MachineParameterIsResetOnBatchCreate: 1, MachineParameterIsShowAsMessage: 1, MachineParameterIsStopAt: 1, MachineParameterIsStopOnBatchStop: 1, MachineParameterIsUseUnit: 1, MachineParameterIsWrite: 1, MachineParameterMachineId: 1, MachineParameterMax: 1, MachineParameterMin: 1, MachineParameterOperationType: 1, MachineParameterOperationValue: 1, MachineParameterParameterName: 1, MachineParameterPickListId: 1, MachineParameterPlcAddress: 1, MachineParameterQueryTypeRowId: 1, MachineParameterReadMachineParameterId: 1, MachineParameterRecordAddedSource: 1, MachineParameterReloadMachineParameterId: 1, MachineParameterRowId: 1, MachineParameterStatusId: 1, MachineParameterType: 1, MachineParameterUnitId: 1, MachineParameterUpdatedBy: 1, MachineParameterUpdatedDate: 1, ModuleCreatedBy: 1, ModuleCreatedDate: 1, ModuleEquipmentId: 1, ModuleId: 1, ModuleMachineId: 1, ModuleModuleName: 1, ModuleSequence: 1, ModuleSerialNumber: 1, ModuleStatusId: 1, ModuleUpdatedBy: 1, ModuleUpdatedDate: 1, Roles: 1, Sequence: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByBirthDate: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsActiveDirectory: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsLockOut: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByLockOutDateTime: 1, UpdatedByLogInAttempt: 1, UpdatedByMachineId: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByQuestionAns: 1, UpdatedByQuestionId: 1, UpdatedByRecordAddedSource: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1, ViewField: 1, ViewFieldName: 1, ViewsAlarmDisplayId: 1, ViewsAttachmentDisplayId: 1, ViewsButtonDisplayId: 1, ViewsContainerDisplayId: 1, ViewsCreatedBy: 1, ViewsCreatedDate: 1, ViewsDisplayObjectTypeId: 1, ViewsFormDisplayId: 1, ViewsId: 1, ViewsIsAccessFieldWise: 1, ViewsIsCommandPanel: 1, ViewsIsFactorySetting: 1, ViewsIsMachineSettings: 1, ViewsIsMachineSummary: 1, ViewsIslabelRoll: 1, ViewsLineChartDisplayId: 1, ViewsListDisplayId: 1, ViewsMachineId: 1, ViewsModuleId: 1, ViewsNotificationDisplayId: 1, ViewsPieChartDisplayId: 1, ViewsRealtimeParameterDisplayId: 1, ViewsStatusId: 1, ViewsTreeDisplayId: 1, ViewsUpdatedBy: 1, ViewsUpdatedDate: 1, ViewsViewName: 1 }, FormDisplay: { Activation: 1, Alignment: 1, BackgroundColor: 1, BorderStyle: 1, Font: 1, FontColorSelected: 1, FontColorUnselected: 1, FormDisplayId: 1, FormDisplayName: 1, IsCheckbox: 1, IsCollapsible: 1, IsHorizontalScrollBar: 1, IsTooltip: 1, IsVerticalScrollBar: 1 }, LineChartDisplay: { Alignment: 1, AxisColor: 1, BackgroundColor: 1, BorderStyle: 1, Font: 1, FontColor: 1, GridlineColor: 1, IsCollapsible: 1, IsGridlines: 1, IsHorizontalScrollBar: 1, IsLegends: 1, IsRealtime: 1, IsTooltip: 1, IsVerticalScrollBar: 1, LineChartDisplayId: 1, LineChartDisplayName: 1 }, LineMaintenanceSchedule: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, Description: 1, EndDateTime: 1, LineMainSchId: 1, MachineLineId: 1, Remark: 1, StartDateTime: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, ListDisplay: { Activation: 1, Alignment: 1, AutoResize: 1, BackgroundColor: 1, BorderStyle: 1, Checkbox: 1, Collapsible: 1, Font: 1, FontColor: 1, FontSize: 1, FullRowSelect: 1, Gridlines: 1, ListDisplayId: 1, ListDisplayName: 1, MultiSelect: 1, SortAscDesc: 1, SortingType: 1, UseWaitCursorOnClick: 1 }, Machine: { AccessIpAddress: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, Description: 1, IsRealTime: 1, MachineId: 1, MachineImage: 1, MachineLineId: 1, MachineName: 1, MachineSequence: 1, Make: 1, ModelNumber: 1, PlcAddress: 1, PlcMake: 1, PlcModelNumber: 1, PlcSerialNumber: 1, RecordAddedSource: 1, SerialNumber: 1, StatusId: 1, StatusStatusName: 1, TableId: 1, TableName: 1, TimerForAlarm: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1, Year: 1 }, MachineHelpFile: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, FileContent: 1, FileExtension: 1, FileLength: 1, FileName: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineHelpFileId: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, MachineHistory: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, IssueCloseDate: 1, IssueStartDate: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineHistoryId: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, ProblemDescription: 1, ProblemNatureCreatedBy: 1, ProblemNatureCreatedDate: 1, ProblemNatureId: 1, ProblemNaturePickListId: 1, ProblemNaturePickListValueName: 1, ProblemNatureStatusId: 1, ProblemNatureUpdatedBy: 1, ProblemNatureUpdatedDate: 1, SparePartCreatedBy: 1, SparePartCreatedDate: 1, SparePartId: 1, SparePartMachineId: 1, SparePartNoOfUnitsRequired: 1, SparePartPartDescription: 1, SparePartPartImage: 1, SparePartPartName: 1, SparePartPartNumber: 1, SparePartStatusId: 1, SparePartUpdatedBy: 1, SparePartUpdatedDate: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, MachineLine: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, InstalledDate: 1, LineName: 1, LineRatedSpeed: 1, MachineLineId: 1, NumberOfMachines: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, MachineLineUser: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, MachineLineId: 1, MachineLineUserId: 1, ShiftId: 1, StatusId: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1, UserId: 1 }, MachineMaintenanceSchedule: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, Description: 1, EndDateTime: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMainSchId: 1, MachineMake: 1, MachineModelNumber: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, StartDateTime: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, MachineParameter: { AllowDecimalPoint: 1, Bit32RowId: 1, BitWiseIndex: 1, ColumnName: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, DataTypeId: 1, DataTypeName: 1, Description: 1, DisableParameterId: 1, DisableParameterValue: 1, Is32Bit: 1, IsBatchStartRequired: 1, IsBitWise: 1, IsLabelRoll: 1, IsRangeUnlimited: 1, IsRead: 1, IsRealTime: 1, IsResetOnBatchCreate: 1, IsShowAsMessage: 1, IsStopAt: 1, IsStopOnBatchStop: 1, IsUseUnit: 1, IsWrite: 1, MachineId: 1, MachineMachineName: 1, MachineParameterId: 1, Max: 1, Min: 1, OperationType: 1, OperationValue: 1, ParameterName: 1, PickListId: 1, PickListName: 1, PlcAddress: 1, QueryTypeRowId: 1, ReadMachineParameterId: 1, RecordAddedSource: 1, ReloadMachineParameterId: 1, RowId: 1, StatusId: 1, StatusStatusName: 1, Type: 1, UnitId: 1, UnitPickListValueName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, MachineRecipe: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByBirthDate: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, Description: 1, IsDefaultRecipe: 1, MachineId: 1, MachineMachineName: 1, MachineRecipeId: 1, PackId: 1, RecipeName: 1, RecipeSettingsId: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByBirthDate: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, MachineRecipeParameter: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByBirthDate: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, MachineParameterId: 1, MachineParameterName: 1, MachineParameterValue: 1, MachineRecipeId: 1, MachineRecipeName: 1, MachineRecipeParameterId: 1, RecipeParameterValue: 1, RecipeSettingsParameterCreatedBy: 1, RecipeSettingsParameterCreatedDate: 1, RecipeSettingsParameterId: 1, RecipeSettingsParameterIsFetchOnSelfSet: 1, RecipeSettingsParameterRecipeSettingsId: 1, RecipeSettingsParameterStatusId: 1, RecipeSettingsParameterUpdatedBy: 1, RecipeSettingsParameterUpdatedDate: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByBirthDate: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, MachineSparePart: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineSparePartId: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, NoOfUnitsRequired: 1, PartDescription: 1, PartImage: 1, PartName: 1, PartNumber: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, MachineSpecification: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, Description: 1, Details: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineId: 1, MachineImage: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineSpecId: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, MachineUser: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, MachineId: 1, MachineUserId: 1, ShiftCreatedBy: 1, ShiftCreatedDate: 1, ShiftEndTime: 1, ShiftId: 1, ShiftShiftName: 1, ShiftStartTime: 1, ShiftStatusId: 1, ShiftUpdatedBy: 1, ShiftUpdatedDate: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1, UserAddress: 1, UserCityId: 1, UserCreatedBy: 1, UserCreatedDate: 1, UserDepartmentId: 1, UserDesignation: 1, UserEmail: 1, UserEmployeeId: 1, UserFirstName: 1, UserId: 1, UserIsForgotPassword: 1, UserIsPasswordChangeOnLogin: 1, UserIsUserHidden: 1, UserLastName: 1, UserMobileCode: 1, UserMobileNumber: 1, UserPasswordExpiryDate: 1, UserPasswordHash: 1, UserPasswordSalt: 1, UserPinCode: 1, UserRoleId: 1, UserStatusId: 1, UserUpdatedBy: 1, UserUpdatedDate: 1, UserUserImage: 1, UserUsername: 1 }, MachineVideo: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, FileContent: 1, FileExtension: 1, FileLength: 1, FileName: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineVideoId: 1, MachineYear: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, NotificationDisplay: { Activation: 1, Alignment: 1, BackgroundColor: 1, BorderStyle: 1, Font: 1, FontColorSelected: 1, FontColorUnselected: 1, IsAddAttachments: 1, IsCollapsible: 1, IsFolderBrowse: 1, IsHorizontalScrollBar: 1, IsOpenInNewWindow: 1, IsTooltip: 1, IsVerticalScrollBar: 1, NotificationDisplayId: 1, NotificationDisplayName: 1 }, PieChartDisplay: { Alignment: 1, BackgroundColor: 1, BorderStyle: 1, Font: 1, FontColor: 1, IsHorizontalScrollBar: 1, IsLegends: 1, IsRealtime: 1, IsShowTotal: 1, IsShowValuesAsPercentage: 1, IsTooltip: 1, IsVerticalScrollBar: 1, LegendFontSize: 1, PieChartDisplayId: 1, PieChartDisplayName: 1 }, PrimaryRelationship: { CreatedBy: 1, CreatedDate: 1, Description: 1, PrimaryBe: 1, PrimaryBeAccessIpAddress: 1, PrimaryBeCreatedBy: 1, PrimaryBeCreatedDate: 1, PrimaryBeDescription: 1, PrimaryBeEquipmentId: 1, PrimaryBeIsRealTime: 1, PrimaryBeIsShowStatistics: 1, PrimaryBeIsactive: 1, PrimaryBeMachineImage: 1, PrimaryBeMachineLineId: 1, PrimaryBeMachineName: 1, PrimaryBeMachineSequence: 1, PrimaryBeMachineTypeId: 1, PrimaryBeMake: 1, PrimaryBeModelNumber: 1, PrimaryBePlcAddress: 1, PrimaryBePlcMake: 1, PrimaryBePlcModelNumber: 1, PrimaryBePlcSerialNumber: 1, PrimaryBeRecordAddedSource: 1, PrimaryBeSerialNumber: 1, PrimaryBeStatusId: 1, PrimaryBeTableId: 1, PrimaryBeTableName: 1, PrimaryBeTimerForAlarm: 1, PrimaryBeUpdatedBy: 1, PrimaryBeUpdatedDate: 1, PrimaryBeYear: 1, PrimaryEf: 1, PrimaryEfParameterName: 1, PrimaryRelationshipId: 1, RelationshipName: 1, Status: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedDate: 1 }, RealtimeParameterDisplay: { Alignment: 1, BackgroundColor: 1, BorderStyle: 1, Font: 1, FontColor: 1, IsCollapsible: 1, IsHorizontalScrollBar: 1, IsTooltip: 1, IsVerticalScrollBar: 1, RealtimeParameterDisplayId: 1, RealtimeParameterDisplayName: 1 }, RecipeSettings: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, RecipeSettingsId: 1, RecipeSettingsName: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, RecipeSettingsParameter: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, IpcParameterCreatedBy: 1, IpcParameterCreatedDate: 1, IpcParameterId: 1, IpcParameterIpcAddress: 1, IpcParameterIpcParameterName: 1, IpcParameterIsChangeInRuntime: 1, IpcParameterMachineId: 1, IpcParameterMachineParameterId: 1, IpcParameterStatusId: 1, IpcParameterUpdatedBy: 1, IpcParameterUpdatedDate: 1, IsFetchOnSelfSet: 1, RecipeParameterId: 1, RecipeSettingsCreatedBy: 1, RecipeSettingsCreatedDate: 1, RecipeSettingsId: 1, RecipeSettingsMachineId: 1, RecipeSettingsRecipeSettingsName: 1, RecipeSettingsStatusId: 1, RecipeSettingsUpdatedBy: 1, RecipeSettingsUpdatedDate: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, SaveRecipe: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByBirthDate: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, Description: 1, IsDefaultRecipe: 1, MachineId: 1, MachineMachineName: 1, MachineRecipeId: 1, PackId: 1, RecipeName: 1, RecipeSettingsId: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByBirthDate: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, ScreenViews: { CreatedBy: 1, CreatedByUsername: 1, CreatedDate: 1, IsNoBer: 1, PrimaryRelationshipCreatedBy: 1, PrimaryRelationshipCreatedDate: 1, PrimaryRelationshipDescription: 1, PrimaryRelationshipId: 1, PrimaryRelationshipPrimaryBe: 1, PrimaryRelationshipPrimaryEf: 1, PrimaryRelationshipRelationshipName: 1, PrimaryRelationshipStatus: 1, PrimaryRelationshipUpdatedBy: 1, PrimaryRelationshipUpdatedDate: 1, ScreenViewId: 1, ScreenViewName: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, SecondaryRelationship: { CreatedBy: 1, CreatedDate: 1, Description: 1, PrimaryBeMachineName: 1, PrimaryEfParameterName: 1, PrimaryRelationshipCreatedBy: 1, PrimaryRelationshipCreatedDate: 1, PrimaryRelationshipDescription: 1, PrimaryRelationshipId: 1, PrimaryRelationshipPrimaryBe: 1, PrimaryRelationshipPrimaryEf: 1, PrimaryRelationshipRelationshipName: 1, PrimaryRelationshipStatus: 1, PrimaryRelationshipUpdatedBy: 1, PrimaryRelationshipUpdatedDate: 1, SecondaryBe: 1, SecondaryBeAccessIpAddress: 1, SecondaryBeCreatedBy: 1, SecondaryBeCreatedDate: 1, SecondaryBeDescription: 1, SecondaryBeEquipmentId: 1, SecondaryBeIsRealTime: 1, SecondaryBeIsShowStatistics: 1, SecondaryBeIsactive: 1, SecondaryBeMachineImage: 1, SecondaryBeMachineLineId: 1, SecondaryBeMachineName: 1, SecondaryBeMachineSequence: 1, SecondaryBeMachineTypeId: 1, SecondaryBeMake: 1, SecondaryBeModelNumber: 1, SecondaryBePlcAddress: 1, SecondaryBePlcMake: 1, SecondaryBePlcModelNumber: 1, SecondaryBePlcSerialNumber: 1, SecondaryBeRecordAddedSource: 1, SecondaryBeSerialNumber: 1, SecondaryBeStatusId: 1, SecondaryBeTableId: 1, SecondaryBeTableName: 1, SecondaryBeTimerForAlarm: 1, SecondaryBeUpdatedBy: 1, SecondaryBeUpdatedDate: 1, SecondaryBeYear: 1, SecondaryEf: 1, SecondaryEfParameterName: 1, SecondaryRelationshipId: 1, UpdatedBy: 1, UpdatedDate: 1 }, TreeDisplay: { Alignment: 1, BackgroundColor: 1, BorderStyle: 1, DefaultView: 1, Font: 1, FontColor: 1, IsFullRowSelect: 1, IsHorizontalScrollBar: 1, IsRealtime: 1, IsTooltip: 1, IsVerticalScrollBar: 1, LineColor: 1, TreeDisplayId: 1, TreeDisplayName: 1 } }, ModuleManagement: { Module: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, EquipmentId: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, ModuleId: 1, ModuleName: 1, Sequence: 1, SerialNumber: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, ViewField: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByBirthDate: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, MachineParameterId: 1, MachineParameterMachineParameterName: 1, Sequence: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByBirthDate: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1, ViewField: 1, ViewFieldName: 1, ViewsCreatedBy: 1, ViewsCreatedDate: 1, ViewsId: 1, ViewsIsAccessFieldWise: 1, ViewsModuleId: 1, ViewsStatusId: 1, ViewsUpdatedBy: 1, ViewsUpdatedDate: 1, ViewsViewName: 1 }, Views: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, IsAccessFieldWise: 1, IsCommandPanel: 1, IsMachineSettings: 1, IsMachineSummary: 1, IslabelRoll: 1, ModuleCreatedBy: 1, ModuleCreatedDate: 1, ModuleId: 1, ModuleMachineId: 1, ModuleModuleName: 1, ModuleStatusId: 1, ModuleUpdatedBy: 1, ModuleUpdatedDate: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1, ViewName: 1, ViewsId: 1 } }, PackSettings: { Bottle: { BottleCc: 1, BottleDiameter: 1, BottleHeight: 1, BottleId: 1, BottleMouthOpeningId: 1, BottleMouthOpeningOd: 1, BottleName: 1, ContainerTypeCreatedBy: 1, ContainerTypeCreatedDate: 1, ContainerTypeId: 1, ContainerTypePickListId: 1, ContainerTypePickListValueName: 1, ContainerTypeStatusId: 1, ContainerTypeUpdatedBy: 1, ContainerTypeUpdatedDate: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, SupplierCityId: 1, SupplierCreatedBy: 1, SupplierCreatedDate: 1, SupplierId: 1, SupplierMobileCode: 1, SupplierMobileNumber: 1, SupplierPinCode: 1, SupplierStatusId: 1, SupplierSupplierAddress: 1, SupplierSupplierName: 1, SupplierUpdatedBy: 1, SupplierUpdatedDate: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, Cap: { CapCc: 1, CapDiameter: 1, CapHeight: 1, CapId: 1, CapName: 1, CapTypeCreatedBy: 1, CapTypeCreatedDate: 1, CapTypeId: 1, CapTypePickListId: 1, CapTypePickListValueName: 1, CapTypeStatusId: 1, CapTypeUpdatedBy: 1, CapTypeUpdatedDate: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, SupplierCityId: 1, SupplierCreatedBy: 1, SupplierCreatedDate: 1, SupplierId: 1, SupplierMobileCode: 1, SupplierMobileNumber: 1, SupplierPinCode: 1, SupplierStatusId: 1, SupplierSupplierAddress: 1, SupplierSupplierName: 1, SupplierUpdatedBy: 1, SupplierUpdatedDate: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, Cotton: { CottonId: 1, CottonName: 1, CottonStatusName: 1, CottonTypeCreatedBy: 1, CottonTypeCreatedDate: 1, CottonTypeId: 1, CottonTypePickListId: 1, CottonTypePickListValueName: 1, CottonTypeStatusId: 1, CottonTypeUpdatedBy: 1, CottonTypeUpdatedDate: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, GmOrYard: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, SupplierCityId: 1, SupplierCreatedBy: 1, SupplierCreatedDate: 1, SupplierId: 1, SupplierMobileCode: 1, SupplierMobileNumber: 1, SupplierPinCode: 1, SupplierStatusId: 1, SupplierSupplierAddress: 1, SupplierSupplierName: 1, SupplierUpdatedBy: 1, SupplierUpdatedDate: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, Desiccant: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, DesiccantId: 1, DesiccantName: 1, DesiccantTypeId: 1, DesiccantTypePickListValueName: 1, DesiccantTypeStatusId: 1, DiameterOrWidth: 1, Grammage: 1, Identification: 1, IdentificationPickListValueName: 1, IdentificationStatusId: 1, LengthOrHeight: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, SupplierCityId: 1, SupplierCreatedBy: 1, SupplierCreatedDate: 1, SupplierId: 1, SupplierMobileCode: 1, SupplierMobileNumber: 1, SupplierPinCode: 1, SupplierStatusId: 1, SupplierSupplierAddress: 1, SupplierSupplierName: 1, SupplierUpdatedBy: 1, SupplierUpdatedDate: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, EndOfLine: { BottleConfiguration: 1, CartonHeight: 1, CartonLength: 1, CartonType: 1, CartonWidth: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, EndOfLineId: 1, EndOfLineName: 1, InnerShipperBoxHeight: 1, InnerShipperBoxLength: 1, InnerShipperBoxType: 1, InnerShipperBoxWidth: 1, InnerShipperMatrix: 1, MedicationLength: 1, MedicationWidth: 1, NoOfMedication: 1, OuterShipperBoxHeight: 1, OuterShipperBoxLength: 1, OuterShipperBoxWidth: 1, OuterShipperQuantity: 1, StatusId: 1, StatusStatusName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, Label: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, LabelHeight: 1, LabelId: 1, LabelImage: 1, LabelLength: 1, LabelName: 1, LabelType: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, SupplierCityId: 1, SupplierCreatedBy: 1, SupplierCreatedDate: 1, SupplierId: 1, SupplierMobileCode: 1, SupplierMobileNumber: 1, SupplierPinCode: 1, SupplierStatusId: 1, SupplierSupplierAddress: 1, SupplierSupplierName: 1, SupplierUpdatedBy: 1, SupplierUpdatedDate: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, Outsert: { CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, OutsertId: 1, OutsertLength: 1, OutsertName: 1, OutsertThickness: 1, OutsertWidth: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, SupplierCityId: 1, SupplierCreatedBy: 1, SupplierCreatedDate: 1, SupplierId: 1, SupplierMobileCode: 1, SupplierMobileNumber: 1, SupplierPinCode: 1, SupplierStatusId: 1, SupplierSupplierAddress: 1, SupplierSupplierName: 1, SupplierUpdatedBy: 1, SupplierUpdatedDate: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, Pack: { BottleId: 1, BottleName: 1, CapId: 1, CapName: 1, CottonId: 1, CottonLength: 1, CottonName: 1, CreatedBy: 1, CreatedBy1: 1, CreatedByAddress: 1, CreatedByCityId: 1, CreatedByCreatedDate: 1, CreatedByDepartmentId: 1, CreatedByDesignation: 1, CreatedByEmail: 1, CreatedByEmployeeId: 1, CreatedByFirstName: 1, CreatedByIsForgotPassword: 1, CreatedByIsPasswordChangeOnLogin: 1, CreatedByIsUserHidden: 1, CreatedByLastName: 1, CreatedByMobileCode: 1, CreatedByMobileNumber: 1, CreatedByPasswordExpiryDate: 1, CreatedByPasswordHash: 1, CreatedByPasswordSalt: 1, CreatedByPinCode: 1, CreatedByRoleId: 1, CreatedByStatusId: 1, CreatedByUpdatedBy: 1, CreatedByUpdatedDate: 1, CreatedByUserImage: 1, CreatedByUsername: 1, CreatedDate: 1, DesiccantId: 1, DesiccantName: 1, EndOfLineBottleConfiguration: 1, EndOfLineCartonHeight: 1, EndOfLineCartonLength: 1, EndOfLineCartonType: 1, EndOfLineCartonWidth: 1, EndOfLineCreatedBy: 1, EndOfLineCreatedDate: 1, EndOfLineEndOfLineName: 1, EndOfLineId: 1, EndOfLineInnerShipperBoxHeight: 1, EndOfLineInnerShipperBoxLength: 1, EndOfLineInnerShipperBoxType: 1, EndOfLineInnerShipperBoxWidth: 1, EndOfLineInnerShipperMatrix: 1, EndOfLineMedicationLength: 1, EndOfLineMedicationWidth: 1, EndOfLineNoOfMedication: 1, EndOfLineOuterShipperBoxHeight: 1, EndOfLineOuterShipperBoxLength: 1, EndOfLineOuterShipperBoxWidth: 1, EndOfLineOuterShipperQuantity: 1, EndOfLineStatusId: 1, EndOfLineUpdatedBy: 1, EndOfLineUpdatedDate: 1, LabelCreatedBy: 1, LabelCreatedDate: 1, LabelId: 1, LabelLabelHeight: 1, LabelLabelImage: 1, LabelLabelLength: 1, LabelLabelName: 1, LabelLabelType: 1, LabelStatusId: 1, LabelSupplierId: 1, LabelUpdatedBy: 1, LabelUpdatedDate: 1, NumberOfCottonPieces: 1, NumberOfDesicantPieces: 1, OutsertId: 1, OutsertName: 1, PackId: 1, PackName: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, TabletCount: 1, TabletId: 1, TabletName: 1, UpdatedBy: 1, UpdatedBy1: 1, UpdatedByAddress: 1, UpdatedByCityId: 1, UpdatedByCreatedBy: 1, UpdatedByCreatedDate: 1, UpdatedByDepartmentId: 1, UpdatedByDesignation: 1, UpdatedByEmail: 1, UpdatedByEmployeeId: 1, UpdatedByFirstName: 1, UpdatedByIsForgotPassword: 1, UpdatedByIsPasswordChangeOnLogin: 1, UpdatedByIsUserHidden: 1, UpdatedByLastName: 1, UpdatedByMobileCode: 1, UpdatedByMobileNumber: 1, UpdatedByPasswordExpiryDate: 1, UpdatedByPasswordHash: 1, UpdatedByPasswordSalt: 1, UpdatedByPinCode: 1, UpdatedByRoleId: 1, UpdatedByStatusId: 1, UpdatedByUpdatedDate: 1, UpdatedByUserImage: 1, UpdatedByUsername: 1, UpdatedDate: 1 }, TabletDetails: { CreatedBy: 1, CreatedDate: 1, RecordAddedSource: 1, StatusId: 1, StatusStatusName: 1, TabletCharOneId: 1, TabletCharOnePickListValueName: 1, TabletCharOneStatusId: 1, TabletCharTwoId: 1, TabletCharTwoPickListValueName: 1, TabletCharTwoStatusId: 1, TabletDetailsId: 1, TabletLength: 1, TabletName: 1, TabletShapeId: 1, TabletShapePickListValueName: 1, TabletShapeStatusId: 1, TabletStrength: 1, TabletThickness: 1, TabletTypeId: 1, TabletTypePickListValueName: 1, TabletTypeStatusId: 1, TabletWidth: 1, UpdatedBy: 1, UpdatedDate: 1 } }, Report: { AlarmLog: { AlarmAlarmName: 1, AlarmDateTime: 1, AlarmId: 1, AlarmLogId: 1, BatchBatchName: 1, BatchId: 1, Comment: 1, Description: 1, LoggedUserId: 1, MachineId: 1, MachineMachineName: 1, PcipAddress: 1 }, AlarmLogArchive: { AlarmAlarmName: 1, AlarmDateTime: 1, AlarmId: 1, AlarmLogArchiveId: 1, BatchBatchName: 1, BatchId: 1, Comment: 1, Description: 1, LoggedUserId: 1, MachineId: 1, MachineMachineName: 1, PcipAddress: 1 }, AuditLog: { Action: 1, AuditLogId: 1, BatchBatchEndDateTime: 1, BatchBatchFor: 1, BatchBatchName: 1, BatchBatchSize: 1, BatchBatchStartDateTime: 1, BatchBatchStatus: 1, BatchCreatedBy: 1, BatchCreatedDate: 1, BatchExpiryDate: 1, BatchId: 1, BatchMachineLineId: 1, BatchName: 1, BatchNumberOfBottles: 1, BatchPackId: 1, BatchProductionSpeed: 1, BatchStatusId: 1, BatchTotalGoodBottles: 1, BatchTotalRejectedBottles: 1, BatchUpdatedBy: 1, BatchUpdatedDate: 1, ChangedOn: 1, Comments: 1, FieldName: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachineName: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, Module: 1, NewValue: 1, OldValue: 1, Page: 1, PcipAddress: 1, RowId: 1, TableName: 1, UserAddress: 1, UserCityId: 1, UserCreatedBy: 1, UserCreatedDate: 1, UserDepartmentId: 1, UserDesignation: 1, UserEmail: 1, UserEmployeeId: 1, UserFirstName: 1, UserId: 1, UserIsForgotPassword: 1, UserIsPasswordChangeOnLogin: 1, UserIsUserHidden: 1, UserLastName: 1, UserMobileCode: 1, UserMobileNumber: 1, UserName: 1, UserPasswordExpiryDate: 1, UserPasswordHash: 1, UserPasswordSalt: 1, UserPinCode: 1, UserRoleId: 1, UserStatusId: 1, UserUpdatedBy: 1, UserUpdatedDate: 1, UserUserImage: 1, UserUsername: 1 }, AuditLogArchive: { Action: 1, AuditLogArchiveId: 1, BatchBatchEndDateTime: 1, BatchBatchFor: 1, BatchBatchName: 1, BatchBatchSize: 1, BatchBatchStartDateTime: 1, BatchBatchStatus: 1, BatchCreatedBy: 1, BatchCreatedDate: 1, BatchExpiryDate: 1, BatchId: 1, BatchMachineLineId: 1, BatchName: 1, BatchNumberOfBottles: 1, BatchPackId: 1, BatchProductionSpeed: 1, BatchStatusId: 1, BatchTotalGoodBottles: 1, BatchTotalRejectedBottles: 1, BatchUpdatedBy: 1, BatchUpdatedDate: 1, ChangedOn: 1, Comments: 1, FieldName: 1, MachineAccessIpAddress: 1, MachineCreatedBy: 1, MachineCreatedDate: 1, MachineDescription: 1, MachineId: 1, MachineMachineImage: 1, MachineMachineLineId: 1, MachineMachineName: 1, MachineMachineSequence: 1, MachineMake: 1, MachineModelNumber: 1, MachineName: 1, MachinePlcAddress: 1, MachinePlcMake: 1, MachinePlcModelNumber: 1, MachinePlcSerialNumber: 1, MachineSerialNumber: 1, MachineStatusId: 1, MachineUpdatedBy: 1, MachineUpdatedDate: 1, MachineYear: 1, Module: 1, NewValue: 1, OldValue: 1, Page: 1, PcipAddress: 1, RowId: 1, TableName: 1, UserAddress: 1, UserCityId: 1, UserCreatedBy: 1, UserCreatedDate: 1, UserDepartmentId: 1, UserDesignation: 1, UserEmail: 1, UserEmployeeId: 1, UserFirstName: 1, UserId: 1, UserIsForgotPassword: 1, UserIsPasswordChangeOnLogin: 1, UserIsUserHidden: 1, UserLastName: 1, UserMobileCode: 1, UserMobileNumber: 1, UserName: 1, UserPasswordExpiryDate: 1, UserPasswordHash: 1, UserPasswordSalt: 1, UserPinCode: 1, UserRoleId: 1, UserStatusId: 1, UserUpdatedBy: 1, UserUpdatedDate: 1, UserUserImage: 1, UserUsername: 1 }, BatchLog: { BatchId: 1, BatchLogId: 1, Description: 1, MachineId: 1, UpdatedDateTime: 1, UserId: 1 }, BatchLogArchive: { BatchId: 1, BatchLogArchiveId: 1, Description: 1, MachineId: 1, UpdatedDateTime: 1, UserId: 1 }, ExceptionLog: { ApplicationName: 1, CreationDate: 1, Id: 1, Message: 1, Type: 1, Url: 1 }, UserLog: { Action: 1, ChangedOn: 1, UserId: 1, UserLogId: 1, UserName: 1 }, UserLogArchive: { Action: 1, ChangedOn: 1, UserId: 1, UserLogArchiveId: 1, UserName: 1 }, UserLoginDetails: { IsOnline: 1, LoginDatetime: 1, LogoutDatetime: 1, UserAddress: 1, UserCityId: 1, UserCreatedBy: 1, UserCreatedDate: 1, UserDepartmentId: 1, UserDesignation: 1, UserEmail: 1, UserEmployeeId: 1, UserFirstName: 1, UserId: 1, UserIsForgotPassword: 1, UserIsPasswordChangeOnLogin: 1, UserIsUserHidden: 1, UserLastName: 1, UserLoginDetailsId: 1, UserMobileCode: 1, UserMobileNumber: 1, UserPasswordExpiryDate: 1, UserPasswordHash: 1, UserPasswordSalt: 1, UserPinCode: 1, UserRoleId: 1, UserStatusId: 1, UserUpdatedBy: 1, UserUpdatedDate: 1, UserUserImage: 1, UserUsername: 1 } } }, Forms: { Membership: { ChangePassword: { BackButton: 1, FormTitle: 1, SubmitButton: 1, Success: 1 }, ForgotPassword: { BackButton: 1, BackToLogin: 1, FormInfo: 1, FormTitle: 1, SubmitButton: 1, Success: 1 }, Login: { FacebookButton: 1, ForgotPassword: 1, FormTitle: 1, GoogleButton: 1, OR: 1, RememberMe: 1, SignInButton: 1, SignUpButton: 1 }, ResetPassword: { BackToLogin: 1, EmailSubject: 1, FormTitle: 1, SubmitButton: 1, Success: 1 }, SignUp: { AcceptTerms: 1, ActivateEmailSubject: 1, ActivationCompleteMessage: 1, BackToLogin: 1, ConfirmEmail: 1, ConfirmPassword: 1, DisplayName: 1, Email: 1, FormInfo: 1, FormTitle: 1, Password: 1, SubmitButton: 1, Success: 1 } } }, Site: { AccessDenied: { ClickToChangeUser: 1, ClickToLogin: 1, LackPermissions: 1, NotLoggedIn: 1, PageTitle: 1 }, BasicProgressDialog: { CancelTitle: 1, PleaseWait: 1 }, BulkServiceAction: { AllHadErrorsFormat: 1, AllSuccessFormat: 1, ConfirmationFormat: 1, ErrorCount: 1, NothingToProcess: 1, SomeHadErrorsFormat: 1, SuccessCount: 1 }, Dashboard: { ContentDescription: 1 }, Layout: { FooterCopyright: 1, FooterInfo: 1, FooterRights: 1, GeneralSettings: 1, Language: 1, Theme: 1, ThemeBlack: 1, ThemeBlackLight: 1, ThemeBlue: 1, ThemeBlueLight: 1, ThemeGreen: 1, ThemeGreenLight: 1, ThemePurple: 1, ThemePurpleLight: 1, ThemeRed: 1, ThemeRedLight: 1, ThemeYellow: 1, ThemeYellowLight: 1 }, RolePermissionDialog: { DialogTitle: 1, EditButton: 1, SaveSuccess: 1 }, UserDialog: { EditPermissionsButton: 1, EditRolesButton: 1 }, UserPermissionDialog: { DialogTitle: 1, Grant: 1, Permission: 1, Revoke: 1, SaveSuccess: 1 }, UserRoleDialog: { DialogTitle: 1, SaveSuccess: 1 }, ValidationError: { Title: 1 } }, Validation: { AuthenticationError: 1, CantFindUserWithEmail: 1, CantFindUserWithUsername: 1, CurrentPasswordMismatch: 1, DeleteForeignKeyError: 1, EmailConfirm: 1, EmailInUse: 1, InvalidActivateToken: 1, InvalidResetToken: 1, MinRequiredPasswordLength: 1, PreviousPasswordError: 1, SavePrimaryKeyError: 1 } });
    })(Texts = CVC.Texts || (CVC.Texts = {}));
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
                return _this;
            }
            UserDialog.prototype.getFormKey = function () { return Administration.UserForm.formKey; };
            UserDialog.prototype.getIdProperty = function () { return Administration.UserRow.idProperty; };
            UserDialog.prototype.getLocalTextPrefix = function () { return Administration.UserRow.localTextPrefix; };
            UserDialog.prototype.getNameProperty = function () { return Administration.UserRow.nameProperty; };
            UserDialog.prototype.getService = function () { return Administration.UserService.baseUrl; };
            UserDialog.prototype.getDeletePermission = function () { return Administration.UserRow.deletePermission; };
            UserDialog.prototype.getInsertPermission = function () { return Administration.UserRow.insertPermission; };
            UserDialog.prototype.getUpdatePermission = function () { return Administration.UserRow.updatePermission; };
            UserDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = Administration.UserService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["UserId" /* UserId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in User
                    // if (res.responseJSON.Entities.length) {
                    //     this.toolbar.findButton("delete-button").remove()
                    // }
                }
            };
            UserDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], UserDialog);
            return UserDialog;
        }(Serenity.EntityDialog));
        Administration.UserDialog = UserDialog;
    })(Administration = CVC.Administration || (CVC.Administration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Batch;
    (function (Batch) {
        var BatchDialog = /** @class */ (function (_super) {
            __extends(BatchDialog, _super);
            function BatchDialog() {
                var _this = _super.call(this) || this;
                _this.form = new Batch.BatchForm(_this.idPrefix);
                return _this;
            }
            BatchDialog.prototype.getFormKey = function () { return Batch.BatchForm.formKey; };
            BatchDialog.prototype.getIdProperty = function () { return Batch.BatchRow.idProperty; };
            BatchDialog.prototype.getLocalTextPrefix = function () { return Batch.BatchRow.localTextPrefix; };
            BatchDialog.prototype.getNameProperty = function () { return Batch.BatchRow.nameProperty; };
            BatchDialog.prototype.getService = function () { return Batch.BatchService.baseUrl; };
            BatchDialog.prototype.getDeletePermission = function () { return Batch.BatchRow.deletePermission; };
            BatchDialog.prototype.getInsertPermission = function () { return Batch.BatchRow.insertPermission; };
            BatchDialog.prototype.getUpdatePermission = function () { return Batch.BatchRow.updatePermission; };
            BatchDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = Batch.BatchService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["BatchId" /* BatchId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in Bottle
                    // if (res.responseJSON.Entities.length) {
                    //     this.toolbar.findButton("delete-button").remove()
                    // }
                }
            };
            BatchDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], BatchDialog);
            return BatchDialog;
        }(Serenity.EntityDialog));
        Batch.BatchDialog = BatchDialog;
    })(Batch = CVC.Batch || (CVC.Batch = {}));
})(CVC || (CVC = {}));
/*
* https://github.com/serenity-is/Serenity/issues/447#issuecomment-901943838
* created by Denis dated 8/20/2021
* **/
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var Bases;
        (function (Bases) {
            var GridBase = /** @class */ (function (_super) {
                __extends(GridBase, _super);
                function GridBase(container, options) {
                    return _super.call(this, container, options) || this;
                }
                GridBase.prototype.createSlickGrid = function () {
                    var grid = _super.prototype.createSlickGrid.call(this);
                    grid.registerPlugin(new Slick.AutoColumnSize(true));
                    return grid;
                };
                GridBase = __decorate([
                    Serenity.Decorators.filterable()
                ], GridBase);
                return GridBase;
            }(Serenity.EntityGrid));
            Bases.GridBase = GridBase;
        })(Bases = Common.Bases || (Common.Bases = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/3/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomColumnFormatters;
        (function (CustomColumnFormatters) {
            var ColoredColumnFormatter = /** @class */ (function () {
                function ColoredColumnFormatter() {
                }
                ColoredColumnFormatter.prototype.format = function (ctx) {
                    if (!ctx.value) {
                        return "";
                    }
                    var text = "";
                    var backgroundColorText;
                    var borderColorText;
                    if (!this.hideText) {
                        text = Q.htmlEncode(ctx.value);
                    }
                    if (this.backgroundColor) {
                        backgroundColorText = "background-color: " + this.backgroundColor + ";";
                    }
                    else if (this.backgroundProperty) {
                        backgroundColorText = "background-color: " + ctx.item[this.backgroundProperty] + ";";
                    }
                    if (this.borderColor) {
                        borderColorText = " border: 1px solid; border-color: " + this.borderColor + ";";
                    }
                    else if (this.borderProperty) {
                        borderColorText = " border: 1px solid; border-color: " + ctx.item[this.borderProperty] + ";";
                    }
                    //return "<span style='background-color: " + color +";'>" + text + '</span>';
                    return "<div class='' style='height: 100%; width: 100%; max-width: 100%; white-space:pre; " + backgroundColorText + " " + borderColorText + " ' > " + text + '</div>';
                };
                ColoredColumnFormatter.prototype.initializeColumn = function (column) {
                    column.referencedFields = column.referencedFields || [];
                    if (this.backgroundProperty)
                        column.referencedFields.push(this.backgroundProperty);
                    if (this.borderProperty)
                        column.referencedFields.push(this.borderProperty);
                };
                __decorate([
                    Serenity.Decorators.option()
                ], ColoredColumnFormatter.prototype, "hideText", void 0);
                __decorate([
                    Serenity.Decorators.option()
                ], ColoredColumnFormatter.prototype, "backgroundProperty", void 0);
                __decorate([
                    Serenity.Decorators.option()
                ], ColoredColumnFormatter.prototype, "backgroundColor", void 0);
                __decorate([
                    Serenity.Decorators.option()
                ], ColoredColumnFormatter.prototype, "borderProperty", void 0);
                __decorate([
                    Serenity.Decorators.option()
                ], ColoredColumnFormatter.prototype, "borderColor", void 0);
                ColoredColumnFormatter = __decorate([
                    Serenity.Decorators.registerFormatter([Serenity.ISlickFormatter, Serenity.IInitializeColumn])
                ], ColoredColumnFormatter);
                return ColoredColumnFormatter;
            }());
            CustomColumnFormatters.ColoredColumnFormatter = ColoredColumnFormatter;
        })(CustomColumnFormatters = Common.CustomColumnFormatters || (Common.CustomColumnFormatters = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/4/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomColumnFormatters;
        (function (CustomColumnFormatters) {
            var ActivationColumnFormatter = /** @class */ (function () {
                function ActivationColumnFormatter() {
                }
                ActivationColumnFormatter.prototype.format = function (ctx) {
                    if (!ctx.value) {
                        return "";
                    }
                    var value = ctx.value;
                    var itm = Q.first(CVC.Common.CustomEditors.ActivationLookup, function (x) { return x.id == value; });
                    return itm.text;
                };
                ActivationColumnFormatter.prototype.initializeColumn = function (column) {
                };
                ActivationColumnFormatter = __decorate([
                    Serenity.Decorators.registerFormatter([Serenity.ISlickFormatter, Serenity.IInitializeColumn])
                ], ActivationColumnFormatter);
                return ActivationColumnFormatter;
            }());
            CustomColumnFormatters.ActivationColumnFormatter = ActivationColumnFormatter;
        })(CustomColumnFormatters = Common.CustomColumnFormatters || (Common.CustomColumnFormatters = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/4/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomColumnFormatters;
        (function (CustomColumnFormatters) {
            var AlignmentColumnFormatter = /** @class */ (function () {
                function AlignmentColumnFormatter() {
                }
                AlignmentColumnFormatter.prototype.format = function (ctx) {
                    if (!ctx.value) {
                        return "";
                    }
                    var value = ctx.value;
                    var itm = Q.first(CVC.Common.CustomEditors.AlignmentLookup, function (x) { return x.id == value; });
                    return itm.text;
                };
                AlignmentColumnFormatter.prototype.initializeColumn = function (column) {
                };
                AlignmentColumnFormatter = __decorate([
                    Serenity.Decorators.registerFormatter([Serenity.ISlickFormatter, Serenity.IInitializeColumn])
                ], AlignmentColumnFormatter);
                return AlignmentColumnFormatter;
            }());
            CustomColumnFormatters.AlignmentColumnFormatter = AlignmentColumnFormatter;
        })(CustomColumnFormatters = Common.CustomColumnFormatters || (Common.CustomColumnFormatters = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/4/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomColumnFormatters;
        (function (CustomColumnFormatters) {
            var AppearanceColumnFormatter = /** @class */ (function () {
                function AppearanceColumnFormatter() {
                }
                AppearanceColumnFormatter.prototype.format = function (ctx) {
                    if (!ctx.value) {
                        return "";
                    }
                    var value = ctx.value;
                    var itm = Q.first(CVC.Common.CustomEditors.AppearanceLookup, function (x) { return x.id == value; });
                    return itm.text;
                };
                AppearanceColumnFormatter.prototype.initializeColumn = function (column) {
                };
                AppearanceColumnFormatter = __decorate([
                    Serenity.Decorators.registerFormatter([Serenity.ISlickFormatter, Serenity.IInitializeColumn])
                ], AppearanceColumnFormatter);
                return AppearanceColumnFormatter;
            }());
            CustomColumnFormatters.AppearanceColumnFormatter = AppearanceColumnFormatter;
        })(CustomColumnFormatters = Common.CustomColumnFormatters || (Common.CustomColumnFormatters = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/4/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomColumnFormatters;
        (function (CustomColumnFormatters) {
            var BorderStyleColumnFormatter = /** @class */ (function () {
                function BorderStyleColumnFormatter() {
                }
                BorderStyleColumnFormatter.prototype.format = function (ctx) {
                    if (!ctx.value) {
                        return "";
                    }
                    var value = ctx.value;
                    var itm = Q.first(CVC.Common.CustomEditors.BorderStyleLookup, function (x) { return x.id == value; });
                    return itm.text;
                };
                BorderStyleColumnFormatter.prototype.initializeColumn = function (column) {
                };
                BorderStyleColumnFormatter = __decorate([
                    Serenity.Decorators.registerFormatter([Serenity.ISlickFormatter, Serenity.IInitializeColumn])
                ], BorderStyleColumnFormatter);
                return BorderStyleColumnFormatter;
            }());
            CustomColumnFormatters.BorderStyleColumnFormatter = BorderStyleColumnFormatter;
        })(CustomColumnFormatters = Common.CustomColumnFormatters || (Common.CustomColumnFormatters = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/6/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomColumnFormatters;
        (function (CustomColumnFormatters) {
            var DOTypeColumnFormatter = /** @class */ (function () {
                function DOTypeColumnFormatter() {
                }
                DOTypeColumnFormatter.prototype.format = function (ctx) {
                    if (!ctx.value) {
                        return "";
                    }
                    var value = ctx.value;
                    var itm = Q.first(CVC.Common.CustomEditors.DOTypeLookup, function (x) { return x.id == value; });
                    return itm.text;
                };
                DOTypeColumnFormatter.prototype.initializeColumn = function (column) {
                };
                DOTypeColumnFormatter = __decorate([
                    Serenity.Decorators.registerFormatter([Serenity.ISlickFormatter, Serenity.IInitializeColumn])
                ], DOTypeColumnFormatter);
                return DOTypeColumnFormatter;
            }());
            CustomColumnFormatters.DOTypeColumnFormatter = DOTypeColumnFormatter;
        })(CustomColumnFormatters = Common.CustomColumnFormatters || (Common.CustomColumnFormatters = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/9/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomColumnFormatters;
        (function (CustomColumnFormatters) {
            var DefaultViewColumnFormatters = /** @class */ (function () {
                function DefaultViewColumnFormatters() {
                }
                DefaultViewColumnFormatters.prototype.format = function (ctx) {
                    if (!ctx.value) {
                        return "";
                    }
                    var value = ctx.value;
                    var itm = Q.first(CVC.Common.CustomEditors.DefaultViewLookup, function (x) { return x.id == value; });
                    return itm.text;
                };
                DefaultViewColumnFormatters.prototype.initializeColumn = function (column) {
                };
                DefaultViewColumnFormatters = __decorate([
                    Serenity.Decorators.registerFormatter([Serenity.ISlickFormatter, Serenity.IInitializeColumn])
                ], DefaultViewColumnFormatters);
                return DefaultViewColumnFormatters;
            }());
            CustomColumnFormatters.DefaultViewColumnFormatters = DefaultViewColumnFormatters;
        })(CustomColumnFormatters = Common.CustomColumnFormatters || (Common.CustomColumnFormatters = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/4/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomColumnFormatters;
        (function (CustomColumnFormatters) {
            var SortTypeColumnFormatter = /** @class */ (function () {
                function SortTypeColumnFormatter() {
                }
                SortTypeColumnFormatter.prototype.format = function (ctx) {
                    if (!ctx.value) {
                        return "";
                    }
                    var value = ctx.value;
                    var itm = Q.first(CVC.Common.CustomEditors.SortTypeLookup, function (x) { return x.id == value; });
                    return itm.text;
                };
                SortTypeColumnFormatter.prototype.initializeColumn = function (column) {
                };
                SortTypeColumnFormatter = __decorate([
                    Serenity.Decorators.registerFormatter([Serenity.ISlickFormatter, Serenity.IInitializeColumn])
                ], SortTypeColumnFormatter);
                return SortTypeColumnFormatter;
            }());
            CustomColumnFormatters.SortTypeColumnFormatter = SortTypeColumnFormatter;
        })(CustomColumnFormatters = Common.CustomColumnFormatters || (Common.CustomColumnFormatters = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/3/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            var ColorPickerEditor = /** @class */ (function (_super) {
                __extends(ColorPickerEditor, _super);
                function ColorPickerEditor(input) {
                    var _this = _super.call(this, input) || this;
                    input.attr('type', 'color');
                    return _this;
                }
                ColorPickerEditor = __decorate([
                    Serenity.Decorators.registerEditor()
                ], ColorPickerEditor);
                return ColorPickerEditor;
            }(Serenity.StringEditor));
            CustomEditors.ColorPickerEditor = ColorPickerEditor;
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/13/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            var NumberInputEditor = /** @class */ (function (_super) {
                __extends(NumberInputEditor, _super);
                function NumberInputEditor(input) {
                    var _a, _b, _c, _d;
                    var _this = _super.call(this, input) || this;
                    input.attr('type', 'number');
                    input.attr('min', (_b = (_a = _this.min) === null || _a === void 0 ? void 0 : _a.toString(), (_b !== null && _b !== void 0 ? _b : '1')));
                    input.attr('max', (_d = (_c = _this.max) === null || _c === void 0 ? void 0 : _c.toString(), (_d !== null && _d !== void 0 ? _d : '100')));
                    return _this;
                }
                __decorate([
                    Serenity.Decorators.option()
                ], NumberInputEditor.prototype, "min", void 0);
                __decorate([
                    Serenity.Decorators.option()
                ], NumberInputEditor.prototype, "max", void 0);
                NumberInputEditor = __decorate([
                    Serenity.Decorators.registerEditor()
                ], NumberInputEditor);
                return NumberInputEditor;
            }(Serenity.StringEditor));
            CustomEditors.NumberInputEditor = NumberInputEditor;
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/3/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            var ActivationValueEditor = /** @class */ (function (_super) {
                __extends(ActivationValueEditor, _super);
                function ActivationValueEditor(container) {
                    var _this = _super.call(this, container, null) || this;
                    CustomEditors.ActivationLookup.forEach(function (ele) { return _this.addItem(ele); });
                    return _this;
                }
                ActivationValueEditor = __decorate([
                    Serenity.Decorators.registerEditor()
                ], ActivationValueEditor);
                return ActivationValueEditor;
            }(Serenity.Select2Editor));
            CustomEditors.ActivationValueEditor = ActivationValueEditor;
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/3/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            var AlignmentValueEditor = /** @class */ (function (_super) {
                __extends(AlignmentValueEditor, _super);
                function AlignmentValueEditor(container) {
                    var _this = _super.call(this, container, null) || this;
                    CustomEditors.AlignmentLookup.forEach(function (ele) { return _this.addItem(ele); });
                    return _this;
                }
                AlignmentValueEditor = __decorate([
                    Serenity.Decorators.registerEditor()
                ], AlignmentValueEditor);
                return AlignmentValueEditor;
            }(Serenity.Select2Editor));
            CustomEditors.AlignmentValueEditor = AlignmentValueEditor;
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/11/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            var AppearanceValueEditor = /** @class */ (function (_super) {
                __extends(AppearanceValueEditor, _super);
                function AppearanceValueEditor(container) {
                    var _this = _super.call(this, container, null) || this;
                    CustomEditors.AppearanceLookup.forEach(function (ele) { return _this.addItem(ele); });
                    return _this;
                }
                AppearanceValueEditor = __decorate([
                    Serenity.Decorators.registerEditor()
                ], AppearanceValueEditor);
                return AppearanceValueEditor;
            }(Serenity.Select2Editor));
            CustomEditors.AppearanceValueEditor = AppearanceValueEditor;
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/3/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            var BorderStyleValueEditor = /** @class */ (function (_super) {
                __extends(BorderStyleValueEditor, _super);
                function BorderStyleValueEditor(container) {
                    var _this = _super.call(this, container, null) || this;
                    CustomEditors.BorderStyleLookup.forEach(function (ele) { return _this.addItem(ele); });
                    return _this;
                }
                BorderStyleValueEditor = __decorate([
                    Serenity.Decorators.registerEditor()
                ], BorderStyleValueEditor);
                return BorderStyleValueEditor;
            }(Serenity.Select2Editor));
            CustomEditors.BorderStyleValueEditor = BorderStyleValueEditor;
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/6/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            var DOTypeValueEditor = /** @class */ (function (_super) {
                __extends(DOTypeValueEditor, _super);
                function DOTypeValueEditor(container) {
                    var _this = _super.call(this, container, null) || this;
                    CustomEditors.DOTypeLookup.forEach(function (ele) { return _this.addItem(ele); });
                    return _this;
                }
                DOTypeValueEditor = __decorate([
                    Serenity.Decorators.registerEditor()
                ], DOTypeValueEditor);
                return DOTypeValueEditor;
            }(Serenity.Select2Editor));
            CustomEditors.DOTypeValueEditor = DOTypeValueEditor;
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/9/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            var DefaultViewValueEditor = /** @class */ (function (_super) {
                __extends(DefaultViewValueEditor, _super);
                function DefaultViewValueEditor(container) {
                    var _this = _super.call(this, container, null) || this;
                    CustomEditors.DefaultViewLookup.forEach(function (ele) { return _this.addItem(ele); });
                    return _this;
                }
                DefaultViewValueEditor = __decorate([
                    Serenity.Decorators.registerEditor()
                ], DefaultViewValueEditor);
                return DefaultViewValueEditor;
            }(Serenity.Select2Editor));
            CustomEditors.DefaultViewValueEditor = DefaultViewValueEditor;
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/3/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            CustomEditors.ActivationLookup = [{ id: "1", text: "One Click" }, { id: "2", text: "Double Click" }];
            CustomEditors.BorderStyleLookup = [{ id: "1", text: "Single" }, { id: "2", text: "Double" }];
            CustomEditors.AlignmentLookup = [
                { id: "1", text: "Left" },
                { id: "2", text: "Center" },
                { id: "3", text: "Right" },
                { id: "4", text: "Top" },
                { id: "5", text: "Middle" },
                { id: "6", text: "Bottom" },
            ];
            CustomEditors.SortTypeLookup = [{ id: "1", text: "Alphabetically" }, { id: "2", text: "Datewise" }];
            CustomEditors.DefaultViewLookup = [{ id: "1", text: "Expanded" }, { id: "2", text: "Closed" }];
            CustomEditors.AppearanceLookup = [{ id: "1", text: "Flash" }, { id: "2", text: "Static" }];
            CustomEditors.DOTypeLookup = [
                { id: "1", text: "List Display", field: "ListDisplayId" },
                { id: "2", text: "Form Display", field: "FormDisplayId" },
                { id: "3", text: "Button Display", field: "ButtonDisplayId" },
                { id: "4", text: "Realtime Parameter Display", field: "RealtimeParameterDisplayId" },
                { id: "5", text: "Line Chart Display", field: "LineChartDisplayId" },
                { id: "6", text: "Pie Chart Display", field: "PieChartDisplayId" },
                { id: "7", text: "Tree Display", field: "TreeDisplayId" },
                { id: "8", text: "Attachments Display", field: "AttachmentDisplayId" },
                { id: "9", text: "Alarm Display", field: "AlarmDisplayId" },
                { id: "10", text: "Notification Display", field: "NotificationDisplayId" },
                { id: "11", text: "Container for third party (exe or webpage)", field: "ContainerDisplayId" }
            ];
            CustomEditors.FontLookup = [
                { id: "Aclonica", text: "Aclonica" },
                { id: "Adamina", text: "Adamina" },
                { id: "Brawler", text: "Brawler" },
                { id: "Copse", text: "Copse" },
                { id: "Cousine", text: "Cousine" },
                { id: "Donegal One", text: "Donegal One" },
                { id: "Doppio One", text: "Doppio One" },
                { id: "Esteban", text: "Esteban" },
                { id: "Glegoo", text: "Glegoo" },
                { id: "Gotu", text: "Gotu" },
                { id: "Gupter", text: "Gupter" },
                { id: "Habibi", text: "Habibi" },
                { id: "Inika", text: "Inika" },
                { id: "Istok Web", text: "Istok Web" },
                { id: "Judson", text: "Judson" },
                { id: "Ledger", text: "Ledger" },
                { id: "Lemon", text: "Lemon" },
                { id: "Manuale", text: "Manuale" },
                { id: "Martel", text: "Martel" },
                { id: "Metrophobic", text: "Metrophobic" },
                { id: "Nokora", text: "Nokora" },
                { id: "Noto Serif", text: "Noto Serif" },
                { id: "Overlock", text: "Overlock" },
                { id: "Oxygen", text: "Oxygen" },
                { id: "Tinos", text: "Tinos" },
                { id: "Voces", text: "Voces" }
            ];
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/13/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            var FontValueEditor = /** @class */ (function (_super) {
                __extends(FontValueEditor, _super);
                function FontValueEditor(container) {
                    var _this = _super.call(this, container, null) || this;
                    CustomEditors.FontLookup.forEach(function (ele) { return _this.addItem(ele); });
                    return _this;
                    //var cssContent = this.getCssContent();
                }
                FontValueEditor = __decorate([
                    Serenity.Decorators.registerEditor()
                ], FontValueEditor);
                return FontValueEditor;
            }(Serenity.Select2Editor));
            CustomEditors.FontValueEditor = FontValueEditor;
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
    })(Common = CVC.Common || (CVC.Common = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 6.5 dated 8/3/2021
var CVC;
(function (CVC) {
    var Common;
    (function (Common) {
        var CustomEditors;
        (function (CustomEditors) {
            var SortTypeValueEditor = /** @class */ (function (_super) {
                __extends(SortTypeValueEditor, _super);
                function SortTypeValueEditor(container) {
                    var _this = _super.call(this, container, null) || this;
                    CustomEditors.SortTypeLookup.forEach(function (ele) { return _this.addItem(ele); });
                    return _this;
                }
                SortTypeValueEditor = __decorate([
                    Serenity.Decorators.registerEditor()
                ], SortTypeValueEditor);
                return SortTypeValueEditor;
            }(Serenity.Select2Editor));
            CustomEditors.SortTypeValueEditor = SortTypeValueEditor;
        })(CustomEditors = Common.CustomEditors || (Common.CustomEditors = {}));
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
                    sb += '<option value="' + Q.attrEncode(x) + '"';
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
                    hint: Q.coalesce(options.hint, 'Excel'),
                    title: Q.coalesce(options.title, ''),
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
            GridEditorBase.prototype.enableDeleteColumn = function () {
                return false;
            };
            GridEditorBase.prototype.getColumns = function () {
                var columns = _super.prototype.getColumns.call(this);
                if (this.enableDeleteColumn()) {
                    columns.unshift({
                        field: 'Delete Row',
                        name: '',
                        format: function (ctx) { return '<a class="inline-action delete-row" title="delete">' +
                            '<i class="fa fa-trash-o text-red"></i></a>'; },
                        width: 24,
                        minWidth: 24,
                        maxWidth: 24
                    });
                }
                return columns;
            };
            GridEditorBase.prototype.onClick = function (e, row, cell) {
                var _this = this;
                _super.prototype.onClick.call(this, e, row, cell);
                if (e.isDefaultPrevented())
                    return;
                var item = this.itemAt(row);
                var target = $(e.target);
                // if user clicks "i" element, e.g. icon
                if (target.parent().hasClass('inline-action'))
                    target = target.parent();
                if (target.hasClass('inline-action')) {
                    e.preventDefault();
                    if (this.enableDeleteColumn()) {
                        if (target.hasClass('delete-row')) {
                            Q.confirm(Q.text('Controls.EntityDialog.DeleteConfirmation'), function () {
                                _this.deleteEntity(item[_this.getIdProperty()]);
                            });
                        }
                    }
                }
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
    /**
     * This is an editor widget but it only displays a text, not edits it.
     *
     */
    var StaticTextBlock = /** @class */ (function (_super) {
        __extends(StaticTextBlock, _super);
        function StaticTextBlock(container, options) {
            var _this = _super.call(this, container, options) || this;
            // hide the caption label for this editor if in a form. ugly hack
            if (_this.options.hideLabel)
                _this.element.closest('.field').find('.caption').hide();
            _this.updateElementContent();
            return _this;
        }
        StaticTextBlock.prototype.updateElementContent = function () {
            var text = Q.coalesce(this.options.text, this.value);
            // if isLocalText is set, text is actually a local text key
            if (this.options.isLocalText)
                text = Q.text(text);
            // don't html encode if isHtml option is true
            if (this.options.isHtml)
                this.element.html(text);
            else
                this.element.text(text);
        };
        /**
         * By implementing ISetEditValue interface, we allow this editor to display its field value.
         * But only do this when our text content is not explicitly set in options
         */
        StaticTextBlock.prototype.setEditValue = function (source, property) {
            if (this.options.text == null) {
                this.value = Q.coalesce(this.options.text, source[property.name]);
                this.updateElementContent();
            }
        };
        StaticTextBlock = __decorate([
            Serenity.Decorators.element("<div/>"),
            Serenity.Decorators.registerEditor([Serenity.ISetEditValue])
        ], StaticTextBlock);
        return StaticTextBlock;
    }(Serenity.Widget));
    CVC.StaticTextBlock = StaticTextBlock;
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var Configuration;
    (function (Configuration) {
        var CompanyDialog = /** @class */ (function (_super) {
            __extends(CompanyDialog, _super);
            function CompanyDialog() {
                var _this = _super.call(this) || this;
                _this.form = new Configuration.CompanyForm(_this.idPrefix);
                return _this;
            }
            CompanyDialog.prototype.getFormKey = function () { return Configuration.CompanyForm.formKey; };
            CompanyDialog.prototype.getIdProperty = function () { return Configuration.CompanyRow.idProperty; };
            CompanyDialog.prototype.getLocalTextPrefix = function () { return Configuration.CompanyRow.localTextPrefix; };
            CompanyDialog.prototype.getNameProperty = function () { return Configuration.CompanyRow.nameProperty; };
            CompanyDialog.prototype.getService = function () { return Configuration.CompanyService.baseUrl; };
            CompanyDialog.prototype.getDeletePermission = function () { return Configuration.CompanyRow.deletePermission; };
            CompanyDialog.prototype.getInsertPermission = function () { return Configuration.CompanyRow.insertPermission; };
            CompanyDialog.prototype.getUpdatePermission = function () { return Configuration.CompanyRow.updatePermission; };
            CompanyDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = Configuration.CompanyService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["CompanyId" /* CompanyId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in Bottle
                    // if (res.responseJSON.Entities.length) {
                    //     this.toolbar.findButton("delete-button").remove()
                    // }
                }
            };
            CompanyDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], CompanyDialog);
            return CompanyDialog;
        }(Serenity.EntityDialog));
        Configuration.CompanyDialog = CompanyDialog;
    })(Configuration = CVC.Configuration || (CVC.Configuration = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmDialog = /** @class */ (function (_super) {
            __extends(AlarmDialog, _super);
            function AlarmDialog() {
                var _this = _super.call(this) || this;
                _this.form = new MachineCustomization.AlarmForm(_this.idPrefix);
                return _this;
            }
            AlarmDialog.prototype.getFormKey = function () { return MachineCustomization.AlarmForm.formKey; };
            AlarmDialog.prototype.getIdProperty = function () { return MachineCustomization.AlarmRow.idProperty; };
            AlarmDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.AlarmRow.localTextPrefix; };
            AlarmDialog.prototype.getNameProperty = function () { return MachineCustomization.AlarmRow.nameProperty; };
            AlarmDialog.prototype.getService = function () { return MachineCustomization.AlarmService.baseUrl; };
            AlarmDialog.prototype.getDeletePermission = function () { return MachineCustomization.AlarmRow.deletePermission; };
            AlarmDialog.prototype.getInsertPermission = function () { return MachineCustomization.AlarmRow.insertPermission; };
            AlarmDialog.prototype.getUpdatePermission = function () { return MachineCustomization.AlarmRow.updatePermission; };
            AlarmDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.AlarmService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["AlarmId" /* AlarmId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in Bottle
                    // if (res.responseJSON.Entities.length) {
                    //     this.toolbar.findButton("delete-button").remove()
                    // }
                }
            };
            AlarmDialog = __decorate([
                Serenity.Decorators.registerClass()
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
        var AlarmDisplayDialog = /** @class */ (function (_super) {
            __extends(AlarmDisplayDialog, _super);
            function AlarmDisplayDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.AlarmDisplayForm(_this.idPrefix);
                return _this;
            }
            AlarmDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.AlarmDisplayForm.formKey; };
            AlarmDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.AlarmDisplayRow.idProperty; };
            AlarmDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.AlarmDisplayRow.localTextPrefix; };
            AlarmDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.AlarmDisplayRow.nameProperty; };
            AlarmDisplayDialog.prototype.getService = function () { return MachineCustomization.AlarmDisplayService.baseUrl; };
            AlarmDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.AlarmDisplayRow.deletePermission; };
            AlarmDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.AlarmDisplayRow.insertPermission; };
            AlarmDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.AlarmDisplayRow.updatePermission; };
            AlarmDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["AlarmDisplayId" /* AlarmDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            AlarmDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], AlarmDisplayDialog);
            return AlarmDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.AlarmDisplayDialog = AlarmDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AlarmDisplayGrid = /** @class */ (function (_super) {
            __extends(AlarmDisplayGrid, _super);
            function AlarmDisplayGrid(container) {
                var _this = _super.call(this, container) || this;
                var grid = _this.slickGrid;
                // var view = this.view;
                //setTimeout(() => this.slickGrid.setSelectedRows([0]), 1000);
                grid.onSelectedRowsChanged.subscribe(function () {
                    var _a;
                    var selectedRow = grid.getSelectedRows()[0];
                    var record = grid.getDataItem(selectedRow);
                    var doTypeLookup = CVC.Common.CustomEditors.DOTypeLookup;
                    var dot = Q.tryFirst(doTypeLookup, function (x) { return x.text === "Alarm Display"; });
                    $('#DisplayObjectTypeId').val(dot.id);
                    $('#SubTypeId').val(record.AlarmDisplayId);
                    console.log("AlarmDisplayId = ", record.AlarmDisplayId);
                    // added by Denis for RS 8.3 dated 9/8/2021
                    // Get SecondaryRelationshipGrid widget and destroy it if it exists.
                    var widget = $('#DisplayObjectType_Color').tryGetWidget(MachineCustomization.DisplayObjectTypeColorGrid);
                    (_a = widget) === null || _a === void 0 ? void 0 : _a.destroy();
                    // Init SecondaryRelationshipGrid widget in the element with id 'Secondary_GridDiv'
                    new CVC.MachineCustomization.DisplayObjectTypeColorGrid($('#DisplayObjectType_Color')).init();
                    // $(".quick-filters-bar").hide();
                });
                return _this;
            }
            AlarmDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.AlarmDisplay'; };
            AlarmDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.AlarmDisplayDialog; };
            AlarmDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.AlarmDisplayRow.idProperty; };
            AlarmDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.AlarmDisplayRow.insertPermission; };
            AlarmDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.AlarmDisplayRow.localTextPrefix; };
            AlarmDisplayGrid.prototype.getService = function () { return MachineCustomization.AlarmDisplayService.baseUrl; };
            AlarmDisplayGrid.prototype.getSlickOptions = function () {
                var opt = _super.prototype.getSlickOptions.call(this);
                opt.enableTextSelectionOnCells = true;
                opt.selectedCellCssClass = "slick-row-selected";
                opt.enableCellNavigation = true;
                return opt;
            };
            AlarmDisplayGrid.prototype.createSlickGrid = function () {
                var grid = _super.prototype.createSlickGrid.call(this);
                grid.setSelectionModel(new Slick.RowSelectionModel());
                return grid;
            };
            AlarmDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], AlarmDisplayGrid);
            return AlarmDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.AlarmDisplayGrid = AlarmDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AttachmentDisplayDialog = /** @class */ (function (_super) {
            __extends(AttachmentDisplayDialog, _super);
            function AttachmentDisplayDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.AttachmentDisplayForm(_this.idPrefix);
                return _this;
            }
            AttachmentDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.AttachmentDisplayForm.formKey; };
            AttachmentDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.AttachmentDisplayRow.idProperty; };
            AttachmentDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.AttachmentDisplayRow.localTextPrefix; };
            AttachmentDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.AttachmentDisplayRow.nameProperty; };
            AttachmentDisplayDialog.prototype.getService = function () { return MachineCustomization.AttachmentDisplayService.baseUrl; };
            AttachmentDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.AttachmentDisplayRow.deletePermission; };
            AttachmentDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.AttachmentDisplayRow.insertPermission; };
            AttachmentDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.AttachmentDisplayRow.updatePermission; };
            AttachmentDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["AttachmentDisplayId" /* AttachmentDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            AttachmentDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], AttachmentDisplayDialog);
            return AttachmentDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.AttachmentDisplayDialog = AttachmentDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var AttachmentDisplayGrid = /** @class */ (function (_super) {
            __extends(AttachmentDisplayGrid, _super);
            function AttachmentDisplayGrid(container) {
                return _super.call(this, container) || this;
            }
            AttachmentDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.AttachmentDisplay'; };
            AttachmentDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.AttachmentDisplayDialog; };
            AttachmentDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.AttachmentDisplayRow.idProperty; };
            AttachmentDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.AttachmentDisplayRow.insertPermission; };
            AttachmentDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.AttachmentDisplayRow.localTextPrefix; };
            AttachmentDisplayGrid.prototype.getService = function () { return MachineCustomization.AttachmentDisplayService.baseUrl; };
            AttachmentDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], AttachmentDisplayGrid);
            return AttachmentDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.AttachmentDisplayGrid = AttachmentDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ButtonDisplayDialog = /** @class */ (function (_super) {
            __extends(ButtonDisplayDialog, _super);
            function ButtonDisplayDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.ButtonDisplayForm(_this.idPrefix);
                return _this;
            }
            ButtonDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.ButtonDisplayForm.formKey; };
            ButtonDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.ButtonDisplayRow.idProperty; };
            ButtonDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.ButtonDisplayRow.localTextPrefix; };
            ButtonDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.ButtonDisplayRow.nameProperty; };
            ButtonDisplayDialog.prototype.getService = function () { return MachineCustomization.ButtonDisplayService.baseUrl; };
            ButtonDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.ButtonDisplayRow.deletePermission; };
            ButtonDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.ButtonDisplayRow.insertPermission; };
            ButtonDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.ButtonDisplayRow.updatePermission; };
            ButtonDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["ButtonDisplayId" /* ButtonDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            ButtonDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], ButtonDisplayDialog);
            return ButtonDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.ButtonDisplayDialog = ButtonDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ButtonDisplayGrid = /** @class */ (function (_super) {
            __extends(ButtonDisplayGrid, _super);
            function ButtonDisplayGrid(container) {
                return _super.call(this, container) || this;
            }
            ButtonDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.ButtonDisplay'; };
            ButtonDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.ButtonDisplayDialog; };
            ButtonDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.ButtonDisplayRow.idProperty; };
            ButtonDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.ButtonDisplayRow.insertPermission; };
            ButtonDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.ButtonDisplayRow.localTextPrefix; };
            ButtonDisplayGrid.prototype.getService = function () { return MachineCustomization.ButtonDisplayService.baseUrl; };
            ButtonDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ButtonDisplayGrid);
            return ButtonDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.ButtonDisplayGrid = ButtonDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ContainerDisplayDialog = /** @class */ (function (_super) {
            __extends(ContainerDisplayDialog, _super);
            function ContainerDisplayDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.ContainerDisplayForm(_this.idPrefix);
                return _this;
            }
            ContainerDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.ContainerDisplayForm.formKey; };
            ContainerDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.ContainerDisplayRow.idProperty; };
            ContainerDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.ContainerDisplayRow.localTextPrefix; };
            ContainerDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.ContainerDisplayRow.nameProperty; };
            ContainerDisplayDialog.prototype.getService = function () { return MachineCustomization.ContainerDisplayService.baseUrl; };
            ContainerDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.ContainerDisplayRow.deletePermission; };
            ContainerDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.ContainerDisplayRow.insertPermission; };
            ContainerDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.ContainerDisplayRow.updatePermission; };
            ContainerDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["ContainerDisplayId" /* ContainerDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            ContainerDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], ContainerDisplayDialog);
            return ContainerDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.ContainerDisplayDialog = ContainerDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ContainerDisplayGrid = /** @class */ (function (_super) {
            __extends(ContainerDisplayGrid, _super);
            function ContainerDisplayGrid(container) {
                return _super.call(this, container) || this;
            }
            ContainerDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.ContainerDisplay'; };
            ContainerDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.ContainerDisplayDialog; };
            ContainerDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.ContainerDisplayRow.idProperty; };
            ContainerDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.ContainerDisplayRow.insertPermission; };
            ContainerDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.ContainerDisplayRow.localTextPrefix; };
            ContainerDisplayGrid.prototype.getService = function () { return MachineCustomization.ContainerDisplayService.baseUrl; };
            ContainerDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ContainerDisplayGrid);
            return ContainerDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.ContainerDisplayGrid = ContainerDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectDialog = /** @class */ (function (_super) {
            __extends(DisplayObjectDialog, _super);
            function DisplayObjectDialog() {
                var _this = _super.call(this) || this;
                _this.form = new MachineCustomization.DisplayObjectForm(_this.idPrefix);
                _this.form.DisplayObjectTypeId.changeSelect2(function (e) {
                    var _a, _b, _c, _d;
                    var value = _this.form.DisplayObjectTypeId.value;
                    var doTypeLookup = CVC.Common.CustomEditors.DOTypeLookup;
                    doTypeLookup.forEach(function (item) {
                        var _a, _b;
                        (_a = _this.form[item.field]) === null || _a === void 0 ? void 0 : _a.getGridField().toggle(false);
                        (_b = _this.form[item.field]) === null || _b === void 0 ? void 0 : _b.element.toggleClass('required', false);
                    });
                    // Show the dropdown for the selected Display Object Type
                    var item = Q.tryFirst(doTypeLookup, function (x) { return x.id === value; });
                    (_b = _this.form[(_a = item) === null || _a === void 0 ? void 0 : _a.field]) === null || _b === void 0 ? void 0 : _b.getGridField().toggle(true);
                    (_d = _this.form[(_c = item) === null || _c === void 0 ? void 0 : _c.field]) === null || _d === void 0 ? void 0 : _d.element.toggleClass('required', true);
                });
                return _this;
            }
            DisplayObjectDialog.prototype.getFormKey = function () { return MachineCustomization.DisplayObjectForm.formKey; };
            DisplayObjectDialog.prototype.getIdProperty = function () { return MachineCustomization.DisplayObjectRow.idProperty; };
            DisplayObjectDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.DisplayObjectRow.localTextPrefix; };
            DisplayObjectDialog.prototype.getNameProperty = function () { return MachineCustomization.DisplayObjectRow.nameProperty; };
            DisplayObjectDialog.prototype.getService = function () { return MachineCustomization.DisplayObjectService.baseUrl; };
            DisplayObjectDialog.prototype.getDeletePermission = function () { return MachineCustomization.DisplayObjectRow.deletePermission; };
            DisplayObjectDialog.prototype.getInsertPermission = function () { return MachineCustomization.DisplayObjectRow.insertPermission; };
            DisplayObjectDialog.prototype.getUpdatePermission = function () { return MachineCustomization.DisplayObjectRow.updatePermission; };
            DisplayObjectDialog.prototype.getToolbarButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getToolbarButtons.call(this);
                Q.first(buttons, function (x) { return x.cssClass == "delete-button"; }).onClick = function () {
                    var isDOFs = _this.checkDisplayObjectFields(_this.entityId);
                    if (isDOFs) {
                        Q.alert("The Display Object cannot be deleted because there are Display Object Fields that belongs to the Display Object");
                    }
                    else {
                        Q.confirm('Do you want to delete the record?', function () {
                            _this.doDelete(function () {
                                _this.dialogClose();
                            });
                        });
                    }
                };
                return buttons;
            };
            DisplayObjectDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                var isDOFs = this.checkDisplayObjectFields(this.entityId);
                if (isDOFs)
                    Serenity.EditorUtils.setReadOnly(this.form.MachineId, true);
            };
            // Check whether display object fields that belongs to certain display object exist or not
            DisplayObjectDialog.prototype.checkDisplayObjectFields = function (displayObjectId) {
                var criteria;
                var res = MachineCustomization.DisplayObjectFieldService.List({
                    Criteria: Serenity.Criteria.and(criteria, [["ViewsId" /* ViewsId */], '=', displayObjectId])
                }, function (_response) { }, { async: false });
                return res.responseJSON.TotalCount ? true : false;
            };
            DisplayObjectDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], DisplayObjectDialog);
            return DisplayObjectDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.DisplayObjectDialog = DisplayObjectDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectGrid = /** @class */ (function (_super) {
            __extends(DisplayObjectGrid, _super);
            function DisplayObjectGrid(container) {
                var _this = _super.call(this, container) || this;
                var grid = _this.slickGrid;
                // Set the first row as default selected
                _this.view.onDataLoaded.subscribe(function (e) {
                    var selectedRow = grid.getSelectedRows()[0];
                    if (selectedRow)
                        grid.setSelectedRows([selectedRow]);
                    else
                        grid.setSelectedRows([0]);
                });
                grid.onSelectedRowsChanged.subscribe(function () {
                    var _a;
                    var selectedRow = grid.getSelectedRows()[0];
                    var record = grid.getDataItem(selectedRow);
                    // Set the value of hidden tag with id 'DisplayObjectId'
                    $("#DisplayObjectId").val(record.ViewsId);
                    $("#DisplayObjectType").val(record.DisplayObjectTypeId);
                    $("#DisplayObjectName").val(record.ViewName);
                    // added by Denis for RS 7.2 dated 10/6/2021
                    // Get DisplayObjectField Widget and destroy it if it exists.
                    var widget = $('#DisplayObjectField_GridDiv').tryGetWidget(MachineCustomization.DisplayObjectFieldGrid);
                    (_a = widget) === null || _a === void 0 ? void 0 : _a.destroy();
                    // Init DisplayObjectFieldGrid widget in the element with id 'DisplayObjectField_GridDiv'
                    new CVC.MachineCustomization.DisplayObjectFieldGrid($('#DisplayObjectField_GridDiv')).init();
                    $(".quick-filters-bar").hide();
                });
                return _this;
            }
            DisplayObjectGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.DisplayObject'; };
            DisplayObjectGrid.prototype.getDialogType = function () { return MachineCustomization.DisplayObjectDialog; };
            DisplayObjectGrid.prototype.getIdProperty = function () { return MachineCustomization.DisplayObjectRow.idProperty; };
            DisplayObjectGrid.prototype.getInsertPermission = function () { return MachineCustomization.DisplayObjectRow.insertPermission; };
            DisplayObjectGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.DisplayObjectRow.localTextPrefix; };
            DisplayObjectGrid.prototype.getService = function () { return MachineCustomization.DisplayObjectService.baseUrl; };
            DisplayObjectGrid.prototype.getColumns = function () {
                var re = /Id/gi;
                var columns = _super.prototype.getColumns.call(this);
                columns.unshift({
                    field: 'Design Mode',
                    name: 'Design Mode',
                    format: function (ctx) { return '<button type="button" class="btn btn-primary design-mode"><i class="fa fa-th" aria-hidden="true"></i></button>'; },
                    width: 50,
                    minWidth: 50,
                    maxWidth: 50
                });
                var dos_col = Q.first(columns, function (x) { return x.field === "DisplayObjectStyle" /* DisplayObjectStyle */; });
                dos_col.referencedFields = ["DisplayObjectStyle" /* DisplayObjectStyle */];
                dos_col.format = function (ctx) {
                    var _a, _b;
                    var doTypeId = ctx.item["DisplayObjectTypeId" /* DisplayObjectTypeId */];
                    var field = (_a = Q.tryFirst(CVC.Common.CustomEditors.DOTypeLookup, function (x) { return x.id == doTypeId; })) === null || _a === void 0 ? void 0 : _a.field;
                    // Change i.e ListDisplayId -> ListDisplayName
                    var colName = (_b = field) === null || _b === void 0 ? void 0 : _b.replace(re, "Name");
                    var value = ctx.item[colName];
                    return (value !== null && value !== void 0 ? value : "");
                };
                CVC.Common.CustomEditors.DOTypeLookup.forEach(function (ele) {
                    var _a;
                    var colName = (_a = ele.field) === null || _a === void 0 ? void 0 : _a.replace(re, "Name");
                    if (colName) {
                        //columns.splice(Q.indexOf(columns, x => x.field === colName), 1);
                        var col = Q.tryFirst(columns, function (x) { return x.field === colName; });
                        col.headerCssClass = "CVC_Hidden";
                        col.cssClass = "CVC_Hidden";
                    }
                });
                return columns;
            };
            /* Below two functions make SlickGrid row selectable
             * https://github.com/serenity-is/Serenity/issues/1241
             * ******************************************************************************/
            DisplayObjectGrid.prototype.getSlickOptions = function () {
                var opt = _super.prototype.getSlickOptions.call(this);
                opt.enableTextSelectionOnCells = true;
                opt.selectedCellCssClass = "slick-row-selected";
                opt.enableCellNavigation = true;
                opt.rowHeight = 40;
                opt.frozenColumn = 0;
                return opt;
            };
            DisplayObjectGrid.prototype.createSlickGrid = function () {
                var grid = _super.prototype.createSlickGrid.call(this);
                grid.setSelectionModel(new Slick.RowSelectionModel());
                return grid;
            };
            DisplayObjectGrid.prototype.onClick = function (e, row, cell) {
                _super.prototype.onClick.call(this, e, row, cell);
                if (e.isDefaultPrevented())
                    return;
                if ($(e.target).hasClass("design-mode")) {
                    Q.notifyInfo("Design Mode selected");
                }
            };
            DisplayObjectGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], DisplayObjectGrid);
            return DisplayObjectGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.DisplayObjectGrid = DisplayObjectGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectLookupEditor = /** @class */ (function (_super) {
            __extends(DisplayObjectLookupEditor, _super);
            function DisplayObjectLookupEditor(container, opt) {
                return _super.call(this, container, opt) || this;
            }
            DisplayObjectLookupEditor.prototype.getLookupKey = function () {
                return "MachineCustomization.DisplayObject";
            };
            DisplayObjectLookupEditor.prototype.getItems = function (lookup) {
                var res = MachineCustomization.DisplayObjectService.List({
                    ColumnSelection: 1,
                    IncludeColumns: ["ViewsId", "ViewName"]
                }, function (_response) { }, { async: false });
                var items = res.responseJSON.Entities;
                return items;
            };
            DisplayObjectLookupEditor = __decorate([
                Serenity.Decorators.registerEditor()
            ], DisplayObjectLookupEditor);
            return DisplayObjectLookupEditor;
        }(Serenity.LookupEditorBase));
        MachineCustomization.DisplayObjectLookupEditor = DisplayObjectLookupEditor;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectColorDialog = /** @class */ (function (_super) {
            __extends(DisplayObjectColorDialog, _super);
            function DisplayObjectColorDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.DisplayObjectColorForm(_this.idPrefix);
                return _this;
            }
            DisplayObjectColorDialog.prototype.getFormKey = function () { return MachineCustomization.DisplayObjectColorForm.formKey; };
            DisplayObjectColorDialog.prototype.getIdProperty = function () { return MachineCustomization.DisplayObjectColorRow.idProperty; };
            DisplayObjectColorDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.DisplayObjectColorRow.localTextPrefix; };
            DisplayObjectColorDialog.prototype.getNameProperty = function () { return MachineCustomization.DisplayObjectColorRow.nameProperty; };
            DisplayObjectColorDialog.prototype.getService = function () { return MachineCustomization.DisplayObjectColorService.baseUrl; };
            DisplayObjectColorDialog.prototype.getDeletePermission = function () { return MachineCustomization.DisplayObjectColorRow.deletePermission; };
            DisplayObjectColorDialog.prototype.getInsertPermission = function () { return MachineCustomization.DisplayObjectColorRow.insertPermission; };
            DisplayObjectColorDialog.prototype.getUpdatePermission = function () { return MachineCustomization.DisplayObjectColorRow.updatePermission; };
            DisplayObjectColorDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], DisplayObjectColorDialog);
            return DisplayObjectColorDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.DisplayObjectColorDialog = DisplayObjectColorDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectColorGrid = /** @class */ (function (_super) {
            __extends(DisplayObjectColorGrid, _super);
            function DisplayObjectColorGrid(container) {
                return _super.call(this, container) || this;
            }
            DisplayObjectColorGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.DisplayObjectColor'; };
            DisplayObjectColorGrid.prototype.getDialogType = function () { return MachineCustomization.DisplayObjectColorDialog; };
            DisplayObjectColorGrid.prototype.getIdProperty = function () { return MachineCustomization.DisplayObjectColorRow.idProperty; };
            DisplayObjectColorGrid.prototype.getInsertPermission = function () { return MachineCustomization.DisplayObjectColorRow.insertPermission; };
            DisplayObjectColorGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.DisplayObjectColorRow.localTextPrefix; };
            DisplayObjectColorGrid.prototype.getService = function () { return MachineCustomization.DisplayObjectColorService.baseUrl; };
            DisplayObjectColorGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], DisplayObjectColorGrid);
            return DisplayObjectColorGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.DisplayObjectColorGrid = DisplayObjectColorGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectFieldDialog = /** @class */ (function (_super) {
            __extends(DisplayObjectFieldDialog, _super);
            function DisplayObjectFieldDialog() {
                var _this = _super.call(this) || this;
                _this.form = new MachineCustomization.DisplayObjectFieldForm(_this.idPrefix);
                // added by Denis for RS 7 dated 10/5/2021
                _this.form.ViewsId.changeSelect2(function (e) {
                    var viewId = _this.form.ViewsId.value;
                    // Getting MachineId
                    if (!viewId)
                        return;
                    var res = MachineCustomization.DisplayObjectService.Retrieve({ EntityId: viewId, ColumnSelection: 1, IncludeColumns: ["MachineId"] }, function (_response) { }, { async: false });
                    var machineId = res.responseJSON.Entity.MachineId;
                    // Cascading MachineParameterId lookup editor
                    _this.form.MachineParameterId.cascadeField = "MachineId" /* MachineId */;
                    _this.form.MachineParameterId.cascadeValue = machineId;
                    _this.form.MachineParameterId.updateItems();
                });
                _this.form.IsAuthenticationRequired.change(function (e) {
                    var flag = _this.form.IsAuthenticationRequired.value;
                    Serenity.EditorUtils.setReadOnly(_this.form.Roles, !flag);
                    _this.form.Roles.element.toggleClass('required', flag);
                    Serenity.EditorUtils.setReadOnly(_this.form.IsSelectAllRoles, !flag);
                    if (!flag) {
                        _this.form.Roles.set_value("");
                        _this.form.IsSelectAllRoles.value = false;
                    }
                });
                _this.form.IsSelectAllRoles.change(function (e) {
                    var flag = _this.form.IsSelectAllRoles.value;
                    if (flag) {
                        var allSelected = _this.form.Roles.items.reduce(function (previousValue, currentValue) { return previousValue + currentValue.id + ","; }, "");
                        _this.form.Roles.set_value(allSelected);
                    }
                    else {
                        _this.form.Roles.set_value("");
                    }
                });
                _this.sequenceNums = [];
                _this.form.Sequence.addValidationRule(_this.uniqueName, function (e) {
                    var value = _this.form.Sequence.value;
                    if (_this.sequenceNums.includes(value)) {
                        return "This value already exists";
                    }
                });
                return _this;
            }
            DisplayObjectFieldDialog.prototype.getFormKey = function () { return MachineCustomization.DisplayObjectFieldForm.formKey; };
            DisplayObjectFieldDialog.prototype.getIdProperty = function () { return MachineCustomization.DisplayObjectFieldRow.idProperty; };
            DisplayObjectFieldDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.DisplayObjectFieldRow.localTextPrefix; };
            DisplayObjectFieldDialog.prototype.getNameProperty = function () { return MachineCustomization.DisplayObjectFieldRow.nameProperty; };
            DisplayObjectFieldDialog.prototype.getService = function () { return MachineCustomization.DisplayObjectFieldService.baseUrl; };
            DisplayObjectFieldDialog.prototype.getDeletePermission = function () { return MachineCustomization.DisplayObjectFieldRow.deletePermission; };
            DisplayObjectFieldDialog.prototype.getInsertPermission = function () { return MachineCustomization.DisplayObjectFieldRow.insertPermission; };
            DisplayObjectFieldDialog.prototype.getUpdatePermission = function () { return MachineCustomization.DisplayObjectFieldRow.updatePermission; };
            DisplayObjectFieldDialog.prototype.afterLoadEntity = function () {
                var _this = this;
                _super.prototype.afterLoadEntity.call(this);
                var viewId = $("#DisplayObjectId").val();
                if (this.isNew() && viewId) {
                    this.form.ViewsId.set_value(viewId);
                }
                Serenity.EditorUtils.setReadOnly(this.form.ViewsId, true);
                if (!this.isNew()) {
                    var res = Q.serviceRequest("/NModuleManagement/Module/getSelectedViewField?id=" + this.entityId, {}, function (_response) { }, { async: false });
                    var pickedRoleIds = res.responseJSON.RoleIdsArray;
                    this.form.Roles.set_value(pickedRoleIds);
                }
                if (!this.form.IsAuthenticationRequired.value) {
                    Serenity.EditorUtils.setReadOnly(this.form.Roles, true);
                    this.form.IsSelectAllRoles.value = false;
                    Serenity.EditorUtils.setReadOnly(this.form.IsSelectAllRoles, true);
                }
                this.sequenceNums = this.getSequenceNumbers(Q.toId(this.form.ViewsId.value));
                if (!this.isNew()) {
                    this.sequenceNums = this.sequenceNums.filter(function (num) { return num != _this.form.Sequence.value; });
                }
                this.form.Roles.element.toggleClass('required', this.form.IsAuthenticationRequired.value);
            };
            DisplayObjectFieldDialog.prototype.onSaveSuccess = function (response) {
                _super.prototype.onSaveSuccess.call(this, response);
                var viewFieldId = response.EntityId;
                var roles = this.form.Roles.value;
                this.addUpdateViewFieldAuthentication(viewFieldId, roles);
            };
            DisplayObjectFieldDialog.prototype.getToolbarButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getToolbarButtons.call(this);
                Q.first(buttons, function (x) { return x.cssClass == "delete-button"; }).onClick = function () {
                    Q.confirm('Do you want to delete the record?', function () {
                        _this.addUpdateViewFieldAuthentication(_this.entityId, "");
                        _this.doDelete(function () {
                            _this.dialogClose();
                        });
                    });
                };
                return buttons;
            };
            DisplayObjectFieldDialog.prototype.addUpdateViewFieldAuthentication = function (viewFieldId, roles) {
                //var res = Q.serviceRequest("/NModuleManagement/Module/AddUpdateViewFieldAuthentication", { ViewFieldId: viewFieldId, RoleIds: roles }, _response => { }, { async: false });
                $.ajax({
                    type: "POST",
                    url: "/NModuleManagement/Module/AddUpdateViewFieldAuthentication",
                    data: { ViewFieldId: viewFieldId, RoleIds: roles },
                    async: false
                });
            };
            DisplayObjectFieldDialog.prototype.getSequenceNumbers = function (viewFieldId) {
                var criteria;
                var res = MachineCustomization.DisplayObjectFieldService.List({
                    Criteria: Serenity.Criteria.and(criteria, [["ViewsId" /* ViewsId */], '=', viewFieldId])
                }, function (_response) { }, { async: false });
                return res.responseJSON.Entities.map(function (obj) { return obj.Sequence; }).filter(function (num) { return num != null; });
            };
            DisplayObjectFieldDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], DisplayObjectFieldDialog);
            return DisplayObjectFieldDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.DisplayObjectFieldDialog = DisplayObjectFieldDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectFieldGrid = /** @class */ (function (_super) {
            __extends(DisplayObjectFieldGrid, _super);
            function DisplayObjectFieldGrid(container) {
                return _super.call(this, container) || this;
            }
            DisplayObjectFieldGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.DisplayObjectField'; };
            DisplayObjectFieldGrid.prototype.getDialogType = function () { return MachineCustomization.DisplayObjectFieldDialog; };
            DisplayObjectFieldGrid.prototype.getIdProperty = function () { return MachineCustomization.DisplayObjectFieldRow.idProperty; };
            DisplayObjectFieldGrid.prototype.getInsertPermission = function () { return MachineCustomization.DisplayObjectFieldRow.insertPermission; };
            DisplayObjectFieldGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.DisplayObjectFieldRow.localTextPrefix; };
            DisplayObjectFieldGrid.prototype.getService = function () { return MachineCustomization.DisplayObjectFieldService.baseUrl; };
            DisplayObjectFieldGrid.prototype.onViewSubmit = function () {
                if (!_super.prototype.onViewSubmit.call(this)) {
                    return false;
                }
                var request = this.view.params;
                var displayObjectId = parseInt($("#DisplayObjectId").val());
                if (displayObjectId)
                    request.EqualityFilter.ViewsId = displayObjectId;
                return true;
            };
            DisplayObjectFieldGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], DisplayObjectFieldGrid);
            return DisplayObjectFieldGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.DisplayObjectFieldGrid = DisplayObjectFieldGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectTypeColorDialog = /** @class */ (function (_super) {
            __extends(DisplayObjectTypeColorDialog, _super);
            function DisplayObjectTypeColorDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.DisplayObjectTypeColorForm(_this.idPrefix);
                return _this;
            }
            DisplayObjectTypeColorDialog.prototype.getFormKey = function () { return MachineCustomization.DisplayObjectTypeColorForm.formKey; };
            DisplayObjectTypeColorDialog.prototype.getIdProperty = function () { return MachineCustomization.DisplayObjectTypeColorRow.idProperty; };
            DisplayObjectTypeColorDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.DisplayObjectTypeColorRow.localTextPrefix; };
            DisplayObjectTypeColorDialog.prototype.getNameProperty = function () { return MachineCustomization.DisplayObjectTypeColorRow.nameProperty; };
            DisplayObjectTypeColorDialog.prototype.getService = function () { return MachineCustomization.DisplayObjectTypeColorService.baseUrl; };
            DisplayObjectTypeColorDialog.prototype.getDeletePermission = function () { return MachineCustomization.DisplayObjectTypeColorRow.deletePermission; };
            DisplayObjectTypeColorDialog.prototype.getInsertPermission = function () { return MachineCustomization.DisplayObjectTypeColorRow.insertPermission; };
            DisplayObjectTypeColorDialog.prototype.getUpdatePermission = function () { return MachineCustomization.DisplayObjectTypeColorRow.updatePermission; };
            DisplayObjectTypeColorDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                // Your custom initialization logic here
                // Example: Set a default value for a field if it's empty
                var subid = $("#SubTypeId").val();
                var dotid = $("#DisplayObjectTypeId").val();
                console.log("subid ", subid, "dotid ", dotid);
                this.form.SubTypeId.value = parseInt(subid);
                // this.form.SubTypeId.value = 123;
                this.form.DisplayObjectTypeId.value = parseInt(dotid);
                // // this.form.DisplayObjectTypeId.read
                Serenity.EditorUtils.setReadOnly(this.form.DisplayObjectTypeId, true);
                Serenity.EditorUtils.setReadOnly(this.form.SubTypeId, true);
            };
            DisplayObjectTypeColorDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], DisplayObjectTypeColorDialog);
            return DisplayObjectTypeColorDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.DisplayObjectTypeColorDialog = DisplayObjectTypeColorDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var DisplayObjectTypeColorGrid = /** @class */ (function (_super) {
            __extends(DisplayObjectTypeColorGrid, _super);
            function DisplayObjectTypeColorGrid(container) {
                return _super.call(this, container) || this;
            }
            DisplayObjectTypeColorGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.DisplayObjectTypeColor'; };
            DisplayObjectTypeColorGrid.prototype.getDialogType = function () { return MachineCustomization.DisplayObjectTypeColorDialog; };
            DisplayObjectTypeColorGrid.prototype.getIdProperty = function () { return MachineCustomization.DisplayObjectTypeColorRow.idProperty; };
            DisplayObjectTypeColorGrid.prototype.getInsertPermission = function () { return MachineCustomization.DisplayObjectTypeColorRow.insertPermission; };
            DisplayObjectTypeColorGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.DisplayObjectTypeColorRow.localTextPrefix; };
            DisplayObjectTypeColorGrid.prototype.getService = function () { return MachineCustomization.DisplayObjectTypeColorService.baseUrl; };
            DisplayObjectTypeColorGrid.prototype.onViewSubmit = function () {
                if (!_super.prototype.onViewSubmit.call(this)) {
                    return false;
                }
                var request = this.view.params;
                var dotId = parseInt($("#DisplayObjectTypeId").val());
                var subId = parseInt($("#SubTypeId").val());
                //$("#PrimaryRelationshipId").val("");
                if (!request.EqualityFilter)
                    request.EqualityFilter = {};
                if (dotId) {
                    console.log("DisplayObjectTypeColorGrid!!! dotid =", dotId, "subid = ", subId);
                    request.EqualityFilter["DisplayObjectTypeId"] = dotId;
                    request.EqualityFilter["SubTypeId"] = subId;
                }
                return true;
            };
            DisplayObjectTypeColorGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], DisplayObjectTypeColorGrid);
            return DisplayObjectTypeColorGrid;
        }(Serenity.EntityGrid));
        MachineCustomization.DisplayObjectTypeColorGrid = DisplayObjectTypeColorGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var FormDisplayDialog = /** @class */ (function (_super) {
            __extends(FormDisplayDialog, _super);
            function FormDisplayDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.FormDisplayForm(_this.idPrefix);
                return _this;
            }
            FormDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.FormDisplayForm.formKey; };
            FormDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.FormDisplayRow.idProperty; };
            FormDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.FormDisplayRow.localTextPrefix; };
            FormDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.FormDisplayRow.nameProperty; };
            FormDisplayDialog.prototype.getService = function () { return MachineCustomization.FormDisplayService.baseUrl; };
            FormDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.FormDisplayRow.deletePermission; };
            FormDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.FormDisplayRow.insertPermission; };
            FormDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.FormDisplayRow.updatePermission; };
            FormDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["FormDisplayId" /* FormDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            FormDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], FormDisplayDialog);
            return FormDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.FormDisplayDialog = FormDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var FormDisplayGrid = /** @class */ (function (_super) {
            __extends(FormDisplayGrid, _super);
            function FormDisplayGrid(container) {
                return _super.call(this, container) || this;
            }
            FormDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.FormDisplay'; };
            FormDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.FormDisplayDialog; };
            FormDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.FormDisplayRow.idProperty; };
            FormDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.FormDisplayRow.insertPermission; };
            FormDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.FormDisplayRow.localTextPrefix; };
            FormDisplayGrid.prototype.getService = function () { return MachineCustomization.FormDisplayService.baseUrl; };
            FormDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], FormDisplayGrid);
            return FormDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.FormDisplayGrid = FormDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineChartDisplayDialog = /** @class */ (function (_super) {
            __extends(LineChartDisplayDialog, _super);
            function LineChartDisplayDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.LineChartDisplayForm(_this.idPrefix);
                return _this;
            }
            LineChartDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.LineChartDisplayForm.formKey; };
            LineChartDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.LineChartDisplayRow.idProperty; };
            LineChartDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.LineChartDisplayRow.localTextPrefix; };
            LineChartDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.LineChartDisplayRow.nameProperty; };
            LineChartDisplayDialog.prototype.getService = function () { return MachineCustomization.LineChartDisplayService.baseUrl; };
            LineChartDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.LineChartDisplayRow.deletePermission; };
            LineChartDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.LineChartDisplayRow.insertPermission; };
            LineChartDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.LineChartDisplayRow.updatePermission; };
            LineChartDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["LineChartDisplayId" /* LineChartDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            LineChartDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], LineChartDisplayDialog);
            return LineChartDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.LineChartDisplayDialog = LineChartDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var LineChartDisplayGrid = /** @class */ (function (_super) {
            __extends(LineChartDisplayGrid, _super);
            function LineChartDisplayGrid(container) {
                var _this = _super.call(this, container) || this;
                var grid = _this.slickGrid;
                // var view = this.view;
                //setTimeout(() => this.slickGrid.setSelectedRows([0]), 1000);
                grid.onSelectedRowsChanged.subscribe(function () {
                    var _a;
                    var selectedRow = grid.getSelectedRows()[0];
                    var record = grid.getDataItem(selectedRow);
                    var doTypeLookup = CVC.Common.CustomEditors.DOTypeLookup;
                    var dot = Q.tryFirst(doTypeLookup, function (x) { return x.text === "Line Chart Display"; });
                    $('#DisplayObjectTypeId').val(dot.id);
                    $('#SubTypeId').val(record.LineChartDisplayId);
                    console.log("LineChartDisplayId = ", record.LineChartDisplayId);
                    // added by Denis for RS 8.3 dated 9/8/2021
                    // Get SecondaryRelationshipGrid widget and destroy it if it exists.
                    var widget = $('#DisplayObjectType_Color').tryGetWidget(MachineCustomization.DisplayObjectTypeColorGrid);
                    (_a = widget) === null || _a === void 0 ? void 0 : _a.destroy();
                    // Init SecondaryRelationshipGrid widget in the element with id 'Secondary_GridDiv'
                    new CVC.MachineCustomization.DisplayObjectTypeColorGrid($('#DisplayObjectType_Color')).init();
                    // $(".quick-filters-bar").hide();
                });
                return _this;
            }
            LineChartDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.LineChartDisplay'; };
            LineChartDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.LineChartDisplayDialog; };
            LineChartDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.LineChartDisplayRow.idProperty; };
            LineChartDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.LineChartDisplayRow.insertPermission; };
            LineChartDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.LineChartDisplayRow.localTextPrefix; };
            LineChartDisplayGrid.prototype.getService = function () { return MachineCustomization.LineChartDisplayService.baseUrl; };
            LineChartDisplayGrid.prototype.getSlickOptions = function () {
                var opt = _super.prototype.getSlickOptions.call(this);
                opt.enableTextSelectionOnCells = true;
                opt.selectedCellCssClass = "slick-row-selected";
                opt.enableCellNavigation = true;
                return opt;
            };
            LineChartDisplayGrid.prototype.createSlickGrid = function () {
                var grid = _super.prototype.createSlickGrid.call(this);
                grid.setSelectionModel(new Slick.RowSelectionModel());
                return grid;
            };
            LineChartDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], LineChartDisplayGrid);
            return LineChartDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.LineChartDisplayGrid = LineChartDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ListDisplayDialog = /** @class */ (function (_super) {
            __extends(ListDisplayDialog, _super);
            function ListDisplayDialog() {
                var _this = _super.call(this) || this;
                _this.form = new MachineCustomization.ListDisplayForm(_this.idPrefix);
                return _this;
                /* added by Denis for RS 6.5 dated 8/5/2021
                 * There cannot be more than one ListDisplay with the same ViewId
                 * **/
                /*this.form.ViewId.addValidationRule(this.uniqueName, e => {
                    var listDisplayId = this.form.ListDisplayId.value;
                    var viewId = this.form.ViewId.value;
                    var res = ListDisplayService.List({
                        Criteria: null,
                        ColumnSelection: 1,
                        IncludeColumns: ["ViewId"]
                    }, response => {
    
                    }, {
                        async: false
                    });
    
                    var existOne = Q.tryFirst(res.responseJSON.Entities, ({ ViewId }) => ViewId === Q.toId(viewId))
                    if (existOne) {
                        if (existOne['ListDisplayId'] !== listDisplayId) {
                            Q.alert("The properties of the selected Display Object already exist.");
                            return "The properties of the selected Display Object already exist.";
                        }
                    }
                });*/
            }
            ListDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.ListDisplayForm.formKey; };
            ListDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.ListDisplayRow.idProperty; };
            ListDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.ListDisplayRow.localTextPrefix; };
            ListDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.ListDisplayRow.nameProperty; };
            ListDisplayDialog.prototype.getService = function () { return MachineCustomization.ListDisplayService.baseUrl; };
            ListDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.ListDisplayRow.deletePermission; };
            ListDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.ListDisplayRow.insertPermission; };
            ListDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.ListDisplayRow.updatePermission; };
            ListDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["ListDisplayId" /* ListDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            ListDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], ListDisplayDialog);
            return ListDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.ListDisplayDialog = ListDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ListDisplayEditor = /** @class */ (function (_super) {
            __extends(ListDisplayEditor, _super);
            function ListDisplayEditor(container) {
                return _super.call(this, container) || this;
            }
            ListDisplayEditor.prototype.getColumnsKey = function () { return 'MachineCustomization.ListDisplayEditor'; };
            ListDisplayEditor.prototype.getDialogType = function () { return MachineCustomization.ListDisplayEditorDialog; };
            ListDisplayEditor.prototype.getLocalTextPrefix = function () { return MachineCustomization.ListDisplayRow.localTextPrefix; };
            ListDisplayEditor.prototype.validateEntity = function (row, id) {
                row.ListDisplayId = Q.toId(row.ListDisplayId);
                var items = this.view.getItems();
                if (items.length) {
                    if (this.id(items[0]) !== id) {
                        Q.alert('The properties of the Display Object already exist!');
                        return false;
                    }
                }
                return true;
            };
            ListDisplayEditor = __decorate([
                Serenity.Decorators.registerClass()
            ], ListDisplayEditor);
            return ListDisplayEditor;
        }(CVC.Common.GridEditorBase));
        MachineCustomization.ListDisplayEditor = ListDisplayEditor;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ListDisplayEditorDialog = /** @class */ (function (_super) {
            __extends(ListDisplayEditorDialog, _super);
            function ListDisplayEditorDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.ListDisplayEditorForm(_this.idPrefix);
                return _this;
            }
            ListDisplayEditorDialog.prototype.getFormKey = function () { return MachineCustomization.ListDisplayEditorForm.formKey; };
            ListDisplayEditorDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.ListDisplayRow.localTextPrefix; };
            ListDisplayEditorDialog.prototype.getNameProperty = function () { return MachineCustomization.ListDisplayRow.nameProperty; };
            ListDisplayEditorDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], ListDisplayEditorDialog);
            return ListDisplayEditorDialog;
        }(CVC.Common.GridEditorDialog));
        MachineCustomization.ListDisplayEditorDialog = ListDisplayEditorDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ListDisplayGrid = /** @class */ (function (_super) {
            __extends(ListDisplayGrid, _super);
            function ListDisplayGrid(container) {
                return _super.call(this, container) || this;
            }
            ListDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.ListDisplay'; };
            ListDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.ListDisplayDialog; };
            ListDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.ListDisplayRow.idProperty; };
            ListDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.ListDisplayRow.insertPermission; };
            ListDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.ListDisplayRow.localTextPrefix; };
            ListDisplayGrid.prototype.getService = function () { return MachineCustomization.ListDisplayService.baseUrl; };
            ListDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ListDisplayGrid);
            return ListDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.ListDisplayGrid = ListDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var NotificationDisplayDialog = /** @class */ (function (_super) {
            __extends(NotificationDisplayDialog, _super);
            function NotificationDisplayDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.NotificationDisplayForm(_this.idPrefix);
                return _this;
            }
            NotificationDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.NotificationDisplayForm.formKey; };
            NotificationDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.NotificationDisplayRow.idProperty; };
            NotificationDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.NotificationDisplayRow.localTextPrefix; };
            NotificationDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.NotificationDisplayRow.nameProperty; };
            NotificationDisplayDialog.prototype.getService = function () { return MachineCustomization.NotificationDisplayService.baseUrl; };
            NotificationDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.NotificationDisplayRow.deletePermission; };
            NotificationDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.NotificationDisplayRow.insertPermission; };
            NotificationDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.NotificationDisplayRow.updatePermission; };
            NotificationDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["NotificationDisplayId" /* NotificationDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            NotificationDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], NotificationDisplayDialog);
            return NotificationDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.NotificationDisplayDialog = NotificationDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var NotificationDisplayGrid = /** @class */ (function (_super) {
            __extends(NotificationDisplayGrid, _super);
            function NotificationDisplayGrid(container) {
                var _this = _super.call(this, container) || this;
                var grid = _this.slickGrid;
                // var view = this.view;
                //setTimeout(() => this.slickGrid.setSelectedRows([0]), 1000);
                grid.onSelectedRowsChanged.subscribe(function () {
                    var _a;
                    var selectedRow = grid.getSelectedRows()[0];
                    var record = grid.getDataItem(selectedRow);
                    var doTypeLookup = CVC.Common.CustomEditors.DOTypeLookup;
                    var dot = Q.tryFirst(doTypeLookup, function (x) { return x.text === "Notification Display"; });
                    $('#DisplayObjectTypeId').val(dot.id);
                    $('#SubTypeId').val(record.NotificationDisplayId);
                    console.log("piechartdisplayid = ", record.NotificationDisplayId);
                    // added by Denis for RS 8.3 dated 9/8/2021
                    // Get SecondaryRelationshipGrid widget and destroy it if it exists.
                    var widget = $('#DisplayObjectType_Color').tryGetWidget(MachineCustomization.DisplayObjectTypeColorGrid);
                    (_a = widget) === null || _a === void 0 ? void 0 : _a.destroy();
                    // Init SecondaryRelationshipGrid widget in the element with id 'Secondary_GridDiv'
                    new CVC.MachineCustomization.DisplayObjectTypeColorGrid($('#DisplayObjectType_Color')).init();
                    // $(".quick-filters-bar").hide();
                });
                return _this;
            }
            NotificationDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.NotificationDisplay'; };
            NotificationDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.NotificationDisplayDialog; };
            NotificationDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.NotificationDisplayRow.idProperty; };
            NotificationDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.NotificationDisplayRow.insertPermission; };
            NotificationDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.NotificationDisplayRow.localTextPrefix; };
            NotificationDisplayGrid.prototype.getService = function () { return MachineCustomization.NotificationDisplayService.baseUrl; };
            NotificationDisplayGrid.prototype.getSlickOptions = function () {
                var opt = _super.prototype.getSlickOptions.call(this);
                opt.enableTextSelectionOnCells = true;
                opt.selectedCellCssClass = "slick-row-selected";
                opt.enableCellNavigation = true;
                return opt;
            };
            NotificationDisplayGrid.prototype.createSlickGrid = function () {
                var grid = _super.prototype.createSlickGrid.call(this);
                grid.setSelectionModel(new Slick.RowSelectionModel());
                return grid;
            };
            NotificationDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], NotificationDisplayGrid);
            return NotificationDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.NotificationDisplayGrid = NotificationDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PieChartDisplayDialog = /** @class */ (function (_super) {
            __extends(PieChartDisplayDialog, _super);
            function PieChartDisplayDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.PieChartDisplayForm(_this.idPrefix);
                return _this;
            }
            PieChartDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.PieChartDisplayForm.formKey; };
            PieChartDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.PieChartDisplayRow.idProperty; };
            PieChartDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.PieChartDisplayRow.localTextPrefix; };
            PieChartDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.PieChartDisplayRow.nameProperty; };
            PieChartDisplayDialog.prototype.getService = function () { return MachineCustomization.PieChartDisplayService.baseUrl; };
            PieChartDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.PieChartDisplayRow.deletePermission; };
            PieChartDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.PieChartDisplayRow.insertPermission; };
            PieChartDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.PieChartDisplayRow.updatePermission; };
            PieChartDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["PieChartDisplayId" /* PieChartDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            PieChartDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], PieChartDisplayDialog);
            return PieChartDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.PieChartDisplayDialog = PieChartDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PieChartDisplayGrid = /** @class */ (function (_super) {
            __extends(PieChartDisplayGrid, _super);
            function PieChartDisplayGrid(container) {
                var _this = _super.call(this, container) || this;
                var grid = _this.slickGrid;
                // var view = this.view;
                //setTimeout(() => this.slickGrid.setSelectedRows([0]), 1000);
                grid.onSelectedRowsChanged.subscribe(function () {
                    var _a;
                    var selectedRow = grid.getSelectedRows()[0];
                    var record = grid.getDataItem(selectedRow);
                    var doTypeLookup = CVC.Common.CustomEditors.DOTypeLookup;
                    var dot = Q.tryFirst(doTypeLookup, function (x) { return x.text === "Pie Chart Display"; });
                    $('#DisplayObjectTypeId').val(dot.id);
                    $('#SubTypeId').val(record.PieChartDisplayId);
                    console.log("piechartdisplayid = ", record.PieChartDisplayId);
                    // added by Denis for RS 8.3 dated 9/8/2021
                    // Get SecondaryRelationshipGrid widget and destroy it if it exists.
                    var widget = $('#DisplayObjectType_Color').tryGetWidget(MachineCustomization.DisplayObjectTypeColorGrid);
                    (_a = widget) === null || _a === void 0 ? void 0 : _a.destroy();
                    // Init SecondaryRelationshipGrid widget in the element with id 'Secondary_GridDiv'
                    new CVC.MachineCustomization.DisplayObjectTypeColorGrid($('#DisplayObjectType_Color')).init();
                    // $(".quick-filters-bar").hide();
                });
                return _this;
            }
            PieChartDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.PieChartDisplay'; };
            PieChartDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.PieChartDisplayDialog; };
            PieChartDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.PieChartDisplayRow.idProperty; };
            PieChartDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.PieChartDisplayRow.insertPermission; };
            PieChartDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.PieChartDisplayRow.localTextPrefix; };
            PieChartDisplayGrid.prototype.getService = function () { return MachineCustomization.PieChartDisplayService.baseUrl; };
            PieChartDisplayGrid.prototype.getSlickOptions = function () {
                var opt = _super.prototype.getSlickOptions.call(this);
                opt.enableTextSelectionOnCells = true;
                opt.selectedCellCssClass = "slick-row-selected";
                opt.enableCellNavigation = true;
                return opt;
            };
            PieChartDisplayGrid.prototype.createSlickGrid = function () {
                var grid = _super.prototype.createSlickGrid.call(this);
                grid.setSelectionModel(new Slick.RowSelectionModel());
                return grid;
            };
            PieChartDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], PieChartDisplayGrid);
            return PieChartDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.PieChartDisplayGrid = PieChartDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PrimaryRelationshipDialog = /** @class */ (function (_super) {
            __extends(PrimaryRelationshipDialog, _super);
            function PrimaryRelationshipDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.PrimaryRelationshipForm(_this.idPrefix);
                return _this;
            }
            PrimaryRelationshipDialog.prototype.getFormKey = function () { return MachineCustomization.PrimaryRelationshipForm.formKey; };
            PrimaryRelationshipDialog.prototype.getIdProperty = function () { return MachineCustomization.PrimaryRelationshipRow.idProperty; };
            PrimaryRelationshipDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.PrimaryRelationshipRow.localTextPrefix; };
            PrimaryRelationshipDialog.prototype.getNameProperty = function () { return MachineCustomization.PrimaryRelationshipRow.nameProperty; };
            PrimaryRelationshipDialog.prototype.getService = function () { return MachineCustomization.PrimaryRelationshipService.baseUrl; };
            PrimaryRelationshipDialog.prototype.getDeletePermission = function () { return MachineCustomization.PrimaryRelationshipRow.deletePermission; };
            PrimaryRelationshipDialog.prototype.getInsertPermission = function () { return MachineCustomization.PrimaryRelationshipRow.insertPermission; };
            PrimaryRelationshipDialog.prototype.getUpdatePermission = function () { return MachineCustomization.PrimaryRelationshipRow.updatePermission; };
            PrimaryRelationshipDialog.prototype.getToolbarButtons = function () {
                var _this = this;
                var buttons = _super.prototype.getToolbarButtons.call(this);
                Q.first(buttons, function (x) { return x.cssClass == "delete-button"; }).onClick = function () {
                    var criteria;
                    var res = MachineCustomization.SecondaryRelationshipService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["PrimaryRelationshipId" /* PrimaryRelationshipId */], '=', _this.entityId])
                    }, function (_response) { }, { async: false });
                    var secondaryRelationshipCount = res.responseJSON.TotalCount;
                    if (secondaryRelationshipCount) {
                        Q.alert("There are " + secondaryRelationshipCount + " Secondary Relationships under the selected Primary Relationship.\nYou can not delete the Primary Relationship until there are no Secondary Relationships under it.\n                    ");
                    }
                    else {
                        Q.confirm('Do you want to delete the record?', function () {
                            _this.doDelete(function () {
                                _this.dialogClose();
                            });
                        });
                    }
                };
                return buttons;
            };
            PrimaryRelationshipDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], PrimaryRelationshipDialog);
            return PrimaryRelationshipDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.PrimaryRelationshipDialog = PrimaryRelationshipDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PrimaryRelationshipGrid = /** @class */ (function (_super) {
            __extends(PrimaryRelationshipGrid, _super);
            function PrimaryRelationshipGrid(container) {
                var _this = _super.call(this, container) || this;
                var grid = _this.slickGrid;
                var view = _this.view;
                //setTimeout(() => this.slickGrid.setSelectedRows([0]), 1000);
                grid.onSelectedRowsChanged.subscribe(function () {
                    var _a;
                    var selectedRow = grid.getSelectedRows()[0];
                    var record = grid.getDataItem(selectedRow);
                    // Set the value of hidden tag with id 'PrimaryRelationshipId'
                    $("#PrimaryRelationshipId").val(record.PrimaryRelationshipId);
                    // added by Denis for RS 8.3 dated 9/8/2021
                    // Get SecondaryRelationshipGrid widget and destroy it if it exists.
                    var widget = $('#Secondary_GridDiv').tryGetWidget(MachineCustomization.SecondaryRelationshipGrid);
                    (_a = widget) === null || _a === void 0 ? void 0 : _a.destroy();
                    // Init SecondaryRelationshipGrid widget in the element with id 'Secondary_GridDiv'
                    new CVC.MachineCustomization.SecondaryRelationshipGrid($('#Secondary_GridDiv')).init();
                    $(".quick-filters-bar").hide();
                });
                /*
                 * When creating a new row, the created row is selected
                 * When deleting a row, the row above the deleted row is selected.**/
                var row_count, old_row_count = 0;
                view.onDataChanged.subscribe(function (e, args) {
                    row_count = view.getLength();
                    var selectedRows = grid.getSelectedRows();
                    var row_nums = Array.from({ length: row_count }, function (_, i) { return i; });
                    var row_ids = row_nums.map(function (x) { return grid.getDataItem(x).PrimaryRelationshipId; });
                    var row_id_num_pairs = row_nums.reduce(function (prev, cur) {
                        var key = grid.getDataItem(cur).PrimaryRelationshipId;
                        var obj = {};
                        obj[key] = cur;
                        return __assign(__assign({}, prev), obj);
                    }, {});
                    var max_row_id = Math.max.apply(Math, row_ids);
                    if (row_count > 0) {
                        if (row_count > old_row_count) {
                            //grid.setSelectedRows([row_count - 1]);
                            grid.setSelectedRows([row_id_num_pairs[max_row_id]]);
                        }
                        if ((row_count < old_row_count) && (selectedRows.length > 0)) {
                            var row_idx = (selectedRows[0] - 1) < 0 ? 0 : selectedRows[0] - 1;
                            grid.setSelectedRows([row_idx]);
                        }
                    }
                    old_row_count = row_count;
                    /*
                    var selectedRows = grid.getSelectedRows();
    
                    if (row_count == 0) return
    
                    // For When the first row is been creating
                    if ((selectedRows.length == 0) ||
                        (selectedRows.length > 0 && selectedRows[0] == 0))
                    {
                        grid.setSelectedRows([0]);
                    }
    
                    // For row deleting
                    if (selectedRows.length > 0 && selectedRows[0] == row_count)
                    {
                        grid.setSelectedRows([row_count - 1]);
                    }*/
                });
                return _this;
                // Forece select a row of active cell
                //grid.onActiveCellChanged.subscribe((e, args) => {
                //    grid.setSelectedRows([args.row]);
                //});
            }
            PrimaryRelationshipGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.PrimaryRelationship'; };
            PrimaryRelationshipGrid.prototype.getDialogType = function () { return MachineCustomization.PrimaryRelationshipDialog; };
            PrimaryRelationshipGrid.prototype.getIdProperty = function () { return MachineCustomization.PrimaryRelationshipRow.idProperty; };
            PrimaryRelationshipGrid.prototype.getInsertPermission = function () { return MachineCustomization.PrimaryRelationshipRow.insertPermission; };
            PrimaryRelationshipGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.PrimaryRelationshipRow.localTextPrefix; };
            PrimaryRelationshipGrid.prototype.getService = function () { return MachineCustomization.PrimaryRelationshipService.baseUrl; };
            /* Below two functions make SlickGrid row selectable
             * https://github.com/serenity-is/Serenity/issues/1241
             * ******************************************************************************/
            PrimaryRelationshipGrid.prototype.getSlickOptions = function () {
                var opt = _super.prototype.getSlickOptions.call(this);
                opt.enableTextSelectionOnCells = true;
                opt.selectedCellCssClass = "slick-row-selected";
                opt.enableCellNavigation = true;
                return opt;
            };
            PrimaryRelationshipGrid.prototype.createSlickGrid = function () {
                var grid = _super.prototype.createSlickGrid.call(this);
                grid.setSelectionModel(new Slick.RowSelectionModel());
                return grid;
            };
            PrimaryRelationshipGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], PrimaryRelationshipGrid);
            return PrimaryRelationshipGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.PrimaryRelationshipGrid = PrimaryRelationshipGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var PrimaryRelationshipLookupEditor = /** @class */ (function (_super) {
            __extends(PrimaryRelationshipLookupEditor, _super);
            function PrimaryRelationshipLookupEditor(container, opt) {
                return _super.call(this, container, opt) || this;
            }
            PrimaryRelationshipLookupEditor.prototype.getLookupKey = function () {
                return "MachineCustomization.PrimaryRelationship";
                //return "MachineCustomization.PrimaryRelationshipLookup";
            };
            PrimaryRelationshipLookupEditor.prototype.getItems = function (lookup) {
                var customLookup = Q.getLookup(this.getLookupKey());
                var items = _super.prototype.getItems.call(this, customLookup);
                /*
                 * I tried to show lookup without caching by adding Expiration = TimeSpan.FromDays(-1)
                 * but no luck.
                 * so decided to use below service call
                 * **/
                var res = MachineCustomization.PrimaryRelationshipService.List({
                    ColumnSelection: 1,
                    IncludeColumns: ["PrimaryRelationshipId", "RelationshipName"]
                }, function (_response) { }, { async: false });
                var itms = res.responseJSON.Entities;
                return itms;
            };
            PrimaryRelationshipLookupEditor = __decorate([
                Serenity.Decorators.registerEditor()
            ], PrimaryRelationshipLookupEditor);
            return PrimaryRelationshipLookupEditor;
        }(Serenity.LookupEditorBase));
        MachineCustomization.PrimaryRelationshipLookupEditor = PrimaryRelationshipLookupEditor;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RealtimeParameterDisplayDialog = /** @class */ (function (_super) {
            __extends(RealtimeParameterDisplayDialog, _super);
            function RealtimeParameterDisplayDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.RealtimeParameterDisplayForm(_this.idPrefix);
                return _this;
            }
            RealtimeParameterDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.RealtimeParameterDisplayForm.formKey; };
            RealtimeParameterDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.RealtimeParameterDisplayRow.idProperty; };
            RealtimeParameterDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.RealtimeParameterDisplayRow.localTextPrefix; };
            RealtimeParameterDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.RealtimeParameterDisplayRow.nameProperty; };
            RealtimeParameterDisplayDialog.prototype.getService = function () { return MachineCustomization.RealtimeParameterDisplayService.baseUrl; };
            RealtimeParameterDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.RealtimeParameterDisplayRow.deletePermission; };
            RealtimeParameterDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.RealtimeParameterDisplayRow.insertPermission; };
            RealtimeParameterDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.RealtimeParameterDisplayRow.updatePermission; };
            RealtimeParameterDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["RealtimeParameterDisplayId" /* RealtimeParameterDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            RealtimeParameterDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], RealtimeParameterDisplayDialog);
            return RealtimeParameterDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.RealtimeParameterDisplayDialog = RealtimeParameterDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var RealtimeParameterDisplayGrid = /** @class */ (function (_super) {
            __extends(RealtimeParameterDisplayGrid, _super);
            function RealtimeParameterDisplayGrid(container) {
                var _this = _super.call(this, container) || this;
                var grid = _this.slickGrid;
                // var view = this.view;
                //setTimeout(() => this.slickGrid.setSelectedRows([0]), 1000);
                grid.onSelectedRowsChanged.subscribe(function () {
                    var _a;
                    var selectedRow = grid.getSelectedRows()[0];
                    var record = grid.getDataItem(selectedRow);
                    var doTypeLookup = CVC.Common.CustomEditors.DOTypeLookup;
                    var dot = Q.tryFirst(doTypeLookup, function (x) { return x.text === "Realtime Parameter Display"; });
                    $('#DisplayObjectTypeId').val(dot.id);
                    $('#SubTypeId').val(record.RealtimeParameterDisplayId);
                    console.log("RealtimeParameterDisplayId = ", record.RealtimeParameterDisplayId);
                    // added by Denis for RS 8.3 dated 9/8/2021
                    // Get SecondaryRelationshipGrid widget and destroy it if it exists.
                    var widget = $('#DisplayObjectType_Color').tryGetWidget(MachineCustomization.DisplayObjectTypeColorGrid);
                    (_a = widget) === null || _a === void 0 ? void 0 : _a.destroy();
                    // Init SecondaryRelationshipGrid widget in the element with id 'Secondary_GridDiv'
                    new CVC.MachineCustomization.DisplayObjectTypeColorGrid($('#DisplayObjectType_Color')).init();
                    // $(".quick-filters-bar").hide();
                });
                return _this;
            }
            RealtimeParameterDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.RealtimeParameterDisplay'; };
            RealtimeParameterDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.RealtimeParameterDisplayDialog; };
            RealtimeParameterDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.RealtimeParameterDisplayRow.idProperty; };
            RealtimeParameterDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.RealtimeParameterDisplayRow.insertPermission; };
            RealtimeParameterDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.RealtimeParameterDisplayRow.localTextPrefix; };
            RealtimeParameterDisplayGrid.prototype.getService = function () { return MachineCustomization.RealtimeParameterDisplayService.baseUrl; };
            RealtimeParameterDisplayGrid.prototype.getSlickOptions = function () {
                var opt = _super.prototype.getSlickOptions.call(this);
                opt.enableTextSelectionOnCells = true;
                opt.selectedCellCssClass = "slick-row-selected";
                opt.enableCellNavigation = true;
                return opt;
            };
            RealtimeParameterDisplayGrid.prototype.createSlickGrid = function () {
                var grid = _super.prototype.createSlickGrid.call(this);
                grid.setSelectionModel(new Slick.RowSelectionModel());
                return grid;
            };
            RealtimeParameterDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], RealtimeParameterDisplayGrid);
            return RealtimeParameterDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.RealtimeParameterDisplayGrid = RealtimeParameterDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ScreenViewsDialog = /** @class */ (function (_super) {
            __extends(ScreenViewsDialog, _super);
            function ScreenViewsDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.ScreenViewsForm(_this.idPrefix);
                return _this;
            }
            ScreenViewsDialog.prototype.getFormKey = function () { return MachineCustomization.ScreenViewsForm.formKey; };
            ScreenViewsDialog.prototype.getIdProperty = function () { return MachineCustomization.ScreenViewsRow.idProperty; };
            ScreenViewsDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.ScreenViewsRow.localTextPrefix; };
            ScreenViewsDialog.prototype.getNameProperty = function () { return MachineCustomization.ScreenViewsRow.nameProperty; };
            ScreenViewsDialog.prototype.getService = function () { return MachineCustomization.ScreenViewsService.baseUrl; };
            ScreenViewsDialog.prototype.getDeletePermission = function () { return MachineCustomization.ScreenViewsRow.deletePermission; };
            ScreenViewsDialog.prototype.getInsertPermission = function () { return MachineCustomization.ScreenViewsRow.insertPermission; };
            ScreenViewsDialog.prototype.getUpdatePermission = function () { return MachineCustomization.ScreenViewsRow.updatePermission; };
            ScreenViewsDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], ScreenViewsDialog);
            return ScreenViewsDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.ScreenViewsDialog = ScreenViewsDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var ScreenViewsGrid = /** @class */ (function (_super) {
            __extends(ScreenViewsGrid, _super);
            function ScreenViewsGrid(container) {
                return _super.call(this, container) || this;
            }
            ScreenViewsGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.ScreenViews'; };
            ScreenViewsGrid.prototype.getDialogType = function () { return MachineCustomization.ScreenViewsDialog; };
            ScreenViewsGrid.prototype.getIdProperty = function () { return MachineCustomization.ScreenViewsRow.idProperty; };
            ScreenViewsGrid.prototype.getInsertPermission = function () { return MachineCustomization.ScreenViewsRow.insertPermission; };
            ScreenViewsGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.ScreenViewsRow.localTextPrefix; };
            ScreenViewsGrid.prototype.getService = function () { return MachineCustomization.ScreenViewsService.baseUrl; };
            ScreenViewsGrid.prototype.getColumns = function () {
                var columns = _super.prototype.getColumns.call(this);
                columns.push({
                    field: 'Design Mode',
                    name: 'Design Mode',
                    format: function (ctx) { return '<button type="button" class="btn btn-primary design-mode">Design Mode</button>'; },
                    width: 120,
                    minWidth: 120,
                    maxWidth: 120
                });
                return columns;
            };
            ScreenViewsGrid.prototype.getSlickOptions = function () {
                var opt = _super.prototype.getSlickOptions.call(this);
                opt.rowHeight = 40;
                return opt;
            };
            ScreenViewsGrid.prototype.onClick = function (e, row, cell) {
                _super.prototype.onClick.call(this, e, row, cell);
                if (e.isDefaultPrevented())
                    return;
                if ($(e.target).hasClass("design-mode")) {
                    Q.notifyInfo("Design Mode selected");
                }
            };
            ScreenViewsGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], ScreenViewsGrid);
            return ScreenViewsGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.ScreenViewsGrid = ScreenViewsGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 8.7 and RS 8.8 dated 9/22/2021
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var SecondaryBELookupEditor = /** @class */ (function (_super) {
            __extends(SecondaryBELookupEditor, _super);
            function SecondaryBELookupEditor(container, opt) {
                return _super.call(this, container, opt) || this;
            }
            SecondaryBELookupEditor.prototype.getLookupKey = function () {
                return "MachineCustomization.Machine";
            };
            SecondaryBELookupEditor.prototype.getItems = function (lookup) {
                var _this = this;
                var criteria;
                var res = MachineCustomization.SecondaryRelationshipService.List({
                    Criteria: Serenity.Criteria.and(criteria, [["PrimaryRelationshipId" /* PrimaryRelationshipId */], '=', this.primaryRelationshipId]),
                    ColumnSelection: 1,
                    IncludeColumns: ["SecondaryBE"]
                }, function (_response) { }, { async: false });
                // Get used BE ids
                var usedBEs = res.responseJSON.Entities.map(function (x) { return x.SecondaryBe; });
                usedBEs = usedBEs.filter(function (x) { return x != _this.includeBE; });
                var customLookup = Q.getLookup(this.getLookupKey());
                var items = _super.prototype.getItems.call(this, customLookup);
                // The used BEs should be excluded from the dropdown
                items = items.filter(function (x) { return !usedBEs.includes(x.MachineId); });
                return items;
            };
            SecondaryBELookupEditor = __decorate([
                Serenity.Decorators.registerEditor()
            ], SecondaryBELookupEditor);
            return SecondaryBELookupEditor;
        }(Serenity.LookupEditorBase));
        MachineCustomization.SecondaryBELookupEditor = SecondaryBELookupEditor;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
// added by Denis for RS 8.7 and RS 8.8 dated 9/11/2021
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var SecondaryEFLookupEditor = /** @class */ (function (_super) {
            __extends(SecondaryEFLookupEditor, _super);
            function SecondaryEFLookupEditor(container, opt) {
                return _super.call(this, container, opt) || this;
            }
            SecondaryEFLookupEditor.prototype.getLookupKey = function () {
                return "MachineCustomization.MachineParameter";
            };
            SecondaryEFLookupEditor.prototype.getItems = function (lookup) {
                var _this = this;
                var criteria;
                var res = MachineCustomization.SecondaryRelationshipService.List({
                    Criteria: Serenity.Criteria.and(criteria, [["PrimaryRelationshipId" /* PrimaryRelationshipId */], '=', this.primaryRelationshipId], [["SecondaryBe" /* SecondaryBe */], '=', this.secondaryBE]),
                    ColumnSelection: 1,
                    IncludeColumns: ["SecondaryEF"]
                }, function (_response) { }, { async: false });
                // Get used EF ids
                var usedEFs = res.responseJSON.Entities.map(function (x) { return x.SecondaryEf; });
                usedEFs = usedEFs.filter(function (x) { return x != _this.includeEF; });
                var customLookup = Q.getLookup("MachineCustomization.MachineParameter");
                var items = _super.prototype.getItems.call(this, customLookup);
                // The used EFs should be excluded from the dropdown
                items = items.filter(function (x) { return Q.toId(x.MachineId) == _this.secondaryBE && !usedEFs.includes(x.MachineParameterId); });
                return items;
            };
            SecondaryEFLookupEditor = __decorate([
                Serenity.Decorators.registerEditor()
            ], SecondaryEFLookupEditor);
            return SecondaryEFLookupEditor;
        }(Serenity.LookupEditorBase));
        MachineCustomization.SecondaryEFLookupEditor = SecondaryEFLookupEditor;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var SecondaryRelationshipDialog = /** @class */ (function (_super) {
            __extends(SecondaryRelationshipDialog, _super);
            function SecondaryRelationshipDialog() {
                var _this = _super.call(this) || this;
                _this.form = new MachineCustomization.SecondaryRelationshipForm(_this.idPrefix);
                return _this;
            }
            SecondaryRelationshipDialog.prototype.getFormKey = function () { return MachineCustomization.SecondaryRelationshipForm.formKey; };
            SecondaryRelationshipDialog.prototype.getIdProperty = function () { return MachineCustomization.SecondaryRelationshipRow.idProperty; };
            SecondaryRelationshipDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.SecondaryRelationshipRow.localTextPrefix; };
            SecondaryRelationshipDialog.prototype.getNameProperty = function () { return MachineCustomization.SecondaryRelationshipRow.nameProperty; };
            SecondaryRelationshipDialog.prototype.getService = function () { return MachineCustomization.SecondaryRelationshipService.baseUrl; };
            SecondaryRelationshipDialog.prototype.getDeletePermission = function () { return MachineCustomization.SecondaryRelationshipRow.deletePermission; };
            SecondaryRelationshipDialog.prototype.getInsertPermission = function () { return MachineCustomization.SecondaryRelationshipRow.insertPermission; };
            SecondaryRelationshipDialog.prototype.getUpdatePermission = function () { return MachineCustomization.SecondaryRelationshipRow.updatePermission; };
            SecondaryRelationshipDialog.prototype.afterLoadEntity = function () {
                var _this = this;
                _super.prototype.afterLoadEntity.call(this);
                //if (this.isNew()) {
                if ($("#PrimaryRelationshipId").val()) {
                    this.form.PrimaryRelationshipId.set_value($("#PrimaryRelationshipId").val());
                    Serenity.EditorUtils.setReadOnly(this.form.PrimaryRelationshipId, true);
                }
                //}
                var secondaryBE = this.form.SecondaryBe.value;
                var secondaryEf = null;
                /*
                 * [Weird thing]
                 * In the below statement, secondaryEf is empty string.
                 * So the SecondaryRelationshipService.Retrieve is used to get SecondaryEf **/
                //secondaryEf = this.form.SecondaryEf.value;
                if (!this.isNew()) {
                    var res = MachineCustomization.SecondaryRelationshipService.Retrieve({ EntityId: this.entityId, ColumnSelection: 1, IncludeColumns: ["SecondaryEf"] }, function (_response) { }, { async: false });
                    secondaryEf = res.responseJSON.Entity.SecondaryEf;
                }
                this.form.SecondaryEf.primaryRelationshipId = $("#PrimaryRelationshipId").val();
                this.form.SecondaryEf.secondaryBE = Q.toId(secondaryBE);
                if (!this.isNew() && secondaryEf)
                    this.form.SecondaryEf.includeEF = Q.toId(secondaryEf);
                this.form.SecondaryEf.updateItems();
                this.form.SecondaryEf.value = secondaryEf;
                this.form.SecondaryBe.changeSelect2(function (e) {
                    var secondaryBE = _this.form.SecondaryBe.value;
                    // Clear old value
                    _this.form.SecondaryEf.value = null;
                    _this.form.SecondaryEf.primaryRelationshipId = $("#PrimaryRelationshipId").val();
                    _this.form.SecondaryEf.secondaryBE = Q.toId(secondaryBE);
                    _this.form.SecondaryEf.updateItems();
                });
                this.form.SecondaryBe.primaryRelationshipId = $("#PrimaryRelationshipId").val();
                this.form.SecondaryBe.includeBE = Q.toId(secondaryBE);
                this.form.SecondaryBe.updateItems();
            };
            SecondaryRelationshipDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], SecondaryRelationshipDialog);
            return SecondaryRelationshipDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.SecondaryRelationshipDialog = SecondaryRelationshipDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var SecondaryRelationshipGrid = /** @class */ (function (_super) {
            __extends(SecondaryRelationshipGrid, _super);
            function SecondaryRelationshipGrid(container) {
                return _super.call(this, container) || this;
            }
            SecondaryRelationshipGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.SecondaryRelationship'; };
            SecondaryRelationshipGrid.prototype.getDialogType = function () { return MachineCustomization.SecondaryRelationshipDialog; };
            SecondaryRelationshipGrid.prototype.getIdProperty = function () { return MachineCustomization.SecondaryRelationshipRow.idProperty; };
            SecondaryRelationshipGrid.prototype.getInsertPermission = function () { return MachineCustomization.SecondaryRelationshipRow.insertPermission; };
            SecondaryRelationshipGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.SecondaryRelationshipRow.localTextPrefix; };
            SecondaryRelationshipGrid.prototype.getService = function () { return MachineCustomization.SecondaryRelationshipService.baseUrl; };
            SecondaryRelationshipGrid.prototype.onViewSubmit = function () {
                if (!_super.prototype.onViewSubmit.call(this)) {
                    return false;
                }
                var request = this.view.params;
                var primaryId = parseInt($("#PrimaryRelationshipId").val());
                //$("#PrimaryRelationshipId").val("");
                if (primaryId)
                    request.EqualityFilter.PrimaryRelationshipId = primaryId;
                return true;
            };
            SecondaryRelationshipGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], SecondaryRelationshipGrid);
            return SecondaryRelationshipGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.SecondaryRelationshipGrid = SecondaryRelationshipGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var TreeDisplayDialog = /** @class */ (function (_super) {
            __extends(TreeDisplayDialog, _super);
            function TreeDisplayDialog() {
                var _this = _super !== null && _super.apply(this, arguments) || this;
                _this.form = new MachineCustomization.TreeDisplayForm(_this.idPrefix);
                return _this;
            }
            TreeDisplayDialog.prototype.getFormKey = function () { return MachineCustomization.TreeDisplayForm.formKey; };
            TreeDisplayDialog.prototype.getIdProperty = function () { return MachineCustomization.TreeDisplayRow.idProperty; };
            TreeDisplayDialog.prototype.getLocalTextPrefix = function () { return MachineCustomization.TreeDisplayRow.localTextPrefix; };
            TreeDisplayDialog.prototype.getNameProperty = function () { return MachineCustomization.TreeDisplayRow.nameProperty; };
            TreeDisplayDialog.prototype.getService = function () { return MachineCustomization.TreeDisplayService.baseUrl; };
            TreeDisplayDialog.prototype.getDeletePermission = function () { return MachineCustomization.TreeDisplayRow.deletePermission; };
            TreeDisplayDialog.prototype.getInsertPermission = function () { return MachineCustomization.TreeDisplayRow.insertPermission; };
            TreeDisplayDialog.prototype.getUpdatePermission = function () { return MachineCustomization.TreeDisplayRow.updatePermission; };
            TreeDisplayDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = MachineCustomization.DisplayObjectService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["TreeDisplayId" /* TreeDisplayId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in DisplayObject.
                    if (res.responseJSON.Entities.length) {
                        this.toolbar.findButton("delete-button").remove();
                    }
                }
            };
            TreeDisplayDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], TreeDisplayDialog);
            return TreeDisplayDialog;
        }(Serenity.EntityDialog));
        MachineCustomization.TreeDisplayDialog = TreeDisplayDialog;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var MachineCustomization;
    (function (MachineCustomization) {
        var TreeDisplayGrid = /** @class */ (function (_super) {
            __extends(TreeDisplayGrid, _super);
            function TreeDisplayGrid(container) {
                return _super.call(this, container) || this;
            }
            TreeDisplayGrid.prototype.getColumnsKey = function () { return 'MachineCustomization.TreeDisplay'; };
            TreeDisplayGrid.prototype.getDialogType = function () { return MachineCustomization.TreeDisplayDialog; };
            TreeDisplayGrid.prototype.getIdProperty = function () { return MachineCustomization.TreeDisplayRow.idProperty; };
            TreeDisplayGrid.prototype.getInsertPermission = function () { return MachineCustomization.TreeDisplayRow.insertPermission; };
            TreeDisplayGrid.prototype.getLocalTextPrefix = function () { return MachineCustomization.TreeDisplayRow.localTextPrefix; };
            TreeDisplayGrid.prototype.getService = function () { return MachineCustomization.TreeDisplayService.baseUrl; };
            TreeDisplayGrid = __decorate([
                Serenity.Decorators.registerClass()
            ], TreeDisplayGrid);
            return TreeDisplayGrid;
        }(CVC.Common.Bases.GridBase));
        MachineCustomization.TreeDisplayGrid = TreeDisplayGrid;
    })(MachineCustomization = CVC.MachineCustomization || (CVC.MachineCustomization = {}));
})(CVC || (CVC = {}));
var CVC;
(function (CVC) {
    var PackSettings;
    (function (PackSettings) {
        var BottleDialog = /** @class */ (function (_super) {
            __extends(BottleDialog, _super);
            function BottleDialog() {
                var _this = _super.call(this) || this;
                _this.form = new PackSettings.BottleForm(_this.idPrefix);
                return _this;
            }
            BottleDialog.prototype.getFormKey = function () { return PackSettings.BottleForm.formKey; };
            BottleDialog.prototype.getIdProperty = function () { return PackSettings.BottleRow.idProperty; };
            BottleDialog.prototype.getLocalTextPrefix = function () { return PackSettings.BottleRow.localTextPrefix; };
            BottleDialog.prototype.getNameProperty = function () { return PackSettings.BottleRow.nameProperty; };
            BottleDialog.prototype.getService = function () { return PackSettings.BottleService.baseUrl; };
            BottleDialog.prototype.getDeletePermission = function () { return PackSettings.BottleRow.deletePermission; };
            BottleDialog.prototype.getInsertPermission = function () { return PackSettings.BottleRow.insertPermission; };
            BottleDialog.prototype.getUpdatePermission = function () { return PackSettings.BottleRow.updatePermission; };
            BottleDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = PackSettings.BottleService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["BottleId" /* BottleId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in Bottle
                    // if (res.responseJSON.Entities.length) {
                    //     this.toolbar.findButton("delete-button").remove()
                    // }
                }
            };
            BottleDialog = __decorate([
                Serenity.Decorators.registerClass()
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
        var CapDialog = /** @class */ (function (_super) {
            __extends(CapDialog, _super);
            function CapDialog() {
                var _this = _super.call(this) || this;
                _this.form = new PackSettings.CapForm(_this.idPrefix);
                return _this;
            }
            CapDialog.prototype.getFormKey = function () { return PackSettings.CapForm.formKey; };
            CapDialog.prototype.getIdProperty = function () { return PackSettings.CapRow.idProperty; };
            CapDialog.prototype.getLocalTextPrefix = function () { return PackSettings.CapRow.localTextPrefix; };
            CapDialog.prototype.getNameProperty = function () { return PackSettings.CapRow.nameProperty; };
            CapDialog.prototype.getService = function () { return PackSettings.CapService.baseUrl; };
            CapDialog.prototype.getDeletePermission = function () { return PackSettings.CapRow.deletePermission; };
            CapDialog.prototype.getInsertPermission = function () { return PackSettings.CapRow.insertPermission; };
            CapDialog.prototype.getUpdatePermission = function () { return PackSettings.CapRow.updatePermission; };
            CapDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = PackSettings.CapService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["CapId" /* CapId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in Bottle
                    // if (res.responseJSON.Entities.length) {
                    //     this.toolbar.findButton("delete-button").remove()
                    // }
                }
            };
            CapDialog = __decorate([
                Serenity.Decorators.registerClass()
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
        var CottonDialog = /** @class */ (function (_super) {
            __extends(CottonDialog, _super);
            function CottonDialog() {
                var _this = _super.call(this) || this;
                _this.form = new PackSettings.CottonForm(_this.idPrefix);
                return _this;
            }
            CottonDialog.prototype.getFormKey = function () { return PackSettings.CottonForm.formKey; };
            CottonDialog.prototype.getIdProperty = function () { return PackSettings.CottonRow.idProperty; };
            CottonDialog.prototype.getLocalTextPrefix = function () { return PackSettings.CottonRow.localTextPrefix; };
            CottonDialog.prototype.getNameProperty = function () { return PackSettings.CottonRow.nameProperty; };
            CottonDialog.prototype.getService = function () { return PackSettings.CottonService.baseUrl; };
            CottonDialog.prototype.getDeletePermission = function () { return PackSettings.CottonRow.deletePermission; };
            CottonDialog.prototype.getInsertPermission = function () { return PackSettings.CottonRow.insertPermission; };
            CottonDialog.prototype.getUpdatePermission = function () { return PackSettings.CottonRow.updatePermission; };
            CottonDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = PackSettings.CottonService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["CottonId" /* CottonId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in Bottle
                    // if (res.responseJSON.Entities.length) {
                    //     this.toolbar.findButton("delete-button").remove()
                    // }
                }
            };
            CottonDialog = __decorate([
                Serenity.Decorators.registerClass()
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
        var DesiccantDialog = /** @class */ (function (_super) {
            __extends(DesiccantDialog, _super);
            function DesiccantDialog() {
                var _this = _super.call(this) || this;
                _this.form = new PackSettings.DesiccantForm(_this.idPrefix);
                return _this;
            }
            DesiccantDialog.prototype.getFormKey = function () { return PackSettings.DesiccantForm.formKey; };
            DesiccantDialog.prototype.getIdProperty = function () { return PackSettings.DesiccantRow.idProperty; };
            DesiccantDialog.prototype.getLocalTextPrefix = function () { return PackSettings.DesiccantRow.localTextPrefix; };
            DesiccantDialog.prototype.getNameProperty = function () { return PackSettings.DesiccantRow.nameProperty; };
            DesiccantDialog.prototype.getService = function () { return PackSettings.DesiccantService.baseUrl; };
            DesiccantDialog.prototype.getDeletePermission = function () { return PackSettings.DesiccantRow.deletePermission; };
            DesiccantDialog.prototype.getInsertPermission = function () { return PackSettings.DesiccantRow.insertPermission; };
            DesiccantDialog.prototype.getUpdatePermission = function () { return PackSettings.DesiccantRow.updatePermission; };
            DesiccantDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = PackSettings.DesiccantService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["DesiccantId" /* DesiccantId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in Bottle
                    // if (res.responseJSON.Entities.length) {
                    //     this.toolbar.findButton("delete-button").remove()
                    // }
                }
            };
            DesiccantDialog = __decorate([
                Serenity.Decorators.registerClass()
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
        var EndOfLineDialog = /** @class */ (function (_super) {
            __extends(EndOfLineDialog, _super);
            function EndOfLineDialog() {
                var _this = _super.call(this) || this;
                _this.form = new PackSettings.EndOfLineForm(_this.idPrefix);
                return _this;
            }
            EndOfLineDialog.prototype.getFormKey = function () { return PackSettings.EndOfLineForm.formKey; };
            EndOfLineDialog.prototype.getIdProperty = function () { return PackSettings.EndOfLineRow.idProperty; };
            EndOfLineDialog.prototype.getLocalTextPrefix = function () { return PackSettings.EndOfLineRow.localTextPrefix; };
            EndOfLineDialog.prototype.getNameProperty = function () { return PackSettings.EndOfLineRow.nameProperty; };
            EndOfLineDialog.prototype.getService = function () { return PackSettings.EndOfLineService.baseUrl; };
            EndOfLineDialog.prototype.getDeletePermission = function () { return PackSettings.EndOfLineRow.deletePermission; };
            EndOfLineDialog.prototype.getInsertPermission = function () { return PackSettings.EndOfLineRow.insertPermission; };
            EndOfLineDialog.prototype.getUpdatePermission = function () { return PackSettings.EndOfLineRow.updatePermission; };
            EndOfLineDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = PackSettings.EndOfLineService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["EndOfLineId" /* EndOfLineId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in Bottle
                    // if (res.responseJSON.Entities.length) {
                    //     this.toolbar.findButton("delete-button").remove()
                    // }
                }
            };
            EndOfLineDialog = __decorate([
                Serenity.Decorators.registerClass()
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
        var PackDialog = /** @class */ (function (_super) {
            __extends(PackDialog, _super);
            function PackDialog() {
                var _this = _super.call(this) || this;
                _this.form = new PackSettings.PackForm(_this.idPrefix);
                return _this;
            }
            PackDialog.prototype.getFormKey = function () { return PackSettings.PackForm.formKey; };
            PackDialog.prototype.getIdProperty = function () { return PackSettings.PackRow.idProperty; };
            PackDialog.prototype.getLocalTextPrefix = function () { return PackSettings.PackRow.localTextPrefix; };
            PackDialog.prototype.getNameProperty = function () { return PackSettings.PackRow.nameProperty; };
            PackDialog.prototype.getService = function () { return PackSettings.PackService.baseUrl; };
            PackDialog.prototype.getDeletePermission = function () { return PackSettings.PackRow.deletePermission; };
            PackDialog.prototype.getInsertPermission = function () { return PackSettings.PackRow.insertPermission; };
            PackDialog.prototype.getUpdatePermission = function () { return PackSettings.PackRow.updatePermission; };
            PackDialog.prototype.afterLoadEntity = function () {
                _super.prototype.afterLoadEntity.call(this);
                /*
                 * isNew() function works properly in afterLoadEntity() function
                 * **/
                if (!this.isNew()) {
                    var criteria;
                    var res = PackSettings.PackService.List({
                        Criteria: Serenity.Criteria.and(criteria, [["PackId" /* PackId */], '=', this.entityId])
                    }, function (_response) { }, { async: false });
                    // Cannot delete the entity if it is already referenced in Bottle
                    // if (res.responseJSON.Entities.length) {
                    //     this.toolbar.findButton("delete-button").remove()
                    // }
                }
            };
            PackDialog = __decorate([
                Serenity.Decorators.registerClass()
            ], PackDialog);
            return PackDialog;
        }(Serenity.EntityDialog));
        PackSettings.PackDialog = PackDialog;
    })(PackSettings = CVC.PackSettings || (CVC.PackSettings = {}));
})(CVC || (CVC = {}));
//# sourceMappingURL=Jsguru.Web.js.map