namespace CVC.MachineCustomization {
    export interface AlarmDisplayForm {
        AlarmDisplayName: Serenity.StringEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        FontColorSelected: Common.CustomEditors.ColorPickerEditor;
        FontColorUnselected: Common.CustomEditors.ColorPickerEditor;
        CautionColor: Common.CustomEditors.ColorPickerEditor;
        WarningColor: Common.CustomEditors.ColorPickerEditor;
        EmergencyColor: Common.CustomEditors.ColorPickerEditor;
        IsCheckbox: Serenity.BooleanEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Appearance: Common.CustomEditors.AppearanceValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsOpenInNewWindow: Serenity.BooleanEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsFolderBrowse: Serenity.BooleanEditor;
        IsAddAttachments: Serenity.BooleanEditor;
        IsCollapsible: Serenity.BooleanEditor;
    }

    export class AlarmDisplayForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.AlarmDisplay';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AlarmDisplayForm.init)  {
                AlarmDisplayForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = Common.CustomEditors.ColorPickerEditor;
                var w2 = Common.CustomEditors.BorderStyleValueEditor;
                var w3 = Common.CustomEditors.FontValueEditor;
                var w4 = s.BooleanEditor;
                var w5 = Common.CustomEditors.ActivationValueEditor;
                var w6 = Common.CustomEditors.AppearanceValueEditor;
                var w7 = Common.CustomEditors.AlignmentValueEditor;

                Q.initFormType(AlarmDisplayForm, [
                    'AlarmDisplayName', w0,
                    'BackgroundColor', w1,
                    'BorderStyle', w2,
                    'Font', w3,
                    'FontColorSelected', w1,
                    'FontColorUnselected', w1,
                    'CautionColor', w1,
                    'WarningColor', w1,
                    'EmergencyColor', w1,
                    'IsCheckbox', w4,
                    'Activation', w5,
                    'Appearance', w6,
                    'Alignment', w7,
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

