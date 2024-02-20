namespace CVC.PackSettings {
    @Serenity.Decorators.registerClass()
    export class EndOfLineDialog extends Serenity.EntityDialog<EndOfLineRow, any> {
        protected getFormKey() { return EndOfLineForm.formKey; }
        protected getIdProperty() { return EndOfLineRow.idProperty; }
        protected getLocalTextPrefix() { return EndOfLineRow.localTextPrefix; }
        protected getNameProperty() { return EndOfLineRow.nameProperty; }
        protected getService() { return EndOfLineService.baseUrl; }
        protected getDeletePermission() { return EndOfLineRow.deletePermission; }
        protected getInsertPermission() { return EndOfLineRow.insertPermission; }
        protected getUpdatePermission() { return EndOfLineRow.updatePermission; }

        protected form = new EndOfLineForm(this.idPrefix);

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
                var res = EndOfLineService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[EndOfLineRow.Fields.EndOfLineId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in Bottle
                // if (res.responseJSON.Entities.length) {
                //     this.toolbar.findButton("delete-button").remove()
                // }
            }
        }

    }
}