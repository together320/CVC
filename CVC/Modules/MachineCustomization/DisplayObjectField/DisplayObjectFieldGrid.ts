
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class DisplayObjectFieldGrid extends Common.Bases.GridBase<DisplayObjectFieldRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.DisplayObjectField'; }
        protected getDialogType() { return DisplayObjectFieldDialog; }
        protected getIdProperty() { return DisplayObjectFieldRow.idProperty; }
        protected getInsertPermission() { return DisplayObjectFieldRow.insertPermission; }
        protected getLocalTextPrefix() { return DisplayObjectFieldRow.localTextPrefix; }
        protected getService() { return DisplayObjectFieldService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected onViewSubmit() {
            if (!super.onViewSubmit()) {
                return false;
            }

            var request = this.view.params as Serenity.ListRequest;
            var displayObjectId = parseInt($("#DisplayObjectId").val());
            if (displayObjectId)
                request.EqualityFilter.ViewsId = displayObjectId;
            return true;
        }
    }
}