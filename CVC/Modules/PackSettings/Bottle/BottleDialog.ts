namespace CVC.PackSettings {
    @Serenity.Decorators.registerClass()
    export class BottleDialog extends Serenity.EntityDialog<BottleRow, any> {
        protected getFormKey() { return BottleForm.formKey; }
        protected getIdProperty() { return BottleRow.idProperty; }
        protected getLocalTextPrefix() { return BottleRow.localTextPrefix; }
        protected getNameProperty() { return BottleRow.nameProperty; }
        protected getService() { return BottleService.baseUrl; }
        protected getDeletePermission() { return BottleRow.deletePermission; }
        protected getInsertPermission() { return BottleRow.insertPermission; }
        protected getUpdatePermission() { return BottleRow.updatePermission; }

        protected form = new BottleForm(this.idPrefix);

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
                var res = BottleService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[BottleRow.Fields.BottleId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in Bottle
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }

    }
}