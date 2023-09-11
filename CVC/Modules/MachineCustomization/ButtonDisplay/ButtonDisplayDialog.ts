
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class ButtonDisplayDialog extends Serenity.EntityDialog<ButtonDisplayRow, any> {
        protected getFormKey() { return ButtonDisplayForm.formKey; }
        protected getIdProperty() { return ButtonDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return ButtonDisplayRow.localTextPrefix; }
        protected getNameProperty() { return ButtonDisplayRow.nameProperty; }
        protected getService() { return ButtonDisplayService.baseUrl; }
        protected getDeletePermission() { return ButtonDisplayRow.deletePermission; }
        protected getInsertPermission() { return ButtonDisplayRow.insertPermission; }
        protected getUpdatePermission() { return ButtonDisplayRow.updatePermission; }

        protected form = new ButtonDisplayForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.ButtonDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}