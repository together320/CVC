namespace CVC.MachineCustomization {
    export interface ScreenViewsForm {
        ScreenViewName: Serenity.StringEditor;
        PrimaryRelationshipId: Serenity.LookupEditor;
        IsNoBer: Serenity.BooleanEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class ScreenViewsForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.ScreenViews';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ScreenViewsForm.init)  {
                ScreenViewsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.BooleanEditor;

                Q.initFormType(ScreenViewsForm, [
                    'ScreenViewName', w0,
                    'PrimaryRelationshipId', w1,
                    'IsNoBer', w2,
                    'StatusId', w1
                ]);
            }
        }
    }
}

