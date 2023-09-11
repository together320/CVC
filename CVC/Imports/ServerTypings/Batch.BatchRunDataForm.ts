namespace CVC.Batch {
    export interface BatchRunDataForm {
        BatchMachineWiseId: Serenity.IntegerEditor;
        IpcParameterId: Serenity.IntegerEditor;
        IpcParameterValue: Serenity.StringEditor;
        UpdatedDateTime: Serenity.DateEditor;
        LoggedInUser: Serenity.IntegerEditor;
    }

    export class BatchRunDataForm extends Serenity.PrefixedContext {
        static formKey = 'Batch.BatchRunData';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BatchRunDataForm.init)  {
                BatchRunDataForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(BatchRunDataForm, [
                    'BatchMachineWiseId', w0,
                    'IpcParameterId', w0,
                    'IpcParameterValue', w1,
                    'UpdatedDateTime', w2,
                    'LoggedInUser', w0
                ]);
            }
        }
    }
}

