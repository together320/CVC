
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class ListDisplayDialog extends Serenity.EntityDialog<ListDisplayRow, any> {
        protected getFormKey() { return ListDisplayForm.formKey; }
        protected getIdProperty() { return ListDisplayRow.idProperty; }
        protected getLocalTextPrefix() { return ListDisplayRow.localTextPrefix; }
        protected getNameProperty() { return ListDisplayRow.nameProperty; }
        protected getService() { return ListDisplayService.baseUrl; }
        protected getDeletePermission() { return ListDisplayRow.deletePermission; }
        protected getInsertPermission() { return ListDisplayRow.insertPermission; }
        protected getUpdatePermission() { return ListDisplayRow.updatePermission; }

        protected form = new ListDisplayForm(this.idPrefix);

        constructor() {
            super();

            /* added by Denis for RS 6.5 dated 8/5/2021
             * There cannot be more than one ListDisplay with the same ViewId
             * **/
            /*this.form.ViewId.addValidationRule(this.uniqueName, e => {
                var listDisplayId = this.form.ListDisplayId.value;
                var viewId = this.form.ViewId.value;
                var res = ListDisplayService.List({
                    Criteria: null,
                    ColumnSelection: 1,
                    IncludeColumns: ["ViewId"]
                }, response => {

                }, {
                    async: false
                });

                var existOne = Q.tryFirst(res.responseJSON.Entities, ({ ViewId }) => ViewId === Q.toId(viewId))
                if (existOne) {
                    if (existOne['ListDisplayId'] !== listDisplayId) {
                        Q.alert("The properties of the selected Display Object already exist.");
                        return "The properties of the selected Display Object already exist.";
                    }
                }
            });*/
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();
            /*
             * isNew() function works properly in afterLoadEntity() function
             * **/
            if (!this.isNew()) {
                var criteria: any;
                var res = DisplayObjectService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectRow.Fields.ListDisplayId], '=', this.entityId])
                }, _response => { }, { async: false });
                // Cannot delete the entity if it is already referenced in DisplayObject.
                if (res.responseJSON.Entities.length) {
                    this.toolbar.findButton("delete-button").remove()
                }
            }
        }
    }
}