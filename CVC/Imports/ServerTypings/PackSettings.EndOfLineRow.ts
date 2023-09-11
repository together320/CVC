namespace CVC.PackSettings {
    export interface EndOfLineRow {
        EndOfLineId?: number;
        EndOfLineName?: string;
        CartonLength?: string;
        CartonHeight?: string;
        CartonWidth?: string;
        CartonType?: string;
        BottleConfiguration?: string;
        MedicationLength?: string;
        MedicationWidth?: string;
        NoOfMedication?: string;
        InnerShipperBoxType?: string;
        InnerShipperBoxLength?: string;
        InnerShipperBoxWidth?: string;
        InnerShipperBoxHeight?: string;
        OuterShipperBoxLength?: string;
        OuterShipperBoxWidth?: string;
        OuterShipperBoxHeight?: string;
        InnerShipperMatrix?: string;
        OuterShipperQuantity?: string;
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
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace EndOfLineRow {
        export const idProperty = 'EndOfLineId';
        export const nameProperty = 'EndOfLineName';
        export const localTextPrefix = 'PackSettings.EndOfLine';
        export const lookupKey = 'PackSettings.EndOfLine';

        export function getLookup(): Q.Lookup<EndOfLineRow> {
            return Q.getLookup<EndOfLineRow>('PackSettings.EndOfLine');
        }
        export const deletePermission = 'PackSettings:EndOfLine:Modify';
        export const insertPermission = 'PackSettings:EndOfLine:Modify';
        export const readPermission = 'PackSettings:EndOfLine:Read';
        export const updatePermission = 'PackSettings:EndOfLine:Modify';

        export declare const enum Fields {
            EndOfLineId = "EndOfLineId",
            EndOfLineName = "EndOfLineName",
            CartonLength = "CartonLength",
            CartonHeight = "CartonHeight",
            CartonWidth = "CartonWidth",
            CartonType = "CartonType",
            BottleConfiguration = "BottleConfiguration",
            MedicationLength = "MedicationLength",
            MedicationWidth = "MedicationWidth",
            NoOfMedication = "NoOfMedication",
            InnerShipperBoxType = "InnerShipperBoxType",
            InnerShipperBoxLength = "InnerShipperBoxLength",
            InnerShipperBoxWidth = "InnerShipperBoxWidth",
            InnerShipperBoxHeight = "InnerShipperBoxHeight",
            OuterShipperBoxLength = "OuterShipperBoxLength",
            OuterShipperBoxWidth = "OuterShipperBoxWidth",
            OuterShipperBoxHeight = "OuterShipperBoxHeight",
            InnerShipperMatrix = "InnerShipperMatrix",
            OuterShipperQuantity = "OuterShipperQuantity",
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
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

