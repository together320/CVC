namespace CVC.MachineCustomization {
    export interface LineChartDisplayForm {
        LineChartDisplayName: Serenity.StringEditor;
        Font: Common.CustomEditors.FontValueEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        IsLegends: Serenity.BooleanEditor;
        AxisColor: Common.CustomEditors.ColorPickerEditor;
        IsGridlines: Serenity.BooleanEditor;
        GridlineColor: Common.CustomEditors.ColorPickerEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsRealtime: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }

    export class LineChartDisplayForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.LineChartDisplay';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LineChartDisplayForm.init)  {
                LineChartDisplayForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = Common.CustomEditors.FontValueEditor;
                var w2 = Common.CustomEditors.BorderStyleValueEditor;
                var w3 = Common.CustomEditors.ColorPickerEditor;
                var w4 = s.BooleanEditor;
                var w5 = Common.CustomEditors.AlignmentValueEditor;

                Q.initFormType(LineChartDisplayForm, [
                    'LineChartDisplayName', w0,
                    'Font', w1,
                    'BorderStyle', w2,
                    'BackgroundColor', w3,
                    'FontColor', w3,
                    'IsLegends', w4,
                    'AxisColor', w3,
                    'IsGridlines', w4,
                    'GridlineColor', w3,
                    'Alignment', w5,
                    'IsTooltip', w4,
                    'IsRealtime', w4,
                    'IsHorizontalScrollBar', w4,
                    'IsVerticalScrollBar', w4,
                    'IsCollapsible', w4
                ]);
            }
        }
    }
}

