// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Scripts.CountryLookup
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.MachineCustomization.Entities;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;
using System;

namespace CVC.MachineCustomization.Scripts
{
    [LookupScript("MachineCustomization.MachineLookUp", Permission = "?")]
    public class MachineLookUp : RowLookupScript<MachineRow>
    {
        public MachineLookUp()
        {
            IdField = "MachineId";
            TextField = "MachineName";
            Expiration = TimeSpan.FromDays(-1);
        }
    

        protected override void PrepareQuery(SqlQuery query)
        {

            var fld = MachineRow.Fields.As("fld");
           // var mp = MachinePeriodRow.Fields.As("mp");
           // var mc = MachineCategoryRow.Fields.As("mc");

            query
                .Select(fld.MachineId, fld.MachineName)
                .From(fld)
               // .LeftJoin(mp, new Criteria(mp.MachineId) == new Criteria(fld.MachineId))
               // .LeftJoin(mc, new Criteria(mc.MachineCategoryId) == new Criteria(fld.MachineCategoryId))
                .Where(new Criteria(fld.StatusId) == 1)
                //.Where(new Criteria(mc.MachineCategoryId) == 1)
                //.Where(new Criteria(fld.Obsolete) == 0)
                //.OrderBy(fld.MachineCode, desc: false)
                .Distinct(true);


            //  MachineRow.RowFields fields = MachineRow.Fields;
            // query.Where(new Criteria(fields.StatusId) == 1);
            //// query.Distinct(true).Select((IField)fields.StatusId==1).Where<SqlQuery>((ICriteria)((BaseCriteria)new Criteria((IField)fields.Country) != "" & new Criteria((IField)fields.Country).IsNotNull()));
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}
