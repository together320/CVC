namespace CVC.PackSettings {
    export interface OutsertForm {
        OutsertName: Serenity.StringEditor;
        OutsertLength: Serenity.StringEditor;
        OutsertWidth: Serenity.StringEditor;
        OutsertThickness: Serenity.StringEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class OutsertForm extends Serenity.PrefixedContext {
        static formKey = 'PackSettings.Outsert';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OutsertForm.init)  {
                OutsertForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(OutsertForm, [
                    'OutsertName', w0,
                    'OutsertLength', w0,
                    'OutsertWidth', w0,
                    'OutsertThickness', w0,
                    'SupplierId', w1,
                    'StatusId', w1
                ]);
            }
        }
    }
}

