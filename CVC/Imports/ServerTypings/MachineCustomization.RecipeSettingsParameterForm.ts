namespace CVC.MachineCustomization {
    export interface RecipeSettingsParameterForm {
        RecipeSettingsId: Serenity.IntegerEditor;
        IpcParameterId: Serenity.IntegerEditor;
        IsFetchOnSelfSet: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class RecipeSettingsParameterForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.RecipeSettingsParameter';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RecipeSettingsParameterForm.init)  {
                RecipeSettingsParameterForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(RecipeSettingsParameterForm, [
                    'RecipeSettingsId', w0,
                    'IpcParameterId', w0,
                    'IsFetchOnSelfSet', w0,
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

