
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class AttachmentDisplayGrid extends Common.Bases.GridBase<AttachmentDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.AttachmentDisplay'; }
        protected getDialogType() { return AttachmentDisplayDialog; }
        protected getIdProperty() { return AttachmentDisplayRow.idProperty; }
        protected getInsertPermission() { return AttachmentDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return AttachmentDisplayRow.localTextPrefix; }
        protected getService() { return AttachmentDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}