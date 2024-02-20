
namespace CVC.MachineCustomization {
    export class DisplayObjectColorForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.DisplayObjectColor';
    }

    export interface DisplayObjectColorForm {
        RangeFrom: Serenity.DecimalEditor;
        RangeTo: Serenity.DecimalEditor;
        Color: Serenity.StringEditor;
        ViewsId: Serenity.IntegerEditor;
    }

    [,
        ['RangeFrom', () => Serenity.DecimalEditor],
        ['RangeTo', () => Serenity.DecimalEditor],
        ['Color', () => Serenity.StringEditor],
        ['ViewsId', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(DisplayObjectColorForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}