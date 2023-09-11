namespace CVC.MachineCustomization {
    export interface RecipeSettingsForm {
        RecipeSettingsName: Serenity.StringEditor;
        MachineId: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class RecipeSettingsForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.RecipeSettings';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RecipeSettingsForm.init)  {
                RecipeSettingsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(RecipeSettingsForm, [
                    'RecipeSettingsName', w0,
                    'MachineId', w1,
                    'StatusId', w1,
                    'CreatedBy', w1,
                    'CreatedDate', w2,
                    'UpdatedBy', w1,
                    'UpdatedDate', w2
                ]);
            }
        }
    }
}

