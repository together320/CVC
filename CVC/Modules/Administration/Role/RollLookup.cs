using Serenity.ComponentModel;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CVC.Administration.Entities;
using Serenity.Data;
using Serenity;

namespace CVC.Modules.Administration.Role
{

    [LookupScript("RollLookup", Permission = "Lookup")]
    public class RollLookup : RowLookupScript<RoleRow>
    {
        public RollLookup()
        {
            this.IdField = "RoleId";
            this.TextField = "RoleName";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            RoleRow.RowFields fields = RoleRow.Fields;
            query.Distinct(true).Select((IField)fields.RoleId,(IField)fields.RoleName).Where(new Criteria(fields.RoleId) != 1);
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}