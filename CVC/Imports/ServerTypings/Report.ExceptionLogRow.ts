namespace CVC.Report {
    export interface ExceptionLogRow {
        Id?: number;
        ApplicationName?: string;
        Type?: string;
        Url?: string;
        Message?: string;
        CreationDate?: string;
    }

    export namespace ExceptionLogRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Message';
        export const localTextPrefix = 'Report.ExceptionLog';
        export const deletePermission = 'Report:ExceptionLog:Read';
        export const insertPermission = 'Report:ExceptionLog:Read';
        export const readPermission = 'Report:ExceptionLog:Read';
        export const updatePermission = 'Report:ExceptionLog:Read';

        export declare const enum Fields {
            Id = "Id",
            ApplicationName = "ApplicationName",
            Type = "Type",
            Url = "Url",
            Message = "Message",
            CreationDate = "CreationDate"
        }
    }
}

