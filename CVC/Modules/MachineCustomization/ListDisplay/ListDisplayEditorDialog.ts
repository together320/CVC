
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />
namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class ListDisplayEditorDialog extends Common.GridEditorDialog<ListDisplayRow> {
        protected getFormKey() { return ListDisplayEditorForm.formKey; }
        protected getLocalTextPrefix() { return ListDisplayRow.localTextPrefix; }
        protected getNameProperty() { return ListDisplayRow.nameProperty; }

        protected form = new ListDisplayEditorForm(this.idPrefix);

    }
}