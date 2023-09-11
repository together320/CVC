/*
* https://github.com/serenity-is/Serenity/issues/447#issuecomment-901943838
* created by Denis dated 8/20/2021
* **/
namespace CVC.Common.Bases {
    @Serenity.Decorators.filterable()
    export class GridBase<TItem, TOptions> extends Serenity.EntityGrid<TItem, TOptions> {
        constructor(container: JQuery, options?: TOptions) {
            super(container, options);
        }
        
        protected createSlickGrid() {
            var grid = super.createSlickGrid();
            grid.registerPlugin(new Slick.AutoColumnSize(true));
            return grid;
        }
    }
}