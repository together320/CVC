namespace CVC.MachineCustomization {
    export interface MachineRecipeForm {
        RecipeName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    export class MachineRecipeForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineRecipe';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineRecipeForm.init)  {
                MachineRecipeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(MachineRecipeForm, [
                    'RecipeName', w0,
                    'Description', w0
                ]);
            }
        }
    }
}

