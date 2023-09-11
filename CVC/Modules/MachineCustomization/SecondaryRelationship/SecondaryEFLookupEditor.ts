// added by Denis for RS 8.7 and RS 8.8 dated 9/11/2021
namespace CVC.MachineCustomization {
    @Serenity.Decorators.registerEditor()
    export class SecondaryEFLookupEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, any> {
        public primaryRelationshipId: number;
        public secondaryBE: number;
        public includeEF: number;

        constructor(container: JQuery, opt: Serenity.LookupEditorOptions) {
            super(container, opt);
        }

        protected getLookupKey() {
            return "MachineCustomization.MachineParameter";
        }

        protected getItems(lookup: Q.Lookup<any>) {
            var criteria: any;
            var res = SecondaryRelationshipService.List({
                Criteria: Serenity.Criteria.and(criteria,
                    [[SecondaryRelationshipRow.Fields.PrimaryRelationshipId], '=', this.primaryRelationshipId],
                    [[SecondaryRelationshipRow.Fields.SecondaryBe], '=', this.secondaryBE]
                ),
                ColumnSelection: 1,
                IncludeColumns: ["SecondaryEF"]
            }, _response => { }, { async: false });

            // Get used EF ids
            var usedEFs = res.responseJSON.Entities.map(x => x.SecondaryEf);
            usedEFs = usedEFs.filter(x => x != this.includeEF);

            var customLookup = Q.getLookup("MachineCustomization.MachineParameter");
            let items: any = super.getItems(customLookup);

            // The used EFs should be excluded from the dropdown
            items = items.filter(x => Q.toId(x.MachineId) == this.secondaryBE && !usedEFs.includes(x.MachineParameterId));
            return items;
        }
    }
}