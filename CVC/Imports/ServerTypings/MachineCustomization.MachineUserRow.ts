namespace CVC.MachineCustomization {
    export interface MachineUserRow {
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

    export namespace MachineUserRow {
        export const idProperty = 'MachineUserId';
        export const localTextPrefix = 'MachineCustomization.MachineUser';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
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

