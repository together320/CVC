
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class ButtonDisplayGrid extends Common.Bases.GridBase<ButtonDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.ButtonDisplay'; }
        protected getDialogType() { return ButtonDisplayDialog; }
        protected getIdProperty() { return ButtonDisplayRow.idProperty; }
        protected getInsertPermission() { return ButtonDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return ButtonDisplayRow.localTextPrefix; }
        protected getService() { return ButtonDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}