namespace CVC.Modules.Configuration.EnvironmentVariables {
    export interface HourFormatTypeLookUp {
        HourFormatTypeID?: number;
        HourFormatTypeValue?: string;
    }

    export namespace HourFormatTypeLookUp {
        export const idProperty = 'HourFormatTypeID';
        export const nameProperty = 'HourFormatTypeValue';
        export const localTextPrefix = 'Configuration.HourFormatTypeLookUp';
        export const lookupKey = 'Configuration.HourFormatType';

        export function getLookup(): Q.Lookup<HourFormatTypeLookUp> {
            return Q.getLookup<HourFormatTypeLookUp>('Configuration.HourFormatType');
        }
        export const deletePermission = 'Lookup';
        export const insertPermission = 'Lookup';
        export const readPermission = 'Lookup';
        export const updatePermission = 'Lookup';

        export declare const enum Fields {
            HourFormatTypeID = "HourFormatTypeID",
            HourFormatTypeValue = "HourFormatTypeValue"
        }
    }
}

