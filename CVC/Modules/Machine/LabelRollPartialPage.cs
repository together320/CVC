// Decompiled with JetBrains decompiler
// Type: CVC.Machine.Pages.RenderViewFieldsController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using AdvancedHMIDrivers;
using CVC.BusinessServices.Common;
using CVC.Data;
using CVC.Data.EDMX;
using CVC.MDB;
using CVC.Modules.Common.Dashboard;
using CVC.Modules.Common.MachineDashboard;
//using CVC.Modules.Machine;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Web.Mvc;
using System.Web.SessionState;

namespace CVC.Machine.Pages
{
    [RoutePrefix("LabelRollPartialPage")]
    [Route("{action=index}")]
    [SessionState(SessionStateBehavior.Disabled)]

    public class LabelRollPartialPageController : Controller
    {

        [Authorize]
        [HttpGet]
        public ActionResult Index(int ModuleId, int ViewId)
        {
            RenderViewFieldsPageModel Model = new RenderViewFieldsPageModel();
            Model.ViewId = ViewId;
            return (ActionResult)this.View("~/Modules/Machine/LabelRollPartialPage.cshtml", (object)Model);

        }




    }
}
