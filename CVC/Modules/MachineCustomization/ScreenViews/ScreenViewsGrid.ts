
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class ScreenViewsGrid extends Common.Bases.GridBase<ScreenViewsRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.ScreenViews'; }
        protected getDialogType() { return ScreenViewsDialog; }
        protected getIdProperty() { return ScreenViewsRow.idProperty; }
        protected getInsertPermission() { return ScreenViewsRow.insertPermission; }
        protected getLocalTextPrefix() { return ScreenViewsRow.localTextPrefix; }
        protected getService() { return ScreenViewsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getColumns() {
            var columns = super.getColumns();

            columns.push({
                field: 'Design Mode',
                name: 'Design Mode',
                format: ctx => '<button type="button" class="btn btn-primary design-mode">Design Mode</button>',
                width: 120,
                minWidth: 120,
                maxWidth: 120
            });
            return columns;
        }

        protected getSlickOptions() {
            var opt = super.getSlickOptions();
            opt.rowHeight = 40;
            return opt;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented())
                return;
            if ($(e.target).hasClass("design-mode")) {
                Q.notifyInfo("Design Mode selected");

            }
        }
    }
}