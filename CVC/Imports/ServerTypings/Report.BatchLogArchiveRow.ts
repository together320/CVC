namespace CVC.Report {
    export interface BatchLogArchiveRow {
        BatchLogArchiveId?: number;
        MachineId?: number;
        BatchId?: number;
        Description?: string;
        UserId?: number;
        UpdatedDateTime?: string;
    }

    export namespace BatchLogArchiveRow {
        export const idProperty = 'BatchLogArchiveId';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Report.BatchLogArchive';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            BatchLogArchiveId = "BatchLogArchiveId",
            MachineId = "MachineId",
            BatchId = "BatchId",
            Description = "Description",
            UserId = "UserId",
            UpdatedDateTime = "UpdatedDateTime"
        }
    }
}

