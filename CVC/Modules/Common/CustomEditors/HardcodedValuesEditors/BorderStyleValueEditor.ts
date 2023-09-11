// added by Denis for RS 6.5 dated 8/3/2021
namespace CVC.Common.CustomEditors {
    @Serenity.Decorators.registerEditor()
    export class BorderStyleValueEditor extends Serenity.Select2Editor<any, any> {

        constructor(container: JQuery) {
            super(container, null);

            BorderStyleLookup.forEach((ele) => this.addItem(ele))
        }
    }
}