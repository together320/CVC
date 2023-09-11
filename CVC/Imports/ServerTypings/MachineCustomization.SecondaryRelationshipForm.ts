namespace CVC.MachineCustomization {
    export interface SecondaryRelationshipForm {
        PrimaryRelationshipId: PrimaryRelationshipLookupEditor;
        SecondaryBe: SecondaryBELookupEditor;
        SecondaryEf: SecondaryEFLookupEditor;
        Description: Serenity.TextAreaEditor;
    }

    export class SecondaryRelationshipForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.SecondaryRelationship';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SecondaryRelationshipForm.init)  {
                SecondaryRelationshipForm.init = true;

                var s = Serenity;
                var w0 = PrimaryRelationshipLookupEditor;
                var w1 = SecondaryBELookupEditor;
                var w2 = SecondaryEFLookupEditor;
                var w3 = s.TextAreaEditor;

                Q.initFormType(SecondaryRelationshipForm, [
                    'PrimaryRelationshipId', w0,
                    'SecondaryBe', w1,
                    'SecondaryEf', w2,
                    'Description', w3
                ]);
            }
        }
    }
}

