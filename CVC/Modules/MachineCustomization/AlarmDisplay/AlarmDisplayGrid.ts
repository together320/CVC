
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class AlarmDisplayGrid extends Common.Bases.GridBase<AlarmDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.AlarmDisplay'; }
        protected getDialogType() { return AlarmDisplayDialog; }
        protected getIdProperty() { return AlarmDisplayRow.idProperty; }
        protected getInsertPermission() { return AlarmDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return AlarmDisplayRow.localTextPrefix; }
        protected getService() { return AlarmDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}