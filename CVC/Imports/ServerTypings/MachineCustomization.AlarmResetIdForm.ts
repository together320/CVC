namespace CVC.MachineCustomization {
    export interface AlarmResetIdForm {
        AlarmId: Serenity.IntegerEditor;
        RoleId: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class AlarmResetIdForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.AlarmResetId';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AlarmResetIdForm.init)  {
                AlarmResetIdForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(AlarmResetIdForm, [
                    'AlarmId', w0,
                    'RoleId', w0,
                    'StatusId', w0,
                    'CreatedBy', w0,
                    'CreatedDate', w1,
                    'UpdatedBy', w0,
                    'UpdatedDate', w1
                ]);
            }
        }
    }
}

