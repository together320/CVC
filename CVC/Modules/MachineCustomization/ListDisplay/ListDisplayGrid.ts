namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class ListDisplayGrid extends Common.Bases.GridBase<ListDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.ListDisplay'; }
        protected getDialogType() { return ListDisplayDialog; }
        protected getIdProperty() { return ListDisplayRow.idProperty; }
        protected getInsertPermission() { return ListDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return ListDisplayRow.localTextPrefix; }
        protected getService() { return ListDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        /*protected getColumns() {
            var columns = super.getColumns();
            var fld = ListDisplayRow.Fields;
            var act_sp = Q.first(columns, x => x.field === fld.Activation);
            act_sp.referencedFields = [fld.Activation];
            act_sp.format = ctx => this.selectFormatter(ctx, fld.Activation, CVC.Common.CustomEditors.ActivationLookup);

            var align_sp = Q.first(columns, x => x.field === fld.Alignment);
            align_sp.referencedFields = [fld.Alignment];
            align_sp.format = ctx => this.selectFormatter(ctx, fld.Alignment, CVC.Common.CustomEditors.AlignmentLookup);

            var border_sp = Q.first(columns, x => x.field === fld.BorderStyle);
            border_sp.referencedFields = [fld.BorderStyle];
            border_sp.format = ctx => this.selectFormatter(ctx, fld.BorderStyle, CVC.Common.CustomEditors.BorderStyleLookup);

            return columns;
        }

        // Cell formatter
        private selectFormatter(ctx: Slick.FormatterContext, idField: string, lookup: { id: string, text: string }[]) {
            var value = ctx.item[idField]
            var itm = Q.first(lookup, x => x.id == value);
            return itm.text;
        }*/
    }
}