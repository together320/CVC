namespace CVC.Configuration {
    export interface SupplierForm {
        SupplierName: Serenity.StringEditor;
        SupplierAddress: Serenity.StringEditor;
        CityCountry: Serenity.LookupEditor;
        CityState: Serenity.LookupEditor;
        CityId: Serenity.LookupEditor;
        PinCode: Serenity.StringEditor;
        MobileCode: Serenity.IntegerEditor;
        MobileNumber: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class SupplierForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.Supplier';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SupplierForm.init)  {
                SupplierForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(SupplierForm, [
                    'SupplierName', w0,
                    'SupplierAddress', w0,
                    'CityCountry', w1,
                    'CityState', w1,
                    'CityId', w1,
                    'PinCode', w0,
                    'MobileCode', w2,
                    'MobileNumber', w0,
                    'StatusId', w1
                ]);
            }
        }
    }
}

