namespace CVC.MachineCustomization {
    export interface MachineParameterForm {
        ParameterName: Serenity.StringEditor;
        MachineId: Serenity.LookupEditor;
        Description: Serenity.StringEditor;
        IsRangeUnlimited: Serenity.BooleanEditor;
        Min: Serenity.DecimalEditor;
        Max: Serenity.DecimalEditor;
        AllowDecimalPoint: Serenity.BooleanEditor;
        IsRead: Serenity.BooleanEditor;
        IsWrite: Serenity.BooleanEditor;
        DataTypeId: Serenity.LookupEditor;
        IsUseUnit: Serenity.BooleanEditor;
        UnitId: Serenity.LookupEditor;
        ColumnName: Serenity.StringEditor;
        PickListId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
        Type: Serenity.LookupEditor;
        RowId: Serenity.IntegerEditor;
        ReadMachineParameterId: Serenity.LookupEditor;
        QueryTypeRowId: Serenity.IntegerEditor;
        IsStopAt: Serenity.BooleanEditor;
        IsBitWise: Serenity.BooleanEditor;
        BitWiseIndex: Serenity.IntegerEditor;
        OperationType: Serenity.LookupEditor;
        OperationValue: Serenity.DecimalEditor;
        Is32Bit: Serenity.BooleanEditor;
        Bit32RowId: Serenity.IntegerEditor;
        ReloadMachineParameterId: Serenity.LookupEditor;
        IsShowAsMessage: Serenity.BooleanEditor;
        IsResetOnBatchCreate: Serenity.BooleanEditor;
        IsBatchStartRequired: Serenity.BooleanEditor;
        IsLabelRoll: Serenity.BooleanEditor;
        DisableParameterId: Serenity.LookupEditor;
        DisableParameterValue: Serenity.StringEditor;
        IsStopOnBatchStop: Serenity.BooleanEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class MachineParameterForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineParameter';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineParameterForm.init)  {
                MachineParameterForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.BooleanEditor;
                var w3 = s.DecimalEditor;
                var w4 = s.IntegerEditor;
                var w5 = s.DateEditor;

                Q.initFormType(MachineParameterForm, [
                    'ParameterName', w0,
                    'MachineId', w1,
                    'Description', w0,
                    'IsRangeUnlimited', w2,
                    'Min', w3,
                    'Max', w3,
                    'AllowDecimalPoint', w2,
                    'IsRead', w2,
                    'IsWrite', w2,
                    'DataTypeId', w1,
                    'IsUseUnit', w2,
                    'UnitId', w1,
                    'ColumnName', w0,
                    'PickListId', w1,
                    'StatusId', w1,
                    'Type', w1,
                    'RowId', w4,
                    'ReadMachineParameterId', w1,
                    'QueryTypeRowId', w4,
                    'IsStopAt', w2,
                    'IsBitWise', w2,
                    'BitWiseIndex', w4,
                    'OperationType', w1,
                    'OperationValue', w3,
                    'Is32Bit', w2,
                    'Bit32RowId', w4,
                    'ReloadMachineParameterId', w1,
                    'IsShowAsMessage', w2,
                    'IsResetOnBatchCreate', w2,
                    'IsBatchStartRequired', w2,
                    'IsLabelRoll', w2,
                    'DisableParameterId', w1,
                    'DisableParameterValue', w0,
                    'IsStopOnBatchStop', w2,
                    'CreatedBy', w4,
                    'CreatedDate', w5,
                    'UpdatedBy', w4,
                    'UpdatedDate', w5
                ]);
            }
        }
    }
}

