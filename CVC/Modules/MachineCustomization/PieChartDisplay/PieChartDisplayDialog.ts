
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class PieChartDisplayDialog extends Serenity.EntityDialog<PieChartDisplayRow, any> {
        protected getFormKey() { return PieChartDisplayForm.formKey; }
        protected getIdProperty() { return PieChartDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return PieChartDisplayRow.localTextPrefix; }
        protected getNameProperty() { return PieChartDisplayRow.nameProperty; }
        protected getService() { return PieChartDisplayService.baseUrl; }
        protected getDeletePermission() { return PieChartDisplayRow.deletePermission; }
        protected getInsertPermission() { return PieChartDisplayRow.insertPermission; }
        protected getUpdatePermission() { return PieChartDisplayRow.updatePermission; }

        protected form = new PieChartDisplayForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.PieChartDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}