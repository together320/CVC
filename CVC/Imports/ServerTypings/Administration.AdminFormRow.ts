namespace CVC.Administration {
    export interface AdminFormRow {
        AdminFormId?: number;
        FormName?: string;
    }

    export namespace AdminFormRow {
        export const idProperty = 'AdminFormId';
        export const nameProperty = 'FormName';
        export const localTextPrefix = 'Administration.AdminForm';
        export const deletePermission = '';
        export const insertPermission = '';
        export const readPermission = '';
        export const updatePermission = '';

        export declare const enum Fields {
            AdminFormId = "AdminFormId",
            FormName = "FormName"
        }
    }
}

