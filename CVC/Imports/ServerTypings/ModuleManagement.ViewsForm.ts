namespace CVC.ModuleManagement {
    export interface ViewsForm {
        ViewName: Serenity.StringEditor;
        ModuleId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
        IsMachineSettings: Serenity.BooleanEditor;
        IsMachineSummary: Serenity.BooleanEditor;
        IslabelRoll: Serenity.BooleanEditor;
        IsCommandPanel: Serenity.BooleanEditor;
    }

    export class ViewsForm extends Serenity.PrefixedContext {
        static formKey = 'ModuleManagement.Views';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ViewsForm.init)  {
                ViewsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.BooleanEditor;

                Q.initFormType(ViewsForm, [
                    'ViewName', w0,
                    'ModuleId', w1,
                    'StatusId', w1,
                    'IsMachineSettings', w2,
                    'IsMachineSummary', w2,
                    'IslabelRoll', w2,
                    'IsCommandPanel', w2
                ]);
            }
        }
    }
}

