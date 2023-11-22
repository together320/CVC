namespace CVC.Configuration {
    @Serenity.Decorators.registerClass()
    export class CompanyDialog extends Serenity.EntityDialog<CompanyRow, any> {
        protected getFormKey() { return CompanyForm.formKey; }
        protected getIdProperty() { return CompanyRow.idProperty; }
        protected getLocalTextPrefix() { return CompanyRow.localTextPrefix; }
        protected getNameProperty() { return CompanyRow.nameProperty; }
        protected getService() { return CompanyService.baseUrl; }
        protected getDeletePermission() { return CompanyRow.deletePermission; }
        protected getInsertPermission() { return CompanyRow.insertPermission; }
        protected getUpdatePermission() { return CompanyRow.updatePermission; }

        protected form = new CompanyForm(this.idPrefix);

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
                var res = CompanyService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[CompanyRow.Fields.CompanyId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in Bottle
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }

    }
}