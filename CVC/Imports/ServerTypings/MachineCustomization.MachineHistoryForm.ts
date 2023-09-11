namespace CVC.MachineCustomization {
    export interface MachineHistoryForm {
        MachineId: Serenity.IntegerEditor;
        IssueStartDate: Serenity.DateEditor;
        IssueCloseDate: Serenity.DateEditor;
        ProblemNatureId: Serenity.IntegerEditor;
        SparePartId: Serenity.IntegerEditor;
        ProblemDescription: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class MachineHistoryForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineHistory';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineHistoryForm.init)  {
                MachineHistoryForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;
                var w2 = s.StringEditor;

                Q.initFormType(MachineHistoryForm, [
                    'MachineId', w0,
                    'IssueStartDate', w1,
                    'IssueCloseDate', w1,
                    'ProblemNatureId', w0,
                    'SparePartId', w0,
                    'ProblemDescription', w2,
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

