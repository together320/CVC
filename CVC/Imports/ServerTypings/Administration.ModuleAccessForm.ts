namespace CVC.Administration {
    export interface ModuleAccessForm {
        ModuleId: Serenity.IntegerEditor;
        RoleId: Serenity.IntegerEditor;
        IsAccess: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class ModuleAccessForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.ModuleAccess';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ModuleAccessForm.init)  {
                ModuleAccessForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(ModuleAccessForm, [
                    'ModuleId', w0,
                    'RoleId', w0,
                    'IsAccess', w0,
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

