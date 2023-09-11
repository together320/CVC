
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class PrimaryRelationshipGrid extends Common.Bases.GridBase<PrimaryRelationshipRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.PrimaryRelationship'; }
        protected getDialogType() { return PrimaryRelationshipDialog; }
        protected getIdProperty() { return PrimaryRelationshipRow.idProperty; }
        protected getInsertPermission() { return PrimaryRelationshipRow.insertPermission; }
        protected getLocalTextPrefix() { return PrimaryRelationshipRow.localTextPrefix; }
        protected getService() { return PrimaryRelationshipService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
            var grid = this.slickGrid;
            var view = this.view;
            //setTimeout(() => this.slickGrid.setSelectedRows([0]), 1000);
            grid.onSelectedRowsChanged.subscribe(() => {
                var selectedRow = grid.getSelectedRows()[0];
                var record = grid.getDataItem(selectedRow);

                // Set the value of hidden tag with id 'PrimaryRelationshipId'
                $("#PrimaryRelationshipId").val(record.PrimaryRelationshipId)

                // added by Denis for RS 8.3 dated 9/8/2021
                // Get SecondaryRelationshipGrid widget and destroy it if it exists.
                var widget = $('#Secondary_GridDiv').tryGetWidget<SecondaryRelationshipGrid>(SecondaryRelationshipGrid);
                widget?.destroy();

                // Init SecondaryRelationshipGrid widget in the element with id 'Secondary_GridDiv'
                new CVC.MachineCustomization.SecondaryRelationshipGrid($('#Secondary_GridDiv')).init();
                $(".quick-filters-bar").hide();
            });

            /*
             * When creating a new row, the created row is selected
             * When deleting a row, the row above the deleted row is selected.**/
            var row_count, old_row_count = 0
            view.onDataChanged.subscribe((e, args) => {
                row_count = view.getLength();
                var selectedRows = grid.getSelectedRows();

                var row_nums = Array.from({ length: row_count }, (_, i) => i);
                var row_ids = row_nums.map(x => grid.getDataItem(x).PrimaryRelationshipId);
                var row_id_num_pairs = row_nums.reduce((prev, cur) => {
                    var key = grid.getDataItem(cur).PrimaryRelationshipId;
                    var obj = {};
                    obj[key] = cur;
                    return { ...prev, ...obj }
                }, {});
                var max_row_id = Math.max(...row_ids);

                if (row_count > 0) {
                    if (row_count > old_row_count) {
                        //grid.setSelectedRows([row_count - 1]);
                        grid.setSelectedRows([row_id_num_pairs[max_row_id]]);
                    }

                    if ((row_count < old_row_count) && (selectedRows.length > 0)) {
                        let row_idx = (selectedRows[0] - 1) < 0 ? 0 : selectedRows[0] - 1;
                        grid.setSelectedRows([row_idx]);
                    }
                }

                old_row_count = row_count;

                /*
                var selectedRows = grid.getSelectedRows();

                if (row_count == 0) return

                // For When the first row is been creating
                if ((selectedRows.length == 0) ||
                    (selectedRows.length > 0 && selectedRows[0] == 0))
                {
                    grid.setSelectedRows([0]);
                }

                // For row deleting
                if (selectedRows.length > 0 && selectedRows[0] == row_count)
                {
                    grid.setSelectedRows([row_count - 1]);
                }*/
            });

            // Forece select a row of active cell
            //grid.onActiveCellChanged.subscribe((e, args) => {
            //    grid.setSelectedRows([args.row]);
            //});
        }

        /* Below two functions make SlickGrid row selectable
         * https://github.com/serenity-is/Serenity/issues/1241
         * ******************************************************************************/

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
        /*******************************************************************************/
    }
}