
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class PrimaryRelationshipDialog extends Serenity.EntityDialog<PrimaryRelationshipRow, any> {
        protected getFormKey() { return PrimaryRelationshipForm.formKey; }
        protected getIdProperty() { return PrimaryRelationshipRow.idProperty; }
        protected getLocalTextPrefix() { return PrimaryRelationshipRow.localTextPrefix; }
        protected getNameProperty() { return PrimaryRelationshipRow.nameProperty; }
        protected getService() { return PrimaryRelationshipService.baseUrl; }
        protected getDeletePermission() { return PrimaryRelationshipRow.deletePermission; }
        protected getInsertPermission() { return PrimaryRelationshipRow.insertPermission; }
        protected getUpdatePermission() { return PrimaryRelationshipRow.updatePermission; }

        protected form = new PrimaryRelationshipForm(this.idPrefix);

        protected getToolbarButtons() {
            var buttons = super.getToolbarButtons();
            Q.first(buttons, x => x.cssClass == "delete-button").onClick = () => {
                var criteria: any;
                var res = SecondaryRelationshipService.List({
                    Criteria: Serenity.Criteria.and(criteria, [[SecondaryRelationshipRow.Fields.PrimaryRelationshipId], '=', this.entityId])
                }, _response => { }, { async: false });

                var secondaryRelationshipCount = res.responseJSON.TotalCount;

                if (secondaryRelationshipCount) {
                    Q.alert(`There are ${secondaryRelationshipCount} Secondary Relationships under the selected Primary Relationship.
You can not delete the Primary Relationship until there are no Secondary Relationships under it.
                    `);
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

    }
}