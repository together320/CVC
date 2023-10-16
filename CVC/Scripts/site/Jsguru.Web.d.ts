/// <reference types="jquery" />
/// <reference types="jqueryui" />
declare namespace CVC.Administration {
}
declare namespace CVC.Administration {
    interface AdminFormForm {
        FormName: Serenity.StringEditor;
    }
    class AdminFormForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Administration {
    interface AdminFormRow {
        AdminFormId?: number;
        FormName?: string;
    }
    namespace AdminFormRow {
        const idProperty = "AdminFormId";
        const nameProperty = "FormName";
        const localTextPrefix = "Administration.AdminForm";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            AdminFormId = "AdminFormId",
            FormName = "FormName"
        }
    }
}
declare namespace CVC.Administration {
    namespace AdminFormService {
        const baseUrl = "Administration/AdminForm";
        function Create(request: Serenity.SaveRequest<AdminFormRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<AdminFormRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AdminFormRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AdminFormRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Administration/AdminForm/Create",
            Update = "Administration/AdminForm/Update",
            Delete = "Administration/AdminForm/Delete",
            Retrieve = "Administration/AdminForm/Retrieve",
            List = "Administration/AdminForm/List"
        }
    }
}
declare namespace CVC.Administration {
}
declare namespace CVC.Administration {
    interface ModuleAccessForm {
        ModuleId: Serenity.IntegerEditor;
        RoleId: Serenity.IntegerEditor;
        IsAccess: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class ModuleAccessForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Administration {
    interface ModuleAccessRow {
        ModuleAccessId?: number;
        ModuleId?: number;
        RoleId?: number;
        IsAccess?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        ModuleModuleName?: string;
        ModuleMachineId?: number;
        ModuleStatusId?: number;
        ModuleCreatedBy?: number;
        ModuleCreatedDate?: string;
        ModuleUpdatedBy?: number;
        ModuleUpdatedDate?: string;
        RoleRoleName?: string;
        RoleStatusId?: number;
        RoleIsHidden?: number;
        RoleParentRoleId?: number;
        RoleCreatedBy?: number;
        RoleCreatedDate?: string;
        RoleUpdatedBy?: number;
        RoleUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace ModuleAccessRow {
        const idProperty = "ModuleAccessId";
        const localTextPrefix = "Administration.ModuleAccess";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            ModuleAccessId = "ModuleAccessId",
            ModuleId = "ModuleId",
            RoleId = "RoleId",
            IsAccess = "IsAccess",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            ModuleModuleName = "ModuleModuleName",
            ModuleMachineId = "ModuleMachineId",
            ModuleStatusId = "ModuleStatusId",
            ModuleCreatedBy = "ModuleCreatedBy",
            ModuleCreatedDate = "ModuleCreatedDate",
            ModuleUpdatedBy = "ModuleUpdatedBy",
            ModuleUpdatedDate = "ModuleUpdatedDate",
            RoleRoleName = "RoleRoleName",
            RoleStatusId = "RoleStatusId",
            RoleIsHidden = "RoleIsHidden",
            RoleParentRoleId = "RoleParentRoleId",
            RoleCreatedBy = "RoleCreatedBy",
            RoleCreatedDate = "RoleCreatedDate",
            RoleUpdatedBy = "RoleUpdatedBy",
            RoleUpdatedDate = "RoleUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.Administration {
    namespace ModuleAccessService {
        const baseUrl = "Administration/ModuleAccess";
        function Create(request: Serenity.SaveRequest<ModuleAccessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ModuleAccessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ModuleAccessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ModuleAccessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Administration/ModuleAccess/Create",
            Update = "Administration/ModuleAccess/Update",
            Delete = "Administration/ModuleAccess/Delete",
            Retrieve = "Administration/ModuleAccess/Retrieve",
            List = "Administration/ModuleAccess/List"
        }
    }
}
declare namespace CVC.Administration {
}
declare namespace CVC.Administration {
}
declare namespace CVC.Administration {
}
declare namespace CVC.Administration {
    interface RoleForm {
        RoleName: Serenity.StringEditor;
        ParentRoleId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }
    class RoleForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Administration {
    interface RolePermissionListRequest extends Serenity.ServiceRequest {
        RoleID?: number;
        Module?: string;
        Submodule?: string;
    }
}
declare namespace CVC.Administration {
    interface RolePermissionListResponse extends Serenity.ListResponse<string> {
    }
}
declare namespace CVC.Administration {
    interface RolePermissionRow {
        RolePermissionId?: number;
        RoleId?: number;
        PermissionKey?: string;
        RoleRoleName?: string;
    }
    namespace RolePermissionRow {
        const idProperty = "RolePermissionId";
        const nameProperty = "PermissionKey";
        const localTextPrefix = "Administration.RolePermission";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            RolePermissionId = "RolePermissionId",
            RoleId = "RoleId",
            PermissionKey = "PermissionKey",
            RoleRoleName = "RoleRoleName"
        }
    }
}
declare namespace CVC.Administration {
    namespace RolePermissionService {
        const baseUrl = "Administration/RolePermission";
        function Update(request: RolePermissionUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: RolePermissionListRequest, onSuccess?: (response: RolePermissionListResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Update = "Administration/RolePermission/Update",
            List = "Administration/RolePermission/List"
        }
    }
}
declare namespace CVC.Administration {
    interface RolePermissionUpdateRequest extends Serenity.ServiceRequest {
        RoleID?: number;
        Module?: string;
        Submodule?: string;
        Permissions?: string[];
    }
}
declare namespace CVC.Administration {
    interface RoleRow {
        RoleId?: number;
        RoleName?: string;
        StatusId?: number;
        StatusStatusName?: string;
        IsHidden?: boolean;
        ParentRoleId?: number;
        RolesRoleName?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace RoleRow {
        const idProperty = "RoleId";
        const nameProperty = "RoleName";
        const localTextPrefix = "Administration.Role";
        const lookupKey = "Role";
        function getLookup(): Q.Lookup<RoleRow>;
        const deletePermission = "Administration:Role:Modify";
        const insertPermission = "Administration:Role:Modify";
        const readPermission = "Administration:Role:Read";
        const updatePermission = "Administration:Role:Modify";
        const enum Fields {
            RoleId = "RoleId",
            RoleName = "RoleName",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            IsHidden = "IsHidden",
            ParentRoleId = "ParentRoleId",
            RolesRoleName = "RolesRoleName",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Administration {
    namespace RoleService {
        const baseUrl = "Administration/Role";
        function Create(request: Serenity.SaveRequest<RoleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<RoleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RoleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RoleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Administration/Role/Create",
            Update = "Administration/Role/Update",
            Delete = "Administration/Role/Delete",
            Retrieve = "Administration/Role/Retrieve",
            List = "Administration/Role/List"
        }
    }
}
declare namespace CVC.Administration {
}
declare namespace CVC.Administration {
    interface UserForm {
        EmployeeId: Serenity.StringEditor;
        FirstName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        DepartmentId: Serenity.LookupEditor;
        Designation: Serenity.StringEditor;
        MobileCode: Serenity.IntegerEditor;
        MobileNumber: Serenity.StringEditor;
        BirthDate: Serenity.DateEditor;
        Email: Serenity.EmailEditor;
        Username: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
        RoleId: Serenity.LookupEditor;
        UserImage: Serenity.ImageUploadEditor;
        Address: Serenity.StringEditor;
        CityId: Serenity.LookupEditor;
        PinCode: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
        QuestionId: Serenity.LookupEditor;
        QuestionAns: Serenity.StringEditor;
        IsLockOut: Serenity.BooleanEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
        IsActiveDirectory: Serenity.BooleanEditor;
    }
    class UserForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Administration {
    interface UserPermissionListRequest extends Serenity.ServiceRequest {
        UserID?: number;
        Module?: string;
        Submodule?: string;
    }
}
declare namespace CVC.Administration {
    interface UserPermissionRow {
        UserPermissionId?: number;
        UserId?: number;
        PermissionKey?: string;
        Granted?: boolean;
        Username?: string;
        User?: string;
    }
    namespace UserPermissionRow {
        const idProperty = "UserPermissionId";
        const nameProperty = "PermissionKey";
        const localTextPrefix = "Administration.UserPermission";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            UserPermissionId = "UserPermissionId",
            UserId = "UserId",
            PermissionKey = "PermissionKey",
            Granted = "Granted",
            Username = "Username",
            User = "User"
        }
    }
}
declare namespace CVC.Administration {
    namespace UserPermissionService {
        const baseUrl = "Administration/UserPermission";
        function Update(request: UserPermissionUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: UserPermissionListRequest, onSuccess?: (response: Serenity.ListResponse<UserPermissionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ListRolePermissions(request: UserPermissionListRequest, onSuccess?: (response: Serenity.ListResponse<string>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ListPermissionKeys(request: Serenity.ServiceRequest, onSuccess?: (response: Serenity.ListResponse<string>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Update = "Administration/UserPermission/Update",
            List = "Administration/UserPermission/List",
            ListRolePermissions = "Administration/UserPermission/ListRolePermissions",
            ListPermissionKeys = "Administration/UserPermission/ListPermissionKeys"
        }
    }
}
declare namespace CVC.Administration {
    interface UserPermissionUpdateRequest extends Serenity.ServiceRequest {
        UserID?: number;
        Module?: string;
        Submodule?: string;
        Permissions?: UserPermissionRow[];
    }
}
declare namespace CVC.Administration {
    interface UserRoleListRequest extends Serenity.ServiceRequest {
        UserID?: number;
    }
}
declare namespace CVC.Administration {
    interface UserRoleListResponse extends Serenity.ListResponse<number> {
    }
}
declare namespace CVC.Administration {
    interface UserRoleRow {
        UserRoleId?: number;
        UserId?: number;
        RoleId?: number;
        Username?: string;
        User?: string;
    }
    namespace UserRoleRow {
        const idProperty = "UserRoleId";
        const localTextPrefix = "Administration.UserRole";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            UserRoleId = "UserRoleId",
            UserId = "UserId",
            RoleId = "RoleId",
            Username = "Username",
            User = "User"
        }
    }
}
declare namespace CVC.Administration {
    namespace UserRoleService {
        const baseUrl = "Administration/UserRole";
        function Update(request: UserRoleUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: UserRoleListRequest, onSuccess?: (response: UserRoleListResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Update = "Administration/UserRole/Update",
            List = "Administration/UserRole/List"
        }
    }
}
declare namespace CVC.Administration {
    interface UserRoleUpdateRequest extends Serenity.ServiceRequest {
        UserID?: number;
        Roles?: number[];
    }
}
declare namespace CVC.Administration {
    interface UserRow {
        UserId?: number;
        EmployeeId?: string;
        Username?: string;
        FirstName?: string;
        LastName?: string;
        DepartmentId?: number;
        Designation?: string;
        MobileCode?: number;
        MobileNumber?: number;
        PasswordHash?: string;
        PasswordSalt?: string;
        Email?: string;
        UserImage?: string;
        StatusId?: number;
        Password?: string;
        PasswordConfirm?: string;
        Address?: string;
        CityId?: number;
        PinCode?: string;
        RoleId?: number;
        PasswordExpiryDate?: string;
        IsForgotPassword?: number;
        IsPasswordChangeOnLogin?: boolean;
        IsUserHidden?: number;
        BirthDate?: string;
        StatusStatusName?: string;
        DepartmentName?: string;
        CityState?: string;
        City?: string;
        IsLockOut?: boolean;
        CityCountry?: string;
        MobileNumberString?: string;
        RolesRoleName?: string;
        QuestionId?: number;
        QuestionAns?: string;
        IsActiveDirectory?: boolean;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace UserRow {
        const idProperty = "UserId";
        const isActiveProperty = "StatusId";
        const nameProperty = "Username";
        const localTextPrefix = "Administration.User";
        const lookupKey = "Administration.User";
        function getLookup(): Q.Lookup<UserRow>;
        const deletePermission = "Administration:User:Modify";
        const insertPermission = "Administration:User:Modify";
        const readPermission = "Administration:User:Read";
        const updatePermission = "Administration:User:Modify";
        const enum Fields {
            UserId = "UserId",
            EmployeeId = "EmployeeId",
            Username = "Username",
            FirstName = "FirstName",
            LastName = "LastName",
            DepartmentId = "DepartmentId",
            Designation = "Designation",
            MobileCode = "MobileCode",
            MobileNumber = "MobileNumber",
            PasswordHash = "PasswordHash",
            PasswordSalt = "PasswordSalt",
            Email = "Email",
            UserImage = "UserImage",
            StatusId = "StatusId",
            Password = "Password",
            PasswordConfirm = "PasswordConfirm",
            Address = "Address",
            CityId = "CityId",
            PinCode = "PinCode",
            RoleId = "RoleId",
            PasswordExpiryDate = "PasswordExpiryDate",
            IsForgotPassword = "IsForgotPassword",
            IsPasswordChangeOnLogin = "IsPasswordChangeOnLogin",
            IsUserHidden = "IsUserHidden",
            BirthDate = "BirthDate",
            StatusStatusName = "StatusStatusName",
            DepartmentName = "DepartmentName",
            CityState = "CityState",
            City = "City",
            IsLockOut = "IsLockOut",
            CityCountry = "CityCountry",
            MobileNumberString = "MobileNumberString",
            RolesRoleName = "RolesRoleName",
            QuestionId = "QuestionId",
            QuestionAns = "QuestionAns",
            IsActiveDirectory = "IsActiveDirectory",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Administration {
    namespace UserService {
        const baseUrl = "Administration/User";
        function Create(request: Serenity.SaveRequest<UserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<UserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Undelete(request: Serenity.UndeleteRequest, onSuccess?: (response: Serenity.UndeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<UserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<UserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Administration/User/Create",
            Update = "Administration/User/Update",
            Delete = "Administration/User/Delete",
            Undelete = "Administration/User/Undelete",
            Retrieve = "Administration/User/Retrieve",
            List = "Administration/User/List"
        }
    }
}
declare namespace CVC.Administration {
}
declare namespace CVC.Administration {
    interface ViewFieldAccessForm {
        ViewFieldId: Serenity.LookupEditor;
        RoleId: Serenity.LookupEditor;
        IsView: Serenity.BooleanEditor;
        IsModify: Serenity.BooleanEditor;
        StatusId: Serenity.LookupEditor;
    }
    class ViewFieldAccessForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Administration {
    interface ViewFieldAccessRow {
        ViewFieldAccessId?: number;
        ViewFieldId?: number;
        RoleId?: number;
        IsView?: boolean;
        IsModify?: boolean;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        ViewFieldViewsId?: number;
        ViewFieldViewFieldName?: string;
        ViewFieldStatusId?: number;
        ViewFieldCreatedBy?: number;
        ViewFieldCreatedDate?: string;
        ViewFieldUpdatedBy?: number;
        ViewFieldUpdatedDate?: string;
        RoleRoleName?: string;
        RoleStatusId?: number;
        RoleIsHidden?: number;
        RoleParentRoleId?: number;
        RoleCreatedBy?: number;
        RoleCreatedDate?: string;
        RoleUpdatedBy?: number;
        RoleUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace ViewFieldAccessRow {
        const idProperty = "ViewFieldAccessId";
        const localTextPrefix = "Administration.ViewFieldAccess";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            ViewFieldAccessId = "ViewFieldAccessId",
            ViewFieldId = "ViewFieldId",
            RoleId = "RoleId",
            IsView = "IsView",
            IsModify = "IsModify",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            ViewFieldViewsId = "ViewFieldViewsId",
            ViewFieldViewFieldName = "ViewFieldViewFieldName",
            ViewFieldStatusId = "ViewFieldStatusId",
            ViewFieldCreatedBy = "ViewFieldCreatedBy",
            ViewFieldCreatedDate = "ViewFieldCreatedDate",
            ViewFieldUpdatedBy = "ViewFieldUpdatedBy",
            ViewFieldUpdatedDate = "ViewFieldUpdatedDate",
            RoleRoleName = "RoleRoleName",
            RoleStatusId = "RoleStatusId",
            RoleIsHidden = "RoleIsHidden",
            RoleParentRoleId = "RoleParentRoleId",
            RoleCreatedBy = "RoleCreatedBy",
            RoleCreatedDate = "RoleCreatedDate",
            RoleUpdatedBy = "RoleUpdatedBy",
            RoleUpdatedDate = "RoleUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.Administration {
    namespace ViewFieldAccessService {
        const baseUrl = "Administration/ViewFieldAccess";
        function Create(request: Serenity.SaveRequest<ViewFieldAccessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ViewFieldAccessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ViewFieldAccessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ViewFieldAccessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Administration/ViewFieldAccess/Create",
            Update = "Administration/ViewFieldAccess/Update",
            Delete = "Administration/ViewFieldAccess/Delete",
            Retrieve = "Administration/ViewFieldAccess/Retrieve",
            List = "Administration/ViewFieldAccess/List"
        }
    }
}
declare namespace CVC.Administration {
}
declare namespace CVC.Administration {
    interface ViewsAccessForm {
        ViewsId: Serenity.LookupEditor;
        RoleId: Serenity.LookupEditor;
        IsView: Serenity.BooleanEditor;
        IsModify: Serenity.BooleanEditor;
        StatusId: Serenity.LookupEditor;
    }
    class ViewsAccessForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Administration {
    interface ViewsAccessRow {
        ViewsAccessId?: number;
        ViewsId?: number;
        RoleId?: number;
        IsView?: boolean;
        IsModify?: boolean;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        ViewsModuleId?: number;
        ViewsViewName?: string;
        ViewsIsAccessFieldWise?: number;
        ViewsStatusId?: number;
        ViewsCreatedBy?: number;
        ViewsCreatedDate?: string;
        ViewsUpdatedBy?: number;
        ViewsUpdatedDate?: string;
        RoleRoleName?: string;
        RoleStatusId?: number;
        RoleIsHidden?: number;
        RoleParentRoleId?: number;
        RoleCreatedBy?: number;
        RoleCreatedDate?: string;
        RoleUpdatedBy?: number;
        RoleUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace ViewsAccessRow {
        const idProperty = "ViewsAccessId";
        const localTextPrefix = "Administration.ViewsAccess";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            ViewsAccessId = "ViewsAccessId",
            ViewsId = "ViewsId",
            RoleId = "RoleId",
            IsView = "IsView",
            IsModify = "IsModify",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            ViewsModuleId = "ViewsModuleId",
            ViewsViewName = "ViewsViewName",
            ViewsIsAccessFieldWise = "ViewsIsAccessFieldWise",
            ViewsStatusId = "ViewsStatusId",
            ViewsCreatedBy = "ViewsCreatedBy",
            ViewsCreatedDate = "ViewsCreatedDate",
            ViewsUpdatedBy = "ViewsUpdatedBy",
            ViewsUpdatedDate = "ViewsUpdatedDate",
            RoleRoleName = "RoleRoleName",
            RoleStatusId = "RoleStatusId",
            RoleIsHidden = "RoleIsHidden",
            RoleParentRoleId = "RoleParentRoleId",
            RoleCreatedBy = "RoleCreatedBy",
            RoleCreatedDate = "RoleCreatedDate",
            RoleUpdatedBy = "RoleUpdatedBy",
            RoleUpdatedDate = "RoleUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.Administration {
    namespace ViewsAccessService {
        const baseUrl = "Administration/ViewsAccess";
        function Create(request: Serenity.SaveRequest<ViewsAccessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ViewsAccessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ViewsAccessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ViewsAccessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Administration/ViewsAccess/Create",
            Update = "Administration/ViewsAccess/Update",
            Delete = "Administration/ViewsAccess/Delete",
            Retrieve = "Administration/ViewsAccess/Retrieve",
            List = "Administration/ViewsAccess/List"
        }
    }
}
declare namespace CVC.Batch {
}
declare namespace CVC.Batch {
    interface BatchForm {
        BatchName: Serenity.StringEditor;
        PackId: Serenity.IntegerEditor;
        MachineLineId: Serenity.IntegerEditor;
        BatchStatus: Serenity.StringEditor;
        BatchSize: Serenity.IntegerEditor;
        BatchFor: Serenity.LookupEditor;
        ExpiryDate: Serenity.DateEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateTimeEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateTimeEditor;
        BatchVersion: Serenity.StringEditor;
    }
    class BatchForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Batch {
}
declare namespace CVC.Batch {
    interface BatchLogForm {
        MachineId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        Description: Serenity.StringEditor;
        UserId: Serenity.IntegerEditor;
        UpdatedDateTime: Serenity.DateEditor;
    }
    class BatchLogForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Batch {
    interface BatchLogRow {
        BatchLogId?: number;
        MachineId?: number;
        BatchId?: number;
        Description?: string;
        UserId?: number;
        UpdatedDateTime?: string;
    }
    namespace BatchLogRow {
        const idProperty = "BatchLogId";
        const nameProperty = "Description";
        const localTextPrefix = "Batch.BatchLog";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            BatchLogId = "BatchLogId",
            MachineId = "MachineId",
            BatchId = "BatchId",
            Description = "Description",
            UserId = "UserId",
            UpdatedDateTime = "UpdatedDateTime"
        }
    }
}
declare namespace CVC.Batch {
    namespace BatchLogService {
        const baseUrl = "Batch/BatchLog";
        function Create(request: Serenity.SaveRequest<BatchLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<BatchLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BatchLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BatchLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Batch/BatchLog/Create",
            Update = "Batch/BatchLog/Update",
            Delete = "Batch/BatchLog/Delete",
            Retrieve = "Batch/BatchLog/Retrieve",
            List = "Batch/BatchLog/List"
        }
    }
}
declare namespace CVC.Batch {
}
declare namespace CVC.Batch {
    interface BatchMachineWiseForm {
        MachineId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        RecipeId: Serenity.IntegerEditor;
        IsMachineInUse: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class BatchMachineWiseForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Batch {
    interface BatchMachineWiseRow {
        BatchMachineId?: number;
        MachineId?: number;
        BatchId?: number;
        RecipeId?: number;
        IsMachineInUse?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
        BatchBatchName?: string;
        BatchPackId?: number;
        BatchBatchStartDateTime?: string;
        BatchBatchEndDateTime?: string;
        BatchMachineLineId?: number;
        BatchBatchStatus?: string;
        BatchBatchSize?: number;
        BatchBatchFor?: string;
        BatchNumberOfBottles?: number;
        BatchTotalGoodBottles?: number;
        BatchTotalRejectedBottles?: number;
        BatchProductionSpeed?: string;
        BatchExpiryDate?: string;
        BatchStatusId?: number;
        BatchCreatedBy?: number;
        BatchCreatedDate?: string;
        BatchUpdatedBy?: number;
        BatchUpdatedDate?: string;
        RecipeMachineId?: number;
        RecipeRecipeSettingsId?: number;
        RecipeRecipeName?: string;
        RecipeStatusId?: number;
        RecipeCreatedBy?: number;
        RecipeCreatedDate?: string;
        RecipeUpdatedBy?: number;
        RecipeUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace BatchMachineWiseRow {
        const idProperty = "BatchMachineId";
        const localTextPrefix = "Batch.BatchMachineWise";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            BatchMachineId = "BatchMachineId",
            MachineId = "MachineId",
            BatchId = "BatchId",
            RecipeId = "RecipeId",
            IsMachineInUse = "IsMachineInUse",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
            BatchBatchName = "BatchBatchName",
            BatchPackId = "BatchPackId",
            BatchBatchStartDateTime = "BatchBatchStartDateTime",
            BatchBatchEndDateTime = "BatchBatchEndDateTime",
            BatchMachineLineId = "BatchMachineLineId",
            BatchBatchStatus = "BatchBatchStatus",
            BatchBatchSize = "BatchBatchSize",
            BatchBatchFor = "BatchBatchFor",
            BatchNumberOfBottles = "BatchNumberOfBottles",
            BatchTotalGoodBottles = "BatchTotalGoodBottles",
            BatchTotalRejectedBottles = "BatchTotalRejectedBottles",
            BatchProductionSpeed = "BatchProductionSpeed",
            BatchExpiryDate = "BatchExpiryDate",
            BatchStatusId = "BatchStatusId",
            BatchCreatedBy = "BatchCreatedBy",
            BatchCreatedDate = "BatchCreatedDate",
            BatchUpdatedBy = "BatchUpdatedBy",
            BatchUpdatedDate = "BatchUpdatedDate",
            RecipeMachineId = "RecipeMachineId",
            RecipeRecipeSettingsId = "RecipeRecipeSettingsId",
            RecipeRecipeName = "RecipeRecipeName",
            RecipeStatusId = "RecipeStatusId",
            RecipeCreatedBy = "RecipeCreatedBy",
            RecipeCreatedDate = "RecipeCreatedDate",
            RecipeUpdatedBy = "RecipeUpdatedBy",
            RecipeUpdatedDate = "RecipeUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.Batch {
    namespace BatchMachineWiseService {
        const baseUrl = "Batch/BatchMachineWise";
        function Create(request: Serenity.SaveRequest<BatchMachineWiseRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<BatchMachineWiseRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BatchMachineWiseRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BatchMachineWiseRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Batch/BatchMachineWise/Create",
            Update = "Batch/BatchMachineWise/Update",
            Delete = "Batch/BatchMachineWise/Delete",
            Retrieve = "Batch/BatchMachineWise/Retrieve",
            List = "Batch/BatchMachineWise/List"
        }
    }
}
declare namespace CVC.Batch {
}
declare namespace CVC.Batch {
    interface BatchRecipeModifyForm {
        BatchMachineId: Serenity.IntegerEditor;
        RecipeSettingsParameterId: Serenity.IntegerEditor;
        OldValue: Serenity.StringEditor;
        NewValue: Serenity.StringEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class BatchRecipeModifyForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Batch {
    interface BatchRecipeModifyRow {
        BatchRecipeModifyId?: number;
        BatchMachineId?: number;
        RecipeSettingsParameterId?: number;
        OldValue?: string;
        NewValue?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        BatchMachineMachineId?: number;
        BatchMachineBatchId?: number;
        BatchMachineRecipeId?: number;
        BatchMachineIsMachineInUse?: number;
        BatchMachineStatusId?: number;
        BatchMachineCreatedBy?: number;
        BatchMachineCreatedDate?: string;
        BatchMachineUpdatedBy?: number;
        BatchMachineUpdatedDate?: string;
        RecipeSettingsParameterRecipeSettingsId?: number;
        RecipeSettingsParameterIpcParameterId?: number;
        RecipeSettingsParameterIsFetchOnSelfSet?: number;
        RecipeSettingsParameterStatusId?: number;
        RecipeSettingsParameterCreatedBy?: number;
        RecipeSettingsParameterCreatedDate?: string;
        RecipeSettingsParameterUpdatedBy?: number;
        RecipeSettingsParameterUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace BatchRecipeModifyRow {
        const idProperty = "BatchRecipeModifyId";
        const nameProperty = "OldValue";
        const localTextPrefix = "Batch.BatchRecipeModify";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            BatchRecipeModifyId = "BatchRecipeModifyId",
            BatchMachineId = "BatchMachineId",
            RecipeSettingsParameterId = "RecipeSettingsParameterId",
            OldValue = "OldValue",
            NewValue = "NewValue",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            BatchMachineMachineId = "BatchMachineMachineId",
            BatchMachineBatchId = "BatchMachineBatchId",
            BatchMachineRecipeId = "BatchMachineRecipeId",
            BatchMachineIsMachineInUse = "BatchMachineIsMachineInUse",
            BatchMachineStatusId = "BatchMachineStatusId",
            BatchMachineCreatedBy = "BatchMachineCreatedBy",
            BatchMachineCreatedDate = "BatchMachineCreatedDate",
            BatchMachineUpdatedBy = "BatchMachineUpdatedBy",
            BatchMachineUpdatedDate = "BatchMachineUpdatedDate",
            RecipeSettingsParameterRecipeSettingsId = "RecipeSettingsParameterRecipeSettingsId",
            RecipeSettingsParameterIpcParameterId = "RecipeSettingsParameterIpcParameterId",
            RecipeSettingsParameterIsFetchOnSelfSet = "RecipeSettingsParameterIsFetchOnSelfSet",
            RecipeSettingsParameterStatusId = "RecipeSettingsParameterStatusId",
            RecipeSettingsParameterCreatedBy = "RecipeSettingsParameterCreatedBy",
            RecipeSettingsParameterCreatedDate = "RecipeSettingsParameterCreatedDate",
            RecipeSettingsParameterUpdatedBy = "RecipeSettingsParameterUpdatedBy",
            RecipeSettingsParameterUpdatedDate = "RecipeSettingsParameterUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.Batch {
    namespace BatchRecipeModifyService {
        const baseUrl = "Batch/BatchRecipeModify";
        function Create(request: Serenity.SaveRequest<BatchRecipeModifyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<BatchRecipeModifyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BatchRecipeModifyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BatchRecipeModifyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Batch/BatchRecipeModify/Create",
            Update = "Batch/BatchRecipeModify/Update",
            Delete = "Batch/BatchRecipeModify/Delete",
            Retrieve = "Batch/BatchRecipeModify/Retrieve",
            List = "Batch/BatchRecipeModify/List"
        }
    }
}
declare namespace CVC.Batch {
    namespace BatchReportService {
        const baseUrl = "~/BatchReport";
        const enum Methods {
        }
    }
}
declare namespace CVC.Batch {
    interface BatchRow {
        BatchId?: number;
        BatchName?: string;
        PackId?: number;
        BatchStartDateTime?: string;
        BatchEndDateTime?: string;
        MachineLineId?: number;
        BatchStatus?: string;
        BatchSize?: number;
        BatchFor?: number;
        NumberOfBottles?: number;
        TotalGoodBottles?: number;
        TotalRejectedBottles?: number;
        ProductionSpeed?: string;
        ExpiryDate?: string;
        StatusId?: number;
        BatchForPickListId?: number;
        BatchForPickListValueName?: string;
        BatchForStatusId?: number;
        BatchForCreatedBy?: number;
        BatchForCreatedDate?: string;
        BatchForUpdatedBy?: number;
        BatchForUpdatedDate?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        BatchVersion?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace BatchRow {
        const idProperty = "BatchId";
        const nameProperty = "BatchName";
        const localTextPrefix = "Batch.Batch";
        const lookupKey = "Batch";
        function getLookup(): Q.Lookup<BatchRow>;
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            BatchId = "BatchId",
            BatchName = "BatchName",
            PackId = "PackId",
            BatchStartDateTime = "BatchStartDateTime",
            BatchEndDateTime = "BatchEndDateTime",
            MachineLineId = "MachineLineId",
            BatchStatus = "BatchStatus",
            BatchSize = "BatchSize",
            BatchFor = "BatchFor",
            NumberOfBottles = "NumberOfBottles",
            TotalGoodBottles = "TotalGoodBottles",
            TotalRejectedBottles = "TotalRejectedBottles",
            ProductionSpeed = "ProductionSpeed",
            ExpiryDate = "ExpiryDate",
            StatusId = "StatusId",
            BatchForPickListId = "BatchForPickListId",
            BatchForPickListValueName = "BatchForPickListValueName",
            BatchForStatusId = "BatchForStatusId",
            BatchForCreatedBy = "BatchForCreatedBy",
            BatchForCreatedDate = "BatchForCreatedDate",
            BatchForUpdatedBy = "BatchForUpdatedBy",
            BatchForUpdatedDate = "BatchForUpdatedDate",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            BatchVersion = "BatchVersion",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Batch {
    interface BatchRow1 {
        BatchId?: number;
        BatchName?: string;
        PackId?: number;
        BatchStartDateTime?: string;
        BatchEndDateTime?: string;
        MachineLineId?: number;
        BatchStatus?: string;
        BatchSize?: number;
        BatchFor?: number;
        NumberOfBottles?: number;
        TotalGoodBottles?: number;
        TotalRejectedBottles?: number;
        ProductionSpeed?: string;
        ExpiryDate?: string;
        StatusId?: number;
        BatchForPickListId?: number;
        BatchForPickListValueName?: string;
        BatchForStatusId?: number;
        BatchForCreatedBy?: number;
        BatchForCreatedDate?: string;
        BatchForUpdatedBy?: number;
        BatchForUpdatedDate?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        BatchVersion?: string;
        ParentId?: number;
        BatchLatestVersion?: string;
        Comments?: string;
        RepackStatus?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace BatchRow1 {
        const idProperty = "BatchId";
        const nameProperty = "BatchName";
        const localTextPrefix = "Batch.Batch";
        const lookupKey = "Batch1";
        function getLookup(): Q.Lookup<BatchRow1>;
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            BatchId = "BatchId",
            BatchName = "BatchName",
            PackId = "PackId",
            BatchStartDateTime = "BatchStartDateTime",
            BatchEndDateTime = "BatchEndDateTime",
            MachineLineId = "MachineLineId",
            BatchStatus = "BatchStatus",
            BatchSize = "BatchSize",
            BatchFor = "BatchFor",
            NumberOfBottles = "NumberOfBottles",
            TotalGoodBottles = "TotalGoodBottles",
            TotalRejectedBottles = "TotalRejectedBottles",
            ProductionSpeed = "ProductionSpeed",
            ExpiryDate = "ExpiryDate",
            StatusId = "StatusId",
            BatchForPickListId = "BatchForPickListId",
            BatchForPickListValueName = "BatchForPickListValueName",
            BatchForStatusId = "BatchForStatusId",
            BatchForCreatedBy = "BatchForCreatedBy",
            BatchForCreatedDate = "BatchForCreatedDate",
            BatchForUpdatedBy = "BatchForUpdatedBy",
            BatchForUpdatedDate = "BatchForUpdatedDate",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            BatchVersion = "BatchVersion",
            ParentId = "ParentId",
            BatchLatestVersion = "BatchLatestVersion",
            Comments = "Comments",
            RepackStatus = "RepackStatus",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Batch {
}
declare namespace CVC.Batch {
    interface BatchRunDataForm {
        BatchMachineWiseId: Serenity.IntegerEditor;
        IpcParameterId: Serenity.IntegerEditor;
        IpcParameterValue: Serenity.StringEditor;
        UpdatedDateTime: Serenity.DateEditor;
        LoggedInUser: Serenity.IntegerEditor;
    }
    class BatchRunDataForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Batch {
    interface BatchRunDataRow {
        BatchRunDataId?: number;
        BatchMachineWiseId?: number;
        IpcParameterId?: number;
        IpcParameterValue?: string;
        UpdatedDateTime?: string;
        LoggedInUser?: number;
        BatchMachineWiseMachineId?: number;
        BatchMachineWiseBatchId?: number;
        BatchMachineWiseRecipeId?: number;
        BatchMachineWiseIsMachineInUse?: number;
        BatchMachineWiseStatusId?: number;
        BatchMachineWiseCreatedBy?: number;
        BatchMachineWiseCreatedDate?: string;
        BatchMachineWiseUpdatedBy?: number;
        BatchMachineWiseUpdatedDate?: string;
        IpcParameterMachineId?: number;
        IpcParameterIpcParameterName?: string;
        IpcParameterMachineParameterId?: number;
        IpcParameterIpcAddress?: string;
        IpcParameterIsChangeInRuntime?: number;
        IpcParameterStatusId?: number;
        IpcParameterCreatedBy?: number;
        IpcParameterCreatedDate?: string;
        IpcParameterUpdatedBy?: number;
        IpcParameterUpdatedDate?: string;
        LoggedInUserEmployeeId?: string;
        LoggedInUserFirstName?: string;
        LoggedInUserLastName?: string;
        LoggedInUserDepartmentId?: number;
        LoggedInUserDesignation?: string;
        LoggedInUserMobileCode?: number;
        LoggedInUserMobileNumber?: number;
        LoggedInUserEmail?: string;
        LoggedInUserUsername?: string;
        LoggedInUserPasswordHash?: string;
        LoggedInUserPasswordSalt?: string;
        LoggedInUserUserImage?: number[];
        LoggedInUserAddress?: string;
        LoggedInUserCityId?: number;
        LoggedInUserPinCode?: string;
        LoggedInUserRoleId?: number;
        LoggedInUserPasswordExpiryDate?: string;
        LoggedInUserIsForgotPassword?: number;
        LoggedInUserIsPasswordChangeOnLogin?: number;
        LoggedInUserIsUserHidden?: number;
        LoggedInUserStatusId?: number;
        LoggedInUserCreatedBy?: number;
        LoggedInUserCreatedDate?: string;
        LoggedInUserUpdatedBy?: number;
        LoggedInUserUpdatedDate?: string;
    }
    namespace BatchRunDataRow {
        const idProperty = "BatchRunDataId";
        const nameProperty = "IpcParameterValue";
        const localTextPrefix = "Batch.BatchRunData";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            BatchRunDataId = "BatchRunDataId",
            BatchMachineWiseId = "BatchMachineWiseId",
            IpcParameterId = "IpcParameterId",
            IpcParameterValue = "IpcParameterValue",
            UpdatedDateTime = "UpdatedDateTime",
            LoggedInUser = "LoggedInUser",
            BatchMachineWiseMachineId = "BatchMachineWiseMachineId",
            BatchMachineWiseBatchId = "BatchMachineWiseBatchId",
            BatchMachineWiseRecipeId = "BatchMachineWiseRecipeId",
            BatchMachineWiseIsMachineInUse = "BatchMachineWiseIsMachineInUse",
            BatchMachineWiseStatusId = "BatchMachineWiseStatusId",
            BatchMachineWiseCreatedBy = "BatchMachineWiseCreatedBy",
            BatchMachineWiseCreatedDate = "BatchMachineWiseCreatedDate",
            BatchMachineWiseUpdatedBy = "BatchMachineWiseUpdatedBy",
            BatchMachineWiseUpdatedDate = "BatchMachineWiseUpdatedDate",
            IpcParameterMachineId = "IpcParameterMachineId",
            IpcParameterIpcParameterName = "IpcParameterIpcParameterName",
            IpcParameterMachineParameterId = "IpcParameterMachineParameterId",
            IpcParameterIpcAddress = "IpcParameterIpcAddress",
            IpcParameterIsChangeInRuntime = "IpcParameterIsChangeInRuntime",
            IpcParameterStatusId = "IpcParameterStatusId",
            IpcParameterCreatedBy = "IpcParameterCreatedBy",
            IpcParameterCreatedDate = "IpcParameterCreatedDate",
            IpcParameterUpdatedBy = "IpcParameterUpdatedBy",
            IpcParameterUpdatedDate = "IpcParameterUpdatedDate",
            LoggedInUserEmployeeId = "LoggedInUserEmployeeId",
            LoggedInUserFirstName = "LoggedInUserFirstName",
            LoggedInUserLastName = "LoggedInUserLastName",
            LoggedInUserDepartmentId = "LoggedInUserDepartmentId",
            LoggedInUserDesignation = "LoggedInUserDesignation",
            LoggedInUserMobileCode = "LoggedInUserMobileCode",
            LoggedInUserMobileNumber = "LoggedInUserMobileNumber",
            LoggedInUserEmail = "LoggedInUserEmail",
            LoggedInUserUsername = "LoggedInUserUsername",
            LoggedInUserPasswordHash = "LoggedInUserPasswordHash",
            LoggedInUserPasswordSalt = "LoggedInUserPasswordSalt",
            LoggedInUserUserImage = "LoggedInUserUserImage",
            LoggedInUserAddress = "LoggedInUserAddress",
            LoggedInUserCityId = "LoggedInUserCityId",
            LoggedInUserPinCode = "LoggedInUserPinCode",
            LoggedInUserRoleId = "LoggedInUserRoleId",
            LoggedInUserPasswordExpiryDate = "LoggedInUserPasswordExpiryDate",
            LoggedInUserIsForgotPassword = "LoggedInUserIsForgotPassword",
            LoggedInUserIsPasswordChangeOnLogin = "LoggedInUserIsPasswordChangeOnLogin",
            LoggedInUserIsUserHidden = "LoggedInUserIsUserHidden",
            LoggedInUserStatusId = "LoggedInUserStatusId",
            LoggedInUserCreatedBy = "LoggedInUserCreatedBy",
            LoggedInUserCreatedDate = "LoggedInUserCreatedDate",
            LoggedInUserUpdatedBy = "LoggedInUserUpdatedBy",
            LoggedInUserUpdatedDate = "LoggedInUserUpdatedDate"
        }
    }
}
declare namespace CVC.Batch {
    namespace BatchRunDataService {
        const baseUrl = "Batch/BatchRunData";
        function Create(request: Serenity.SaveRequest<BatchRunDataRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<BatchRunDataRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BatchRunDataRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BatchRunDataRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Batch/BatchRunData/Create",
            Update = "Batch/BatchRunData/Update",
            Delete = "Batch/BatchRunData/Delete",
            Retrieve = "Batch/BatchRunData/Retrieve",
            List = "Batch/BatchRunData/List"
        }
    }
}
declare namespace CVC.Batch {
    namespace BatchService {
        const baseUrl = "Batch/Batch";
        function Create(request: Serenity.SaveRequest<BatchRow1>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<BatchRow1>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BatchRow1>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BatchRow1>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Batch/Batch/Create",
            Update = "Batch/Batch/Update",
            Delete = "Batch/Batch/Delete",
            Retrieve = "Batch/Batch/Retrieve",
            List = "Batch/Batch/List"
        }
    }
}
declare namespace CVC.Batch {
}
declare namespace CVC.Batch {
    interface LabelLostForm {
        LabelRecId: Serenity.IntegerEditor;
        ActivityId: Serenity.IntegerEditor;
        ActivityText: Serenity.StringEditor;
        NumberOfLabels: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class LabelLostForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Batch {
    interface LabelLostRow {
        LabelLostId?: number;
        LabelRecId?: number;
        ActivityId?: number;
        ActivityText?: string;
        NumberOfLabels?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        LabelRecBatchId?: number;
        LabelRecMachineId?: number;
        LabelRecLabelRollId?: number;
        LabelRecRejectedLabels?: number;
        LabelRecLabelLost?: number;
        LabelRecNoLabelOnRoll?: number;
        LabelRecLabelBalance?: number;
        LabelRecStatusId?: number;
        LabelRecCreatedBy?: number;
        LabelRecCreatedDate?: string;
        LabelRecUpdatedBy?: number;
        LabelRecUpdatedDate?: string;
        ActivityPickListId?: number;
        ActivityPickListValueName?: string;
        ActivityStatusId?: number;
        ActivityCreatedBy?: number;
        ActivityCreatedDate?: string;
        ActivityUpdatedBy?: number;
        ActivityUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace LabelLostRow {
        const idProperty = "LabelLostId";
        const nameProperty = "ActivityText";
        const localTextPrefix = "Batch.LabelLost";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            LabelLostId = "LabelLostId",
            LabelRecId = "LabelRecId",
            ActivityId = "ActivityId",
            ActivityText = "ActivityText",
            NumberOfLabels = "NumberOfLabels",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            LabelRecBatchId = "LabelRecBatchId",
            LabelRecMachineId = "LabelRecMachineId",
            LabelRecLabelRollId = "LabelRecLabelRollId",
            LabelRecRejectedLabels = "LabelRecRejectedLabels",
            LabelRecLabelLost = "LabelRecLabelLost",
            LabelRecNoLabelOnRoll = "LabelRecNoLabelOnRoll",
            LabelRecLabelBalance = "LabelRecLabelBalance",
            LabelRecStatusId = "LabelRecStatusId",
            LabelRecCreatedBy = "LabelRecCreatedBy",
            LabelRecCreatedDate = "LabelRecCreatedDate",
            LabelRecUpdatedBy = "LabelRecUpdatedBy",
            LabelRecUpdatedDate = "LabelRecUpdatedDate",
            ActivityPickListId = "ActivityPickListId",
            ActivityPickListValueName = "ActivityPickListValueName",
            ActivityStatusId = "ActivityStatusId",
            ActivityCreatedBy = "ActivityCreatedBy",
            ActivityCreatedDate = "ActivityCreatedDate",
            ActivityUpdatedBy = "ActivityUpdatedBy",
            ActivityUpdatedDate = "ActivityUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.Batch {
    namespace LabelLostService {
        const baseUrl = "Batch/LabelLost";
        function Create(request: Serenity.SaveRequest<LabelLostRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<LabelLostRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LabelLostRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LabelLostRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Batch/LabelLost/Create",
            Update = "Batch/LabelLost/Update",
            Delete = "Batch/LabelLost/Delete",
            Retrieve = "Batch/LabelLost/Retrieve",
            List = "Batch/LabelLost/List"
        }
    }
}
declare namespace CVC.Batch {
}
declare namespace CVC.Batch {
    interface LabelReconciliationForm {
        BatchId: Serenity.IntegerEditor;
        MachineId: Serenity.IntegerEditor;
        LabelRollId: Serenity.IntegerEditor;
        RejectedLabels: Serenity.IntegerEditor;
        LabelLost: Serenity.IntegerEditor;
        NoLabelOnRoll: Serenity.IntegerEditor;
        LabelBalance: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class LabelReconciliationForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Batch {
    interface LabelReconciliationRow {
        LabelRecId?: number;
        BatchId?: number;
        MachineId?: number;
        LabelRollId?: number;
        RejectedLabels?: number;
        LabelLost?: number;
        NoLabelOnRoll?: number;
        LabelBalance?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        BatchBatchName?: string;
        BatchPackId?: number;
        BatchBatchStartDateTime?: string;
        BatchBatchEndDateTime?: string;
        BatchMachineLineId?: number;
        BatchBatchStatus?: string;
        BatchBatchSize?: number;
        BatchBatchFor?: string;
        BatchNumberOfBottles?: number;
        BatchTotalGoodBottles?: number;
        BatchTotalRejectedBottles?: number;
        BatchProductionSpeed?: string;
        BatchExpiryDate?: string;
        BatchStatusId?: number;
        BatchCreatedBy?: number;
        BatchCreatedDate?: string;
        BatchUpdatedBy?: number;
        BatchUpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
        LabelRollBatchId?: number;
        LabelRollMachineId?: number;
        LabelRollLabelRollNumber?: number;
        LabelRollNumberOfLabels?: number;
        LabelRollRemark?: string;
        LabelRollStatusId?: number;
        LabelRollCreatedBy?: number;
        LabelRollCreatedDate?: string;
        LabelRollUpdatedBy?: number;
        LabelRollUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace LabelReconciliationRow {
        const idProperty = "LabelRecId";
        const localTextPrefix = "Batch.LabelReconciliation";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            LabelRecId = "LabelRecId",
            BatchId = "BatchId",
            MachineId = "MachineId",
            LabelRollId = "LabelRollId",
            RejectedLabels = "RejectedLabels",
            LabelLost = "LabelLost",
            NoLabelOnRoll = "NoLabelOnRoll",
            LabelBalance = "LabelBalance",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            BatchBatchName = "BatchBatchName",
            BatchPackId = "BatchPackId",
            BatchBatchStartDateTime = "BatchBatchStartDateTime",
            BatchBatchEndDateTime = "BatchBatchEndDateTime",
            BatchMachineLineId = "BatchMachineLineId",
            BatchBatchStatus = "BatchBatchStatus",
            BatchBatchSize = "BatchBatchSize",
            BatchBatchFor = "BatchBatchFor",
            BatchNumberOfBottles = "BatchNumberOfBottles",
            BatchTotalGoodBottles = "BatchTotalGoodBottles",
            BatchTotalRejectedBottles = "BatchTotalRejectedBottles",
            BatchProductionSpeed = "BatchProductionSpeed",
            BatchExpiryDate = "BatchExpiryDate",
            BatchStatusId = "BatchStatusId",
            BatchCreatedBy = "BatchCreatedBy",
            BatchCreatedDate = "BatchCreatedDate",
            BatchUpdatedBy = "BatchUpdatedBy",
            BatchUpdatedDate = "BatchUpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
            LabelRollBatchId = "LabelRollBatchId",
            LabelRollMachineId = "LabelRollMachineId",
            LabelRollLabelRollNumber = "LabelRollLabelRollNumber",
            LabelRollNumberOfLabels = "LabelRollNumberOfLabels",
            LabelRollRemark = "LabelRollRemark",
            LabelRollStatusId = "LabelRollStatusId",
            LabelRollCreatedBy = "LabelRollCreatedBy",
            LabelRollCreatedDate = "LabelRollCreatedDate",
            LabelRollUpdatedBy = "LabelRollUpdatedBy",
            LabelRollUpdatedDate = "LabelRollUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.Batch {
    namespace LabelReconciliationService {
        const baseUrl = "Batch/LabelReconciliation";
        function Create(request: Serenity.SaveRequest<LabelReconciliationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<LabelReconciliationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LabelReconciliationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LabelReconciliationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Batch/LabelReconciliation/Create",
            Update = "Batch/LabelReconciliation/Update",
            Delete = "Batch/LabelReconciliation/Delete",
            Retrieve = "Batch/LabelReconciliation/Retrieve",
            List = "Batch/LabelReconciliation/List"
        }
    }
}
declare namespace CVC.Batch {
}
declare namespace CVC.Batch {
    interface LabelRollForm {
        BatchId: Serenity.IntegerEditor;
        MachineId: Serenity.IntegerEditor;
        LabelRollNumber: Serenity.IntegerEditor;
        NumberOfLabels: Serenity.StringEditor;
        Remark: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class LabelRollForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Batch {
    interface LabelRollRow {
        LabelRollId?: number;
        BatchId?: number;
        MachineId?: number;
        LabelRollNumber?: number;
        NumberOfLabels?: number;
        NumberOfLabelsUsed?: number;
        LabelRemaining?: number;
        Remark?: string;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        IsApplied?: boolean;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace LabelRollRow {
        const idProperty = "LabelRollId";
        const nameProperty = "Remark";
        const localTextPrefix = "Batch.LabelRoll";
        const lookupKey = "Batch.LabelRollId";
        function getLookup(): Q.Lookup<LabelRollRow>;
        const deletePermission = "?";
        const insertPermission = "?";
        const readPermission = "?";
        const updatePermission = "?";
        const enum Fields {
            LabelRollId = "LabelRollId",
            BatchId = "BatchId",
            MachineId = "MachineId",
            LabelRollNumber = "LabelRollNumber",
            NumberOfLabels = "NumberOfLabels",
            NumberOfLabelsUsed = "NumberOfLabelsUsed",
            LabelRemaining = "LabelRemaining",
            Remark = "Remark",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            IsApplied = "IsApplied",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Batch {
    namespace LabelRollService {
        const baseUrl = "Batch/LabelRoll";
        function Create(request: Serenity.SaveRequest<LabelRollRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<LabelRollRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LabelRollRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LabelRollRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Batch/LabelRoll/Create",
            Update = "Batch/LabelRoll/Update",
            Delete = "Batch/LabelRoll/Delete",
            Retrieve = "Batch/LabelRoll/Retrieve",
            List = "Batch/LabelRoll/List"
        }
    }
}
declare namespace CVC.Common {
    interface UserPreferenceRetrieveRequest extends Serenity.ServiceRequest {
        PreferenceType?: string;
        Name?: string;
    }
}
declare namespace CVC.Common {
    interface UserPreferenceRetrieveResponse extends Serenity.ServiceResponse {
        Value?: string;
    }
}
declare namespace CVC.Common {
    interface UserPreferenceRow {
        UserPreferenceId?: number;
        UserId?: number;
        PreferenceType?: string;
        Name?: string;
        Value?: string;
    }
    namespace UserPreferenceRow {
        const idProperty = "UserPreferenceId";
        const nameProperty = "Name";
        const localTextPrefix = "Common.UserPreference";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            UserPreferenceId = "UserPreferenceId",
            UserId = "UserId",
            PreferenceType = "PreferenceType",
            Name = "Name",
            Value = "Value"
        }
    }
}
declare namespace CVC.Common {
    namespace UserPreferenceService {
        const baseUrl = "Common/UserPreference";
        function Update(request: UserPreferenceUpdateRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: UserPreferenceRetrieveRequest, onSuccess?: (response: UserPreferenceRetrieveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Update = "Common/UserPreference/Update",
            Retrieve = "Common/UserPreference/Retrieve"
        }
    }
}
declare namespace CVC.Common {
    interface UserPreferenceUpdateRequest extends Serenity.ServiceRequest {
        PreferenceType?: string;
        Name?: string;
        Value?: string;
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface CityDetailsForm {
        Country: Serenity.LookupEditor;
        State: Serenity.LookupEditor;
        City: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }
    class CityDetailsForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface CityDetailsRow {
        CityDetailsId?: number;
        Country?: string;
        State?: string;
        City?: string;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace CityDetailsRow {
        const idProperty = "CityDetailsId";
        const nameProperty = "City";
        const localTextPrefix = "Configuration.CityDetails";
        const lookupKey = "Configuration.CityDetails";
        function getLookup(): Q.Lookup<CityDetailsRow>;
        const deletePermission = "Configuration:CityDetails:Modify";
        const insertPermission = "Configuration:CityDetails:Modify";
        const readPermission = "Configuration:CityDetails:Read";
        const updatePermission = "Configuration:CityDetails:Modify";
        const enum Fields {
            CityDetailsId = "CityDetailsId",
            Country = "Country",
            State = "State",
            City = "City",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Configuration {
    namespace CityDetailsService {
        const baseUrl = "Configuration/CityDetails";
        function Create(request: Serenity.SaveRequest<CityDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CityDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CityDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CityDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/CityDetails/Create",
            Update = "Configuration/CityDetails/Update",
            Delete = "Configuration/CityDetails/Delete",
            Retrieve = "Configuration/CityDetails/Retrieve",
            List = "Configuration/CityDetails/List"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface CompanyForm {
        CompanyName: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        CityCountry: Serenity.LookupEditor;
        CityState: Serenity.LookupEditor;
        CityId: Serenity.LookupEditor;
        PinCode: Serenity.StringEditor;
        Website: Serenity.StringEditor;
        CompanyLogo: Serenity.ImageUploadEditor;
    }
    class CompanyForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface CompanyRow {
        CompanyId?: number;
        CompanyName?: string;
        Address?: string;
        CityId?: number;
        PinCode?: string;
        Website?: string;
        CompanyLogo?: string;
        CityCountry?: string;
        CityState?: string;
        City?: string;
        CityStatusId?: number;
        CityCreatedBy?: number;
        CityCreatedDate?: string;
        CityUpdatedBy?: number;
        CityUpdatedDate?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        CreatedByFullName?: string;
        UpdatedByFullName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace CompanyRow {
        const idProperty = "CompanyId";
        const nameProperty = "CompanyName";
        const localTextPrefix = "Configuration.Company";
        const deletePermission = "Configuration:Company:Modify";
        const insertPermission = "Configuration:Company:Modify";
        const readPermission = "Configuration:Company:Read";
        const updatePermission = "Configuration:Company:Modify";
        const enum Fields {
            CompanyId = "CompanyId",
            CompanyName = "CompanyName",
            Address = "Address",
            CityId = "CityId",
            PinCode = "PinCode",
            Website = "Website",
            CompanyLogo = "CompanyLogo",
            CityCountry = "CityCountry",
            CityState = "CityState",
            City = "City",
            CityStatusId = "CityStatusId",
            CityCreatedBy = "CityCreatedBy",
            CityCreatedDate = "CityCreatedDate",
            CityUpdatedBy = "CityUpdatedBy",
            CityUpdatedDate = "CityUpdatedDate",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            CreatedByFullName = "CreatedByFullName",
            UpdatedByFullName = "UpdatedByFullName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Configuration {
    namespace CompanyService {
        const baseUrl = "Configuration/Company";
        function Create(request: Serenity.SaveRequest<CompanyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CompanyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CompanyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CompanyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/Company/Create",
            Update = "Configuration/Company/Update",
            Delete = "Configuration/Company/Delete",
            Retrieve = "Configuration/Company/Retrieve",
            List = "Configuration/Company/List"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface CurrencyForm {
        CountryName: Serenity.StringEditor;
        CurrencyType: Serenity.StringEditor;
        Symbol: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class CurrencyForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface CurrencyRow {
        CurrencyId?: number;
        CountryName?: string;
        CurrencyType?: string;
        Symbol?: string;
        Description?: string;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        CreatedByFullName?: string;
    }
    namespace CurrencyRow {
        const idProperty = "CurrencyId";
        const nameProperty = "CountryName";
        const localTextPrefix = "Configuration.Currency";
        const lookupKey = "Configuration.Currency";
        function getLookup(): Q.Lookup<CurrencyRow>;
        const deletePermission = "Lookup";
        const insertPermission = "Lookup";
        const readPermission = "Lookup";
        const updatePermission = "Lookup";
        const enum Fields {
            CurrencyId = "CurrencyId",
            CountryName = "CountryName",
            CurrencyType = "CurrencyType",
            Symbol = "Symbol",
            Description = "Description",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            CreatedByFullName = "CreatedByFullName"
        }
    }
}
declare namespace CVC.Configuration {
    namespace CurrencyService {
        const baseUrl = "Configuration/Currency";
        function Create(request: Serenity.SaveRequest<CurrencyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CurrencyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CurrencyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CurrencyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/Currency/Create",
            Update = "Configuration/Currency/Update",
            Delete = "Configuration/Currency/Delete",
            Retrieve = "Configuration/Currency/Retrieve",
            List = "Configuration/Currency/List"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface DataTypeForm {
        DataTypeName: Serenity.StringEditor;
        TypeId: Serenity.IntegerEditor;
        Bit: Serenity.IntegerEditor;
        IsSigned: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class DataTypeForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface DataTypeRow {
        DataTypeId?: number;
        DataTypeName?: string;
        TypeId?: number;
        Bit?: number;
        IsSigned?: boolean;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace DataTypeRow {
        const idProperty = "DataTypeId";
        const nameProperty = "DataTypeName";
        const localTextPrefix = "MachineCustomization.DataType";
        const lookupKey = "Configuration.DataType";
        function getLookup(): Q.Lookup<DataTypeRow>;
        const deletePermission = "Lookup";
        const insertPermission = "Lookup";
        const readPermission = "Lookup";
        const updatePermission = "Lookup";
        const enum Fields {
            DataTypeId = "DataTypeId",
            DataTypeName = "DataTypeName",
            TypeId = "TypeId",
            Bit = "Bit",
            IsSigned = "IsSigned",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.Configuration {
    namespace DataTypeService {
        const baseUrl = "MachineCustomization/DataType";
        function Create(request: Serenity.SaveRequest<DataTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DataTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DataTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DataTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/DataType/Create",
            Update = "MachineCustomization/DataType/Update",
            Delete = "MachineCustomization/DataType/Delete",
            Retrieve = "MachineCustomization/DataType/Retrieve",
            List = "MachineCustomization/DataType/List"
        }
    }
}
declare namespace CVC.Configuration {
    interface DateFormatTypeLookUp {
        DateFormatTypeID?: number;
        DateFormatTypeValue?: string;
    }
    namespace DateFormatTypeLookUp {
        const idProperty = "DateFormatTypeID";
        const nameProperty = "DateFormatTypeValue";
        const localTextPrefix = "Configuration.DateFormatTypeLookUp";
        const lookupKey = "Configuration.DateFormatType";
        function getLookup(): Q.Lookup<DateFormatTypeLookUp>;
        const deletePermission = "Lookup";
        const insertPermission = "Lookup";
        const readPermission = "Lookup";
        const updatePermission = "Lookup";
        const enum Fields {
            DateFormatTypeID = "DateFormatTypeID",
            DateFormatTypeValue = "DateFormatTypeValue"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface DepartmentForm {
        DepartmentCode: Serenity.StringEditor;
        DepartmentName: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }
    class DepartmentForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface DepartmentRow {
        DepartmentId?: number;
        DepartmentCode?: string;
        DepartmentName?: string;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace DepartmentRow {
        const idProperty = "DepartmentId";
        const nameProperty = "DepartmentCode";
        const localTextPrefix = "Configuration.Department";
        const lookupKey = "Configuration.Department";
        function getLookup(): Q.Lookup<DepartmentRow>;
        const deletePermission = "Configuration:Department:Modify";
        const insertPermission = "Configuration:Department:Modify";
        const readPermission = "Configuration:Department:Read";
        const updatePermission = "Configuration:Department:Modify";
        const enum Fields {
            DepartmentId = "DepartmentId",
            DepartmentCode = "DepartmentCode",
            DepartmentName = "DepartmentName",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Configuration {
    namespace DepartmentService {
        const baseUrl = "Configuration/Department";
        function Create(request: Serenity.SaveRequest<DepartmentRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DepartmentRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DepartmentRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DepartmentRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/Department/Create",
            Update = "Configuration/Department/Update",
            Delete = "Configuration/Department/Delete",
            Retrieve = "Configuration/Department/Retrieve",
            List = "Configuration/Department/List"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface EnvironmentVariablesForm {
        BackupFolder: Serenity.StringEditor;
        BackupFrequencyNoOfDaya: Serenity.IntegerEditor;
        BackupTime: Serenity.IntegerEditor;
        IsOverWriteBackup: Serenity.BooleanEditor;
        DatabaseLimit: Serenity.IntegerEditor;
        ArchivalPath: Serenity.StringEditor;
        LastPeriodRetained: Serenity.IntegerEditor;
        SessionTimeOut: Serenity.IntegerEditor;
        IsPasswordChangeRequired: Serenity.BooleanEditor;
        PasswordMaxLength: Serenity.IntegerEditor;
        PasswordMinLength: Serenity.IntegerEditor;
        MinAlphaChars: Serenity.IntegerEditor;
        MinNumericChars: Serenity.IntegerEditor;
        MinSpecialChars: Serenity.IntegerEditor;
        MinCapitalLetter: Serenity.IntegerEditor;
        PreviousPasswordLimit: Serenity.IntegerEditor;
        PasswordExpiryInDays: Serenity.IntegerEditor;
        PasswordExpiryNotification: Serenity.IntegerEditor;
        LockInAttempt: Serenity.IntegerEditor;
        IsUnLockAfterTime: Serenity.BooleanEditor;
        UnLockTime: Serenity.IntegerEditor;
        DateFormatTypeID: Serenity.LookupEditor;
        TimeFormatTypeID: Serenity.LookupEditor;
        HourFormatTypeID: Serenity.LookupEditor;
        LicenseExpiryNotification: Serenity.IntegerEditor;
    }
    class EnvironmentVariablesForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface EnvironmentVariablesRow {
        EnvVariableId?: number;
        ReportLocation?: string;
        BackupFolder?: string;
        BackupFrequencyNoOfDaya?: number;
        BackupTime?: number;
        TimeZoneId?: string;
        TimeZoneName?: string;
        ScreenTimeOut?: number;
        IsPasswordChangeRequired?: boolean;
        PasswordMinLength?: number;
        PasswordMaxLength?: number;
        MinAlphaChars?: number;
        MinNumericChars?: number;
        MinSpecialChars?: number;
        MinCapitalLetter?: number;
        PasswordExpiryInDays?: number;
        CurrencyId?: number;
        LanguageId?: number;
        SessionTimeOut?: number;
        DateTimeFormat?: string;
        NumberFormat?: string;
        LockInAttempt?: number;
        UnLockTime?: number;
        IsUnLockAfterTime?: boolean;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        DateFormatTypeID?: number;
        DateFormatTypeValue?: string;
        TimeFormatTypeID?: number;
        TimeFormatValue?: string;
        HourFormatTypeID?: number;
        HourFormatTypeValue?: string;
        ArchivalPath?: string;
        LastPeriodRetained?: number;
        IsOverWriteBackup?: boolean;
        PasswordExpiryNotification?: number;
        PreviousPasswordLimit?: number;
        DatabaseLimit?: number;
        LicenseExpiryNotification?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace EnvironmentVariablesRow {
        const idProperty = "EnvVariableId";
        const nameProperty = "ReportLocation";
        const localTextPrefix = "Configuration.EnvironmentVariables";
        const deletePermission = "Configuration:EnvironmentVariable:Modify";
        const insertPermission = "Configuration:EnvironmentVariable:Modify";
        const readPermission = "Configuration:EnvironmentVariable:Read";
        const updatePermission = "Configuration:EnvironmentVariable:Modify";
        const enum Fields {
            EnvVariableId = "EnvVariableId",
            ReportLocation = "ReportLocation",
            BackupFolder = "BackupFolder",
            BackupFrequencyNoOfDaya = "BackupFrequencyNoOfDaya",
            BackupTime = "BackupTime",
            TimeZoneId = "TimeZoneId",
            TimeZoneName = "TimeZoneName",
            ScreenTimeOut = "ScreenTimeOut",
            IsPasswordChangeRequired = "IsPasswordChangeRequired",
            PasswordMinLength = "PasswordMinLength",
            PasswordMaxLength = "PasswordMaxLength",
            MinAlphaChars = "MinAlphaChars",
            MinNumericChars = "MinNumericChars",
            MinSpecialChars = "MinSpecialChars",
            MinCapitalLetter = "MinCapitalLetter",
            PasswordExpiryInDays = "PasswordExpiryInDays",
            CurrencyId = "CurrencyId",
            LanguageId = "LanguageId",
            SessionTimeOut = "SessionTimeOut",
            DateTimeFormat = "DateTimeFormat",
            NumberFormat = "NumberFormat",
            LockInAttempt = "LockInAttempt",
            UnLockTime = "UnLockTime",
            IsUnLockAfterTime = "IsUnLockAfterTime",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            DateFormatTypeID = "DateFormatTypeID",
            DateFormatTypeValue = "DateFormatTypeValue",
            TimeFormatTypeID = "TimeFormatTypeID",
            TimeFormatValue = "TimeFormatValue",
            HourFormatTypeID = "HourFormatTypeID",
            HourFormatTypeValue = "HourFormatTypeValue",
            ArchivalPath = "ArchivalPath",
            LastPeriodRetained = "LastPeriodRetained",
            IsOverWriteBackup = "IsOverWriteBackup",
            PasswordExpiryNotification = "PasswordExpiryNotification",
            PreviousPasswordLimit = "PreviousPasswordLimit",
            DatabaseLimit = "DatabaseLimit",
            LicenseExpiryNotification = "LicenseExpiryNotification",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Configuration {
    namespace EnvironmentVariablesService {
        const baseUrl = "Configuration/EnvironmentVariables";
        function Create(request: Serenity.SaveRequest<EnvironmentVariablesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<EnvironmentVariablesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<EnvironmentVariablesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<EnvironmentVariablesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/EnvironmentVariables/Create",
            Update = "Configuration/EnvironmentVariables/Update",
            Delete = "Configuration/EnvironmentVariables/Delete",
            Retrieve = "Configuration/EnvironmentVariables/Retrieve",
            List = "Configuration/EnvironmentVariables/List"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface LanguageForm {
        LanguageId: Serenity.StringEditor;
        LanguageName: Serenity.StringEditor;
    }
    class LanguageForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface LanguageRow {
        Id?: number;
        LanguageId?: string;
        LanguageName?: string;
    }
    namespace LanguageRow {
        const idProperty = "Id";
        const nameProperty = "LanguageName";
        const localTextPrefix = "Administration.Language";
        const lookupKey = "Configuration.Language";
        function getLookup(): Q.Lookup<LanguageRow>;
        const deletePermission = "Administration:Translation";
        const insertPermission = "Administration:Translation";
        const readPermission = "Administration:Translation";
        const updatePermission = "Administration:Translation";
        const enum Fields {
            Id = "Id",
            LanguageId = "LanguageId",
            LanguageName = "LanguageName"
        }
    }
}
declare namespace CVC.Configuration {
    namespace LanguageService {
        const baseUrl = "Configuration/Language";
        function Create(request: Serenity.SaveRequest<LanguageRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<LanguageRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LanguageRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LanguageRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/Language/Create",
            Update = "Configuration/Language/Update",
            Delete = "Configuration/Language/Delete",
            Retrieve = "Configuration/Language/Retrieve",
            List = "Configuration/Language/List"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface PickListForm {
        PickListName: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }
    class PickListForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface PickListRow {
        PickListId?: number;
        PickListName?: string;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace PickListRow {
        const idProperty = "PickListId";
        const nameProperty = "PickListName";
        const localTextPrefix = "Configuration.PickList";
        const lookupKey = "Configuration.PickList";
        function getLookup(): Q.Lookup<PickListRow>;
        const deletePermission = "Lookup";
        const insertPermission = "Lookup";
        const readPermission = "Lookup";
        const updatePermission = "Lookup";
        const enum Fields {
            PickListId = "PickListId",
            PickListName = "PickListName",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.Configuration {
    namespace PickListService {
        const baseUrl = "Configuration/PickList";
        function Create(request: Serenity.SaveRequest<PickListRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<PickListRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PickListRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PickListRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/PickList/Create",
            Update = "Configuration/PickList/Update",
            Delete = "Configuration/PickList/Delete",
            Retrieve = "Configuration/PickList/Retrieve",
            List = "Configuration/PickList/List"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface PickListValueForm {
        PickListId: Serenity.LookupEditor;
        PickListValueName: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }
    class PickListValueForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface PickListValueRoleAccessForm {
        PickListValueId: Serenity.IntegerEditor;
        RoleId: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class PickListValueRoleAccessForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface PickListValueRoleAccessRow {
        PickListValueRoleAccessId?: number;
        PickListValueId?: number;
        RoleId?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        PickListValuePickListId?: number;
        PickListValuePickListValueName?: string;
        PickListValueStatusId?: number;
        PickListValueCreatedBy?: number;
        PickListValueCreatedDate?: string;
        PickListValueUpdatedBy?: number;
        PickListValueUpdatedDate?: string;
        RoleRoleName?: string;
        RoleStatusId?: number;
        RoleIsHidden?: number;
        RoleParentRoleId?: number;
        RoleCreatedBy?: number;
        RoleCreatedDate?: string;
        RoleUpdatedBy?: number;
        RoleUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace PickListValueRoleAccessRow {
        const idProperty = "PickListValueRoleAccessId";
        const localTextPrefix = "Configuration.PickListValueRoleAccess";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            PickListValueRoleAccessId = "PickListValueRoleAccessId",
            PickListValueId = "PickListValueId",
            RoleId = "RoleId",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            PickListValuePickListId = "PickListValuePickListId",
            PickListValuePickListValueName = "PickListValuePickListValueName",
            PickListValueStatusId = "PickListValueStatusId",
            PickListValueCreatedBy = "PickListValueCreatedBy",
            PickListValueCreatedDate = "PickListValueCreatedDate",
            PickListValueUpdatedBy = "PickListValueUpdatedBy",
            PickListValueUpdatedDate = "PickListValueUpdatedDate",
            RoleRoleName = "RoleRoleName",
            RoleStatusId = "RoleStatusId",
            RoleIsHidden = "RoleIsHidden",
            RoleParentRoleId = "RoleParentRoleId",
            RoleCreatedBy = "RoleCreatedBy",
            RoleCreatedDate = "RoleCreatedDate",
            RoleUpdatedBy = "RoleUpdatedBy",
            RoleUpdatedDate = "RoleUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.Configuration {
    namespace PickListValueRoleAccessService {
        const baseUrl = "Configuration/PickListValueRoleAccess";
        function Create(request: Serenity.SaveRequest<PickListValueRoleAccessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<PickListValueRoleAccessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PickListValueRoleAccessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PickListValueRoleAccessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/PickListValueRoleAccess/Create",
            Update = "Configuration/PickListValueRoleAccess/Update",
            Delete = "Configuration/PickListValueRoleAccess/Delete",
            Retrieve = "Configuration/PickListValueRoleAccess/Retrieve",
            List = "Configuration/PickListValueRoleAccess/List"
        }
    }
}
declare namespace CVC.Configuration {
    interface PickListValueRow {
        PickListValueId?: number;
        PickListId?: number;
        PickListValueName?: string;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        PickListName?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace PickListValueRow {
        const idProperty = "PickListValueId";
        const nameProperty = "PickListValueName";
        const localTextPrefix = "Configuration.PickListValue";
        const lookupKey = "Configuration.PickListValue";
        function getLookup(): Q.Lookup<PickListValueRow>;
        const deletePermission = "Configuration:PickListValue:Modify";
        const insertPermission = "Configuration:PickListValue:Modify";
        const readPermission = "Configuration:PickListValue:Read";
        const updatePermission = "Configuration:PickListValue:Modify";
        const enum Fields {
            PickListValueId = "PickListValueId",
            PickListId = "PickListId",
            PickListValueName = "PickListValueName",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            PickListName = "PickListName",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Configuration {
    namespace PickListValueService {
        const baseUrl = "Configuration/PickListValue";
        function Create(request: Serenity.SaveRequest<PickListValueRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<PickListValueRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PickListValueRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PickListValueRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/PickListValue/Create",
            Update = "Configuration/PickListValue/Update",
            Delete = "Configuration/PickListValue/Delete",
            Retrieve = "Configuration/PickListValue/Retrieve",
            List = "Configuration/PickListValue/List"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface ShiftForm {
        ShiftName: Serenity.StringEditor;
        StartTime: Serenity.StringEditor;
        EndTime: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }
    class ShiftForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface ShiftRow {
        ShiftId?: number;
        ShiftName?: string;
        StartTime?: string;
        EndTime?: string;
        StatusId?: number;
        StatusStatusName?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace ShiftRow {
        const idProperty = "ShiftId";
        const nameProperty = "ShiftName";
        const localTextPrefix = "Configuration.Shift";
        const lookupKey = "Configuration.Shift";
        function getLookup(): Q.Lookup<ShiftRow>;
        const deletePermission = "Configuration:Shift:Modify";
        const insertPermission = "Configuration:Shift:Modify";
        const readPermission = "Configuration:Shift:Read";
        const updatePermission = "Configuration:Shift:Modify";
        const enum Fields {
            ShiftId = "ShiftId",
            ShiftName = "ShiftName",
            StartTime = "StartTime",
            EndTime = "EndTime",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Configuration {
    namespace ShiftService {
        const baseUrl = "Configuration/Shift";
        function Create(request: Serenity.SaveRequest<ShiftRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ShiftRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ShiftRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ShiftRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/Shift/Create",
            Update = "Configuration/Shift/Update",
            Delete = "Configuration/Shift/Delete",
            Retrieve = "Configuration/Shift/Retrieve",
            List = "Configuration/Shift/List"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface StatusForm {
        StatusName: Serenity.StringEditor;
    }
    class StatusForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface StatusRow {
        StatusId?: number;
        StatusName?: string;
    }
    namespace StatusRow {
        const idProperty = "StatusId";
        const nameProperty = "StatusName";
        const localTextPrefix = "Configuration.Status";
        const lookupKey = "Configuration.Status";
        function getLookup(): Q.Lookup<StatusRow>;
        const deletePermission = "Lookup";
        const insertPermission = "Lookup";
        const readPermission = "Lookup";
        const updatePermission = "Lookup";
        const enum Fields {
            StatusId = "StatusId",
            StatusName = "StatusName"
        }
    }
}
declare namespace CVC.Configuration {
    namespace StatusService {
        const baseUrl = "Configuration/Status";
        function Create(request: Serenity.SaveRequest<StatusRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<StatusRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<StatusRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<StatusRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/Status/Create",
            Update = "Configuration/Status/Update",
            Delete = "Configuration/Status/Delete",
            Retrieve = "Configuration/Status/Retrieve",
            List = "Configuration/Status/List"
        }
    }
}
declare namespace CVC.Configuration {
}
declare namespace CVC.Configuration {
    interface SupplierForm {
        SupplierName: Serenity.StringEditor;
        SupplierAddress: Serenity.StringEditor;
        CityCountry: Serenity.LookupEditor;
        CityState: Serenity.LookupEditor;
        CityId: Serenity.LookupEditor;
        PinCode: Serenity.StringEditor;
        MobileCode: Serenity.IntegerEditor;
        MobileNumber: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }
    class SupplierForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Configuration {
    interface SupplierRow {
        SupplierId?: number;
        SupplierName?: string;
        SupplierAddress?: string;
        CityId?: number;
        PinCode?: string;
        MobileCode?: number;
        MobileNumber?: number;
        StatusId?: number;
        StatusStatusName?: string;
        CityCountry?: string;
        CityState?: string;
        City?: string;
        CityStatusId?: number;
        CityCreatedBy?: number;
        CityCreatedDate?: string;
        CityUpdatedBy?: number;
        CityUpdatedDate?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace SupplierRow {
        const idProperty = "SupplierId";
        const nameProperty = "SupplierName";
        const localTextPrefix = "Configuration.Supplier";
        const lookupKey = "Configuration.Supplier";
        function getLookup(): Q.Lookup<SupplierRow>;
        const deletePermission = "Configuration:Supplier:Modify";
        const insertPermission = "Configuration:Supplier:Modify";
        const readPermission = "Configuration:Supplier:Read";
        const updatePermission = "Configuration:Supplier:Modify";
        const enum Fields {
            SupplierId = "SupplierId",
            SupplierName = "SupplierName",
            SupplierAddress = "SupplierAddress",
            CityId = "CityId",
            PinCode = "PinCode",
            MobileCode = "MobileCode",
            MobileNumber = "MobileNumber",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CityCountry = "CityCountry",
            CityState = "CityState",
            City = "City",
            CityStatusId = "CityStatusId",
            CityCreatedBy = "CityCreatedBy",
            CityCreatedDate = "CityCreatedDate",
            CityUpdatedBy = "CityUpdatedBy",
            CityUpdatedDate = "CityUpdatedDate",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.Configuration {
    namespace SupplierService {
        const baseUrl = "Configuration/Supplier";
        function Create(request: Serenity.SaveRequest<SupplierRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<SupplierRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SupplierRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SupplierRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Configuration/Supplier/Create",
            Update = "Configuration/Supplier/Update",
            Delete = "Configuration/Supplier/Delete",
            Retrieve = "Configuration/Supplier/Retrieve",
            List = "Configuration/Supplier/List"
        }
    }
}
declare namespace CVC.Configuration {
    interface TimeFormatTypeLookUp {
        TimeFormatTypeID?: number;
        TimeFormatValue?: string;
    }
    namespace TimeFormatTypeLookUp {
        const idProperty = "TimeFormatTypeID";
        const nameProperty = "TimeFormatValue";
        const localTextPrefix = "Configuration.TimeFormatTypeLookUp";
        const lookupKey = "Configuration.TimeFormatType";
        function getLookup(): Q.Lookup<TimeFormatTypeLookUp>;
        const deletePermission = "Lookup";
        const insertPermission = "Lookup";
        const readPermission = "Lookup";
        const updatePermission = "Lookup";
        const enum Fields {
            TimeFormatTypeID = "TimeFormatTypeID",
            TimeFormatValue = "TimeFormatValue"
        }
    }
}
declare namespace CVC.Configuration {
    interface TranslationItem {
        Key?: string;
        SourceText?: string;
        TargetText?: string;
        CustomText?: string;
    }
}
declare namespace CVC.Configuration {
    interface TranslationListRequest extends Serenity.ListRequest {
        SourceLanguageID?: string;
        TargetLanguageID?: string;
    }
}
declare namespace CVC.Configuration {
    namespace TranslationService {
        const baseUrl = "Configuration/Translation";
        function List(request: TranslationListRequest, onSuccess?: (response: Serenity.ListResponse<TranslationItem>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: TranslationUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            List = "Configuration/Translation/List",
            Update = "Configuration/Translation/Update"
        }
    }
}
declare namespace CVC.Configuration {
    interface TranslationUpdateRequest extends Serenity.ServiceRequest {
        TargetLanguageID?: string;
        Translations?: {
            [key: string]: string;
        };
    }
}
declare namespace CVC {
    interface ExcelImportRequest extends Serenity.ServiceRequest {
        FileName?: string;
    }
}
declare namespace CVC {
    interface ExcelImportResponse extends Serenity.ServiceResponse {
        Inserted?: number;
        Updated?: number;
        ErrorList?: string[];
    }
}
declare namespace CVC.ExternalApplicationInterface {
}
declare namespace CVC.ExternalApplicationInterface {
    interface IpcParameterForm {
        MachineId: Serenity.LookupEditor;
        MachineParameterId: Serenity.LookupEditor;
        ProtocolId: Serenity.LookupEditor;
        IpcAddress: Serenity.StringEditor;
        NodeId: Serenity.StringEditor;
        AttributeId: Serenity.LookupEditor;
        IpcParameterName: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
        IsBitWise: Serenity.BooleanEditor;
        BitWiseIndex: Serenity.IntegerEditor;
        Is32Bit: Serenity.BooleanEditor;
        Bit32Address: Serenity.StringEditor;
        IsWordSwap: Serenity.BooleanEditor;
        IsByteSwap: Serenity.BooleanEditor;
        IsStopATIPC: Serenity.BooleanEditor;
        IsShowAsMessageIPC: Serenity.BooleanEditor;
        IsBatchStartRequiredIPC: Serenity.BooleanEditor;
        IsResetOnBatchCreateIPC: Serenity.BooleanEditor;
        IsLabelRollIPC: Serenity.BooleanEditor;
        DisableParameterIdIPC: Serenity.LookupEditor;
        DisableParameterValueIPC: Serenity.StringEditor;
        IsStopOnBatchStopIPC: Serenity.BooleanEditor;
        OperationTypeIPC: Serenity.LookupEditor;
        OperationValueIPC: Serenity.DecimalEditor;
        IsAlarm: Serenity.BooleanEditor;
        IsMachineSpeed: Serenity.BooleanEditor;
        IsRefreshMachineSettings: Serenity.BooleanEditor;
        IsHeartBeat: Serenity.BooleanEditor;
        HeartBeatFailedTime: Serenity.IntegerEditor;
        IsHeartBeatSend: Serenity.BooleanEditor;
        IncrementalNumber: Serenity.IntegerEditor;
        StartNumber: Serenity.IntegerEditor;
        EndNumber: Serenity.IntegerEditor;
        IsWriteToPLC: Serenity.BooleanEditor;
        IsIndicatorParameter: Serenity.BooleanEditor;
        IndicatorParameterId: Serenity.LookupEditor;
        IsGoodBottles: Serenity.BooleanEditor;
        IsRejectBottles: Serenity.BooleanEditor;
        IsBatchSize: Serenity.BooleanEditor;
        IsCounterReset: Serenity.BooleanEditor;
        IsConveyer: Serenity.BooleanEditor;
        IsMissingLabelCounter: Serenity.BooleanEditor;
    }
    class IpcParameterForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.ExternalApplicationInterface {
    interface IpcParameterRow {
        IpcParameterId?: number;
        MachineId?: number;
        ProtocolId?: number;
        IpcParameterName?: string;
        MachineParameterId?: number;
        IpcAddress?: string;
        IsChangeInRuntime?: number;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        MachineMachineName?: string;
        MachineParameterName?: string;
        IsBitWise?: boolean;
        BitWiseIndex?: number;
        Is32Bit?: boolean;
        IsAlarm?: boolean;
        IsRefreshMachineSettings?: boolean;
        IsMachineSpeed?: boolean;
        Bit32Address?: string;
        IsWordSwap?: boolean;
        IsByteSwap?: boolean;
        IsStopATIPC?: boolean;
        IsShowAsMessageIPC?: boolean;
        IsBatchStartRequiredIPC?: boolean;
        IsResetOnBatchCreateIPC?: boolean;
        IsLabelRollIPC?: boolean;
        DisableParameterIdIPC?: number;
        DisableParameterValueIPC?: string;
        IsStopOnBatchStopIPC?: boolean;
        OperationTypeIPC?: number;
        OperationValueIPC?: number;
        IsHeartBeat?: boolean;
        IsHeartBeatSend?: boolean;
        HeartBeatFailedTime?: number;
        IncrementalNumber?: number;
        StartNumber?: number;
        EndNumber?: number;
        IsWriteToPLC?: boolean;
        IsIndicatorParameter?: boolean;
        IndicatorParameterId?: number;
        IsGoodBottles?: boolean;
        IsRejectBottles?: boolean;
        IsBatchSize?: boolean;
        IsCounterReset?: boolean;
        IsConveyer?: boolean;
        IsMissingLabelCounter?: boolean;
        NodeId?: string;
        AttributeId?: number;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace IpcParameterRow {
        const idProperty = "IpcParameterId";
        const nameProperty = "IpcParameterName";
        const localTextPrefix = "ExternalApplicationInterface.IpcParameter";
        const lookupKey = "ExternalApplicationInterface.IpcParameter";
        function getLookup(): Q.Lookup<IpcParameterRow>;
        const deletePermission = "EAI:IPCParameter:Modify";
        const insertPermission = "EAI:IPCParameter:Modify";
        const readPermission = "EAI:IPCParameter:Read";
        const updatePermission = "EAI:IPCParameter:Modify";
        const enum Fields {
            IpcParameterId = "IpcParameterId",
            MachineId = "MachineId",
            ProtocolId = "ProtocolId",
            IpcParameterName = "IpcParameterName",
            MachineParameterId = "MachineParameterId",
            IpcAddress = "IpcAddress",
            IsChangeInRuntime = "IsChangeInRuntime",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            MachineMachineName = "MachineMachineName",
            MachineParameterName = "MachineParameterName",
            IsBitWise = "IsBitWise",
            BitWiseIndex = "BitWiseIndex",
            Is32Bit = "Is32Bit",
            IsAlarm = "IsAlarm",
            IsRefreshMachineSettings = "IsRefreshMachineSettings",
            IsMachineSpeed = "IsMachineSpeed",
            Bit32Address = "Bit32Address",
            IsWordSwap = "IsWordSwap",
            IsByteSwap = "IsByteSwap",
            IsStopATIPC = "IsStopATIPC",
            IsShowAsMessageIPC = "IsShowAsMessageIPC",
            IsBatchStartRequiredIPC = "IsBatchStartRequiredIPC",
            IsResetOnBatchCreateIPC = "IsResetOnBatchCreateIPC",
            IsLabelRollIPC = "IsLabelRollIPC",
            DisableParameterIdIPC = "DisableParameterIdIPC",
            DisableParameterValueIPC = "DisableParameterValueIPC",
            IsStopOnBatchStopIPC = "IsStopOnBatchStopIPC",
            OperationTypeIPC = "OperationTypeIPC",
            OperationValueIPC = "OperationValueIPC",
            IsHeartBeat = "IsHeartBeat",
            IsHeartBeatSend = "IsHeartBeatSend",
            HeartBeatFailedTime = "HeartBeatFailedTime",
            IncrementalNumber = "IncrementalNumber",
            StartNumber = "StartNumber",
            EndNumber = "EndNumber",
            IsWriteToPLC = "IsWriteToPLC",
            IsIndicatorParameter = "IsIndicatorParameter",
            IndicatorParameterId = "IndicatorParameterId",
            IsGoodBottles = "IsGoodBottles",
            IsRejectBottles = "IsRejectBottles",
            IsBatchSize = "IsBatchSize",
            IsCounterReset = "IsCounterReset",
            IsConveyer = "IsConveyer",
            IsMissingLabelCounter = "IsMissingLabelCounter",
            NodeId = "NodeId",
            AttributeId = "AttributeId",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.ExternalApplicationInterface {
    namespace IpcParameterService {
        const baseUrl = "ExternalApplicationInterface/IpcParameter";
        function Create(request: Serenity.SaveRequest<IpcParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<IpcParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<IpcParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<IpcParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "ExternalApplicationInterface/IpcParameter/Create",
            Update = "ExternalApplicationInterface/IpcParameter/Update",
            Delete = "ExternalApplicationInterface/IpcParameter/Delete",
            Retrieve = "ExternalApplicationInterface/IpcParameter/Retrieve",
            List = "ExternalApplicationInterface/IpcParameter/List"
        }
    }
}
declare namespace CVC.ExternalApplicationInterface {
}
declare namespace CVC.ExternalApplicationInterface {
    interface MachineCommunicationForm {
        ProtocolTypeId: Serenity.LookupEditor;
        MachineId: Serenity.LookupEditor;
        IpAddress: Serenity.StringEditor;
        TcpipPort: Serenity.IntegerEditor;
        PollRate: Serenity.IntegerEditor;
        MDBPath: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
        SecurityModeId: Serenity.LookupEditor;
        SecurityPolicyId: Serenity.LookupEditor;
        UserIdentityId: Serenity.LookupEditor;
        UserName: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
        CpuTypeId: Serenity.LookupEditor;
        Rack: Serenity.IntegerEditor;
        Slot: Serenity.IntegerEditor;
    }
    class MachineCommunicationForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.ExternalApplicationInterface {
    interface MachineCommunicationRow {
        MachineCommunicatonId?: number;
        ProtocolTypeId?: number;
        MachineId?: number;
        IpAddress?: string;
        MDBPath?: string;
        TcpipPort?: number;
        PollRate?: number;
        UserName?: string;
        Password?: string;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        ProtocolName?: string;
        MachineMachineName?: string;
        SecurityModeId?: number;
        SecurityPolicyId?: number;
        UserIdentityId?: number;
        IsConnected?: boolean;
        RecordAddedSource?: string;
        CpuTypeId?: number;
        Rack?: number;
        Slot?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace MachineCommunicationRow {
        const idProperty = "MachineCommunicatonId";
        const nameProperty = "ProtocolName";
        const localTextPrefix = "ExternalApplicationInterface.MachineCommunication";
        const lookupKey = "ExternalApplicationInterface.MachineCommunication";
        function getLookup(): Q.Lookup<MachineCommunicationRow>;
        const deletePermission = "EAI:MachineCommunication:Modify";
        const insertPermission = "EAI:MachineCommunication:Modify";
        const readPermission = "EAI:MachineCommunication:Read";
        const updatePermission = "EAI:MachineCommunication:Modify";
        const enum Fields {
            MachineCommunicatonId = "MachineCommunicatonId",
            ProtocolTypeId = "ProtocolTypeId",
            MachineId = "MachineId",
            IpAddress = "IpAddress",
            MDBPath = "MDBPath",
            TcpipPort = "TcpipPort",
            PollRate = "PollRate",
            UserName = "UserName",
            Password = "Password",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            ProtocolName = "ProtocolName",
            MachineMachineName = "MachineMachineName",
            SecurityModeId = "SecurityModeId",
            SecurityPolicyId = "SecurityPolicyId",
            UserIdentityId = "UserIdentityId",
            IsConnected = "IsConnected",
            RecordAddedSource = "RecordAddedSource",
            CpuTypeId = "CpuTypeId",
            Rack = "Rack",
            Slot = "Slot",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.ExternalApplicationInterface {
    namespace MachineCommunicationService {
        const baseUrl = "ExternalApplicationInterface/MachineCommunication";
        function Create(request: Serenity.SaveRequest<MachineCommunicationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineCommunicationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineCommunicationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineCommunicationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "ExternalApplicationInterface/MachineCommunication/Create",
            Update = "ExternalApplicationInterface/MachineCommunication/Update",
            Delete = "ExternalApplicationInterface/MachineCommunication/Delete",
            Retrieve = "ExternalApplicationInterface/MachineCommunication/Retrieve",
            List = "ExternalApplicationInterface/MachineCommunication/List"
        }
    }
}
declare namespace CVC.ExternalApplicationInterface {
}
declare namespace CVC.ExternalApplicationInterface {
    interface ProtocolForm {
        ProtocolName: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }
    class ProtocolForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.ExternalApplicationInterface {
    interface ProtocolRow {
        ProtocolId?: number;
        ProtocolName?: string;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace ProtocolRow {
        const idProperty = "ProtocolId";
        const nameProperty = "ProtocolName";
        const localTextPrefix = "ExternalApplicationInterface.Protocol";
        const lookupKey = "ExternalApplicationInterface.Protocol";
        function getLookup(): Q.Lookup<ProtocolRow>;
        const deletePermission = "EAI:Protocol:Modify";
        const insertPermission = "EAI:Protocol:Modify";
        const readPermission = "EAI:Protocol:Read";
        const updatePermission = "EAI:Protocol:Modify";
        const enum Fields {
            ProtocolId = "ProtocolId",
            ProtocolName = "ProtocolName",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.ExternalApplicationInterface {
    namespace ProtocolService {
        const baseUrl = "ExternalApplicationInterface/Protocol";
        function Create(request: Serenity.SaveRequest<ProtocolRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ProtocolRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ProtocolRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ProtocolRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "ExternalApplicationInterface/Protocol/Create",
            Update = "ExternalApplicationInterface/Protocol/Update",
            Delete = "ExternalApplicationInterface/Protocol/Delete",
            Retrieve = "ExternalApplicationInterface/Protocol/Retrieve",
            List = "ExternalApplicationInterface/Protocol/List"
        }
    }
}
declare namespace CVC {
    interface GetNextNumberRequest extends Serenity.ServiceRequest {
        Prefix?: string;
        Length?: number;
    }
}
declare namespace CVC {
    interface GetNextNumberResponse extends Serenity.ServiceResponse {
        Number?: number;
        Serial?: string;
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface AlarmDisplayForm {
        AlarmDisplayName: Serenity.StringEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        CautionColor: Common.CustomEditors.ColorPickerEditor;
        WarningColor: Common.CustomEditors.ColorPickerEditor;
        EmergencyColor: Common.CustomEditors.ColorPickerEditor;
        IsCheckbox: Serenity.BooleanEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Appearance: Common.CustomEditors.AppearanceValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsOpenInNewWindow: Serenity.BooleanEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsFolderBrowse: Serenity.BooleanEditor;
        IsAddAttachments: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }
    class AlarmDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface AlarmDisplayRow {
        AlarmDisplayId?: number;
        AlarmDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        IsCheckbox?: boolean;
        Font?: string;
        FontColorSelected?: string;
        FontColorUnselected?: string;
        CautionColor?: string;
        WarningColor?: string;
        EmergencyColor?: string;
        Activation?: number;
        Appearance?: number;
        IsOpenInNewWindow?: boolean;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        Alignment?: number;
        IsFolderBrowse?: boolean;
        IsAddAttachments?: boolean;
        IsCollapsible?: boolean;
    }
    namespace AlarmDisplayRow {
        const idProperty = "AlarmDisplayId";
        const nameProperty = "AlarmDisplayName";
        const localTextPrefix = "MachineCustomization.AlarmDisplay";
        const lookupKey = "MachineCustomization.AlarmDisplay";
        function getLookup(): Q.Lookup<AlarmDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            AlarmDisplayId = "AlarmDisplayId",
            AlarmDisplayName = "AlarmDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            IsCheckbox = "IsCheckbox",
            Font = "Font",
            FontColorSelected = "FontColorSelected",
            FontColorUnselected = "FontColorUnselected",
            CautionColor = "CautionColor",
            WarningColor = "WarningColor",
            EmergencyColor = "EmergencyColor",
            Activation = "Activation",
            Appearance = "Appearance",
            IsOpenInNewWindow = "IsOpenInNewWindow",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            Alignment = "Alignment",
            IsFolderBrowse = "IsFolderBrowse",
            IsAddAttachments = "IsAddAttachments",
            IsCollapsible = "IsCollapsible"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace AlarmDisplayService {
        const baseUrl = "MachineCustomization/AlarmDisplay";
        function Create(request: Serenity.SaveRequest<AlarmDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<AlarmDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AlarmDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AlarmDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/AlarmDisplay/Create",
            Update = "MachineCustomization/AlarmDisplay/Update",
            Delete = "MachineCustomization/AlarmDisplay/Delete",
            Retrieve = "MachineCustomization/AlarmDisplay/Retrieve",
            List = "MachineCustomization/AlarmDisplay/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
    interface AlarmForm {
        AlarmName: Serenity.StringEditor;
        MachineId: Serenity.LookupEditor;
        MachineParameterId: Serenity.LookupEditor;
        Message: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        IsResetRequired: Serenity.BooleanEditor;
        IsCommentRequired: Serenity.BooleanEditor;
        IsMachineRequiredToStop: Serenity.BooleanEditor;
        MachineStopMachineParameterId: Serenity.LookupEditor;
        IsCountForReject: Serenity.BooleanEditor;
        BitValue: Serenity.BooleanEditor;
        IsCheckAtMachineStart: Serenity.BooleanEditor;
        StatusId: Serenity.LookupEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
        IsRefreshMachineSettings: Serenity.BooleanEditor;
        IsHideEdit: Serenity.BooleanEditor;
        IsAlarmForCounter: Serenity.BooleanEditor;
    }
    class AlarmForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface AlarmResetIdForm {
        AlarmId: Serenity.IntegerEditor;
        RoleId: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class AlarmResetIdForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface AlarmResetIdRow {
        AlarmResetRoleId?: number;
        AlarmId?: number;
        RoleId?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace AlarmResetIdRow {
        const idProperty = "AlarmResetRoleId";
        const localTextPrefix = "MachineCustomization.AlarmResetId";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            AlarmResetRoleId = "AlarmResetRoleId",
            AlarmId = "AlarmId",
            RoleId = "RoleId",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace AlarmResetIdService {
        const baseUrl = "MachineCustomization/AlarmResetId";
        function Create(request: Serenity.SaveRequest<AlarmResetIdRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<AlarmResetIdRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AlarmResetIdRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AlarmResetIdRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/AlarmResetId/Create",
            Update = "MachineCustomization/AlarmResetId/Update",
            Delete = "MachineCustomization/AlarmResetId/Delete",
            Retrieve = "MachineCustomization/AlarmResetId/Retrieve",
            List = "MachineCustomization/AlarmResetId/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
    interface AlarmRow {
        AlarmId?: number;
        AlarmName?: string;
        MachineId?: number;
        MachineParameterId?: number;
        Message?: string;
        Description?: string;
        IsResetRequired?: boolean;
        IsCommentRequired?: boolean;
        IsMachineRequiredToStop?: boolean;
        MachineStopMachineParameterId?: number;
        IsCountForReject?: boolean;
        BitValue?: boolean;
        IsCheckAtMachineStart?: boolean;
        StatusId?: number;
        MachineStopMachineParameterMachineId?: number;
        MachineStopMachineParameterMachineParameterName?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByBirthDate?: string;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByBirthDate?: string;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        MachineMachineName?: string;
        MachineParameterMachineParameterName?: string;
        IsResetRequiredString?: string;
        IsCommentRequiredString?: string;
        IsMachineRequiredToStopString?: string;
        IsCountForRejectString?: string;
        BitValueString?: string;
        IsCheckAtMachineStartString?: string;
        IsRefreshMachineSettings?: boolean;
        IsHideEdit?: boolean;
        IsAlarmForCounter?: boolean;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace AlarmRow {
        const idProperty = "AlarmId";
        const nameProperty = "AlarmName";
        const localTextPrefix = "MachineCustomization.Alarm";
        const deletePermission = "MachineCustomization:Alarm:Modify";
        const insertPermission = "MachineCustomization:Alarm:Modify";
        const readPermission = "MachineCustomization:Alarm:Read";
        const updatePermission = "MachineCustomization:Alarm:Modify";
        const enum Fields {
            AlarmId = "AlarmId",
            AlarmName = "AlarmName",
            MachineId = "MachineId",
            MachineParameterId = "MachineParameterId",
            Message = "Message",
            Description = "Description",
            IsResetRequired = "IsResetRequired",
            IsCommentRequired = "IsCommentRequired",
            IsMachineRequiredToStop = "IsMachineRequiredToStop",
            MachineStopMachineParameterId = "MachineStopMachineParameterId",
            IsCountForReject = "IsCountForReject",
            BitValue = "BitValue",
            IsCheckAtMachineStart = "IsCheckAtMachineStart",
            StatusId = "StatusId",
            MachineStopMachineParameterMachineId = "MachineStopMachineParameterMachineId",
            MachineStopMachineParameterMachineParameterName = "MachineStopMachineParameterMachineParameterName",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByBirthDate = "CreatedByBirthDate",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByBirthDate = "UpdatedByBirthDate",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            MachineMachineName = "MachineMachineName",
            MachineParameterMachineParameterName = "MachineParameterMachineParameterName",
            IsResetRequiredString = "IsResetRequiredString",
            IsCommentRequiredString = "IsCommentRequiredString",
            IsMachineRequiredToStopString = "IsMachineRequiredToStopString",
            IsCountForRejectString = "IsCountForRejectString",
            BitValueString = "BitValueString",
            IsCheckAtMachineStartString = "IsCheckAtMachineStartString",
            IsRefreshMachineSettings = "IsRefreshMachineSettings",
            IsHideEdit = "IsHideEdit",
            IsAlarmForCounter = "IsAlarmForCounter",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace AlarmService {
        const baseUrl = "MachineCustomization/Alarm";
        function Create(request: Serenity.SaveRequest<AlarmRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<AlarmRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AlarmRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AlarmRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/Alarm/Create",
            Update = "MachineCustomization/Alarm/Update",
            Delete = "MachineCustomization/Alarm/Delete",
            Retrieve = "MachineCustomization/Alarm/Retrieve",
            List = "MachineCustomization/Alarm/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface AttachmentDisplayForm {
        AttachmentDisplayName: Serenity.StringEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        IsCheckbox: Serenity.BooleanEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsOpenInNewWindow: Serenity.BooleanEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsFolderBrowse: Serenity.BooleanEditor;
        IsAddAttachments: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }
    class AttachmentDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface AttachmentDisplayRow {
        AttachmentDisplayId?: number;
        AttachmentDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        IsCheckbox?: boolean;
        Font?: string;
        FontColorSelected?: string;
        FontColorUnselected?: string;
        Activation?: number;
        IsOpenInNewWindow?: boolean;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        Alignment?: number;
        IsFolderBrowse?: boolean;
        IsAddAttachments?: boolean;
        IsCollapsible?: boolean;
    }
    namespace AttachmentDisplayRow {
        const idProperty = "AttachmentDisplayId";
        const nameProperty = "AttachmentDisplayName";
        const localTextPrefix = "MachineCustomization.AttachmentDisplay";
        const lookupKey = "MachineCustomization.AttachmentDisplay";
        function getLookup(): Q.Lookup<AttachmentDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            AttachmentDisplayId = "AttachmentDisplayId",
            AttachmentDisplayName = "AttachmentDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            IsCheckbox = "IsCheckbox",
            Font = "Font",
            FontColorSelected = "FontColorSelected",
            FontColorUnselected = "FontColorUnselected",
            Activation = "Activation",
            IsOpenInNewWindow = "IsOpenInNewWindow",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            Alignment = "Alignment",
            IsFolderBrowse = "IsFolderBrowse",
            IsAddAttachments = "IsAddAttachments",
            IsCollapsible = "IsCollapsible"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace AttachmentDisplayService {
        const baseUrl = "MachineCustomization/AttachmentDisplay";
        function Create(request: Serenity.SaveRequest<AttachmentDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<AttachmentDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AttachmentDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AttachmentDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/AttachmentDisplay/Create",
            Update = "MachineCustomization/AttachmentDisplay/Update",
            Delete = "MachineCustomization/AttachmentDisplay/Delete",
            Retrieve = "MachineCustomization/AttachmentDisplay/Retrieve",
            List = "MachineCustomization/AttachmentDisplay/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface ButtonDisplayForm {
        ButtonDisplayName: Serenity.StringEditor;
        Font: Common.CustomEditors.FontValueEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }
    class ButtonDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface ButtonDisplayRow {
        ButtonDisplayId?: number;
        ButtonDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColorSelected?: string;
        FontColorUnselected?: string;
        Activation?: number;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsCollapsible?: boolean;
    }
    namespace ButtonDisplayRow {
        const idProperty = "ButtonDisplayId";
        const nameProperty = "ButtonDisplayName";
        const localTextPrefix = "MachineCustomization.ButtonDisplay";
        const lookupKey = "MachineCustomization.ButtonDisplay";
        function getLookup(): Q.Lookup<ButtonDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            ButtonDisplayId = "ButtonDisplayId",
            ButtonDisplayName = "ButtonDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColorSelected = "FontColorSelected",
            FontColorUnselected = "FontColorUnselected",
            Activation = "Activation",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsCollapsible = "IsCollapsible"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace ButtonDisplayService {
        const baseUrl = "MachineCustomization/ButtonDisplay";
        function Create(request: Serenity.SaveRequest<ButtonDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ButtonDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ButtonDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ButtonDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/ButtonDisplay/Create",
            Update = "MachineCustomization/ButtonDisplay/Update",
            Delete = "MachineCustomization/ButtonDisplay/Delete",
            Retrieve = "MachineCustomization/ButtonDisplay/Retrieve",
            List = "MachineCustomization/ButtonDisplay/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
    interface ColumnIDRow {
        ColumnName?: string;
        ColumnId?: number;
    }
}
declare namespace CVC.MachineCustomization {
    interface ColumnIdsRequest extends Serenity.ServiceRequest {
        TableId?: number;
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface ContainerDisplayForm {
        ContainerDisplayName: Serenity.StringEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsOpenInNewWindow: Serenity.BooleanEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }
    class ContainerDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface ContainerDisplayRow {
        ContainerDisplayId?: number;
        ContainerDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColorSelected?: string;
        FontColorUnselected?: string;
        Activation?: number;
        IsOpenInNewWindow?: boolean;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        Alignment?: number;
        IsCollapsible?: boolean;
    }
    namespace ContainerDisplayRow {
        const idProperty = "ContainerDisplayId";
        const nameProperty = "ContainerDisplayName";
        const localTextPrefix = "MachineCustomization.ContainerDisplay";
        const lookupKey = "MachineCustomization.ContainerDisplay";
        function getLookup(): Q.Lookup<ContainerDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            ContainerDisplayId = "ContainerDisplayId",
            ContainerDisplayName = "ContainerDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColorSelected = "FontColorSelected",
            FontColorUnselected = "FontColorUnselected",
            Activation = "Activation",
            IsOpenInNewWindow = "IsOpenInNewWindow",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            Alignment = "Alignment",
            IsCollapsible = "IsCollapsible"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace ContainerDisplayService {
        const baseUrl = "MachineCustomization/ContainerDisplay";
        function Create(request: Serenity.SaveRequest<ContainerDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ContainerDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ContainerDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ContainerDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/ContainerDisplay/Create",
            Update = "MachineCustomization/ContainerDisplay/Update",
            Delete = "MachineCustomization/ContainerDisplay/Delete",
            Retrieve = "MachineCustomization/ContainerDisplay/Retrieve",
            List = "MachineCustomization/ContainerDisplay/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectColorForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface DisplayObjectColorForm {
        RangeFrom: Serenity.DecimalEditor;
        RangeTo: Serenity.DecimalEditor;
        Color: Serenity.StringEditor;
        ViewsId: Serenity.IntegerEditor;
    }
}
declare namespace CVC.MachineCustomization {
    interface DisplayObjectColorRow {
        ColorId?: number;
        RangeFrom?: number;
        RangeTo?: number;
        Color?: string;
        ViewsId?: number;
        ViewsModuleId?: number;
        ViewsViewName?: string;
        ViewsIsAccessFieldWise?: boolean;
        ViewsStatusId?: number;
        ViewsCreatedBy?: number;
        ViewsCreatedDate?: string;
        ViewsUpdatedBy?: number;
        ViewsUpdatedDate?: string;
        ViewsIsMachineSettings?: boolean;
        ViewsIsMachineSummary?: boolean;
        ViewsIslabelRoll?: boolean;
        ViewsIsCommandPanel?: boolean;
        ViewsIsFactorySetting?: boolean;
        ViewsDisplayObjectTypeId?: number;
        ViewsMachineId?: number;
        ViewsListDisplayId?: number;
        ViewsFormDisplayId?: number;
        ViewsButtonDisplayId?: number;
        ViewsRealtimeParameterDisplayId?: number;
        ViewsLineChartDisplayId?: number;
        ViewsPieChartDisplayId?: number;
        ViewsTreeDisplayId?: number;
        ViewsAttachmentDisplayId?: number;
        ViewsAlarmDisplayId?: number;
        ViewsNotificationDisplayId?: number;
        ViewsContainerDisplayId?: number;
    }
    namespace DisplayObjectColorRow {
        const idProperty = "ColorId";
        const nameProperty = "Color";
        const localTextPrefix = "MachineCustomization.DisplayObjectColor";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        namespace Fields {
            const ColorId: any;
            const RangeFrom: any;
            const RangeTo: any;
            const Color: any;
            const ViewsId: any;
            const ViewsModuleId: any;
            const ViewsViewName: any;
            const ViewsIsAccessFieldWise: any;
            const ViewsStatusId: any;
            const ViewsCreatedBy: any;
            const ViewsCreatedDate: any;
            const ViewsUpdatedBy: any;
            const ViewsUpdatedDate: any;
            const ViewsIsMachineSettings: any;
            const ViewsIsMachineSummary: any;
            const ViewsIslabelRoll: any;
            const ViewsIsCommandPanel: any;
            const ViewsIsFactorySetting: any;
            const ViewsDisplayObjectTypeId: any;
            const ViewsMachineId: any;
            const ViewsListDisplayId: any;
            const ViewsFormDisplayId: any;
            const ViewsButtonDisplayId: any;
            const ViewsRealtimeParameterDisplayId: any;
            const ViewsLineChartDisplayId: any;
            const ViewsPieChartDisplayId: any;
            const ViewsTreeDisplayId: any;
            const ViewsAttachmentDisplayId: any;
            const ViewsAlarmDisplayId: any;
            const ViewsNotificationDisplayId: any;
            const ViewsContainerDisplayId: any;
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace DisplayObjectColorService {
        const baseUrl = "MachineCustomization/DisplayObjectColor";
        function Create(request: Serenity.SaveRequest<DisplayObjectColorRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DisplayObjectColorRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DisplayObjectColorRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DisplayObjectColorRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function FetchAllColumns(request: ColumnIdsRequest, onSuccess?: (response: Serenity.ListResponse<ColumnIDRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/DisplayObjectColor/Create",
            Update = "MachineCustomization/DisplayObjectColor/Update",
            Delete = "MachineCustomization/DisplayObjectColor/Delete",
            Retrieve = "MachineCustomization/DisplayObjectColor/Retrieve",
            List = "MachineCustomization/DisplayObjectColor/List",
            FetchAllColumns = "MachineCustomization/DisplayObjectColor/FetchAllColumns"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface DisplayObjectFieldForm {
        ViewFieldName: Serenity.StringEditor;
        ViewsId: DisplayObjectLookupEditor;
        MachineParameterId: Serenity.LookupEditor;
        Sequence: Serenity.IntegerEditor;
        StatusId: Serenity.LookupEditor;
        IsPopUpRequired: Serenity.BooleanEditor;
        IsCommentRequired: Serenity.BooleanEditor;
        IsAuthenticationRequired: Serenity.BooleanEditor;
        IsSelectAllRoles: Serenity.BooleanEditor;
        Roles: Serenity.LookupEditor;
    }
    class DisplayObjectFieldForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface DisplayObjectFieldRow {
        ViewField?: number;
        ViewsId?: number;
        ViewFieldName?: string;
        StatusId?: number;
        Sequence?: number;
        MachineParameterId?: number;
        IsPopUpRequired?: boolean;
        IsCommentRequired?: boolean;
        IsAuthenticationRequired?: boolean;
        ModuleId?: number;
        Roles?: number[];
        IsSelectAllRoles?: boolean;
        ViewsModuleId?: number;
        ViewsViewName?: string;
        ViewsIsAccessFieldWise?: boolean;
        ViewsStatusId?: number;
        ViewsCreatedBy?: number;
        ViewsCreatedDate?: string;
        ViewsUpdatedBy?: number;
        ViewsUpdatedDate?: string;
        ViewsIsMachineSettings?: boolean;
        ViewsIsMachineSummary?: boolean;
        ViewsIslabelRoll?: boolean;
        ViewsIsCommandPanel?: boolean;
        ViewsIsFactorySetting?: boolean;
        ViewsDisplayObjectTypeId?: number;
        ViewsMachineId?: number;
        ViewsListDisplayId?: number;
        ViewsFormDisplayId?: number;
        ViewsButtonDisplayId?: number;
        ViewsRealtimeParameterDisplayId?: number;
        ViewsLineChartDisplayId?: number;
        ViewsPieChartDisplayId?: number;
        ViewsTreeDisplayId?: number;
        ViewsAttachmentDisplayId?: number;
        ViewsAlarmDisplayId?: number;
        ViewsNotificationDisplayId?: number;
        ViewsContainerDisplayId?: number;
        StatusStatusName?: string;
        MachineName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: boolean;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: boolean;
        CreatedByBirthDate?: string;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        CreatedByQuestionId?: number;
        CreatedByQuestionAns?: string;
        CreatedByIsLockOut?: boolean;
        CreatedByLockOutDateTime?: string;
        CreatedByLogInAttempt?: number;
        CreatedByIsActiveDirectory?: boolean;
        CreatedByMachineId?: string;
        CreatedByRecordAddedSource?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: boolean;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: boolean;
        UpdatedByBirthDate?: string;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        UpdatedByQuestionId?: number;
        UpdatedByQuestionAns?: string;
        UpdatedByIsLockOut?: boolean;
        UpdatedByLockOutDateTime?: string;
        UpdatedByLogInAttempt?: number;
        UpdatedByIsActiveDirectory?: boolean;
        UpdatedByMachineId?: string;
        UpdatedByRecordAddedSource?: string;
        MachineParameterMachineId?: number;
        MachineParameterParameterName?: string;
        MachineParameterPlcAddress?: string;
        MachineParameterDescription?: string;
        MachineParameterDataTypeId?: number;
        MachineParameterIsRangeUnlimited?: boolean;
        MachineParameterMin?: number;
        MachineParameterMax?: number;
        MachineParameterIsUseUnit?: boolean;
        MachineParameterUnitId?: number;
        MachineParameterStatusId?: number;
        MachineParameterCreatedBy?: number;
        MachineParameterCreatedDate?: string;
        MachineParameterUpdatedBy?: number;
        MachineParameterUpdatedDate?: string;
        MachineParameterType?: number;
        MachineParameterIsRead?: boolean;
        MachineParameterIsWrite?: boolean;
        MachineParameterRowId?: number;
        MachineParameterIsBitWise?: boolean;
        MachineParameterBitWiseIndex?: number;
        MachineParameterQueryTypeRowId?: number;
        MachineParameterOperationType?: number;
        MachineParameterOperationValue?: number;
        MachineParameterIs32Bit?: boolean;
        MachineParameterBit32RowId?: number;
        MachineParameterIsStopAt?: boolean;
        MachineParameterReadMachineParameterId?: number;
        MachineParameterReloadMachineParameterId?: number;
        MachineParameterIsShowAsMessage?: boolean;
        MachineParameterIsBatchStartRequired?: boolean;
        MachineParameterIsResetOnBatchCreate?: boolean;
        MachineParameterIsLabelRoll?: boolean;
        MachineParameterDisableParameterId?: number;
        MachineParameterDisableParameterValue?: string;
        MachineParameterAllowDecimalPoint?: boolean;
        MachineParameterIsStopOnBatchStop?: boolean;
        MachineParameterRecordAddedSource?: string;
        MachineParameterColumnName?: string;
        MachineParameterPickListId?: number;
        ModuleModuleName?: string;
        ModuleMachineId?: number;
        ModuleStatusId?: number;
        ModuleCreatedBy?: number;
        ModuleCreatedDate?: string;
        ModuleUpdatedBy?: number;
        ModuleUpdatedDate?: string;
        ModuleSequence?: number;
        ModuleEquipmentId?: string;
        ModuleSerialNumber?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace DisplayObjectFieldRow {
        const idProperty = "ViewField";
        const nameProperty = "ViewFieldName";
        const localTextPrefix = "MachineCustomization.DisplayObjectField";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            ViewField = "ViewField",
            ViewsId = "ViewsId",
            ViewFieldName = "ViewFieldName",
            StatusId = "StatusId",
            Sequence = "Sequence",
            MachineParameterId = "MachineParameterId",
            IsPopUpRequired = "IsPopUpRequired",
            IsCommentRequired = "IsCommentRequired",
            IsAuthenticationRequired = "IsAuthenticationRequired",
            ModuleId = "ModuleId",
            Roles = "Roles",
            IsSelectAllRoles = "IsSelectAllRoles",
            ViewsModuleId = "ViewsModuleId",
            ViewsViewName = "ViewsViewName",
            ViewsIsAccessFieldWise = "ViewsIsAccessFieldWise",
            ViewsStatusId = "ViewsStatusId",
            ViewsCreatedBy = "ViewsCreatedBy",
            ViewsCreatedDate = "ViewsCreatedDate",
            ViewsUpdatedBy = "ViewsUpdatedBy",
            ViewsUpdatedDate = "ViewsUpdatedDate",
            ViewsIsMachineSettings = "ViewsIsMachineSettings",
            ViewsIsMachineSummary = "ViewsIsMachineSummary",
            ViewsIslabelRoll = "ViewsIslabelRoll",
            ViewsIsCommandPanel = "ViewsIsCommandPanel",
            ViewsIsFactorySetting = "ViewsIsFactorySetting",
            ViewsDisplayObjectTypeId = "ViewsDisplayObjectTypeId",
            ViewsMachineId = "ViewsMachineId",
            ViewsListDisplayId = "ViewsListDisplayId",
            ViewsFormDisplayId = "ViewsFormDisplayId",
            ViewsButtonDisplayId = "ViewsButtonDisplayId",
            ViewsRealtimeParameterDisplayId = "ViewsRealtimeParameterDisplayId",
            ViewsLineChartDisplayId = "ViewsLineChartDisplayId",
            ViewsPieChartDisplayId = "ViewsPieChartDisplayId",
            ViewsTreeDisplayId = "ViewsTreeDisplayId",
            ViewsAttachmentDisplayId = "ViewsAttachmentDisplayId",
            ViewsAlarmDisplayId = "ViewsAlarmDisplayId",
            ViewsNotificationDisplayId = "ViewsNotificationDisplayId",
            ViewsContainerDisplayId = "ViewsContainerDisplayId",
            StatusStatusName = "StatusStatusName",
            MachineName = "MachineName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByBirthDate = "CreatedByBirthDate",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            CreatedByQuestionId = "CreatedByQuestionId",
            CreatedByQuestionAns = "CreatedByQuestionAns",
            CreatedByIsLockOut = "CreatedByIsLockOut",
            CreatedByLockOutDateTime = "CreatedByLockOutDateTime",
            CreatedByLogInAttempt = "CreatedByLogInAttempt",
            CreatedByIsActiveDirectory = "CreatedByIsActiveDirectory",
            CreatedByMachineId = "CreatedByMachineId",
            CreatedByRecordAddedSource = "CreatedByRecordAddedSource",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByBirthDate = "UpdatedByBirthDate",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            UpdatedByQuestionId = "UpdatedByQuestionId",
            UpdatedByQuestionAns = "UpdatedByQuestionAns",
            UpdatedByIsLockOut = "UpdatedByIsLockOut",
            UpdatedByLockOutDateTime = "UpdatedByLockOutDateTime",
            UpdatedByLogInAttempt = "UpdatedByLogInAttempt",
            UpdatedByIsActiveDirectory = "UpdatedByIsActiveDirectory",
            UpdatedByMachineId = "UpdatedByMachineId",
            UpdatedByRecordAddedSource = "UpdatedByRecordAddedSource",
            MachineParameterMachineId = "MachineParameterMachineId",
            MachineParameterParameterName = "MachineParameterParameterName",
            MachineParameterPlcAddress = "MachineParameterPlcAddress",
            MachineParameterDescription = "MachineParameterDescription",
            MachineParameterDataTypeId = "MachineParameterDataTypeId",
            MachineParameterIsRangeUnlimited = "MachineParameterIsRangeUnlimited",
            MachineParameterMin = "MachineParameterMin",
            MachineParameterMax = "MachineParameterMax",
            MachineParameterIsUseUnit = "MachineParameterIsUseUnit",
            MachineParameterUnitId = "MachineParameterUnitId",
            MachineParameterStatusId = "MachineParameterStatusId",
            MachineParameterCreatedBy = "MachineParameterCreatedBy",
            MachineParameterCreatedDate = "MachineParameterCreatedDate",
            MachineParameterUpdatedBy = "MachineParameterUpdatedBy",
            MachineParameterUpdatedDate = "MachineParameterUpdatedDate",
            MachineParameterType = "MachineParameterType",
            MachineParameterIsRead = "MachineParameterIsRead",
            MachineParameterIsWrite = "MachineParameterIsWrite",
            MachineParameterRowId = "MachineParameterRowId",
            MachineParameterIsBitWise = "MachineParameterIsBitWise",
            MachineParameterBitWiseIndex = "MachineParameterBitWiseIndex",
            MachineParameterQueryTypeRowId = "MachineParameterQueryTypeRowId",
            MachineParameterOperationType = "MachineParameterOperationType",
            MachineParameterOperationValue = "MachineParameterOperationValue",
            MachineParameterIs32Bit = "MachineParameterIs32Bit",
            MachineParameterBit32RowId = "MachineParameterBit32RowId",
            MachineParameterIsStopAt = "MachineParameterIsStopAt",
            MachineParameterReadMachineParameterId = "MachineParameterReadMachineParameterId",
            MachineParameterReloadMachineParameterId = "MachineParameterReloadMachineParameterId",
            MachineParameterIsShowAsMessage = "MachineParameterIsShowAsMessage",
            MachineParameterIsBatchStartRequired = "MachineParameterIsBatchStartRequired",
            MachineParameterIsResetOnBatchCreate = "MachineParameterIsResetOnBatchCreate",
            MachineParameterIsLabelRoll = "MachineParameterIsLabelRoll",
            MachineParameterDisableParameterId = "MachineParameterDisableParameterId",
            MachineParameterDisableParameterValue = "MachineParameterDisableParameterValue",
            MachineParameterAllowDecimalPoint = "MachineParameterAllowDecimalPoint",
            MachineParameterIsStopOnBatchStop = "MachineParameterIsStopOnBatchStop",
            MachineParameterRecordAddedSource = "MachineParameterRecordAddedSource",
            MachineParameterColumnName = "MachineParameterColumnName",
            MachineParameterPickListId = "MachineParameterPickListId",
            ModuleModuleName = "ModuleModuleName",
            ModuleMachineId = "ModuleMachineId",
            ModuleStatusId = "ModuleStatusId",
            ModuleCreatedBy = "ModuleCreatedBy",
            ModuleCreatedDate = "ModuleCreatedDate",
            ModuleUpdatedBy = "ModuleUpdatedBy",
            ModuleUpdatedDate = "ModuleUpdatedDate",
            ModuleSequence = "ModuleSequence",
            ModuleEquipmentId = "ModuleEquipmentId",
            ModuleSerialNumber = "ModuleSerialNumber",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace DisplayObjectFieldService {
        const baseUrl = "MachineCustomization/DisplayObjectField";
        function Create(request: Serenity.SaveRequest<DisplayObjectFieldRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DisplayObjectFieldRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DisplayObjectFieldRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DisplayObjectFieldRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/DisplayObjectField/Create",
            Update = "MachineCustomization/DisplayObjectField/Update",
            Delete = "MachineCustomization/DisplayObjectField/Delete",
            Retrieve = "MachineCustomization/DisplayObjectField/Retrieve",
            List = "MachineCustomization/DisplayObjectField/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
    interface DisplayObjectForm {
        ViewName: Serenity.StringEditor;
        MachineId: Serenity.LookupEditor;
        DisplayObjectTypeId: Common.CustomEditors.DOTypeValueEditor;
        StatusId: Serenity.LookupEditor;
        ListDisplayId: Serenity.LookupEditor;
        FormDisplayId: Serenity.LookupEditor;
        ButtonDisplayId: Serenity.LookupEditor;
        RealtimeParameterDisplayId: Serenity.LookupEditor;
        LineChartDisplayId: Serenity.LookupEditor;
        PieChartDisplayId: Serenity.LookupEditor;
        TreeDisplayId: Serenity.LookupEditor;
        AttachmentDisplayId: Serenity.LookupEditor;
        AlarmDisplayId: Serenity.LookupEditor;
        NotificationDisplayId: Serenity.LookupEditor;
        ContainerDisplayId: Serenity.LookupEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class DisplayObjectForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface DisplayObjectRow {
        ViewsId?: number;
        ModuleId?: number;
        ViewName?: string;
        IsAccessFieldWise?: boolean;
        StatusId?: number;
        IsMachineSettings?: boolean;
        IsMachineSummary?: boolean;
        IslabelRoll?: boolean;
        IsCommandPanel?: boolean;
        IsFactorySetting?: boolean;
        DisplayObjectTypeId?: number;
        DisplayObjectStyle?: string;
        MachineId?: number;
        StatusStatusName?: string;
        CreatedByUsername?: string;
        UpdatedByUsername?: string;
        MachineMachineName?: string;
        ListDisplayId?: number;
        ListDisplayName?: string;
        FormDisplayId?: number;
        FormDisplayName?: string;
        ButtonDisplayId?: number;
        ButtonDisplayName?: string;
        RealtimeParameterDisplayId?: number;
        RealtimeParameterDisplayName?: string;
        LineChartDisplayId?: number;
        LineChartDisplayName?: string;
        PieChartDisplayId?: number;
        PieChartDisplayName?: string;
        TreeDisplayId?: number;
        TreeDisplayName?: string;
        AttachmentDisplayId?: number;
        AttachmentDisplayName?: string;
        AlarmDisplayId?: number;
        AlarmDisplayName?: string;
        NotificationDisplayId?: number;
        NotificationDisplayName?: string;
        ContainerDisplayId?: number;
        ContainerDisplayName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace DisplayObjectRow {
        const idProperty = "ViewsId";
        const nameProperty = "ViewName";
        const localTextPrefix = "MachineCustomization.DisplayObject";
        const lookupKey = "MachineCustomization.DisplayObject";
        function getLookup(): Q.Lookup<DisplayObjectRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            ViewsId = "ViewsId",
            ModuleId = "ModuleId",
            ViewName = "ViewName",
            IsAccessFieldWise = "IsAccessFieldWise",
            StatusId = "StatusId",
            IsMachineSettings = "IsMachineSettings",
            IsMachineSummary = "IsMachineSummary",
            IslabelRoll = "IslabelRoll",
            IsCommandPanel = "IsCommandPanel",
            IsFactorySetting = "IsFactorySetting",
            DisplayObjectTypeId = "DisplayObjectTypeId",
            DisplayObjectStyle = "DisplayObjectStyle",
            MachineId = "MachineId",
            StatusStatusName = "StatusStatusName",
            CreatedByUsername = "CreatedByUsername",
            UpdatedByUsername = "UpdatedByUsername",
            MachineMachineName = "MachineMachineName",
            ListDisplayId = "ListDisplayId",
            ListDisplayName = "ListDisplayName",
            FormDisplayId = "FormDisplayId",
            FormDisplayName = "FormDisplayName",
            ButtonDisplayId = "ButtonDisplayId",
            ButtonDisplayName = "ButtonDisplayName",
            RealtimeParameterDisplayId = "RealtimeParameterDisplayId",
            RealtimeParameterDisplayName = "RealtimeParameterDisplayName",
            LineChartDisplayId = "LineChartDisplayId",
            LineChartDisplayName = "LineChartDisplayName",
            PieChartDisplayId = "PieChartDisplayId",
            PieChartDisplayName = "PieChartDisplayName",
            TreeDisplayId = "TreeDisplayId",
            TreeDisplayName = "TreeDisplayName",
            AttachmentDisplayId = "AttachmentDisplayId",
            AttachmentDisplayName = "AttachmentDisplayName",
            AlarmDisplayId = "AlarmDisplayId",
            AlarmDisplayName = "AlarmDisplayName",
            NotificationDisplayId = "NotificationDisplayId",
            NotificationDisplayName = "NotificationDisplayName",
            ContainerDisplayId = "ContainerDisplayId",
            ContainerDisplayName = "ContainerDisplayName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace DisplayObjectService {
        const baseUrl = "MachineCustomization/DisplayObject";
        function Create(request: Serenity.SaveRequest<DisplayObjectRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DisplayObjectRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DisplayObjectRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DisplayObjectRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/DisplayObject/Create",
            Update = "MachineCustomization/DisplayObject/Update",
            Delete = "MachineCustomization/DisplayObject/Delete",
            Retrieve = "MachineCustomization/DisplayObject/Retrieve",
            List = "MachineCustomization/DisplayObject/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectTypeColorForm extends Serenity.PrefixedContext {
        static formKey: string;
    }
    interface DisplayObjectTypeColorForm {
        DotColor: Common.CustomEditors.ColorPickerEditor;
        Min: Serenity.DecimalEditor;
        Max: Serenity.DecimalEditor;
        DisplayObjectTypeId: Serenity.IntegerEditor;
        SubTypeId: Serenity.IntegerEditor;
    }
}
declare namespace CVC.MachineCustomization {
    interface DisplayObjectTypeColorRow {
        DotColorId?: number;
        DotColor?: string;
        Min?: number;
        Max?: number;
        DisplayObjectTypeId?: number;
        SubTypeId?: number;
    }
    namespace DisplayObjectTypeColorRow {
        const idProperty = "DotColorId";
        const nameProperty = "DotColor";
        const localTextPrefix = "MachineCustomization.DisplayObjectTypeColor";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        namespace Fields {
            const DotColorId: any;
            const DotColor: any;
            const Min: any;
            const Max: any;
            const DisplayObjectTypeId: any;
            const SubTypeId: any;
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace DisplayObjectTypeColorService {
        const baseUrl = "MachineCustomization/DisplayObjectTypeColor";
        function Create(request: Serenity.SaveRequest<DisplayObjectTypeColorRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DisplayObjectTypeColorRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DisplayObjectTypeColorRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DisplayObjectTypeColorRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        namespace Methods {
            const Create: string;
            const Update: string;
            const Delete: string;
            const Retrieve: string;
            const List: string;
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface FormDisplayForm {
        FormDisplayName: Serenity.StringEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        IsCheckbox: Serenity.BooleanEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }
    class FormDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface FormDisplayRow {
        FormDisplayId?: number;
        FormDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        IsCheckbox?: boolean;
        Font?: string;
        FontColorSelected?: string;
        FontColorUnselected?: string;
        Activation?: number;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsCollapsible?: boolean;
    }
    namespace FormDisplayRow {
        const idProperty = "FormDisplayId";
        const nameProperty = "FormDisplayName";
        const localTextPrefix = "MachineCustomization.FormDisplay";
        const lookupKey = "MachineCustomization.FormDisplay";
        function getLookup(): Q.Lookup<FormDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            FormDisplayId = "FormDisplayId",
            FormDisplayName = "FormDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            IsCheckbox = "IsCheckbox",
            Font = "Font",
            FontColorSelected = "FontColorSelected",
            FontColorUnselected = "FontColorUnselected",
            Activation = "Activation",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsCollapsible = "IsCollapsible"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace FormDisplayService {
        const baseUrl = "MachineCustomization/FormDisplay";
        function Create(request: Serenity.SaveRequest<FormDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<FormDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<FormDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<FormDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/FormDisplay/Create",
            Update = "MachineCustomization/FormDisplay/Update",
            Delete = "MachineCustomization/FormDisplay/Delete",
            Retrieve = "MachineCustomization/FormDisplay/Retrieve",
            List = "MachineCustomization/FormDisplay/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface LineChartDisplayForm {
        LineChartDisplayName: Serenity.StringEditor;
        Font: Common.CustomEditors.FontValueEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        IsLegends: Serenity.BooleanEditor;
        AxisColor: Common.CustomEditors.ColorPickerEditor;
        IsGridlines: Serenity.BooleanEditor;
        GridlineColor: Common.CustomEditors.ColorPickerEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsRealtime: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }
    class LineChartDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface LineChartDisplayRow {
        LineChartDisplayId?: number;
        LineChartDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColor?: string;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsCollapsible?: boolean;
        IsLegends?: boolean;
        IsGridlines?: boolean;
        GridlineColor?: string;
        IsRealtime?: boolean;
        AxisColor?: string;
    }
    namespace LineChartDisplayRow {
        const idProperty = "LineChartDisplayId";
        const nameProperty = "LineChartDisplayName";
        const localTextPrefix = "MachineCustomization.LineChartDisplay";
        const lookupKey = "MachineCustomization.LineChartDisplay";
        function getLookup(): Q.Lookup<LineChartDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            LineChartDisplayId = "LineChartDisplayId",
            LineChartDisplayName = "LineChartDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColor = "FontColor",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsCollapsible = "IsCollapsible",
            IsLegends = "IsLegends",
            IsGridlines = "IsGridlines",
            GridlineColor = "GridlineColor",
            IsRealtime = "IsRealtime",
            AxisColor = "AxisColor"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace LineChartDisplayService {
        const baseUrl = "MachineCustomization/LineChartDisplay";
        function Create(request: Serenity.SaveRequest<LineChartDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<LineChartDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LineChartDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LineChartDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/LineChartDisplay/Create",
            Update = "MachineCustomization/LineChartDisplay/Update",
            Delete = "MachineCustomization/LineChartDisplay/Delete",
            Retrieve = "MachineCustomization/LineChartDisplay/Retrieve",
            List = "MachineCustomization/LineChartDisplay/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface LineMaintenanceScheduleForm {
        MachineLineId: Serenity.IntegerEditor;
        StartDateTime: Serenity.DateEditor;
        EndDateTime: Serenity.DateEditor;
        Description: Serenity.StringEditor;
        Remark: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class LineMaintenanceScheduleForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface LineMaintenanceScheduleRow {
        LineMainSchId?: number;
        MachineLineId?: number;
        StartDateTime?: string;
        EndDateTime?: string;
        Description?: string;
        Remark?: string;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace LineMaintenanceScheduleRow {
        const idProperty = "LineMainSchId";
        const nameProperty = "Description";
        const localTextPrefix = "MachineCustomization.LineMaintenanceSchedule";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            LineMainSchId = "LineMainSchId",
            MachineLineId = "MachineLineId",
            StartDateTime = "StartDateTime",
            EndDateTime = "EndDateTime",
            Description = "Description",
            Remark = "Remark",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace LineMaintenanceScheduleService {
        const baseUrl = "MachineCustomization/LineMaintenanceSchedule";
        function Create(request: Serenity.SaveRequest<LineMaintenanceScheduleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<LineMaintenanceScheduleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LineMaintenanceScheduleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LineMaintenanceScheduleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/LineMaintenanceSchedule/Create",
            Update = "MachineCustomization/LineMaintenanceSchedule/Update",
            Delete = "MachineCustomization/LineMaintenanceSchedule/Delete",
            Retrieve = "MachineCustomization/LineMaintenanceSchedule/Retrieve",
            List = "MachineCustomization/LineMaintenanceSchedule/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface ListDisplayEditorForm {
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Serenity.StringEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        FontSize: Serenity.IntegerEditor;
        Checkbox: Serenity.BooleanEditor;
        FullRowSelect: Serenity.BooleanEditor;
        Gridlines: Serenity.BooleanEditor;
        UseWaitCursorOnClick: Serenity.BooleanEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        SortingType: Common.CustomEditors.SortTypeValueEditor;
        SortAscDesc: Serenity.BooleanEditor;
        MultiSelect: Serenity.BooleanEditor;
        AutoResize: Serenity.BooleanEditor;
        Collapsible: Serenity.BooleanEditor;
    }
    class ListDisplayEditorForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface ListDisplayForm {
        ListDisplayName: Serenity.StringEditor;
        ListDisplayId: Serenity.IntegerEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        FontSize: Common.CustomEditors.NumberInputEditor;
        Checkbox: Serenity.BooleanEditor;
        FullRowSelect: Serenity.BooleanEditor;
        Gridlines: Serenity.BooleanEditor;
        UseWaitCursorOnClick: Serenity.BooleanEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        SortingType: Common.CustomEditors.SortTypeValueEditor;
        SortAscDesc: Serenity.BooleanEditor;
        MultiSelect: Serenity.BooleanEditor;
        AutoResize: Serenity.BooleanEditor;
        Collapsible: Serenity.BooleanEditor;
    }
    class ListDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface ListDisplayRow {
        ListDisplayId?: number;
        ListDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Checkbox?: boolean;
        Font?: string;
        FontColor?: string;
        FontSize?: number;
        FullRowSelect?: boolean;
        Gridlines?: boolean;
        UseWaitCursorOnClick?: boolean;
        Activation?: number;
        Alignment?: number;
        SortingType?: number;
        SortAscDesc?: boolean;
        MultiSelect?: boolean;
        AutoResize?: boolean;
        Collapsible?: boolean;
    }
    namespace ListDisplayRow {
        const idProperty = "ListDisplayId";
        const nameProperty = "ListDisplayName";
        const localTextPrefix = "MachineCustomization.ListDisplay";
        const lookupKey = "MachineCustomization.ListDisplay";
        function getLookup(): Q.Lookup<ListDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            ListDisplayId = "ListDisplayId",
            ListDisplayName = "ListDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Checkbox = "Checkbox",
            Font = "Font",
            FontColor = "FontColor",
            FontSize = "FontSize",
            FullRowSelect = "FullRowSelect",
            Gridlines = "Gridlines",
            UseWaitCursorOnClick = "UseWaitCursorOnClick",
            Activation = "Activation",
            Alignment = "Alignment",
            SortingType = "SortingType",
            SortAscDesc = "SortAscDesc",
            MultiSelect = "MultiSelect",
            AutoResize = "AutoResize",
            Collapsible = "Collapsible"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace ListDisplayService {
        const baseUrl = "MachineCustomization/ListDisplay";
        function Create(request: Serenity.SaveRequest<ListDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ListDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ListDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ListDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/ListDisplay/Create",
            Update = "MachineCustomization/ListDisplay/Update",
            Delete = "MachineCustomization/ListDisplay/Delete",
            Retrieve = "MachineCustomization/ListDisplay/Retrieve",
            List = "MachineCustomization/ListDisplay/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineForm {
        MachineName: Serenity.StringEditor;
        IsRealTime: Serenity.BooleanEditor;
        TableId: Serenity.IntegerEditor;
        TableName: Serenity.StringEditor;
        MachineLineId: Serenity.IntegerEditor;
        AccessIpAddress: Serenity.StringEditor;
        MachineSequence: Serenity.IntegerEditor;
        MachineImage: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        ModelNumber: Serenity.StringEditor;
        SerialNumber: Serenity.StringEditor;
        Make: Serenity.StringEditor;
        Year: Serenity.IntegerEditor;
        TimerForAlarm: Serenity.IntegerEditor;
        PlcMake: Serenity.StringEditor;
        PlcModelNumber: Serenity.StringEditor;
        PlcSerialNumber: Serenity.StringEditor;
        PlcAddress: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineHelpFileForm {
        MachineId: Serenity.IntegerEditor;
        FileName: Serenity.StringEditor;
        FileContent: Serenity.StringEditor;
        FileLength: Serenity.IntegerEditor;
        FileExtension: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineHelpFileForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineHelpFileRow {
        MachineHelpFileId?: number;
        MachineId?: number;
        FileName?: string;
        FileContent?: number[];
        FileLength?: number;
        FileExtension?: string;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace MachineHelpFileRow {
        const idProperty = "MachineHelpFileId";
        const nameProperty = "FileName";
        const localTextPrefix = "MachineCustomization.MachineHelpFile";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            MachineHelpFileId = "MachineHelpFileId",
            MachineId = "MachineId",
            FileName = "FileName",
            FileContent = "FileContent",
            FileLength = "FileLength",
            FileExtension = "FileExtension",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineHelpFileService {
        const baseUrl = "MachineCustomization/MachineHelpFile";
        function Create(request: Serenity.SaveRequest<MachineHelpFileRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineHelpFileRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineHelpFileRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineHelpFileRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineHelpFile/Create",
            Update = "MachineCustomization/MachineHelpFile/Update",
            Delete = "MachineCustomization/MachineHelpFile/Delete",
            Retrieve = "MachineCustomization/MachineHelpFile/Retrieve",
            List = "MachineCustomization/MachineHelpFile/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineHistoryForm {
        MachineId: Serenity.IntegerEditor;
        IssueStartDate: Serenity.DateEditor;
        IssueCloseDate: Serenity.DateEditor;
        ProblemNatureId: Serenity.IntegerEditor;
        SparePartId: Serenity.IntegerEditor;
        ProblemDescription: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineHistoryForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineHistoryRow {
        MachineHistoryId?: number;
        MachineId?: number;
        IssueStartDate?: string;
        IssueCloseDate?: string;
        ProblemNatureId?: number;
        SparePartId?: number;
        ProblemDescription?: string;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
        ProblemNaturePickListId?: number;
        ProblemNaturePickListValueName?: string;
        ProblemNatureStatusId?: number;
        ProblemNatureCreatedBy?: number;
        ProblemNatureCreatedDate?: string;
        ProblemNatureUpdatedBy?: number;
        ProblemNatureUpdatedDate?: string;
        SparePartMachineId?: number;
        SparePartPartNumber?: string;
        SparePartPartName?: string;
        SparePartPartDescription?: string;
        SparePartNoOfUnitsRequired?: number;
        SparePartPartImage?: number[];
        SparePartStatusId?: number;
        SparePartCreatedBy?: number;
        SparePartCreatedDate?: string;
        SparePartUpdatedBy?: number;
        SparePartUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace MachineHistoryRow {
        const idProperty = "MachineHistoryId";
        const nameProperty = "ProblemDescription";
        const localTextPrefix = "MachineCustomization.MachineHistory";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            MachineHistoryId = "MachineHistoryId",
            MachineId = "MachineId",
            IssueStartDate = "IssueStartDate",
            IssueCloseDate = "IssueCloseDate",
            ProblemNatureId = "ProblemNatureId",
            SparePartId = "SparePartId",
            ProblemDescription = "ProblemDescription",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
            ProblemNaturePickListId = "ProblemNaturePickListId",
            ProblemNaturePickListValueName = "ProblemNaturePickListValueName",
            ProblemNatureStatusId = "ProblemNatureStatusId",
            ProblemNatureCreatedBy = "ProblemNatureCreatedBy",
            ProblemNatureCreatedDate = "ProblemNatureCreatedDate",
            ProblemNatureUpdatedBy = "ProblemNatureUpdatedBy",
            ProblemNatureUpdatedDate = "ProblemNatureUpdatedDate",
            SparePartMachineId = "SparePartMachineId",
            SparePartPartNumber = "SparePartPartNumber",
            SparePartPartName = "SparePartPartName",
            SparePartPartDescription = "SparePartPartDescription",
            SparePartNoOfUnitsRequired = "SparePartNoOfUnitsRequired",
            SparePartPartImage = "SparePartPartImage",
            SparePartStatusId = "SparePartStatusId",
            SparePartCreatedBy = "SparePartCreatedBy",
            SparePartCreatedDate = "SparePartCreatedDate",
            SparePartUpdatedBy = "SparePartUpdatedBy",
            SparePartUpdatedDate = "SparePartUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineHistoryService {
        const baseUrl = "MachineCustomization/MachineHistory";
        function Create(request: Serenity.SaveRequest<MachineHistoryRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineHistoryRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineHistoryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineHistoryRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineHistory/Create",
            Update = "MachineCustomization/MachineHistory/Update",
            Delete = "MachineCustomization/MachineHistory/Delete",
            Retrieve = "MachineCustomization/MachineHistory/Retrieve",
            List = "MachineCustomization/MachineHistory/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineLineForm {
        LineName: Serenity.StringEditor;
        LineRatedSpeed: Serenity.StringEditor;
        NumberOfMachines: Serenity.IntegerEditor;
        InstalledDate: Serenity.DateEditor;
        StatusId: Serenity.LookupEditor;
    }
    class MachineLineForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineLineRow {
        MachineLineId?: number;
        LineName?: string;
        LineRatedSpeed?: string;
        NumberOfMachines?: number;
        InstalledDate?: string;
        StatusId?: number;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace MachineLineRow {
        const idProperty = "MachineLineId";
        const nameProperty = "LineName";
        const localTextPrefix = "MachineCustomization.MachineLine";
        const lookupKey = "MachineCustomization.MachineLine";
        function getLookup(): Q.Lookup<MachineLineRow>;
        const deletePermission = "MachineCustomization:MachineLine:Modify";
        const insertPermission = "MachineCustomization:MachineLine:Modify";
        const readPermission = "MachineCustomization:MachineLine:Read";
        const updatePermission = "MachineCustomization:MachineLine:Modify";
        const enum Fields {
            MachineLineId = "MachineLineId",
            LineName = "LineName",
            LineRatedSpeed = "LineRatedSpeed",
            NumberOfMachines = "NumberOfMachines",
            InstalledDate = "InstalledDate",
            StatusId = "StatusId",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineLineService {
        const baseUrl = "MachineCustomization/MachineLine";
        function Create(request: Serenity.SaveRequest<MachineLineRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineLineRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineLineRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineLineRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineLine/Create",
            Update = "MachineCustomization/MachineLine/Update",
            Delete = "MachineCustomization/MachineLine/Delete",
            Retrieve = "MachineCustomization/MachineLine/Retrieve",
            List = "MachineCustomization/MachineLine/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineLineUserForm {
        MachineLineId: Serenity.IntegerEditor;
        UserId: Serenity.IntegerEditor;
        ShiftId: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineLineUserForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineLineUserRow {
        MachineLineUserId?: number;
        MachineLineId?: number;
        UserId?: number;
        ShiftId?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace MachineLineUserRow {
        const idProperty = "MachineLineUserId";
        const localTextPrefix = "MachineCustomization.MachineLineUser";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            MachineLineUserId = "MachineLineUserId",
            MachineLineId = "MachineLineId",
            UserId = "UserId",
            ShiftId = "ShiftId",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineLineUserService {
        const baseUrl = "MachineCustomization/MachineLineUser";
        function Create(request: Serenity.SaveRequest<MachineLineUserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineLineUserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineLineUserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineLineUserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineLineUser/Create",
            Update = "MachineCustomization/MachineLineUser/Update",
            Delete = "MachineCustomization/MachineLineUser/Delete",
            Retrieve = "MachineCustomization/MachineLineUser/Retrieve",
            List = "MachineCustomization/MachineLineUser/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineMaintenanceScheduleForm {
        MachineId: Serenity.IntegerEditor;
        StartDateTime: Serenity.DateEditor;
        EndDateTime: Serenity.DateEditor;
        Description: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineMaintenanceScheduleForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineMaintenanceScheduleRow {
        MachineMainSchId?: number;
        MachineId?: number;
        StartDateTime?: string;
        EndDateTime?: string;
        Description?: string;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace MachineMaintenanceScheduleRow {
        const idProperty = "MachineMainSchId";
        const nameProperty = "Description";
        const localTextPrefix = "MachineCustomization.MachineMaintenanceSchedule";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            MachineMainSchId = "MachineMainSchId",
            MachineId = "MachineId",
            StartDateTime = "StartDateTime",
            EndDateTime = "EndDateTime",
            Description = "Description",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineMaintenanceScheduleService {
        const baseUrl = "MachineCustomization/MachineMaintenanceSchedule";
        function Create(request: Serenity.SaveRequest<MachineMaintenanceScheduleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineMaintenanceScheduleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineMaintenanceScheduleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineMaintenanceScheduleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineMaintenanceSchedule/Create",
            Update = "MachineCustomization/MachineMaintenanceSchedule/Update",
            Delete = "MachineCustomization/MachineMaintenanceSchedule/Delete",
            Retrieve = "MachineCustomization/MachineMaintenanceSchedule/Retrieve",
            List = "MachineCustomization/MachineMaintenanceSchedule/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineParameterForm {
        ParameterName: Serenity.StringEditor;
        MachineId: Serenity.LookupEditor;
        Description: Serenity.StringEditor;
        IsRangeUnlimited: Serenity.BooleanEditor;
        Min: Serenity.DecimalEditor;
        Max: Serenity.DecimalEditor;
        AllowDecimalPoint: Serenity.BooleanEditor;
        IsRead: Serenity.BooleanEditor;
        IsWrite: Serenity.BooleanEditor;
        DataTypeId: Serenity.LookupEditor;
        IsUseUnit: Serenity.BooleanEditor;
        UnitId: Serenity.LookupEditor;
        ColumnName: Serenity.StringEditor;
        PickListId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
        Type: Serenity.LookupEditor;
        RowId: Serenity.IntegerEditor;
        ReadMachineParameterId: Serenity.LookupEditor;
        QueryTypeRowId: Serenity.IntegerEditor;
        IsStopAt: Serenity.BooleanEditor;
        IsBitWise: Serenity.BooleanEditor;
        BitWiseIndex: Serenity.IntegerEditor;
        OperationType: Serenity.LookupEditor;
        OperationValue: Serenity.DecimalEditor;
        Is32Bit: Serenity.BooleanEditor;
        Bit32RowId: Serenity.IntegerEditor;
        ReloadMachineParameterId: Serenity.LookupEditor;
        IsShowAsMessage: Serenity.BooleanEditor;
        IsResetOnBatchCreate: Serenity.BooleanEditor;
        IsBatchStartRequired: Serenity.BooleanEditor;
        IsLabelRoll: Serenity.BooleanEditor;
        DisableParameterId: Serenity.LookupEditor;
        DisableParameterValue: Serenity.StringEditor;
        IsStopOnBatchStop: Serenity.BooleanEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineParameterForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineParameterRow {
        MachineParameterId?: number;
        MachineId?: number;
        IsRealTime?: boolean;
        ColumnName?: string;
        PickListId?: number;
        PickListName?: string;
        ParameterName?: string;
        PlcAddress?: string;
        Description?: string;
        DataTypeId?: number;
        IsRangeUnlimited?: boolean;
        IsResetOnBatchCreate?: boolean;
        IsBatchStartRequired?: boolean;
        AllowDecimalPoint?: boolean;
        IsLabelRoll?: boolean;
        IsStopOnBatchStop?: boolean;
        Min?: number;
        Max?: number;
        IsUseUnit?: boolean;
        UnitId?: number;
        StatusId?: number;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        StatusStatusName?: string;
        DataTypeName?: string;
        UnitPickListValueName?: string;
        MachineMachineName?: string;
        Type?: number;
        ReadMachineParameterId?: number;
        ReloadMachineParameterId?: number;
        IsRead?: boolean;
        IsWrite?: boolean;
        RowId?: number;
        IsBitWise?: boolean;
        BitWiseIndex?: number;
        QueryTypeRowId?: number;
        OperationType?: number;
        OperationValue?: number;
        Is32Bit?: boolean;
        Bit32RowId?: number;
        IsStopAt?: boolean;
        IsShowAsMessage?: boolean;
        DisableParameterId?: number;
        DisableParameterValue?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace MachineParameterRow {
        const idProperty = "MachineParameterId";
        const nameProperty = "ParameterName";
        const localTextPrefix = "MachineCustomization.MachineParameter";
        const lookupKey = "MachineCustomization.MachineParameter";
        function getLookup(): Q.Lookup<MachineParameterRow>;
        const deletePermission = "MachineCustomization:MachineParameter:Modify";
        const insertPermission = "MachineCustomization:MachineParameter:Modify";
        const readPermission = "MachineCustomization:MachineParameter:Read";
        const updatePermission = "MachineCustomization:MachineParameter:Modify";
        const enum Fields {
            MachineParameterId = "MachineParameterId",
            MachineId = "MachineId",
            IsRealTime = "IsRealTime",
            ColumnName = "ColumnName",
            PickListId = "PickListId",
            PickListName = "PickListName",
            ParameterName = "ParameterName",
            PlcAddress = "PlcAddress",
            Description = "Description",
            DataTypeId = "DataTypeId",
            IsRangeUnlimited = "IsRangeUnlimited",
            IsResetOnBatchCreate = "IsResetOnBatchCreate",
            IsBatchStartRequired = "IsBatchStartRequired",
            AllowDecimalPoint = "AllowDecimalPoint",
            IsLabelRoll = "IsLabelRoll",
            IsStopOnBatchStop = "IsStopOnBatchStop",
            Min = "Min",
            Max = "Max",
            IsUseUnit = "IsUseUnit",
            UnitId = "UnitId",
            StatusId = "StatusId",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            StatusStatusName = "StatusStatusName",
            DataTypeName = "DataTypeName",
            UnitPickListValueName = "UnitPickListValueName",
            MachineMachineName = "MachineMachineName",
            Type = "Type",
            ReadMachineParameterId = "ReadMachineParameterId",
            ReloadMachineParameterId = "ReloadMachineParameterId",
            IsRead = "IsRead",
            IsWrite = "IsWrite",
            RowId = "RowId",
            IsBitWise = "IsBitWise",
            BitWiseIndex = "BitWiseIndex",
            QueryTypeRowId = "QueryTypeRowId",
            OperationType = "OperationType",
            OperationValue = "OperationValue",
            Is32Bit = "Is32Bit",
            Bit32RowId = "Bit32RowId",
            IsStopAt = "IsStopAt",
            IsShowAsMessage = "IsShowAsMessage",
            DisableParameterId = "DisableParameterId",
            DisableParameterValue = "DisableParameterValue",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineParameterService {
        const baseUrl = "MachineCustomization/MachineParameter";
        function Create(request: Serenity.SaveRequest<MachineParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function FetchAllColumns(request: ColumnIdsRequest, onSuccess?: (response: Serenity.ListResponse<ColumnIDRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineParameter/Create",
            Update = "MachineCustomization/MachineParameter/Update",
            Delete = "MachineCustomization/MachineParameter/Delete",
            Retrieve = "MachineCustomization/MachineParameter/Retrieve",
            List = "MachineCustomization/MachineParameter/List",
            FetchAllColumns = "MachineCustomization/MachineParameter/FetchAllColumns"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineRecipeForm {
        RecipeName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }
    class MachineRecipeForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineRecipeParameterForm {
        MachineRecipeId: Serenity.IntegerEditor;
        RecipeSettingsParameterId: Serenity.IntegerEditor;
        RecipeParameterValue: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineRecipeParameterForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineRecipeParameterRow {
        MachineRecipeParameterId?: number;
        MachineRecipeId?: number;
        MachineRecipeName?: string;
        RecipeSettingsParameterId?: number;
        RecipeParameterValue?: string;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        RecipeSettingsParameterRecipeSettingsId?: number;
        RecipeSettingsParameterIsFetchOnSelfSet?: number;
        RecipeSettingsParameterStatusId?: number;
        RecipeSettingsParameterCreatedBy?: number;
        RecipeSettingsParameterCreatedDate?: string;
        RecipeSettingsParameterUpdatedBy?: number;
        RecipeSettingsParameterUpdatedDate?: string;
        StatusStatusName?: string;
        MachineParameterValue?: string;
        MachineParameterId?: number;
        MachineParameterName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByBirthDate?: string;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByBirthDate?: string;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace MachineRecipeParameterRow {
        const idProperty = "MachineRecipeParameterId";
        const nameProperty = "RecipeParameterValue";
        const localTextPrefix = "MachineCustomization.MachineRecipeParameter";
        const deletePermission = "MachineCustomization:MachineRecipeParameter:Modify";
        const insertPermission = "MachineCustomization:MachineRecipeParameter:Modify";
        const readPermission = "MachineCustomization:MachineRecipeParameter:Read";
        const updatePermission = "MachineCustomization:MachineRecipeParameter:Modify";
        const enum Fields {
            MachineRecipeParameterId = "MachineRecipeParameterId",
            MachineRecipeId = "MachineRecipeId",
            MachineRecipeName = "MachineRecipeName",
            RecipeSettingsParameterId = "RecipeSettingsParameterId",
            RecipeParameterValue = "RecipeParameterValue",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            RecipeSettingsParameterRecipeSettingsId = "RecipeSettingsParameterRecipeSettingsId",
            RecipeSettingsParameterIsFetchOnSelfSet = "RecipeSettingsParameterIsFetchOnSelfSet",
            RecipeSettingsParameterStatusId = "RecipeSettingsParameterStatusId",
            RecipeSettingsParameterCreatedBy = "RecipeSettingsParameterCreatedBy",
            RecipeSettingsParameterCreatedDate = "RecipeSettingsParameterCreatedDate",
            RecipeSettingsParameterUpdatedBy = "RecipeSettingsParameterUpdatedBy",
            RecipeSettingsParameterUpdatedDate = "RecipeSettingsParameterUpdatedDate",
            StatusStatusName = "StatusStatusName",
            MachineParameterValue = "MachineParameterValue",
            MachineParameterId = "MachineParameterId",
            MachineParameterName = "MachineParameterName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByBirthDate = "CreatedByBirthDate",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByBirthDate = "UpdatedByBirthDate",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineRecipeParameterService {
        const baseUrl = "MachineCustomization/MachineRecipeParameter";
        function Create(request: Serenity.SaveRequest<MachineRecipeParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineRecipeParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineRecipeParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineRecipeParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineRecipeParameter/Create",
            Update = "MachineCustomization/MachineRecipeParameter/Update",
            Delete = "MachineCustomization/MachineRecipeParameter/Delete",
            Retrieve = "MachineCustomization/MachineRecipeParameter/Retrieve",
            List = "MachineCustomization/MachineRecipeParameter/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineRecipeReportService {
        const baseUrl = "~/MachineRecipeReport";
        const enum Methods {
        }
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineRecipeRow {
        MachineRecipeId?: number;
        MachineId?: number;
        PackId?: number;
        RecipeSettingsId?: number;
        RecipeName?: string;
        Description?: string;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByBirthDate?: string;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByBirthDate?: string;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        IsDefaultRecipe?: boolean;
        MachineMachineName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace MachineRecipeRow {
        const idProperty = "MachineRecipeId";
        const nameProperty = "RecipeName";
        const localTextPrefix = "MachineCustomization.MachineRecipe";
        const lookupKey = "MachineCustomization.MachineRecipe";
        function getLookup(): Q.Lookup<MachineRecipeRow>;
        const deletePermission = "MachineCustomization:MachineRecipe:Modify";
        const insertPermission = "MachineCustomization:MachineRecipe:Modify";
        const readPermission = "MachineCustomization:MachineRecipe:Read";
        const updatePermission = "MachineCustomization:MachineRecipe:Modify";
        const enum Fields {
            MachineRecipeId = "MachineRecipeId",
            MachineId = "MachineId",
            PackId = "PackId",
            RecipeSettingsId = "RecipeSettingsId",
            RecipeName = "RecipeName",
            Description = "Description",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByBirthDate = "CreatedByBirthDate",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByBirthDate = "UpdatedByBirthDate",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            IsDefaultRecipe = "IsDefaultRecipe",
            MachineMachineName = "MachineMachineName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineRecipeService {
        const baseUrl = "MachineCustomization/MachineRecipe";
        function Create(request: Serenity.SaveRequest<MachineRecipeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineRecipeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineRecipeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineRecipeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineRecipe/Create",
            Update = "MachineCustomization/MachineRecipe/Update",
            Delete = "MachineCustomization/MachineRecipe/Delete",
            Retrieve = "MachineCustomization/MachineRecipe/Retrieve",
            List = "MachineCustomization/MachineRecipe/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineRow {
        MachineId?: number;
        MachineLineId?: number;
        MachineName?: string;
        ModelNumber?: string;
        SerialNumber?: string;
        Make?: string;
        Year?: number;
        PlcMake?: string;
        PlcModelNumber?: string;
        PlcSerialNumber?: string;
        PlcAddress?: string;
        AccessIpAddress?: string;
        MachineSequence?: number;
        MachineImage?: number[];
        StatusId?: number;
        Description?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        StatusStatusName?: string;
        TimerForAlarm?: number;
        RecordAddedSource?: string;
        IsRealTime?: boolean;
        TableId?: number;
        TableName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace MachineRow {
        const idProperty = "MachineId";
        const nameProperty = "MachineName";
        const localTextPrefix = "MachineCustomization.Machine";
        const lookupKey = "MachineCustomization.Machine";
        function getLookup(): Q.Lookup<MachineRow>;
        const deletePermission = "MachineCustomization:Machine:Modify";
        const insertPermission = "MachineCustomization:Machine:Modify";
        const readPermission = "MachineCustomization:Machine:Read";
        const updatePermission = "MachineCustomization:Machine:Modify";
        const enum Fields {
            MachineId = "MachineId",
            MachineLineId = "MachineLineId",
            MachineName = "MachineName",
            ModelNumber = "ModelNumber",
            SerialNumber = "SerialNumber",
            Make = "Make",
            Year = "Year",
            PlcMake = "PlcMake",
            PlcModelNumber = "PlcModelNumber",
            PlcSerialNumber = "PlcSerialNumber",
            PlcAddress = "PlcAddress",
            AccessIpAddress = "AccessIpAddress",
            MachineSequence = "MachineSequence",
            MachineImage = "MachineImage",
            StatusId = "StatusId",
            Description = "Description",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            StatusStatusName = "StatusStatusName",
            TimerForAlarm = "TimerForAlarm",
            RecordAddedSource = "RecordAddedSource",
            IsRealTime = "IsRealTime",
            TableId = "TableId",
            TableName = "TableName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineService {
        const baseUrl = "MachineCustomization/Machine";
        function Create(request: Serenity.SaveRequest<MachineRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function FetchAllTables(request: Serenity.ServiceRequest, onSuccess?: (response: Serenity.ListResponse<TableObjIDRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/Machine/Create",
            Update = "MachineCustomization/Machine/Update",
            Delete = "MachineCustomization/Machine/Delete",
            Retrieve = "MachineCustomization/Machine/Retrieve",
            List = "MachineCustomization/Machine/List",
            FetchAllTables = "MachineCustomization/Machine/FetchAllTables"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineSparePartForm {
        MachineId: Serenity.IntegerEditor;
        PartNumber: Serenity.StringEditor;
        PartName: Serenity.StringEditor;
        PartDescription: Serenity.StringEditor;
        NoOfUnitsRequired: Serenity.IntegerEditor;
        PartImage: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineSparePartForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineSparePartRow {
        MachineSparePartId?: number;
        MachineId?: number;
        PartNumber?: string;
        PartName?: string;
        PartDescription?: string;
        NoOfUnitsRequired?: number;
        PartImage?: number[];
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace MachineSparePartRow {
        const idProperty = "MachineSparePartId";
        const nameProperty = "PartNumber";
        const localTextPrefix = "MachineCustomization.MachineSparePart";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            MachineSparePartId = "MachineSparePartId",
            MachineId = "MachineId",
            PartNumber = "PartNumber",
            PartName = "PartName",
            PartDescription = "PartDescription",
            NoOfUnitsRequired = "NoOfUnitsRequired",
            PartImage = "PartImage",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineSparePartService {
        const baseUrl = "MachineCustomization/MachineSparePart";
        function Create(request: Serenity.SaveRequest<MachineSparePartRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineSparePartRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineSparePartRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineSparePartRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineSparePart/Create",
            Update = "MachineCustomization/MachineSparePart/Update",
            Delete = "MachineCustomization/MachineSparePart/Delete",
            Retrieve = "MachineCustomization/MachineSparePart/Retrieve",
            List = "MachineCustomization/MachineSparePart/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineSpecificationForm {
        MachineId: Serenity.IntegerEditor;
        Description: Serenity.StringEditor;
        Details: Serenity.StringEditor;
        MachineImage: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineSpecificationForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineSpecificationRow {
        MachineSpecId?: number;
        MachineId?: number;
        Description?: string;
        Details?: string;
        MachineImage?: number[];
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace MachineSpecificationRow {
        const idProperty = "MachineSpecId";
        const nameProperty = "Description";
        const localTextPrefix = "MachineCustomization.MachineSpecification";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            MachineSpecId = "MachineSpecId",
            MachineId = "MachineId",
            Description = "Description",
            Details = "Details",
            MachineImage = "MachineImage",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineSpecificationService {
        const baseUrl = "MachineCustomization/MachineSpecification";
        function Create(request: Serenity.SaveRequest<MachineSpecificationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineSpecificationRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineSpecificationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineSpecificationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineSpecification/Create",
            Update = "MachineCustomization/MachineSpecification/Update",
            Delete = "MachineCustomization/MachineSpecification/Delete",
            Retrieve = "MachineCustomization/MachineSpecification/Retrieve",
            List = "MachineCustomization/MachineSpecification/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineUserForm {
        MachineId: Serenity.IntegerEditor;
        UserId: Serenity.IntegerEditor;
        ShiftId: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineUserForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineUserRow {
        MachineUserId?: number;
        MachineId?: number;
        UserId?: number;
        ShiftId?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        UserEmployeeId?: string;
        UserFirstName?: string;
        UserLastName?: string;
        UserDepartmentId?: number;
        UserDesignation?: string;
        UserMobileCode?: number;
        UserMobileNumber?: number;
        UserEmail?: string;
        UserUsername?: string;
        UserPasswordHash?: string;
        UserPasswordSalt?: string;
        UserUserImage?: number[];
        UserAddress?: string;
        UserCityId?: number;
        UserPinCode?: string;
        UserRoleId?: number;
        UserPasswordExpiryDate?: string;
        UserIsForgotPassword?: number;
        UserIsPasswordChangeOnLogin?: boolean;
        UserIsUserHidden?: number;
        UserStatusId?: number;
        UserCreatedBy?: number;
        UserCreatedDate?: string;
        UserUpdatedBy?: number;
        UserUpdatedDate?: string;
        ShiftShiftName?: string;
        ShiftStartTime?: string;
        ShiftEndTime?: string;
        ShiftStatusId?: number;
        ShiftCreatedBy?: number;
        ShiftCreatedDate?: string;
        ShiftUpdatedBy?: number;
        ShiftUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace MachineUserRow {
        const idProperty = "MachineUserId";
        const localTextPrefix = "MachineCustomization.MachineUser";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            MachineUserId = "MachineUserId",
            MachineId = "MachineId",
            UserId = "UserId",
            ShiftId = "ShiftId",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            UserEmployeeId = "UserEmployeeId",
            UserFirstName = "UserFirstName",
            UserLastName = "UserLastName",
            UserDepartmentId = "UserDepartmentId",
            UserDesignation = "UserDesignation",
            UserMobileCode = "UserMobileCode",
            UserMobileNumber = "UserMobileNumber",
            UserEmail = "UserEmail",
            UserUsername = "UserUsername",
            UserPasswordHash = "UserPasswordHash",
            UserPasswordSalt = "UserPasswordSalt",
            UserUserImage = "UserUserImage",
            UserAddress = "UserAddress",
            UserCityId = "UserCityId",
            UserPinCode = "UserPinCode",
            UserRoleId = "UserRoleId",
            UserPasswordExpiryDate = "UserPasswordExpiryDate",
            UserIsForgotPassword = "UserIsForgotPassword",
            UserIsPasswordChangeOnLogin = "UserIsPasswordChangeOnLogin",
            UserIsUserHidden = "UserIsUserHidden",
            UserStatusId = "UserStatusId",
            UserCreatedBy = "UserCreatedBy",
            UserCreatedDate = "UserCreatedDate",
            UserUpdatedBy = "UserUpdatedBy",
            UserUpdatedDate = "UserUpdatedDate",
            ShiftShiftName = "ShiftShiftName",
            ShiftStartTime = "ShiftStartTime",
            ShiftEndTime = "ShiftEndTime",
            ShiftStatusId = "ShiftStatusId",
            ShiftCreatedBy = "ShiftCreatedBy",
            ShiftCreatedDate = "ShiftCreatedDate",
            ShiftUpdatedBy = "ShiftUpdatedBy",
            ShiftUpdatedDate = "ShiftUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineUserService {
        const baseUrl = "MachineCustomization/MachineUser";
        function Create(request: Serenity.SaveRequest<MachineUserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineUserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineUserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineUserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineUser/Create",
            Update = "MachineCustomization/MachineUser/Update",
            Delete = "MachineCustomization/MachineUser/Delete",
            Retrieve = "MachineCustomization/MachineUser/Retrieve",
            List = "MachineCustomization/MachineUser/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface MachineVideoForm {
        MachineId: Serenity.IntegerEditor;
        FileName: Serenity.StringEditor;
        FileContent: Serenity.StringEditor;
        FileLength: Serenity.IntegerEditor;
        FileExtension: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class MachineVideoForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface MachineVideoRow {
        MachineVideoId?: number;
        MachineId?: number;
        FileName?: string;
        FileContent?: number[];
        FileLength?: number;
        FileExtension?: string;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace MachineVideoRow {
        const idProperty = "MachineVideoId";
        const nameProperty = "FileName";
        const localTextPrefix = "MachineCustomization.MachineVideo";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            MachineVideoId = "MachineVideoId",
            MachineId = "MachineId",
            FileName = "FileName",
            FileContent = "FileContent",
            FileLength = "FileLength",
            FileExtension = "FileExtension",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace MachineVideoService {
        const baseUrl = "MachineCustomization/MachineVideo";
        function Create(request: Serenity.SaveRequest<MachineVideoRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<MachineVideoRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MachineVideoRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MachineVideoRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/MachineVideo/Create",
            Update = "MachineCustomization/MachineVideo/Update",
            Delete = "MachineCustomization/MachineVideo/Delete",
            Retrieve = "MachineCustomization/MachineVideo/Retrieve",
            List = "MachineCustomization/MachineVideo/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface NotificationDisplayForm {
        NotificationDisplayName: Serenity.StringEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsOpenInNewWindow: Serenity.BooleanEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsFolderBrowse: Serenity.BooleanEditor;
        IsAddAttachments: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }
    class NotificationDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface NotificationDisplayRow {
        NotificationDisplayId?: number;
        NotificationDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColorSelected?: string;
        FontColorUnselected?: string;
        Activation?: number;
        IsOpenInNewWindow?: boolean;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        Alignment?: number;
        IsFolderBrowse?: boolean;
        IsAddAttachments?: boolean;
        IsCollapsible?: boolean;
    }
    namespace NotificationDisplayRow {
        const idProperty = "NotificationDisplayId";
        const nameProperty = "NotificationDisplayName";
        const localTextPrefix = "MachineCustomization.NotificationDisplay";
        const lookupKey = "MachineCustomization.NotificationDisplay";
        function getLookup(): Q.Lookup<NotificationDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            NotificationDisplayId = "NotificationDisplayId",
            NotificationDisplayName = "NotificationDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColorSelected = "FontColorSelected",
            FontColorUnselected = "FontColorUnselected",
            Activation = "Activation",
            IsOpenInNewWindow = "IsOpenInNewWindow",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            Alignment = "Alignment",
            IsFolderBrowse = "IsFolderBrowse",
            IsAddAttachments = "IsAddAttachments",
            IsCollapsible = "IsCollapsible"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace NotificationDisplayService {
        const baseUrl = "MachineCustomization/NotificationDisplay";
        function Create(request: Serenity.SaveRequest<NotificationDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<NotificationDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<NotificationDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<NotificationDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/NotificationDisplay/Create",
            Update = "MachineCustomization/NotificationDisplay/Update",
            Delete = "MachineCustomization/NotificationDisplay/Delete",
            Retrieve = "MachineCustomization/NotificationDisplay/Retrieve",
            List = "MachineCustomization/NotificationDisplay/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface PieChartDisplayForm {
        PieChartDisplayName: Serenity.StringEditor;
        Font: Common.CustomEditors.FontValueEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        IsLegends: Serenity.BooleanEditor;
        LegendFontSize: Common.CustomEditors.NumberInputEditor;
        IsShowValuesAsPercentage: Serenity.BooleanEditor;
        IsShowTotal: Serenity.BooleanEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsRealtime: Serenity.BooleanEditor;
    }
    class PieChartDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface PieChartDisplayRow {
        PieChartDisplayId?: number;
        PieChartDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColor?: string;
        IsLegends?: boolean;
        LegendFontSize?: number;
        IsShowValuesAsPercentage?: boolean;
        IsShowTotal?: boolean;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsRealtime?: boolean;
    }
    namespace PieChartDisplayRow {
        const idProperty = "PieChartDisplayId";
        const nameProperty = "PieChartDisplayName";
        const localTextPrefix = "MachineCustomization.PieChartDisplay";
        const lookupKey = "MachineCustomization.PieChartDisplay";
        function getLookup(): Q.Lookup<PieChartDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            PieChartDisplayId = "PieChartDisplayId",
            PieChartDisplayName = "PieChartDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColor = "FontColor",
            IsLegends = "IsLegends",
            LegendFontSize = "LegendFontSize",
            IsShowValuesAsPercentage = "IsShowValuesAsPercentage",
            IsShowTotal = "IsShowTotal",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsRealtime = "IsRealtime"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace PieChartDisplayService {
        const baseUrl = "MachineCustomization/PieChartDisplay";
        function Create(request: Serenity.SaveRequest<PieChartDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<PieChartDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PieChartDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PieChartDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/PieChartDisplay/Create",
            Update = "MachineCustomization/PieChartDisplay/Update",
            Delete = "MachineCustomization/PieChartDisplay/Delete",
            Retrieve = "MachineCustomization/PieChartDisplay/Retrieve",
            List = "MachineCustomization/PieChartDisplay/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface PrimaryRelationshipForm {
        RelationshipName: Serenity.StringEditor;
        PrimaryBe: Serenity.LookupEditor;
        PrimaryEf: Serenity.LookupEditor;
        Description: Serenity.TextAreaEditor;
        Status: Serenity.LookupEditor;
    }
    class PrimaryRelationshipForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface PrimaryRelationshipRow {
        PrimaryRelationshipId?: number;
        RelationshipName?: string;
        PrimaryBe?: number;
        PrimaryEf?: number;
        Description?: string;
        Status?: number;
        PrimaryBeMachineLineId?: number;
        PrimaryBeMachineName?: string;
        PrimaryBeModelNumber?: string;
        PrimaryBeSerialNumber?: string;
        PrimaryBeMake?: string;
        PrimaryBeYear?: number;
        PrimaryBePlcMake?: string;
        PrimaryBePlcModelNumber?: string;
        PrimaryBePlcSerialNumber?: string;
        PrimaryBePlcAddress?: string;
        PrimaryBeAccessIpAddress?: string;
        PrimaryBeMachineSequence?: number;
        PrimaryBeMachineImage?: number[];
        PrimaryBeMachineTypeId?: number;
        PrimaryBeStatusId?: number;
        PrimaryBeDescription?: string;
        PrimaryBeCreatedBy?: number;
        PrimaryBeCreatedDate?: string;
        PrimaryBeUpdatedBy?: number;
        PrimaryBeUpdatedDate?: string;
        PrimaryBeEquipmentId?: string;
        PrimaryBeTimerForAlarm?: number;
        PrimaryBeIsactive?: boolean;
        PrimaryBeIsShowStatistics?: boolean;
        PrimaryBeRecordAddedSource?: string;
        PrimaryBeIsRealTime?: boolean;
        PrimaryBeTableId?: number;
        PrimaryBeTableName?: string;
        PrimaryEfParameterName?: string;
        StatusStatusName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace PrimaryRelationshipRow {
        const idProperty = "PrimaryRelationshipId";
        const nameProperty = "RelationshipName";
        const localTextPrefix = "MachineCustomization.PrimaryRelationship";
        const lookupKey = "MachineCustomization.PrimaryRelationship";
        function getLookup(): Q.Lookup<PrimaryRelationshipRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            PrimaryRelationshipId = "PrimaryRelationshipId",
            RelationshipName = "RelationshipName",
            PrimaryBe = "PrimaryBe",
            PrimaryEf = "PrimaryEf",
            Description = "Description",
            Status = "Status",
            PrimaryBeMachineLineId = "PrimaryBeMachineLineId",
            PrimaryBeMachineName = "PrimaryBeMachineName",
            PrimaryBeModelNumber = "PrimaryBeModelNumber",
            PrimaryBeSerialNumber = "PrimaryBeSerialNumber",
            PrimaryBeMake = "PrimaryBeMake",
            PrimaryBeYear = "PrimaryBeYear",
            PrimaryBePlcMake = "PrimaryBePlcMake",
            PrimaryBePlcModelNumber = "PrimaryBePlcModelNumber",
            PrimaryBePlcSerialNumber = "PrimaryBePlcSerialNumber",
            PrimaryBePlcAddress = "PrimaryBePlcAddress",
            PrimaryBeAccessIpAddress = "PrimaryBeAccessIpAddress",
            PrimaryBeMachineSequence = "PrimaryBeMachineSequence",
            PrimaryBeMachineImage = "PrimaryBeMachineImage",
            PrimaryBeMachineTypeId = "PrimaryBeMachineTypeId",
            PrimaryBeStatusId = "PrimaryBeStatusId",
            PrimaryBeDescription = "PrimaryBeDescription",
            PrimaryBeCreatedBy = "PrimaryBeCreatedBy",
            PrimaryBeCreatedDate = "PrimaryBeCreatedDate",
            PrimaryBeUpdatedBy = "PrimaryBeUpdatedBy",
            PrimaryBeUpdatedDate = "PrimaryBeUpdatedDate",
            PrimaryBeEquipmentId = "PrimaryBeEquipmentId",
            PrimaryBeTimerForAlarm = "PrimaryBeTimerForAlarm",
            PrimaryBeIsactive = "PrimaryBeIsactive",
            PrimaryBeIsShowStatistics = "PrimaryBeIsShowStatistics",
            PrimaryBeRecordAddedSource = "PrimaryBeRecordAddedSource",
            PrimaryBeIsRealTime = "PrimaryBeIsRealTime",
            PrimaryBeTableId = "PrimaryBeTableId",
            PrimaryBeTableName = "PrimaryBeTableName",
            PrimaryEfParameterName = "PrimaryEfParameterName",
            StatusStatusName = "StatusStatusName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace PrimaryRelationshipService {
        const baseUrl = "MachineCustomization/PrimaryRelationship";
        function Create(request: Serenity.SaveRequest<PrimaryRelationshipRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<PrimaryRelationshipRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PrimaryRelationshipRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PrimaryRelationshipRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/PrimaryRelationship/Create",
            Update = "MachineCustomization/PrimaryRelationship/Update",
            Delete = "MachineCustomization/PrimaryRelationship/Delete",
            Retrieve = "MachineCustomization/PrimaryRelationship/Retrieve",
            List = "MachineCustomization/PrimaryRelationship/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface RealtimeParameterDisplayForm {
        RealtimeParameterDisplayName: Serenity.StringEditor;
        Font: Common.CustomEditors.FontValueEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }
    class RealtimeParameterDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface RealtimeParameterDisplayRow {
        RealtimeParameterDisplayId?: number;
        RealtimeParameterDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColor?: string;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsCollapsible?: boolean;
    }
    namespace RealtimeParameterDisplayRow {
        const idProperty = "RealtimeParameterDisplayId";
        const nameProperty = "RealtimeParameterDisplayName";
        const localTextPrefix = "MachineCustomization.RealtimeParameterDisplay";
        const lookupKey = "MachineCustomization.RealtimeParameterDisplay";
        function getLookup(): Q.Lookup<RealtimeParameterDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            RealtimeParameterDisplayId = "RealtimeParameterDisplayId",
            RealtimeParameterDisplayName = "RealtimeParameterDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColor = "FontColor",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsCollapsible = "IsCollapsible"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace RealtimeParameterDisplayService {
        const baseUrl = "MachineCustomization/RealtimeParameterDisplay";
        function Create(request: Serenity.SaveRequest<RealtimeParameterDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<RealtimeParameterDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RealtimeParameterDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RealtimeParameterDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/RealtimeParameterDisplay/Create",
            Update = "MachineCustomization/RealtimeParameterDisplay/Update",
            Delete = "MachineCustomization/RealtimeParameterDisplay/Delete",
            Retrieve = "MachineCustomization/RealtimeParameterDisplay/Retrieve",
            List = "MachineCustomization/RealtimeParameterDisplay/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface RecipeSettingsForm {
        RecipeSettingsName: Serenity.StringEditor;
        MachineId: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class RecipeSettingsForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface RecipeSettingsParameterForm {
        RecipeSettingsId: Serenity.IntegerEditor;
        IpcParameterId: Serenity.IntegerEditor;
        IsFetchOnSelfSet: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }
    class RecipeSettingsParameterForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface RecipeSettingsParameterRow {
        RecipeParameterId?: number;
        RecipeSettingsId?: number;
        IpcParameterId?: number;
        IsFetchOnSelfSet?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        RecipeSettingsRecipeSettingsName?: string;
        RecipeSettingsMachineId?: number;
        RecipeSettingsStatusId?: number;
        RecipeSettingsCreatedBy?: number;
        RecipeSettingsCreatedDate?: string;
        RecipeSettingsUpdatedBy?: number;
        RecipeSettingsUpdatedDate?: string;
        IpcParameterMachineId?: number;
        IpcParameterIpcParameterName?: string;
        IpcParameterMachineParameterId?: number;
        IpcParameterIpcAddress?: string;
        IpcParameterIsChangeInRuntime?: number;
        IpcParameterStatusId?: number;
        IpcParameterCreatedBy?: number;
        IpcParameterCreatedDate?: string;
        IpcParameterUpdatedBy?: number;
        IpcParameterUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace RecipeSettingsParameterRow {
        const idProperty = "RecipeParameterId";
        const localTextPrefix = "MachineCustomization.RecipeSettingsParameter";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            RecipeParameterId = "RecipeParameterId",
            RecipeSettingsId = "RecipeSettingsId",
            IpcParameterId = "IpcParameterId",
            IsFetchOnSelfSet = "IsFetchOnSelfSet",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            RecipeSettingsRecipeSettingsName = "RecipeSettingsRecipeSettingsName",
            RecipeSettingsMachineId = "RecipeSettingsMachineId",
            RecipeSettingsStatusId = "RecipeSettingsStatusId",
            RecipeSettingsCreatedBy = "RecipeSettingsCreatedBy",
            RecipeSettingsCreatedDate = "RecipeSettingsCreatedDate",
            RecipeSettingsUpdatedBy = "RecipeSettingsUpdatedBy",
            RecipeSettingsUpdatedDate = "RecipeSettingsUpdatedDate",
            IpcParameterMachineId = "IpcParameterMachineId",
            IpcParameterIpcParameterName = "IpcParameterIpcParameterName",
            IpcParameterMachineParameterId = "IpcParameterMachineParameterId",
            IpcParameterIpcAddress = "IpcParameterIpcAddress",
            IpcParameterIsChangeInRuntime = "IpcParameterIsChangeInRuntime",
            IpcParameterStatusId = "IpcParameterStatusId",
            IpcParameterCreatedBy = "IpcParameterCreatedBy",
            IpcParameterCreatedDate = "IpcParameterCreatedDate",
            IpcParameterUpdatedBy = "IpcParameterUpdatedBy",
            IpcParameterUpdatedDate = "IpcParameterUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace RecipeSettingsParameterService {
        const baseUrl = "MachineCustomization/RecipeSettingsParameter";
        function Create(request: Serenity.SaveRequest<RecipeSettingsParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<RecipeSettingsParameterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RecipeSettingsParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RecipeSettingsParameterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/RecipeSettingsParameter/Create",
            Update = "MachineCustomization/RecipeSettingsParameter/Update",
            Delete = "MachineCustomization/RecipeSettingsParameter/Delete",
            Retrieve = "MachineCustomization/RecipeSettingsParameter/Retrieve",
            List = "MachineCustomization/RecipeSettingsParameter/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
    interface RecipeSettingsRow {
        RecipeSettingsId?: number;
        RecipeSettingsName?: string;
        MachineId?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace RecipeSettingsRow {
        const idProperty = "RecipeSettingsId";
        const nameProperty = "RecipeSettingsName";
        const localTextPrefix = "MachineCustomization.RecipeSettings";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            RecipeSettingsId = "RecipeSettingsId",
            RecipeSettingsName = "RecipeSettingsName",
            MachineId = "MachineId",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace RecipeSettingsService {
        const baseUrl = "MachineCustomization/RecipeSettings";
        function Create(request: Serenity.SaveRequest<RecipeSettingsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<RecipeSettingsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RecipeSettingsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RecipeSettingsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/RecipeSettings/Create",
            Update = "MachineCustomization/RecipeSettings/Update",
            Delete = "MachineCustomization/RecipeSettings/Delete",
            Retrieve = "MachineCustomization/RecipeSettings/Retrieve",
            List = "MachineCustomization/RecipeSettings/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface ScreenViewsForm {
        ScreenViewName: Serenity.StringEditor;
        PrimaryRelationshipId: Serenity.LookupEditor;
        IsNoBer: Serenity.BooleanEditor;
        StatusId: Serenity.LookupEditor;
    }
    class ScreenViewsForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface ScreenViewsRow {
        ScreenViewId?: number;
        ScreenViewName?: string;
        PrimaryRelationshipId?: number;
        IsNoBer?: boolean;
        StatusId?: number;
        CreatedByUsername?: string;
        UpdatedByUsername?: string;
        PrimaryRelationshipRelationshipName?: string;
        PrimaryRelationshipPrimaryBe?: number;
        PrimaryRelationshipDescription?: string;
        PrimaryRelationshipStatus?: number;
        PrimaryRelationshipCreatedBy?: number;
        PrimaryRelationshipCreatedDate?: string;
        PrimaryRelationshipUpdatedBy?: number;
        PrimaryRelationshipUpdatedDate?: string;
        PrimaryRelationshipPrimaryEf?: number;
        StatusStatusName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace ScreenViewsRow {
        const idProperty = "ScreenViewId";
        const nameProperty = "ScreenViewName";
        const localTextPrefix = "MachineCustomization.ScreenViews";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            ScreenViewId = "ScreenViewId",
            ScreenViewName = "ScreenViewName",
            PrimaryRelationshipId = "PrimaryRelationshipId",
            IsNoBer = "IsNoBer",
            StatusId = "StatusId",
            CreatedByUsername = "CreatedByUsername",
            UpdatedByUsername = "UpdatedByUsername",
            PrimaryRelationshipRelationshipName = "PrimaryRelationshipRelationshipName",
            PrimaryRelationshipPrimaryBe = "PrimaryRelationshipPrimaryBe",
            PrimaryRelationshipDescription = "PrimaryRelationshipDescription",
            PrimaryRelationshipStatus = "PrimaryRelationshipStatus",
            PrimaryRelationshipCreatedBy = "PrimaryRelationshipCreatedBy",
            PrimaryRelationshipCreatedDate = "PrimaryRelationshipCreatedDate",
            PrimaryRelationshipUpdatedBy = "PrimaryRelationshipUpdatedBy",
            PrimaryRelationshipUpdatedDate = "PrimaryRelationshipUpdatedDate",
            PrimaryRelationshipPrimaryEf = "PrimaryRelationshipPrimaryEf",
            StatusStatusName = "StatusStatusName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace ScreenViewsService {
        const baseUrl = "MachineCustomization/ScreenViews";
        function Create(request: Serenity.SaveRequest<ScreenViewsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ScreenViewsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ScreenViewsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ScreenViewsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/ScreenViews/Create",
            Update = "MachineCustomization/ScreenViews/Update",
            Delete = "MachineCustomization/ScreenViews/Delete",
            Retrieve = "MachineCustomization/ScreenViews/Retrieve",
            List = "MachineCustomization/ScreenViews/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface SecondaryRelationshipForm {
        PrimaryRelationshipId: PrimaryRelationshipLookupEditor;
        SecondaryBe: SecondaryBELookupEditor;
        SecondaryEf: SecondaryEFLookupEditor;
        Description: Serenity.TextAreaEditor;
    }
    class SecondaryRelationshipForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface SecondaryRelationshipRow {
        SecondaryRelationshipId?: number;
        PrimaryRelationshipId?: number;
        SecondaryBe?: number;
        SecondaryEf?: number;
        Description?: string;
        PrimaryRelationshipRelationshipName?: string;
        PrimaryRelationshipPrimaryBe?: number;
        PrimaryBeMachineName?: string;
        PrimaryRelationshipPrimaryEf?: number;
        PrimaryEfParameterName?: string;
        PrimaryRelationshipDescription?: string;
        PrimaryRelationshipStatus?: number;
        PrimaryRelationshipCreatedBy?: number;
        PrimaryRelationshipCreatedDate?: string;
        PrimaryRelationshipUpdatedBy?: number;
        PrimaryRelationshipUpdatedDate?: string;
        SecondaryBeMachineLineId?: number;
        SecondaryBeMachineName?: string;
        SecondaryBeModelNumber?: string;
        SecondaryBeSerialNumber?: string;
        SecondaryBeMake?: string;
        SecondaryBeYear?: number;
        SecondaryBePlcMake?: string;
        SecondaryBePlcModelNumber?: string;
        SecondaryBePlcSerialNumber?: string;
        SecondaryBePlcAddress?: string;
        SecondaryBeAccessIpAddress?: string;
        SecondaryBeMachineSequence?: number;
        SecondaryBeMachineImage?: number[];
        SecondaryBeMachineTypeId?: number;
        SecondaryBeStatusId?: number;
        SecondaryBeDescription?: string;
        SecondaryBeCreatedBy?: number;
        SecondaryBeCreatedDate?: string;
        SecondaryBeUpdatedBy?: number;
        SecondaryBeUpdatedDate?: string;
        SecondaryBeEquipmentId?: string;
        SecondaryBeTimerForAlarm?: number;
        SecondaryBeIsactive?: boolean;
        SecondaryBeIsShowStatistics?: boolean;
        SecondaryBeRecordAddedSource?: string;
        SecondaryBeIsRealTime?: boolean;
        SecondaryBeTableId?: number;
        SecondaryBeTableName?: string;
        SecondaryEfParameterName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace SecondaryRelationshipRow {
        const idProperty = "SecondaryRelationshipId";
        const nameProperty = "Description";
        const localTextPrefix = "MachineCustomization.SecondaryRelationship";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            SecondaryRelationshipId = "SecondaryRelationshipId",
            PrimaryRelationshipId = "PrimaryRelationshipId",
            SecondaryBe = "SecondaryBe",
            SecondaryEf = "SecondaryEf",
            Description = "Description",
            PrimaryRelationshipRelationshipName = "PrimaryRelationshipRelationshipName",
            PrimaryRelationshipPrimaryBe = "PrimaryRelationshipPrimaryBe",
            PrimaryBeMachineName = "PrimaryBeMachineName",
            PrimaryRelationshipPrimaryEf = "PrimaryRelationshipPrimaryEf",
            PrimaryEfParameterName = "PrimaryEfParameterName",
            PrimaryRelationshipDescription = "PrimaryRelationshipDescription",
            PrimaryRelationshipStatus = "PrimaryRelationshipStatus",
            PrimaryRelationshipCreatedBy = "PrimaryRelationshipCreatedBy",
            PrimaryRelationshipCreatedDate = "PrimaryRelationshipCreatedDate",
            PrimaryRelationshipUpdatedBy = "PrimaryRelationshipUpdatedBy",
            PrimaryRelationshipUpdatedDate = "PrimaryRelationshipUpdatedDate",
            SecondaryBeMachineLineId = "SecondaryBeMachineLineId",
            SecondaryBeMachineName = "SecondaryBeMachineName",
            SecondaryBeModelNumber = "SecondaryBeModelNumber",
            SecondaryBeSerialNumber = "SecondaryBeSerialNumber",
            SecondaryBeMake = "SecondaryBeMake",
            SecondaryBeYear = "SecondaryBeYear",
            SecondaryBePlcMake = "SecondaryBePlcMake",
            SecondaryBePlcModelNumber = "SecondaryBePlcModelNumber",
            SecondaryBePlcSerialNumber = "SecondaryBePlcSerialNumber",
            SecondaryBePlcAddress = "SecondaryBePlcAddress",
            SecondaryBeAccessIpAddress = "SecondaryBeAccessIpAddress",
            SecondaryBeMachineSequence = "SecondaryBeMachineSequence",
            SecondaryBeMachineImage = "SecondaryBeMachineImage",
            SecondaryBeMachineTypeId = "SecondaryBeMachineTypeId",
            SecondaryBeStatusId = "SecondaryBeStatusId",
            SecondaryBeDescription = "SecondaryBeDescription",
            SecondaryBeCreatedBy = "SecondaryBeCreatedBy",
            SecondaryBeCreatedDate = "SecondaryBeCreatedDate",
            SecondaryBeUpdatedBy = "SecondaryBeUpdatedBy",
            SecondaryBeUpdatedDate = "SecondaryBeUpdatedDate",
            SecondaryBeEquipmentId = "SecondaryBeEquipmentId",
            SecondaryBeTimerForAlarm = "SecondaryBeTimerForAlarm",
            SecondaryBeIsactive = "SecondaryBeIsactive",
            SecondaryBeIsShowStatistics = "SecondaryBeIsShowStatistics",
            SecondaryBeRecordAddedSource = "SecondaryBeRecordAddedSource",
            SecondaryBeIsRealTime = "SecondaryBeIsRealTime",
            SecondaryBeTableId = "SecondaryBeTableId",
            SecondaryBeTableName = "SecondaryBeTableName",
            SecondaryEfParameterName = "SecondaryEfParameterName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace SecondaryRelationshipService {
        const baseUrl = "MachineCustomization/SecondaryRelationship";
        function Create(request: Serenity.SaveRequest<SecondaryRelationshipRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<SecondaryRelationshipRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SecondaryRelationshipRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SecondaryRelationshipRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/SecondaryRelationship/Create",
            Update = "MachineCustomization/SecondaryRelationship/Update",
            Delete = "MachineCustomization/SecondaryRelationship/Delete",
            Retrieve = "MachineCustomization/SecondaryRelationship/Retrieve",
            List = "MachineCustomization/SecondaryRelationship/List"
        }
    }
}
declare namespace CVC.MachineCustomization {
    interface TableObjIDRow {
        Name?: string;
        ObjectId?: number;
    }
}
declare namespace CVC.MachineCustomization {
}
declare namespace CVC.MachineCustomization {
    interface TreeDisplayForm {
        TreeDisplayName: Serenity.StringEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        IsFullRowSelect: Serenity.BooleanEditor;
        LineColor: Common.CustomEditors.ColorPickerEditor;
        DefaultView: Common.CustomEditors.DefaultViewValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsRealtime: Serenity.BooleanEditor;
    }
    class TreeDisplayForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.MachineCustomization {
    interface TreeDisplayRow {
        TreeDisplayId?: number;
        TreeDisplayName?: string;
        BackgroundColor?: string;
        BorderStyle?: number;
        Font?: string;
        FontColor?: string;
        IsFullRowSelect?: boolean;
        LineColor?: string;
        DefaultView?: number;
        Alignment?: number;
        IsTooltip?: boolean;
        IsHorizontalScrollBar?: boolean;
        IsVerticalScrollBar?: boolean;
        IsRealtime?: boolean;
    }
    namespace TreeDisplayRow {
        const idProperty = "TreeDisplayId";
        const nameProperty = "TreeDisplayName";
        const localTextPrefix = "MachineCustomization.TreeDisplay";
        const lookupKey = "MachineCustomization.TreeDisplay";
        function getLookup(): Q.Lookup<TreeDisplayRow>;
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            TreeDisplayId = "TreeDisplayId",
            TreeDisplayName = "TreeDisplayName",
            BackgroundColor = "BackgroundColor",
            BorderStyle = "BorderStyle",
            Font = "Font",
            FontColor = "FontColor",
            IsFullRowSelect = "IsFullRowSelect",
            LineColor = "LineColor",
            DefaultView = "DefaultView",
            Alignment = "Alignment",
            IsTooltip = "IsTooltip",
            IsHorizontalScrollBar = "IsHorizontalScrollBar",
            IsVerticalScrollBar = "IsVerticalScrollBar",
            IsRealtime = "IsRealtime"
        }
    }
}
declare namespace CVC.MachineCustomization {
    namespace TreeDisplayService {
        const baseUrl = "MachineCustomization/TreeDisplay";
        function Create(request: Serenity.SaveRequest<TreeDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<TreeDisplayRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TreeDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TreeDisplayRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "MachineCustomization/TreeDisplay/Create",
            Update = "MachineCustomization/TreeDisplay/Update",
            Delete = "MachineCustomization/TreeDisplay/Delete",
            Retrieve = "MachineCustomization/TreeDisplay/Retrieve",
            List = "MachineCustomization/TreeDisplay/List"
        }
    }
}
declare namespace CVC.Membership {
    interface ChangePasswordForm {
        OldPassword: Serenity.PasswordEditor;
        NewPassword: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }
    class ChangePasswordForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Membership {
    interface ChangePasswordRequest extends Serenity.ServiceRequest {
        OldPassword?: string;
        NewPassword?: string;
        ConfirmPassword?: string;
    }
}
declare namespace CVC.Membership {
    interface ForgotPasswordForm {
        Username: Serenity.StringEditor;
        QuestionId: Serenity.LookupEditor;
        QuestionAns: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
    }
    class ForgotPasswordForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Membership {
    interface ForgotPasswordRequest extends Serenity.ServiceRequest {
        Username?: string;
        QuestionId?: number;
        QuestionAns?: string;
        Password?: string;
        PasswordConfirm?: string;
    }
}
declare namespace CVC.Membership {
    interface LoginForm {
        Username: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
        IsADUser: Serenity.BooleanEditor;
    }
    class LoginForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Membership {
    interface LoginRequest extends Serenity.ServiceRequest {
        Username?: string;
        Password?: string;
        IsADUser?: boolean;
    }
}
declare namespace CVC.Membership.Pages {
    namespace AccountService {
        const baseUrl = "~/Account";
        function ChangePassword(request: ChangePasswordRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ForgotPassword(request: ForgotPasswordRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ResetPassword(request: ResetPasswordRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function SignUp(request: SignUpRequest, onSuccess?: (response: Serenity.ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            ChangePassword = "~/Account/ChangePassword",
            ForgotPassword = "~/Account/ForgotPassword",
            ResetPassword = "~/Account/ResetPassword",
            SignUp = "~/Account/SignUp"
        }
    }
}
declare namespace CVC.Membership {
    interface ResetPasswordForm {
        NewPassword: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }
    class ResetPasswordForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Membership {
    interface ResetPasswordRequest extends Serenity.ServiceRequest {
        Token?: string;
        NewPassword?: string;
        ConfirmPassword?: string;
    }
}
declare namespace CVC.Membership {
    interface SignUpForm {
        DisplayName: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        ConfirmEmail: Serenity.EmailEditor;
        Password: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }
    class SignUpForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Membership {
    interface SignUpRequest extends Serenity.ServiceRequest {
        FirstName?: string;
        LastName?: string;
        Email?: string;
        Password?: string;
    }
}
declare namespace CVC.Models {
    namespace TreeViewModelService {
        const baseUrl = "~/LDAP";
        const enum Methods {
        }
    }
}
declare namespace CVC.ModuleManagement {
}
declare namespace CVC.ModuleManagement {
    interface ModuleForm {
        ModuleName: Serenity.StringEditor;
        MachineId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
        Sequence: Serenity.IntegerEditor;
        EquipmentId: Serenity.StringEditor;
        SerialNumber: Serenity.StringEditor;
    }
    class ModuleForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.ModuleManagement {
    interface ModuleRow {
        ModuleId?: number;
        ModuleName?: string;
        MachineId?: number;
        Sequence?: number;
        StatusId?: number;
        EquipmentId?: string;
        SerialNumber?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace ModuleRow {
        const idProperty = "ModuleId";
        const nameProperty = "ModuleName";
        const localTextPrefix = "ModuleManagement.Module";
        const lookupKey = "ModuleManagement.Module";
        function getLookup(): Q.Lookup<ModuleRow>;
        const deletePermission = "ModuleManagement:Module:Modify";
        const insertPermission = "ModuleManagement:Module:Modify";
        const readPermission = "ModuleManagement:Module:Read";
        const updatePermission = "ModuleManagement:Module:Modify";
        const enum Fields {
            ModuleId = "ModuleId",
            ModuleName = "ModuleName",
            MachineId = "MachineId",
            Sequence = "Sequence",
            StatusId = "StatusId",
            EquipmentId = "EquipmentId",
            SerialNumber = "SerialNumber",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.ModuleManagement {
    namespace ModuleService {
        const baseUrl = "ModuleManagement/Module";
        function Create(request: Serenity.SaveRequest<ModuleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ModuleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ModuleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ModuleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "ModuleManagement/Module/Create",
            Update = "ModuleManagement/Module/Update",
            Delete = "ModuleManagement/Module/Delete",
            Retrieve = "ModuleManagement/Module/Retrieve",
            List = "ModuleManagement/Module/List"
        }
    }
}
declare namespace CVC.ModuleManagement {
}
declare namespace CVC.ModuleManagement {
    interface ViewFieldForm {
        ViewsId: Serenity.LookupEditor;
        ViewFieldName: Serenity.StringEditor;
        MachineParameterId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
        Sequence: Serenity.IntegerEditor;
    }
    class ViewFieldForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.ModuleManagement {
    interface ViewFieldRow {
        ViewField?: number;
        ViewsId?: number;
        ViewFieldName?: string;
        MachineParameterId?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        ViewsModuleId?: number;
        ViewsViewName?: string;
        ViewsIsAccessFieldWise?: number;
        ViewsStatusId?: number;
        ViewsCreatedBy?: number;
        ViewsCreatedDate?: string;
        ViewsUpdatedBy?: number;
        ViewsUpdatedDate?: string;
        Sequence?: number;
        MachineParameterMachineParameterName?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByBirthDate?: string;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByBirthDate?: string;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace ViewFieldRow {
        const idProperty = "ViewField";
        const nameProperty = "ViewFieldName";
        const localTextPrefix = "ModuleManagement.ViewField";
        const lookupKey = "ModuleManagement.ViewField";
        function getLookup(): Q.Lookup<ViewFieldRow>;
        const deletePermission = "ModuleManagement:ViewField:Modify";
        const insertPermission = "ModuleManagement:ViewField:Modify";
        const readPermission = "ModuleManagement:ViewField:Read";
        const updatePermission = "ModuleManagement:ViewField:Modify";
        const enum Fields {
            ViewField = "ViewField",
            ViewsId = "ViewsId",
            ViewFieldName = "ViewFieldName",
            MachineParameterId = "MachineParameterId",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            ViewsModuleId = "ViewsModuleId",
            ViewsViewName = "ViewsViewName",
            ViewsIsAccessFieldWise = "ViewsIsAccessFieldWise",
            ViewsStatusId = "ViewsStatusId",
            ViewsCreatedBy = "ViewsCreatedBy",
            ViewsCreatedDate = "ViewsCreatedDate",
            ViewsUpdatedBy = "ViewsUpdatedBy",
            ViewsUpdatedDate = "ViewsUpdatedDate",
            Sequence = "Sequence",
            MachineParameterMachineParameterName = "MachineParameterMachineParameterName",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByBirthDate = "CreatedByBirthDate",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByBirthDate = "UpdatedByBirthDate",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.ModuleManagement {
    namespace ViewFieldService {
        const baseUrl = "ModuleManagement/ViewField";
        function Create(request: Serenity.SaveRequest<ViewFieldRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ViewFieldRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ViewFieldRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ViewFieldRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "ModuleManagement/ViewField/Create",
            Update = "ModuleManagement/ViewField/Update",
            Delete = "ModuleManagement/ViewField/Delete",
            Retrieve = "ModuleManagement/ViewField/Retrieve",
            List = "ModuleManagement/ViewField/List"
        }
    }
}
declare namespace CVC.ModuleManagement {
}
declare namespace CVC.ModuleManagement {
    interface ViewsForm {
        ViewName: Serenity.StringEditor;
        ModuleId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
        IsMachineSettings: Serenity.BooleanEditor;
        IsMachineSummary: Serenity.BooleanEditor;
        IslabelRoll: Serenity.BooleanEditor;
        IsCommandPanel: Serenity.BooleanEditor;
    }
    class ViewsForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.ModuleManagement {
    interface ViewsRow {
        ViewsId?: number;
        ModuleId?: number;
        ViewName?: string;
        IsMachineSettings?: boolean;
        IsMachineSummary?: boolean;
        IslabelRoll?: boolean;
        IsCommandPanel?: boolean;
        IsAccessFieldWise?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        ModuleModuleName?: string;
        ModuleMachineId?: number;
        ModuleStatusId?: number;
        ModuleCreatedBy?: number;
        ModuleCreatedDate?: string;
        ModuleUpdatedBy?: number;
        ModuleUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
    }
    namespace ViewsRow {
        const idProperty = "ViewsId";
        const nameProperty = "ViewName";
        const localTextPrefix = "ModuleManagement.Views";
        const lookupKey = "ModuleManagement.Views";
        function getLookup(): Q.Lookup<ViewsRow>;
        const deletePermission = "ModuleManagement:Views:Modify";
        const insertPermission = "ModuleManagement:Views:Modify";
        const readPermission = "ModuleManagement:Views:Read";
        const updatePermission = "ModuleManagement:Views:Modify";
        const enum Fields {
            ViewsId = "ViewsId",
            ModuleId = "ModuleId",
            ViewName = "ViewName",
            IsMachineSettings = "IsMachineSettings",
            IsMachineSummary = "IsMachineSummary",
            IslabelRoll = "IslabelRoll",
            IsCommandPanel = "IsCommandPanel",
            IsAccessFieldWise = "IsAccessFieldWise",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            ModuleModuleName = "ModuleModuleName",
            ModuleMachineId = "ModuleMachineId",
            ModuleStatusId = "ModuleStatusId",
            ModuleCreatedBy = "ModuleCreatedBy",
            ModuleCreatedDate = "ModuleCreatedDate",
            ModuleUpdatedBy = "ModuleUpdatedBy",
            ModuleUpdatedDate = "ModuleUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate"
        }
    }
}
declare namespace CVC.ModuleManagement {
    namespace ViewsService {
        const baseUrl = "ModuleManagement/Views";
        function Create(request: Serenity.SaveRequest<ViewsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ViewsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ViewsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ViewsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "ModuleManagement/Views/Create",
            Update = "ModuleManagement/Views/Update",
            Delete = "ModuleManagement/Views/Delete",
            Retrieve = "ModuleManagement/Views/Retrieve",
            List = "ModuleManagement/Views/List"
        }
    }
}
declare namespace CVC.Modules.Configuration.EnvironmentVariables {
    interface HourFormatTypeLookUp {
        HourFormatTypeID?: number;
        HourFormatTypeValue?: string;
    }
    namespace HourFormatTypeLookUp {
        const idProperty = "HourFormatTypeID";
        const nameProperty = "HourFormatTypeValue";
        const localTextPrefix = "Configuration.HourFormatTypeLookUp";
        const lookupKey = "Configuration.HourFormatType";
        function getLookup(): Q.Lookup<HourFormatTypeLookUp>;
        const deletePermission = "Lookup";
        const insertPermission = "Lookup";
        const readPermission = "Lookup";
        const updatePermission = "Lookup";
        const enum Fields {
            HourFormatTypeID = "HourFormatTypeID",
            HourFormatTypeValue = "HourFormatTypeValue"
        }
    }
}
declare namespace CVC.Modules.Configuration.Status {
    interface Class1Row {
        AttributeId?: number;
        Name?: string;
    }
    namespace Class1Row {
        const idProperty = "AttributeId";
        const nameProperty = "Name";
        const localTextPrefix = "Configuration.Status1";
        const lookupKey = "Configuration.Status1";
        function getLookup(): Q.Lookup<Class1Row>;
        const deletePermission = "Lookup";
        const insertPermission = "Lookup";
        const readPermission = "Lookup";
        const updatePermission = "Lookup";
        const enum Fields {
            AttributeId = "AttributeId",
            Name = "Name"
        }
    }
}
declare namespace CVC.Modules.ExternalApplicationInterface.IpcParameter {
    interface MachineProtocolCommunication {
        MachineCommunicatonId?: number;
        ProtocolTypeId?: number;
        MachineId?: number;
        IpAddress?: string;
        MDBPath?: string;
        TcpipPort?: number;
        PollRate?: number;
        StatusId?: number;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
        ProtocolName?: string;
        MachineMachineName?: string;
    }
    namespace MachineProtocolCommunication {
        const idProperty = "ProtocolTypeId";
        const nameProperty = "ProtocolName";
        const localTextPrefix = "ExternalApplicationInterface.MachineCommunication";
        const lookupKey = "ExternalApplicationInterface.MachineProtocolCommunication";
        function getLookup(): Q.Lookup<MachineProtocolCommunication>;
        const deletePermission = "EAI:MachineCommunication:Modify";
        const insertPermission = "EAI:MachineCommunication:Modify";
        const readPermission = "EAI:MachineCommunication:Read";
        const updatePermission = "EAI:MachineCommunication:Modify";
        const enum Fields {
            MachineCommunicatonId = "MachineCommunicatonId",
            ProtocolTypeId = "ProtocolTypeId",
            MachineId = "MachineId",
            IpAddress = "IpAddress",
            MDBPath = "MDBPath",
            TcpipPort = "TcpipPort",
            PollRate = "PollRate",
            StatusId = "StatusId",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate",
            ProtocolName = "ProtocolName",
            MachineMachineName = "MachineMachineName"
        }
    }
}
declare namespace CVC.Modules.MachineCustomization.SaveRecipe {
    interface SaveRecipeRow {
        MachineRecipeId?: number;
        MachineId?: number;
        PackId?: number;
        RecipeSettingsId?: number;
        RecipeName?: string;
        Description?: string;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByBirthDate?: string;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByBirthDate?: string;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        IsDefaultRecipe?: boolean;
        MachineMachineName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace SaveRecipeRow {
        const idProperty = "MachineRecipeId";
        const nameProperty = "RecipeName";
        const localTextPrefix = "MachineCustomization.SaveRecipe";
        const lookupKey = "MachineCustomization.SaveRecipe";
        function getLookup(): Q.Lookup<SaveRecipeRow>;
        const deletePermission = "MachineCustomization:SaveRecipe:Modify";
        const insertPermission = "MachineCustomization:SaveRecipe:Modify";
        const readPermission = "MachineCustomization:SaveRecipe:Read";
        const updatePermission = "MachineCustomization:SaveRecipe:Modify";
        const enum Fields {
            MachineRecipeId = "MachineRecipeId",
            MachineId = "MachineId",
            PackId = "PackId",
            RecipeSettingsId = "RecipeSettingsId",
            RecipeName = "RecipeName",
            Description = "Description",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByBirthDate = "CreatedByBirthDate",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByBirthDate = "UpdatedByBirthDate",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            IsDefaultRecipe = "IsDefaultRecipe",
            MachineMachineName = "MachineMachineName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.PackSettings {
}
declare namespace CVC.PackSettings {
    interface BottleForm {
        BottleName: Serenity.StringEditor;
        BottleCc: Serenity.StringEditor;
        ContainerTypeId: Serenity.LookupEditor;
        BottleHeight: Serenity.StringEditor;
        BottleDiameter: Serenity.StringEditor;
        BottleMouthOpeningId: Serenity.StringEditor;
        BottleMouthOpeningOd: Serenity.StringEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }
    class BottleForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.PackSettings {
    interface BottleRow {
        BottleId?: number;
        BottleName?: string;
        BottleCc?: string;
        ContainerTypeId?: number;
        BottleHeight?: string;
        BottleDiameter?: string;
        BottleMouthOpeningId?: string;
        BottleMouthOpeningOd?: string;
        SupplierId?: number;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        SupplierSupplierName?: string;
        SupplierSupplierAddress?: string;
        SupplierCityId?: number;
        SupplierPinCode?: string;
        SupplierMobileCode?: number;
        SupplierMobileNumber?: number;
        SupplierStatusId?: number;
        SupplierCreatedBy?: number;
        SupplierCreatedDate?: string;
        SupplierUpdatedBy?: number;
        SupplierUpdatedDate?: string;
        ContainerTypePickListId?: number;
        ContainerTypePickListValueName?: string;
        ContainerTypeStatusId?: number;
        ContainerTypeCreatedBy?: number;
        ContainerTypeCreatedDate?: string;
        ContainerTypeUpdatedBy?: number;
        ContainerTypeUpdatedDate?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace BottleRow {
        const idProperty = "BottleId";
        const nameProperty = "BottleName";
        const localTextPrefix = "PackSettings.Bottle";
        const lookupKey = "PackSettings.Bottle";
        function getLookup(): Q.Lookup<BottleRow>;
        const deletePermission = "PackSettings:Bottle:Modify";
        const insertPermission = "PackSettings:Bottle:Modify";
        const readPermission = "PackSettings:Bottle:Read";
        const updatePermission = "PackSettings:Bottle:Modify";
        const enum Fields {
            BottleId = "BottleId",
            BottleName = "BottleName",
            BottleCc = "BottleCc",
            ContainerTypeId = "ContainerTypeId",
            BottleHeight = "BottleHeight",
            BottleDiameter = "BottleDiameter",
            BottleMouthOpeningId = "BottleMouthOpeningId",
            BottleMouthOpeningOd = "BottleMouthOpeningOd",
            SupplierId = "SupplierId",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            SupplierSupplierName = "SupplierSupplierName",
            SupplierSupplierAddress = "SupplierSupplierAddress",
            SupplierCityId = "SupplierCityId",
            SupplierPinCode = "SupplierPinCode",
            SupplierMobileCode = "SupplierMobileCode",
            SupplierMobileNumber = "SupplierMobileNumber",
            SupplierStatusId = "SupplierStatusId",
            SupplierCreatedBy = "SupplierCreatedBy",
            SupplierCreatedDate = "SupplierCreatedDate",
            SupplierUpdatedBy = "SupplierUpdatedBy",
            SupplierUpdatedDate = "SupplierUpdatedDate",
            ContainerTypePickListId = "ContainerTypePickListId",
            ContainerTypePickListValueName = "ContainerTypePickListValueName",
            ContainerTypeStatusId = "ContainerTypeStatusId",
            ContainerTypeCreatedBy = "ContainerTypeCreatedBy",
            ContainerTypeCreatedDate = "ContainerTypeCreatedDate",
            ContainerTypeUpdatedBy = "ContainerTypeUpdatedBy",
            ContainerTypeUpdatedDate = "ContainerTypeUpdatedDate",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.PackSettings {
    namespace BottleService {
        const baseUrl = "PackSettings/Bottle";
        function Create(request: Serenity.SaveRequest<BottleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<BottleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BottleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BottleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "PackSettings/Bottle/Create",
            Update = "PackSettings/Bottle/Update",
            Delete = "PackSettings/Bottle/Delete",
            Retrieve = "PackSettings/Bottle/Retrieve",
            List = "PackSettings/Bottle/List"
        }
    }
}
declare namespace CVC.PackSettings {
}
declare namespace CVC.PackSettings {
    interface CapForm {
        CapName: Serenity.StringEditor;
        CapCc: Serenity.StringEditor;
        CapTypeId: Serenity.LookupEditor;
        CapDiameter: Serenity.StringEditor;
        CapHeight: Serenity.StringEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }
    class CapForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.PackSettings {
    interface CapRow {
        CapId?: number;
        CapName?: string;
        CapCc?: string;
        CapTypeId?: number;
        CapDiameter?: string;
        CapHeight?: string;
        SupplierId?: number;
        StatusId?: number;
        CapTypePickListId?: number;
        CapTypePickListValueName?: string;
        CapTypeStatusId?: number;
        CapTypeCreatedBy?: number;
        CapTypeCreatedDate?: string;
        CapTypeUpdatedBy?: number;
        CapTypeUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        SupplierSupplierName?: string;
        SupplierSupplierAddress?: string;
        SupplierCityId?: number;
        SupplierPinCode?: string;
        SupplierMobileCode?: number;
        SupplierMobileNumber?: number;
        SupplierStatusId?: number;
        SupplierCreatedBy?: number;
        SupplierCreatedDate?: string;
        SupplierUpdatedBy?: number;
        SupplierUpdatedDate?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace CapRow {
        const idProperty = "CapId";
        const nameProperty = "CapName";
        const localTextPrefix = "PackSettings.Cap";
        const lookupKey = "PackSettings.Cap";
        function getLookup(): Q.Lookup<CapRow>;
        const deletePermission = "PackSettings:Cap:Modify";
        const insertPermission = "PackSettings:Cap:Modify";
        const readPermission = "PackSettings:Cap:Read";
        const updatePermission = "PackSettings:Cap:Modify";
        const enum Fields {
            CapId = "CapId",
            CapName = "CapName",
            CapCc = "CapCc",
            CapTypeId = "CapTypeId",
            CapDiameter = "CapDiameter",
            CapHeight = "CapHeight",
            SupplierId = "SupplierId",
            StatusId = "StatusId",
            CapTypePickListId = "CapTypePickListId",
            CapTypePickListValueName = "CapTypePickListValueName",
            CapTypeStatusId = "CapTypeStatusId",
            CapTypeCreatedBy = "CapTypeCreatedBy",
            CapTypeCreatedDate = "CapTypeCreatedDate",
            CapTypeUpdatedBy = "CapTypeUpdatedBy",
            CapTypeUpdatedDate = "CapTypeUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            SupplierSupplierName = "SupplierSupplierName",
            SupplierSupplierAddress = "SupplierSupplierAddress",
            SupplierCityId = "SupplierCityId",
            SupplierPinCode = "SupplierPinCode",
            SupplierMobileCode = "SupplierMobileCode",
            SupplierMobileNumber = "SupplierMobileNumber",
            SupplierStatusId = "SupplierStatusId",
            SupplierCreatedBy = "SupplierCreatedBy",
            SupplierCreatedDate = "SupplierCreatedDate",
            SupplierUpdatedBy = "SupplierUpdatedBy",
            SupplierUpdatedDate = "SupplierUpdatedDate",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.PackSettings {
    namespace CapService {
        const baseUrl = "PackSettings/Cap";
        function Create(request: Serenity.SaveRequest<CapRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CapRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CapRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CapRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "PackSettings/Cap/Create",
            Update = "PackSettings/Cap/Update",
            Delete = "PackSettings/Cap/Delete",
            Retrieve = "PackSettings/Cap/Retrieve",
            List = "PackSettings/Cap/List"
        }
    }
}
declare namespace CVC.PackSettings {
}
declare namespace CVC.PackSettings {
    interface CottonForm {
        CottonName: Serenity.StringEditor;
        CottonTypeId: Serenity.LookupEditor;
        GmOrYard: Serenity.StringEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }
    class CottonForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.PackSettings {
    interface CottonRow {
        CottonId?: number;
        CottonName?: string;
        CottonTypeId?: number;
        GmOrYard?: string;
        SupplierId?: number;
        StatusId?: number;
        CottonStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        SupplierSupplierName?: string;
        SupplierSupplierAddress?: string;
        SupplierCityId?: number;
        SupplierPinCode?: string;
        SupplierMobileCode?: number;
        SupplierMobileNumber?: number;
        SupplierStatusId?: number;
        SupplierCreatedBy?: number;
        SupplierCreatedDate?: string;
        SupplierUpdatedBy?: number;
        SupplierUpdatedDate?: string;
        CottonTypePickListId?: number;
        CottonTypePickListValueName?: string;
        CottonTypeStatusId?: number;
        CottonTypeCreatedBy?: number;
        CottonTypeCreatedDate?: string;
        CottonTypeUpdatedBy?: number;
        CottonTypeUpdatedDate?: string;
        StatusStatusName?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace CottonRow {
        const idProperty = "CottonId";
        const nameProperty = "CottonName";
        const localTextPrefix = "PackSettings.Cotton";
        const lookupKey = "PackSettings.Cotton";
        function getLookup(): Q.Lookup<CottonRow>;
        const deletePermission = "PackSettings:Cotton:Modify";
        const insertPermission = "PackSettings:Cotton:Modify";
        const readPermission = "PackSettings:Cotton:Read";
        const updatePermission = "PackSettings:Cotton:Modify";
        const enum Fields {
            CottonId = "CottonId",
            CottonName = "CottonName",
            CottonTypeId = "CottonTypeId",
            GmOrYard = "GmOrYard",
            SupplierId = "SupplierId",
            StatusId = "StatusId",
            CottonStatusName = "CottonStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            SupplierSupplierName = "SupplierSupplierName",
            SupplierSupplierAddress = "SupplierSupplierAddress",
            SupplierCityId = "SupplierCityId",
            SupplierPinCode = "SupplierPinCode",
            SupplierMobileCode = "SupplierMobileCode",
            SupplierMobileNumber = "SupplierMobileNumber",
            SupplierStatusId = "SupplierStatusId",
            SupplierCreatedBy = "SupplierCreatedBy",
            SupplierCreatedDate = "SupplierCreatedDate",
            SupplierUpdatedBy = "SupplierUpdatedBy",
            SupplierUpdatedDate = "SupplierUpdatedDate",
            CottonTypePickListId = "CottonTypePickListId",
            CottonTypePickListValueName = "CottonTypePickListValueName",
            CottonTypeStatusId = "CottonTypeStatusId",
            CottonTypeCreatedBy = "CottonTypeCreatedBy",
            CottonTypeCreatedDate = "CottonTypeCreatedDate",
            CottonTypeUpdatedBy = "CottonTypeUpdatedBy",
            CottonTypeUpdatedDate = "CottonTypeUpdatedDate",
            StatusStatusName = "StatusStatusName",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.PackSettings {
    namespace CottonService {
        const baseUrl = "PackSettings/Cotton";
        function Create(request: Serenity.SaveRequest<CottonRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CottonRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CottonRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CottonRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "PackSettings/Cotton/Create",
            Update = "PackSettings/Cotton/Update",
            Delete = "PackSettings/Cotton/Delete",
            Retrieve = "PackSettings/Cotton/Retrieve",
            List = "PackSettings/Cotton/List"
        }
    }
}
declare namespace CVC.PackSettings {
}
declare namespace CVC.PackSettings {
    interface DesiccantForm {
        DesiccantName: Serenity.StringEditor;
        DesiccantTypeId: Serenity.LookupEditor;
        Grammage: Serenity.StringEditor;
        LengthOrHeight: Serenity.StringEditor;
        DiameterOrWidth: Serenity.StringEditor;
        Identification: Serenity.LookupEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }
    class DesiccantForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.PackSettings {
    interface DesiccantRow {
        DesiccantId?: number;
        DesiccantName?: string;
        DesiccantTypeId?: number;
        Grammage?: string;
        LengthOrHeight?: string;
        DiameterOrWidth?: string;
        Identification?: number;
        SupplierId?: number;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        SupplierSupplierName?: string;
        SupplierSupplierAddress?: string;
        SupplierCityId?: number;
        SupplierPinCode?: string;
        SupplierMobileCode?: number;
        SupplierMobileNumber?: number;
        SupplierStatusId?: number;
        SupplierCreatedBy?: number;
        SupplierCreatedDate?: string;
        SupplierUpdatedBy?: number;
        SupplierUpdatedDate?: string;
        DesiccantTypePickListValueName?: string;
        DesiccantTypeStatusId?: number;
        IdentificationPickListValueName?: string;
        IdentificationStatusId?: number;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace DesiccantRow {
        const idProperty = "DesiccantId";
        const nameProperty = "DesiccantName";
        const localTextPrefix = "PackSettings.Desiccant";
        const lookupKey = "PackSettings.Desiccant";
        function getLookup(): Q.Lookup<DesiccantRow>;
        const deletePermission = "PackSettings:Desiccant:Modify";
        const insertPermission = "PackSettings:Desiccant:Modify";
        const readPermission = "PackSettings:Desiccant:Read";
        const updatePermission = "PackSettings:Desiccant:Modify";
        const enum Fields {
            DesiccantId = "DesiccantId",
            DesiccantName = "DesiccantName",
            DesiccantTypeId = "DesiccantTypeId",
            Grammage = "Grammage",
            LengthOrHeight = "LengthOrHeight",
            DiameterOrWidth = "DiameterOrWidth",
            Identification = "Identification",
            SupplierId = "SupplierId",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            SupplierSupplierName = "SupplierSupplierName",
            SupplierSupplierAddress = "SupplierSupplierAddress",
            SupplierCityId = "SupplierCityId",
            SupplierPinCode = "SupplierPinCode",
            SupplierMobileCode = "SupplierMobileCode",
            SupplierMobileNumber = "SupplierMobileNumber",
            SupplierStatusId = "SupplierStatusId",
            SupplierCreatedBy = "SupplierCreatedBy",
            SupplierCreatedDate = "SupplierCreatedDate",
            SupplierUpdatedBy = "SupplierUpdatedBy",
            SupplierUpdatedDate = "SupplierUpdatedDate",
            DesiccantTypePickListValueName = "DesiccantTypePickListValueName",
            DesiccantTypeStatusId = "DesiccantTypeStatusId",
            IdentificationPickListValueName = "IdentificationPickListValueName",
            IdentificationStatusId = "IdentificationStatusId",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.PackSettings {
    namespace DesiccantService {
        const baseUrl = "PackSettings/Desiccant";
        function Create(request: Serenity.SaveRequest<DesiccantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<DesiccantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<DesiccantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DesiccantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "PackSettings/Desiccant/Create",
            Update = "PackSettings/Desiccant/Update",
            Delete = "PackSettings/Desiccant/Delete",
            Retrieve = "PackSettings/Desiccant/Retrieve",
            List = "PackSettings/Desiccant/List"
        }
    }
}
declare namespace CVC.PackSettings {
}
declare namespace CVC.PackSettings {
    interface EndOfLineForm {
        EndOfLineName: Serenity.StringEditor;
        CartonLength: Serenity.StringEditor;
        CartonHeight: Serenity.StringEditor;
        CartonWidth: Serenity.StringEditor;
        CartonType: Serenity.StringEditor;
        BottleConfiguration: Serenity.StringEditor;
        MedicationLength: Serenity.StringEditor;
        MedicationWidth: Serenity.StringEditor;
        NoOfMedication: Serenity.StringEditor;
        InnerShipperBoxType: Serenity.StringEditor;
        InnerShipperBoxLength: Serenity.StringEditor;
        InnerShipperBoxWidth: Serenity.StringEditor;
        InnerShipperBoxHeight: Serenity.StringEditor;
        OuterShipperBoxLength: Serenity.StringEditor;
        OuterShipperBoxWidth: Serenity.StringEditor;
        OuterShipperBoxHeight: Serenity.StringEditor;
        InnerShipperMatrix: Serenity.StringEditor;
        OuterShipperQuantity: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }
    class EndOfLineForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.PackSettings {
    interface EndOfLineRow {
        EndOfLineId?: number;
        EndOfLineName?: string;
        CartonLength?: string;
        CartonHeight?: string;
        CartonWidth?: string;
        CartonType?: string;
        BottleConfiguration?: string;
        MedicationLength?: string;
        MedicationWidth?: string;
        NoOfMedication?: string;
        InnerShipperBoxType?: string;
        InnerShipperBoxLength?: string;
        InnerShipperBoxWidth?: string;
        InnerShipperBoxHeight?: string;
        OuterShipperBoxLength?: string;
        OuterShipperBoxWidth?: string;
        OuterShipperBoxHeight?: string;
        InnerShipperMatrix?: string;
        OuterShipperQuantity?: string;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace EndOfLineRow {
        const idProperty = "EndOfLineId";
        const nameProperty = "EndOfLineName";
        const localTextPrefix = "PackSettings.EndOfLine";
        const lookupKey = "PackSettings.EndOfLine";
        function getLookup(): Q.Lookup<EndOfLineRow>;
        const deletePermission = "PackSettings:EndOfLine:Modify";
        const insertPermission = "PackSettings:EndOfLine:Modify";
        const readPermission = "PackSettings:EndOfLine:Read";
        const updatePermission = "PackSettings:EndOfLine:Modify";
        const enum Fields {
            EndOfLineId = "EndOfLineId",
            EndOfLineName = "EndOfLineName",
            CartonLength = "CartonLength",
            CartonHeight = "CartonHeight",
            CartonWidth = "CartonWidth",
            CartonType = "CartonType",
            BottleConfiguration = "BottleConfiguration",
            MedicationLength = "MedicationLength",
            MedicationWidth = "MedicationWidth",
            NoOfMedication = "NoOfMedication",
            InnerShipperBoxType = "InnerShipperBoxType",
            InnerShipperBoxLength = "InnerShipperBoxLength",
            InnerShipperBoxWidth = "InnerShipperBoxWidth",
            InnerShipperBoxHeight = "InnerShipperBoxHeight",
            OuterShipperBoxLength = "OuterShipperBoxLength",
            OuterShipperBoxWidth = "OuterShipperBoxWidth",
            OuterShipperBoxHeight = "OuterShipperBoxHeight",
            InnerShipperMatrix = "InnerShipperMatrix",
            OuterShipperQuantity = "OuterShipperQuantity",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.PackSettings {
    namespace EndOfLineService {
        const baseUrl = "PackSettings/EndOfLine";
        function Create(request: Serenity.SaveRequest<EndOfLineRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<EndOfLineRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<EndOfLineRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<EndOfLineRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "PackSettings/EndOfLine/Create",
            Update = "PackSettings/EndOfLine/Update",
            Delete = "PackSettings/EndOfLine/Delete",
            Retrieve = "PackSettings/EndOfLine/Retrieve",
            List = "PackSettings/EndOfLine/List"
        }
    }
}
declare namespace CVC.PackSettings {
}
declare namespace CVC.PackSettings {
    interface LabelForm {
        LabelName: Serenity.StringEditor;
        LabelLength: Serenity.StringEditor;
        LabelHeight: Serenity.StringEditor;
        LabelType: Serenity.StringEditor;
        LabelImage: Serenity.ImageUploadEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }
    class LabelForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.PackSettings {
    interface LabelRow {
        LabelId?: number;
        LabelName?: string;
        LabelLength?: string;
        LabelHeight?: string;
        LabelType?: string;
        LabelImage?: string;
        SupplierId?: number;
        StatusId?: number;
        SupplierSupplierName?: string;
        SupplierSupplierAddress?: string;
        SupplierCityId?: number;
        SupplierPinCode?: string;
        SupplierMobileCode?: number;
        SupplierMobileNumber?: number;
        SupplierStatusId?: number;
        SupplierCreatedBy?: number;
        SupplierCreatedDate?: string;
        SupplierUpdatedBy?: number;
        SupplierUpdatedDate?: string;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace LabelRow {
        const idProperty = "LabelId";
        const nameProperty = "LabelName";
        const localTextPrefix = "PackSettings.Label";
        const lookupKey = "PackSettings.Label";
        function getLookup(): Q.Lookup<LabelRow>;
        const deletePermission = "PackSettings:Label:Modify";
        const insertPermission = "PackSettings:Label:Modify";
        const readPermission = "PackSettings:Label:Read";
        const updatePermission = "PackSettings:Label:Modify";
        const enum Fields {
            LabelId = "LabelId",
            LabelName = "LabelName",
            LabelLength = "LabelLength",
            LabelHeight = "LabelHeight",
            LabelType = "LabelType",
            LabelImage = "LabelImage",
            SupplierId = "SupplierId",
            StatusId = "StatusId",
            SupplierSupplierName = "SupplierSupplierName",
            SupplierSupplierAddress = "SupplierSupplierAddress",
            SupplierCityId = "SupplierCityId",
            SupplierPinCode = "SupplierPinCode",
            SupplierMobileCode = "SupplierMobileCode",
            SupplierMobileNumber = "SupplierMobileNumber",
            SupplierStatusId = "SupplierStatusId",
            SupplierCreatedBy = "SupplierCreatedBy",
            SupplierCreatedDate = "SupplierCreatedDate",
            SupplierUpdatedBy = "SupplierUpdatedBy",
            SupplierUpdatedDate = "SupplierUpdatedDate",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.PackSettings {
    namespace LabelService {
        const baseUrl = "PackSettings/Label";
        function Create(request: Serenity.SaveRequest<LabelRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<LabelRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LabelRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LabelRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "PackSettings/Label/Create",
            Update = "PackSettings/Label/Update",
            Delete = "PackSettings/Label/Delete",
            Retrieve = "PackSettings/Label/Retrieve",
            List = "PackSettings/Label/List"
        }
    }
}
declare namespace CVC.PackSettings {
}
declare namespace CVC.PackSettings {
    interface OutsertForm {
        OutsertName: Serenity.StringEditor;
        OutsertLength: Serenity.StringEditor;
        OutsertWidth: Serenity.StringEditor;
        OutsertThickness: Serenity.StringEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }
    class OutsertForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.PackSettings {
    interface OutsertRow {
        OutsertId?: number;
        OutsertName?: string;
        OutsertLength?: string;
        OutsertWidth?: string;
        OutsertThickness?: string;
        SupplierId?: number;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        SupplierSupplierName?: string;
        SupplierSupplierAddress?: string;
        SupplierCityId?: number;
        SupplierPinCode?: string;
        SupplierMobileCode?: number;
        SupplierMobileNumber?: number;
        SupplierStatusId?: number;
        SupplierCreatedBy?: number;
        SupplierCreatedDate?: string;
        SupplierUpdatedBy?: number;
        SupplierUpdatedDate?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace OutsertRow {
        const idProperty = "OutsertId";
        const nameProperty = "OutsertName";
        const localTextPrefix = "PackSettings.Outsert";
        const lookupKey = "PackSettings.Outsert";
        function getLookup(): Q.Lookup<OutsertRow>;
        const deletePermission = "PackSettings:Outsert:Modify";
        const insertPermission = "PackSettings:Outsert:Modify";
        const readPermission = "PackSettings:Outsert:Read";
        const updatePermission = "PackSettings:Outsert:Modify";
        const enum Fields {
            OutsertId = "OutsertId",
            OutsertName = "OutsertName",
            OutsertLength = "OutsertLength",
            OutsertWidth = "OutsertWidth",
            OutsertThickness = "OutsertThickness",
            SupplierId = "SupplierId",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            SupplierSupplierName = "SupplierSupplierName",
            SupplierSupplierAddress = "SupplierSupplierAddress",
            SupplierCityId = "SupplierCityId",
            SupplierPinCode = "SupplierPinCode",
            SupplierMobileCode = "SupplierMobileCode",
            SupplierMobileNumber = "SupplierMobileNumber",
            SupplierStatusId = "SupplierStatusId",
            SupplierCreatedBy = "SupplierCreatedBy",
            SupplierCreatedDate = "SupplierCreatedDate",
            SupplierUpdatedBy = "SupplierUpdatedBy",
            SupplierUpdatedDate = "SupplierUpdatedDate",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.PackSettings {
    namespace OutsertService {
        const baseUrl = "PackSettings/Outsert";
        function Create(request: Serenity.SaveRequest<OutsertRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<OutsertRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<OutsertRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<OutsertRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "PackSettings/Outsert/Create",
            Update = "PackSettings/Outsert/Update",
            Delete = "PackSettings/Outsert/Delete",
            Retrieve = "PackSettings/Outsert/Retrieve",
            List = "PackSettings/Outsert/List"
        }
    }
}
declare namespace CVC.PackSettings {
}
declare namespace CVC.PackSettings {
    interface PackForm {
        PackName: Serenity.StringEditor;
        TabletId: Serenity.LookupEditor;
        TabletCount: Serenity.IntegerEditor;
        BottleId: Serenity.LookupEditor;
        CapId: Serenity.LookupEditor;
        CottonId: Serenity.LookupEditor;
        CottonLength: Serenity.StringEditor;
        NumberOfCottonPieces: Serenity.IntegerEditor;
        DesiccantId: Serenity.LookupEditor;
        NumberOfDesicantPieces: Serenity.IntegerEditor;
        OutsertId: Serenity.LookupEditor;
        LabelId: Serenity.LookupEditor;
        EndOfLineId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }
    class PackForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.PackSettings {
    interface PackRow {
        PackId?: number;
        PackName?: string;
        TabletId?: number;
        TabletCount?: number;
        BottleId?: number;
        CapId?: number;
        CottonId?: number;
        CottonLength?: string;
        NumberOfCottonPieces?: number;
        DesiccantId?: number;
        NumberOfDesicantPieces?: number;
        OutsertId?: number;
        LabelId?: number;
        StatusId?: number;
        EndOfLineId?: number;
        LabelLabelName?: string;
        LabelLabelLength?: string;
        LabelLabelHeight?: string;
        LabelLabelType?: string;
        LabelLabelImage?: string;
        LabelSupplierId?: number;
        LabelStatusId?: number;
        LabelCreatedBy?: number;
        LabelCreatedDate?: string;
        LabelUpdatedBy?: number;
        LabelUpdatedDate?: string;
        StatusStatusName?: string;
        EndOfLineEndOfLineName?: string;
        EndOfLineCartonLength?: string;
        EndOfLineCartonHeight?: string;
        EndOfLineCartonWidth?: string;
        EndOfLineCartonType?: string;
        EndOfLineBottleConfiguration?: string;
        EndOfLineMedicationLength?: string;
        EndOfLineMedicationWidth?: string;
        EndOfLineNoOfMedication?: string;
        EndOfLineInnerShipperBoxType?: string;
        EndOfLineInnerShipperBoxLength?: string;
        EndOfLineInnerShipperBoxWidth?: string;
        EndOfLineInnerShipperBoxHeight?: string;
        EndOfLineOuterShipperBoxLength?: string;
        EndOfLineOuterShipperBoxWidth?: string;
        EndOfLineOuterShipperBoxHeight?: string;
        EndOfLineInnerShipperMatrix?: string;
        EndOfLineOuterShipperQuantity?: string;
        EndOfLineStatusId?: number;
        EndOfLineCreatedBy?: number;
        EndOfLineCreatedDate?: string;
        EndOfLineUpdatedBy?: number;
        EndOfLineUpdatedDate?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        TabletName?: string;
        BottleName?: string;
        CapName?: string;
        CottonName?: string;
        DesiccantName?: string;
        OutsertName?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace PackRow {
        const idProperty = "PackId";
        const nameProperty = "PackName";
        const localTextPrefix = "PackSettings.Pack";
        const lookupKey = "PackSettings.Pack";
        function getLookup(): Q.Lookup<PackRow>;
        const deletePermission = "PackSettings:Pack:Modify";
        const insertPermission = "PackSettings:Pack:Modify";
        const readPermission = "PackSettings:Pack:Read";
        const updatePermission = "PackSettings:Pack:Modify";
        const enum Fields {
            PackId = "PackId",
            PackName = "PackName",
            TabletId = "TabletId",
            TabletCount = "TabletCount",
            BottleId = "BottleId",
            CapId = "CapId",
            CottonId = "CottonId",
            CottonLength = "CottonLength",
            NumberOfCottonPieces = "NumberOfCottonPieces",
            DesiccantId = "DesiccantId",
            NumberOfDesicantPieces = "NumberOfDesicantPieces",
            OutsertId = "OutsertId",
            LabelId = "LabelId",
            StatusId = "StatusId",
            EndOfLineId = "EndOfLineId",
            LabelLabelName = "LabelLabelName",
            LabelLabelLength = "LabelLabelLength",
            LabelLabelHeight = "LabelLabelHeight",
            LabelLabelType = "LabelLabelType",
            LabelLabelImage = "LabelLabelImage",
            LabelSupplierId = "LabelSupplierId",
            LabelStatusId = "LabelStatusId",
            LabelCreatedBy = "LabelCreatedBy",
            LabelCreatedDate = "LabelCreatedDate",
            LabelUpdatedBy = "LabelUpdatedBy",
            LabelUpdatedDate = "LabelUpdatedDate",
            StatusStatusName = "StatusStatusName",
            EndOfLineEndOfLineName = "EndOfLineEndOfLineName",
            EndOfLineCartonLength = "EndOfLineCartonLength",
            EndOfLineCartonHeight = "EndOfLineCartonHeight",
            EndOfLineCartonWidth = "EndOfLineCartonWidth",
            EndOfLineCartonType = "EndOfLineCartonType",
            EndOfLineBottleConfiguration = "EndOfLineBottleConfiguration",
            EndOfLineMedicationLength = "EndOfLineMedicationLength",
            EndOfLineMedicationWidth = "EndOfLineMedicationWidth",
            EndOfLineNoOfMedication = "EndOfLineNoOfMedication",
            EndOfLineInnerShipperBoxType = "EndOfLineInnerShipperBoxType",
            EndOfLineInnerShipperBoxLength = "EndOfLineInnerShipperBoxLength",
            EndOfLineInnerShipperBoxWidth = "EndOfLineInnerShipperBoxWidth",
            EndOfLineInnerShipperBoxHeight = "EndOfLineInnerShipperBoxHeight",
            EndOfLineOuterShipperBoxLength = "EndOfLineOuterShipperBoxLength",
            EndOfLineOuterShipperBoxWidth = "EndOfLineOuterShipperBoxWidth",
            EndOfLineOuterShipperBoxHeight = "EndOfLineOuterShipperBoxHeight",
            EndOfLineInnerShipperMatrix = "EndOfLineInnerShipperMatrix",
            EndOfLineOuterShipperQuantity = "EndOfLineOuterShipperQuantity",
            EndOfLineStatusId = "EndOfLineStatusId",
            EndOfLineCreatedBy = "EndOfLineCreatedBy",
            EndOfLineCreatedDate = "EndOfLineCreatedDate",
            EndOfLineUpdatedBy = "EndOfLineUpdatedBy",
            EndOfLineUpdatedDate = "EndOfLineUpdatedDate",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            TabletName = "TabletName",
            BottleName = "BottleName",
            CapName = "CapName",
            CottonName = "CottonName",
            DesiccantName = "DesiccantName",
            OutsertName = "OutsertName",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.PackSettings {
    namespace PackService {
        const baseUrl = "PackSettings/Pack";
        function Create(request: Serenity.SaveRequest<PackRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<PackRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PackRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PackRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "PackSettings/Pack/Create",
            Update = "PackSettings/Pack/Update",
            Delete = "PackSettings/Pack/Delete",
            Retrieve = "PackSettings/Pack/Retrieve",
            List = "PackSettings/Pack/List"
        }
    }
}
declare namespace CVC.PackSettings {
}
declare namespace CVC.PackSettings {
    interface TabletDetailsForm {
        TabletName: Serenity.StringEditor;
        TabletStrength: Serenity.StringEditor;
        TabletTypeId: Serenity.LookupEditor;
        TabletCharOneId: Serenity.LookupEditor;
        TabletCharTwoId: Serenity.LookupEditor;
        TabletShapeId: Serenity.LookupEditor;
        TabletLength: Serenity.StringEditor;
        TabletThickness: Serenity.StringEditor;
        TabletWidth: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }
    class TabletDetailsForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.PackSettings {
    interface TabletDetailsRow {
        TabletDetailsId?: number;
        TabletName?: string;
        TabletStrength?: string;
        TabletTypeId?: number;
        TabletCharOneId?: number;
        TabletCharTwoId?: number;
        TabletShapeId?: number;
        TabletLength?: string;
        TabletThickness?: string;
        TabletWidth?: string;
        StatusId?: number;
        StatusStatusName?: string;
        TabletTypePickListValueName?: string;
        TabletTypeStatusId?: number;
        TabletCharOnePickListValueName?: string;
        TabletCharOneStatusId?: number;
        TabletCharTwoPickListValueName?: string;
        TabletCharTwoStatusId?: number;
        TabletShapePickListValueName?: string;
        TabletShapeStatusId?: number;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }
    namespace TabletDetailsRow {
        const idProperty = "TabletDetailsId";
        const nameProperty = "TabletName";
        const localTextPrefix = "PackSettings.TabletDetails";
        const lookupKey = "PackSettings.Tablet";
        function getLookup(): Q.Lookup<TabletDetailsRow>;
        const deletePermission = "PackSettings:TabletDetails:Modify";
        const insertPermission = "PackSettings:TabletDetails:Modify";
        const readPermission = "PackSettings:TabletDetails:Read";
        const updatePermission = "PackSettings:TabletDetails:Modify";
        const enum Fields {
            TabletDetailsId = "TabletDetailsId",
            TabletName = "TabletName",
            TabletStrength = "TabletStrength",
            TabletTypeId = "TabletTypeId",
            TabletCharOneId = "TabletCharOneId",
            TabletCharTwoId = "TabletCharTwoId",
            TabletShapeId = "TabletShapeId",
            TabletLength = "TabletLength",
            TabletThickness = "TabletThickness",
            TabletWidth = "TabletWidth",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            TabletTypePickListValueName = "TabletTypePickListValueName",
            TabletTypeStatusId = "TabletTypeStatusId",
            TabletCharOnePickListValueName = "TabletCharOnePickListValueName",
            TabletCharOneStatusId = "TabletCharOneStatusId",
            TabletCharTwoPickListValueName = "TabletCharTwoPickListValueName",
            TabletCharTwoStatusId = "TabletCharTwoStatusId",
            TabletShapePickListValueName = "TabletShapePickListValueName",
            TabletShapeStatusId = "TabletShapeStatusId",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}
declare namespace CVC.PackSettings {
    namespace TabletDetailsService {
        const baseUrl = "PackSettings/TabletDetails";
        function Create(request: Serenity.SaveRequest<TabletDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<TabletDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TabletDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TabletDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "PackSettings/TabletDetails/Create",
            Update = "PackSettings/TabletDetails/Update",
            Delete = "PackSettings/TabletDetails/Delete",
            Retrieve = "PackSettings/TabletDetails/Retrieve",
            List = "PackSettings/TabletDetails/List"
        }
    }
}
declare namespace CVC.Report {
}
declare namespace CVC.Report {
    interface AlarmLogArchiveForm {
        MachineId: Serenity.IntegerEditor;
        AlarmId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        LoggedUserId: Serenity.IntegerEditor;
        Comment: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        AlarmDateTime: Serenity.DateEditor;
        PcipAddress: Serenity.StringEditor;
    }
    class AlarmLogArchiveForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Report {
    interface AlarmLogArchiveRow {
        AlarmLogArchiveId?: number;
        MachineId?: number;
        AlarmId?: number;
        BatchId?: number;
        LoggedUserId?: number;
        Comment?: string;
        Description?: string;
        AlarmDateTime?: string;
        PcipAddress?: string;
        BatchBatchName?: string;
        AlarmAlarmName?: string;
        MachineMachineName?: string;
    }
    namespace AlarmLogArchiveRow {
        const idProperty = "AlarmLogArchiveId";
        const nameProperty = "Comment";
        const localTextPrefix = "Report.AlarmLogArchive";
        const deletePermission = "Report:AlarmLogArchive:Read";
        const insertPermission = "Report:AlarmLogArchive:Read";
        const readPermission = "Report:AlarmLogArchive:Read";
        const updatePermission = "Report:AlarmLogArchive:Read";
        const enum Fields {
            AlarmLogArchiveId = "AlarmLogArchiveId",
            MachineId = "MachineId",
            AlarmId = "AlarmId",
            BatchId = "BatchId",
            LoggedUserId = "LoggedUserId",
            Comment = "Comment",
            Description = "Description",
            AlarmDateTime = "AlarmDateTime",
            PcipAddress = "PcipAddress",
            BatchBatchName = "BatchBatchName",
            AlarmAlarmName = "AlarmAlarmName",
            MachineMachineName = "MachineMachineName"
        }
    }
}
declare namespace CVC.Report {
    namespace AlarmLogArchiveService {
        const baseUrl = "Report/AlarmLogArchive";
        function Create(request: Serenity.SaveRequest<AlarmLogArchiveRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<AlarmLogArchiveRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AlarmLogArchiveRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AlarmLogArchiveRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Report/AlarmLogArchive/Create",
            Update = "Report/AlarmLogArchive/Update",
            Delete = "Report/AlarmLogArchive/Delete",
            Retrieve = "Report/AlarmLogArchive/Retrieve",
            List = "Report/AlarmLogArchive/List"
        }
    }
}
declare namespace CVC.Report {
}
declare namespace CVC.Report {
    interface AlarmLogForm {
        MachineId: Serenity.IntegerEditor;
        AlarmId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        LoggedUserId: Serenity.IntegerEditor;
        Comment: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        AlarmDateTime: Serenity.DateEditor;
        PcipAddress: Serenity.StringEditor;
    }
    class AlarmLogForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Report {
    interface AlarmLogRow {
        AlarmLogId?: number;
        MachineId?: number;
        AlarmId?: number;
        BatchId?: number;
        LoggedUserId?: number;
        Comment?: string;
        Description?: string;
        AlarmDateTime?: string;
        PcipAddress?: string;
        BatchBatchName?: string;
        AlarmAlarmName?: string;
        MachineMachineName?: string;
    }
    namespace AlarmLogRow {
        const idProperty = "AlarmLogId";
        const nameProperty = "Comment";
        const localTextPrefix = "Report.AlarmLog";
        const deletePermission = "Report:AlarmLog:Read";
        const insertPermission = "Report:AlarmLog:Read";
        const readPermission = "Report:AlarmLog:Read";
        const updatePermission = "Report:AlarmLog:Read";
        const enum Fields {
            AlarmLogId = "AlarmLogId",
            MachineId = "MachineId",
            AlarmId = "AlarmId",
            BatchId = "BatchId",
            LoggedUserId = "LoggedUserId",
            Comment = "Comment",
            Description = "Description",
            AlarmDateTime = "AlarmDateTime",
            PcipAddress = "PcipAddress",
            BatchBatchName = "BatchBatchName",
            AlarmAlarmName = "AlarmAlarmName",
            MachineMachineName = "MachineMachineName"
        }
    }
}
declare namespace CVC.Report {
    namespace AlarmLogService {
        const baseUrl = "Report/AlarmLog";
        function Create(request: Serenity.SaveRequest<AlarmLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<AlarmLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AlarmLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AlarmLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Report/AlarmLog/Create",
            Update = "Report/AlarmLog/Update",
            Delete = "Report/AlarmLog/Delete",
            Retrieve = "Report/AlarmLog/Retrieve",
            List = "Report/AlarmLog/List"
        }
    }
}
declare namespace CVC.Report {
}
declare namespace CVC.Report {
    interface AuditLogArchiveForm {
        UserId: Serenity.IntegerEditor;
        UserName: Serenity.StringEditor;
        Action: Serenity.StringEditor;
        ChangedOn: Serenity.DateEditor;
        TableName: Serenity.StringEditor;
        RowId: Serenity.IntegerEditor;
        Module: Serenity.StringEditor;
        Page: Serenity.StringEditor;
        FieldName: Serenity.StringEditor;
        OldValue: Serenity.StringEditor;
        NewValue: Serenity.StringEditor;
        Comments: Serenity.StringEditor;
        PcipAddress: Serenity.StringEditor;
        BatchId: Serenity.IntegerEditor;
        BatchName: Serenity.StringEditor;
        MachineId: Serenity.IntegerEditor;
        MachineName: Serenity.StringEditor;
    }
    class AuditLogArchiveForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Report {
    interface AuditLogArchiveRow {
        AuditLogArchiveId?: number;
        UserId?: number;
        UserName?: string;
        Action?: string;
        ChangedOn?: string;
        TableName?: string;
        RowId?: number;
        Module?: string;
        Page?: string;
        FieldName?: string;
        OldValue?: string;
        NewValue?: string;
        Comments?: string;
        PcipAddress?: string;
        BatchId?: number;
        BatchName?: string;
        MachineId?: number;
        MachineName?: string;
        UserEmployeeId?: string;
        UserFirstName?: string;
        UserLastName?: string;
        UserDepartmentId?: number;
        UserDesignation?: string;
        UserMobileCode?: number;
        UserMobileNumber?: number;
        UserEmail?: string;
        UserUsername?: string;
        UserPasswordHash?: string;
        UserPasswordSalt?: string;
        UserUserImage?: number[];
        UserAddress?: string;
        UserCityId?: number;
        UserPinCode?: string;
        UserRoleId?: number;
        UserPasswordExpiryDate?: string;
        UserIsForgotPassword?: number;
        UserIsPasswordChangeOnLogin?: boolean;
        UserIsUserHidden?: number;
        UserStatusId?: number;
        UserCreatedBy?: number;
        UserCreatedDate?: string;
        UserUpdatedBy?: number;
        UserUpdatedDate?: string;
        BatchBatchName?: string;
        BatchPackId?: number;
        BatchBatchStartDateTime?: string;
        BatchBatchEndDateTime?: string;
        BatchMachineLineId?: number;
        BatchBatchStatus?: string;
        BatchBatchSize?: number;
        BatchBatchFor?: string;
        BatchNumberOfBottles?: number;
        BatchTotalGoodBottles?: number;
        BatchTotalRejectedBottles?: number;
        BatchProductionSpeed?: string;
        BatchExpiryDate?: string;
        BatchStatusId?: number;
        BatchCreatedBy?: number;
        BatchCreatedDate?: string;
        BatchUpdatedBy?: number;
        BatchUpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
    }
    namespace AuditLogArchiveRow {
        const idProperty = "AuditLogArchiveId";
        const nameProperty = "UserName";
        const localTextPrefix = "Report.AuditLogArchive";
        const deletePermission = "Report:AuditLogArchive:Read";
        const insertPermission = "Report:AuditLogArchive:Read";
        const readPermission = "Report:AuditLogArchive:Read";
        const updatePermission = "Report:AuditLogArchive:Read";
        const enum Fields {
            AuditLogArchiveId = "AuditLogArchiveId",
            UserId = "UserId",
            UserName = "UserName",
            Action = "Action",
            ChangedOn = "ChangedOn",
            TableName = "TableName",
            RowId = "RowId",
            Module = "Module",
            Page = "Page",
            FieldName = "FieldName",
            OldValue = "OldValue",
            NewValue = "NewValue",
            Comments = "Comments",
            PcipAddress = "PcipAddress",
            BatchId = "BatchId",
            BatchName = "BatchName",
            MachineId = "MachineId",
            MachineName = "MachineName",
            UserEmployeeId = "UserEmployeeId",
            UserFirstName = "UserFirstName",
            UserLastName = "UserLastName",
            UserDepartmentId = "UserDepartmentId",
            UserDesignation = "UserDesignation",
            UserMobileCode = "UserMobileCode",
            UserMobileNumber = "UserMobileNumber",
            UserEmail = "UserEmail",
            UserUsername = "UserUsername",
            UserPasswordHash = "UserPasswordHash",
            UserPasswordSalt = "UserPasswordSalt",
            UserUserImage = "UserUserImage",
            UserAddress = "UserAddress",
            UserCityId = "UserCityId",
            UserPinCode = "UserPinCode",
            UserRoleId = "UserRoleId",
            UserPasswordExpiryDate = "UserPasswordExpiryDate",
            UserIsForgotPassword = "UserIsForgotPassword",
            UserIsPasswordChangeOnLogin = "UserIsPasswordChangeOnLogin",
            UserIsUserHidden = "UserIsUserHidden",
            UserStatusId = "UserStatusId",
            UserCreatedBy = "UserCreatedBy",
            UserCreatedDate = "UserCreatedDate",
            UserUpdatedBy = "UserUpdatedBy",
            UserUpdatedDate = "UserUpdatedDate",
            BatchBatchName = "BatchBatchName",
            BatchPackId = "BatchPackId",
            BatchBatchStartDateTime = "BatchBatchStartDateTime",
            BatchBatchEndDateTime = "BatchBatchEndDateTime",
            BatchMachineLineId = "BatchMachineLineId",
            BatchBatchStatus = "BatchBatchStatus",
            BatchBatchSize = "BatchBatchSize",
            BatchBatchFor = "BatchBatchFor",
            BatchNumberOfBottles = "BatchNumberOfBottles",
            BatchTotalGoodBottles = "BatchTotalGoodBottles",
            BatchTotalRejectedBottles = "BatchTotalRejectedBottles",
            BatchProductionSpeed = "BatchProductionSpeed",
            BatchExpiryDate = "BatchExpiryDate",
            BatchStatusId = "BatchStatusId",
            BatchCreatedBy = "BatchCreatedBy",
            BatchCreatedDate = "BatchCreatedDate",
            BatchUpdatedBy = "BatchUpdatedBy",
            BatchUpdatedDate = "BatchUpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate"
        }
    }
}
declare namespace CVC.Report {
    namespace AuditLogArchiveService {
        const baseUrl = "Report/AuditLogArchive";
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AuditLogArchiveRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AuditLogArchiveRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Retrieve = "Report/AuditLogArchive/Retrieve",
            List = "Report/AuditLogArchive/List"
        }
    }
}
declare namespace CVC.Report {
}
declare namespace CVC.Report {
    interface AuditLogForm {
        UserId: Serenity.IntegerEditor;
        UserName: Serenity.StringEditor;
        Action: Serenity.StringEditor;
        ChangedOn: Serenity.DateEditor;
        TableName: Serenity.StringEditor;
        RowId: Serenity.IntegerEditor;
        Module: Serenity.StringEditor;
        Page: Serenity.StringEditor;
        FieldName: Serenity.StringEditor;
        OldValue: Serenity.StringEditor;
        NewValue: Serenity.StringEditor;
        Comments: Serenity.StringEditor;
        PcipAddress: Serenity.StringEditor;
        BatchId: Serenity.IntegerEditor;
        BatchName: Serenity.StringEditor;
        MachineId: Serenity.LookupEditor;
        MachineName: Serenity.StringEditor;
    }
    class AuditLogForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Report {
    interface AuditLogRow {
        AuditLogId?: number;
        UserId?: number;
        UserName?: string;
        Action?: string;
        ChangedOn?: string;
        TableName?: string;
        RowId?: number;
        Module?: string;
        Page?: string;
        FieldName?: string;
        OldValue?: string;
        NewValue?: string;
        Comments?: string;
        PcipAddress?: string;
        BatchId?: number;
        BatchName?: string;
        MachineId?: number;
        MachineName?: string;
        UserEmployeeId?: string;
        UserFirstName?: string;
        UserLastName?: string;
        UserDepartmentId?: number;
        UserDesignation?: string;
        UserMobileCode?: number;
        UserMobileNumber?: number;
        UserEmail?: string;
        UserUsername?: string;
        UserPasswordHash?: string;
        UserPasswordSalt?: string;
        UserUserImage?: number[];
        UserAddress?: string;
        UserCityId?: number;
        UserPinCode?: string;
        UserRoleId?: number;
        UserPasswordExpiryDate?: string;
        UserIsForgotPassword?: number;
        UserIsPasswordChangeOnLogin?: boolean;
        UserIsUserHidden?: number;
        UserStatusId?: number;
        UserCreatedBy?: number;
        UserCreatedDate?: string;
        UserUpdatedBy?: number;
        UserUpdatedDate?: string;
        BatchBatchName?: string;
        BatchPackId?: number;
        BatchBatchStartDateTime?: string;
        BatchBatchEndDateTime?: string;
        BatchMachineLineId?: number;
        BatchBatchStatus?: string;
        BatchBatchSize?: number;
        BatchBatchFor?: string;
        BatchNumberOfBottles?: number;
        BatchTotalGoodBottles?: number;
        BatchTotalRejectedBottles?: number;
        BatchProductionSpeed?: string;
        BatchExpiryDate?: string;
        BatchStatusId?: number;
        BatchCreatedBy?: number;
        BatchCreatedDate?: string;
        BatchUpdatedBy?: number;
        BatchUpdatedDate?: string;
        MachineMachineLineId?: number;
        MachineMachineName?: string;
        MachineModelNumber?: string;
        MachineSerialNumber?: string;
        MachineMake?: string;
        MachineYear?: number;
        MachinePlcMake?: string;
        MachinePlcModelNumber?: string;
        MachinePlcSerialNumber?: string;
        MachinePlcAddress?: string;
        MachineAccessIpAddress?: string;
        MachineMachineSequence?: number;
        MachineMachineImage?: number[];
        MachineStatusId?: number;
        MachineDescription?: string;
        MachineCreatedBy?: number;
        MachineCreatedDate?: string;
        MachineUpdatedBy?: number;
        MachineUpdatedDate?: string;
    }
    namespace AuditLogRow {
        const idProperty = "AuditLogId";
        const nameProperty = "UserName";
        const localTextPrefix = "Report.AuditLog";
        const deletePermission = "Report:AuditLog:Read";
        const insertPermission = "Report:AuditLog:Read";
        const readPermission = "Report:AuditLog:Read";
        const updatePermission = "Report:AuditLog:Read";
        const enum Fields {
            AuditLogId = "AuditLogId",
            UserId = "UserId",
            UserName = "UserName",
            Action = "Action",
            ChangedOn = "ChangedOn",
            TableName = "TableName",
            RowId = "RowId",
            Module = "Module",
            Page = "Page",
            FieldName = "FieldName",
            OldValue = "OldValue",
            NewValue = "NewValue",
            Comments = "Comments",
            PcipAddress = "PcipAddress",
            BatchId = "BatchId",
            BatchName = "BatchName",
            MachineId = "MachineId",
            MachineName = "MachineName",
            UserEmployeeId = "UserEmployeeId",
            UserFirstName = "UserFirstName",
            UserLastName = "UserLastName",
            UserDepartmentId = "UserDepartmentId",
            UserDesignation = "UserDesignation",
            UserMobileCode = "UserMobileCode",
            UserMobileNumber = "UserMobileNumber",
            UserEmail = "UserEmail",
            UserUsername = "UserUsername",
            UserPasswordHash = "UserPasswordHash",
            UserPasswordSalt = "UserPasswordSalt",
            UserUserImage = "UserUserImage",
            UserAddress = "UserAddress",
            UserCityId = "UserCityId",
            UserPinCode = "UserPinCode",
            UserRoleId = "UserRoleId",
            UserPasswordExpiryDate = "UserPasswordExpiryDate",
            UserIsForgotPassword = "UserIsForgotPassword",
            UserIsPasswordChangeOnLogin = "UserIsPasswordChangeOnLogin",
            UserIsUserHidden = "UserIsUserHidden",
            UserStatusId = "UserStatusId",
            UserCreatedBy = "UserCreatedBy",
            UserCreatedDate = "UserCreatedDate",
            UserUpdatedBy = "UserUpdatedBy",
            UserUpdatedDate = "UserUpdatedDate",
            BatchBatchName = "BatchBatchName",
            BatchPackId = "BatchPackId",
            BatchBatchStartDateTime = "BatchBatchStartDateTime",
            BatchBatchEndDateTime = "BatchBatchEndDateTime",
            BatchMachineLineId = "BatchMachineLineId",
            BatchBatchStatus = "BatchBatchStatus",
            BatchBatchSize = "BatchBatchSize",
            BatchBatchFor = "BatchBatchFor",
            BatchNumberOfBottles = "BatchNumberOfBottles",
            BatchTotalGoodBottles = "BatchTotalGoodBottles",
            BatchTotalRejectedBottles = "BatchTotalRejectedBottles",
            BatchProductionSpeed = "BatchProductionSpeed",
            BatchExpiryDate = "BatchExpiryDate",
            BatchStatusId = "BatchStatusId",
            BatchCreatedBy = "BatchCreatedBy",
            BatchCreatedDate = "BatchCreatedDate",
            BatchUpdatedBy = "BatchUpdatedBy",
            BatchUpdatedDate = "BatchUpdatedDate",
            MachineMachineLineId = "MachineMachineLineId",
            MachineMachineName = "MachineMachineName",
            MachineModelNumber = "MachineModelNumber",
            MachineSerialNumber = "MachineSerialNumber",
            MachineMake = "MachineMake",
            MachineYear = "MachineYear",
            MachinePlcMake = "MachinePlcMake",
            MachinePlcModelNumber = "MachinePlcModelNumber",
            MachinePlcSerialNumber = "MachinePlcSerialNumber",
            MachinePlcAddress = "MachinePlcAddress",
            MachineAccessIpAddress = "MachineAccessIpAddress",
            MachineMachineSequence = "MachineMachineSequence",
            MachineMachineImage = "MachineMachineImage",
            MachineStatusId = "MachineStatusId",
            MachineDescription = "MachineDescription",
            MachineCreatedBy = "MachineCreatedBy",
            MachineCreatedDate = "MachineCreatedDate",
            MachineUpdatedBy = "MachineUpdatedBy",
            MachineUpdatedDate = "MachineUpdatedDate"
        }
    }
}
declare namespace CVC.Report {
    namespace AuditLogService {
        const baseUrl = "Report/AuditLog";
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<AuditLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<AuditLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Retrieve = "Report/AuditLog/Retrieve",
            List = "Report/AuditLog/List"
        }
    }
}
declare namespace CVC.Report {
}
declare namespace CVC.Report {
    interface BatchLogArchiveForm {
        MachineId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        Description: Serenity.StringEditor;
        UserId: Serenity.IntegerEditor;
        UpdatedDateTime: Serenity.DateEditor;
    }
    class BatchLogArchiveForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Report {
    interface BatchLogArchiveRow {
        BatchLogArchiveId?: number;
        MachineId?: number;
        BatchId?: number;
        Description?: string;
        UserId?: number;
        UpdatedDateTime?: string;
    }
    namespace BatchLogArchiveRow {
        const idProperty = "BatchLogArchiveId";
        const nameProperty = "Description";
        const localTextPrefix = "Report.BatchLogArchive";
        const deletePermission = "Administration:General";
        const insertPermission = "Administration:General";
        const readPermission = "Administration:General";
        const updatePermission = "Administration:General";
        const enum Fields {
            BatchLogArchiveId = "BatchLogArchiveId",
            MachineId = "MachineId",
            BatchId = "BatchId",
            Description = "Description",
            UserId = "UserId",
            UpdatedDateTime = "UpdatedDateTime"
        }
    }
}
declare namespace CVC.Report {
    namespace BatchLogArchiveService {
        const baseUrl = "Report/BatchLogArchive";
        function Create(request: Serenity.SaveRequest<BatchLogArchiveRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<BatchLogArchiveRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BatchLogArchiveRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BatchLogArchiveRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Report/BatchLogArchive/Create",
            Update = "Report/BatchLogArchive/Update",
            Delete = "Report/BatchLogArchive/Delete",
            Retrieve = "Report/BatchLogArchive/Retrieve",
            List = "Report/BatchLogArchive/List"
        }
    }
}
declare namespace CVC.Report {
}
declare namespace CVC.Report {
    interface BatchLogForm {
        MachineId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        Description: Serenity.StringEditor;
        UserId: Serenity.IntegerEditor;
        UpdatedDateTime: Serenity.DateEditor;
    }
    class BatchLogForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Report {
    interface BatchLogRow {
        BatchLogId?: number;
        MachineId?: number;
        BatchId?: number;
        Description?: string;
        UserId?: number;
        UpdatedDateTime?: string;
    }
    namespace BatchLogRow {
        const idProperty = "BatchLogId";
        const nameProperty = "Description";
        const localTextPrefix = "Report.BatchLog";
        const deletePermission = "Report:BatchLog:Read";
        const insertPermission = "Report:BatchLog:Read";
        const readPermission = "Report:BatchLog:Read";
        const updatePermission = "Report:BatchLog:Read";
        const enum Fields {
            BatchLogId = "BatchLogId",
            MachineId = "MachineId",
            BatchId = "BatchId",
            Description = "Description",
            UserId = "UserId",
            UpdatedDateTime = "UpdatedDateTime"
        }
    }
}
declare namespace CVC.Report {
    namespace BatchLogService {
        const baseUrl = "Report/BatchLog";
        function Create(request: Serenity.SaveRequest<BatchLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<BatchLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BatchLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BatchLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Report/BatchLog/Create",
            Update = "Report/BatchLog/Update",
            Delete = "Report/BatchLog/Delete",
            Retrieve = "Report/BatchLog/Retrieve",
            List = "Report/BatchLog/List"
        }
    }
}
declare namespace CVC.Report {
}
declare namespace CVC.Report {
    interface ExceptionLogForm {
        Id: Serenity.StringEditor;
        Type: Serenity.StringEditor;
        Url: Serenity.StringEditor;
        Message: Serenity.StringEditor;
    }
    class ExceptionLogForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Report {
    interface ExceptionLogRow {
        Id?: number;
        ApplicationName?: string;
        Type?: string;
        Url?: string;
        Message?: string;
        CreationDate?: string;
    }
    namespace ExceptionLogRow {
        const idProperty = "Id";
        const nameProperty = "Message";
        const localTextPrefix = "Report.ExceptionLog";
        const deletePermission = "Report:ExceptionLog:Read";
        const insertPermission = "Report:ExceptionLog:Read";
        const readPermission = "Report:ExceptionLog:Read";
        const updatePermission = "Report:ExceptionLog:Read";
        const enum Fields {
            Id = "Id",
            ApplicationName = "ApplicationName",
            Type = "Type",
            Url = "Url",
            Message = "Message",
            CreationDate = "CreationDate"
        }
    }
}
declare namespace CVC.Report {
    namespace ExceptionLogService {
        const baseUrl = "Report/ExceptionLog";
        function Create(request: Serenity.SaveRequest<ExceptionLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ExceptionLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ExceptionLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ExceptionLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Report/ExceptionLog/Create",
            Update = "Report/ExceptionLog/Update",
            Delete = "Report/ExceptionLog/Delete",
            Retrieve = "Report/ExceptionLog/Retrieve",
            List = "Report/ExceptionLog/List"
        }
    }
}
declare namespace CVC.Report {
}
declare namespace CVC.Report {
    interface UserLogArchiveForm {
        UserLogArchiveId: Serenity.StringEditor;
        UserId: Serenity.IntegerEditor;
        UserName: Serenity.StringEditor;
        Action: Serenity.StringEditor;
        ChangedOn: Serenity.DateEditor;
    }
    class UserLogArchiveForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Report {
    interface UserLogArchiveRow {
        UserLogArchiveId?: number;
        UserId?: number;
        UserName?: string;
        Action?: string;
        ChangedOn?: string;
    }
    namespace UserLogArchiveRow {
        const idProperty = "UserLogArchiveId";
        const nameProperty = "UserName";
        const localTextPrefix = "Report.UserLogArchive";
        const deletePermission = "Report:UserLogArchive:Read";
        const insertPermission = "Report:UserLogArchive:Read";
        const readPermission = "Report:UserLogArchive:Read";
        const updatePermission = "Report:UserLogArchive:Read";
        const enum Fields {
            UserLogArchiveId = "UserLogArchiveId",
            UserId = "UserId",
            UserName = "UserName",
            Action = "Action",
            ChangedOn = "ChangedOn"
        }
    }
}
declare namespace CVC.Report {
    namespace UserLogArchiveService {
        const baseUrl = "Report/UserLogArchive";
        function Create(request: Serenity.SaveRequest<UserLogArchiveRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<UserLogArchiveRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<UserLogArchiveRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<UserLogArchiveRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Report/UserLogArchive/Create",
            Update = "Report/UserLogArchive/Update",
            Delete = "Report/UserLogArchive/Delete",
            Retrieve = "Report/UserLogArchive/Retrieve",
            List = "Report/UserLogArchive/List"
        }
    }
}
declare namespace CVC.Report {
}
declare namespace CVC.Report {
    interface UserLogForm {
        UserLogId: Serenity.StringEditor;
        UserId: Serenity.IntegerEditor;
        UserName: Serenity.StringEditor;
        Action: Serenity.StringEditor;
        ChangedOn: Serenity.DateEditor;
    }
    class UserLogForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Report {
    interface UserLogRow {
        UserLogId?: number;
        UserId?: number;
        UserName?: string;
        Action?: string;
        ChangedOn?: string;
    }
    namespace UserLogRow {
        const idProperty = "UserLogId";
        const nameProperty = "UserName";
        const localTextPrefix = "Report.UserLog";
        const deletePermission = "Report:UserLog:Read";
        const insertPermission = "Report:UserLog:Read";
        const readPermission = "Report:UserLog:Read";
        const updatePermission = "Report:UserLog:Read";
        const enum Fields {
            UserLogId = "UserLogId",
            UserId = "UserId",
            UserName = "UserName",
            Action = "Action",
            ChangedOn = "ChangedOn"
        }
    }
}
declare namespace CVC.Report {
    namespace UserLogService {
        const baseUrl = "Report/UserLog";
        function Create(request: Serenity.SaveRequest<UserLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<UserLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<UserLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<UserLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Report/UserLog/Create",
            Update = "Report/UserLog/Update",
            Delete = "Report/UserLog/Delete",
            Retrieve = "Report/UserLog/Retrieve",
            List = "Report/UserLog/List"
        }
    }
}
declare namespace CVC.Report {
}
declare namespace CVC.Report {
    interface UserLoginDetailsForm {
        UserId: Serenity.IntegerEditor;
        LoginDatetime: Serenity.DateEditor;
        LogoutDatetime: Serenity.DateEditor;
        IsOnline: Serenity.IntegerEditor;
    }
    class UserLoginDetailsForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace CVC.Report {
    interface UserLoginDetailsRow {
        UserLoginDetailsId?: number;
        UserId?: number;
        LoginDatetime?: string;
        LogoutDatetime?: string;
        IsOnline?: number;
        UserEmployeeId?: string;
        UserFirstName?: string;
        UserLastName?: string;
        UserDepartmentId?: number;
        UserDesignation?: string;
        UserMobileCode?: number;
        UserMobileNumber?: number;
        UserEmail?: string;
        UserUsername?: string;
        UserPasswordHash?: string;
        UserPasswordSalt?: string;
        UserUserImage?: number[];
        UserAddress?: string;
        UserCityId?: number;
        UserPinCode?: string;
        UserRoleId?: number;
        UserPasswordExpiryDate?: string;
        UserIsForgotPassword?: number;
        UserIsPasswordChangeOnLogin?: boolean;
        UserIsUserHidden?: number;
        UserStatusId?: number;
        UserCreatedBy?: number;
        UserCreatedDate?: string;
        UserUpdatedBy?: number;
        UserUpdatedDate?: string;
    }
    namespace UserLoginDetailsRow {
        const idProperty = "UserLoginDetailsId";
        const localTextPrefix = "Report.UserLoginDetails";
        const deletePermission = "";
        const insertPermission = "";
        const readPermission = "";
        const updatePermission = "";
        const enum Fields {
            UserLoginDetailsId = "UserLoginDetailsId",
            UserId = "UserId",
            LoginDatetime = "LoginDatetime",
            LogoutDatetime = "LogoutDatetime",
            IsOnline = "IsOnline",
            UserEmployeeId = "UserEmployeeId",
            UserFirstName = "UserFirstName",
            UserLastName = "UserLastName",
            UserDepartmentId = "UserDepartmentId",
            UserDesignation = "UserDesignation",
            UserMobileCode = "UserMobileCode",
            UserMobileNumber = "UserMobileNumber",
            UserEmail = "UserEmail",
            UserUsername = "UserUsername",
            UserPasswordHash = "UserPasswordHash",
            UserPasswordSalt = "UserPasswordSalt",
            UserUserImage = "UserUserImage",
            UserAddress = "UserAddress",
            UserCityId = "UserCityId",
            UserPinCode = "UserPinCode",
            UserRoleId = "UserRoleId",
            UserPasswordExpiryDate = "UserPasswordExpiryDate",
            UserIsForgotPassword = "UserIsForgotPassword",
            UserIsPasswordChangeOnLogin = "UserIsPasswordChangeOnLogin",
            UserIsUserHidden = "UserIsUserHidden",
            UserStatusId = "UserStatusId",
            UserCreatedBy = "UserCreatedBy",
            UserCreatedDate = "UserCreatedDate",
            UserUpdatedBy = "UserUpdatedBy",
            UserUpdatedDate = "UserUpdatedDate"
        }
    }
}
declare namespace CVC.Report {
    namespace UserLoginDetailsService {
        const baseUrl = "Report/UserLoginDetails";
        function Create(request: Serenity.SaveRequest<UserLoginDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<UserLoginDetailsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<UserLoginDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<UserLoginDetailsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Report/UserLoginDetails/Create",
            Update = "Report/UserLoginDetails/Update",
            Delete = "Report/UserLoginDetails/Delete",
            Retrieve = "Report/UserLoginDetails/Retrieve",
            List = "Report/UserLoginDetails/List"
        }
    }
}
declare namespace CVC {
    interface ScriptUserDefinition {
        Username?: string;
        DisplayName?: string;
        IsAdmin?: boolean;
        Permissions?: {
            [key: string]: boolean;
        };
    }
}
declare namespace CVC.Texts {
}
declare namespace CVC.Common.Bases {
    class GridBase<TItem, TOptions> extends Serenity.EntityGrid<TItem, TOptions> {
        constructor(container: JQuery, options?: TOptions);
        protected createSlickGrid(): Slick.Grid;
    }
}
declare namespace CVC.Common.CustomColumnFormatters {
    class ColoredColumnFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
        hideText: boolean;
        backgroundProperty: string;
        backgroundColor: string;
        borderProperty: string;
        borderColor: string;
        initializeColumn(column: Slick.Column): void;
    }
}
declare namespace CVC.Common.CustomColumnFormatters {
    class ActivationColumnFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
        initializeColumn(column: Slick.Column): void;
    }
}
declare namespace CVC.Common.CustomColumnFormatters {
    class AlignmentColumnFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
        initializeColumn(column: Slick.Column): void;
    }
}
declare namespace CVC.Common.CustomColumnFormatters {
    class AppearanceColumnFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
        initializeColumn(column: Slick.Column): void;
    }
}
declare namespace CVC.Common.CustomColumnFormatters {
    class BorderStyleColumnFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
        initializeColumn(column: Slick.Column): void;
    }
}
declare namespace CVC.Common.CustomColumnFormatters {
    class DOTypeColumnFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
        initializeColumn(column: Slick.Column): void;
    }
}
declare namespace CVC.Common.CustomColumnFormatters {
    class DefaultViewColumnFormatters implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
        initializeColumn(column: Slick.Column): void;
    }
}
declare namespace CVC.Common.CustomColumnFormatters {
    class SortTypeColumnFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext): string;
        initializeColumn(column: Slick.Column): void;
    }
}
declare namespace CVC.Common.CustomEditors {
    class ColorPickerEditor extends Serenity.StringEditor {
        constructor(input: JQuery);
    }
}
declare namespace CVC.Common.CustomEditors {
    class NumberInputEditor extends Serenity.StringEditor {
        constructor(input: JQuery);
        min: number;
        max: number;
    }
}
declare namespace CVC.Common.CustomEditors {
    class ActivationValueEditor extends Serenity.Select2Editor<any, any> {
        constructor(container: JQuery);
    }
}
declare namespace CVC.Common.CustomEditors {
    class AlignmentValueEditor extends Serenity.Select2Editor<any, any> {
        constructor(container: JQuery);
    }
}
declare namespace CVC.Common.CustomEditors {
    class AppearanceValueEditor extends Serenity.Select2Editor<any, any> {
        constructor(container: JQuery);
    }
}
declare namespace CVC.Common.CustomEditors {
    class BorderStyleValueEditor extends Serenity.Select2Editor<any, any> {
        constructor(container: JQuery);
    }
}
declare namespace CVC.Common.CustomEditors {
    class DOTypeValueEditor extends Serenity.Select2Editor<any, any> {
        constructor(container: JQuery);
    }
}
declare namespace CVC.Common.CustomEditors {
    class DefaultViewValueEditor extends Serenity.Select2Editor<any, any> {
        constructor(container: JQuery);
    }
}
declare namespace CVC.Common.CustomEditors {
    var ActivationLookup: {
        id: string;
        text: string;
    }[];
    var BorderStyleLookup: {
        id: string;
        text: string;
    }[];
    var AlignmentLookup: {
        id: string;
        text: string;
    }[];
    var SortTypeLookup: {
        id: string;
        text: string;
    }[];
    var DefaultViewLookup: {
        id: string;
        text: string;
    }[];
    var AppearanceLookup: {
        id: string;
        text: string;
    }[];
    var DOTypeLookup: {
        id: string;
        text: string;
        field: string;
    }[];
    var FontLookup: {
        id: string;
        text: string;
    }[];
}
declare namespace CVC.Common.CustomEditors {
    class FontValueEditor extends Serenity.Select2Editor<any, any> {
        constructor(container: JQuery);
    }
}
declare namespace CVC.Common.CustomEditors {
    class SortTypeValueEditor extends Serenity.Select2Editor<any, any> {
        constructor(container: JQuery);
    }
}
declare namespace CVC {
    class BasicProgressDialog extends Serenity.TemplatedDialog<any> {
        constructor();
        cancelled: boolean;
        get max(): number;
        set max(value: number);
        get value(): number;
        set value(value: number);
        get title(): string;
        set title(value: string);
        cancelTitle: string;
        getDialogOptions(): JQueryUI.DialogOptions;
        initDialog(): void;
        getTemplate(): string;
    }
}
declare namespace CVC.Common {
    class BulkServiceAction {
        protected keys: string[];
        protected queue: string[];
        protected queueIndex: number;
        protected progressDialog: BasicProgressDialog;
        protected pendingRequests: number;
        protected completedRequests: number;
        protected errorByKey: Q.Dictionary<Serenity.ServiceError>;
        private successCount;
        private errorCount;
        done: () => void;
        protected createProgressDialog(): void;
        protected getConfirmationFormat(): string;
        protected getConfirmationMessage(targetCount: any): string;
        protected confirm(targetCount: any, action: any): void;
        protected getNothingToProcessMessage(): string;
        protected nothingToProcess(): void;
        protected getParallelRequests(): number;
        protected getBatchSize(): number;
        protected startParallelExecution(): void;
        protected serviceCallCleanup(): void;
        protected executeForBatch(batch: string[]): void;
        protected executeNextBatch(): void;
        protected getAllHadErrorsFormat(): string;
        protected showAllHadErrors(): void;
        protected getSomeHadErrorsFormat(): string;
        protected showSomeHadErrors(): void;
        protected getAllSuccessFormat(): string;
        protected showAllSuccess(): void;
        protected showResults(): void;
        execute(keys: string[]): void;
        get_successCount(): any;
        set_successCount(value: number): void;
        get_errorCount(): any;
        set_errorCount(value: number): void;
    }
}
declare namespace CVC.DialogUtils {
    function pendingChangesConfirmation(element: JQuery, hasPendingChanges: () => boolean): void;
}
declare namespace CVC.Common {
    class EnumSelectFormatter implements Slick.Formatter {
        constructor();
        format(ctx: Slick.FormatterContext): string;
        enumKey: string;
        allowClear: boolean;
        emptyItemText: string;
    }
}
declare namespace CVC.Common {
    interface ExcelExportOptions {
        grid: Serenity.DataGrid<any, any>;
        service: string;
        onViewSubmit: () => boolean;
        title?: string;
        hint?: string;
        separator?: boolean;
    }
    namespace ExcelExportHelper {
        function createToolButton(options: ExcelExportOptions): Serenity.ToolButton;
    }
}
declare namespace CVC.Common {
    class GridEditorBase<TEntity> extends Serenity.EntityGrid<TEntity, any> implements Serenity.IGetEditValue, Serenity.ISetEditValue {
        protected getIdProperty(): string;
        protected nextId: number;
        constructor(container: JQuery);
        protected id(entity: TEntity): any;
        protected getNextId(): string;
        protected setNewId(entity: TEntity): void;
        protected save(opt: Serenity.ServiceOptions<any>, callback: (r: Serenity.ServiceResponse) => void): void;
        protected deleteEntity(id: number): boolean;
        protected validateEntity(row: TEntity, id: number): boolean;
        protected setEntities(items: TEntity[]): void;
        protected getNewEntity(): TEntity;
        protected getButtons(): Serenity.ToolButton[];
        protected editItem(entityOrId: any): void;
        getEditValue(property: any, target: any): void;
        setEditValue(source: any, property: any): void;
        get value(): TEntity[];
        set value(value: TEntity[]);
        protected getGridCanLoad(): boolean;
        protected usePager(): boolean;
        protected getInitialTitle(): any;
        protected createQuickSearchInput(): void;
        protected enableDeleteColumn(): boolean;
        protected getColumns(): Slick.Column[];
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
    }
}
declare namespace CVC.Common {
    class GridEditorDialog<TEntity> extends Serenity.EntityDialog<TEntity, any> {
        protected getIdProperty(): string;
        onSave: (options: Serenity.ServiceOptions<Serenity.SaveResponse>, callback: (response: Serenity.SaveResponse) => void) => void;
        onDelete: (options: Serenity.ServiceOptions<Serenity.DeleteResponse>, callback: (response: Serenity.DeleteResponse) => void) => void;
        destroy(): void;
        protected updateInterface(): void;
        protected saveHandler(options: Serenity.ServiceOptions<Serenity.SaveResponse>, callback: (response: Serenity.SaveResponse) => void): void;
        protected deleteHandler(options: Serenity.ServiceOptions<Serenity.DeleteResponse>, callback: (response: Serenity.DeleteResponse) => void): void;
    }
}
declare namespace CVC {
    /**
     * This is an editor widget but it only displays a text, not edits it.
     *
     */
    class StaticTextBlock extends Serenity.Widget<StaticTextBlockOptions> implements Serenity.ISetEditValue {
        private value;
        constructor(container: JQuery, options: StaticTextBlockOptions);
        private updateElementContent;
        /**
         * By implementing ISetEditValue interface, we allow this editor to display its field value.
         * But only do this when our text content is not explicitly set in options
         */
        setEditValue(source: any, property: Serenity.PropertyItem): void;
    }
    interface StaticTextBlockOptions {
        text: string;
        isHtml: boolean;
        isLocalText: boolean;
        hideLabel: boolean;
    }
}
declare namespace CVC.MachineCustomization {
    class AlarmDisplayDialog extends Serenity.EntityDialog<AlarmDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: AlarmDisplayForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class AlarmDisplayGrid extends Common.Bases.GridBase<AlarmDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof AlarmDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getSlickOptions(): Slick.GridOptions;
        protected createSlickGrid(): Slick.Grid;
    }
}
declare namespace CVC.MachineCustomization {
    class AttachmentDisplayDialog extends Serenity.EntityDialog<AttachmentDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: AttachmentDisplayForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class AttachmentDisplayGrid extends Common.Bases.GridBase<AttachmentDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof AttachmentDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace CVC.MachineCustomization {
    class ButtonDisplayDialog extends Serenity.EntityDialog<ButtonDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: ButtonDisplayForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class ButtonDisplayGrid extends Common.Bases.GridBase<ButtonDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ButtonDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace CVC.MachineCustomization {
    class ContainerDisplayDialog extends Serenity.EntityDialog<ContainerDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: ContainerDisplayForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class ContainerDisplayGrid extends Common.Bases.GridBase<ContainerDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ContainerDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectDialog extends Serenity.EntityDialog<DisplayObjectRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: DisplayObjectForm;
        constructor();
        protected getToolbarButtons(): Serenity.ToolButton[];
        protected afterLoadEntity(): void;
        private checkDisplayObjectFields;
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectGrid extends Common.Bases.GridBase<DisplayObjectRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DisplayObjectDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getColumns(): Slick.Column[];
        protected getSlickOptions(): Slick.GridOptions;
        protected createSlickGrid(): Slick.Grid;
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectLookupEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, any> {
        constructor(container: JQuery, opt: Serenity.LookupEditorOptions);
        protected getLookupKey(): string;
        protected getItems(lookup: Q.Lookup<any>): any;
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectColorDialog extends Serenity.EntityDialog<DisplayObjectColorRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: DisplayObjectColorForm;
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectColorGrid extends Serenity.EntityGrid<DisplayObjectColorRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DisplayObjectColorDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectFieldDialog extends Serenity.EntityDialog<DisplayObjectFieldRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: DisplayObjectFieldForm;
        private sequenceNums;
        constructor();
        protected afterLoadEntity(): void;
        protected onSaveSuccess(response: any): void;
        protected getToolbarButtons(): Serenity.ToolButton[];
        private addUpdateViewFieldAuthentication;
        private getSequenceNumbers;
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectFieldGrid extends Common.Bases.GridBase<DisplayObjectFieldRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DisplayObjectFieldDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected onViewSubmit(): boolean;
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectTypeColorDialog extends Serenity.EntityDialog<DisplayObjectTypeColorRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: DisplayObjectTypeColorForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class DisplayObjectTypeColorGrid extends Serenity.EntityGrid<DisplayObjectTypeColorRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DisplayObjectTypeColorDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected onViewSubmit(): boolean;
    }
}
declare namespace CVC.MachineCustomization {
    class FormDisplayDialog extends Serenity.EntityDialog<FormDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: FormDisplayForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class FormDisplayGrid extends Common.Bases.GridBase<FormDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof FormDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace CVC.MachineCustomization {
    class LineChartDisplayDialog extends Serenity.EntityDialog<LineChartDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: LineChartDisplayForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class LineChartDisplayGrid extends Common.Bases.GridBase<LineChartDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof LineChartDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getSlickOptions(): Slick.GridOptions;
        protected createSlickGrid(): Slick.Grid;
    }
}
declare namespace CVC.MachineCustomization {
    class ListDisplayDialog extends Serenity.EntityDialog<ListDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: ListDisplayForm;
        constructor();
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class ListDisplayEditor extends Common.GridEditorBase<ListDisplayRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ListDisplayEditorDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
        validateEntity(row: any, id: any): boolean;
    }
}
declare namespace CVC.MachineCustomization {
    class ListDisplayEditorDialog extends Common.GridEditorDialog<ListDisplayRow> {
        protected getFormKey(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected form: ListDisplayEditorForm;
    }
}
declare namespace CVC.MachineCustomization {
    class ListDisplayGrid extends Common.Bases.GridBase<ListDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ListDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace CVC.MachineCustomization {
    class NotificationDisplayDialog extends Serenity.EntityDialog<NotificationDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: NotificationDisplayForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class NotificationDisplayGrid extends Common.Bases.GridBase<NotificationDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof NotificationDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getSlickOptions(): Slick.GridOptions;
        protected createSlickGrid(): Slick.Grid;
    }
}
declare namespace CVC.MachineCustomization {
    class PieChartDisplayDialog extends Serenity.EntityDialog<PieChartDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: PieChartDisplayForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class PieChartDisplayGrid extends Common.Bases.GridBase<PieChartDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof PieChartDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getSlickOptions(): Slick.GridOptions;
        protected createSlickGrid(): Slick.Grid;
    }
}
declare namespace CVC.MachineCustomization {
    class PrimaryRelationshipDialog extends Serenity.EntityDialog<PrimaryRelationshipRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: PrimaryRelationshipForm;
        protected getToolbarButtons(): Serenity.ToolButton[];
    }
}
declare namespace CVC.MachineCustomization {
    class PrimaryRelationshipGrid extends Common.Bases.GridBase<PrimaryRelationshipRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof PrimaryRelationshipDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getSlickOptions(): Slick.GridOptions;
        protected createSlickGrid(): Slick.Grid;
    }
}
declare namespace CVC.MachineCustomization {
    class PrimaryRelationshipLookupEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, any> {
        constructor(container: JQuery, opt: Serenity.LookupEditorOptions);
        protected getLookupKey(): string;
        protected getItems(lookup: Q.Lookup<any>): any;
    }
}
declare namespace CVC.MachineCustomization {
    class RealtimeParameterDisplayDialog extends Serenity.EntityDialog<RealtimeParameterDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: RealtimeParameterDisplayForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class RealtimeParameterDisplayGrid extends Common.Bases.GridBase<RealtimeParameterDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof RealtimeParameterDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getSlickOptions(): Slick.GridOptions;
        protected createSlickGrid(): Slick.Grid;
    }
}
declare namespace CVC.MachineCustomization {
    class ScreenViewsDialog extends Serenity.EntityDialog<ScreenViewsRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: ScreenViewsForm;
    }
}
declare namespace CVC.MachineCustomization {
    class ScreenViewsGrid extends Common.Bases.GridBase<ScreenViewsRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ScreenViewsDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getColumns(): Slick.Column[];
        protected getSlickOptions(): Slick.GridOptions;
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
    }
}
declare namespace CVC.MachineCustomization {
    class SecondaryBELookupEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, any> {
        primaryRelationshipId: number;
        includeBE: number;
        constructor(container: JQuery, opt: Serenity.LookupEditorOptions);
        protected getLookupKey(): string;
        protected getItems(lookup: Q.Lookup<any>): any;
    }
}
declare namespace CVC.MachineCustomization {
    class SecondaryEFLookupEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, any> {
        primaryRelationshipId: number;
        secondaryBE: number;
        includeEF: number;
        constructor(container: JQuery, opt: Serenity.LookupEditorOptions);
        protected getLookupKey(): string;
        protected getItems(lookup: Q.Lookup<any>): any;
    }
}
declare namespace CVC.MachineCustomization {
    class SecondaryRelationshipDialog extends Serenity.EntityDialog<SecondaryRelationshipRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: SecondaryRelationshipForm;
        constructor();
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class SecondaryRelationshipGrid extends Common.Bases.GridBase<SecondaryRelationshipRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof SecondaryRelationshipDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected onViewSubmit(): boolean;
    }
}
declare namespace CVC.MachineCustomization {
    class TreeDisplayDialog extends Serenity.EntityDialog<TreeDisplayRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: TreeDisplayForm;
        protected afterLoadEntity(): void;
    }
}
declare namespace CVC.MachineCustomization {
    class TreeDisplayGrid extends Common.Bases.GridBase<TreeDisplayRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof TreeDisplayDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
