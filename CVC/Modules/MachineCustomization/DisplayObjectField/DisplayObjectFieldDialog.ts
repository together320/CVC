
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class DisplayObjectFieldDialog extends Serenity.EntityDialog<DisplayObjectFieldRow, any> {
        protected getFormKey() { return DisplayObjectFieldForm.formKey; }
        protected getIdProperty() { return DisplayObjectFieldRow.idProperty; }
        protected getLocalTextPrefix() { return DisplayObjectFieldRow.localTextPrefix; }
        protected getNameProperty() { return DisplayObjectFieldRow.nameProperty; }
        protected getService() { return DisplayObjectFieldService.baseUrl; }
        protected getDeletePermission() { return DisplayObjectFieldRow.deletePermission; }
        protected getInsertPermission() { return DisplayObjectFieldRow.insertPermission; }
        protected getUpdatePermission() { return DisplayObjectFieldRow.updatePermission; }

        protected form = new DisplayObjectFieldForm(this.idPrefix);
        private sequenceNums: any;

        constructor() {
            super();
            // added by Denis for RS 7 dated 10/5/2021
            this.form.ViewsId.changeSelect2(e => {
                var viewId = this.form.ViewsId.value;
                // Getting MachineId
                if (!viewId) return;
                var res = DisplayObjectService.Retrieve({ EntityId: viewId, ColumnSelection: 1, IncludeColumns: ["MachineId"] }, _response => { }, { async: false });
                var machineId = res.responseJSON.Entity.MachineId;
                // Cascading MachineParameterId lookup editor
                this.form.MachineParameterId.cascadeField = MachineParameterRow.Fields.MachineId;
                this.form.MachineParameterId.cascadeValue = machineId;
                this.form.MachineParameterId.updateItems();
            });

            this.form.IsAuthenticationRequired.change(e => {
                var flag = this.form.IsAuthenticationRequired.value;

                Serenity.EditorUtils.setReadOnly(this.form.Roles, !flag);
                this.form.Roles.element.toggleClass('required', flag);
                Serenity.EditorUtils.setReadOnly(this.form.IsSelectAllRoles, !flag);

                if (!flag) {
                    this.form.Roles.set_value("");
                    this.form.IsSelectAllRoles.value = false;
                }
            });

            this.form.IsSelectAllRoles.change(e => {
                var flag = this.form.IsSelectAllRoles.value;
                if (flag) {
                    var allSelected = this.form.Roles.items.reduce((previousValue, currentValue) => previousValue + currentValue.id + ",", "");
                    this.form.Roles.set_value(allSelected);
                } else {
                    this.form.Roles.set_value("");
                }
            });

            this.sequenceNums = [];
            this.form.Sequence.addValidationRule(this.uniqueName, e => {
                var value = this.form.Sequence.value;
                if (this.sequenceNums.includes(value)) {
                    return "This value already exists";
                }
            });
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();
            var viewId = $("#DisplayObjectId").val();
            if (this.isNew() && viewId) {
                this.form.ViewsId.set_value(viewId);
            }
            Serenity.EditorUtils.setReadOnly(this.form.ViewsId, true);

            if (!this.isNew()) {
                var res = Q.serviceRequest("/NModuleManagement/Module/getSelectedViewField?id=" + this.entityId, {}, _response => { }, { async: false });
                var pickedRoleIds = res.responseJSON.RoleIdsArray;
                this.form.Roles.set_value(pickedRoleIds);
            }

            if (!this.form.IsAuthenticationRequired.value) {
                Serenity.EditorUtils.setReadOnly(this.form.Roles, true);
                this.form.IsSelectAllRoles.value = false;
                Serenity.EditorUtils.setReadOnly(this.form.IsSelectAllRoles, true);
            }

            this.sequenceNums = this.getSequenceNumbers(Q.toId(this.form.ViewsId.value));
            if (!this.isNew()) {
                this.sequenceNums = this.sequenceNums.filter(num => num != this.form.Sequence.value);
            }

            this.form.Roles.element.toggleClass('required', this.form.IsAuthenticationRequired.value);
        }

        protected onSaveSuccess(response) {
            super.onSaveSuccess(response);
            var viewFieldId = response.EntityId;
            var roles = this.form.Roles.value;
            this.addUpdateViewFieldAuthentication(viewFieldId, roles);
        }

        protected getToolbarButtons() {
            var buttons = super.getToolbarButtons();
            Q.first(buttons, x => x.cssClass == "delete-button").onClick = () => {
                Q.confirm('Do you want to delete the record?', () => {
                    this.addUpdateViewFieldAuthentication(this.entityId, "");
                    this.doDelete(() => {
                        this.dialogClose();
                    });
                });
            }
            return buttons;
        }

        private addUpdateViewFieldAuthentication(viewFieldId: number, roles: string) {
            //var res = Q.serviceRequest("/NModuleManagement/Module/AddUpdateViewFieldAuthentication", { ViewFieldId: viewFieldId, RoleIds: roles }, _response => { }, { async: false });
            $.ajax({
                type: "POST",
                url: "/NModuleManagement/Module/AddUpdateViewFieldAuthentication",
                data: { ViewFieldId: viewFieldId, RoleIds: roles },
                async: false
            })
        }

        private getSequenceNumbers(viewFieldId: number): number[] {
            var criteria: any;
            var res = DisplayObjectFieldService.List({
                Criteria: Serenity.Criteria.and(criteria, [[DisplayObjectFieldRow.Fields.ViewsId], '=', viewFieldId])
            }, _response => { }, { async: false });
            return res.responseJSON.Entities.map( obj => obj.Sequence).filter(num => num != null);
        }
    }
}