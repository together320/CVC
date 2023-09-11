namespace CVC.MachineCustomization {
    export interface MachineMaintenanceScheduleForm {
        MachineId: Serenity.IntegerEditor;
        StartDateTime: Serenity.DateEditor;
        EndDateTime: Serenity.DateEditor;
        Description: Serenity.StringEditor;
        StatusId: Serenity.IntegerEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class MachineMaintenanceScheduleForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.MachineMaintenanceSchedule';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MachineMaintenanceScheduleForm.init)  {
                MachineMaintenanceScheduleForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;
                var w2 = s.StringEditor;

                Q.initFormType(MachineMaintenanceScheduleForm, [
                    'MachineId', w0,
                    'StartDateTime', w1,
                    'EndDateTime', w1,
                    'Description', w2,
                    'StatusId', w0,
                    'CreatedBy', w0,
                    'CreatedDate', w1,
                    'UpdatedBy', w0,
                    'UpdatedDate', w1
                ]);
            }
        }
    }
}

