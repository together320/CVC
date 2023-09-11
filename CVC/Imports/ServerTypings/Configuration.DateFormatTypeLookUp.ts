namespace CVC.Configuration {
    export interface DateFormatTypeLookUp {
        DateFormatTypeID?: number;
        DateFormatTypeValue?: string;
    }

    export namespace DateFormatTypeLookUp {
        export const idProperty = 'DateFormatTypeID';
        export const nameProperty = 'DateFormatTypeValue';
        export const localTextPrefix = 'Configuration.DateFormatTypeLookUp';
        export const lookupKey = 'Configuration.DateFormatType';

        export function getLookup(): Q.Lookup<DateFormatTypeLookUp> {
            return Q.getLookup<DateFormatTypeLookUp>('Configuration.DateFormatType');
        }
        export const deletePermission = 'Lookup';
        export const insertPermission = 'Lookup';
        export const readPermission = 'Lookup';
        export const updatePermission = 'Lookup';

        export declare const enum Fields {
            DateFormatTypeID = "DateFormatTypeID",
            DateFormatTypeValue = "DateFormatTypeValue"
        }
    }
}

