namespace CVC.MachineCustomization {
    export interface ScreenViewsRow {
        ScreenViewId?: number;
        ScreenViewName?: string;
        PrimaryRelationshipId?: number;
        IsNoBer?: boolean;
        StatusId?: number;
        CreatedByUsername?: string;
        UpdatedByUsername?: string;
        PrimaryRelationshipRelationshipName?: string;
        PrimaryRelationshipPrimaryBe?: number;
        PrimaryRelationshipDescription?: string;
        PrimaryRelationshipStatus?: number;
        PrimaryRelationshipCreatedBy?: number;
        PrimaryRelationshipCreatedDate?: string;
        PrimaryRelationshipUpdatedBy?: number;
        PrimaryRelationshipUpdatedDate?: string;
        PrimaryRelationshipPrimaryEf?: number;
        StatusStatusName?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace ScreenViewsRow {
        export const idProperty = 'ScreenViewId';
        export const nameProperty = 'ScreenViewName';
        export const localTextPrefix = 'MachineCustomization.ScreenViews';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ScreenViewId = "ScreenViewId",
            ScreenViewName = "ScreenViewName",
            PrimaryRelationshipId = "PrimaryRelationshipId",
            IsNoBer = "IsNoBer",
            StatusId = "StatusId",
            CreatedByUsername = "CreatedByUsername",
            UpdatedByUsername = "UpdatedByUsername",
            PrimaryRelationshipRelationshipName = "PrimaryRelationshipRelationshipName",
            PrimaryRelationshipPrimaryBe = "PrimaryRelationshipPrimaryBe",
            PrimaryRelationshipDescription = "PrimaryRelationshipDescription",
            PrimaryRelationshipStatus = "PrimaryRelationshipStatus",
            PrimaryRelationshipCreatedBy = "PrimaryRelationshipCreatedBy",
            PrimaryRelationshipCreatedDate = "PrimaryRelationshipCreatedDate",
            PrimaryRelationshipUpdatedBy = "PrimaryRelationshipUpdatedBy",
            PrimaryRelationshipUpdatedDate = "PrimaryRelationshipUpdatedDate",
            PrimaryRelationshipPrimaryEf = "PrimaryRelationshipPrimaryEf",
            StatusStatusName = "StatusStatusName",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

