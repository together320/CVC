
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class DisplayObjectTypeColorDialog extends Serenity.EntityDialog<DisplayObjectTypeColorRow, any> {
        protected getFormKey() { return DisplayObjectTypeColorForm.formKey; }
        protected getIdProperty() { return DisplayObjectTypeColorRow.idProperty; }
        protected getLocalTextPrefix() { return DisplayObjectTypeColorRow.localTextPrefix; }
        protected getNameProperty() { return DisplayObjectTypeColorRow.nameProperty; }
        protected getService() { return DisplayObjectTypeColorService.baseUrl; }
        protected getDeletePermission() { return DisplayObjectTypeColorRow.deletePermission; }
        protected getInsertPermission() { return DisplayObjectTypeColorRow.insertPermission; }
        protected getUpdatePermission() { return DisplayObjectTypeColorRow.updatePermission; }

        protected form = new DisplayObjectTypeColorForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();

            // Your custom initialization logic here

            // Example: Set a default value for a field if it's empty
            var subid = $("#SubTypeId").val();
            var dotid = $("#DisplayObjectTypeId").val();
            console.log("subid ", subid, "dotid ", dotid);
            this.form.SubTypeId.value = parseInt(subid);
            // this.form.SubTypeId.value = 123;
            this.form.DisplayObjectTypeId.value = parseInt(dotid);
            // // this.form.DisplayObjectTypeId.read
            Serenity.EditorUtils.setReadOnly(this.form.DisplayObjectTypeId, true);
            Serenity.EditorUtils.setReadOnly(this.form.SubTypeId, true);
        }

    }
}