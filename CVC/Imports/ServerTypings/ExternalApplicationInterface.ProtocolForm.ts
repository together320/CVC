namespace CVC.ExternalApplicationInterface {
    export interface ProtocolForm {
        ProtocolName: Serenity.StringEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class ProtocolForm extends Serenity.PrefixedContext {
        static formKey = 'ExternalApplicationInterface.Protocol';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProtocolForm.init)  {
                ProtocolForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(ProtocolForm, [
                    'ProtocolName', w0,
                    'StatusId', w1
                ]);
            }
        }
    }
}

