namespace CVC.Report {
    export interface AuditLogArchiveForm {
        UserId: Serenity.IntegerEditor;
        UserName: Serenity.StringEditor;
        Action: Serenity.StringEditor;
        ChangedOn: Serenity.DateEditor;
        TableName: Serenity.StringEditor;
        RowId: Serenity.IntegerEditor;
        Module: Serenity.StringEditor;
        Page: Serenity.StringEditor;
        FieldName: Serenity.StringEditor;
        OldValue: Serenity.StringEditor;
        NewValue: Serenity.StringEditor;
        Comments: Serenity.StringEditor;
        PcipAddress: Serenity.StringEditor;
        BatchId: Serenity.IntegerEditor;
        BatchName: Serenity.StringEditor;
        MachineId: Serenity.IntegerEditor;
        MachineName: Serenity.StringEditor;
    }

    export class AuditLogArchiveForm extends Serenity.PrefixedContext {
        static formKey = 'Report.AuditLogArchive';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AuditLogArchiveForm.init)  {
                AuditLogArchiveForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(AuditLogArchiveForm, [
                    'UserId', w0,
                    'UserName', w1,
                    'Action', w1,
                    'ChangedOn', w2,
                    'TableName', w1,
                    'RowId', w0,
                    'Module', w1,
                    'Page', w1,
                    'FieldName', w1,
                    'OldValue', w1,
                    'NewValue', w1,
                    'Comments', w1,
                    'PcipAddress', w1,
                    'BatchId', w0,
                    'BatchName', w1,
                    'MachineId', w0,
                    'MachineName', w1
                ]);
            }
        }
    }
}

