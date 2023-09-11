// added by Denis for RS 6.5 dated 8/3/2021
namespace CVC.Common.CustomEditors {
    @Serenity.Decorators.registerEditor()
    export class ColorPickerEditor extends Serenity.StringEditor {
        constructor(input: JQuery) {
            super(input);

            input.attr('type', 'color');
        }
    }
}