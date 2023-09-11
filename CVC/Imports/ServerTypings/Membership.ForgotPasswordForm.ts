namespace CVC.Membership {
    export interface ForgotPasswordForm {
        Username: Serenity.StringEditor;
        QuestionId: Serenity.LookupEditor;
        QuestionAns: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
    }

    export class ForgotPasswordForm extends Serenity.PrefixedContext {
        static formKey = 'Membership.ForgotPassword';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ForgotPasswordForm.init)  {
                ForgotPasswordForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.PasswordEditor;

                Q.initFormType(ForgotPasswordForm, [
                    'Username', w0,
                    'QuestionId', w1,
                    'QuestionAns', w0,
                    'Password', w2,
                    'PasswordConfirm', w2
                ]);
            }
        }
    }
}

