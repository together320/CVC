namespace CVC.MachineCustomization {
    export interface FormDisplayForm {
        FormDisplayName: Serenity.StringEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        IsCheckbox: Serenity.BooleanEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }

    export class FormDisplayForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.FormDisplay';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!FormDisplayForm.init)  {
                FormDisplayForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = Common.CustomEditors.BorderStyleValueEditor;
                var w2 = Common.CustomEditors.FontValueEditor;
                var w3 = Common.CustomEditors.ColorPickerEditor;
                var w4 = s.BooleanEditor;
                var w5 = Common.CustomEditors.ActivationValueEditor;
                var w6 = Common.CustomEditors.AlignmentValueEditor;

                Q.initFormType(FormDisplayForm, [
                    'FormDisplayName', w0,
                    'BorderStyle', w1,
                    'Font', w2,
                    'BackgroundColor', w3,
                    'IsCheckbox', w4,
                    'FontColorSelected', w3,
                    'FontColorUnselected', w3,
                    'Activation', w5,
                    'Alignment', w6,
                    'IsTooltip', w4,
                    'IsHorizontalScrollBar', w4,
                    'IsVerticalScrollBar', w4,
                    'IsCollapsible', w4
                ]);
            }
        }
    }
}

