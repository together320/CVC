namespace CVC.MachineCustomization {

    import fld = DisplayObjectRow.Fields;
    @Serenity.Decorators.registerClass()
    export class DisplayObjectGrid extends Common.Bases.GridBase<DisplayObjectRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.DisplayObject'; }
        protected getDialogType() { return DisplayObjectDialog; }
        protected getIdProperty() { return DisplayObjectRow.idProperty; }
        protected getInsertPermission() { return DisplayObjectRow.insertPermission; }
        protected getLocalTextPrefix() { return DisplayObjectRow.localTextPrefix; }
        protected getService() { return DisplayObjectService.baseUrl; }

        constructor(container: JQuery) {
            super(container);

            var grid = this.slickGrid;

            // Set the first row as default selected
            this.view.onDataLoaded.subscribe(e => {
                var selectedRow = grid.getSelectedRows()[0];
                if (selectedRow)
                    grid.setSelectedRows([selectedRow]);
                else
                    grid.setSelectedRows([0]);
            })

            grid.onSelectedRowsChanged.subscribe(() => {
                var selectedRow = grid.getSelectedRows()[0];
                var record = grid.getDataItem(selectedRow);

                // Set the value of hidden tag with id 'DisplayObjectId'
                $("#DisplayObjectId").val(record.ViewsId)
                $("#DisplayObjectType").val(record.DisplayObjectTypeId)
                $("#DisplayObjectName").val(record.ViewName)
                // added by Denis for RS 7.2 dated 10/6/2021
                // Get DisplayObjectField Widget and destroy it if it exists.
                var widget = $('#DisplayObjectField_GridDiv').tryGetWidget<DisplayObjectFieldGrid>(DisplayObjectFieldGrid);
                widget?.destroy();

                // Init DisplayObjectFieldGrid widget in the element with id 'DisplayObjectField_GridDiv'
                new CVC.MachineCustomization.DisplayObjectFieldGrid($('#DisplayObjectField_GridDiv')).init();

                $(".quick-filters-bar").hide();
            });

        }

        protected getColumns() {
            var re = /Id/gi;
            var columns = super.getColumns();

            columns.unshift({
                field: 'Design Mode',
                name: 'Design Mode',
                format: ctx => '<button type="button" class="btn btn-primary design-mode"><i class="fa fa-th" aria-hidden="true"></i></button>',
                width: 50,
                minWidth: 50,
                maxWidth: 50
            });

            var dos_col = Q.first(columns, x => x.field === fld.DisplayObjectStyle);
            dos_col.referencedFields = [fld.DisplayObjectStyle];

            dos_col.format = ctx => {
                var doTypeId = ctx.item[fld.DisplayObjectTypeId];
                var field = Q.tryFirst(CVC.Common.CustomEditors.DOTypeLookup, x => x.id == doTypeId)?.field
                // Change i.e ListDisplayId -> ListDisplayName
                var colName = field?.replace(re, "Name");
                var value = ctx.item[colName]
                return value ?? "";
            }

            CVC.Common.CustomEditors.DOTypeLookup.forEach(ele => {
                var colName = ele.field?.replace(re, "Name");
                if (colName) {
                    //columns.splice(Q.indexOf(columns, x => x.field === colName), 1);
                    var col = Q.tryFirst(columns, x => x.field === colName);
                    col.headerCssClass = "CVC_Hidden";
                    col.cssClass = "CVC_Hidden";
                }
            });

            return columns;
        }

        /* Below two functions make SlickGrid row selectable
         * https://github.com/serenity-is/Serenity/issues/1241
         * ******************************************************************************/

        protected getSlickOptions() {
            var opt = super.getSlickOptions();
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selected";
            opt.enableCellNavigation = true;
            opt.rowHeight = 40;
            opt.frozenColumn = 0;
            return opt;
        }

        protected createSlickGrid() {
            var grid = super.createSlickGrid();
            grid.setSelectionModel(new Slick.RowSelectionModel());
            return grid;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented())
                return;
            if ($(e.target).hasClass("design-mode")) {
                Q.notifyInfo("Design Mode selected");
            }
        }
        /*******************************************************************************/
    }
}