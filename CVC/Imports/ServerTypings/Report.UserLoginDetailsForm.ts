namespace CVC.Report {
    export interface UserLoginDetailsForm {
        UserId: Serenity.IntegerEditor;
        LoginDatetime: Serenity.DateEditor;
        LogoutDatetime: Serenity.DateEditor;
        IsOnline: Serenity.IntegerEditor;
    }

    export class UserLoginDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Report.UserLoginDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserLoginDetailsForm.init)  {
                UserLoginDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(UserLoginDetailsForm, [
                    'UserId', w0,
                    'LoginDatetime', w1,
                    'LogoutDatetime', w1,
                    'IsOnline', w0
                ]);
            }
        }
    }
}

