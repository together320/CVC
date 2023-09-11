
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class FormDisplayGrid extends Common.Bases.GridBase<FormDisplayRow, any> {
        protected getColumnsKey() { return 'MachineCustomization.FormDisplay'; }
        protected getDialogType() { return FormDisplayDialog; }
        protected getIdProperty() { return FormDisplayRow.idProperty; }
        protected getInsertPermission() { return FormDisplayRow.insertPermission; }
        protected getLocalTextPrefix() { return FormDisplayRow.localTextPrefix; }
        protected getService() { return FormDisplayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}