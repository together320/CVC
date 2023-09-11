namespace CVC.Configuration {
    export interface CityDetailsForm {
        Country: Serenity.LookupEditor;
        State: Serenity.LookupEditor;
        City: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class CityDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.CityDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CityDetailsForm.init)  {
                CityDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(CityDetailsForm, [
                    'Country', w0,
                    'State', w0,
                    'City', w1,
                    'StatusId', w0
                ]);
            }
        }
    }
}

