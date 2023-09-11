
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class RealtimeParameterDisplayGrid extends Common.Bases.GridBase<RealtimeParameterDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.RealtimeParameterDisplay'; }
        protected getDialogType() { return RealtimeParameterDisplayDialog; }
        protected getIdProperty() { return RealtimeParameterDisplayRow.idProperty; }
        protected getInsertPermission() { return RealtimeParameterDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return RealtimeParameterDisplayRow.localTextPrefix; }
        protected getService() { return RealtimeParameterDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}