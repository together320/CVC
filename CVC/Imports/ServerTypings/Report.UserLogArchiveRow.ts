namespace CVC.Report {
    export interface UserLogArchiveRow {
        UserLogArchiveId?: number;
        UserId?: number;
        UserName?: string;
        Action?: string;
        ChangedOn?: string;
    }

    export namespace UserLogArchiveRow {
        export const idProperty = 'UserLogArchiveId';
        export const nameProperty = 'UserName';
        export const localTextPrefix = 'Report.UserLogArchive';
        export const deletePermission = 'Report:UserLogArchive:Read';
        export const insertPermission = 'Report:UserLogArchive:Read';
        export const readPermission = 'Report:UserLogArchive:Read';
        export const updatePermission = 'Report:UserLogArchive:Read';

        export declare const enum Fields {
            UserLogArchiveId = "UserLogArchiveId",
            UserId = "UserId",
            UserName = "UserName",
            Action = "Action",
            ChangedOn = "ChangedOn"
        }
    }
}

