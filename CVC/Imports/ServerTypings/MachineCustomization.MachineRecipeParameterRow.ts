namespace CVC.MachineCustomization {
    export interface MachineRecipeParameterRow {
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

    export namespace MachineRecipeParameterRow {
        export const idProperty = 'MachineRecipeParameterId';
        export const nameProperty = 'RecipeParameterValue';
        export const localTextPrefix = 'MachineCustomization.MachineRecipeParameter';
        export const deletePermission = 'MachineCustomization:MachineRecipeParameter:Modify';
        export const insertPermission = 'MachineCustomization:MachineRecipeParameter:Modify';
        export const readPermission = 'MachineCustomization:MachineRecipeParameter:Read';
        export const updatePermission = 'MachineCustomization:MachineRecipeParameter:Modify';

        export declare const enum Fields {
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

