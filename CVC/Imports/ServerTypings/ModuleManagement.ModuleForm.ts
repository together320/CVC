namespace CVC.ModuleManagement {
    export interface ModuleForm {
        ModuleName: Serenity.StringEditor;
        MachineId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
        Sequence: Serenity.IntegerEditor;
        EquipmentId: Serenity.StringEditor;
        SerialNumber: Serenity.StringEditor;
    }

    export class ModuleForm extends Serenity.PrefixedContext {
        static formKey = 'ModuleManagement.Module';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ModuleForm.init)  {
                ModuleForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ModuleForm, [
                    'ModuleName', w0,
                    'MachineId', w1,
                    'StatusId', w1,
                    'Sequence', w2,
                    'EquipmentId', w0,
                    'SerialNumber', w0
                ]);
            }
        }
    }
}

