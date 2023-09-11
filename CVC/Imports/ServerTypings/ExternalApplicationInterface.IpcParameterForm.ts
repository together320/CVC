namespace CVC.ExternalApplicationInterface {
    export interface IpcParameterForm {
        MachineId: Serenity.LookupEditor;
        MachineParameterId: Serenity.LookupEditor;
        ProtocolId: Serenity.LookupEditor;
        IpcAddress: Serenity.StringEditor;
        NodeId: Serenity.StringEditor;
        AttributeId: Serenity.LookupEditor;
        IpcParameterName: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
        IsBitWise: Serenity.BooleanEditor;
        BitWiseIndex: Serenity.IntegerEditor;
        Is32Bit: Serenity.BooleanEditor;
        Bit32Address: Serenity.StringEditor;
        IsWordSwap: Serenity.BooleanEditor;
        IsByteSwap: Serenity.BooleanEditor;
        IsStopATIPC: Serenity.BooleanEditor;
        IsShowAsMessageIPC: Serenity.BooleanEditor;
        IsBatchStartRequiredIPC: Serenity.BooleanEditor;
        IsResetOnBatchCreateIPC: Serenity.BooleanEditor;
        IsLabelRollIPC: Serenity.BooleanEditor;
        DisableParameterIdIPC: Serenity.LookupEditor;
        DisableParameterValueIPC: Serenity.StringEditor;
        IsStopOnBatchStopIPC: Serenity.BooleanEditor;
        OperationTypeIPC: Serenity.LookupEditor;
        OperationValueIPC: Serenity.DecimalEditor;
        IsAlarm: Serenity.BooleanEditor;
        IsMachineSpeed: Serenity.BooleanEditor;
        IsRefreshMachineSettings: Serenity.BooleanEditor;
        IsHeartBeat: Serenity.BooleanEditor;
        HeartBeatFailedTime: Serenity.IntegerEditor;
        IsHeartBeatSend: Serenity.BooleanEditor;
        IncrementalNumber: Serenity.IntegerEditor;
        StartNumber: Serenity.IntegerEditor;
        EndNumber: Serenity.IntegerEditor;
        IsWriteToPLC: Serenity.BooleanEditor;
        IsIndicatorParameter: Serenity.BooleanEditor;
        IndicatorParameterId: Serenity.LookupEditor;
        IsGoodBottles: Serenity.BooleanEditor;
        IsRejectBottles: Serenity.BooleanEditor;
        IsBatchSize: Serenity.BooleanEditor;
        IsCounterReset: Serenity.BooleanEditor;
        IsConveyer: Serenity.BooleanEditor;
        IsMissingLabelCounter: Serenity.BooleanEditor;
    }

    export class IpcParameterForm extends Serenity.PrefixedContext {
        static formKey = 'ExternalApplicationInterface.IpcParameter';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!IpcParameterForm.init)  {
                IpcParameterForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.BooleanEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.DecimalEditor;

                Q.initFormType(IpcParameterForm, [
                    'MachineId', w0,
                    'MachineParameterId', w0,
                    'ProtocolId', w0,
                    'IpcAddress', w1,
                    'NodeId', w1,
                    'AttributeId', w0,
                    'IpcParameterName', w1,
                    'StatusId', w0,
                    'IsBitWise', w2,
                    'BitWiseIndex', w3,
                    'Is32Bit', w2,
                    'Bit32Address', w1,
                    'IsWordSwap', w2,
                    'IsByteSwap', w2,
                    'IsStopATIPC', w2,
                    'IsShowAsMessageIPC', w2,
                    'IsBatchStartRequiredIPC', w2,
                    'IsResetOnBatchCreateIPC', w2,
                    'IsLabelRollIPC', w2,
                    'DisableParameterIdIPC', w0,
                    'DisableParameterValueIPC', w1,
                    'IsStopOnBatchStopIPC', w2,
                    'OperationTypeIPC', w0,
                    'OperationValueIPC', w4,
                    'IsAlarm', w2,
                    'IsMachineSpeed', w2,
                    'IsRefreshMachineSettings', w2,
                    'IsHeartBeat', w2,
                    'HeartBeatFailedTime', w3,
                    'IsHeartBeatSend', w2,
                    'IncrementalNumber', w3,
                    'StartNumber', w3,
                    'EndNumber', w3,
                    'IsWriteToPLC', w2,
                    'IsIndicatorParameter', w2,
                    'IndicatorParameterId', w0,
                    'IsGoodBottles', w2,
                    'IsRejectBottles', w2,
                    'IsBatchSize', w2,
                    'IsCounterReset', w2,
                    'IsConveyer', w2,
                    'IsMissingLabelCounter', w2
                ]);
            }
        }
    }
}

