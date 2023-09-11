namespace CVC.PackSettings {
    export interface TabletDetailsRow {
        TabletDetailsId?: number;
        TabletName?: string;
        TabletStrength?: string;
        TabletTypeId?: number;
        TabletCharOneId?: number;
        TabletCharTwoId?: number;
        TabletShapeId?: number;
        TabletLength?: string;
        TabletThickness?: string;
        TabletWidth?: string;
        StatusId?: number;
        StatusStatusName?: string;
        TabletTypePickListValueName?: string;
        TabletTypeStatusId?: number;
        TabletCharOnePickListValueName?: string;
        TabletCharOneStatusId?: number;
        TabletCharTwoPickListValueName?: string;
        TabletCharTwoStatusId?: number;
        TabletShapePickListValueName?: string;
        TabletShapeStatusId?: number;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace TabletDetailsRow {
        export const idProperty = 'TabletDetailsId';
        export const nameProperty = 'TabletName';
        export const localTextPrefix = 'PackSettings.TabletDetails';
        export const lookupKey = 'PackSettings.Tablet';

        export function getLookup(): Q.Lookup<TabletDetailsRow> {
            return Q.getLookup<TabletDetailsRow>('PackSettings.Tablet');
        }
        export const deletePermission = 'PackSettings:TabletDetails:Modify';
        export const insertPermission = 'PackSettings:TabletDetails:Modify';
        export const readPermission = 'PackSettings:TabletDetails:Read';
        export const updatePermission = 'PackSettings:TabletDetails:Modify';

        export declare const enum Fields {
            TabletDetailsId = "TabletDetailsId",
            TabletName = "TabletName",
            TabletStrength = "TabletStrength",
            TabletTypeId = "TabletTypeId",
            TabletCharOneId = "TabletCharOneId",
            TabletCharTwoId = "TabletCharTwoId",
            TabletShapeId = "TabletShapeId",
            TabletLength = "TabletLength",
            TabletThickness = "TabletThickness",
            TabletWidth = "TabletWidth",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            TabletTypePickListValueName = "TabletTypePickListValueName",
            TabletTypeStatusId = "TabletTypeStatusId",
            TabletCharOnePickListValueName = "TabletCharOnePickListValueName",
            TabletCharOneStatusId = "TabletCharOneStatusId",
            TabletCharTwoPickListValueName = "TabletCharTwoPickListValueName",
            TabletCharTwoStatusId = "TabletCharTwoStatusId",
            TabletShapePickListValueName = "TabletShapePickListValueName",
            TabletShapeStatusId = "TabletShapeStatusId",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

