namespace CVC.Administration {
    export interface UserRow {
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

    export namespace UserRow {
        export const idProperty = 'UserId';
        export const isActiveProperty = 'StatusId';
        export const nameProperty = 'Username';
        export const localTextPrefix = 'Administration.User';
        export const lookupKey = 'Administration.User';

        export function getLookup(): Q.Lookup<UserRow> {
            return Q.getLookup<UserRow>('Administration.User');
        }
        export const deletePermission = 'Administration:User:Modify';
        export const insertPermission = 'Administration:User:Modify';
        export const readPermission = 'Administration:User:Read';
        export const updatePermission = 'Administration:User:Modify';

        export declare const enum Fields {
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

