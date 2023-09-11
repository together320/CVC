// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Pages.UserController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.Web;
using System.Web.Mvc;
using CVC.Models;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.Security.Permissions;
using System.Net;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web.Providers;
using System.Web.Security;
using CVC.Membership;
using CVC.ExternalApplicationInterface.Entities;

namespace CVC.Administration.Pages
{
    [RoutePrefix("LDAP/Index")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(LDAPRow))]
    public class LDAPController : Controller
    {
        public PartialViewResult ChildNode()
        {
            return PartialView();
        }


        public ActionResult Index(LDAP ld)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ld.Username != null)
                    {
						//DirectoryEntry directoryEntry = new DirectoryEntry("LDAP://WIN-F43OA93Q9LB/DC=cvcpharma,DC=com");
						//{

						//}

						ActiveDirectoryService ADireService = new ActiveDirectoryService();
						CVC.Administration.DirectoryEntry de = new CVC.Administration.DirectoryEntry();
					
                        de = ADireService.Validate(ld.Username, ld.Password);
                        if (de == null)
                        {

                            ld.Error = "Invalid User or password";


                        }
                        else
                        {
                            TreeViewModel treeViewModel = new TreeViewModel();
                            TreeViewNodeVM treeView = treeViewModel.GetTreeview(ld.Username, ld.Password, ld.LDAPUrl);
                            //return View("Index", treeView);
                            return (ActionResult)this.View("~/Modules/Administration/User/UserIndex.cshtml", treeView);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return View("LDAP", ld);




        }
    }
}

