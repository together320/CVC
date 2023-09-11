namespace CVC.MachineCustomization {
    export interface MachineSparePartForm {
        MachineId: Serenity.IntegerEditor;
        PartNumber: Serenity.StringEditor;
        PartName: Serenity.StringEditor;
        PartDescription: Serenity.StringEditor;
        NoOfUnitsRequired: Serenity.IntegerEditor;
        PartImage: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class MachineSparePartForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineSparePart';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineSparePartForm.init)  {
                MachineSparePartForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(MachineSparePartForm, [
                    'MachineId', w0,
                    'PartNumber', w1,
                    'PartName', w1,
                    'PartDescription', w1,
                    'NoOfUnitsRequired', w0,
                    'PartImage', w1,
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

