namespace CVC.Batch {
    export interface BatchRecipeModifyForm {
        BatchMachineId: Serenity.IntegerEditor;
        RecipeSettingsParameterId: Serenity.IntegerEditor;
        OldValue: Serenity.StringEditor;
        NewValue: Serenity.StringEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class BatchRecipeModifyForm extends Serenity.PrefixedContext {
        static formKey = 'Batch.BatchRecipeModify';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BatchRecipeModifyForm.init)  {
                BatchRecipeModifyForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(BatchRecipeModifyForm, [
                    'BatchMachineId', w0,
                    'RecipeSettingsParameterId', w0,
                    'OldValue', w1,
                    'NewValue', w1,
                    'UpdatedBy', w0,
                    'UpdatedDate', w2
                ]);
            }
        }
    }
}

