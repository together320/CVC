namespace CVC.MachineCustomization {
    export interface PrimaryRelationshipRow {
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

    export namespace PrimaryRelationshipRow {
        export const idProperty = 'PrimaryRelationshipId';
        export const nameProperty = 'RelationshipName';
        export const localTextPrefix = 'MachineCustomization.PrimaryRelationship';
        export const lookupKey = 'MachineCustomization.PrimaryRelationship';

        export function getLookup(): Q.Lookup<PrimaryRelationshipRow> {
            return Q.getLookup<PrimaryRelationshipRow>('MachineCustomization.PrimaryRelationship');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
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

