namespace CVC.MachineCustomization {
    export interface ContainerDisplayForm {
        ContainerDisplayName: Serenity.StringEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsOpenInNewWindow: Serenity.BooleanEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }

    export class ContainerDisplayForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.ContainerDisplay';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ContainerDisplayForm.init)  {
                ContainerDisplayForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = Common.CustomEditors.ColorPickerEditor;
                var w2 = Common.CustomEditors.BorderStyleValueEditor;
                var w3 = Common.CustomEditors.FontValueEditor;
                var w4 = Common.CustomEditors.ActivationValueEditor;
                var w5 = Common.CustomEditors.AlignmentValueEditor;
                var w6 = s.BooleanEditor;

                Q.initFormType(ContainerDisplayForm, [
                    'ContainerDisplayName', w0,
                    'BackgroundColor', w1,
                    'BorderStyle', w2,
                    'Font', w3,
                    'FontColorSelected', w1,
                    'FontColorUnselected', w1,
                    'Activation', w4,
                    'Alignment', w5,
                    'IsOpenInNewWindow', w6,
                    'IsTooltip', w6,
                    'IsHorizontalScrollBar', w6,
                    'IsVerticalScrollBar', w6,
                    'IsCollapsible', w6
                ]);
            }
        }
    }
}

