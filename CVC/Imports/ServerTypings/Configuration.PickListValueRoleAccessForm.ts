namespace CVC.Configuration {
    export interface PickListValueRoleAccessForm {
        PickListValueId: Serenity.IntegerEditor;
        RoleId: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class PickListValueRoleAccessForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.PickListValueRoleAccess';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PickListValueRoleAccessForm.init)  {
                PickListValueRoleAccessForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(PickListValueRoleAccessForm, [
                    'PickListValueId', w0,
                    'RoleId', w0,
                    'StatusId', w0,
                    'CreatedBy', w0,
                    'CreatedDate', w1,
                    'UpdatedBy', w0,
                    'UpdatedDate', w1
                ]);
            }
        }
    }
}

