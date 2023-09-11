namespace CVC.Report {
    export interface AuditLogArchiveRow {
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

    export namespace AuditLogArchiveRow {
        export const idProperty = 'AuditLogArchiveId';
        export const nameProperty = 'UserName';
        export const localTextPrefix = 'Report.AuditLogArchive';
        export const deletePermission = 'Report:AuditLogArchive:Read';
        export const insertPermission = 'Report:AuditLogArchive:Read';
        export const readPermission = 'Report:AuditLogArchive:Read';
        export const updatePermission = 'Report:AuditLogArchive:Read';

        export declare const enum Fields {
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

