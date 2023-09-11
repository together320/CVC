namespace CVC.PackSettings {
    export interface BottleForm {
        BottleName: Serenity.StringEditor;
        BottleCc: Serenity.StringEditor;
        ContainerTypeId: Serenity.LookupEditor;
        BottleHeight: Serenity.StringEditor;
        BottleDiameter: Serenity.StringEditor;
        BottleMouthOpeningId: Serenity.StringEditor;
        BottleMouthOpeningOd: Serenity.StringEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class BottleForm extends Serenity.PrefixedContext {
        static formKey = 'PackSettings.Bottle';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BottleForm.init)  {
                BottleForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(BottleForm, [
                    'BottleName', w0,
                    'BottleCc', w0,
                    'ContainerTypeId', w1,
                    'BottleHeight', w0,
                    'BottleDiameter', w0,
                    'BottleMouthOpeningId', w0,
                    'BottleMouthOpeningOd', w0,
                    'SupplierId', w1,
                    'StatusId', w1
                ]);
            }
        }
    }
}

