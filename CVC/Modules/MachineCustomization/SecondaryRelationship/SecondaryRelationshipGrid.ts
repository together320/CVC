
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class SecondaryRelationshipGrid extends Common.Bases.GridBase<SecondaryRelationshipRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.SecondaryRelationship'; }
        protected getDialogType() { return SecondaryRelationshipDialog; }
        protected getIdProperty() { return SecondaryRelationshipRow.idProperty; }
        protected getInsertPermission() { return SecondaryRelationshipRow.insertPermission; }
        protected getLocalTextPrefix() { return SecondaryRelationshipRow.localTextPrefix; }
        protected getService() { return SecondaryRelationshipService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected onViewSubmit() {
            if (!super.onViewSubmit()) {
                return false;
            }

            var request = this.view.params as Serenity.ListRequest;
            var primaryId = parseInt($("#PrimaryRelationshipId").val());
            //$("#PrimaryRelationshipId").val("");
            if (primaryId)
                request.EqualityFilter.PrimaryRelationshipId = primaryId;
            return true;
        }
    }
}