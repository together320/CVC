namespace CVC.Configuration {
    export interface CompanyForm {
        CompanyName: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        CityCountry: Serenity.LookupEditor;
        CityState: Serenity.LookupEditor;
        CityId: Serenity.LookupEditor;
        PinCode: Serenity.StringEditor;
        Website: Serenity.StringEditor;
        CompanyLogo: Serenity.ImageUploadEditor;
    }

    export class CompanyForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.Company';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CompanyForm.init)  {
                CompanyForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.ImageUploadEditor;

                Q.initFormType(CompanyForm, [
                    'CompanyName', w0,
                    'Address', w0,
                    'CityCountry', w1,
                    'CityState', w1,
                    'CityId', w1,
                    'PinCode', w0,
                    'Website', w0,
                    'CompanyLogo', w2
                ]);
            }
        }
    }
}

