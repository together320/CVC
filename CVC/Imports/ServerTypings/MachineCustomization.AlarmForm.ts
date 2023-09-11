namespace CVC.MachineCustomization {
    export interface AlarmForm {
        AlarmName: Serenity.StringEditor;
        MachineId: Serenity.LookupEditor;
        MachineParameterId: Serenity.LookupEditor;
        Message: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        IsResetRequired: Serenity.BooleanEditor;
        IsCommentRequired: Serenity.BooleanEditor;
        IsMachineRequiredToStop: Serenity.BooleanEditor;
        MachineStopMachineParameterId: Serenity.LookupEditor;
        IsCountForReject: Serenity.BooleanEditor;
        BitValue: Serenity.BooleanEditor;
        IsCheckAtMachineStart: Serenity.BooleanEditor;
        StatusId: Serenity.LookupEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
        IsRefreshMachineSettings: Serenity.BooleanEditor;
        IsHideEdit: Serenity.BooleanEditor;
        IsAlarmForCounter: Serenity.BooleanEditor;
    }

    export class AlarmForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.Alarm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AlarmForm.init)  {
                AlarmForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.BooleanEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.DateEditor;

                Q.initFormType(AlarmForm, [
                    'AlarmName', w0,
                    'MachineId', w1,
                    'MachineParameterId', w1,
                    'Message', w0,
                    'Description', w0,
                    'IsResetRequired', w2,
                    'IsCommentRequired', w2,
                    'IsMachineRequiredToStop', w2,
                    'MachineStopMachineParameterId', w1,
                    'IsCountForReject', w2,
                    'BitValue', w2,
                    'IsCheckAtMachineStart', w2,
                    'StatusId', w1,
                    'CreatedBy', w3,
                    'CreatedDate', w4,
                    'UpdatedBy', w3,
                    'UpdatedDate', w4,
                    'IsRefreshMachineSettings', w2,
                    'IsHideEdit', w2,
                    'IsAlarmForCounter', w2
                ]);
            }
        }
    }
}

