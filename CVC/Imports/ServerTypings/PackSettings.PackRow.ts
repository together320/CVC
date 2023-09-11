namespace CVC.PackSettings {
    export interface PackRow {
        PackId?: number;
        PackName?: string;
        TabletId?: number;
        TabletCount?: number;
        BottleId?: number;
        CapId?: number;
        CottonId?: number;
        CottonLength?: string;
        NumberOfCottonPieces?: number;
        DesiccantId?: number;
        NumberOfDesicantPieces?: number;
        OutsertId?: number;
        LabelId?: number;
        StatusId?: number;
        EndOfLineId?: number;
        LabelLabelName?: string;
        LabelLabelLength?: string;
        LabelLabelHeight?: string;
        LabelLabelType?: string;
        LabelLabelImage?: string;
        LabelSupplierId?: number;
        LabelStatusId?: number;
        LabelCreatedBy?: number;
        LabelCreatedDate?: string;
        LabelUpdatedBy?: number;
        LabelUpdatedDate?: string;
        StatusStatusName?: string;
        EndOfLineEndOfLineName?: string;
        EndOfLineCartonLength?: string;
        EndOfLineCartonHeight?: string;
        EndOfLineCartonWidth?: string;
        EndOfLineCartonType?: string;
        EndOfLineBottleConfiguration?: string;
        EndOfLineMedicationLength?: string;
        EndOfLineMedicationWidth?: string;
        EndOfLineNoOfMedication?: string;
        EndOfLineInnerShipperBoxType?: string;
        EndOfLineInnerShipperBoxLength?: string;
        EndOfLineInnerShipperBoxWidth?: string;
        EndOfLineInnerShipperBoxHeight?: string;
        EndOfLineOuterShipperBoxLength?: string;
        EndOfLineOuterShipperBoxWidth?: string;
        EndOfLineOuterShipperBoxHeight?: string;
        EndOfLineInnerShipperMatrix?: string;
        EndOfLineOuterShipperQuantity?: string;
        EndOfLineStatusId?: number;
        EndOfLineCreatedBy?: number;
        EndOfLineCreatedDate?: string;
        EndOfLineUpdatedBy?: number;
        EndOfLineUpdatedDate?: string;
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
        TabletName?: string;
        BottleName?: string;
        CapName?: string;
        CottonName?: string;
        DesiccantName?: string;
        OutsertName?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace PackRow {
        export const idProperty = 'PackId';
        export const nameProperty = 'PackName';
        export const localTextPrefix = 'PackSettings.Pack';
        export const lookupKey = 'PackSettings.Pack';

        export function getLookup(): Q.Lookup<PackRow> {
            return Q.getLookup<PackRow>('PackSettings.Pack');
        }
        export const deletePermission = 'PackSettings:Pack:Modify';
        export const insertPermission = 'PackSettings:Pack:Modify';
        export const readPermission = 'PackSettings:Pack:Read';
        export const updatePermission = 'PackSettings:Pack:Modify';

        export declare const enum Fields {
            PackId = "PackId",
            PackName = "PackName",
            TabletId = "TabletId",
            TabletCount = "TabletCount",
            BottleId = "BottleId",
            CapId = "CapId",
            CottonId = "CottonId",
            CottonLength = "CottonLength",
            NumberOfCottonPieces = "NumberOfCottonPieces",
            DesiccantId = "DesiccantId",
            NumberOfDesicantPieces = "NumberOfDesicantPieces",
            OutsertId = "OutsertId",
            LabelId = "LabelId",
            StatusId = "StatusId",
            EndOfLineId = "EndOfLineId",
            LabelLabelName = "LabelLabelName",
            LabelLabelLength = "LabelLabelLength",
            LabelLabelHeight = "LabelLabelHeight",
            LabelLabelType = "LabelLabelType",
            LabelLabelImage = "LabelLabelImage",
            LabelSupplierId = "LabelSupplierId",
            LabelStatusId = "LabelStatusId",
            LabelCreatedBy = "LabelCreatedBy",
            LabelCreatedDate = "LabelCreatedDate",
            LabelUpdatedBy = "LabelUpdatedBy",
            LabelUpdatedDate = "LabelUpdatedDate",
            StatusStatusName = "StatusStatusName",
            EndOfLineEndOfLineName = "EndOfLineEndOfLineName",
            EndOfLineCartonLength = "EndOfLineCartonLength",
            EndOfLineCartonHeight = "EndOfLineCartonHeight",
            EndOfLineCartonWidth = "EndOfLineCartonWidth",
            EndOfLineCartonType = "EndOfLineCartonType",
            EndOfLineBottleConfiguration = "EndOfLineBottleConfiguration",
            EndOfLineMedicationLength = "EndOfLineMedicationLength",
            EndOfLineMedicationWidth = "EndOfLineMedicationWidth",
            EndOfLineNoOfMedication = "EndOfLineNoOfMedication",
            EndOfLineInnerShipperBoxType = "EndOfLineInnerShipperBoxType",
            EndOfLineInnerShipperBoxLength = "EndOfLineInnerShipperBoxLength",
            EndOfLineInnerShipperBoxWidth = "EndOfLineInnerShipperBoxWidth",
            EndOfLineInnerShipperBoxHeight = "EndOfLineInnerShipperBoxHeight",
            EndOfLineOuterShipperBoxLength = "EndOfLineOuterShipperBoxLength",
            EndOfLineOuterShipperBoxWidth = "EndOfLineOuterShipperBoxWidth",
            EndOfLineOuterShipperBoxHeight = "EndOfLineOuterShipperBoxHeight",
            EndOfLineInnerShipperMatrix = "EndOfLineInnerShipperMatrix",
            EndOfLineOuterShipperQuantity = "EndOfLineOuterShipperQuantity",
            EndOfLineStatusId = "EndOfLineStatusId",
            EndOfLineCreatedBy = "EndOfLineCreatedBy",
            EndOfLineCreatedDate = "EndOfLineCreatedDate",
            EndOfLineUpdatedBy = "EndOfLineUpdatedBy",
            EndOfLineUpdatedDate = "EndOfLineUpdatedDate",
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
            TabletName = "TabletName",
            BottleName = "BottleName",
            CapName = "CapName",
            CottonName = "CottonName",
            DesiccantName = "DesiccantName",
            OutsertName = "OutsertName",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

