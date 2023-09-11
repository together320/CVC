namespace CVC.MachineCustomization {
    export interface MachineForm {
        MachineName: Serenity.StringEditor;
        IsRealTime: Serenity.BooleanEditor;
        TableId: Serenity.IntegerEditor;
        TableName: Serenity.StringEditor;
        MachineLineId: Serenity.IntegerEditor;
        AccessIpAddress: Serenity.StringEditor;
        MachineSequence: Serenity.IntegerEditor;
        MachineImage: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        ModelNumber: Serenity.StringEditor;
        SerialNumber: Serenity.StringEditor;
        Make: Serenity.StringEditor;
        Year: Serenity.IntegerEditor;
        TimerForAlarm: Serenity.IntegerEditor;
        PlcMake: Serenity.StringEditor;
        PlcModelNumber: Serenity.StringEditor;
        PlcSerialNumber: Serenity.StringEditor;
        PlcAddress: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class MachineForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.Machine';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineForm.init)  {
                MachineForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.LookupEditor;
                var w4 = s.DateEditor;

                Q.initFormType(MachineForm, [
                    'MachineName', w0,
                    'IsRealTime', w1,
                    'TableId', w2,
                    'TableName', w0,
                    'MachineLineId', w2,
                    'AccessIpAddress', w0,
                    'MachineSequence', w2,
                    'MachineImage', w0,
                    'Description', w0,
                    'ModelNumber', w0,
                    'SerialNumber', w0,
                    'Make', w0,
                    'Year', w2,
                    'TimerForAlarm', w2,
                    'PlcMake', w0,
                    'PlcModelNumber', w0,
                    'PlcSerialNumber', w0,
                    'PlcAddress', w0,
                    'StatusId', w3,
                    'CreatedBy', w2,
                    'CreatedDate', w4,
                    'UpdatedBy', w2,
                    'UpdatedDate', w4
                ]);
            }
        }
    }
}

