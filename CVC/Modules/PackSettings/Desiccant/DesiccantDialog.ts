namespace CVC.PackSettings {
    @Serenity.Decorators.registerClass()
    export class DesiccantDialog extends Serenity.EntityDialog<DesiccantRow, any> {
        protected getFormKey() { return DesiccantForm.formKey; }
        protected getIdProperty() { return DesiccantRow.idProperty; }
        protected getLocalTextPrefix() { return DesiccantRow.localTextPrefix; }
        protected getNameProperty() { return DesiccantRow.nameProperty; }
        protected getService() { return DesiccantService.baseUrl; }
        protected getDeletePermission() { return DesiccantRow.deletePermission; }
        protected getInsertPermission() { return DesiccantRow.insertPermission; }
        protected getUpdatePermission() { return DesiccantRow.updatePermission; }

        protected form = new DesiccantForm(this.idPrefix);

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
                var res = DesiccantService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DesiccantRow.Fields.DesiccantId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in Bottle
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }

    }
}