namespace CVC.PackSettings {
    export interface CottonRow {
        CottonId?: number;
        CottonName?: string;
        CottonTypeId?: number;
        GmOrYard?: string;
        SupplierId?: number;
        StatusId?: number;
        CottonStatusName?: string;
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
        CottonTypePickListId?: number;
        CottonTypePickListValueName?: string;
        CottonTypeStatusId?: number;
        CottonTypeCreatedBy?: number;
        CottonTypeCreatedDate?: string;
        CottonTypeUpdatedBy?: number;
        CottonTypeUpdatedDate?: string;
        StatusStatusName?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace CottonRow {
        export const idProperty = 'CottonId';
        export const nameProperty = 'CottonName';
        export const localTextPrefix = 'PackSettings.Cotton';
        export const lookupKey = 'PackSettings.Cotton';

        export function getLookup(): Q.Lookup<CottonRow> {
            return Q.getLookup<CottonRow>('PackSettings.Cotton');
        }
        export const deletePermission = 'PackSettings:Cotton:Modify';
        export const insertPermission = 'PackSettings:Cotton:Modify';
        export const readPermission = 'PackSettings:Cotton:Read';
        export const updatePermission = 'PackSettings:Cotton:Modify';

        export declare const enum Fields {
            CottonId = "CottonId",
            CottonName = "CottonName",
            CottonTypeId = "CottonTypeId",
            GmOrYard = "GmOrYard",
            SupplierId = "SupplierId",
            StatusId = "StatusId",
            CottonStatusName = "CottonStatusName",
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
            CottonTypePickListId = "CottonTypePickListId",
            CottonTypePickListValueName = "CottonTypePickListValueName",
            CottonTypeStatusId = "CottonTypeStatusId",
            CottonTypeCreatedBy = "CottonTypeCreatedBy",
            CottonTypeCreatedDate = "CottonTypeCreatedDate",
            CottonTypeUpdatedBy = "CottonTypeUpdatedBy",
            CottonTypeUpdatedDate = "CottonTypeUpdatedDate",
            StatusStatusName = "StatusStatusName",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

