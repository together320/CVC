
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class TreeDisplayDialog extends Serenity.EntityDialog<TreeDisplayRow, any> {
        protected getFormKey() { return TreeDisplayForm.formKey; }
        protected getIdProperty() { return TreeDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return TreeDisplayRow.localTextPrefix; }
        protected getNameProperty() { return TreeDisplayRow.nameProperty; }
        protected getService() { return TreeDisplayService.baseUrl; }
        protected getDeletePermission() { return TreeDisplayRow.deletePermission; }
        protected getInsertPermission() { return TreeDisplayRow.insertPermission; }
        protected getUpdatePermission() { return TreeDisplayRow.updatePermission; }

        protected form = new TreeDisplayForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.TreeDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}