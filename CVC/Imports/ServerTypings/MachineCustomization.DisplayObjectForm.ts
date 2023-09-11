namespace CVC.MachineCustomization {
    export interface DisplayObjectForm {
        ViewName: Serenity.StringEditor;
        MachineId: Serenity.LookupEditor;
        DisplayObjectTypeId: Common.CustomEditors.DOTypeValueEditor;
        StatusId: Serenity.LookupEditor;
        ListDisplayId: Serenity.LookupEditor;
        FormDisplayId: Serenity.LookupEditor;
        ButtonDisplayId: Serenity.LookupEditor;
        RealtimeParameterDisplayId: Serenity.LookupEditor;
        LineChartDisplayId: Serenity.LookupEditor;
        PieChartDisplayId: Serenity.LookupEditor;
        TreeDisplayId: Serenity.LookupEditor;
        AttachmentDisplayId: Serenity.LookupEditor;
        AlarmDisplayId: Serenity.LookupEditor;
        NotificationDisplayId: Serenity.LookupEditor;
        ContainerDisplayId: Serenity.LookupEditor;
        CreatedBy: Serenity.IntegerEditor;
        CreatedDate: Serenity.DateEditor;
        UpdatedBy: Serenity.IntegerEditor;
        UpdatedDate: Serenity.DateEditor;
    }

    export class DisplayObjectForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.DisplayObject';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DisplayObjectForm.init)  {
                DisplayObjectForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = Common.CustomEditors.DOTypeValueEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.DateEditor;

                Q.initFormType(DisplayObjectForm, [
                    'ViewName', w0,
                    'MachineId', w1,
                    'DisplayObjectTypeId', w2,
                    'StatusId', w1,
                    'ListDisplayId', w1,
                    'FormDisplayId', w1,
                    'ButtonDisplayId', w1,
                    'RealtimeParameterDisplayId', w1,
                    'LineChartDisplayId', w1,
                    'PieChartDisplayId', w1,
                    'TreeDisplayId', w1,
                    'AttachmentDisplayId', w1,
                    'AlarmDisplayId', w1,
                    'NotificationDisplayId', w1,
                    'ContainerDisplayId', w1,
                    'CreatedBy', w3,
                    'CreatedDate', w4,
                    'UpdatedBy', w3,
                    'UpdatedDate', w4
                ]);
            }
        }
    }
}

