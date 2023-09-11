namespace CVC.MachineCustomization {
    export interface ListDisplayEditorForm {
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Serenity.StringEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        FontSize: Serenity.IntegerEditor;
        Checkbox: Serenity.BooleanEditor;
        FullRowSelect: Serenity.BooleanEditor;
        Gridlines: Serenity.BooleanEditor;
        UseWaitCursorOnClick: Serenity.BooleanEditor;
        Activation: Common.CustomEditors.ActivationValueEditor;
        Alignment: Common.CustomEditors.AlignmentValueEditor;
        SortingType: Common.CustomEditors.SortTypeValueEditor;
        SortAscDesc: Serenity.BooleanEditor;
        MultiSelect: Serenity.BooleanEditor;
        AutoResize: Serenity.BooleanEditor;
        Collapsible: Serenity.BooleanEditor;
    }

    export class ListDisplayEditorForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.ListDisplayEditor';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ListDisplayEditorForm.init)  {
                ListDisplayEditorForm.init = true;

                var s = Serenity;
                var w0 = Common.CustomEditors.ColorPickerEditor;
                var w1 = Common.CustomEditors.BorderStyleValueEditor;
                var w2 = s.StringEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.BooleanEditor;
                var w5 = Common.CustomEditors.ActivationValueEditor;
                var w6 = Common.CustomEditors.AlignmentValueEditor;
                var w7 = Common.CustomEditors.SortTypeValueEditor;

                Q.initFormType(ListDisplayEditorForm, [
                    'BackgroundColor', w0,
                    'BorderStyle', w1,
                    'Font', w2,
                    'FontColor', w0,
                    'FontSize', w3,
                    'Checkbox', w4,
                    'FullRowSelect', w4,
                    'Gridlines', w4,
                    'UseWaitCursorOnClick', w4,
                    'Activation', w5,
                    'Alignment', w6,
                    'SortingType', w7,
                    'SortAscDesc', w4,
                    'MultiSelect', w4,
                    'AutoResize', w4,
                    'Collapsible', w4
                ]);
            }
        }
    }
}

