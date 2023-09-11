namespace CVC.MachineCustomization {
    export interface ListDisplayForm {
        ListDisplayName: Serenity.StringEditor;
        ListDisplayId: Serenity.IntegerEditor;
        BackgroundColor: Common.CustomEditors.ColorPickerEditor;
        BorderStyle: Common.CustomEditors.BorderStyleValueEditor;
        Font: Common.CustomEditors.FontValueEditor;
        FontColor: Common.CustomEditors.ColorPickerEditor;
        FontSize: Common.CustomEditors.NumberInputEditor;
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

    export class ListDisplayForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.ListDisplay';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ListDisplayForm.init)  {
                ListDisplayForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = Common.CustomEditors.ColorPickerEditor;
                var w3 = Common.CustomEditors.BorderStyleValueEditor;
                var w4 = Common.CustomEditors.FontValueEditor;
                var w5 = Common.CustomEditors.NumberInputEditor;
                var w6 = s.BooleanEditor;
                var w7 = Common.CustomEditors.ActivationValueEditor;
                var w8 = Common.CustomEditors.AlignmentValueEditor;
                var w9 = Common.CustomEditors.SortTypeValueEditor;

                Q.initFormType(ListDisplayForm, [
                    'ListDisplayName', w0,
                    'ListDisplayId', w1,
                    'BackgroundColor', w2,
                    'BorderStyle', w3,
                    'Font', w4,
                    'FontColor', w2,
                    'FontSize', w5,
                    'Checkbox', w6,
                    'FullRowSelect', w6,
                    'Gridlines', w6,
                    'UseWaitCursorOnClick', w6,
                    'Activation', w7,
                    'Alignment', w8,
                    'SortingType', w9,
                    'SortAscDesc', w6,
                    'MultiSelect', w6,
                    'AutoResize', w6,
                    'Collapsible', w6
                ]);
            }
        }
    }
}

