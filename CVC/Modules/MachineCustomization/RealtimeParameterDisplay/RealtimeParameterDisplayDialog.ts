
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class RealtimeParameterDisplayDialog extends Serenity.EntityDialog<RealtimeParameterDisplayRow, any> {
        protected getFormKey() { return RealtimeParameterDisplayForm.formKey; }
        protected getIdProperty() { return RealtimeParameterDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return RealtimeParameterDisplayRow.localTextPrefix; }
        protected getNameProperty() { return RealtimeParameterDisplayRow.nameProperty; }
        protected getService() { return RealtimeParameterDisplayService.baseUrl; }
        protected getDeletePermission() { return RealtimeParameterDisplayRow.deletePermission; }
        protected getInsertPermission() { return RealtimeParameterDisplayRow.insertPermission; }
        protected getUpdatePermission() { return RealtimeParameterDisplayRow.updatePermission; }

        protected form = new RealtimeParameterDisplayForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.RealtimeParameterDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}