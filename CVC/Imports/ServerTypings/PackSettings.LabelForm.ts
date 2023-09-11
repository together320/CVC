namespace CVC.PackSettings {
    export interface LabelForm {
        LabelName: Serenity.StringEditor;
        LabelLength: Serenity.StringEditor;
        LabelHeight: Serenity.StringEditor;
        LabelType: Serenity.StringEditor;
        LabelImage: Serenity.ImageUploadEditor;
        SupplierId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class LabelForm extends Serenity.PrefixedContext {
        static formKey = 'PackSettings.Label';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LabelForm.init)  {
                LabelForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;
                var w2 = s.LookupEditor;

                Q.initFormType(LabelForm, [
                    'LabelName', w0,
                    'LabelLength', w0,
                    'LabelHeight', w0,
                    'LabelType', w0,
                    'LabelImage', w1,
                    'SupplierId', w2,
                    'StatusId', w2
                ]);
            }
        }
    }
}

