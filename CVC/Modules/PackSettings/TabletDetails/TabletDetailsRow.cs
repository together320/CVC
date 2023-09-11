// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Entities.TabletDetailsRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CVC.PackSettings.Entities
{
    [ConnectionKey("Default")]
    [TableName("TabletDetails")]
    [DisplayName("Product Details")]
    [InstanceName("Product Details")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("PackSettings:TabletDetails:Read")]
    [ModifyPermission("PackSettings:TabletDetails:Modify")]
    [LookupScript("PackSettings.Tablet", Permission = "Lookup")]
    public sealed class TabletDetailsRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly TabletDetailsRow.RowFields Fields = new TabletDetailsRow.RowFields().Init<TabletDetailsRow.RowFields>();

        [DisplayName("Tablet Details Id")]
        [Identity]
        public int? TabletDetailsId
        {
            get
            {
                return TabletDetailsRow.Fields.TabletDetailsId[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletDetailsId[(Row)this] = value;
            }
        }

        [DisplayName("Product Name")]
        [Size(50)]
        [QuickSearch(SearchType.Auto, -1, false)]
        [NotNull]
        public string TabletName
        {
            get
            {
                return TabletDetailsRow.Fields.TabletName[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletName[(Row)this] = value;
            }
        }

        [DisplayName("Product Strength")]
        [Size(50)]
        //[NotNull]
        public string TabletStrength
        {
            get
            {
                return TabletDetailsRow.Fields.TabletStrength[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletStrength[(Row)this] = value;
            }
        }

        [DisplayName("Product Type")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jTabletType")]
        [TextualField("TabletTypePickListValueName")]
       // [NotNull]
        public int? TabletTypeId
        {
            get
            {
                return TabletDetailsRow.Fields.TabletTypeId[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletTypeId[(Row)this] = value;
            }
        }

        [DisplayName("Product Type")]
        [Expression("jTabletType.[PickListValueName]")]
        public string TabletTypePickListValueName
        {
            get
            {
                return TabletDetailsRow.Fields.TabletTypePickListValueName[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletTypePickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("Product Type Status Id")]
        [Expression("jTabletType.[StatusId]")]
        public int? TabletTypeStatusId
        {
            get
            {
                return TabletDetailsRow.Fields.TabletTypeStatusId[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletTypeStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Characteristics One")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jTabletCharOne")]
        [TextualField("TabletCharOnePickListValueName")]
       // [NotNull]
        public int? TabletCharOneId
        {
            get
            {
                return TabletDetailsRow.Fields.TabletCharOneId[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletCharOneId[(Row)this] = value;
            }
        }

        [DisplayName("Characteristics One")]
        [Expression("jTabletCharOne.[PickListValueName]")]
        public string TabletCharOnePickListValueName
        {
            get
            {
                return TabletDetailsRow.Fields.TabletCharOnePickListValueName[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletCharOnePickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("TabletCharOne Status Id")]
        [Expression("jTabletCharOne.[StatusId]")]
        public int? TabletCharOneStatusId
        {
            get
            {
                return TabletDetailsRow.Fields.TabletCharOneStatusId[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletCharOneStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Characteristics Two")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jTabletCharTwoId")]
        [TextualField("TabletCharTwoIdPickListValueName")]
        //[NotNull]
        public int? TabletCharTwoId
        {
            get
            {
                return TabletDetailsRow.Fields.TabletCharTwoId[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletCharTwoId[(Row)this] = value;
            }
        }

        [DisplayName("Characteristics Two")]
        [Expression("jTabletCharTwoId.[PickListValueName]")]
        public string TabletCharTwoPickListValueName
        {
            get
            {
                return TabletDetailsRow.Fields.TabletCharTwoPickListValueName[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletCharTwoPickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("TabletCharTwoId Status Id")]
        [Expression("jTabletCharTwoId.[StatusId]")]
        public int? TabletCharTwoStatusId
        {
            get
            {
                return TabletDetailsRow.Fields.TabletCharTwoStatusId[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletCharTwoStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Product Shape Id")]
        [ForeignKey("PickListValue", "PickListValueId")]
        [LeftJoin("jTabletShape")]
        [TextualField("TabletShapePickListValueName")]
        //[NotNull]
        public int? TabletShapeId
        {
            get
            {
                return TabletDetailsRow.Fields.TabletShapeId[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletShapeId[(Row)this] = value;
            }
        }

        [DisplayName("Product Shape")]
        [Expression("jTabletShape.[PickListValueName]")]
        public string TabletShapePickListValueName
        {
            get
            {
                return TabletDetailsRow.Fields.TabletShapePickListValueName[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletShapePickListValueName[(Row)this] = value;
            }
        }

        [DisplayName("TabletShape Status Id")]
        [Expression("jTabletShape.[StatusId]")]
        public int? TabletShapeStatusId
        {
            get
            {
                return TabletDetailsRow.Fields.TabletShapeStatusId[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletShapeStatusId[(Row)this] = value;
            }
        }

        [DisplayName("Product Length")]
        [Size(50)]
      //  [NotNull]
        public string TabletLength
        {
            get
            {
                return TabletDetailsRow.Fields.TabletLength[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletLength[(Row)this] = value;
            }
        }

        [DisplayName("Product Thickness")]
        [Size(50)]
      //  [NotNull]
        public string TabletThickness
        {
            get
            {
                return TabletDetailsRow.Fields.TabletThickness[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletThickness[(Row)this] = value;
            }
        }

        [DisplayName("Product Width")]
        [Size(50)]
     //   [NotNull]
        public string TabletWidth
        {
            get
            {
                return TabletDetailsRow.Fields.TabletWidth[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.TabletWidth[(Row)this] = value;
            }
        }

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
                return TabletDetailsRow.Fields.StatusId[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return TabletDetailsRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return TabletDetailsRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                TabletDetailsRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)TabletDetailsRow.Fields.TabletDetailsId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return TabletDetailsRow.Fields.TabletName;
            }
        }

        public TabletDetailsRow()
          : base((RowFieldsBase)TabletDetailsRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field TabletDetailsId;
            public StringField TabletName;
            public StringField TabletStrength;
            public Int32Field TabletTypeId;
            public Int32Field TabletCharOneId;
            public Int32Field TabletCharTwoId;
            public Int32Field TabletShapeId;
            public StringField TabletLength;
            public StringField TabletThickness;
            public StringField TabletWidth;
            public Int32Field StatusId;
            public StringField StatusStatusName;
            public StringField TabletTypePickListValueName;
            public Int32Field TabletTypeStatusId;
            public StringField TabletCharOnePickListValueName;
            public Int32Field TabletCharOneStatusId;
            public StringField TabletCharTwoPickListValueName;
            public Int32Field TabletCharTwoStatusId;
            public StringField TabletShapePickListValueName;
            public Int32Field TabletShapeStatusId;
            public StringField RecordAddedSource;

            public RowFields()
              : base((string)null, (string)null)
            {
                this.LocalTextPrefix = "PackSettings.TabletDetails";
            }
        }
    }
}
