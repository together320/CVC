// Decompiled with JetBrains decompiler
// Type: CVC.ReportRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using OfficeOpenXml.Table;
using Serenity;
using Serenity.PropertyGrid;
using Serenity.Reporting;
using Serenity.Services;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CVC
{
  public class ReportRepository
  {
    public byte[] Render(IDataOnlyReport report)
    {
      List<ReportColumn> columnList = report.GetColumnList();
      List<object> objectList = new List<object>();
      object data = report.GetData();
      IEnumerable enumerable = data as IEnumerable;
      if (enumerable == null)
        enumerable = (IEnumerable) new List<object>()
        {
          data
        };
      foreach (object obj in enumerable)
        objectList.Add(obj);
      return ExcelReportGenerator.GeneratePackageBytes(columnList, (IList) objectList, "Page1", "Table1", TableStyles.Medium2);
    }

    public ReportTree GetReportTree(string category)
    {
      return ReportTree.FromList(ReportRegistry.GetAvailableReportsInCategory(category), category, (string) null);
    }

    public ReportRetrieveResponse Retrieve(ReportRetrieveRequest request)
    {
      request.CheckNotNull();
      if (request.ReportKey.IsEmptyOrNull())
        throw new ArgumentNullException("reportKey");
      ReportRegistry.Report report = ReportRegistry.GetReport(request.ReportKey);
      if (report == null)
        throw new ArgumentOutOfRangeException("reportKey");
      if (report.Permission != null)
        Authorization.ValidatePermission(report.Permission);
      ReportRetrieveResponse retrieveResponse = new ReportRetrieveResponse();
      retrieveResponse.Properties = PropertyItemHelper.GetPropertyItemsFor(report.Type);
      retrieveResponse.ReportKey = report.Key;
      retrieveResponse.Title = report.Title;
      object instance = Activator.CreateInstance(report.Type);
      retrieveResponse.InitialSettings = instance;
      retrieveResponse.IsDataOnlyReport = instance is IDataOnlyReport;
      return retrieveResponse;
    }
  }
}
