namespace CVC.MachineCustomization {
    export interface ButtonDisplayForm {
        ButtonDisplayName: Serenity.StringEditor;
        Font: Common.CustomEditors.FontValueEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }

    export class ButtonDisplayForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.ButtonDisplay';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ButtonDisplayForm.init)  {
                ButtonDisplayForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = Common.CustomEditors.FontValueEditor;
                var w2 = Common.CustomEditors.BorderStyleValueEditor;
                var w3 = Common.CustomEditors.ColorPickerEditor;
                var w4 = Common.CustomEditors.ActivationValueEditor;
                var w5 = Common.CustomEditors.AlignmentValueEditor;
                var w6 = s.BooleanEditor;

                Q.initFormType(ButtonDisplayForm, [
                    'ButtonDisplayName', w0,
                    'Font', w1,
                    'BorderStyle', w2,
                    'FontColorSelected', w3,
                    'FontColorUnselected', w3,
                    'BackgroundColor', w3,
                    'Activation', w4,
                    'Alignment', w5,
                    'IsTooltip', w6,
                    'IsHorizontalScrollBar', w6,
                    'IsVerticalScrollBar', w6,
                    'IsCollapsible', w6
                ]);
            }
        }
    }
}

