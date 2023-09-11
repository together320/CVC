namespace CVC.Report {
    export interface AlarmLogArchiveForm {
        MachineId: Serenity.IntegerEditor;
        AlarmId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        LoggedUserId: Serenity.IntegerEditor;
        Comment: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        AlarmDateTime: Serenity.DateEditor;
        PcipAddress: Serenity.StringEditor;
    }

    export class AlarmLogArchiveForm extends Serenity.PrefixedContext {
        static formKey = 'Report.AlarmLogArchive';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AlarmLogArchiveForm.init)  {
                AlarmLogArchiveForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(AlarmLogArchiveForm, [
                    'MachineId', w0,
                    'AlarmId', w0,
                    'BatchId', w0,
                    'LoggedUserId', w0,
                    'Comment', w1,
                    'Description', w1,
                    'AlarmDateTime', w2,
                    'PcipAddress', w1
                ]);
            }
        }
    }
}

