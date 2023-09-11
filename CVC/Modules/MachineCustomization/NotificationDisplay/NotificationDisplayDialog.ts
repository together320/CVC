
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class NotificationDisplayDialog extends Serenity.EntityDialog<NotificationDisplayRow, any> {
        protected getFormKey() { return NotificationDisplayForm.formKey; }
        protected getIdProperty() { return NotificationDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return NotificationDisplayRow.localTextPrefix; }
        protected getNameProperty() { return NotificationDisplayRow.nameProperty; }
        protected getService() { return NotificationDisplayService.baseUrl; }
        protected getDeletePermission() { return NotificationDisplayRow.deletePermission; }
        protected getInsertPermission() { return NotificationDisplayRow.insertPermission; }
        protected getUpdatePermission() { return NotificationDisplayRow.updatePermission; }

        protected form = new NotificationDisplayForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.NotificationDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}