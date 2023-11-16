namespace CVC.MachineCustomization {
    @Serenity.Decorators.registerClass()
    export class MachineDialog extends Serenity.EntityDialog<MachineRow, any> {
        protected getFormKey() { return MachineForm.formKey; }
        protected getIdProperty() { return MachineRow.idProperty; }
        protected getLocalTextPrefix() { return MachineRow.localTextPrefix; }
        protected getNameProperty() { return MachineRow.nameProperty; }
        protected getService() { return MachineService.baseUrl; }
        protected getDeletePermission() { return MachineRow.deletePermission; }
        protected getInsertPermission() { return MachineRow.insertPermission; }
        protected getUpdatePermission() { return MachineRow.updatePermission; }

        protected form = new MachineForm(this.idPrefix);

        constructor() {
            super();

        }

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = MachineService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[MachineRow.Fields.MachineId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in Bottle
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }

    }
}