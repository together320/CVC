namespace CVC.Batch {
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
        export const localTextPrefix = 'Batch.BatchLog';
        export const deletePermission = '';
        export const insertPermission = '';
        export const readPermission = '';
        export const updatePermission = '';

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

