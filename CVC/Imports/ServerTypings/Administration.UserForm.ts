namespace CVC.Administration {
    export interface UserForm {
        EmployeeId: Serenity.StringEditor;
        FirstName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        DepartmentId: Serenity.LookupEditor;
        Designation: Serenity.StringEditor;
        MobileCode: Serenity.IntegerEditor;
        MobileNumber: Serenity.StringEditor;
        BirthDate: Serenity.DateEditor;
        Email: Serenity.EmailEditor;
        Username: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
        RoleId: Serenity.LookupEditor;
        UserImage: Serenity.ImageUploadEditor;
        Address: Serenity.StringEditor;
        CityId: Serenity.LookupEditor;
        PinCode: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
        QuestionId: Serenity.LookupEditor;
        QuestionAns: Serenity.StringEditor;
        IsLockOut: Serenity.BooleanEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
        IsActiveDirectory: Serenity.BooleanEditor;
    }

    export class UserForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.User';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserForm.init)  {
                UserForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateEditor;
                var w4 = s.EmailEditor;
                var w5 = s.PasswordEditor;
                var w6 = s.ImageUploadEditor;
                var w7 = s.BooleanEditor;

                Q.initFormType(UserForm, [
                    'EmployeeId', w0,
                    'FirstName', w0,
                    'LastName', w0,
                    'DepartmentId', w1,
                    'Designation', w0,
                    'MobileCode', w2,
                    'MobileNumber', w0,
                    'BirthDate', w3,
                    'Email', w4,
                    'Username', w0,
                    'Password', w5,
                    'PasswordConfirm', w5,
                    'RoleId', w1,
                    'UserImage', w6,
                    'Address', w0,
                    'CityId', w1,
                    'PinCode', w0,
                    'StatusId', w1,
                    'QuestionId', w1,
                    'QuestionAns', w0,
                    'IsLockOut', w7,
                    'CreatedBy', w2,
                    'CreatedDate', w3,
                    'UpdatedBy', w2,
                    'UpdatedDate', w3,
                    'IsActiveDirectory', w7
                ]);
            }
        }
    }
}

