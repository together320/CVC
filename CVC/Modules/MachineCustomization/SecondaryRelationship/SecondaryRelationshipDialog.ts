
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class SecondaryRelationshipDialog extends Serenity.EntityDialog<SecondaryRelationshipRow, any> {
        protected getFormKey() { return SecondaryRelationshipForm.formKey; }
        protected getIdProperty() { return SecondaryRelationshipRow.idProperty; }
        protected getLocalTextPrefix() { return SecondaryRelationshipRow.localTextPrefix; }
        protected getNameProperty() { return SecondaryRelationshipRow.nameProperty; }
        protected getService() { return SecondaryRelationshipService.baseUrl; }
        protected getDeletePermission() { return SecondaryRelationshipRow.deletePermission; }
        protected getInsertPermission() { return SecondaryRelationshipRow.insertPermission; }
        protected getUpdatePermission() { return SecondaryRelationshipRow.updatePermission; }

        protected form = new SecondaryRelationshipForm(this.idPrefix);

        constructor() {
            super();
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();

            //if (this.isNew()) {
                if ($("#PrimaryRelationshipId").val()) {
                    this.form.PrimaryRelationshipId.set_value($("#PrimaryRelationshipId").val());
                    Serenity.EditorUtils.setReadOnly(this.form.PrimaryRelationshipId, true);
                }
            //}
            
            var secondaryBE = this.form.SecondaryBe.value;

            var secondaryEf = null;

            /*
             * [Weird thing]
             * In the below statement, secondaryEf is empty string.
             * So the SecondaryRelationshipService.Retrieve is used to get SecondaryEf **/
            //secondaryEf = this.form.SecondaryEf.value;
            if (!this.isNew()) {
                var res = SecondaryRelationshipService.Retrieve({ EntityId: this.entityId, ColumnSelection: 1, IncludeColumns: ["SecondaryEf"] }, _response => { }, { async: false });
                secondaryEf = res.responseJSON.Entity.SecondaryEf;
            }

            this.form.SecondaryEf.primaryRelationshipId = $("#PrimaryRelationshipId").val();
            this.form.SecondaryEf.secondaryBE = Q.toId(secondaryBE);
            if (!this.isNew() && secondaryEf)
                this.form.SecondaryEf.includeEF = Q.toId(secondaryEf);
            this.form.SecondaryEf.updateItems();
            this.form.SecondaryEf.value = secondaryEf;

            this.form.SecondaryBe.changeSelect2(e => {
                var secondaryBE = this.form.SecondaryBe.value;
                // Clear old value
                this.form.SecondaryEf.value = null;

                this.form.SecondaryEf.primaryRelationshipId = $("#PrimaryRelationshipId").val();
                this.form.SecondaryEf.secondaryBE = Q.toId(secondaryBE);
                this.form.SecondaryEf.updateItems();
            });

            this.form.SecondaryBe.primaryRelationshipId = $("#PrimaryRelationshipId").val();
            this.form.SecondaryBe.includeBE = Q.toId(secondaryBE);
            this.form.SecondaryBe.updateItems();
        }
    }
}