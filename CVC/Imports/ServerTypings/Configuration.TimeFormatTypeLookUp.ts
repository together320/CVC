namespace CVC.Configuration {
    export interface TimeFormatTypeLookUp {
        TimeFormatTypeID?: number;
        TimeFormatValue?: string;
    }

    export namespace TimeFormatTypeLookUp {
        export const idProperty = 'TimeFormatTypeID';
        export const nameProperty = 'TimeFormatValue';
        export const localTextPrefix = 'Configuration.TimeFormatTypeLookUp';
        export const lookupKey = 'Configuration.TimeFormatType';

        export function getLookup(): Q.Lookup<TimeFormatTypeLookUp> {
            return Q.getLookup<TimeFormatTypeLookUp>('Configuration.TimeFormatType');
        }
        export const deletePermission = 'Lookup';
        export const insertPermission = 'Lookup';
        export const readPermission = 'Lookup';
        export const updatePermission = 'Lookup';

        export declare const enum Fields {
            TimeFormatTypeID = "TimeFormatTypeID",
            TimeFormatValue = "TimeFormatValue"
        }
    }
}

