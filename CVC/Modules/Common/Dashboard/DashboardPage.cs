// Decompiled with JetBrains decompiler
// Type: CVC.Common.Pages.DashboardController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data;
using CVC.Data.EDMX;
using System.Web.Mvc;

namespace CVC.Common.Pages
{
  [RoutePrefix("Common/Dashboard")]
  [Route("{action=index}")]
  public class DashboardController : Controller
  {
    [Authorize]
    [HttpGet]
    [Route("~/")]
    public ActionResult Index()
    {
      MachineLine machineLine1 = new MachineLine();
      BatchDTO batchDto = new BatchDTO();
      MachineLine machineLine2;
      if (this.Session["PackageLineId"] == null)
      {
        machineLine2 = CVCDaoFactory.GetMachineLine();
        if (machineLine2 != null)
        {
          this.Session["PackageLineId"] = (object) machineLine2.MachineLineId;
          this.Session["PackageLine"] = (object) machineLine2;
        }
      }
      else
        machineLine2 = (MachineLine) this.Session["PackageLine"];
      if (this.Session["BatchId"] == null)
      {
        BatchDTO batchDetails = CVCDaoFactory.GetBatchDetails();
        if (batchDetails != null)
        {
          this.Session["BatchId"] = (object) batchDetails.BatchId;
          this.Session["Batch"] = (object) batchDetails;
        }
      }
      else
        batchDto = (BatchDTO) this.Session["Batch"];
      return (ActionResult) this.View("~/Modules/Common/Dashboard/DashboardIndex.cshtml", (object) new DashboardPageModel());
    }
  }
}
