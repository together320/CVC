
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class DisplayObjectDialog extends Serenity.EntityDialog<DisplayObjectRow, any> {
        protected getFormKey() { return DisplayObjectForm.formKey; }
        protected getIdProperty() { return DisplayObjectRow.idProperty; }
        protected getLocalTextPrefix() { return DisplayObjectRow.localTextPrefix; }
        protected getNameProperty() { return DisplayObjectRow.nameProperty; }
        protected getService() { return DisplayObjectService.baseUrl; }
        protected getDeletePermission() { return DisplayObjectRow.deletePermission; }
        protected getInsertPermission() { return DisplayObjectRow.insertPermission; }
        protected getUpdatePermission() { return DisplayObjectRow.updatePermission; }

        protected form = new DisplayObjectForm(this.idPrefix);

        constructor() {
            super();
            this.form.DisplayObjectTypeId.changeSelect2(e => {
                var value = this.form.DisplayObjectTypeId.value;
                var doTypeLookup = CVC.Common.CustomEditors.DOTypeLookup;
                doTypeLookup.forEach(item => {
                    this.form[item.field]?.getGridField().toggle(false);
                    this.form[item.field]?.element.toggleClass('required', false);
                });

                // Show the dropdown for the selected Display Object Type
                var item = Q.tryFirst(doTypeLookup, x => x.id === value);
                this.form[item?.field]?.getGridField().toggle(true);
                this.form[item?.field]?.element.toggleClass('required', true);
            });
        }

        protected getToolbarButtons() {
            var buttons = super.getToolbarButtons();
            Q.first(buttons, x => x.cssClass == "delete-button").onClick = () => {
                var isDOFs = this.checkDisplayObjectFields(this.entityId);

                if (isDOFs) {
                    Q.alert("The Display Object cannot be deleted because there are Display Object Fields that belongs to the Display Object");
                } else {
                    Q.confirm('Do you want to delete the record?', () => {
                        this.doDelete(() => {
                            this.dialogClose();
                        });
                    });
                }
            }

            return buttons;
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();

            var isDOFs = this.checkDisplayObjectFields(this.entityId);
            if (isDOFs)
                Serenity.EditorUtils.setReadOnly(this.form.MachineId, true);
        }

        // Check whether display object fields that belongs to certain display object exist or not
        private checkDisplayObjectFields(displayObjectId: number): boolean {
            var criteria: any;
            var res = DisplayObjectFieldService.List({
                Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectFieldRow.Fields.ViewsId], '=', displayObjectId])
            }, _response => { }, { async: false });

            return res.responseJSON.TotalCount ? true : false;
        }
    }
}