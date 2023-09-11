namespace CVC.Batch {
    export interface LabelReconciliationForm {
        BatchId: Serenity.IntegerEditor;
        MachineId: Serenity.IntegerEditor;
        LabelRollId: Serenity.IntegerEditor;
        RejectedLabels: Serenity.IntegerEditor;
        LabelLost: Serenity.IntegerEditor;
        NoLabelOnRoll: Serenity.IntegerEditor;
        LabelBalance: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class LabelReconciliationForm extends Serenity.PrefixedContext {
        static formKey = 'Batch.LabelReconciliation';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LabelReconciliationForm.init)  {
                LabelReconciliationForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(LabelReconciliationForm, [
                    'BatchId', w0,
                    'MachineId', w0,
                    'LabelRollId', w0,
                    'RejectedLabels', w0,
                    'LabelLost', w0,
                    'NoLabelOnRoll', w0,
                    'LabelBalance', w0,
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

