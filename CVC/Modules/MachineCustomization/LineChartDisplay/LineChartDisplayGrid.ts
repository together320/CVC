
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

            var grid = this.slickGrid;
            // var view = this.view;
            //setTimeout(() => this.slickGrid.setSelectedRows([0]), 1000);
            grid.onSelectedRowsChanged.subscribe(() => {
                var selectedRow = grid.getSelectedRows()[0];
                var record = grid.getDataItem(selectedRow);
                var doTypeLookup = CVC.Common.CustomEditors.DOTypeLookup;
                var dot = Q.tryFirst(doTypeLookup, x => x.text === "Line Chart Display");

                $('#DisplayObjectTypeId').val(dot.id);
                $('#SubTypeId').val(record.LineChartDisplayId);
                console.log("LineChartDisplayId = ", record.LineChartDisplayId);
                // added by Denis for RS 8.3 dated 9/8/2021
                // Get SecondaryRelationshipGrid widget and destroy it if it exists.
                var widget = $('#DisplayObjectType_Color').tryGetWidget<DisplayObjectTypeColorGrid>(DisplayObjectTypeColorGrid);
                widget?.destroy();

                // Init SecondaryRelationshipGrid widget in the element with id 'Secondary_GridDiv'
                new CVC.MachineCustomization.DisplayObjectTypeColorGrid($('#DisplayObjectType_Color')).init();
                // $(".quick-filters-bar").hide();
            });

        }

        protected getSlickOptions() {
            var opt = super.getSlickOptions();
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selected";
            opt.enableCellNavigation = true;
            return opt;
        }

        protected createSlickGrid() {
            var grid = super.createSlickGrid();
            grid.setSelectionModel(new Slick.RowSelectionModel());
            return grid;
        }
    }
}