namespace CVC.Report {
    export interface UserLoginDetailsRow {
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

    export namespace UserLoginDetailsRow {
        export const idProperty = 'UserLoginDetailsId';
        export const localTextPrefix = 'Report.UserLoginDetails';
        export const deletePermission = '';
        export const insertPermission = '';
        export const readPermission = '';
        export const updatePermission = '';

        export declare const enum Fields {
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

