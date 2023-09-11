namespace CVC.MachineCustomization {
    export interface MachineLineForm {
        LineName: Serenity.StringEditor;
        LineRatedSpeed: Serenity.StringEditor;
        NumberOfMachines: Serenity.IntegerEditor;
        InstalledDate: Serenity.DateEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class MachineLineForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineLine';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineLineForm.init)  {
                MachineLineForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;
                var w3 = s.LookupEditor;

                Q.initFormType(MachineLineForm, [
                    'LineName', w0,
                    'LineRatedSpeed', w0,
                    'NumberOfMachines', w1,
                    'InstalledDate', w2,
                    'StatusId', w3
                ]);
            }
        }
    }
}

