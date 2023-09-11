namespace CVC.MachineCustomization {
    export interface MachineRecipeParameterForm {
        MachineRecipeId: Serenity.IntegerEditor;
        RecipeSettingsParameterId: Serenity.IntegerEditor;
        RecipeParameterValue: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class MachineRecipeParameterForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineRecipeParameter';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineRecipeParameterForm.init)  {
                MachineRecipeParameterForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(MachineRecipeParameterForm, [
                    'MachineRecipeId', w0,
                    'RecipeSettingsParameterId', w0,
                    'RecipeParameterValue', w1,
                    'StatusId', w0,
                    'CreatedBy', w0,
                    'CreatedDate', w2,
                    'UpdatedBy', w0,
                    'UpdatedDate', w2
                ]);
            }
        }
    }
}

