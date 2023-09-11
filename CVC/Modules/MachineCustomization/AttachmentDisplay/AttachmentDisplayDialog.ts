
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class AttachmentDisplayDialog extends Serenity.EntityDialog<AttachmentDisplayRow, any> {
        protected getFormKey() { return AttachmentDisplayForm.formKey; }
        protected getIdProperty() { return AttachmentDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return AttachmentDisplayRow.localTextPrefix; }
        protected getNameProperty() { return AttachmentDisplayRow.nameProperty; }
        protected getService() { return AttachmentDisplayService.baseUrl; }
        protected getDeletePermission() { return AttachmentDisplayRow.deletePermission; }
        protected getInsertPermission() { return AttachmentDisplayRow.insertPermission; }
        protected getUpdatePermission() { return AttachmentDisplayRow.updatePermission; }

        protected form = new AttachmentDisplayForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.AttachmentDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}