
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class ContainerDisplayGrid extends Common.Bases.GridBase<ContainerDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.ContainerDisplay'; }
        protected getDialogType() { return ContainerDisplayDialog; }
        protected getIdProperty() { return ContainerDisplayRow.idProperty; }
        protected getInsertPermission() { return ContainerDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return ContainerDisplayRow.localTextPrefix; }
        protected getService() { return ContainerDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}