namespace CVC.Batch {
    export interface BatchRecipeModifyRow {
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

    export namespace BatchRecipeModifyRow {
        export const idProperty = 'BatchRecipeModifyId';
        export const nameProperty = 'OldValue';
        export const localTextPrefix = 'Batch.BatchRecipeModify';
        export const deletePermission = '';
        export const insertPermission = '';
        export const readPermission = '';
        export const updatePermission = '';

        export declare const enum Fields {
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

