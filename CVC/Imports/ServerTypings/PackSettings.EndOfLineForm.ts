namespace CVC.PackSettings {
    export interface EndOfLineForm {
        EndOfLineName: Serenity.StringEditor;
        CartonLength: Serenity.StringEditor;
        CartonHeight: Serenity.StringEditor;
        CartonWidth: Serenity.StringEditor;
        CartonType: Serenity.StringEditor;
        BottleConfiguration: Serenity.StringEditor;
        MedicationLength: Serenity.StringEditor;
        MedicationWidth: Serenity.StringEditor;
        NoOfMedication: Serenity.StringEditor;
        InnerShipperBoxType: Serenity.StringEditor;
        InnerShipperBoxLength: Serenity.StringEditor;
        InnerShipperBoxWidth: Serenity.StringEditor;
        InnerShipperBoxHeight: Serenity.StringEditor;
        OuterShipperBoxLength: Serenity.StringEditor;
        OuterShipperBoxWidth: Serenity.StringEditor;
        OuterShipperBoxHeight: Serenity.StringEditor;
        InnerShipperMatrix: Serenity.StringEditor;
        OuterShipperQuantity: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class EndOfLineForm extends Serenity.PrefixedContext {
        static formKey = 'PackSettings.EndOfLine';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!EndOfLineForm.init)  {
                EndOfLineForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(EndOfLineForm, [
                    'EndOfLineName', w0,
                    'CartonLength', w0,
                    'CartonHeight', w0,
                    'CartonWidth', w0,
                    'CartonType', w0,
                    'BottleConfiguration', w0,
                    'MedicationLength', w0,
                    'MedicationWidth', w0,
                    'NoOfMedication', w0,
                    'InnerShipperBoxType', w0,
                    'InnerShipperBoxLength', w0,
                    'InnerShipperBoxWidth', w0,
                    'InnerShipperBoxHeight', w0,
                    'OuterShipperBoxLength', w0,
                    'OuterShipperBoxWidth', w0,
                    'OuterShipperBoxHeight', w0,
                    'InnerShipperMatrix', w0,
                    'OuterShipperQuantity', w0,
                    'StatusId', w1
                ]);
            }
        }
    }
}

