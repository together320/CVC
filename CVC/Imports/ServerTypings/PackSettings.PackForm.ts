namespace CVC.PackSettings {
    export interface PackForm {
        PackName: Serenity.StringEditor;
        TabletId: Serenity.LookupEditor;
        TabletCount: Serenity.IntegerEditor;
        BottleId: Serenity.LookupEditor;
        CapId: Serenity.LookupEditor;
        CottonId: Serenity.LookupEditor;
        CottonLength: Serenity.StringEditor;
        NumberOfCottonPieces: Serenity.IntegerEditor;
        DesiccantId: Serenity.LookupEditor;
        NumberOfDesicantPieces: Serenity.IntegerEditor;
        OutsertId: Serenity.LookupEditor;
        LabelId: Serenity.LookupEditor;
        EndOfLineId: Serenity.LookupEditor;
        StatusId: Serenity.LookupEditor;
    }

    export class PackForm extends Serenity.PrefixedContext {
        static formKey = 'PackSettings.Pack';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PackForm.init)  {
                PackForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(PackForm, [
                    'PackName', w0,
                    'TabletId', w1,
                    'TabletCount', w2,
                    'BottleId', w1,
                    'CapId', w1,
                    'CottonId', w1,
                    'CottonLength', w0,
                    'NumberOfCottonPieces', w2,
                    'DesiccantId', w1,
                    'NumberOfDesicantPieces', w2,
                    'OutsertId', w1,
                    'LabelId', w1,
                    'EndOfLineId', w1,
                    'StatusId', w1
                ]);
            }
        }
    }
}

