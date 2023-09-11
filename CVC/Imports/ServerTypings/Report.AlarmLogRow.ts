namespace CVC.Report {
    export interface AlarmLogRow {
        AlarmLogId?: number;
        MachineId?: number;
        AlarmId?: number;
        BatchId?: number;
        LoggedUserId?: number;
        Comment?: string;
        Description?: string;
        AlarmDateTime?: string;
        PcipAddress?: string;
        BatchBatchName?: string;
        AlarmAlarmName?: string;
        MachineMachineName?: string;
    }

    export namespace AlarmLogRow {
        export const idProperty = 'AlarmLogId';
        export const nameProperty = 'Comment';
        export const localTextPrefix = 'Report.AlarmLog';
        export const deletePermission = 'Report:AlarmLog:Read';
        export const insertPermission = 'Report:AlarmLog:Read';
        export const readPermission = 'Report:AlarmLog:Read';
        export const updatePermission = 'Report:AlarmLog:Read';

        export declare const enum Fields {
            AlarmLogId = "AlarmLogId",
            MachineId = "MachineId",
            AlarmId = "AlarmId",
            BatchId = "BatchId",
            LoggedUserId = "LoggedUserId",
            Comment = "Comment",
            Description = "Description",
            AlarmDateTime = "AlarmDateTime",
            PcipAddress = "PcipAddress",
            BatchBatchName = "BatchBatchName",
            AlarmAlarmName = "AlarmAlarmName",
            MachineMachineName = "MachineMachineName"
        }
    }
}

