namespace CVC.MachineCustomization {
    export interface PieChartDisplayForm {
        PieChartDisplayName: Serenity.StringEditor;
        Font: Common.CustomEditors.FontValueEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        IsLegends: Serenity.BooleanEditor;
        LegendFontSize: Common.CustomEditors.NumberInputEditor;
        IsShowValuesAsPercentage: Serenity.BooleanEditor;
        IsShowTotal: Serenity.BooleanEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsRealtime: Serenity.BooleanEditor;
    }

    export class PieChartDisplayForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.PieChartDisplay';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PieChartDisplayForm.init)  {
                PieChartDisplayForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = Common.CustomEditors.FontValueEditor;
                var w2 = Common.CustomEditors.BorderStyleValueEditor;
                var w3 = Common.CustomEditors.ColorPickerEditor;
                var w4 = s.BooleanEditor;
                var w5 = Common.CustomEditors.NumberInputEditor;
                var w6 = Common.CustomEditors.AlignmentValueEditor;

                Q.initFormType(PieChartDisplayForm, [
                    'PieChartDisplayName', w0,
                    'Font', w1,
                    'BorderStyle', w2,
                    'BackgroundColor', w3,
                    'FontColor', w3,
                    'IsLegends', w4,
                    'LegendFontSize', w5,
                    'IsShowValuesAsPercentage', w4,
                    'IsShowTotal', w4,
                    'Alignment', w6,
                    'IsTooltip', w4,
                    'IsHorizontalScrollBar', w4,
                    'IsVerticalScrollBar', w4,
                    'IsRealtime', w4
                ]);
            }
        }
    }
}

