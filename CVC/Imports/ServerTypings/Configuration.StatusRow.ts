namespace CVC.Configuration {
    export interface StatusRow {
        StatusId?: number;
        StatusName?: string;
    }

    export namespace StatusRow {
        export const idProperty = 'StatusId';
        export const nameProperty = 'StatusName';
        export const localTextPrefix = 'Configuration.Status';
        export const lookupKey = 'Configuration.Status';

        export function getLookup(): Q.Lookup<StatusRow> {
            return Q.getLookup<StatusRow>('Configuration.Status');
        }
        export const deletePermission = 'Lookup';
        export const insertPermission = 'Lookup';
        export const readPermission = 'Lookup';
        export const updatePermission = 'Lookup';

        export declare const enum Fields {
            StatusId = "StatusId",
            StatusName = "StatusName"
        }
    }
}

