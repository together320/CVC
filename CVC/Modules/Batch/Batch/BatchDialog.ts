namespace CVC.Batch {
    @Serenity.Decorators.registerClass()
    export class BatchDialog extends Serenity.EntityDialog<BatchRow, any> {
        protected getFormKey() { return BatchForm.formKey; }
        protected getIdProperty() { return BatchRow.idProperty; }
        protected getLocalTextPrefix() { return BatchRow.localTextPrefix; }
        protected getNameProperty() { return BatchRow.nameProperty; }
        protected getService() { return BatchService.baseUrl; }
        protected getDeletePermission() { return BatchRow.deletePermission; }
        protected getInsertPermission() { return BatchRow.insertPermission; }
        protected getUpdatePermission() { return BatchRow.updatePermission; }

        protected form = new BatchForm(this.idPrefix);

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
                var res = BatchService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[BatchRow.Fields.BatchId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in Bottle
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }

    }
}