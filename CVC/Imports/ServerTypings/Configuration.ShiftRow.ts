namespace CVC.Configuration {
    export interface ShiftRow {
        ShiftId?: number;
        ShiftName?: string;
        StartTime?: string;
        EndTime?: string;
        StatusId?: number;
        StatusStatusName?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace ShiftRow {
        export const idProperty = 'ShiftId';
        export const nameProperty = 'ShiftName';
        export const localTextPrefix = 'Configuration.Shift';
        export const lookupKey = 'Configuration.Shift';

        export function getLookup(): Q.Lookup<ShiftRow> {
            return Q.getLookup<ShiftRow>('Configuration.Shift');
        }
        export const deletePermission = 'Configuration:Shift:Modify';
        export const insertPermission = 'Configuration:Shift:Modify';
        export const readPermission = 'Configuration:Shift:Read';
        export const updatePermission = 'Configuration:Shift:Modify';

        export declare const enum Fields {
            ShiftId = "ShiftId",
            ShiftName = "ShiftName",
            StartTime = "StartTime",
            EndTime = "EndTime",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

