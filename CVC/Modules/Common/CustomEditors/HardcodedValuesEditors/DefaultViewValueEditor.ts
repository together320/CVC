// added by Denis for RS 6.5 dated 8/9/2021
namespace CVC.Common.CustomEditors {
    @Serenity.Decorators.registerEditor()
    export class DefaultViewValueEditor extends Serenity.Select2Editor<any, any> {

        constructor(container: JQuery) {
            super(container, null);

            DefaultViewLookup.forEach((ele) => this.addItem(ele))
        }
    }
}