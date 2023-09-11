
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class ScreenViewsDialog extends Serenity.EntityDialog<ScreenViewsRow, any> {
        protected getFormKey() { return ScreenViewsForm.formKey; }
        protected getIdProperty() { return ScreenViewsRow.idProperty; }
        protected getLocalTextPrefix() { return ScreenViewsRow.localTextPrefix; }
        protected getNameProperty() { return ScreenViewsRow.nameProperty; }
        protected getService() { return ScreenViewsService.baseUrl; }
        protected getDeletePermission() { return ScreenViewsRow.deletePermission; }
        protected getInsertPermission() { return ScreenViewsRow.insertPermission; }
        protected getUpdatePermission() { return ScreenViewsRow.updatePermission; }

        protected form = new ScreenViewsForm(this.idPrefix);

    }
}