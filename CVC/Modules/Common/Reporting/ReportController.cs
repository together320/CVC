// Decompiled with JetBrains decompiler
// Type: CVC.ReportController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Newtonsoft.Json;
using Serenity;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Security;

namespace CVC
{
  [RoutePrefix("Report")]
  [Route("{action=index}")]
  public class ReportController : Controller
  {
    public ActionResult Render(string key, string opt, string ext, int? print = 0)
    {
      string key1 = key;
      string opt1 = opt;
      string ext1 = ext;
      int num1 = 0;
      int? nullable = print;
      int num2 = 0;
      int num3 = nullable.GetValueOrDefault() == num2 ? (!nullable.HasValue ? 1 : 0) : 1;
      return this.Execute(key1, opt1, ext1, num1 != 0, num3 != 0);
    }

    public ActionResult Download(string key, string opt, string ext)
    {
      return this.Execute(key, opt, ext, true, true);
    }

    private ActionResult Execute(string key, string opt, string ext, bool download, bool printing)
    {
      if (key.IsEmptyOrNull())
        throw new ArgumentNullException("reportKey");
      ReportRegistry.Report report1 = ReportRegistry.GetReport(key);
      if (report1 == null)
        throw new ArgumentOutOfRangeException("reportKey");
      if (report1.Permission != null)
        Authorization.ValidatePermission(report1.Permission);
      IReport report2 = (IReport) JsonConvert.DeserializeObject(opt.TrimToNull() ?? "{}", report1.Type, JsonSettings.Tolerant);
      byte[] renderedBytes = (byte[]) null;
      if (report2 is IDataOnlyReport)
      {
        ext = "xlsx";
        renderedBytes = new ReportRepository().Render((IDataOnlyReport) report2);
      }
      else
      {
        ext = (ext ?? "html").ToLowerInvariant();
        if (ext == "htm" || ext == "html")
        {
          ActionResult actionResult = this.RenderAsHtml(report2, download, printing, ref renderedBytes);
          if (!download)
            return actionResult;
        }
        else
        {
          if (!(ext == "pdf"))
            throw new ArgumentOutOfRangeException(nameof (ext));
          renderedBytes = this.RenderAsPdf(report2, key, opt);
        }
      }
      return this.PrepareFileResult(report2, ext, download, renderedBytes, report1);
    }

    private ActionResult PrepareFileResult(IReport report, string ext, bool download, byte[] renderedBytes, ReportRegistry.Report reportInfo)
    {
      ICustomFileName customFileName = report as ICustomFileName;
      string fileName = (customFileName == null ? (reportInfo.Title ?? reportInfo.Key) + "_" + DateTime.Now.ToString("yyyyMMdd_HHss") : customFileName.GetFileName()) + "." + ext;
      if (download)
      {
        FileContentResult fileContentResult = new FileContentResult(renderedBytes, "application/octet-stream");
        fileContentResult.FileDownloadName = fileName;
        return (ActionResult) fileContentResult;
      }
      this.Response.AddHeader("Content-Disposition", new ContentDisposition()
      {
        Inline = true,
        FileName = fileName
      }.ToString());
      return (ActionResult) this.File(renderedBytes, UploadHelper.GetMimeType(fileName));
    }

    private byte[] RenderAsPdf(IReport report, string key, string opt)
    {
      string str1 = Serenity.UriHelper.Combine(Config.Get<EnvironmentSettings>().SiteExternalUrl ?? this.Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/"), "Report/Render?key=" + Uri.EscapeDataString(key));
      if (!string.IsNullOrEmpty(opt))
        str1 = str1 + "&opt=" + Uri.EscapeDataString(opt);
      string str2 = str1 + "&print=1";
      HtmlToPdfConverter htmlToPdfConverter = new HtmlToPdfConverter();
      string path = HostingEnvironment.MapPath("~/bin/wkhtmltopdf.exe");
      if (System.IO.File.Exists(path))
        htmlToPdfConverter.UtilityExePath = path;
      htmlToPdfConverter.Url = str2;
      HttpCookie cookie1 = this.Request.Cookies[FormsAuthentication.FormsCookieName];
      if (cookie1 != null)
        htmlToPdfConverter.Cookies[FormsAuthentication.FormsCookieName] = cookie1.Value;
      HttpCookie cookie2 = this.Request.Cookies["LanguagePreference"];
      if (cookie2 != null)
        htmlToPdfConverter.Cookies["LanguagePreference"] = cookie2.Value;
      ICustomizeHtmlToPdf customizeHtmlToPdf = report as ICustomizeHtmlToPdf;
      if (customizeHtmlToPdf != null)
        customizeHtmlToPdf.Customize((IHtmlToPdfOptions) htmlToPdfConverter);
      return htmlToPdfConverter.Execute();
    }

    private ActionResult RenderAsHtml(IReport report, bool download, bool printing, ref byte[] renderedBytes)
    {
      ReportDesignAttribute attribute = report.GetType().GetAttribute<ReportDesignAttribute>(false);
      if (attribute == null)
        throw new Exception(string.Format("Report design attribute for type '{0}' is not found!", (object) report.GetType().FullName));
      object data1 = report.GetData();
      ViewDataDictionary data2 = download ? new ViewDataDictionary(data1) : this.ViewData;
      IReportWithAdditionalData withAdditionalData = report as IReportWithAdditionalData;
      data2["AdditionalData"] = withAdditionalData != null ? (object) withAdditionalData.GetAdditionalData() : (object) new Dictionary<string, object>();
      data2["Printing"] = (object) printing;
      if (!download)
        return (ActionResult) this.View(attribute.Design, data1);
      string s = TemplateHelper.RenderViewToString(attribute.Design, data2);
      renderedBytes = Encoding.UTF8.GetBytes(s);
      return (ActionResult) null;
    }

    [HttpPost]
    [JsonFilter]
    public ActionResult Retrieve(ReportRetrieveRequest request)
    {
      return (ActionResult) this.ExecuteMethod<ReportRetrieveResponse>((Func<ReportRetrieveResponse>) (() => new ReportRepository().Retrieve(request)));
    }
  }
}
