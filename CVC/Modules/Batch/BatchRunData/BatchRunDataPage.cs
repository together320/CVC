﻿// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Pages.BatchRunDataController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Batch.Pages
{
  [RoutePrefix("Batch/BatchRunData")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (BatchRunDataRow))]
  public class BatchRunDataController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/Batch/BatchRunData/BatchRunDataIndex.cshtml");
    }
  }
}