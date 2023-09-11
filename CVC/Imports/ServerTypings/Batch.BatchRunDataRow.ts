namespace CVC.Batch {
    export interface BatchRunDataRow {
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

    export namespace BatchRunDataRow {
        export const idProperty = 'BatchRunDataId';
        export const nameProperty = 'IpcParameterValue';
        export const localTextPrefix = 'Batch.BatchRunData';
        export const deletePermission = '';
        export const insertPermission = '';
        export const readPermission = '';
        export const updatePermission = '';

        export declare const enum Fields {
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

