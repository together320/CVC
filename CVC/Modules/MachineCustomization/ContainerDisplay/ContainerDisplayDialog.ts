
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class ContainerDisplayDialog extends Serenity.EntityDialog<ContainerDisplayRow, any> {
        protected getFormKey() { return ContainerDisplayForm.formKey; }
        protected getIdProperty() { return ContainerDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return ContainerDisplayRow.localTextPrefix; }
        protected getNameProperty() { return ContainerDisplayRow.nameProperty; }
        protected getService() { return ContainerDisplayService.baseUrl; }
        protected getDeletePermission() { return ContainerDisplayRow.deletePermission; }
        protected getInsertPermission() { return ContainerDisplayRow.insertPermission; }
        protected getUpdatePermission() { return ContainerDisplayRow.updatePermission; }

        protected form = new ContainerDisplayForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.ContainerDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}