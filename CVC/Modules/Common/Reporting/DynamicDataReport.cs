// Decompiled with JetBrains decompiler
// Type: Serenity.Reporting.DynamicDataReport
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.PropertyGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Serenity.Reporting
{
  public class DynamicDataReport : IDataOnlyReport, IReport
  {
    public IEnumerable Data { get; private set; }

    public IEnumerable<string> ColumnList { get; set; }

    public Type ColumnsType { get; private set; }

    public DynamicDataReport(IEnumerable data, IEnumerable<string> columnList, Type columnsType)
    {
      if (data == null)
        throw new ArgumentNullException(nameof (data));
      this.Data = data;
      this.ColumnList = columnList ?? (IEnumerable<string>) new List<string>();
      this.ColumnsType = columnsType;
    }

    public object GetData()
    {
      return (object) this.Data;
    }

    public List<ReportColumn> GetColumnList()
    {
      List<ReportColumn> reportColumnList = new List<ReportColumn>();
      if (!this.ColumnList.Any<string>())
        return reportColumnList;
      IDictionary<string, PropertyItem> dictionary1 = (IDictionary<string, PropertyItem>) null;
      IDictionary<string, PropertyInfo> dictionary2 = (IDictionary<string, PropertyInfo>) null;
      Row row = (Row) null;
      if (this.ColumnsType != (Type) null)
      {
        dictionary1 = (IDictionary<string, PropertyItem>) LocalCache.Get<Dictionary<string, PropertyItem>>("DynamicDataReport:Columns:" + this.ColumnsType.FullName, TimeSpan.Zero, (Func<Dictionary<string, PropertyItem>>) (() => PropertyItemHelper.GetPropertyItemsFor(this.ColumnsType).ToDictionary<PropertyItem, string>((Func<PropertyItem, string>) (x => x.Name))));
        dictionary2 = (IDictionary<string, PropertyInfo>) ((IEnumerable<PropertyInfo>) this.ColumnsType.GetProperties()).ToDictionary<PropertyInfo, string>((Func<PropertyInfo, string>) (x => x.Name));
        BasedOnRowAttribute customAttribute = this.ColumnsType.GetCustomAttribute<BasedOnRowAttribute>();
        if (customAttribute != null && customAttribute.RowType != (Type) null && typeof (Row).IsAssignableFrom(customAttribute.RowType))
          row = (Row) Activator.CreateInstance(customAttribute.RowType);
      }
      foreach (string column in this.ColumnList)
      {
        PropertyItem propertyItem;
        if (dictionary1.TryGetValue(column, out propertyItem))
        {
          Field field1;
          if (row != null)
          {
            Field field2 = row.FindField(column);
            field1 = (object) field2 != null ? field2 : row.FindFieldByPropertyName(column);
          }
          else
            field1 = (Field) null;
          Field field3 = field1;
          PropertyInfo property;
          if (dictionary2 == null || !dictionary2.TryGetValue(column, out property))
            property = (PropertyInfo) null;
          reportColumnList.Add(this.FromPropertyItem(propertyItem, field3, property));
        }
      }
      return reportColumnList;
    }

    private ReportColumn FromPropertyItem(PropertyItem item, Field field, PropertyInfo property)
    {
      ReportColumn reportColumn1 = new ReportColumn();
      reportColumn1.Name = item.Name;
      reportColumn1.Title = item.Title ?? item.Name;
      if (reportColumn1.Title != null)
        reportColumn1.Title = LocalText.TryGet(reportColumn1.Title) ?? reportColumn1.Title;
      if (item.Width.HasValue)
      {
        ReportColumn reportColumn2 = reportColumn1;
        int? width = item.Width;
        double? nullable = width.HasValue ? new double?((double) width.GetValueOrDefault()) : new double?();
        reportColumn2.Width = nullable;
      }
      if (!string.IsNullOrWhiteSpace(item.DisplayFormat))
      {
        reportColumn1.Format = item.DisplayFormat;
      }
      else
      {
        //DateTimeField dateTimeField = field as DateTimeField;
        //if (dateTimeField.DateTimeKind != DateTimeKind.Unspecified)
          reportColumn1.Format = "dd/MM/yyyy HH:mm";
        //else if (dateTimeField != null)
        //  reportColumn1.Format = "dd/MM/yyyy";
      }
      IEnumTypeField enumTypeField = field as IEnumTypeField;
      if (enumTypeField != null && enumTypeField.EnumType != (Type) null)
        reportColumn1.Decorator = (ICellDecorator) new EnumDecorator(enumTypeField.EnumType);
      if (property != (PropertyInfo) null)
      {
        CellDecoratorAttribute customAttribute = property.GetCustomAttribute<CellDecoratorAttribute>();
        if (customAttribute != null && customAttribute.DecoratorType != (Type) null)
          reportColumn1.Decorator = (ICellDecorator) Activator.CreateInstance(customAttribute.DecoratorType);
      }
      if ((object) field != null)
      {
        if (reportColumn1.Title == null)
          reportColumn1.Title = field.Title;
        if (!reportColumn1.Width.HasValue && field is StringField && field.Size != 0)
          reportColumn1.Width = new double?((double) field.Size);
      }
      reportColumn1.DataType = (object) field != null ? field.ValueType : (Type) null;
      return reportColumn1;
    }
  }
}
