namespace CVC.PackSettings {
    export interface CapForm {
        CapName: Serenity.StringEditor;
        CapCc: Serenity.StringEditor;
        CapTypeId: Serenity.LookupEditor;
        CapDiameter: Serenity.StringEditor;
        CapHeight: Serenity.StringEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class CapForm extends Serenity.PrefixedContext {
        static formKey = 'PackSettings.Cap';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CapForm.init)  {
                CapForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(CapForm, [
                    'CapName', w0,
                    'CapCc', w0,
                    'CapTypeId', w1,
                    'CapDiameter', w0,
                    'CapHeight', w0,
                    'SupplierId', w1,
                    'StatusId', w1
                ]);
            }
        }
    }
}

