namespace CVC.MachineCustomization {
    export interface RealtimeParameterDisplayForm {
        RealtimeParameterDisplayName: Serenity.StringEditor;
        Font: Common.CustomEditors.FontValueEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }

    export class RealtimeParameterDisplayForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.RealtimeParameterDisplay';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RealtimeParameterDisplayForm.init)  {
                RealtimeParameterDisplayForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = Common.CustomEditors.FontValueEditor;
                var w2 = Common.CustomEditors.BorderStyleValueEditor;
                var w3 = Common.CustomEditors.ColorPickerEditor;
                var w4 = Common.CustomEditors.AlignmentValueEditor;
                var w5 = s.BooleanEditor;

                Q.initFormType(RealtimeParameterDisplayForm, [
                    'RealtimeParameterDisplayName', w0,
                    'Font', w1,
                    'BorderStyle', w2,
                    'BackgroundColor', w3,
                    'FontColor', w3,
                    'Alignment', w4,
                    'IsTooltip', w5,
                    'IsHorizontalScrollBar', w5,
                    'IsVerticalScrollBar', w5,
                    'IsCollapsible', w5
                ]);
            }
        }
    }
}

