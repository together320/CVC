namespace CVC.MachineCustomization {
    export interface SecondaryRelationshipRow {
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

    export namespace SecondaryRelationshipRow {
        export const idProperty = 'SecondaryRelationshipId';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'MachineCustomization.SecondaryRelationship';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
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

