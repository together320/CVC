// added by Denis for RS 8.7 and RS 8.8 dated 9/22/2021
namespace CVC.MachineCustomization {
    @Serenity.Decorators.registerEditor()
    export class SecondaryBELookupEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, any> {
        public primaryRelationshipId: number;
        public includeBE: number;

        constructor(container: JQuery, opt: Serenity.LookupEditorOptions) {
            super(container, opt);
        }

        protected getLookupKey() {
            return "MachineCustomization.Machine";
        }

        protected getItems(lookup: Q.Lookup<any>) {
            var criteria: any;
            var res = SecondaryRelationshipService.List({
                Criteria: Serenity.Criteria.and(criteria, [[SecondaryRelationshipRow.Fields.PrimaryRelationshipId], '=', this.primaryRelationshipId]),
                ColumnSelection: 1,
                IncludeColumns: ["SecondaryBE"]
            }, _response => { }, { async: false });

            // Get used BE ids
            var usedBEs = res.responseJSON.Entities.map(x => x.SecondaryBe);
            usedBEs = usedBEs.filter(x => x != this.includeBE);
            var customLookup = Q.getLookup(this.getLookupKey());
            let items: any = super.getItems(customLookup);

            // The used BEs should be excluded from the dropdown
            items = items.filter(x => !usedBEs.includes(x.MachineId));
            return items;
        }
    }
}