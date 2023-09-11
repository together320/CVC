namespace CVC.Batch {
    export interface BatchForm {
        BatchName: Serenity.StringEditor;
        PackId: Serenity.IntegerEditor;
        MachineLineId: Serenity.IntegerEditor;
        BatchStatus: Serenity.StringEditor;
        BatchSize: Serenity.IntegerEditor;
        BatchFor: Serenity.LookupEditor;
        ExpiryDate: Serenity.DateEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateTimeEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateTimeEditor;
        BatchVersion: Serenity.StringEditor;
    }

    export class BatchForm extends Serenity.PrefixedContext {
        static formKey = 'Batch.Batch';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BatchForm.init)  {
                BatchForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.LookupEditor;
                var w3 = s.DateEditor;
                var w4 = s.DateTimeEditor;

                Q.initFormType(BatchForm, [
                    'BatchName', w0,
                    'PackId', w1,
                    'MachineLineId', w1,
                    'BatchStatus', w0,
                    'BatchSize', w1,
                    'BatchFor', w2,
                    'ExpiryDate', w3,
                    'StatusId', w1,
                    'CreatedBy', w1,
                    'CreatedDate', w4,
                    'UpdatedBy', w1,
                    'UpdatedDate', w4,
                    'BatchVersion', w0
                ]);
            }
        }
    }
}

