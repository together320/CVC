namespace CVC.Report {
    export interface UserLogForm {
        UserLogId: Serenity.StringEditor;
        UserId: Serenity.IntegerEditor;
        UserName: Serenity.StringEditor;
        Action: Serenity.StringEditor;
        ChangedOn: Serenity.DateEditor;
    }

    export class UserLogForm extends Serenity.PrefixedContext {
        static formKey = 'Report.UserLog';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserLogForm.init)  {
                UserLogForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(UserLogForm, [
                    'UserLogId', w0,
                    'UserId', w1,
                    'UserName', w0,
                    'Action', w0,
                    'ChangedOn', w2
                ]);
            }
        }
    }
}

