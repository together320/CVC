namespace CVC.Administration {
    export interface ViewFieldAccessForm {
        ViewFieldId: Serenity.LookupEditor;
        RoleId: Serenity.LookupEditor;
        IsView: Serenity.BooleanEditor;
        IsModify: Serenity.BooleanEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class ViewFieldAccessForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.ViewFieldAccess';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ViewFieldAccessForm.init)  {
                ViewFieldAccessForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(ViewFieldAccessForm, [
                    'ViewFieldId', w0,
                    'RoleId', w0,
                    'IsView', w1,
                    'IsModify', w1,
                    'StatusId', w0
                ]);
            }
        }
    }
}

