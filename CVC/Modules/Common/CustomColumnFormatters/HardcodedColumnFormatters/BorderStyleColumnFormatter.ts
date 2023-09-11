// added by Denis for RS 6.5 dated 8/4/2021
namespace CVC.Common.CustomColumnFormatters {

    @Serenity.Decorators.registerFormatter([Serenity.ISlickFormatter, Serenity.IInitializeColumn])
    export class BorderStyleColumnFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {

            if (!ctx.value) {
                return "";
            }

            var value = ctx.value
            var itm = Q.first(CVC.Common.CustomEditors.BorderStyleLookup, x => x.id == value);
            return itm.text;
        }

        public initializeColumn(column: Slick.Column) {

        }
    }
}