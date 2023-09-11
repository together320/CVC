namespace CVC.Report {
    export interface AlarmLogForm {
        MachineId: Serenity.IntegerEditor;
        AlarmId: Serenity.IntegerEditor;
        BatchId: Serenity.IntegerEditor;
        LoggedUserId: Serenity.IntegerEditor;
        Comment: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        AlarmDateTime: Serenity.DateEditor;
        PcipAddress: Serenity.StringEditor;
    }

    export class AlarmLogForm extends Serenity.PrefixedContext {
        static formKey = 'Report.AlarmLog';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AlarmLogForm.init)  {
                AlarmLogForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(AlarmLogForm, [
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

