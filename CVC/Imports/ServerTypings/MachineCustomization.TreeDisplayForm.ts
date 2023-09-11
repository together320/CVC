namespace CVC.MachineCustomization {
    export interface TreeDisplayForm {
        TreeDisplayName: Serenity.StringEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        IsFullRowSelect: Serenity.BooleanEditor;
        LineColor: Common.CustomEditors.ColorPickerEditor;
        DefaultView: Common.CustomEditors.DefaultViewValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        IsTooltip: Serenity.BooleanEditor;
        IsHorizontalScrollBar: Serenity.BooleanEditor;
        IsVerticalScrollBar: Serenity.BooleanEditor;
        IsRealtime: Serenity.BooleanEditor;
    }

    export class TreeDisplayForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.TreeDisplay';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TreeDisplayForm.init)  {
                TreeDisplayForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = Common.CustomEditors.ColorPickerEditor;
                var w2 = Common.CustomEditors.BorderStyleValueEditor;
                var w3 = Common.CustomEditors.FontValueEditor;
                var w4 = s.BooleanEditor;
                var w5 = Common.CustomEditors.DefaultViewValueEditor;
                var w6 = Common.CustomEditors.AlignmentValueEditor;

                Q.initFormType(TreeDisplayForm, [
                    'TreeDisplayName', w0,
                    'BackgroundColor', w1,
                    'BorderStyle', w2,
                    'Font', w3,
                    'FontColor', w1,
                    'IsFullRowSelect', w4,
                    'LineColor', w1,
                    'DefaultView', w5,
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

