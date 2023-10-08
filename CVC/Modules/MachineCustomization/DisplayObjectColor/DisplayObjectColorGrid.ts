
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class DisplayObjectColorGrid extends Serenity.EntityGrid<DisplayObjectColorRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.DisplayObjectColor'; }
        protected getDialogType() { return DisplayObjectColorDialog; }
        protected getIdProperty() { return DisplayObjectColorRow.idProperty; }
        protected getInsertPermission() { return DisplayObjectColorRow.insertPermission; }
        protected getLocalTextPrefix() { return DisplayObjectColorRow.localTextPrefix; }
        protected getService() { return DisplayObjectColorService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}