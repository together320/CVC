namespace CVC.PackSettings {
    @Serenity.Decorators.registerClass()
    export class CapDialog extends Serenity.EntityDialog<CapRow, any> {
        protected getFormKey() { return CapForm.formKey; }
        protected getIdProperty() { return CapRow.idProperty; }
        protected getLocalTextPrefix() { return CapRow.localTextPrefix; }
        protected getNameProperty() { return CapRow.nameProperty; }
        protected getService() { return CapService.baseUrl; }
        protected getDeletePermission() { return CapRow.deletePermission; }
        protected getInsertPermission() { return CapRow.insertPermission; }
        protected getUpdatePermission() { return CapRow.updatePermission; }

        protected form = new CapForm(this.idPrefix);

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
                var res = CapService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[CapRow.Fields.CapId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in Bottle
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }

    }
}