namespace CVC.MachineCustomization {
    export interface DisplayObjectFieldForm {
        ViewFieldName: Serenity.StringEditor;
        ViewsId: DisplayObjectLookupEditor;
        MachineParameterId: Serenity.LookupEditor;
        Sequence: Serenity.IntegerEditor;
        StatusId: Serenity.LookupEditor;
        IsPopUpRequired: Serenity.BooleanEditor;
        IsCommentRequired: Serenity.BooleanEditor;
        IsAuthenticationRequired: Serenity.BooleanEditor;
        IsSelectAllRoles: Serenity.BooleanEditor;
        Roles: Serenity.LookupEditor;
    }

    export class DisplayObjectFieldForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.DisplayObjectField';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DisplayObjectFieldForm.init)  {
                DisplayObjectFieldForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = DisplayObjectLookupEditor;
                var w2 = s.LookupEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.BooleanEditor;

                Q.initFormType(DisplayObjectFieldForm, [
                    'ViewFieldName', w0,
                    'ViewsId', w1,
                    'MachineParameterId', w2,
                    'Sequence', w3,
                    'StatusId', w2,
                    'IsPopUpRequired', w4,
                    'IsCommentRequired', w4,
                    'IsAuthenticationRequired', w4,
                    'IsSelectAllRoles', w4,
                    'Roles', w2
                ]);
            }
        }
    }
}

