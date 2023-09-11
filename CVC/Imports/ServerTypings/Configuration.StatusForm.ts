﻿namespace CVC.Configuration {
    export interface StatusForm {
        StatusName: Serenity.StringEditor;
    }

    export class StatusForm extends Serenity.PrefixedContext {
        static formKey = 'Configuration.Status';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!StatusForm.init)  {
                StatusForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(StatusForm, [
                    'StatusName', w0
                ]);
            }
        }
    }
}

