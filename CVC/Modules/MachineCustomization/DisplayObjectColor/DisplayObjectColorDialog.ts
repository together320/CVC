
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class DisplayObjectColorDialog extends Serenity.EntityDialog<DisplayObjectColorRow, any> {
        protected getFormKey() { return DisplayObjectColorForm.formKey; }
        protected getIdProperty() { return DisplayObjectColorRow.idProperty; }
        protected getLocalTextPrefix() { return DisplayObjectColorRow.localTextPrefix; }
        protected getNameProperty() { return DisplayObjectColorRow.nameProperty; }
        protected getService() { return DisplayObjectColorService.baseUrl; }
        protected getDeletePermission() { return DisplayObjectColorRow.deletePermission; }
        protected getInsertPermission() { return DisplayObjectColorRow.insertPermission; }
        protected getUpdatePermission() { return DisplayObjectColorRow.updatePermission; }

        protected form = new DisplayObjectColorForm(this.idPrefix);

    }
}