namespace CVC.Report {
    export interface BatchLogArchiveForm {
        MachineId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        Description: Serenity.StringEditor;
        UserId: Serenity.IntegerEditor;
        UpdatedDateTime: Serenity.DateEditor;
    }

    export class BatchLogArchiveForm extends Serenity.PrefixedContext {
        static formKey = 'Report.BatchLogArchive';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BatchLogArchiveForm.init)  {
                BatchLogArchiveForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(BatchLogArchiveForm, [
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

