namespace CVC.PackSettings {
    export interface CottonForm {
        CottonName: Serenity.StringEditor;
        CottonTypeId: Serenity.LookupEditor;
        GmOrYard: Serenity.StringEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class CottonForm extends Serenity.PrefixedContext {
        static formKey = 'PackSettings.Cotton';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CottonForm.init)  {
                CottonForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(CottonForm, [
                    'CottonName', w0,
                    'CottonTypeId', w1,
                    'GmOrYard', w0,
                    'SupplierId', w1,
                    'StatusId', w1
                ]);
            }
        }
    }
}

