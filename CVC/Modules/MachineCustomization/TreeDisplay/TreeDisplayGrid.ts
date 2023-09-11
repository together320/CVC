
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class TreeDisplayGrid extends Common.Bases.GridBase<TreeDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.TreeDisplay'; }
        protected getDialogType() { return TreeDisplayDialog; }
        protected getIdProperty() { return TreeDisplayRow.idProperty; }
        protected getInsertPermission() { return TreeDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return TreeDisplayRow.localTextPrefix; }
        protected getService() { return TreeDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}