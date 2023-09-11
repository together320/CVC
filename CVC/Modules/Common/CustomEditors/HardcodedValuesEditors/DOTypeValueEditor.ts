// added by Denis for RS 6.5 dated 8/6/2021
namespace CVC.Common.CustomEditors {
    @Serenity.Decorators.registerEditor()
    export class DOTypeValueEditor extends Serenity.Select2Editor<any, any> {

        constructor(container: JQuery) {
            super(container, null);

            DOTypeLookup.forEach((ele) => this.addItem(ele))
        }
    }
}