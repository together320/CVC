namespace CVC.MachineCustomization {
    export interface MachineUserForm {
        MachineId: Serenity.IntegerEditor;
        UserId: Serenity.IntegerEditor;
        ShiftId: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class MachineUserForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineUser';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineUserForm.init)  {
                MachineUserForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(MachineUserForm, [
                    'MachineId', w0,
                    'UserId', w0,
                    'ShiftId', w0,
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

