namespace CVC.MachineCustomization {
    export interface MachineVideoForm {
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

    export class MachineVideoForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineVideo';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineVideoForm.init)  {
                MachineVideoForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(MachineVideoForm, [
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

