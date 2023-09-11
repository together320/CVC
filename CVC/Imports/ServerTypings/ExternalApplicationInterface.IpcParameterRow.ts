namespace CVC.ExternalApplicationInterface {
    export interface IpcParameterRow {
        IpcParameterId?: number;
        MachineId?: number;
        ProtocolId?: number;
        IpcParameterName?: string;
        MachineParameterId?: number;
        IpcAddress?: string;
        IsChangeInRuntime?: number;
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
        MachineMachineName?: string;
        MachineParameterName?: string;
        IsBitWise?: boolean;
        BitWiseIndex?: number;
        Is32Bit?: boolean;
        IsAlarm?: boolean;
        IsRefreshMachineSettings?: boolean;
        IsMachineSpeed?: boolean;
        Bit32Address?: string;
        IsWordSwap?: boolean;
        IsByteSwap?: boolean;
        IsStopATIPC?: boolean;
        IsShowAsMessageIPC?: boolean;
        IsBatchStartRequiredIPC?: boolean;
        IsResetOnBatchCreateIPC?: boolean;
        IsLabelRollIPC?: boolean;
        DisableParameterIdIPC?: number;
        DisableParameterValueIPC?: string;
        IsStopOnBatchStopIPC?: boolean;
        OperationTypeIPC?: number;
        OperationValueIPC?: number;
        IsHeartBeat?: boolean;
        IsHeartBeatSend?: boolean;
        HeartBeatFailedTime?: number;
        IncrementalNumber?: number;
        StartNumber?: number;
        EndNumber?: number;
        IsWriteToPLC?: boolean;
        IsIndicatorParameter?: boolean;
        IndicatorParameterId?: number;
        IsGoodBottles?: boolean;
        IsRejectBottles?: boolean;
        IsBatchSize?: boolean;
        IsCounterReset?: boolean;
        IsConveyer?: boolean;
        IsMissingLabelCounter?: boolean;
        NodeId?: string;
        AttributeId?: number;
        RecordAddedSource?: string;
        CreatedBy?: number;
        CreatedDate?: string;
        UpdatedBy?: number;
        UpdatedDate?: string;
    }

    export namespace IpcParameterRow {
        export const idProperty = 'IpcParameterId';
        export const nameProperty = 'IpcParameterName';
        export const localTextPrefix = 'ExternalApplicationInterface.IpcParameter';
        export const lookupKey = 'ExternalApplicationInterface.IpcParameter';

        export function getLookup(): Q.Lookup<IpcParameterRow> {
            return Q.getLookup<IpcParameterRow>('ExternalApplicationInterface.IpcParameter');
        }
        export const deletePermission = 'EAI:IPCParameter:Modify';
        export const insertPermission = 'EAI:IPCParameter:Modify';
        export const readPermission = 'EAI:IPCParameter:Read';
        export const updatePermission = 'EAI:IPCParameter:Modify';

        export declare const enum Fields {
            IpcParameterId = "IpcParameterId",
            MachineId = "MachineId",
            ProtocolId = "ProtocolId",
            IpcParameterName = "IpcParameterName",
            MachineParameterId = "MachineParameterId",
            IpcAddress = "IpcAddress",
            IsChangeInRuntime = "IsChangeInRuntime",
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
            MachineMachineName = "MachineMachineName",
            MachineParameterName = "MachineParameterName",
            IsBitWise = "IsBitWise",
            BitWiseIndex = "BitWiseIndex",
            Is32Bit = "Is32Bit",
            IsAlarm = "IsAlarm",
            IsRefreshMachineSettings = "IsRefreshMachineSettings",
            IsMachineSpeed = "IsMachineSpeed",
            Bit32Address = "Bit32Address",
            IsWordSwap = "IsWordSwap",
            IsByteSwap = "IsByteSwap",
            IsStopATIPC = "IsStopATIPC",
            IsShowAsMessageIPC = "IsShowAsMessageIPC",
            IsBatchStartRequiredIPC = "IsBatchStartRequiredIPC",
            IsResetOnBatchCreateIPC = "IsResetOnBatchCreateIPC",
            IsLabelRollIPC = "IsLabelRollIPC",
            DisableParameterIdIPC = "DisableParameterIdIPC",
            DisableParameterValueIPC = "DisableParameterValueIPC",
            IsStopOnBatchStopIPC = "IsStopOnBatchStopIPC",
            OperationTypeIPC = "OperationTypeIPC",
            OperationValueIPC = "OperationValueIPC",
            IsHeartBeat = "IsHeartBeat",
            IsHeartBeatSend = "IsHeartBeatSend",
            HeartBeatFailedTime = "HeartBeatFailedTime",
            IncrementalNumber = "IncrementalNumber",
            StartNumber = "StartNumber",
            EndNumber = "EndNumber",
            IsWriteToPLC = "IsWriteToPLC",
            IsIndicatorParameter = "IsIndicatorParameter",
            IndicatorParameterId = "IndicatorParameterId",
            IsGoodBottles = "IsGoodBottles",
            IsRejectBottles = "IsRejectBottles",
            IsBatchSize = "IsBatchSize",
            IsCounterReset = "IsCounterReset",
            IsConveyer = "IsConveyer",
            IsMissingLabelCounter = "IsMissingLabelCounter",
            NodeId = "NodeId",
            AttributeId = "AttributeId",
            RecordAddedSource = "RecordAddedSource",
            CreatedBy = "CreatedBy",
            CreatedDate = "CreatedDate",
            UpdatedBy = "UpdatedBy",
            UpdatedDate = "UpdatedDate"
        }
    }
}

