namespace CVC.Administration {
    export interface AdminFormForm {
        FormName: Serenity.StringEditor;
    }

    export class AdminFormForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.AdminForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AdminFormForm.init)  {
                AdminFormForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(AdminFormForm, [
                    'FormName', w0
                ]);
            }
        }
    }
}

