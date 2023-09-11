namespace CVC.MachineCustomization {
    export interface MachineSpecificationForm {
        MachineId: Serenity.IntegerEditor;
        Description: Serenity.StringEditor;
        Details: Serenity.StringEditor;
        MachineImage: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class MachineSpecificationForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineSpecification';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineSpecificationForm.init)  {
                MachineSpecificationForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(MachineSpecificationForm, [
                    'MachineId', w0,
                    'Description', w1,
                    'Details', w1,
                    'MachineImage', w1,
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

