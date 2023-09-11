namespace CVC.PackSettings {
    export interface BottleRow {
        BottleId?: number;
        BottleName?: string;
        BottleCc?: string;
        ContainerTypeId?: number;
        BottleHeight?: string;
        BottleDiameter?: string;
        BottleMouthOpeningId?: string;
        BottleMouthOpeningOd?: string;
        SupplierId?: number;
        StatusId?: number;
        StatusStatusName?: string;
        CreatedByEmployeeId?: string;
        CreatedByFirstName?: string;
        CreatedByLastName?: string;
        CreatedByDepartmentId?: number;
        CreatedByDesignation?: string;
        CreatedByMobileCode?: number;
        CreatedByMobileNumber?: number;
        CreatedByEmail?: string;
        CreatedByUsername?: string;
        CreatedByPasswordHash?: string;
        CreatedByPasswordSalt?: string;
        CreatedByUserImage?: string;
        CreatedByAddress?: string;
        CreatedByCityId?: number;
        CreatedByPinCode?: string;
        CreatedByRoleId?: number;
        CreatedByPasswordExpiryDate?: string;
        CreatedByIsForgotPassword?: number;
        CreatedByIsPasswordChangeOnLogin?: boolean;
        CreatedByIsUserHidden?: number;
        CreatedByStatusId?: number;
        CreatedBy1?: number;
        CreatedByCreatedDate?: string;
        CreatedByUpdatedBy?: number;
        CreatedByUpdatedDate?: string;
        UpdatedByEmployeeId?: string;
        UpdatedByFirstName?: string;
        UpdatedByLastName?: string;
        UpdatedByDepartmentId?: number;
        UpdatedByDesignation?: string;
        UpdatedByMobileCode?: number;
        UpdatedByMobileNumber?: number;
        UpdatedByEmail?: string;
        UpdatedByUsername?: string;
        UpdatedByPasswordHash?: string;
        UpdatedByPasswordSalt?: string;
        UpdatedByUserImage?: string;
        UpdatedByAddress?: string;
        UpdatedByCityId?: number;
        UpdatedByPinCode?: string;
        UpdatedByRoleId?: number;
        UpdatedByPasswordExpiryDate?: string;
        UpdatedByIsForgotPassword?: number;
        UpdatedByIsPasswordChangeOnLogin?: boolean;
        UpdatedByIsUserHidden?: number;
        UpdatedByStatusId?: number;
        UpdatedByCreatedBy?: number;
        UpdatedByCreatedDate?: string;
        UpdatedBy1?: number;
        UpdatedByUpdatedDate?: string;
        SupplierSupplierName?: string;
        SupplierSupplierAddress?: string;
        SupplierCityId?: number;
        SupplierPinCode?: string;
        SupplierMobileCode?: number;
        SupplierMobileNumber?: number;
        SupplierStatusId?: number;
        SupplierCreatedBy?: number;
        SupplierCreatedDate?: string;
        SupplierUpdatedBy?: number;
        SupplierUpdatedDate?: string;
        ContainerTypePickListId?: number;
        ContainerTypePickListValueName?: string;
        ContainerTypeStatusId?: number;
        ContainerTypeCreatedBy?: number;
        ContainerTypeCreatedDate?: string;
        ContainerTypeUpdatedBy?: number;
        ContainerTypeUpdatedDate?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace BottleRow {
        export const idProperty = 'BottleId';
        export const nameProperty = 'BottleName';
        export const localTextPrefix = 'PackSettings.Bottle';
        export const lookupKey = 'PackSettings.Bottle';

        export function getLookup(): Q.Lookup<BottleRow> {
            return Q.getLookup<BottleRow>('PackSettings.Bottle');
        }
        export const deletePermission = 'PackSettings:Bottle:Modify';
        export const insertPermission = 'PackSettings:Bottle:Modify';
        export const readPermission = 'PackSettings:Bottle:Read';
        export const updatePermission = 'PackSettings:Bottle:Modify';

        export declare const enum Fields {
            BottleId = "BottleId",
            BottleName = "BottleName",
            BottleCc = "BottleCc",
            ContainerTypeId = "ContainerTypeId",
            BottleHeight = "BottleHeight",
            BottleDiameter = "BottleDiameter",
            BottleMouthOpeningId = "BottleMouthOpeningId",
            BottleMouthOpeningOd = "BottleMouthOpeningOd",
            SupplierId = "SupplierId",
            StatusId = "StatusId",
            StatusStatusName = "StatusStatusName",
            CreatedByEmployeeId = "CreatedByEmployeeId",
            CreatedByFirstName = "CreatedByFirstName",
            CreatedByLastName = "CreatedByLastName",
            CreatedByDepartmentId = "CreatedByDepartmentId",
            CreatedByDesignation = "CreatedByDesignation",
            CreatedByMobileCode = "CreatedByMobileCode",
            CreatedByMobileNumber = "CreatedByMobileNumber",
            CreatedByEmail = "CreatedByEmail",
            CreatedByUsername = "CreatedByUsername",
            CreatedByPasswordHash = "CreatedByPasswordHash",
            CreatedByPasswordSalt = "CreatedByPasswordSalt",
            CreatedByUserImage = "CreatedByUserImage",
            CreatedByAddress = "CreatedByAddress",
            CreatedByCityId = "CreatedByCityId",
            CreatedByPinCode = "CreatedByPinCode",
            CreatedByRoleId = "CreatedByRoleId",
            CreatedByPasswordExpiryDate = "CreatedByPasswordExpiryDate",
            CreatedByIsForgotPassword = "CreatedByIsForgotPassword",
            CreatedByIsPasswordChangeOnLogin = "CreatedByIsPasswordChangeOnLogin",
            CreatedByIsUserHidden = "CreatedByIsUserHidden",
            CreatedByStatusId = "CreatedByStatusId",
            CreatedBy1 = "CreatedBy1",
            CreatedByCreatedDate = "CreatedByCreatedDate",
            CreatedByUpdatedBy = "CreatedByUpdatedBy",
            CreatedByUpdatedDate = "CreatedByUpdatedDate",
            UpdatedByEmployeeId = "UpdatedByEmployeeId",
            UpdatedByFirstName = "UpdatedByFirstName",
            UpdatedByLastName = "UpdatedByLastName",
            UpdatedByDepartmentId = "UpdatedByDepartmentId",
            UpdatedByDesignation = "UpdatedByDesignation",
            UpdatedByMobileCode = "UpdatedByMobileCode",
            UpdatedByMobileNumber = "UpdatedByMobileNumber",
            UpdatedByEmail = "UpdatedByEmail",
            UpdatedByUsername = "UpdatedByUsername",
            UpdatedByPasswordHash = "UpdatedByPasswordHash",
            UpdatedByPasswordSalt = "UpdatedByPasswordSalt",
            UpdatedByUserImage = "UpdatedByUserImage",
            UpdatedByAddress = "UpdatedByAddress",
            UpdatedByCityId = "UpdatedByCityId",
            UpdatedByPinCode = "UpdatedByPinCode",
            UpdatedByRoleId = "UpdatedByRoleId",
            UpdatedByPasswordExpiryDate = "UpdatedByPasswordExpiryDate",
            UpdatedByIsForgotPassword = "UpdatedByIsForgotPassword",
            UpdatedByIsPasswordChangeOnLogin = "UpdatedByIsPasswordChangeOnLogin",
            UpdatedByIsUserHidden = "UpdatedByIsUserHidden",
            UpdatedByStatusId = "UpdatedByStatusId",
            UpdatedByCreatedBy = "UpdatedByCreatedBy",
            UpdatedByCreatedDate = "UpdatedByCreatedDate",
            UpdatedBy1 = "UpdatedBy1",
            UpdatedByUpdatedDate = "UpdatedByUpdatedDate",
            SupplierSupplierName = "SupplierSupplierName",
            SupplierSupplierAddress = "SupplierSupplierAddress",
            SupplierCityId = "SupplierCityId",
            SupplierPinCode = "SupplierPinCode",
            SupplierMobileCode = "SupplierMobileCode",
            SupplierMobileNumber = "SupplierMobileNumber",
            SupplierStatusId = "SupplierStatusId",
            SupplierCreatedBy = "SupplierCreatedBy",
            SupplierCreatedDate = "SupplierCreatedDate",
            SupplierUpdatedBy = "SupplierUpdatedBy",
            SupplierUpdatedDate = "SupplierUpdatedDate",
            ContainerTypePickListId = "ContainerTypePickListId",
            ContainerTypePickListValueName = "ContainerTypePickListValueName",
            ContainerTypeStatusId = "ContainerTypeStatusId",
            ContainerTypeCreatedBy = "ContainerTypeCreatedBy",
            ContainerTypeCreatedDate = "ContainerTypeCreatedDate",
            ContainerTypeUpdatedBy = "ContainerTypeUpdatedBy",
            ContainerTypeUpdatedDate = "ContainerTypeUpdatedDate",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

