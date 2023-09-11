namespace CVC.Batch {
    export interface LabelLostForm {
        LabelRecId: Serenity.IntegerEditor;
        ActivityId: Serenity.IntegerEditor;
        ActivityText: Serenity.StringEditor;
        NumberOfLabels: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class LabelLostForm extends Serenity.PrefixedContext {
        static formKey = 'Batch.LabelLost';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LabelLostForm.init)  {
                LabelLostForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(LabelLostForm, [
                    'LabelRecId', w0,
                    'ActivityId', w0,
                    'ActivityText', w1,
                    'NumberOfLabels', w0,
                    'StatusId', w0,
                    'CreatedBy', w0,
                    'CreatedDate', w2,
                    'UpdatedBy', w0,
                    'UpdatedDate', w2
                ]);
            }
        }
    }
}

