namespace CVC.MachineCustomization {
    export interface MachineLineUserForm {
        MachineLineId: Serenity.IntegerEditor;
        UserId: Serenity.IntegerEditor;
        ShiftId: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class MachineLineUserForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineLineUser';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineLineUserForm.init)  {
                MachineLineUserForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(MachineLineUserForm, [
                    'MachineLineId', w0,
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

