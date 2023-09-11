
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class LineChartDisplayGrid extends Common.Bases.GridBase<LineChartDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.LineChartDisplay'; }
        protected getDialogType() { return LineChartDisplayDialog; }
        protected getIdProperty() { return LineChartDisplayRow.idProperty; }
        protected getInsertPermission() { return LineChartDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return LineChartDisplayRow.localTextPrefix; }
        protected getService() { return LineChartDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}