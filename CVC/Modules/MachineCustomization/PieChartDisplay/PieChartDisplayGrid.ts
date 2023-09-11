
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class PieChartDisplayGrid extends Common.Bases.GridBase<PieChartDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.PieChartDisplay'; }
        protected getDialogType() { return PieChartDisplayDialog; }
        protected getIdProperty() { return PieChartDisplayRow.idProperty; }
        protected getInsertPermission() { return PieChartDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return PieChartDisplayRow.localTextPrefix; }
        protected getService() { return PieChartDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}