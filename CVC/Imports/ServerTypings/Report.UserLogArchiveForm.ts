namespace CVC.Report {
    export interface UserLogArchiveForm {
        UserLogArchiveId: Serenity.StringEditor;
        UserId: Serenity.IntegerEditor;
        UserName: Serenity.StringEditor;
        Action: Serenity.StringEditor;
        ChangedOn: Serenity.DateEditor;
    }

    export class UserLogArchiveForm extends Serenity.PrefixedContext {
        static formKey = 'Report.UserLogArchive';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserLogArchiveForm.init)  {
                UserLogArchiveForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(UserLogArchiveForm, [
                    'UserLogArchiveId', w0,
                    'UserId', w1,
                    'UserName', w0,
                    'Action', w0,
                    'ChangedOn', w2
                ]);
            }
        }
    }
}

