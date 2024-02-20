namespace CVC.MachineCustomization {
    @Serenity.Decorators.registerClass()
    export class AlarmDialog extends Serenity.EntityDialog<AlarmRow, any> {
        protected getFormKey() { return AlarmForm.formKey; }
        protected getIdProperty() { return AlarmRow.idProperty; }
        protected getLocalTextPrefix() { return AlarmRow.localTextPrefix; }
        protected getNameProperty() { return AlarmRow.nameProperty; }
        protected getService() { return AlarmService.baseUrl; }
        protected getDeletePermission() { return AlarmRow.deletePermission; }
        protected getInsertPermission() { return AlarmRow.insertPermission; }
        protected getUpdatePermission() { return AlarmRow.updatePermission; }

        protected form = new AlarmForm(this.idPrefix);

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
                var res = AlarmService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[AlarmRow.Fields.AlarmId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in Bottle
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }

    }
}