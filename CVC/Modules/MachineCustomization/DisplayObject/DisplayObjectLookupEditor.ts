namespace CVC.MachineCustomization {
    @Serenity.Decorators.registerEditor()
    export class DisplayObjectLookupEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, any> {
        constructor(container: JQuery, opt: Serenity.LookupEditorOptions) {
            super(container, opt);
        }

        protected getLookupKey() {
            return "MachineCustomization.DisplayObject";
        }

        protected getItems(lookup: Q.Lookup<any>) {
            var res = DisplayObjectService.List(
                {
                    ColumnSelection: 1,
                    IncludeColumns: ["ViewsId", "ViewName"]
                },
                _response => { },
                { async: false }
            );

            var items = res.responseJSON.Entities;
            return items;
        }
    }
}