
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class AlarmDisplayDialog extends Serenity.EntityDialog<AlarmDisplayRow, any> {
        protected getFormKey() { return AlarmDisplayForm.formKey; }
        protected getIdProperty() { return AlarmDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return AlarmDisplayRow.localTextPrefix; }
        protected getNameProperty() { return AlarmDisplayRow.nameProperty; }
        protected getService() { return AlarmDisplayService.baseUrl; }
        protected getDeletePermission() { return AlarmDisplayRow.deletePermission; }
        protected getInsertPermission() { return AlarmDisplayRow.insertPermission; }
        protected getUpdatePermission() { return AlarmDisplayRow.updatePermission; }

        protected form = new AlarmDisplayForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.AlarmDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}