namespace CVC.Report {
    export interface ExceptionLogForm {
        Id: Serenity.StringEditor;
        Type: Serenity.StringEditor;
        Url: Serenity.StringEditor;
        Message: Serenity.StringEditor;
    }

    export class ExceptionLogForm extends Serenity.PrefixedContext {
        static formKey = 'Report.ExceptionLog';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExceptionLogForm.init)  {
                ExceptionLogForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(ExceptionLogForm, [
                    'Id', w0,
                    'Type', w0,
                    'Url', w0,
                    'Message', w0
                ]);
            }
        }
    }
}

