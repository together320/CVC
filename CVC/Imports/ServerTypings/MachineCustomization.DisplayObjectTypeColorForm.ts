
namespace CVC.MachineCustomization {
    export class DisplayObjectTypeColorForm extends Serenity.PrefixedContext {
        static formKey = 'MachineCustomization.DisplayObjectTypeColor';
    }

    export interface DisplayObjectTypeColorForm {
        DotColor: Common.CustomEditors.ColorPickerEditor;
        Min: Serenity.DecimalEditor;
        Max: Serenity.DecimalEditor;
        DisplayObjectTypeId: Serenity.IntegerEditor;
        SubTypeId: Serenity.IntegerEditor;
    }

    [,
        ['DotColor', () => Common.CustomEditors.ColorPickerEditor],
        ['Min', () => Serenity.DecimalEditor],
        ['Max', () => Serenity.DecimalEditor],
        ['DisplayObjectTypeId', () => Serenity.IntegerEditor],
        ['SubTypeId', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(DisplayObjectTypeColorForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}