// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.SupplierRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Configuration.Entities
{
    [ConnectionKey("Default")]
    [TableName("Supplier")]
    [DisplayName("Supplier")]
    [InstanceName("Supplier")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Configuration:Supplier:Read")]
    [ModifyPermission("Configuration:Supplier:Modify")]
    [LookupScript("Configuration.Supplier", Permission = "Lookup")]
    public sealed class SupplierRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly SupplierRow.RowFields Fields = new SupplierRow.RowFields().Init<SupplierRow.RowFields>();

        [DisplayName("Supplier Id")]
        [Identity]
        public int? SupplierId
        {
            get
            {
                return SupplierRow.Fields.SupplierId[(Row)this];
            }
            set
            {
                SupplierRow.Fields.SupplierId[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Name")]
        [Size(100)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string SupplierName
        {
            get
            {
                return SupplierRow.Fields.SupplierName[(Row)this];
            }
            set
            {
                SupplierRow.Fields.SupplierName[(Row)this] = value;
            }
        }

        [DisplayName("Supplier Address")]
        [Size(1000)]
        [NotNull]
        public string SupplierAddress
        {
            get
            {
                return SupplierRow.Fields.SupplierAddress[(Row)this];
            }
            set
            {
                SupplierRow.Fields.SupplierAddress[(Row)this] = value;
            }
        }

        [DisplayName("City")]
        [ForeignKey("CityDetails", "CityDetailsId")]
        [LeftJoin("jCity")]
        [TextualField("City")]
        [NotNull]
        public int? CityId
        {
            get
            {
                return SupplierRow.Fields.CityId[(Row)this];
            }
            set
            {
                SupplierRow.Fields.CityId[(Row)this] = value;
            }
        }

        [DisplayName("Pin Code")]
        [Size(50)]
        public string PinCode
        {
            get
            {
                return SupplierRow.Fields.PinCode[(Row)this];
            }
            set
            {
                SupplierRow.Fields.PinCode[(Row)this] = value;
            }
        }

        [DisplayName("Mobile Code")]
        [NotNull]
        public int? MobileCode
        {
            get
            {
                return SupplierRow.Fields.MobileCode[(Row)this];
            }
            set
            {
                SupplierRow.Fields.MobileCode[(Row)this] = value;
            }
        }

        [DisplayName("Mobile Number")]
        [NotNull]
        public long? MobileNumber
        {
            get
            {
                return SupplierRow.Fields.MobileNumber[(Row)this];
            }
            set
            {
                SupplierRow.Fields.MobileNumber[(Row)this] = value;
            }
        }

        //[DisplayName("Mobile Number")]
        //[Expression("(MobileCode + ' ' + MobileNumber)")]
        //public string FullMobileNumber
        //{
        //  get
        //  {
        //    return SupplierRow.Fields.FullMobileNumber[(Row) this];
        //  }
        //  set
        //  {
        //    SupplierRow.Fields.FullMobileNumber[(Row) this] = value;
        //  }
        //}

        [DisplayName("Status")]
        [ForeignKey("Status", "StatusId")]
        [LeftJoin("jStatus")]
        [TextualField("StatusStatusName")]
        //To make status as default "Active"
        [DefaultValue(1)]
        [NotNull]
        public int? StatusId
        {
            get
            {
                return SupplierRow.Fields.StatusId[(Row)this];
            }
            set
            {
                SupplierRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        public int? CreatedBy
        {
            get
            {
                return SupplierRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                SupplierRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return SupplierRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                SupplierRow.Fields.CreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        public int? UpdatedBy
        {
            get
            {
                return SupplierRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                SupplierRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return SupplierRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                SupplierRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return SupplierRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                SupplierRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Country")]
        [Expression("jCity.[Country]")]
        public string CityCountry
        {
            get
            {
                return SupplierRow.Fields.CityCountry[(Row)this];
            }
            set
            {
                SupplierRow.Fields.CityCountry[(Row)this] = value;
            }
        }

        [DisplayName("City State")]
        [Expression("jCity.[State]")]
        public string CityState
        {
            get
            {
                return SupplierRow.Fields.CityState[(Row)this];
            }
            set
            {
                SupplierRow.Fields.CityState[(Row)this] = value;
            }
        }

        [DisplayName("City")]
        [Expression("jCity.[City]")]
        public string City
        {
            get
            {
                return SupplierRow.Fields.City[(Row)this];
            }
            set
            {
                SupplierRow.Fields.City[(Row)this] = value;
            }
        }

        [DisplayName("City Status Id")]
        [Expression("jCity.[StatusId]")]
        public int? CityStatusId
        {
            get
            {
                return SupplierRow.Fields.CityStatusId[(Row)this];
            }
            set
            {
                SupplierRow.Fields.CityStatusId[(Row)this] = value;
            }
        }

        [DisplayName("City Created By")]
        [Expression("jCity.[CreatedBy]")]
        public int? CityCreatedBy
        {
            get
            {
                return SupplierRow.Fields.CityCreatedBy[(Row)this];
            }
            set
            {
                SupplierRow.Fields.CityCreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("City Created Date")]
        [Expression("jCity.[CreatedDate]")]
        public DateTime? CityCreatedDate
        {
            get
            {
                return SupplierRow.Fields.CityCreatedDate[(Row)this];
            }
            set
            {
                SupplierRow.Fields.CityCreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("City Updated By")]
        [Expression("jCity.[UpdatedBy]")]
        public int? CityUpdatedBy
        {
            get
            {
                return SupplierRow.Fields.CityUpdatedBy[(Row)this];
            }
            set
            {
                SupplierRow.Fields.CityUpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("City Updated Date")]
        [Expression("jCity.[UpdatedDate]")]
        public DateTime? CityUpdatedDate
        {
            get
            {
                return SupplierRow.Fields.CityUpdatedDate[(Row)this];
            }
            set
            {
                SupplierRow.Fields.CityUpdatedDate[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return SupplierRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                SupplierRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)SupplierRow.Fields.SupplierId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return SupplierRow.Fields.SupplierName;
            }
        }

        public SupplierRow()
          : base((RowFieldsBase)SupplierRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields

        // public class RowFields : RowFieldsBase
        {
            public Int32Field SupplierId;
            public StringField SupplierName;
            public StringField SupplierAddress;
            public Int32Field CityId;
            public StringField PinCode;
            public Int32Field MobileCode;
            public Int64Field MobileNumber;
            public Int32Field StatusId;
            /*public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;*/
            public StringField StatusStatusName;
            //public StringField FullMobileNumber;
            public StringField CityCountry;
            public StringField CityState;
            public StringField City;
            public Int32Field CityStatusId;
            public Int32Field CityCreatedBy;
            public DateTimeField CityCreatedDate;
            public Int32Field CityUpdatedBy;
            public DateTimeField CityUpdatedDate;
            public StringField RecordAddedSource;



            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.Supplier";
            }
        }
    }
}
