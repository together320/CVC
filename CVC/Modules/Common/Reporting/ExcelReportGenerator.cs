// Decompiled with JetBrains decompiler
// Type: Serenity.Reporting.ExcelReportGenerator
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using Serenity.Data;
using Serenity.Reflection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Serenity.Reporting
{
  public static class ExcelReportGenerator
  {
    private static Type[] DateTimeTypes = new Type[4]
    {
      typeof (DateTime),
      typeof (DateTime?),
      typeof (TimeSpan),
      typeof (TimeSpan?)
    };

    public static byte[] GeneratePackageBytes(List<ReportColumn> columns, IList rows, string sheetName = "Page1", string tableName = "Table1", TableStyles tableStyle = TableStyles.Medium2)
    {
      using (ExcelPackage package = ExcelReportGenerator.GeneratePackage(columns, rows, sheetName, tableName, tableStyle))
        return package.GetAsByteArray();
    }

    public static ExcelPackage GeneratePackage(List<ReportColumn> columns, IList rows, string sheetName = "Page1", string tableName = "Table1", TableStyles tableStyle = TableStyles.Medium2)
    {
      ExcelPackage excelPackage = new ExcelPackage();
      ExcelWorkbook workbook = excelPackage.Workbook;
      ExcelReportGenerator.PopulateSheet(excelPackage.Workbook.Worksheets.Add(sheetName), columns, rows, tableName, tableStyle);
      return excelPackage;
    }

    private static string FixFormatSpecifier(string format, Type dataType)
    {
      if (string.IsNullOrEmpty(format) || format.IndexOf('f') < 0 || Array.IndexOf<Type>(ExcelReportGenerator.DateTimeTypes, dataType) < 0)
        return format;
      return format.Replace('f', '0');
    }

    public static void PopulateSheet(ExcelWorksheet worksheet, List<ReportColumn> columns, IList rows, string tableName = "Table1", TableStyles tableStyle = TableStyles.Medium2)
    {
      if (columns == null)
        throw new ArgumentNullException(nameof (columns));
      if (rows == null)
        throw new ArgumentNullException(nameof (rows));
      Field[] fieldArray1 = (Field[]) null;
      TypeAccessor typeAccessor = (TypeAccessor) null;
      bool[] flagArray = (bool[]) null;
      int count = columns.Count;
      int index1 = count;
      int val1 = rows.Count + 1;
      worksheet.Cells[1, 1, 1, columns.Count].LoadFromArrays((IEnumerable<object[]>) new List<object[]>()
      {
        (object[]) columns.ConvertAll<string>((Converter<ReportColumn, string>) (x => x.Title ?? x.Name)).ToArray()
      });
      List<object[]> objArrayList = new List<object[]>();
      foreach (object row1 in (IEnumerable) rows)
      {
        object[] objArray = new object[count];
        Row row2 = row1 as Row;
        if (row2 != null)
        {
          if (fieldArray1 == null)
          {
            fieldArray1 = new Field[count];
            for (int index2 = 0; index2 < columns.Count; ++index2)
            {
              string name = columns[index2].Name;
              Field[] fieldArray2 = fieldArray1;
              int index3 = index2;
              Field field = row2.FindFieldByPropertyName(name);
              if ((object) field == null)
                field = row2.FindField(name);
              fieldArray2[index3] = field;
            }
          }
        }
        else if (row1 != null && !(row1 is IDictionary) && (!(row1 is IDictionary<string, object>) && typeAccessor == null))
        {
          typeAccessor = TypeAccessor.Create(row1.GetType());
          flagArray = new bool[count];
          for (int index2 = 0; index2 < count; ++index2)
          {
            try
            {
              object obj = typeAccessor[row1, columns[index2].Name];
            }
            catch
            {
              flagArray[index2] = true;
            }
          }
        }
        for (int index2 = 0; index2 < count; ++index2)
        {
          if (row2 != null)
          {
            Field field = fieldArray1[index2];
            if ((object) field != null)
              objArray[index2] = field.AsObject(row2);
          }
          else if (row1 is IDictionary<string, object>)
          {
            string name = columns[index2].Name;
            object obj;
            if ((row1 as IDictionary<string, object>).TryGetValue(name, out obj))
              objArray[index2] = obj;
          }
          else if (row1 is IDictionary)
          {
            string name = columns[index2].Name;
            IDictionary dictionary = row1 as IDictionary;
            if (dictionary.Contains((object) name))
              objArray[index2] = dictionary[(object) name];
          }
          else if (row1 != null && !flagArray[index2])
            objArray[index2] = typeAccessor[row1, columns[index2].Name];
        }
        objArrayList.Add(objArray);
      }
      if (rows.Count > 0)
        worksheet.Cells[2, 1, val1, index1].LoadFromArrays((IEnumerable<object[]>) objArrayList);
      ExcelRange cell1 = worksheet.Cells[1, 1, val1, index1];
      worksheet.Tables.Add((ExcelAddressBase) cell1, tableName).TableStyle = tableStyle;
      for (int col = 1; col <= index1; ++col)
      {
        ReportColumn column = columns[col - 1];
        if (!column.Format.IsEmptyOrNull())
          worksheet.Column(col).Style.Numberformat.Format = ExcelReportGenerator.FixFormatSpecifier(column.Format, column.DataType);
      }
      worksheet.Cells[1, 1, Math.Min(val1, 250), index1].AutoFitColumns(1.0, 100.0);
      for (int index2 = 1; index2 <= index1; ++index2)
      {
        ReportColumn column = columns[index2 - 1];
        ICellDecorator decorator = column.Decorator;
        if (decorator != null)
        {
          for (int index3 = 2; index3 <= val1; ++index3)
          {
            object row1 = rows[index3 - 2];
            Row row2 = row1 as Row;
            decorator.Item = row1;
            decorator.Name = column.Name;
            decorator.Format = (string) null;
            decorator.Background = Color.Empty;
            decorator.Foreground = Color.Empty;
            object objB = (object) null;
            if (row2 != null)
            {
              Field field = fieldArray1[index2 - 1];
              if ((object) field != null)
                objB = field.AsObject(row2);
            }
            else if (row1 is IDictionary<string, object>)
            {
              string name = column.Name;
              if (!(row1 as IDictionary<string, object>).TryGetValue(name, out objB))
                objB = (object) null;
            }
            else if (row1 is IDictionary)
            {
              string name = column.Name;
              IDictionary dictionary = row1 as IDictionary;
              if (dictionary.Contains((object) name))
                objB = dictionary[(object) name];
            }
            else if (row1 != null)
            {
              if (!flagArray[index2 - 1])
                objB = typeAccessor[row1, column.Name];
            }
            else
              continue;
            decorator.Value = objB;
            decorator.Decorate();
            if (decorator.Background != Color.Empty || decorator.Foreground != Color.Empty || (!object.Equals(decorator.Value, objB) || decorator.Format != null))
            {
              ExcelRange cell2 = worksheet.Cells[index3, index2];
              if (decorator.Background != Color.Empty)
              {
                cell2.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cell2.Style.Fill.BackgroundColor.SetColor(decorator.Background);
              }
              if (decorator.Foreground != Color.Empty)
                cell2.Style.Font.Color.SetColor(decorator.Foreground);
              if (decorator.Format != null)
                cell2.Style.Numberformat.Format = ExcelReportGenerator.FixFormatSpecifier(decorator.Format, column.DataType);
              if (!object.Equals(decorator.Value, objB))
                cell2.Value = decorator.Value;
            }
          }
        }
      }
    }
  }
}
