namespace CVC.MachineCustomization {
    export interface MachineHelpFileForm {
        MachineId: Serenity.IntegerEditor;
        FileName: Serenity.StringEditor;
        FileContent: Serenity.StringEditor;
        FileLength: Serenity.IntegerEditor;
        FileExtension: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class MachineHelpFileForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineHelpFile';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineHelpFileForm.init)  {
                MachineHelpFileForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(MachineHelpFileForm, [
                    'MachineId', w0,
                    'FileName', w1,
                    'FileContent', w1,
                    'FileLength', w0,
                    'FileExtension', w1,
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

