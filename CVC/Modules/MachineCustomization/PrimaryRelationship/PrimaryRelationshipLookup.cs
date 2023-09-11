using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;
using System;

namespace CVC.MachineCustomization.Scripts
{
    [LookupScript("MachineCustomization.PrimaryRelationshipLookup")]
    public class PrimaryRelationshipLookup : RowLookupScript<PrimaryRelationshipRow>
    {
        public PrimaryRelationshipLookup()
        {
            IdField = PrimaryRelationshipRow.Fields.PrimaryRelationshipId.PropertyName;
            TextField = PrimaryRelationshipRow.Fields.RelationshipName.PropertyName;
            Expiration = TimeSpan.FromDays(-1);
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = PrimaryRelationshipRow.Fields;
            query.Distinct(true)
                .Select(fld.PrimaryRelationshipId, fld.RelationshipName);
        }
    }
}