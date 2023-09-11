namespace CVC.Configuration {
    export interface DepartmentForm {
        DepartmentCode: Serenity.StringEditor;
        DepartmentName: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class DepartmentForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.Department';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DepartmentForm.init)  {
                DepartmentForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(DepartmentForm, [
                    'DepartmentCode', w0,
                    'DepartmentName', w0,
                    'StatusId', w1
                ]);
            }
        }
    }
}

