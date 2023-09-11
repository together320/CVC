namespace CVC.Report {
    export interface AlarmLogArchiveRow {
        AlarmLogArchiveId?: number;
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

    export namespace AlarmLogArchiveRow {
        export const idProperty = 'AlarmLogArchiveId';
        export const nameProperty = 'Comment';
        export const localTextPrefix = 'Report.AlarmLogArchive';
        export const deletePermission = 'Report:AlarmLogArchive:Read';
        export const insertPermission = 'Report:AlarmLogArchive:Read';
        export const readPermission = 'Report:AlarmLogArchive:Read';
        export const updatePermission = 'Report:AlarmLogArchive:Read';

        export declare const enum Fields {
            AlarmLogArchiveId = "AlarmLogArchiveId",
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

