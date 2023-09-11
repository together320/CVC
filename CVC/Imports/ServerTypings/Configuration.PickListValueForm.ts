namespace CVC.Configuration {
    export interface PickListValueForm {
        PickListId: Serenity.LookupEditor;
        PickListValueName: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class PickListValueForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.PickListValue';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PickListValueForm.init)  {
                PickListValueForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(PickListValueForm, [
                    'PickListId', w0,
                    'PickListValueName', w1,
                    'StatusId', w0
                ]);
            }
        }
    }
}

