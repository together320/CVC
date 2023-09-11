namespace CVC.Configuration {
    export interface ShiftForm {
        ShiftName: Serenity.StringEditor;
        StartTime: Serenity.StringEditor;
        EndTime: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class ShiftForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.Shift';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ShiftForm.init)  {
                ShiftForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(ShiftForm, [
                    'ShiftName', w0,
                    'StartTime', w0,
                    'EndTime', w0,
                    'StatusId', w1
                ]);
            }
        }
    }
}

