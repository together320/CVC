namespace CVC.Configuration {
    export interface CurrencyForm {
        CountryName: Serenity.StringEditor;
        CurrencyType: Serenity.StringEditor;
        Symbol: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class CurrencyForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.Currency';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CurrencyForm.init)  {
                CurrencyForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(CurrencyForm, [
                    'CountryName', w0,
                    'CurrencyType', w0,
                    'Symbol', w0,
                    'Description', w0,
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

