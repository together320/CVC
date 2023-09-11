
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class NotificationDisplayGrid extends Common.Bases.GridBase<NotificationDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.NotificationDisplay'; }
        protected getDialogType() { return NotificationDisplayDialog; }
        protected getIdProperty() { return NotificationDisplayRow.idProperty; }
        protected getInsertPermission() { return NotificationDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return NotificationDisplayRow.localTextPrefix; }
        protected getService() { return NotificationDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}