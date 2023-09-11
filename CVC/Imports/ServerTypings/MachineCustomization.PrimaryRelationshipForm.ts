namespace CVC.MachineCustomization {
    export interface PrimaryRelationshipForm {
        RelationshipName: Serenity.StringEditor;
        PrimaryBe: Serenity.LookupEditor;
        PrimaryEf: Serenity.LookupEditor;
        Description: Serenity.TextAreaEditor;
        Status: Serenity.LookupEditor;
    }

    export class PrimaryRelationshipForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.PrimaryRelationship';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PrimaryRelationshipForm.init)  {
                PrimaryRelationshipForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.TextAreaEditor;

                Q.initFormType(PrimaryRelationshipForm, [
                    'RelationshipName', w0,
                    'PrimaryBe', w1,
                    'PrimaryEf', w1,
                    'Description', w2,
                    'Status', w1
                ]);
            }
        }
    }
}

