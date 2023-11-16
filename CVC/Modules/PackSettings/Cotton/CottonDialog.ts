namespace CVC.PackSettings {
    @Serenity.Decorators.registerClass()
    export class CottonDialog extends Serenity.EntityDialog<CottonRow, any> {
        protected getFormKey() { return CottonForm.formKey; }
        protected getIdProperty() { return CottonRow.idProperty; }
        protected getLocalTextPrefix() { return CottonRow.localTextPrefix; }
        protected getNameProperty() { return CottonRow.nameProperty; }
        protected getService() { return CottonService.baseUrl; }
        protected getDeletePermission() { return CottonRow.deletePermission; }
        protected getInsertPermission() { return CottonRow.insertPermission; }
        protected getUpdatePermission() { return CottonRow.updatePermission; }

        protected form = new CottonForm(this.idPrefix);

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
                var res = CottonService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[CottonRow.Fields.CottonId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in Bottle
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }

    }
}