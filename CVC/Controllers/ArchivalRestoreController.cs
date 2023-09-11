using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVC.BusinessServices.Common;
using CVC.ViewModels;
using System.IO;
using Serenity.Web;
using CVC.Configuration.Entities;
using System.Reflection;

namespace CVC.Controllers
{
    [RoutePrefix("Archival")]
    [Route("{action=index}")]
  
    [PageAuthorize(typeof(DataBaseArchivalRow))]
    public class ArchivalRestoreController : Controller
    {
        CommonServices objCommonServices = new CommonServices();

        // GET: Archival
        public ActionResult Index()
        {
            ArchivalViewModel objArchivalViewModel = new ArchivalViewModel();
            objArchivalViewModel.StatusId = (int)ClsConstants.StatusType.Active;
            ViewBag.MachineList = objCommonServices.GetAllMachine(objArchivalViewModel.StatusId);
            var LastPeriodRetained = objCommonServices.GetEnvironmentVaiableDetails();
            DateTime OneYearAgoToday = DateTime.Now.AddDays(-(int)LastPeriodRetained.LastPeriodRetained);
            ViewBag.EndDate = OneYearAgoToday.ToString("yyyy-MM-dd");
          
           return View(objArchivalViewModel);
        }

        #region Code for Archive Data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Archive(ArchivalViewModel objArchivalViewModel)
        {
            objArchivalViewModel.StatusId = (int)ClsConstants.StatusType.Active;
            objCommonServices.GetArchiveData(objArchivalViewModel);
            TempData["Message"] = "Data Archived Successfully";
            TempData.Keep("Message");
            return RedirectToAction("Index");
        }
        #endregion

        #region Code for Restore Data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Restore(List<HttpPostedFileBase> FileUploadArchive, HttpPostedFileBase FileUploadMiscellaneous)
        {
            var ArchivalPath = Server.MapPath(ClsConstants.UploadArchivalFolderPath.UploadArchivalPath);
            var MiscellaneousPath = Server.MapPath(ClsConstants.UploadArchivalFolderPath.UploadMiscellaneousPath);
            var TruncateAuditLogTable = false;
            if (!Directory.Exists(ArchivalPath))
            {
                Directory.CreateDirectory(ArchivalPath);
            }
            if (FileUploadArchive[0] != null)
            {
                foreach (HttpPostedFileBase postedFile in FileUploadArchive)
                {
                    if (postedFile != null)
                    {
                        string FileName = Path.GetFileName(postedFile.FileName);
                        //ArchivalViewModel objArchivalViewModel = new ArchivalViewModel();
                        //objArchivalViewModel.FileName = FileName;
                        // objCommonServices.RestoreData(objArchivalViewModel);
                        postedFile.SaveAs(ArchivalPath + FileName);
                        if (postedFile.FileName.Contains("AuditLog"))
                        {
                            TruncateAuditLogTable = true;
                        }
                        objCommonServices.ImportExcel(ClsConstants.UploadArchivalFolderPath.UploadArchivalPath, FileName, TruncateAuditLogTable);
                        if ((System.IO.File.Exists(ArchivalPath + FileName)))
                        {
                            System.IO.File.Delete(ArchivalPath + FileName);
                        }
                    }
                }

            }

            if (FileUploadMiscellaneous != null)
            {
                if (!Directory.Exists(MiscellaneousPath))
                {
                    Directory.CreateDirectory(MiscellaneousPath);
                }

                string FileName = Path.GetFileName(FileUploadMiscellaneous.FileName);

                FileUploadMiscellaneous.SaveAs(MiscellaneousPath + FileName);
                objCommonServices.ImportExcel(ClsConstants.UploadArchivalFolderPath.UploadMiscellaneousPath, FileName, TruncateAuditLogTable == true ? false : true);
                if ((System.IO.File.Exists(MiscellaneousPath + FileName)))
                {
                    System.IO.File.Delete(MiscellaneousPath + FileName);
                }
            }

            TempData["Message"] = "Data Restored Successfully";
            TempData.Keep("Message");
            return RedirectToAction("Index");
        }
        #endregion 
    }

}