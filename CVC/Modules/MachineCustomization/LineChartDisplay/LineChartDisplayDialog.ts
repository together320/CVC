
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class LineChartDisplayDialog extends Serenity.EntityDialog<LineChartDisplayRow, any> {
        protected getFormKey() { return LineChartDisplayForm.formKey; }
        protected getIdProperty() { return LineChartDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return LineChartDisplayRow.localTextPrefix; }
        protected getNameProperty() { return LineChartDisplayRow.nameProperty; }
        protected getService() { return LineChartDisplayService.baseUrl; }
        protected getDeletePermission() { return LineChartDisplayRow.deletePermission; }
        protected getInsertPermission() { return LineChartDisplayRow.insertPermission; }
        protected getUpdatePermission() { return LineChartDisplayRow.updatePermission; }

        protected form = new LineChartDisplayForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.LineChartDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}