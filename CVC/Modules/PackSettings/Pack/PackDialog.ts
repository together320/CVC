namespace CVC.PackSettings {
    @Serenity.Decorators.registerClass()
    export class PackDialog extends Serenity.EntityDialog<PackRow, any> {
        protected getFormKey() { return PackForm.formKey; }
        protected getIdProperty() { return PackRow.idProperty; }
        protected getLocalTextPrefix() { return PackRow.localTextPrefix; }
        protected getNameProperty() { return PackRow.nameProperty; }
        protected getService() { return PackService.baseUrl; }
        protected getDeletePermission() { return PackRow.deletePermission; }
        protected getInsertPermission() { return PackRow.insertPermission; }
        protected getUpdatePermission() { return PackRow.updatePermission; }

        protected form = new PackForm(this.idPrefix);

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
                var res = PackService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[PackRow.Fields.PackId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in Bottle
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }

    }
}