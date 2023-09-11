namespace CVC.ModuleManagement {
    export interface ViewFieldForm {
        ViewsId: Serenity.LookupEditor;
        ViewFieldName: Serenity.StringEditor;
        MachineParameterId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
        Sequence: Serenity.IntegerEditor;
    }

    export class ViewFieldForm extends Serenity.PrefixedContext {
        static formKey = 'ModuleManagement.ViewField';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ViewFieldForm.init)  {
                ViewFieldForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ViewFieldForm, [
                    'ViewsId', w0,
                    'ViewFieldName', w1,
                    'MachineParameterId', w0,
                    'StatusId', w0,
                    'Sequence', w2
                ]);
            }
        }
    }
}

