// Decompiled with JetBrains decompiler
// Type: CVC.ReportTree
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity;
using Serenity.Reporting;
using System;
using System.Collections.Generic;

namespace CVC
{
  public class ReportTree
  {
    public ReportTree.Category Root { get; set; }

    public ReportTree()
    {
      this.Root = new ReportTree.Category();
    }

    public static ReportTree FromList(IEnumerable<ReportRegistry.Report> reports, string rootPath = null, string categoryOrder = null)
    {
      if (reports == null)
        throw new ArgumentNullException(nameof (reports));
      rootPath = rootPath ?? "";
      categoryOrder = categoryOrder ?? "";
      ReportTree reportTree = new ReportTree();
      Dictionary<string, ReportTree.Category> dictionary = new Dictionary<string, ReportTree.Category>((IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
      foreach (ReportRegistry.Report report in reports)
      {
        ReportTree.Category category;
        if (dictionary.TryGetValue(report.Category.Key ?? "", out category))
        {
          category.Reports.Add(report);
        }
        else
        {
          string[] strArray = (report.Category.Key ?? "Other").Split(new char[1]
          {
            '/'
          }, StringSplitOptions.RemoveEmptyEntries);
          string key1 = "";
          category = (ReportTree.Category) null;
          foreach (string str in strArray)
          {
            string key2 = key1;
            if (key1.Length > 0)
              key1 += "/";
            key1 += str;
            if (key1.Length > rootPath.Length && !dictionary.TryGetValue(key1 ?? "", out category))
            {
              category = new ReportTree.Category();
              category.Key = key1;
              category.Title = ReportRegistry.GetReportCategoryTitle(key1);
              dictionary[key1] = category;
              if (!dictionary.ContainsKey(key2))
                reportTree.Root.SubCategories.Add(category);
              else
                dictionary[key2].SubCategories.Add(category);
            }
          }
          if (category == null)
            reportTree.Root.Reports.Add(report);
          else
            category.Reports.Add(report);
        }
      }
      Dictionary<string, int> order = new Dictionary<string, int>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      int num1 = 0;
      string str1 = categoryOrder;
      char[] chArray = new char[1]{ ';' };
      foreach (string str2 in str1.Split(chArray))
      {
        string index = str2.TrimToNull();
        if (index != null)
          order[index] = num1++;
      }
      Comparison<ReportTree.Category> comparison = (Comparison<ReportTree.Category>) ((x, y) =>
      {
        int num2 = 0;
        if (x.Key != y.Key)
        {
          int? nullable1 = order.ContainsKey(x.Key) ? new int?(order[x.Key]) : new int?();
          int? nullable2 = order.ContainsKey(y.Key) ? new int?(order[y.Key]) : new int?();
          if (nullable1.HasValue && nullable2.HasValue)
            num2 = nullable1.Value - nullable2.Value;
          else if (nullable1.HasValue)
            num2 = -1;
          else if (nullable2.HasValue)
            num2 = 1;
        }
        if (num2 == 0)
          num2 = string.Compare(x.Title, y.Title, StringComparison.CurrentCultureIgnoreCase);
        return num2;
      });
      foreach (ReportTree.Category category in dictionary.Values)
      {
        if (category.SubCategories != null)
          category.SubCategories.Sort(comparison);
      }
      reportTree.Root.SubCategories.Sort(comparison);
      return reportTree;
    }

    public class Category
    {
      public string Key { get; set; }

      public string Title { get; set; }

      public List<ReportTree.Category> SubCategories { get; private set; }

      public List<ReportRegistry.Report> Reports { get; private set; }

      public Category()
      {
        this.SubCategories = new List<ReportTree.Category>();
        this.Reports = new List<ReportRegistry.Report>();
      }
    }
  }
}
