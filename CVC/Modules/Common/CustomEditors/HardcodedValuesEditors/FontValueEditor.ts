// added by Denis for RS 6.5 dated 8/13/2021
namespace CVC.Common.CustomEditors {
    @Serenity.Decorators.registerEditor()
    export class FontValueEditor extends Serenity.Select2Editor<any, any> {

        constructor(container: JQuery) {
            super(container, null);
            FontLookup.forEach((ele) => this.addItem(ele))
            //var cssContent = this.getCssContent();
        }
        /*
        protected getCssContent(): string {
            var result = null;
            $.ajax({
                url: "/Content/site/cvc.custom.css",
                dataType: "text",
                async: false,
                success: (content) => {
                    result = content;
                }
            });
            return result;
        }*/
    }
}