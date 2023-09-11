namespace CVC.Modules.Configuration.Status {
    export interface Class1Row {
        AttributeId?: number;
        Name?: string;
    }

    export namespace Class1Row {
        export const idProperty = 'AttributeId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Configuration.Status1';
        export const lookupKey = 'Configuration.Status1';

        export function getLookup(): Q.Lookup<Class1Row> {
            return Q.getLookup<Class1Row>('Configuration.Status1');
        }
        export const deletePermission = 'Lookup';
        export const insertPermission = 'Lookup';
        export const readPermission = 'Lookup';
        export const updatePermission = 'Lookup';

        export declare const enum Fields {
            AttributeId = "AttributeId",
            Name = "Name"
        }
    }
}

