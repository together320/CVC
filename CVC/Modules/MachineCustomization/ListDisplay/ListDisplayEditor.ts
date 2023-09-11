/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace CVC.MachineCustomization {

    @Serenity.Decorators.registerClass()
    export class ListDisplayEditor extends Common.GridEditorBase<ListDisplayRow> {
        protected getColumnsKey() { return 'MachineCustomization.ListDisplayEditor'; }
        protected getDialogType() { return ListDisplayEditorDialog; }
        protected getLocalTextPrefix() { return ListDisplayRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        validateEntity(row, id) {
            row.ListDisplayId = Q.toId(row.ListDisplayId);

            var items = this.view.getItems();
            if (items.length) {
                if (this.id(items[0]) !== id) {
                    Q.alert('The properties of the Display Object already exist!');
                    return false;
                }
            }
                
            return true;
        }
    }
}