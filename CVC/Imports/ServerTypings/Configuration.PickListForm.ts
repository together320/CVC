namespace CVC.Configuration {
    export interface PickListForm {
        PickListName: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class PickListForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.PickList';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PickListForm.init)  {
                PickListForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(PickListForm, [
                    'PickListName', w0,
                    'StatusId', w1
                ]);
            }
        }
    }
}

