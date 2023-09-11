namespace CVC.PackSettings {
    export interface TabletDetailsForm {
        TabletName: Serenity.StringEditor;
        TabletStrength: Serenity.StringEditor;
        TabletTypeId: Serenity.LookupEditor;
        TabletCharOneId: Serenity.LookupEditor;
        TabletCharTwoId: Serenity.LookupEditor;
        TabletShapeId: Serenity.LookupEditor;
        TabletLength: Serenity.StringEditor;
        TabletThickness: Serenity.StringEditor;
        TabletWidth: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class TabletDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'PackSettings.TabletDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TabletDetailsForm.init)  {
                TabletDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(TabletDetailsForm, [
                    'TabletName', w0,
                    'TabletStrength', w0,
                    'TabletTypeId', w1,
                    'TabletCharOneId', w1,
                    'TabletCharTwoId', w1,
                    'TabletShapeId', w1,
                    'TabletLength', w0,
                    'TabletThickness', w0,
                    'TabletWidth', w0,
                    'StatusId', w1
                ]);
            }
        }
    }
}

