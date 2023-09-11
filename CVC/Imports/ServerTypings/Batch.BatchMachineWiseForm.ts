namespace CVC.Batch {
    export interface BatchMachineWiseForm {
        MachineId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        RecipeId: Serenity.IntegerEditor;
        IsMachineInUse: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class BatchMachineWiseForm extends Serenity.PrefixedContext {
        static formKey = 'Batch.BatchMachineWise';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BatchMachineWiseForm.init)  {
                BatchMachineWiseForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(BatchMachineWiseForm, [
                    'MachineId', w0,
                    'BatchId', w0,
                    'RecipeId', w0,
                    'IsMachineInUse', w0,
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

