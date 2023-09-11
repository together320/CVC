namespace CVC.MachineCustomization {
    export interface RecipeSettingsParameterRow {
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

    export namespace RecipeSettingsParameterRow {
        export const idProperty = 'RecipeParameterId';
        export const localTextPrefix = 'MachineCustomization.RecipeSettingsParameter';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
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

