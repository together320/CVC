namespace CVC.MachineCustomization {
    @Serenity.Decorators.registerEditor()
    export class PrimaryRelationshipLookupEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, any> {
        constructor(container: JQuery, opt: Serenity.LookupEditorOptions) {
            super(container, opt);
        }

        protected getLookupKey() {
            return "MachineCustomization.PrimaryRelationship";
            //return "MachineCustomization.PrimaryRelationshipLookup";
        }

        protected getItems(lookup: Q.Lookup<any>) {
            var customLookup = Q.getLookup(this.getLookupKey());
            let items: any = super.getItems(customLookup);

            /*
             * I tried to show lookup without caching by adding Expiration = TimeSpan.FromDays(-1) 
             * but no luck.
             * so decided to use below service call
             * **/
            var res = PrimaryRelationshipService.List(
                {
                    ColumnSelection: 1,
                    IncludeColumns: ["PrimaryRelationshipId", "RelationshipName"]
                },
                _response => { },
                { async: false }
            );

            var itms = res.responseJSON.Entities;
            return itms;
        }
    }
}