namespace CVC.Configuration {
    export interface DataTypeForm {
        DataTypeName: Serenity.StringEditor;
        TypeId: Serenity.IntegerEditor;
        Bit: Serenity.IntegerEditor;
        IsSigned: Serenity.IntegerEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class DataTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.DataType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DataTypeForm.init)  {
                DataTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(DataTypeForm, [
                    'DataTypeName', w0,
                    'TypeId', w1,
                    'Bit', w1,
                    'IsSigned', w1,
                    'StatusId', w1,
                    'CreatedBy', w1,
                    'CreatedDate', w2,
                    'UpdatedBy', w1,
                    'UpdatedDate', w2
                ]);
            }
        }
    }
}

