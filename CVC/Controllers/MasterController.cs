using CVC.Data.EDMX;
using System;
using System.Linq;
using System.Web.Mvc;

namespace CVC.Controllers
{
    [RoutePrefix("Master")]
    public class MasterController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Index")]
        public ActionResult Index(MasterTerminal Model)
        {
            if (ModelState.IsValid)
            {
                using (var insert = new CVCEntities())
                {
                    Model.CreatedOn = DateTime.Now;
                    Model.CreatedBy = 1;
                    insert.MasterTerminals.Add(Model);
                    insert.SaveChanges();
                }
            }
            else
            {
                return View(Model);
            }
            return RedirectToAction("GetAllTerminals");
        }


        [Route("CheckTerminalName/{terminalname}")]
        public JsonResult CheckTerminalName1(string terminalname)
        {
            bool searchdata;
            using (var db = new CVCEntities())
            {
                searchdata = db.MasterTerminals.Any(o => o.TerminalName == terminalname);
            }
            return Json(searchdata, JsonRequestBehavior.AllowGet);
        }

        [Route("CheckMackaddress/{mackname}")]
        public JsonResult CheckMackaddress(string mackname)
        {
            bool IsExist;
            using (var db = new CVCEntities())
            {
                IsExist = db.MasterTerminals.Any(o => o.MacAddress == mackname);
            }
            return Json(IsExist, JsonRequestBehavior.AllowGet);
        }


        [Route("getall-Terminalmaster")]
        [HttpGet]
        public ActionResult GetAllTerminals()
        {
            return View();
        }

        [Route("getTerminalmaster")]
        [HttpGet]
        public JsonResult GetallTerminalMaster()
        {
            using (CVCEntities db = new CVCEntities())
            {
                var model = db.MasterTerminals.Select(m => new
                {
                    ID = m.ID,
                    TerminalName = m.TerminalName,
                    MacAddress = m.MacAddress,
                    IsActive = m.IsActive,
                    CreatedOn = m.CreatedOn.ToString()
                }).ToList();

                return Json(new { data = model }, JsonRequestBehavior.AllowGet);
            }
        }


        [Route("update-terminal")]
        [HttpGet]
        public ActionResult GetTerminalDetails(int ID)
        {
            using (CVCEntities db = new CVCEntities())
            {
                var result = db.MasterTerminals.SingleOrDefault(b => b.ID == ID);
                return View(result);
            }
        }

        [Route("update-terminal")]
        [HttpPost]
        public ActionResult GetTerminalDetails(MasterTerminal model)
        {
            if (ModelState.IsValid)
            {
                using (var update = new CVCEntities())
                {
                    var result = update.MasterTerminals.Where(x => x.ID == model.ID).FirstOrDefault();

                    if (result != null)
                    {
                        result.TerminalName = model.TerminalName;
                        result.MacAddress = model.MacAddress;
                        result.EditedOn = DateTime.Now;
                        result.EditedBy = 1;
                        result.IsActive = model.IsActive;
                        update.SaveChanges();
                    }
                }
            }
            else
            {
                return View(model);
            }
            return RedirectToAction("GetAllTerminals");
        }
    }
}

