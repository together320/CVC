namespace CVC.MachineCustomization {
    export interface AttachmentDisplayForm {
        AttachmentDisplayName: Serenity.StringEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        IsCheckbox: Serenity.BooleanEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsOpenInNewWindow: Serenity.BooleanEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsFolderBrowse: Serenity.BooleanEditor;
        IsAddAttachments: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }

    export class AttachmentDisplayForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.AttachmentDisplay';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AttachmentDisplayForm.init)  {
                AttachmentDisplayForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = Common.CustomEditors.ColorPickerEditor;
                var w2 = Common.CustomEditors.BorderStyleValueEditor;
                var w3 = Common.CustomEditors.FontValueEditor;
                var w4 = s.BooleanEditor;
                var w5 = Common.CustomEditors.ActivationValueEditor;
                var w6 = Common.CustomEditors.AlignmentValueEditor;

                Q.initFormType(AttachmentDisplayForm, [
                    'AttachmentDisplayName', w0,
                    'BackgroundColor', w1,
                    'BorderStyle', w2,
                    'Font', w3,
                    'IsCheckbox', w4,
                    'FontColorSelected', w1,
                    'FontColorUnselected', w1,
                    'Activation', w5,
                    'Alignment', w6,
                    'IsOpenInNewWindow', w4,
                    'IsTooltip', w4,
                    'IsHorizontalScrollBar', w4,
                    'IsVerticalScrollBar', w4,
                    'IsFolderBrowse', w4,
                    'IsAddAttachments', w4,
                    'IsCollapsible', w4
                ]);
            }
        }
    }
}

