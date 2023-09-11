
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class FormDisplayDialog extends Serenity.EntityDialog<FormDisplayRow, any> {
        protected getFormKey() { return FormDisplayForm.formKey; }
        protected getIdProperty() { return FormDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return FormDisplayRow.localTextPrefix; }
        protected getNameProperty() { return FormDisplayRow.nameProperty; }
        protected getService() { return FormDisplayService.baseUrl; }
        protected getDeletePermission() { return FormDisplayRow.deletePermission; }
        protected getInsertPermission() { return FormDisplayRow.insertPermission; }
        protected getUpdatePermission() { return FormDisplayRow.updatePermission; }

        protected form = new FormDisplayForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.FormDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}