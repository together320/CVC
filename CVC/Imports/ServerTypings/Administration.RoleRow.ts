namespace CVC.Administration {
    export interface RoleRow {
        RoleId?: number;
        RoleName?: string;
        StatusId?: number;
        StatusStatusName?: string;
        IsHidden?: boolean;
        ParentRoleId?: number;
        RolesRoleName?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace RoleRow {
        export const idProperty = 'RoleId';
        export const nameProperty = 'RoleName';
        export const localTextPrefix = 'Administration.Role';
        export const lookupKey = 'Role';

        export function getLookup(): Q.Lookup<RoleRow> {
            return Q.getLookup<RoleRow>('Role');
        }
        export const deletePermission = 'Administration:Role:Modify';
        export const insertPermission = 'Administration:Role:Modify';
        export const readPermission = 'Administration:Role:Read';
        export const updatePermission = 'Administration:Role:Modify';

        export declare const enum Fields {
            RoleId = "RoleId",
            RoleName = "RoleName",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            IsHidden = "IsHidden",
            ParentRoleId = "ParentRoleId",
            RolesRoleName = "RolesRoleName",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

