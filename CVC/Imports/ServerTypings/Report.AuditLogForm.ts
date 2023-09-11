namespace CVC.Report {
    export interface AuditLogForm {
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
        MachineId: Serenity.LookupEditor;
        MachineName: Serenity.StringEditor;
    }

    export class AuditLogForm extends Serenity.PrefixedContext {
        static formKey = 'Report.AuditLog';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AuditLogForm.init)  {
                AuditLogForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;
                var w3 = s.LookupEditor;

                Q.initFormType(AuditLogForm, [
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
                    'MachineId', w3,
                    'MachineName', w1
                ]);
            }
        }
    }
}

