namespace CVC.Report {
    export interface BatchLogRow {
        BatchLogId?: number;
        MachineId?: number;
        BatchId?: number;
        Description?: string;
        UserId?: number;
        UpdatedDateTime?: string;
    }

    export namespace BatchLogRow {
        export const idProperty = 'BatchLogId';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Report.BatchLog';
        export const deletePermission = 'Report:BatchLog:Read';
        export const insertPermission = 'Report:BatchLog:Read';
        export const readPermission = 'Report:BatchLog:Read';
        export const updatePermission = 'Report:BatchLog:Read';

        export declare const enum Fields {
            BatchLogId = "BatchLogId",
            MachineId = "MachineId",
            BatchId = "BatchId",
            Description = "Description",
            UserId = "UserId",
            UpdatedDateTime = "UpdatedDateTime"
        }
    }
}

