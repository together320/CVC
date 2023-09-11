// added by Denis for RS 6.5 dated 8/13/2021
namespace CVC.Common.CustomEditors {
    @Serenity.Decorators.registerEditor()
    export class NumberInputEditor extends Serenity.StringEditor {
        constructor(input: JQuery) {
            super(input);

            input.attr('type', 'number');
            input.attr('min', this.min?.toString() ?? '1');
            input.attr('max', this.max?.toString() ?? '100')
        }

        @Serenity.Decorators.option()
        public min: number;
        @Serenity.Decorators.option()
        public max: number;
    }
}