using CVC.BusinessServices.Common;
using CVC.BusinessServices.DAL;
using CVC.Configuration.Endpoints;
using CVC.Configuration.Entities;
using CVC.Configuration.Repositories;
using CVC.ViewModels;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Caching;
using System.Text;
using System.Web;
using System.Web.Mvc;
using static CVC.BusinessServices.Common.ClsConstants;
using static CVC.BusinessServices.Common.ClsEnum;
using ms = CVC.Modules.Common.CommonServices;
namespace CVC.Controllers
{
    [RoutePrefix("ImportFile")]
    [Route("{action=index}")]
    public class ImportFileController : Controller
    {
        ObjectCache cache = MemoryCache.Default;
        ClsCacheConfig clsCacheConfig = new ClsCacheConfig();
        CommonServices objCommonServices = new CommonServices();
        // GET: ImportFile
        public ActionResult Index(string name)
        {
           // ImportFileDAL importFileDAL = new ImportFileDAL();
           // importFileDAL.ClearImportCacheItem();
            //var previousPageUrl = Request?.UrlReferrer?.AbsoluteUri;
            //var absolutePath = Request?.UrlReferrer?.AbsolutePath;

            //if (!string.IsNullOrEmpty(previousPageUrl))
            //{
            //    if (!absolutePath.Contains("ImportFile") && !absolutePath.Contains("UploadedDataView"))
            //    {
            //        clsCacheConfig.AddItemToCache(ClsCacheConfig.CacheKeys.ImportedFilePreviousPageUrl, previousPageUrl);
            //    }
            //}
            TempData.Remove("FailedRecordCount");
            var cacheData = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFilePreviousPageUrl);           
            ViewBag.PreviousPageUrl =cacheData;
            
            clsCacheConfig.AddItemToCache(ClsCacheConfig.CacheKeys.ImportedFileFormName, name);

            ViewBag.FormName = GetFormatedFormName(name);

           // var cachedLoggedUserId = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);
           //objCommonServices.AddToAuditLog($"Import data of {name} form started",name, "", UserId: cachedLoggedUserId);
           // objCommonServices.AddToImportLog($"Import data of {name} form started",cachedLoggedUserId,name);

            return View();
        }

        #region Code for Upload File
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(HttpPostedFileBase fileUploadImport)
        {
            try
            {
                var importFilePath = Server.MapPath(ClsConstants.UploadImportFolderPath.UploadImportPath);

                if (fileUploadImport != null)
                {
                    if (!Directory.Exists(importFilePath))
                    {
                        Directory.CreateDirectory(importFilePath);
                    }

                    string fileName = Path.GetFileName(fileUploadImport.FileName);
                    var getExtension = Path.GetExtension(fileName);
                    var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

                    var currentTime = DateTime.Now.ToString("ddmmyyyyhhmmss");
                    var customeFileName = $"{fileNameWithoutExtension}_{currentTime}{getExtension}";

                    fileUploadImport.SaveAs(importFilePath + customeFileName);

                    TempData["ImportedFileName"] = customeFileName;
                    TempData.Keep("ImportedFileName");
                    clsCacheConfig.AddItemToCache(ClsCacheConfig.CacheKeys.ImportedFileName, customeFileName);


                    var response = new CommonController().GetMessageDetailsById((int)MessageType.FileUploadedSuccessfully);
                    var result = response.Data;

                    TempData["IsStatus"] = ClsExtensionMethods.GetPropValue(result, "IsStatus");
                    TempData["Message"] = $"{fileName} {ClsExtensionMethods.GetPropValue(result, "Data")}";
                    TempData.Keep("IsStatus");
                    TempData.Keep("Message");
                    
                    objCommonServices.AddToImportLog($"{fileName} file uploaded successfully");

                }
            }
            catch (Exception ex)
            {
                //TempData["Message"] = "Error while uploading file";
                //TempData.Keep("Message");
            }
            finally
            {

            }
            var formNameCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileFormName);
           
            return RedirectToAction("Index", new { name = formNameCache });


        }
        #endregion

        [HttpPost]
        public JsonResult BrowseAndUploadNext(int columnHeaderRowNumber)
        {

            var importFilePath = ClsConstants.UploadImportFolderPath.UploadImportPath;
            CommonServices objCommonServices = new CommonServices();
            var fileName = TempData["ImportedFileName"];
            var response = objCommonServices.ReadFileData(importFilePath, Convert.ToString(fileName), columnHeaderRowNumber);
            if (response.Item1)
            {
                var splitFileName=Convert.ToString(fileName).Split(new char[] { '_', '.' });
                objCommonServices.AddToImportLog($"{response.Item2} in uploaded {splitFileName[0]}.{splitFileName[2]} file");
            }
            else
            {
                objCommonServices.AddToImportLog($"{response.Item2}");

            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult UploadedDataView()
        {
            var model = new ImportViewModel();
            var cacheData = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileData);
            if (cacheData != null)
            {
                model.dtUploadedData=cacheData;
            }
            //if (cache.Contains(ClsCacheConfig.CacheKeys.ImportedFildData))
            //{
            //    model.dtUploadedData = (DataTable)(cache.Get(ClsCacheConfig.CacheKeys.ImportedFildData));

            //}
            var previousPageUrlCache= objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFilePreviousPageUrl);
            ViewBag.PreviousPageUrl = previousPageUrlCache;
            var failedRecord = TempData["FailedRecordCount"];
            TempData.Keep("FailedRecordCount");
            var formNameCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileFormName);
            ViewBag.FormName = formNameCache;
            ViewBag.FormattedFormName = GetFormatedFormName(formNameCache);

            return View(model);
        }

        [HttpPost]
        public JsonResult UpdateDataTableCache(int serialNumber, string columnName, string columnValue,int rowIndex)
        {
            try
            {

                string expression;
                expression = $"serialNumber={serialNumber}";
                //ObjectCache cache = MemoryCache.Default;
                DataTable dt = new DataTable();
                //if (cache.Contains(ClsCacheConfig.CacheKeys.ImportedFildData))
                //{
                //    dt = (DataTable)(cache.Get(ClsCacheConfig.CacheKeys.ImportedFildData));
                //}

                var cacheData = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileData);
                if (cacheData != null)
                {
                    dt = cacheData;
                }

                //DataRow[] rows = dt.Select(expression);

                //for (int i = 0; i < rows.Length; i++)
                //{
                //    rows[i][columnName] = columnValue;
                //}

                dt.Rows[rowIndex][columnName] = columnValue;

                if (dt.Rows.Count > 0)
                {
                    //cache.Remove(ClsCacheConfig.CacheKeys.ImportedFildData);
                    //CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                    //cacheItemPolicy.AbsoluteExpiration = ClsCacheConfig.CacheExpiry.CacheExpiryTime;
                    //cache.Add(ClsCacheConfig.CacheKeys.ImportedFildData, dt, cacheItemPolicy);

                    clsCacheConfig.AddItemToCache(ClsCacheConfig.CacheKeys.ImportedFileData, dt);
                }
                objCommonServices.AddToImportLog($"Sr.No. {serialNumber} {columnName} column updated with new value {columnValue}");

                return Json("success", JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult ColumnFieldMappingView()
        {
            DataTable dt = new DataTable();
            var cacheData = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileData);
            if (cacheData != null)
            {
                dt =cacheData;
            }
            ColumnFieldMappingViewModel columnFieldMappingViewModel = new ColumnFieldMappingViewModel();
            List<ColumnFieldMappingList> lstColumnFieldMappingViewModel = new List<ColumnFieldMappingList>();

            if (dt.Rows.Count > 0)
            {
                var count = dt.Columns.Count;
                var i = 1;
                foreach (DataColumn column in dt.Columns)
                {
                    if (column.ColumnName != "serialNumber" && column.ColumnName!="Error Message")
                    {
                        ColumnFieldMappingList coluViewModel = new ColumnFieldMappingList
                        {
                            header = column.ColumnName,
                            row = Convert.ToString(dt.Rows[0][column.ColumnName]),
                            serialNumber = i
                        };
                        lstColumnFieldMappingViewModel.Add(coluViewModel);
                        i++;
                    }
                }

            }

            var cacheDataFormName = clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileFormName);
           

            var formFieldList = objCommonServices.GetEnumList(Convert.ToString(cacheDataFormName));
            var filterExpression = "(*)";

            ViewBag.FormFieldList = formFieldList;
            ViewBag.MandatoryFormFieldsCount = formFieldList?.Where(ffl => ffl.Text.Contains(filterExpression)).Count();
            columnFieldMappingViewModel.lstColumnFieldMappingList = lstColumnFieldMappingViewModel;
            columnFieldMappingViewModel.lstViewModel = formFieldList;

            objCommonServices.AddToImportLog($"Column field mapping done successfully");

            var formNameCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileFormName);
            ViewBag.FormName = formNameCache;
            ViewBag.FormattedFormName = GetFormatedFormName(formNameCache);
            var previousPageUrlCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFilePreviousPageUrl);
            ViewBag.PreviousPageUrl = previousPageUrlCache;


            return View(columnFieldMappingViewModel);
        }

        [HttpPost]
        public ActionResult ImportData(List<ColumnFieldMappingList> lstColumnFieldMappingViewModel)
        {
            try
            {
                if (lstColumnFieldMappingViewModel == null)
                {
                    var columnFieldMappedCacheData = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileColumnFieldMappingList);
                    if (columnFieldMappedCacheData != null)
                    {
                        lstColumnFieldMappingViewModel = columnFieldMappedCacheData;
                    }
                }

                if (lstColumnFieldMappingViewModel.Count > 0)
                {
                    clsCacheConfig.AddItemToCache(ClsCacheConfig.CacheKeys.ImportedFileColumnFieldMappingList, lstColumnFieldMappingViewModel);
                }

                var dtImportedFileData = new DataTable();
                var cacheData = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileData);
                if (cacheData != null)
                {
                    dtImportedFileData = cacheData;
                }

                lstColumnFieldMappingViewModel
                                  .Select(cfm =>
                                  {
                                      cfm.formFieldText = cfm.formFieldText.Replace("(*)", "");
                                      cfm.mappedFieldText = cfm.mappedFieldText.Replace("(*)", "");

                                      return cfm;
                                  }).ToList();
                // lstColumnFieldMappingViewModel = lstColumnFieldMappingViewModel.where((cfm => cfm.formFieldText.Replace("(*)", ""))).ToList();
                DataTable dt = dtImportedFileData.Clone();
                dt = dtImportedFileData.Copy();


                List<string> cols = lstColumnFieldMappingViewModel.Select(cfm => cfm.header).ToList();
                List<string> colsToExclude = new List<string>();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (!cols.Contains(dt.Columns[i].ColumnName))
                    {
                        colsToExclude.Add(dt.Columns[i].ColumnName);
                    }
                }

                foreach (string colName in colsToExclude)
                {
                    if (colName != "serialNumber" && colName!="Error Message")
                        dt.Columns.Remove(colName);
                }


                for (int i = 0; i < dt.Columns.Count; i++)
                //foreach (DataColumn column in dt.Columns)
                {
                    var columnName = dt.Columns[i].ColumnName;
                    //var columnName = column.ColumnName;
                    var columnFieldMappingDetails = lstColumnFieldMappingViewModel.FirstOrDefault(cfm => cfm.header == columnName);
                    if (columnFieldMappingDetails != null)
                    {
                        dt.Columns[columnName].ColumnName = $"{columnFieldMappingDetails.mappedFieldText}1";
                        dt.AcceptChanges();
                    }
                    //else
                    //{
                    //    dt.Columns.Remove(columnName);
                    //    dt.AcceptChanges();
                    //    i = i - 1;
                    //}
                }

                foreach (DataColumn column in dt.Columns)
                {
                    dt.Columns[column.ColumnName].ColumnName = dt.Columns[column.ColumnName].ColumnName.Replace("1", "");
                    dt.AcceptChanges();
                }

                if (dt.Rows.Count > 0)
                {
                    clsCacheConfig.AddItemToCache(ClsCacheConfig.CacheKeys.ImportedFileDataAfterColumnFieldMapping, dt);
                }

                ms.CommonServices commonServices = new ms.CommonServices();
                var result = commonServices.ImportData();


                TempData["SuccededRecordCount"] = result.Item1;
                TempData["FailedRecordCount"] = result.Item2;

                TempData.Keep("SuccededRecordCount");
                TempData.Keep("FailedRecordCount");

                var loggedUserIdCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);
                var formNameCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileFormName);

                if (result.Item1 > 0)
                {
                    objCommonServices.AddToAuditLog($"{formNameCache} data imported successfully.Succeded record={result.Item1},Failed record={result.Item2}", formNameCache, "", UserId: loggedUserIdCache);
                    objCommonServices.AddToImportLog($"{formNameCache} data imported successfully.Succeded record={result.Item1}, Failed record={result.Item2}.");
                }
                else
                {
                    objCommonServices.AddToAuditLog($"{formNameCache} data not imported.Succeded record={result.Item1},Failed record={result.Item2}", formNameCache, "", UserId: loggedUserIdCache);
                    objCommonServices.AddToImportLog($"{formNameCache} data not imported.Succeded record={result.Item1}, Failed record={result.Item2}.");

                }


                return Json("success", JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult SummaryView()
        {
            var succededRecord = TempData["SuccededRecordCount"];
            var failedRecord = TempData["FailedRecordCount"];
            var totalRecord = Convert.ToInt32(succededRecord) + Convert.ToInt32(failedRecord);
            TempData["TotalRecordCount"] = totalRecord;
            TempData.Keep();
            var previousPageUrlCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFilePreviousPageUrl);
            ViewBag.PreviousPageUrl = previousPageUrlCache;
            var formNameCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileFormName);
            ViewBag.FormName = formNameCache;
            ViewBag.FormattedFormName = GetFormatedFormName(formNameCache);
            
            return View();

        }

        public JsonResult DisplayErrorData()
        {
            var dtImportedFileData = new DataTable();
            var dtImportedFileDataAfterColumnFieldMapping = new DataTable();

            var cacheDataOfImportedFile = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileData);
            if (cacheDataOfImportedFile != null)
            {
                dtImportedFileData = cacheDataOfImportedFile;
            }
            var cacheDataAfterColumnFieldMapping = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileDataAfterColumnFieldMapping);
            if (cacheDataAfterColumnFieldMapping != null)
            {
                dtImportedFileDataAfterColumnFieldMapping=cacheDataAfterColumnFieldMapping;
            }


            DataTable dtErrorData = dtImportedFileData.AsEnumerable()
           .Where(ra => dtImportedFileDataAfterColumnFieldMapping.AsEnumerable()
                        .Any(rb => rb.Field<string>("serialNumber") == ra.Field<string>("serialNumber")))
                        .CopyToDataTable();

            

            if (dtErrorData.Rows.Count > 0)
            {
                
                foreach (DataRow row in dtImportedFileDataAfterColumnFieldMapping.Rows)
                {
            
                    var rowsToUpdate =dtErrorData.AsEnumerable().Where(r => r.Field<string>("serialNumber") ==row.ItemArray[0].ToString());
                    foreach(var rows in rowsToUpdate)
                    {
                        rows.SetField("Error Message", row.ItemArray[1].ToString());
                        dtErrorData.AcceptChanges();
                    }
                }
                

                clsCacheConfig.AddItemToCache(ClsCacheConfig.CacheKeys.ImportedFileData, dtErrorData);
            }

            objCommonServices.AddToImportLog($"Importing error record started");

            TempData.Keep("FailedRecordCount");

            return Json("success", JsonRequestBehavior.AllowGet);
        }

        private StringBuilder GetFormatedFormName(string formName)
        {
            var formNameResult = objCommonServices.SplitByCapitalLetter(formName);

            StringBuilder sb = new StringBuilder();
            foreach (var item in formNameResult)
            {
                var formaredString = objCommonServices.FirstCharToUpper(item);
                sb.Append($"{formaredString} ");
            }
            return sb;
        }

    }
}
