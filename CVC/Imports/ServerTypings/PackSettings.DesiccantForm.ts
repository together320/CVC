namespace CVC.PackSettings {
    export interface DesiccantForm {
        DesiccantName: Serenity.StringEditor;
        DesiccantTypeId: Serenity.LookupEditor;
        Grammage: Serenity.StringEditor;
        LengthOrHeight: Serenity.StringEditor;
        DiameterOrWidth: Serenity.StringEditor;
        Identification: Serenity.LookupEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class DesiccantForm extends Serenity.PrefixedContext {
        static formKey = 'PackSettings.Desiccant';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DesiccantForm.init)  {
                DesiccantForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(DesiccantForm, [
                    'DesiccantName', w0,
                    'DesiccantTypeId', w1,
                    'Grammage', w0,
                    'LengthOrHeight', w0,
                    'DiameterOrWidth', w0,
                    'Identification', w1,
                    'SupplierId', w1,
                    'StatusId', w1
                ]);
            }
        }
    }
}

