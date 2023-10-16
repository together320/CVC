
namespace CVC.MachineCustomization {
    import fld = DisplayObjectTypeColorRow.Fields;
    @Serenity.Decorators.registerClass()
    export class DisplayObjectTypeColorGrid extends Serenity.EntityGrid<DisplayObjectTypeColorRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.DisplayObjectTypeColor'; }
        protected getDialogType() { return DisplayObjectTypeColorDialog; }
        protected getIdProperty() { return DisplayObjectTypeColorRow.idProperty; }
        protected getInsertPermission() { return DisplayObjectTypeColorRow.insertPermission; }
        protected getLocalTextPrefix() { return DisplayObjectTypeColorRow.localTextPrefix; }
        protected getService() { return DisplayObjectTypeColorService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
        protected onViewSubmit() {
            if (!super.onViewSubmit()) {
                return false;
            }

            var request = this.view.params as Serenity.ListRequest;
            var dotId = parseInt($("#DisplayObjectTypeId").val());
            var subId = parseInt($("#SubTypeId").val());
            //$("#PrimaryRelationshipId").val("");
            if (!request.EqualityFilter)
                request.EqualityFilter = {};
            if (dotId) {
                console.log("DisplayObjectTypeColorGrid!!! dotid =", dotId, "subid = ", subId);
                request.EqualityFilter["DisplayObjectTypeId"] = dotId;
                request.EqualityFilter["SubTypeId"] = subId;
            }
            return true;
        }
    }
}