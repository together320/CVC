namespace CVC.PackSettings {
    export interface DesiccantRow {
        DesiccantId?: number;
        DesiccantName?: string;
        DesiccantTypeId?: number;
        Grammage?: string;
        LengthOrHeight?: string;
        DiameterOrWidth?: string;
        Identification?: number;
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
        DesiccantTypePickListValueName?: string;
        DesiccantTypeStatusId?: number;
        IdentificationPickListValueName?: string;
        IdentificationStatusId?: number;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace DesiccantRow {
        export const idProperty = 'DesiccantId';
        export const nameProperty = 'DesiccantName';
        export const localTextPrefix = 'PackSettings.Desiccant';
        export const lookupKey = 'PackSettings.Desiccant';

        export function getLookup(): Q.Lookup<DesiccantRow> {
            return Q.getLookup<DesiccantRow>('PackSettings.Desiccant');
        }
        export const deletePermission = 'PackSettings:Desiccant:Modify';
        export const insertPermission = 'PackSettings:Desiccant:Modify';
        export const readPermission = 'PackSettings:Desiccant:Read';
        export const updatePermission = 'PackSettings:Desiccant:Modify';

        export declare const enum Fields {
            DesiccantId = "DesiccantId",
            DesiccantName = "DesiccantName",
            DesiccantTypeId = "DesiccantTypeId",
            Grammage = "Grammage",
            LengthOrHeight = "LengthOrHeight",
            DiameterOrWidth = "DiameterOrWidth",
            Identification = "Identification",
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
            DesiccantTypePickListValueName = "DesiccantTypePickListValueName",
            DesiccantTypeStatusId = "DesiccantTypeStatusId",
            IdentificationPickListValueName = "IdentificationPickListValueName",
            IdentificationStatusId = "IdentificationStatusId",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

