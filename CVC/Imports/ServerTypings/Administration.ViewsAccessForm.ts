namespace CVC.Administration {
    export interface ViewsAccessForm {
        ViewsId: Serenity.LookupEditor;
        RoleId: Serenity.LookupEditor;
        IsView: Serenity.BooleanEditor;
        IsModify: Serenity.BooleanEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class ViewsAccessForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.ViewsAccess';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ViewsAccessForm.init)  {
                ViewsAccessForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(ViewsAccessForm, [
                    'ViewsId', w0,
                    'RoleId', w0,
                    'IsView', w1,
                    'IsModify', w1,
                    'StatusId', w0
                ]);
            }
        }
    }
}

