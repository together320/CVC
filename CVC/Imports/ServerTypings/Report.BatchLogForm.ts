namespace CVC.Report {
    export interface BatchLogForm {
        MachineId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        Description: Serenity.StringEditor;
        UserId: Serenity.IntegerEditor;
        UpdatedDateTime: Serenity.DateEditor;
    }

    export class BatchLogForm extends Serenity.PrefixedContext {
        static formKey = 'Report.BatchLog';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BatchLogForm.init)  {
                BatchLogForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(BatchLogForm, [
                    'MachineId', w0,
                    'BatchId', w0,
                    'Description', w1,
                    'UserId', w0,
                    'UpdatedDateTime', w2
                ]);
            }
        }
    }
}

