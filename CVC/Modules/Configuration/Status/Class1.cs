using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CVC.Modules.Configuration.Status
{
    [ConnectionKey("Default")]
    [TableName("Attribute")]
    [DisplayName("Attribute")]
    [InstanceName("Attribute")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Lookup")]
    [ModifyPermission("Lookup")]
    [LookupScript("Configuration.Status1", Permission = "Lookup")]
    public sealed class Class1Row : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly Class1Row.RowFields Fields = new Class1Row.RowFields().Init<Class1Row.RowFields>();

        [DisplayName("Status Id")]
        [PrimaryKey]
        public int? AttributeId
        {
            get
            {
                return Class1Row.Fields.AttributeId[(Row)this];
            }
            set
            {
                Class1Row.Fields.AttributeId[(Row)this] = value;
            }
        }

        [DisplayName("Name")]
        [Size(20)]
      //  [QuickSearch(SearchType.Auto, -1, false)]
        public string Name
        {
            get
            {
                return Class1Row.Fields.Name[(Row)this];
            }
            set
            {
                Class1Row.Fields.Name[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)Class1Row.Fields.AttributeId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return Class1Row.Fields.Name;
            }
        }

        public Class1Row()
          : base((RowFieldsBase)Class1Row.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field AttributeId;
            public StringField Name;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.Status1";
            }
        }
    }
}


