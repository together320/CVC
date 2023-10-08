
namespace CVC.MachineCustomization.Entities
{
    using CVC.Modules.Common.BaseClass;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[ListDisplay]")]
    [DisplayName("List Display"), InstanceName("List Display")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("MachineCustomization.ListDisplay")]
    public sealed class ListDisplayRow : Row, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("List Display Id"), Identity]
        public Int32? ListDisplayId
        {
            get { return Fields.ListDisplayId[this]; }
            set { Fields.ListDisplayId[this] = value; }
        }

        [DisplayName("Name"), Size(50), QuickSearch]
        [NotNull]
        public String ListDisplayName
        {
            get { return Fields.ListDisplayName[this]; }
            set { Fields.ListDisplayName[this] = value; }
        }

        [DisplayName("Background Color"), Size(50)]
        public String BackgroundColor
        {
            get { return Fields.BackgroundColor[this]; }
            set { Fields.BackgroundColor[this] = value; }
        }

        [DisplayName("Border Style")]
        public Int32? BorderStyle
        {
            get { return Fields.BorderStyle[this]; }
            set { Fields.BorderStyle[this] = value; }
        }

        [DisplayName("Checkbox")]
        public Boolean? Checkbox
        {
            get { return Fields.Checkbox[this]; }
            set { Fields.Checkbox[this] = value; }
        }

        [DisplayName("Font"), Size(50)]
        public String Font
        {
            get { return Fields.Font[this]; }
            set { Fields.Font[this] = value; }
        }

        [DisplayName("Font Color"), Size(50)]
        public String FontColor
        {
            get { return Fields.FontColor[this]; }
            set { Fields.FontColor[this] = value; }
        }

        [DisplayName("Font Size")]
        public Int32? FontSize
        {
            get { return Fields.FontSize[this]; }
            set { Fields.FontSize[this] = value; }
        }

        [DisplayName("Full Row Select")]
        public Boolean? FullRowSelect
        {
            get { return Fields.FullRowSelect[this]; }
            set { Fields.FullRowSelect[this] = value; }
        }

        [DisplayName("Gridlines")]
        public Boolean? Gridlines
        {
            get { return Fields.Gridlines[this]; }
            set { Fields.Gridlines[this] = value; }
        }

        [DisplayName("Use Wait Cursor On Click")]
        public Boolean? UseWaitCursorOnClick
        {
            get { return Fields.UseWaitCursorOnClick[this]; }
            set { Fields.UseWaitCursorOnClick[this] = value; }
        }

        [DisplayName("Activation")]
        public Int32? Activation
        {
            get { return Fields.Activation[this]; }
            set { Fields.Activation[this] = value; }
        }

        [DisplayName("Alignment")]
        public Int32? Alignment
        {
            get { return Fields.Alignment[this]; }
            set { Fields.Alignment[this] = value; }
        }

        [DisplayName("Sorting Type")]
        public Int32? SortingType
        {
            get { return Fields.SortingType[this]; }
            set { Fields.SortingType[this] = value; }
        }

        [DisplayName("Sort Descending")]
        public Boolean? SortAscDesc
        {
            get { return Fields.SortAscDesc[this]; }
            set { Fields.SortAscDesc[this] = value; }
        }

        [DisplayName("Multi Select")]
        public Boolean? MultiSelect
        {
            get { return Fields.MultiSelect[this]; }
            set { Fields.MultiSelect[this] = value; }
        }

        [DisplayName("Auto Resize")]
        public Boolean? AutoResize
        {
            get { return Fields.AutoResize[this]; }
            set { Fields.AutoResize[this] = value; }
        }

        [DisplayName("Collapsible")]
        public Boolean? Collapsible
        {
            get { return Fields.Collapsible[this]; }
            set { Fields.Collapsible[this] = value; }
        }

        //[DisplayName("Display Object"), ForeignKey("[dbo].[Views]", "ViewsId"), LeftJoin("jView"), TextualField("ViewViewName")]
        //[NotNull]
        //public Int32? ViewId
        //{
        //    get { return Fields.ViewId[this]; }
        //    set { Fields.ViewId[this] = value; }
        //}

        //[DisplayName("Display Object Name"), Expression("jView.[ViewName]")]
        //public String ViewViewName
        //{
        //    get { return Fields.ViewViewName[this]; }
        //    set { Fields.ViewViewName[this] = value; }
        //}

        IIdField IIdRow.IdField
        {
            get { return Fields.ListDisplayId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ListDisplayName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ListDisplayRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ListDisplayId;
            public StringField ListDisplayName;
            public StringField BackgroundColor;
            public Int32Field BorderStyle;
            public BooleanField Checkbox;
            public StringField Font;
            public StringField FontColor;
            public Int32Field FontSize;
            public BooleanField FullRowSelect;
            public BooleanField Gridlines;
            public BooleanField UseWaitCursorOnClick;
            public Int32Field Activation;
            public Int32Field Alignment;
            public Int32Field SortingType;
            public BooleanField SortAscDesc;
            public BooleanField MultiSelect;
            public BooleanField AutoResize;
            public BooleanField Collapsible;
            //public Int32Field ViewId;

            //public StringField ViewViewName;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "MachineCustomization.ListDisplay";
            }
        }
    }
}
