namespace CVC.MachineCustomization {
    export interface MachineParameterRow {
        MachineParameterId?: number;
        MachineId?: number;
        IsRealTime?: boolean;
        ColumnName?: string;
        PickListId?: number;
        PickListName?: string;
        ParameterName?: string;
        PlcAddress?: string;
        Description?: string;
        DataTypeId?: number;
        IsRangeUnlimited?: boolean;
        IsResetOnBatchCreate?: boolean;
        IsBatchStartRequired?: boolean;
        AllowDecimalPoint?: boolean;
        IsLabelRoll?: boolean;
        IsStopOnBatchStop?: boolean;
        Min?: number;
        Max?: number;
        IsUseUnit?: boolean;
        UnitId?: number;
        StatusId?: number;
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
        StatusStatusName?: string;
        DataTypeName?: string;
        UnitPickListValueName?: string;
        MachineMachineName?: string;
        Type?: number;
        ReadMachineParameterId?: number;
        ReloadMachineParameterId?: number;
        IsRead?: boolean;
        IsWrite?: boolean;
        RowId?: number;
        IsBitWise?: boolean;
        BitWiseIndex?: number;
        QueryTypeRowId?: number;
        OperationType?: number;
        OperationValue?: number;
        Is32Bit?: boolean;
        Bit32RowId?: number;
        IsStopAt?: boolean;
        IsShowAsMessage?: boolean;
        DisableParameterId?: number;
        DisableParameterValue?: string;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace MachineParameterRow {
        export const idProperty = 'MachineParameterId';
        export const nameProperty = 'ParameterName';
        export const localTextPrefix = 'MachineCustomization.MachineParameter';
        export const lookupKey = 'MachineCustomization.MachineParameter';

        export function getLookup(): Q.Lookup<MachineParameterRow> {
            return Q.getLookup<MachineParameterRow>('MachineCustomization.MachineParameter');
        }
        export const deletePermission = 'MachineCustomization:MachineParameter:Modify';
        export const insertPermission = 'MachineCustomization:MachineParameter:Modify';
        export const readPermission = 'MachineCustomization:MachineParameter:Read';
        export const updatePermission = 'MachineCustomization:MachineParameter:Modify';

        export declare const enum Fields {
            MachineParameterId = "MachineParameterId",
            MachineId = "MachineId",
            IsRealTime = "IsRealTime",
            ColumnName = "ColumnName",
            PickListId = "PickListId",
            PickListName = "PickListName",
            ParameterName = "ParameterName",
            PlcAddress = "PlcAddress",
            Description = "Description",
            DataTypeId = "DataTypeId",
            IsRangeUnlimited = "IsRangeUnlimited",
            IsResetOnBatchCreate = "IsResetOnBatchCreate",
            IsBatchStartRequired = "IsBatchStartRequired",
            AllowDecimalPoint = "AllowDecimalPoint",
            IsLabelRoll = "IsLabelRoll",
            IsStopOnBatchStop = "IsStopOnBatchStop",
            Min = "Min",
            Max = "Max",
            IsUseUnit = "IsUseUnit",
            UnitId = "UnitId",
            StatusId = "StatusId",
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
            StatusStatusName = "StatusStatusName",
            DataTypeName = "DataTypeName",
            UnitPickListValueName = "UnitPickListValueName",
            MachineMachineName = "MachineMachineName",
            Type = "Type",
            ReadMachineParameterId = "ReadMachineParameterId",
            ReloadMachineParameterId = "ReloadMachineParameterId",
            IsRead = "IsRead",
            IsWrite = "IsWrite",
            RowId = "RowId",
            IsBitWise = "IsBitWise",
            BitWiseIndex = "BitWiseIndex",
            QueryTypeRowId = "QueryTypeRowId",
            OperationType = "OperationType",
            OperationValue = "OperationValue",
            Is32Bit = "Is32Bit",
            Bit32RowId = "Bit32RowId",
            IsStopAt = "IsStopAt",
            IsShowAsMessage = "IsShowAsMessage",
            DisableParameterId = "DisableParameterId",
            DisableParameterValue = "DisableParameterValue",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

