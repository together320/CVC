namespace CVC.Report {
    export interface UserLogRow {
        UserLogId?: number;
        UserId?: number;
        UserName?: string;
        Action?: string;
        ChangedOn?: string;
    }

    export namespace UserLogRow {
        export const idProperty = 'UserLogId';
        export const nameProperty = 'UserName';
        export const localTextPrefix = 'Report.UserLog';
        export const deletePermission = 'Report:UserLog:Read';
        export const insertPermission = 'Report:UserLog:Read';
        export const readPermission = 'Report:UserLog:Read';
        export const updatePermission = 'Report:UserLog:Read';

        export declare const enum Fields {
            UserLogId = "UserLogId",
            UserId = "UserId",
            UserName = "UserName",
            Action = "Action",
            ChangedOn = "ChangedOn"
        }
    }
}

