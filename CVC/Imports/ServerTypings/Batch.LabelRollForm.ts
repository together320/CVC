namespace CVC.Batch {
    export interface LabelRollForm {
        BatchId: Serenity.IntegerEditor;
        MachineId: Serenity.IntegerEditor;
        LabelRollNumber: Serenity.IntegerEditor;
        NumberOfLabels: Serenity.StringEditor;
        Remark: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class LabelRollForm extends Serenity.PrefixedContext {
        static formKey = 'Batch.LabelRoll';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LabelRollForm.init)  {
                LabelRollForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(LabelRollForm, [
                    'BatchId', w0,
                    'MachineId', w0,
                    'LabelRollNumber', w0,
                    'NumberOfLabels', w1,
                    'Remark', w1,
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

