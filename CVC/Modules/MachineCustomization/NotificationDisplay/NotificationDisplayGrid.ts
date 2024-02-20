
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class NotificationDisplayGrid extends Common.Bases.GridBase<NotificationDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.NotificationDisplay'; }
        protected getDialogType() { return NotificationDisplayDialog; }
        protected getIdProperty() { return NotificationDisplayRow.idProperty; }
        protected getInsertPermission() { return NotificationDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return NotificationDisplayRow.localTextPrefix; }
        protected getService() { return NotificationDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
            var grid = this.slickGrid;
            // var view = this.view;
            //setTimeout(() => this.slickGrid.setSelectedRows([0]), 1000);
            grid.onSelectedRowsChanged.subscribe(() => {
                var selectedRow = grid.getSelectedRows()[0];
                var record = grid.getDataItem(selectedRow);
                var doTypeLookup = CVC.Common.CustomEditors.DOTypeLookup;
                var dot = Q.tryFirst(doTypeLookup, x => x.text === "Notification Display");

                $('#DisplayObjectTypeId').val(dot.id);
                $('#SubTypeId').val(record.NotificationDisplayId);
                console.log("piechartdisplayid = ", record.NotificationDisplayId);
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