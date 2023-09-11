// added by Denis for RS 6.5 dated 8/11/2021
namespace CVC.Common.CustomEditors {
    @Serenity.Decorators.registerEditor()
    export class AppearanceValueEditor extends Serenity.Select2Editor<any, any> {

        constructor(container: JQuery) {
            super(container, null);

            AppearanceLookup.forEach((ele) => this.addItem(ele))
        }
    }
}