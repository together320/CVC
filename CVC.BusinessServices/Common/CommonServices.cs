using CVC.Data.EDMX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CVC.ViewModels;
using System.Data.Entity;
using static CVC.BusinessServices.Common.ClsConstants;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Serenity;
using System.Linq.Expressions;
using Serenity.Web.Providers;
using System.Net;
using System.Text.RegularExpressions;
using AutoMapper;
using System.Runtime.Caching;
using LumenWorks.Framework.IO.Csv;
using ExcelDataReader;
using static CVC.BusinessServices.Common.ClsEnum;
using Serenity.Data;
using Serenity.Services;
using Exception = CVC.Data.EDMX.Exception;

namespace CVC.BusinessServices.Common
{
    public class CommonServices:IDisposable
    {
        CVCEntities cvcEntities = new CVCEntities();
        ObjectCache cache = MemoryCache.Default;
        ClsCacheConfig clsCacheConfig = new ClsCacheConfig();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                               
            }
            cvcEntities.Dispose();
        }
        #region Role
        public RoleViewModel GetAllRoles(RoleViewModel objRoleViewModel,string loggedUserId)
        {
            var role = new List<Role>();
            var UserId = Convert.ToInt32(loggedUserId);
            var loggedRoleId = cvcEntities.Users.FirstOrDefault(u => u.UserId == UserId).RoleId;

            if (objRoleViewModel.StatusId != null)
            {
                role = loggedRoleId==1? cvcEntities.Roles.Where(r => r.StatusId == objRoleViewModel.StatusId).ToList(): cvcEntities.Roles.Where(r => r.StatusId == objRoleViewModel.StatusId && r.RoleId>1).ToList();

            }
            else
            {
                role = loggedRoleId == 1 ? cvcEntities.Roles.ToList() : cvcEntities.Roles.Where(r=>r.RoleId > 1).ToList();

            }

            objRoleViewModel.lstRoleViewModel = role.Select(x => new RoleViewModel
            {
                RoleId = x.RoleId,
                RoleName = x.RoleName,
                ParentRole = cvcEntities?.Roles?.Where(r => r.RoleId == x.ParentRoleId)?.FirstOrDefault()?.RoleName ?? null,
                StatusName = x?.Status?.StatusName,
            }).ToList();

            return objRoleViewModel;
        }

        public RoleViewModel GetRoleById(RoleViewModel roleViewModel)
        {
            RoleViewModel objRoleViewModel = new RoleViewModel();
            var Getrole = cvcEntities.Roles.Where(r => r.RoleId == roleViewModel.RoleId).FirstOrDefault();

            if (Getrole != null)
            {

                objRoleViewModel.RoleId = Getrole.RoleId;
                objRoleViewModel.RoleName = Getrole.RoleName;
                objRoleViewModel.ParentRoleId = Getrole.ParentRoleId;
                // objRoleViewModel.pa = Getrole.ParentRoleId;
                objRoleViewModel.StatusId = Getrole?.StatusId ?? null;
            }
            return objRoleViewModel;
        }

        public RoleViewModel CreateRole(RoleViewModel roleViewModel)
        {
            var response = new RoleViewModel();
            var IsRoleExist = cvcEntities.Roles.Where(r => r.RoleName.ToLower() == roleViewModel.RoleName.ToLower());
            if (IsRoleExist.Any())
            {
                response.IsStatus = false;
                response.StatusMessage = StatusMessage.Exist;
                return response;
            }

           /* Role role = new Role();
            role.RoleName = roleViewModel.RoleName;
            role.StatusId = roleViewModel.StatusId;
            role.ParentRoleId = roleViewModel.ParentRoleId;
            role.CreatedBy = (roleViewModel.CreatedBy == null || roleViewModel.CreatedBy == 0) ? null : roleViewModel.CreatedBy;
            role.CreatedDate = DateTime.Now;*/
            Role role = new Role
            {
                RoleName = roleViewModel.RoleName,
                StatusId = roleViewModel.StatusId,
                ParentRoleId = roleViewModel.ParentRoleId,
                CreatedBy = (roleViewModel.CreatedBy == null || roleViewModel.CreatedBy == 0) ? null : roleViewModel.CreatedBy,
                CreatedDate = DateTime.Now
            };
            cvcEntities.Roles.Add(role);
            cvcEntities.SaveChanges();

            response.IsStatus = true;
            response.StatusMessage = StatusMessage.DataInsertedSuccessfully;
            return response;
        }

        public RoleViewModel UpdateRole(RoleViewModel roleViewModel)
        {
            var response = new RoleViewModel();
            var IsRoleExist = cvcEntities.Roles.Where(r => r.RoleName.ToLower() == roleViewModel.RoleName.ToLower() && r.RoleId != roleViewModel.RoleId);
            if (IsRoleExist.Any())
            {
                response.IsStatus = false;
                response.StatusMessage = StatusMessage.Exist;
                return response;
            }

            var role = cvcEntities.Roles.FirstOrDefault(r => r.RoleId == roleViewModel.RoleId);

            role.RoleName = roleViewModel.RoleName;
            role.StatusId = roleViewModel.StatusId;
            role.ParentRoleId = roleViewModel.ParentRoleId;
            role.UpdatedBy = (roleViewModel.UpdatedBy == null || roleViewModel.UpdatedBy == 0) ? null : roleViewModel.UpdatedBy;
            role.UpdatedDate = DateTime.UtcNow;
            cvcEntities.Entry(role).State = EntityState.Modified;
            cvcEntities.SaveChanges();

            response.IsStatus = true;
            response.StatusMessage = StatusMessage.DataUpdatedSuccessfully;
            return response;
        }

        #endregion

        #region Status
        public List<StatusViewModel> GetAllStatus()
        {
            var statusList = new List<StatusViewModel>();
            var status = cvcEntities.Status;

            statusList = status.Select(x => new StatusViewModel
            {
                StatusId = x.StatusId,
                StatusName = x.StatusName,
               
            }).ToList();
            return statusList;
        }
        #endregion

        #region Module
        public ResponseListViewModel<ModuleViewModel> GetAllModules(ModuleViewModel objModuleViewModel)
        {
            var response = new ResponseListViewModel<ModuleViewModel>();
            var module = new List<Module>();
            if (objModuleViewModel.StatusId != null)
            {
                module = cvcEntities.Modules.Where(r => r.StatusId == objModuleViewModel.StatusId).ToList();
            }
            else
            {
                module = cvcEntities.Modules.ToList();
            }

            var ModuleViewModel = module.Select(x => new ModuleViewModel
            {
                RoleId = objModuleViewModel.RoleId,
                ModuleId = x.ModuleId,
                ModuleName = x.ModuleName,
                MachineName = x.Machine.MachineName,
                StatusName = x?.Status?.StatusName,
                StatusId = cvcEntities.ModuleAccesses.Where(m => m.RoleId == objModuleViewModel.RoleId && m.ModuleId == x.ModuleId)?.FirstOrDefault()?.StatusId ?? null,
                IsAccess = cvcEntities.ModuleAccesses.Where(m => m.RoleId == objModuleViewModel.RoleId && m.ModuleId == x.ModuleId)?.FirstOrDefault()?.IsAccess ?? null
            }).ToList();

            response = new ResponseListViewModel<ModuleViewModel>
            {
                IsStatus = true,
                StatusMessage = StatusMessage.DataFound,
                Data = ModuleViewModel
            };
            return response;
        }

        #endregion

        #region Module Access
        public ResponseViewModel<ModuleAccessViewModel> GetAllModuleAccess(ModuleAccessViewModel objModuleAccessViewModel)
        {
            var response = new ResponseViewModel<ModuleAccessViewModel>();
            var module = new List<ModuleAccess>();
            if (objModuleAccessViewModel.StatusId != null)
            {
                module = cvcEntities.ModuleAccesses.Where(r => r.StatusId == objModuleAccessViewModel.StatusId && r.RoleId == objModuleAccessViewModel.RoleId && r.IsAccess == true).ToList();
            }
            else
            {
                module = cvcEntities.ModuleAccesses.Where(r => r.RoleId == objModuleAccessViewModel.RoleId && r.IsAccess == true).ToList();
            }

            objModuleAccessViewModel.lstModuleViewModel = module.Select(x => new ModuleViewModel
            {
                ModuleName = x.Module.ModuleName,
                RoleId = x?.RoleId ?? 0,
                ModuleId = x?.ModuleId ?? 0,
                StatusName=x?.Status?.StatusName??""

            }).ToList();
            objModuleAccessViewModel.RoleName = cvcEntities.Roles.Where(r => r.RoleId == objModuleAccessViewModel.RoleId)?.FirstOrDefault()?.RoleName ?? null;
            response = new ResponseViewModel<ModuleAccessViewModel>
            {
                IsStatus = true,
                StatusMessage = StatusMessage.DataFound,
                Data = objModuleAccessViewModel
            };
            return response;
        }

        public RoleViewModel CreateModuleAccess(ModuleAccessViewModel objModuleAccessViewModel)
        {
            var response = new RoleViewModel();
            var GetModuleAccesses = cvcEntities.ModuleAccesses.Where(ma => ma.RoleId == objModuleAccessViewModel.RoleId).ToList();
            if (GetModuleAccesses.Any())
            {
                foreach (var item in GetModuleAccesses)
                {
                    cvcEntities.Entry(item).State = EntityState.Deleted;
                    cvcEntities.SaveChanges();
                }
            }

            var GetAllModule = cvcEntities.Modules.Where(m => m.StatusId == (int)ClsConstants.StatusType.Active).Select(m => m.ModuleId).ToList();

            if (objModuleAccessViewModel.ModuleIds != null)
            {
                foreach (var item in GetAllModule)
                {
                   
                    ModuleAccess moduleAccess = new ModuleAccess();
                    moduleAccess.ModuleId = item;
                    moduleAccess.RoleId = objModuleAccessViewModel.RoleId;
                    moduleAccess.IsAccess = Array.Exists(objModuleAccessViewModel.ModuleIds, element => element == item.ToString()+"&1" || element == item.ToString() + "&2") == true ? true : false;
                   // moduleAccess.IsAccess = Array.Exists(objModuleAccessViewModel.ModuleIds, element => element == item.ToString()) == true ? true : false;

                    moduleAccess.StatusId = Array.Exists(objModuleAccessViewModel.ModuleIds, element => element == item.ToString() + "&1") == true ? 1 : 2; 
                    moduleAccess.CreatedBy = (objModuleAccessViewModel.CreatedBy == null || objModuleAccessViewModel.CreatedBy == 0) ? null : objModuleAccessViewModel.CreatedBy;
                    moduleAccess.CreatedDate = DateTime.Now;
                    cvcEntities.ModuleAccesses.Add(moduleAccess);
                    cvcEntities.SaveChanges();
                }
            }

            return response;
        }

        #endregion

        #region Views
        public ResponseListViewModel<ViewsViewModel> GetAllViews(ViewsViewModel objViewsViewModel)
        {
            var response = new ResponseListViewModel<ViewsViewModel>();
            var view = new List<View>();
            if (objViewsViewModel.StatusId != null)
            {
                view = cvcEntities.Views.Where(r => r.StatusId == objViewsViewModel.StatusId && r.ModuleId == objViewsViewModel.ModuleId).ToList();
            }
            else
            {
                view = cvcEntities.Views.Where(r => r.ModuleId == objViewsViewModel.ModuleId).ToList();
            }

            var ViewsViewModel = view.Select(x => new ViewsViewModel
            {
                ModuleId = x.ModuleId,
                ViewsId = x.ViewsId,
                ViewName = x.ViewName,
                StatusId = cvcEntities.ViewsAccesses.Where(va => va.RoleId == objViewsViewModel.RoleId && va.ViewsId == x.ViewsId)?.FirstOrDefault()?.StatusId ?? null,
                IsView = cvcEntities.ViewsAccesses.Where(va => va.RoleId == objViewsViewModel.RoleId && va.ModuleId == objViewsViewModel.ModuleId && va.ViewsId == x.ViewsId)?.FirstOrDefault()?.IsView ?? null,
                IsModify = cvcEntities.ViewsAccesses.Where(va => va.RoleId == objViewsViewModel.RoleId && va.ModuleId == objViewsViewModel.ModuleId && va.ViewsId == x.ViewsId)?.FirstOrDefault()?.IsModify ?? null

            }).ToList();

            response = new ResponseListViewModel<ViewsViewModel>
            {
                IsStatus = true,
                StatusMessage = StatusMessage.DataFound,
                Data = ViewsViewModel
            };
            return response;
        }

        #endregion

        #region View Access
        public ResponseViewModel<ViewAccessViewModel> GetAllViewAccess(ViewAccessViewModel objViewAccessViewModel)
        {
            var response = new ResponseViewModel<ViewAccessViewModel>();
            var viewsAccess = new List<ViewsAccess>();
            if (objViewAccessViewModel.StatusId != null)
            {
                if (objViewAccessViewModel.RoleId == 1)
                {
                    viewsAccess = cvcEntities.ViewsAccesses.Where(r => r.StatusId == objViewAccessViewModel.StatusId && r.RoleId == objViewAccessViewModel.RoleId && r.ModuleId == objViewAccessViewModel.ModuleId).ToList();
                }
                else
                {
                    viewsAccess = cvcEntities.ViewsAccesses.Where(r => r.StatusId == objViewAccessViewModel.StatusId && r.RoleId == objViewAccessViewModel.RoleId && r.ModuleId == objViewAccessViewModel.ModuleId && r.View.IsFactorySetting==false).ToList();
                }
                
            }
            else
            {
                if(objViewAccessViewModel.RoleId==1)
                {
                    viewsAccess = cvcEntities.ViewsAccesses.Where(r => r.RoleId == objViewAccessViewModel.RoleId && r.ModuleId == objViewAccessViewModel.ModuleId).ToList();
                }
                else
                {
                    viewsAccess = cvcEntities.ViewsAccesses.Where(r => r.RoleId == objViewAccessViewModel.RoleId && r.ModuleId == objViewAccessViewModel.ModuleId && r.View.IsFactorySetting == false).ToList();
                }
                
            }


            objViewAccessViewModel.lstViewsViewModel = viewsAccess.Select(x => new ViewsViewModel
            {
                ViewsId = x?.ViewsId ?? 0,
                ViewName = x.View.ViewName,
                IsView = x.IsView,
                IsModify = x.IsModify,
                StatusName=x?.Status?.StatusName??""
            }).ToList();

            response = new ResponseViewModel<ViewAccessViewModel>
            {
                IsStatus = true,
                StatusMessage = StatusMessage.DataFound,
                Data = objViewAccessViewModel
            };
            return response;
        }

        public ViewAccessViewModel CreateViewAccess(ViewAccessViewModel objViewAccessViewModel)
        {
            var response = new ViewAccessViewModel();
            var GetViewAccesses = cvcEntities.ViewsAccesses.Where(va => va.RoleId == objViewAccessViewModel.RoleId && va.ModuleId== objViewAccessViewModel.ModuleId).ToList();
            if (GetViewAccesses.Any())
            {
                foreach (var item in GetViewAccesses)
                {
                    cvcEntities.Entry(item).State = EntityState.Deleted;
                    cvcEntities.SaveChanges();
                }
            }

            var GetAllViews = cvcEntities.Views.Where(m => m.ModuleId == objViewAccessViewModel.ModuleId).Select(m => m.ViewsId).ToList();

             if (objViewAccessViewModel.IsViewIds != null || objViewAccessViewModel.IsModifyIds!=null)
            {
                foreach (var item in GetAllViews)
                {
                    /*ViewsAccess viewsAccess = new ViewsAccess();
                    viewsAccess.ViewsId = item;
                    viewsAccess.RoleId = objViewAccessViewModel.RoleId;
                    viewsAccess.ModuleId = objViewAccessViewModel.ModuleId;
                    viewsAccess.IsView = (objViewAccessViewModel.IsViewIds != null ? (Array.Exists(objViewAccessViewModel.IsViewIds, element => element == item.ToString() + "&1" || element == item.ToString() + "&2") == true ? true : false) : false);
                    viewsAccess.IsModify = (objViewAccessViewModel.IsModifyIds != null ? (Array.Exists(objViewAccessViewModel.IsModifyIds, element => element == item.ToString() + "&1" || element == item.ToString() + "&2") == true ? true : false) : false);*/

                    ViewsAccess viewsAccess = new ViewsAccess
                    {
                        ViewsId = item,
                        RoleId = objViewAccessViewModel.RoleId,
                        ModuleId = objViewAccessViewModel.ModuleId,
                        IsView = (objViewAccessViewModel.IsViewIds != null ? (Array.Exists(objViewAccessViewModel.IsViewIds, element => element == item.ToString() + "&1" || element == item.ToString() + "&2") == true ? true : false) : false),
                        IsModify = (objViewAccessViewModel.IsModifyIds != null ? (Array.Exists(objViewAccessViewModel.IsModifyIds, element => element == item.ToString() + "&1" || element == item.ToString() + "&2") == true ? true : false) : false)
                    };

                    // viewsAccess.IsView = objViewAccessViewModel.IsViewIds != null ? (Array.Exists(objViewAccessViewModel.IsViewIds, element => element == item.ToString()) == true ? true : false) : false;
                    // viewsAccess.IsModify = objViewAccessViewModel.IsModifyIds != null ? (Array.Exists(objViewAccessViewModel.IsModifyIds, element => element == item.ToString()) == true ? true : false) : false;



                    viewsAccess.StatusId =(viewsAccess.IsView == false&& viewsAccess.IsModify==false)?2:(viewsAccess.IsView == true ? (Array.Exists(objViewAccessViewModel.IsViewIds, element => element == item.ToString() + "&1") == true ? 1 : 2) : (Array.Exists(objViewAccessViewModel.IsModifyIds, element => element == item.ToString() + "&1") == true ? 1 : 2));
                    viewsAccess.CreatedBy = (objViewAccessViewModel.CreatedBy == null || objViewAccessViewModel.CreatedBy == 0) ? null : objViewAccessViewModel.CreatedBy;
                    viewsAccess.CreatedDate = DateTime.Now;
                    cvcEntities.ViewsAccesses.Add(viewsAccess);
                    cvcEntities.SaveChanges();

                    #region Save ViewFieldAccess
                    var getViewField = cvcEntities.ViewFields.Where(vf => vf.ViewsId == item && vf.StatusId==1 && (vf.ModuleId == null || vf.ModuleId == objViewAccessViewModel.ModuleId)).Select(vf => vf.ViewField1).ToArray();
                    string[] isViewIds = Array.ConvertAll(getViewField, ele => ele.ToString());


                    ViewFieldAccessViewModel viewFieldAccessViewModel = new ViewFieldAccessViewModel
                    {
                        CreatedBy= objViewAccessViewModel.CreatedBy,
                        RoleId= objViewAccessViewModel.RoleId,
                        ViewId = item,
                        IsModifyIds = isViewIds,
                        IsViewIds= isViewIds,
                        IsView= viewsAccess.IsView,
                        IsModify = viewsAccess.IsModify,
                    };
                    SaveViewFieldAccess(viewFieldAccessViewModel);
                    #endregion
                }
            }

            return response;
        }

        #endregion

        #region View Field
        public ResponseListViewModel<ViewFieldViewModel> GetAllViewField(ViewFieldViewModel objViewFieldViewModel)
        {
            var response = new ResponseListViewModel<ViewFieldViewModel>();
            var viewField = new List<ViewField>();
            if (objViewFieldViewModel.StatusId != null)
            {
                viewField = cvcEntities.ViewFields.Where(v => v.StatusId == objViewFieldViewModel.StatusId && v.ViewsId == objViewFieldViewModel.ViewsId).ToList();
            }
            else
            {
                viewField = cvcEntities.ViewFields.Where(r => r.ViewsId == objViewFieldViewModel.ViewsId).ToList();
            }

            var ViewFieldViewModel = viewField.Select(x => new ViewFieldViewModel
            {
                ViewFieldId = x.ViewField1,
                ViewsId = x.ViewsId,
                ViewFieldName = x.ViewFieldName,
                StatusId = cvcEntities.ViewFieldAccesses.Where(vfa => vfa.RoleId == objViewFieldViewModel.RoleId && vfa.ViewFieldId == x.ViewField1 && vfa.ViewsId == objViewFieldViewModel.ViewsId)?.FirstOrDefault()?.StatusId ?? null,
                IsView = cvcEntities.ViewFieldAccesses.Where(vfa => vfa.RoleId == objViewFieldViewModel.RoleId && vfa.ViewFieldId == x.ViewField1 && vfa.ViewsId == objViewFieldViewModel.ViewsId)?.FirstOrDefault()?.IsView ?? null,
                IsModify = cvcEntities.ViewFieldAccesses.Where(vfa => vfa.RoleId == objViewFieldViewModel.RoleId && vfa.ViewFieldId == x.ViewField1 && vfa.ViewsId == objViewFieldViewModel.ViewsId)?.FirstOrDefault()?.IsModify ?? null,

            }).ToList();

            response = new ResponseListViewModel<ViewFieldViewModel>
            {
                IsStatus = true,
                StatusMessage = StatusMessage.DataFound,
                Data = ViewFieldViewModel
            };
            return response;
        }

        #endregion

        #region View Field Access
        public ResponseViewModel<ViewFieldAccessViewModel> GetAllViewFieldAccess(ViewFieldAccessViewModel objViewFieldAccessViewModel)
        {
            var response = new ResponseViewModel<ViewFieldAccessViewModel>();
            var viewFieldAccess = new List<ViewFieldAccess>();
            if (objViewFieldAccessViewModel.StatusId != null)
            {
                viewFieldAccess = cvcEntities.ViewFieldAccesses.Where(r => r.StatusId == objViewFieldAccessViewModel.StatusId && r.RoleId == objViewFieldAccessViewModel.RoleId && r.ViewsId==objViewFieldAccessViewModel.ViewId).ToList();
            }
            else
            {
                viewFieldAccess = cvcEntities.ViewFieldAccesses.Where(r => r.RoleId == objViewFieldAccessViewModel.RoleId && r.ViewsId == objViewFieldAccessViewModel.ViewId).ToList();
            }

            objViewFieldAccessViewModel.lstViewFieldViewModel = viewFieldAccess.Select(x => new ViewFieldViewModel
            {
                ViewFieldName = x.ViewField.ViewFieldName,
                IsView = x.IsView,
                IsModify = x.IsModify,
                StatusName = x?.Status?.StatusName ?? ""

            }).ToList();
            response = new ResponseViewModel<ViewFieldAccessViewModel>
            {
                IsStatus = true,
                StatusMessage = StatusMessage.DataFound,
                Data = objViewFieldAccessViewModel
            };
            return response;
        }

        public ViewFieldAccessViewModel CreateViewFieldAccess(ViewFieldAccessViewModel objViewFieldAccessViewModel)
        {        
            var response = new ViewFieldAccessViewModel();
            var GetViewFieldAccesses = cvcEntities.ViewFieldAccesses.Where(va => va.RoleId == objViewFieldAccessViewModel.RoleId && va.ViewsId== objViewFieldAccessViewModel.ViewId).ToList();

            if (GetViewFieldAccesses.Any())
            {
                foreach (var item in GetViewFieldAccesses)
                {
                    cvcEntities.Entry(item).State = EntityState.Deleted;
                    cvcEntities.SaveChanges();
                }
            }

            var GetAllViewFields = cvcEntities.ViewFields.Where(vf => vf.ViewsId == objViewFieldAccessViewModel.ViewId).Select(vf => vf.ViewField1).ToList();

             if (objViewFieldAccessViewModel.IsViewIds != null || objViewFieldAccessViewModel.IsModifyIds != null)
            {
                foreach (var item in GetAllViewFields)
                {
                    ViewFieldAccess viewFieldAccess = new ViewFieldAccess();
                    viewFieldAccess.ViewFieldId = item;
                    viewFieldAccess.RoleId = objViewFieldAccessViewModel.RoleId;
                    viewFieldAccess.IsView = (objViewFieldAccessViewModel.IsViewIds != null ? (Array.Exists(objViewFieldAccessViewModel.IsViewIds, element => element == item.ToString() + "&1" || element == item.ToString() + "&2") == true ? true : false) : false);
                    viewFieldAccess.IsModify = (objViewFieldAccessViewModel.IsModifyIds != null ? (Array.Exists(objViewFieldAccessViewModel.IsModifyIds, element => element == item.ToString() + "&1" || element == item.ToString() + "&2") == true ? true : false) : false);
                    viewFieldAccess.StatusId = (viewFieldAccess.IsView == false && viewFieldAccess.IsModify == false) ? 2 : (viewFieldAccess.IsView == true ? (Array.Exists(objViewFieldAccessViewModel.IsViewIds, element => element == item.ToString() + "&1") == true ? 1 : 2) : (Array.Exists(objViewFieldAccessViewModel.IsModifyIds, element => element == item.ToString() + "&1") == true ? 1 : 2));

                    // viewFieldAccess.IsView = objViewFieldAccessViewModel.IsViewIds != null ? (Array.Exists(objViewFieldAccessViewModel.IsViewIds, element => element == item.ToString()) == true ? true : false) : false;
                    // viewFieldAccess.IsModify = objViewFieldAccessViewModel.IsModifyIds != null ? (Array.Exists(objViewFieldAccessViewModel.IsModifyIds, element => element == item.ToString()) == true ? true : false) : false;
                    // viewFieldAccess.StatusId = 1;
                    viewFieldAccess.ViewsId = objViewFieldAccessViewModel.ViewId;
                    viewFieldAccess.CreatedBy = (objViewFieldAccessViewModel.CreatedBy == null || objViewFieldAccessViewModel.CreatedBy == 0) ? null : objViewFieldAccessViewModel.CreatedBy;
                    viewFieldAccess.CreatedDate = DateTime.Now;
                    cvcEntities.ViewFieldAccesses.Add(viewFieldAccess);
                    cvcEntities.SaveChanges();
                }
            }

            return response;
        }

        private void SaveViewFieldAccess(ViewFieldAccessViewModel objViewFieldAccessViewModel)
        {
            var response = new ViewFieldAccessViewModel();
            var GetViewFieldAccesses = cvcEntities.ViewFieldAccesses.Where(va => va.RoleId == objViewFieldAccessViewModel.RoleId && va.ViewsId == objViewFieldAccessViewModel.ViewId).ToList();

            if (GetViewFieldAccesses.Any())
            {
                foreach (var item in GetViewFieldAccesses)
                {
                    cvcEntities.Entry(item).State = EntityState.Deleted;
                    cvcEntities.SaveChanges();
                }
            }

         //   var GetAllViewFields = cvcEntities.ViewFields.Where(vf => vf.ViewsId == objViewFieldAccessViewModel.ViewId).Select(vf => vf.ViewField1).ToList();

            if (objViewFieldAccessViewModel.IsViewIds != null || objViewFieldAccessViewModel.IsModifyIds != null)
            {
                foreach (var item in objViewFieldAccessViewModel.IsViewIds)
                {
                    ViewFieldAccess viewFieldAccess = new ViewFieldAccess();
                    viewFieldAccess.ViewFieldId =Convert.ToInt32(item);
                    viewFieldAccess.RoleId = objViewFieldAccessViewModel.RoleId;
                    viewFieldAccess.IsView = objViewFieldAccessViewModel.IsView;
                    viewFieldAccess.IsModify = objViewFieldAccessViewModel.IsModify;
                    viewFieldAccess.StatusId = (objViewFieldAccessViewModel.IsView == false && objViewFieldAccessViewModel.IsModify == false) ? 2 : 1;
                    viewFieldAccess.ViewsId = objViewFieldAccessViewModel.ViewId;
                    viewFieldAccess.CreatedBy = (objViewFieldAccessViewModel.CreatedBy == null || objViewFieldAccessViewModel.CreatedBy == 0) ? null : objViewFieldAccessViewModel.CreatedBy;
                    viewFieldAccess.CreatedDate = DateTime.Now;
                    cvcEntities.ViewFieldAccesses.Add(viewFieldAccess);
                    cvcEntities.SaveChanges();
                }
            }

          //  return response;
        }
        #endregion

        #region Environment Variable
        public EnvironmentVariable GetEnvironmentVaiableDetails()
        {
            return cvcEntities.EnvironmentVariables.FirstOrDefault();
        }
        #endregion

        #region Machine
        public List<Machine> GetAllMachine(int StatusId,string protocolType=null)
        {
            if(StatusId==0)
            {
                return cvcEntities.Machines.ToList();

            }
            else
            {
                if(!string.IsNullOrEmpty(protocolType))
                {
                    var protocolId = cvcEntities?.Protocols?.FirstOrDefault(p => p.ProtocolName.ToLower() == protocolType.ToLower()).ProtocolId;
                    return cvcEntities?.MachineCommunications?.Where(mc => mc.ProtocolTypeId == protocolId && mc.Machine.StatusId==StatusId)?.Select(mc => mc.Machine)?.ToList();

                   // return cvcEntities?.MachineCommunications?.Where(mc => mc.ProtocolTypeId == protocolId)?.Select(m =>new Machine{MachineId=m.Machine.MachineId,MachineName=m.Machine.MachineName })?.ToList();

                }

                return cvcEntities.Machines.Where(m => m.StatusId == StatusId).ToList();

            }


        }

        public MachineDetails GetMachineDetails(int MachineId)
        {
            var machineDetails= cvcEntities.Machines.Where(m => m.MachineId == MachineId).FirstOrDefault();

            var m_machineDetails = new MachineDetails();
            m_machineDetails.MachineId = machineDetails.MachineId;
            m_machineDetails.MachineName = machineDetails.MachineName;
            m_machineDetails.MachineSequence = machineDetails.MachineSequence;
            m_machineDetails.AccessIPAddress = machineDetails.AccessIPAddress;
            m_machineDetails.Description = machineDetails.Description;
            m_machineDetails.ModelNumber = machineDetails.ModelNumber;
            m_machineDetails.SerialNumber = machineDetails.SerialNumber;
            m_machineDetails.Make = machineDetails.Make;
            m_machineDetails.Year = machineDetails.Year;
            m_machineDetails.PlcMake = machineDetails.PlcMake;
            m_machineDetails.PlcModelNumber = machineDetails.PlcModelNumber;
            m_machineDetails.PlcSerialNumber = machineDetails.PlcSerialNumber;
            m_machineDetails.PLCAddress = machineDetails.PLCAddress;
            m_machineDetails.StatusId = (int)machineDetails.StatusId;
            m_machineDetails.IsRealTime = machineDetails.IsRealTime ?? false;
            m_machineDetails.TableId = machineDetails.TableId;
            m_machineDetails.TableName = machineDetails.TableName;
            m_machineDetails.TimerForAlarm = machineDetails.TimerForAlarm;

            return m_machineDetails;
            /*return new MachineDetails
            {
                MachineId = machineDetails.MachineId,
                MachineName = machineDetails.MachineName,
                MachineSequence = machineDetails.MachineSequence,
                AccessIPAddress = machineDetails.AccessIPAddress,
                Description = machineDetails.Description,
                ModelNumber = machineDetails.ModelNumber,
                SerialNumber = machineDetails.SerialNumber,
                Make = machineDetails.Make,
                Year = machineDetails.Year,
                PlcMake = machineDetails.PlcMake,
                PlcModelNumber = machineDetails.PlcModelNumber,
                PlcSerialNumber = machineDetails.PlcSerialNumber,
                PLCAddress = machineDetails.PLCAddress,
                StatusId =(int)machineDetails.StatusId,
                IsRealTime = (bool)machineDetails.IsRealTime,
                TableId = machineDetails.TableId,
                TimerForAlarm = machineDetails.TimerForAlarm
          };*/

        }
        #endregion

        #region Archival And Restore Process
        public DataSet GetArchiveData(ArchivalViewModel objArchivalViewModel)
        {
            string[] SplitFromDate = objArchivalViewModel.FromDate.ToString().Split('/', ' ');
            var FromDate = SplitFromDate[1] + "/" + SplitFromDate[0] + "/" + SplitFromDate[2];
            objArchivalViewModel.FromDate = FromDate;

            string[] SplitToDate = objArchivalViewModel.ToDate.ToString().Split('/', ' ');
            var ToDate = SplitToDate[1] + "/" + SplitToDate[0] + "/" + SplitToDate[2];

            objArchivalViewModel.ToDate = ToDate;
            objArchivalViewModel.Type = "Archive";

            DataSet ds = CallArchiveProcedure(objArchivalViewModel);

            if (ds.Tables.Count > 0)
            {
                var FileName = "";

                if (objArchivalViewModel.MachineName.Length > 2)
                {
                    FileName = objArchivalViewModel.MachineName.Substring(0, 3).ToUpper() + "_ARCH" + "_" + "TableName" + "_" + SplitFromDate[0] + "" + SplitFromDate[1] + "" + SplitFromDate[2] + "_" + SplitToDate[0] + "" + SplitToDate[1] + "" + SplitToDate[2];
                }
                else
                {
                    FileName = objArchivalViewModel.MachineName.ToUpper() + "_ARCH" + "_" + "TableName" + "_" + SplitFromDate[0] + "" + SplitFromDate[1] + "" + SplitFromDate[2] + "_" + SplitToDate[0] + "" + SplitToDate[1] + "" + SplitToDate[2];

                }
                var path = cvcEntities.EnvironmentVariables.FirstOrDefault().ArchivalPath + "\\" + objArchivalViewModel.MachineName;

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = path + "\\" + FileName + "." + ClsConstants.FileType.Csv;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    /* @"D:\\Log\tt1.csv"*/
                    path = path.Replace("TableName", ArchiveTableName.AlarmLog);
                    DataTable dt = ds.Tables[0];
                    bool IsDataExport = ExportToCsv(dt, path);

                    if (IsDataExport == true)
                    {
                        if ((System.IO.File.Exists(path)))
                        {
                            objArchivalViewModel.Type = "Delete";
                            objArchivalViewModel.DeleteTableName = ArchiveTableName.AlarmLog;
                            CallArchiveProcedure(objArchivalViewModel);
                        }

                    }

                    path = path.Replace("AlarmLog", "TableName");
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    path = path.Replace("TableName", ArchiveTableName.AuditLog);
                    DataTable dt = ds.Tables[1];
                    bool IsDataExport = ExportToCsv(dt, path);
                    if (IsDataExport == true)
                    {
                        if ((System.IO.File.Exists(path)))
                        {
                            objArchivalViewModel.Type = "Delete";
                            objArchivalViewModel.DeleteTableName = ArchiveTableName.AuditLog;
                            CallArchiveProcedure(objArchivalViewModel);
                        }

                    }
                    path = path.Replace("AuditLog", "TableName");

                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    path = path.Replace("TableName", ArchiveTableName.UserLog);
                    DataTable dt = ds.Tables[2];
                    bool IsDataExport = ExportToCsv(dt, path);
                    if (IsDataExport == true)
                    {
                        if ((System.IO.File.Exists(path)))
                        {
                            objArchivalViewModel.Type = "Delete";
                            objArchivalViewModel.DeleteTableName = ArchiveTableName.UserLog;
                            CallArchiveProcedure(objArchivalViewModel);
                        }

                    }
                    path = path.Replace("UserLog", "TableName");

                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    path = path.Replace("TableName", ArchiveTableName.BatchLog);
                    DataTable dt = ds.Tables[3];
                    bool IsDataExport = ExportToCsv(dt, path);
                    if (IsDataExport == true)
                    {
                        if ((System.IO.File.Exists(path)))
                        {
                            objArchivalViewModel.Type = "Delete";
                            objArchivalViewModel.DeleteTableName = ArchiveTableName.BatchLog;
                            CallArchiveProcedure(objArchivalViewModel);
                        }

                    }
                    path = path.Replace("BatchLog", "TableName");
                }

                if (ds.Tables[4].Rows.Count > 0)
                {
                    var MiscellaneousPath = cvcEntities.EnvironmentVariables.FirstOrDefault().ArchivalPath + "\\" + "Miscellaneous";

                    if (!Directory.Exists(MiscellaneousPath))
                    {
                        Directory.CreateDirectory(MiscellaneousPath);
                    }
                    MiscellaneousPath = MiscellaneousPath + "\\" + FileName + "." + ClsConstants.FileType.Csv;
                    MiscellaneousPath = MiscellaneousPath.Replace("TableName", ArchiveTableName.AuditLogMiscellaneous);
                    DataTable dt = ds.Tables[4];
                    bool IsDataExport = ExportToCsv(dt, MiscellaneousPath);
                    if (IsDataExport == true)
                    {
                        if ((System.IO.File.Exists(MiscellaneousPath)))
                        {
                            objArchivalViewModel.Type = "Delete";
                            objArchivalViewModel.DeleteTableName = ArchiveTableName.AuditLogMiscellaneous;
                            CallArchiveProcedure(objArchivalViewModel);
                        }

                    }
                    MiscellaneousPath = path.Replace("AuditLogMiscellaneous", "TableName");

                }

            }


            return ds;

        }
        public void RestoreData(ArchivalViewModel objArchivalViewModel)
        {
            string[] SplitFileName = objArchivalViewModel.FileName.ToString().Split('_', '.');

            var FromDate = SplitFileName[3].Substring(2, 2) + "/" + SplitFileName[3].Substring(0, 2) + "/" + SplitFileName[3].Substring(4, 4);
            var ToDate = SplitFileName[4].Substring(2, 2) + "/" + SplitFileName[4].Substring(0, 2) + "/" + SplitFileName[4].Substring(4, 4);

            objArchivalViewModel.FromDate = FromDate;
            objArchivalViewModel.ToDate = ToDate;
            objArchivalViewModel.Type = "Restore";
            objArchivalViewModel.MachineId = Convert.ToInt32(SplitFileName[5]);
            objArchivalViewModel.InsertTableName = SplitFileName[2];
            DataSet Ds = CallArchiveProcedure(objArchivalViewModel);

        }
        private DataSet CallArchiveProcedure(ArchivalViewModel objArchivalViewModel)
        {

            using (SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_ArchiveData", Con);

                cmd.Parameters.AddWithValue("@MachineId", objArchivalViewModel.MachineId);
                cmd.Parameters.AddWithValue("@FromDate", objArchivalViewModel.FromDate);
                cmd.Parameters.AddWithValue("@ToDate", objArchivalViewModel.ToDate);
                cmd.Parameters.AddWithValue("@Type", objArchivalViewModel.Type);
                cmd.Parameters.AddWithValue("@DeleteTableName", objArchivalViewModel.DeleteTableName);
                cmd.Parameters.AddWithValue("@InsertTableName", objArchivalViewModel.InsertTableName);
                cmd.Parameters.AddWithValue("@TruncateTableName", objArchivalViewModel.TruncateTableName);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }

        }

        #endregion

        #region PickListValue
        public List<PickListValue> GetPickListValues()
        {
            var PickListId = cvcEntities.PickLists.FirstOrDefault(pl => pl.PickListName.ToUpper() == "REASON").PickListId;

            return cvcEntities.PickListValues.Where(plv=>plv.PickListId== PickListId).ToList();
        }
        #endregion

        #region Password
        public bool CreatePassword(PasswordViewModel objPasswordViewModel)
        {
            using (CVCEntities objCVCEntities = new CVCEntities())
            {
                Password objPassword = new Password();
                objPassword.PasswordHash = objPasswordViewModel.PasswordHash;
                objPassword.PasswordSalt = objPasswordViewModel.PasswordSalt;
                objPassword.UserId = Convert.ToInt32(objPasswordViewModel.UserId);
                objPassword.CreatedOn = objPasswordViewModel.CreatedOn;
                objCVCEntities.Passwords.Add(objPassword);
                objCVCEntities.SaveChanges();
                return true;
            }


        }

        public int GetPreviousPasswordLimit()
        {
            using (CVCEntities objCVCEntities = new CVCEntities())
            {
               return cvcEntities.EnvironmentVariables?.FirstOrDefault()?.PreviousPasswordLimit??0;

            }
        }
        #endregion

        protected bool ExportToCsv(DataTable dt, string FilePath)
        {
            try
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt);
                    using (MemoryStream MyMemoryStream = new MemoryStream())
                    {
                        wb.SaveAs(MyMemoryStream);
                        MyMemoryStream.WriteTo(HttpContext.Current.Response.OutputStream);

                        FileStream file = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
                        MyMemoryStream.WriteTo(file);
                        file.Close();
                       // MyMemoryStream.Close();

                    }

                    return true;
                }
            }
            catch (System.Exception ex)
            {
           
                return false;
            }
        }

        public void ImportExcel(string Path, string FileName, bool TruncateAuditLogTable)
        {
            var SplitFileName = FileName.Split('_');
            //Save the uploaded Excel file.
            string filePath = HttpContext.Current.Server.MapPath(Path + FileName);

            //Open the Excel file in Read Mode using OpenXml.
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(filePath, false))
            {
                //Read the first Sheets from Excel file.
                Sheet sheet = doc.WorkbookPart.Workbook.Sheets.GetFirstChild<Sheet>();

                //Get the Worksheet instance.
                Worksheet worksheet = (doc.WorkbookPart.GetPartById(sheet.Id.Value) as WorksheetPart).Worksheet;

                //Fetch all the rows present in the Worksheet.
                IEnumerable<Row> rows = worksheet.GetFirstChild<SheetData>().Descendants<Row>();

                //Create a new DataTable.
                DataTable dt = new DataTable();

                //Loop through the Worksheet rows.
                foreach (Row row in rows)
                {
                    //Use the first row to add columns to DataTable
                    if (row.RowIndex.Value == 1)
                    {
                        foreach (Cell cell in row.Descendants<Cell>())
                        {
                            dt.Columns.Add(GetValue(doc, cell, "",""));
                        }
                    }
                    else
                    {
                        var TableName = SplitFileName[2];
                        var CellReference = "";
                        if (TableName.Trim().ToUpper() == "AUDITLOG" || TableName.Trim().ToUpper() == "AUDITLOGMISCELLANEOUS")
                        {
                            CellReference = "E";

                        }
                        else if (TableName.Trim().ToUpper() == "ALARMLOG")
                        {
                            CellReference = "H";
                        }
                        else if (TableName.Trim().ToUpper() == "USERLOG")
                        {
                            CellReference = "E";
                        }
                        else if (TableName.Trim().ToUpper() == "BATCHLOG")
                        {
                            CellReference = "Q";
                        }
                        //Add rows to DataTable.
                        dt.Rows.Add();
                        int i = 0;
                        foreach (Cell cell in row.Descendants<Cell>())
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = GetValue(doc, cell, CellReference, TableName);
                            i++;
                        }
                    }
                }
                if (FileName.Contains("Miscellaneous"))
                {
                    SplitFileName[2] = SplitFileName[2].Replace("Miscellaneous", "");
                }
                using (SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    if (SplitFileName[2].ToUpper() == "AUDITLOG" && TruncateAuditLogTable == false)
                    {

                    }
                    else
                    {
                        ArchivalViewModel objArchivalViewModel = new ArchivalViewModel();
                        objArchivalViewModel.Type = "Restore";
                        objArchivalViewModel.TruncateTableName = SplitFileName[2] + "Archive";
                        CallArchiveProcedure(objArchivalViewModel);
                    }



                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(Con))
                    {
                        var tableName = SplitFileName[2] == "BatchLog" ? "Batch" : SplitFileName[2];
                        sqlBulkCopy.DestinationTableName = tableName + "Archive";
                        bool IsFirst = true;

                        foreach (DataColumn column in dt.Columns)
                        {
                            if (IsFirst)
                            {
                                IsFirst = false;
                            }
                            else
                            {
                                if (column.ColumnName=="IsAlarmActive")
                                {
                                    
                                }
                              else // if (column.ColumnName == "MachineId" || column.ColumnName == "AlarmId" || column.ColumnName == "BatchId" || column.ColumnName == "LoggedUserId" || column.ColumnName == "Comment" || column.ColumnName == "Description" || column.ColumnName == "PCIPAddress" || column.ColumnName == "AlarmDateTime")
                                {
                                    sqlBulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                                }
                            }

                        }

                        Con.Open();
                        sqlBulkCopy.WriteToServer(dt);
                        Con.Close();
                    }
                }

            }
        }

        private string GetValue(SpreadsheetDocument doc, Cell cell, string CellReference,string TableName)
        {
            string value = string.Empty;
            if (TableName.ToUpper()=="ALARMLOG" && cell.CellValue.ToString()!="1")
            {
                value = cell.CellValue != null ? (cell.CellValue.InnerText=="0"?null:cell.CellValue.InnerText) : null;

            }
            else
            {
                value = cell.CellValue != null ? (cell.CellValue.InnerText) : null;
            }
            if (!string.IsNullOrEmpty(value))
            {
                if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
                {
                    return doc.WorkbookPart.SharedStringTablePart.SharedStringTable.ChildElements.GetItem(int.Parse(value)).InnerText;
                }

                if (!string.IsNullOrEmpty(CellReference))
                {
                    if (TableName.ToUpper() == "BATCHLOG")
                    {
                        string[] numbers = Regex.Split(cell.CellReference.Value, @"\D+");
                        string[] cellaArray = new string[]{ "D"+ numbers[1] , "E" + numbers[1], "N" + numbers[1], "Q" + numbers[1], "S" + numbers[1], "T" + numbers[1] };
                        if (cellaArray.Contains(cell.CellReference.Value))
                        // if (cell.CellReference.Value.Contains(CellReference))
                        {
                            double date = double.Parse(value);
                            var dateTime = DateTime.FromOADate(date);

                            return dateTime.ToString();
                        }
                    }
                    else
                    {
                        if (cell.CellReference.Value.Contains(CellReference))
                        {
                            double date = double.Parse(value);
                            var dateTime = DateTime.FromOADate(date);

                            return dateTime.ToString();
                        }
                    }
                }




            }

            return value;
        }

        public int[] GetRoleViewFieldWise(int ViewFieldId)
        {
            return cvcEntities.ViewFieldAuthentications.Where(vf => vf.ViewFieldId == ViewFieldId).Select(vf => vf.RoleId).ToArray();
        }

        public static string CalculateHash(string password, string salt)
        {
            return SiteMembershipProvider.ComputeSHA512(password + salt);
        }

        public static string GenerateHash(string password, ref string salt)
        {
            salt = salt ?? System.Web.Security.Membership.GeneratePassword(5, 1);
            return CalculateHash(password, salt);
        }

        public Tuple<bool, int?> AuthenticateUserByViewFieldWise(int ViewFieldId, string UserName, string Password)
        {
            var user = Data.CVCDaoFactory.GetUser(UserName);         
            var Roles = GetRoleViewFieldWise(ViewFieldId);
            if (Roles != null)
            {
                if (user != null)
                {
                    string salt = user.PasswordSalt;
                    string hash = GenerateHash(Password, ref salt);
                    if (string.Equals(user.Username, UserName, StringComparison.OrdinalIgnoreCase) && user.PasswordHash == hash)
                    {
                        var UsersDetails = cvcEntities.Users.FirstOrDefault(ur => ur.Username == UserName);
                        var IsValidRole = Array.Exists(Roles, element => element == UsersDetails.RoleId);

                        if (IsValidRole)
                        {
                            return new Tuple<bool, int?>(true, UsersDetails.UserId);
                        }
                        else
                        {
                            return new Tuple<bool, int?>(false, null);

                        }
                    }
                    else
                    {
                        return new Tuple<bool, int?>(false, null);
                    }
                }
                return new Tuple<bool, int?>(false, null);
            }
            return new Tuple<bool, int?>(false, null);

        }

        public Tuple<bool, int?> AuthenticateUserByLogin(string UserName, string Password)
        {
            var user = Data.CVCDaoFactory.GetUser(UserName);
           
            if (user != null)
            {
                string salt = user.PasswordSalt;
                string hash = GenerateHash(Password, ref salt);
                
                if (string.Equals(user.Username, UserName, StringComparison.OrdinalIgnoreCase) && user.PasswordHash == hash)
                {
                    var UsersDetails = cvcEntities.Users.FirstOrDefault(ur => ur.Username == UserName);

                    return new Tuple<bool, int?>(true, UsersDetails.UserId);
                }
                else
                {
                    return new Tuple<bool, int?>(false, null);
                }
            }
            else
            {
                return new Tuple<bool, int?>(false, null);
            }

        }

        public MachineCommunication GetMachineCommunicationDetails(int MachineParameterId)
        {
            var machineCommunication = new MachineCommunication();
            try
            {
                using (CVCEntities objcvcEntities = new CVCEntities())
                {
                    var machinePara = new MachineParameter();
                    machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == MachineParameterId);

                    if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
                    {
                        return machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();
                    }
                }
            }
            catch(System.Exception ex)
            {

            }
            return machineCommunication;
        }

        public User GetUserDetailsByUserName(string UserName)
        {
            return cvcEntities.Users.FirstOrDefault(u => u.Username == UserName);
        }

        public User GetUserDetailsByUserId(int UserId)
        {
            return cvcEntities.Users.FirstOrDefault(u => u.UserId == UserId);
        }

        public List<RolePermission> GetRolePermission(int RoleId)
        {
            return cvcEntities.RolePermissions.Where(r => r.RoleId == RoleId).ToList();
        }

        public bool GetRolePermission(int RoleId,string permissionKey)
        {
            var rolePermission= cvcEntities.RolePermissions.Where(r => r.RoleId == RoleId && r.PermissionKey==permissionKey)?.FirstOrDefault();

            if(rolePermission!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SendHeartBeatViewModel CheckHeartBeatSend(int ModuleId)
        {
            SendHeartBeatViewModel sendHeartBeatViewModel=null;
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var MachineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == ModuleId).MachineId.Value;
                var IPCParameter = cvcEntities.IPCParameters.FirstOrDefault(i => i.MachineId == MachineId && i.IsHeartBeatSend == true);
                if (IPCParameter != null)
                {
                    var result = new { IsHeartBeatSend = IPCParameter.IsHeartBeatSend, MachineParameterId = IPCParameter.MachineParameterId, IPCAddress = IPCParameter.IPCAddress, IncrementalNumber = IPCParameter.IncrementalNumber, StartNumber = IPCParameter.StartNumber, EndNumber = IPCParameter.EndNumber };
                    sendHeartBeatViewModel = new SendHeartBeatViewModel
                    {
                        BitWiseIndex = IPCParameter.BitWiseIndex,
                        DataTypeId = IPCParameter.MachineParameter.DataTypeId,
                        EndNumber = IPCParameter.EndNumber,
                        IncrementalNumber = IPCParameter.IncrementalNumber,
                        IPCAddress = IPCParameter.IPCAddress,
                        IsBitWise = IPCParameter.IsBitWise,
                        IsByteSwap = IPCParameter.IsByteSwap,
                        IsHeartBeatSend = IPCParameter.IsHeartBeatSend,
                        IsWordSwap = IPCParameter.IsWordSwap,
                        MachineParameterId = IPCParameter.MachineParameterId,
                        StartNumber = IPCParameter.StartNumber,
                        Bit32Address = IPCParameter.Bit32Address,
                        Is32Bit = IPCParameter.Is32Bit,
                        NodeId = IPCParameter.NodeId,
                        AttributeId = Convert.ToUInt32(IPCParameter.AttributeId),
                        DataTypeName=IPCParameter?.MachineParameter?.DataType?.DataTypeName
                        

                    };
                 
                 

                }
                else
                {
                    var result = new { IsHeartBeat = false };

                }
                return sendHeartBeatViewModel;

            }

        }

        public MasterTerminal checkData(string MacAddress)
        {
            var masterTerminals = new MasterTerminal();
            using (CVCEntities cVCEntities = new CVCEntities())
            {
              return cvcEntities.MasterTerminals.Where(a => a.MacAddress.Replace("-", string.Empty).ToUpper() == MacAddress.ToUpper()).FirstOrDefault();
            }
        }

        public bool AddAuditLog(List<AuditLog> lstAuditLog)
        {

            using (CVCEntities cvcEntities = new CVCEntities())
            {
                foreach (var item in lstAuditLog)
                {
                    AuditLog log = new AuditLog();
                   
                    if (item.User != null)
                    {
                        log.UserId = item.User.UserId;
                        log.UserName = item.User.Username;
                    }
                    log.Action = item.Action;

                    log.ChangedOn = DateTime.Now;
                    log.Module = item.Module;
                    log.Page = item.Page;
                    log.FieldName = item.FieldName;
                    log.OldValue = item.OldValue;
                    log.NewValue = item.NewValue;
                    log.BatchId = item.BatchId;
                    log.MachineId = item.MachineId;
                    log.Comments = item.Comments;
                    log.PickListValueId = item.PickListValueId;
                    log.AuthenticationId = item.AuthenticationId;
                    cvcEntities.AuditLogs.Add(log);
                    cvcEntities.SaveChanges();
                }

            }
            return true;
        }

        public bool AddToAuditLog(string Action, string Module, string Page, string FieldName = "", string OldValue = "", string NewValue = "", int? BatchId = null, int? MachineId = null, int? UserId=null,string UserName=null, int? PickListValueId = null, string Comments = null, int? AuthenticationId = null)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                AuditLog log = new AuditLog();
               
                log.UserId = UserId;
                if(UserId!=null)
                {
                    var userDetails = GetUserDetailsByUserId((int)UserId);
                    UserName = userDetails.Username;
                }
                log.UserName=UserName;              
                log.Action = Action;
                log.ChangedOn = DateTime.Now;
                log.Module = Module;
                log.Page = Page;
                log.FieldName = FieldName;
                log.OldValue = OldValue;
                log.NewValue = NewValue;
                log.BatchId = BatchId;
                log.MachineId = MachineId;
                log.Comments = Comments;
                log.PickListValueId = PickListValueId;
                log.AuthenticationId = AuthenticationId;
                cvcEntities.AuditLogs.Add(log);
                cvcEntities.SaveChanges();
            }
            return true;
        }


        public object GetPropertyValue( object model, string propertyName)
        {
            return model.GetType().GetProperties()
               .Single(pi => pi.Name == propertyName)
               .GetValue(model, null);
        }

        public string GetServerMacAddress()
        {
            string macAddresses = "";

            foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;
        }

        public string GetClientMacAddress(string ipAddress)
        {
            string macAddress = string.Empty;
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = "arp";
            pProcess.StartInfo.Arguments = "-a " + ipAddress;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            string strOutput = pProcess.StandardOutput.ReadToEnd();
            string[] substrings = strOutput.Split('-');
            if (substrings.Length >= 8)
            {
                macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2))
                    + "-" + substrings[4] + "-" + substrings[5] + "-" + substrings[6]
                    + "-" + substrings[7] + "-"
                    + substrings[8].Substring(0, 2);
                return macAddress;
            }
            else
            {
                return "not found";
            }
        }

        public MessageMaster GetMessages(MessageMaster messageMaster)
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                return cvcEntities.MessageMasters.FirstOrDefault(mm => mm.MessageMasterId == messageMaster.MessageMasterId && mm.IsActive == messageMaster.IsActive);
            }
        }

        public List<PickListValue> GetPickListValue_ByPickListId(PickList pickList)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                }     return cvcEntities.PickListValues.Where(pl => pl.PickListId == pickList.PickListId).ToList();

            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        public string GetProtocolType(int machineParameterId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == machineParameterId);
                return machinePara?.Machine?.MachineCommunications?.FirstOrDefault()?.Protocol?.ProtocolName?.ToUpper()??"NA";
            }
        }

        public string GetProtocolTypeByMachineId(int machineId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                return cvcEntities?.MachineCommunications?.FirstOrDefault(a => a.MachineId == machineId)?.Protocol?.ProtocolName?.ToLower();
            }
        }


        //public void WriteValueCollectionForOPCUaClient(List<OPCUaClientWriteValues> lstOPCUaClientWriteValues)
        //{
        //    if (lstOPCUaClientWriteValues.Count > 0)
        //    {
        //        var opcUaClientViewModel = new OPCUaClientViewModel();
        //        opcUaClientViewModel.lstWriteValues = lstOPCUaClientWriteValues;

        //        ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
        //        clsOpcUaClient.WriteValueCollection(opcUaClientViewModel);
        //    }
        //}

        public MachineCommunicationViewModel GetMachineCommunicationDetailsByMachineId(int machineId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machineCommunicationViewModel = new MachineCommunicationViewModel();
                var machineCommunication = cvcEntities?.MachineCommunications?.FirstOrDefault(mc => mc.MachineId == machineId);
                if (machineCommunication != null)
                { 
                    var config = new MapperConfiguration(com => com.CreateMap<MachineCommunication, MachineCommunicationViewModel>());
                    var mapper = config.CreateMapper();
                    machineCommunicationViewModel = mapper.Map<MachineCommunicationViewModel>(machineCommunication);
                    machineCommunicationViewModel.SecurityMode = machineCommunication?.PickListValue?.PickListValueName;
                    machineCommunicationViewModel.SecurityPolicy = machineCommunication?.PickListValue1?.PickListValueName;
                    machineCommunicationViewModel.UserIdentity = machineCommunication?.PickListValue3?.PickListValueName;
                  
                }
                return machineCommunicationViewModel;
            }
        }

        public List<MachineParameterList> GetAllMachineParaeter(int machineId)
        {
            var machineParameterdata = (from mp in cvcEntities.MachineParameters
                                        where mp.MachineId==machineId &&  mp.StatusId == (int)ClsConstants.StatusType.Active
                                        orderby mp.ParameterName
                                        select new MachineParameterList { MachineParameterId = mp.MachineParameterId, ParameterName = mp.ParameterName });
            return machineParameterdata.ToList();

        }

        public void UpdateMachineCommunication(int machineId,bool isConnected)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machineCommunications = cvcEntities.MachineCommunications.FirstOrDefault(a => a.MachineId == machineId);
                if(machineCommunications!=null)
                {
                    machineCommunications.IsConnected = isConnected;
                    cvcEntities.SaveChanges();
                }
            }

        }

        public string GetAccessLevel(int? protocolId,string accessLevelId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
               return cvcEntities?.AccessLevels?.FirstOrDefault(al => al.ProtocolId == protocolId && al.Column1==accessLevelId)?.AceessLevelDescription;
               
            }
        }

        public Tuple<bool,string> ReadExcelDocument(string Path, string FileName,int columnHeaderRowNumber)
        {
            try
            {
                //var csvTable = new DataTable();
                //using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(HttpContext.Current.Server.MapPath(Path+FileName))), true))

                //{
                //    var data = csvReader;
                //    csvTable.Load(csvReader);
                //}

              FileStream stream = File.Open(HttpContext.Current.Server.MapPath(Path + FileName), FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                // DataSet result = excelReader.AsDataSet();
                // excelReader.i = true;



                var result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

               DataTable dt1 = result.Tables[0];

                dt1.Columns.Add("vvvvvvvvvv").SetOrdinal(0);
                //string text = dt1.Rows[1][0].ToString();





                var SplitFileName = FileName.Split('_');
                //Save the uploaded Excel file.
                string filePath = HttpContext.Current.Server.MapPath(Path + FileName);
                var isHeaderRowAvailable = false;
                DataTable dt = new DataTable();

                //Open the Excel file in Read Mode using OpenXml.
                using (SpreadsheetDocument doc = SpreadsheetDocument.Open(filePath, false))
                {
                    //Read the first Sheets from Excel file.
                    Sheet sheet = doc.WorkbookPart.Workbook.Sheets.GetFirstChild<Sheet>();

                    //Get the Worksheet instance.
                    Worksheet worksheet = (doc.WorkbookPart.GetPartById(sheet.Id.Value) as WorksheetPart).Worksheet;

                    //Fetch all the rows present in the Worksheet.
                    IEnumerable<Row> rows = worksheet.GetFirstChild<SheetData>().Descendants<Row>();


                    if (rows.Count() > 0)
                    {
                        //Create a new DataTable.

                        //Loop through the Worksheet rows.
                        foreach (Row row in rows)
                        {
                            //Use the first row to add columns to DataTable
                            if (row.RowIndex.Value == columnHeaderRowNumber)
                            {
                                dt.Columns.Add("SerialNumber");

                                foreach (Cell cell in row.Descendants<Cell>())
                                {
                                    dt.Columns.Add(GetValue(doc, cell, "", ""));
                                }
                                isHeaderRowAvailable = true;
                            }
                            else
                            {
                                var TableName = "";
                                var CellReference = "";

                                //Add rows to DataTable.
                                dt.Rows.Add();
                                int i = 1;
                                dt.Rows[dt.Rows.Count - 1][0] = row.RowIndex.Value-1;

                                foreach (Cell cell in row.Descendants<Cell>())
                                {
                                    dt.Rows[dt.Rows.Count - 1][i] = GetValue(doc, cell, CellReference, TableName);
                                    i++;
                                }
                            }
                        }
                    }
                    else
                    {
                        return new Tuple<bool, string>(false,ClsConstants.StatusMessage.DataNotFoundInUploadedFile);

                    }


                }

                if (!isHeaderRowAvailable)
                {
                    return new Tuple<bool, string>(false,ClsConstants.StatusMessage.HeaderNotFoundInUploadedFile);
                }

                if (dt.Rows.Count > 0)
                {
                    ObjectCache cache = MemoryCache.Default;
                    cache.Remove(ClsCacheConfig.CacheKeys.ImportedFileData);
                    CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                    cacheItemPolicy.AbsoluteExpiration = ClsCacheConfig.CacheExpiry.CacheExpiryTime;
                    cache.Add(ClsCacheConfig.CacheKeys.ImportedFileData, dt, cacheItemPolicy);
                }
                return new Tuple<bool, string>(true, ClsConstants.StatusMessage.DataFound);

            }
            catch (System.Exception ex)
            {
                return new Tuple<bool,string>(false, ex.Message);

            }
        }

        public Tuple<bool, string> ReadFileData(string path, string fileName, int columnHeaderRowNumber)
        {
            var dt = new DataTable();
            try
            {
                var fileExtension = string.Empty;
                var splitFileName = fileName.Split('.');
                fileExtension = splitFileName[1];
                if (fileExtension?.ToLower() == "csv")
                {                
                    using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(HttpContext.Current.Server.MapPath(path + fileName))), true))
                    {
                        var data = csvReader;
                        dt.Load(csvReader);
                    }

                }
                else
                {
                    FileStream stream = File.Open(HttpContext.Current.Server.MapPath(path + fileName), FileMode.Open, FileAccess.Read);
                    IExcelDataReader excelReader = null;

                    if (fileExtension?.ToLower() == "xls")
                    {
                       excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    else if (fileExtension?.ToLower() == "xlsx")
                    {
                        excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    //IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                    // DataSet result = excelReader.AsDataSet();
                    // excelReader.i = true;

                    var result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    dt = result.Tables[0];
                }

                var messageData =new ResponseViewModel <string>();
                if (dt.Rows.Count <= 0)
                {
                     messageData=GetMessageDetailsById((int)ClsConstants.MessageType.NoDataInUploadedFile);
                     return new Tuple<bool, string>(false,messageData.Data);
                }

                if (dt.Columns.Count<=0)
                {
                    messageData = GetMessageDetailsById((int)ClsConstants.MessageType.NoHeadersFoundInUploadedFile);
                    return new Tuple<bool, string>(false,messageData.Data);
                }


                if (dt.Rows.Count > 0)
                {
                    dt.Columns.Add("serialNumber").SetOrdinal(0);
                    dt.Columns.Add("Error Message").SetOrdinal(1);

                    for (int i=0;i<dt.Rows.Count;i++)
                    {
                        dt.Rows[i]["serialNumber"] = i + 1;
                    }

                    //ObjectCache cache = MemoryCache.Default;
                    //cache.Remove(ClsCacheConfig.CacheKeys.ImportedFildData);
                    //CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                    //cacheItemPolicy.AbsoluteExpiration = ClsCacheConfig.CacheExpiry.CacheExpiryTime;
                    //cache.Add(ClsCacheConfig.CacheKeys.ImportedFildData, dt, cacheItemPolicy);

                    foreach (DataColumn col in dt.Columns)
                    {
                       // col.DataType = typeof(object);
                        col.ReadOnly = false;
                        //dt.AcceptChanges();
                    }
                    ClsCacheConfig clsCacheConfig = new ClsCacheConfig();
                    clsCacheConfig.AddItemToCache(ClsCacheConfig.CacheKeys.ImportedFileData, dt);
                }
                messageData = GetMessageDetailsById((int)ClsConstants.MessageType.DataFound);

                return new Tuple<bool, string>(true, messageData.Data);

            }
            catch (System.Exception ex)
            {
                return new Tuple<bool, string>(false, ex.Message);

            }
        }

        public List<ListViewModel> GetEnumList(string enumType)
        {
            // var data =(GetEnumType(enumType));
            Array enumValueArray = Enum.GetValues(GetEnumType(enumType));
            List<ListViewModel> lstViewModel = new List<ListViewModel>();
            int i = 0;
            foreach (var item in enumValueArray)
            {

                ListViewModel listViewModel = new ListViewModel
                {
                    Text = GetEnumDescription(enumType, i + 1),
                    Value = i + 1,
                    MappedFieldText = item.ToString()
                };
                lstViewModel.Add(listViewModel);
                i++;
            }
            return lstViewModel;
        }


        public Type GetEnumType(string enumType)
        {
            Type returnEnumType=null;
            switch (enumType)
            {
                 case "role":
                     returnEnumType=  typeof(ClsEnum.RoleFormField);
                     break;

                 case "pack":
                     returnEnumType = typeof(ClsEnum.PackFormField);
                     break;

                case "outsert":
                    returnEnumType = typeof(ClsEnum.OutsertFormField);
                    break;

                case "label":
                    returnEnumType = typeof(ClsEnum.LabelFormField);
                    break;

                case "endOfLine":
                    returnEnumType = typeof(ClsEnum.EndOfLineFormField);
                    break;

                case "desiccant":
                    returnEnumType = typeof(ClsEnum.DesiccantFormField);
                    break;

                case "cotton":
                    returnEnumType = typeof(ClsEnum.CottonFormField);
                    break;

                case "cap":
                    returnEnumType = typeof(ClsEnum.CapFormField);
                    break;

                case "bottle":
                    returnEnumType = typeof(ClsEnum.BottleFormField);
                    break;

                case "machineParameter":
                    returnEnumType = typeof(ClsEnum.MachineParameterFormField);
                    break;

                case "machine":
                    returnEnumType = typeof(ClsEnum.MachineFormField);
                    break;

                case "alarm":
                    returnEnumType = typeof(ClsEnum.AlarmFormField);
                    break;

                case "protocol":
                    returnEnumType = typeof(ClsEnum.ProtocolFormField);
                    break;

                case "machineCommunication":
                    returnEnumType = typeof(ClsEnum.MachineCommunicationFormField);
                    break;

                case "ipcParameter":
                    returnEnumType = typeof(ClsEnum.IpcParameterFormField);
                    break;

                case "supplier":
                    returnEnumType = typeof(ClsEnum.SupplierFormField);
                    break;

                case "shift":
                    returnEnumType = typeof(ClsEnum.ShiftFormField);
                    break;

                case "department":
                    returnEnumType = typeof(ClsEnum.DepartmentFormField);
                    break;

                case "cityDetails":
                    returnEnumType = typeof(ClsEnum.CityFormField);
                    break;

                case "userManagement":
                    returnEnumType = typeof(ClsEnum.UserFormField);
                    break;

                case "pickListValue":
                    returnEnumType = typeof(ClsEnum.PickListValueFormField);
                    break;

                case "tabletDetails":
                    returnEnumType = typeof(ClsEnum.TabletDetailsFormField);
                    break;



            }
            return returnEnumType;
        }

        public string GetEnumDescription(string enumType,int enumValue)
        {
            var description = string.Empty;
            switch (enumType)
            {
                case "role":
                    description = ClsExtensionMethods.GetEnumDescription((RoleFormField)enumValue);
                    break;

                case "pack":
                    description = ClsExtensionMethods.GetEnumDescription((PackFormField)enumValue);
                    break;

                case "outsert":
                    description = ClsExtensionMethods.GetEnumDescription((OutsertFormField)enumValue);
                    break;

                case "label":
                    description = ClsExtensionMethods.GetEnumDescription((LabelFormField)enumValue);
                    break;

                case "endOfLine":
                    description = ClsExtensionMethods.GetEnumDescription((EndOfLineFormField)enumValue);
                    break;

                case "desiccant":
                    description = ClsExtensionMethods.GetEnumDescription((DesiccantFormField)enumValue);
                    break;

                case "cotton":
                    description = ClsExtensionMethods.GetEnumDescription((CottonFormField)enumValue);
                    break;

                case "cap":
                    description = ClsExtensionMethods.GetEnumDescription((CapFormField)enumValue);
                    break;

                case "bottle":
                    description = ClsExtensionMethods.GetEnumDescription((BottleFormField)enumValue);
                    break;

                case "machineParameter":
                    description = ClsExtensionMethods.GetEnumDescription((MachineParameterFormField)enumValue);
                    break;

                case "machine":
                    description = ClsExtensionMethods.GetEnumDescription((MachineFormField)enumValue);
                    break;

                case "alarm":
                    description = ClsExtensionMethods.GetEnumDescription((AlarmFormField)enumValue);
                    break;

                case "protocol":
                    description = ClsExtensionMethods.GetEnumDescription((ProtocolFormField)enumValue);
                    break;

                case "machineCommunication":
                    description = ClsExtensionMethods.GetEnumDescription((MachineCommunicationFormField)enumValue);
                    break;

                case "ipcParameter":
                    description = ClsExtensionMethods.GetEnumDescription((IpcParameterFormField)enumValue);
                    break;

                case "supplier":
                    description = ClsExtensionMethods.GetEnumDescription((SupplierFormField)enumValue);
                    break;

                case "shift":
                    description = ClsExtensionMethods.GetEnumDescription((ShiftFormField)enumValue);
                    break;

                case "department":
                    description = ClsExtensionMethods.GetEnumDescription((DepartmentFormField)enumValue);
                    break;

                case "cityDetails":
                    description = ClsExtensionMethods.GetEnumDescription((CityFormField)enumValue);
                    break;

                case "userManagement":
                    description = ClsExtensionMethods.GetEnumDescription((UserFormField)enumValue);
                    break;

                case "pickListValue":
                    description = ClsExtensionMethods.GetEnumDescription((PickListValueFormField)enumValue);
                    break;

                case "tabletDetails":
                    description = ClsExtensionMethods.GetEnumDescription((TabletDetailsFormField)enumValue);
                    break;

            }

            return description;
        }

        public ResponseViewModel<string> GetMessageDetailsById(int messageTypeId)
        {
            var response = new ResponseViewModel<string>();
            try
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var messageDetails = cVCEntities.MessageMasters.FirstOrDefault(m => m.MessageMasterId == messageTypeId && m.IsActive == true).MessageText;

                    if (messageDetails != null)
                    {
                        response = new ResponseViewModel<string>
                        {
                            IsStatus = true,
                            StatusMessage = StatusMessage.DataFound,
                            Data = messageDetails
                        };
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                return response;

            }
        }

        public bool CheckColumnExistInDataTable(DataTable dt, string columnName)
        {
            var isColumnExist = false;
            DataColumnCollection columns = dt.Columns;
            if (columns.Contains(columnName))
            {
                isColumnExist = true;
            }
            return isColumnExist;

        }

        public object GetTableDataByName(string type, string value)
        {
            object tableObject = null;
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                switch (type)
                {
                    case "status":
                        tableObject = cVCEntities.Status.FirstOrDefault(s => s.StatusName.ToLower() == value.ToLower());
                        break;

                    case "role":
                        tableObject = cVCEntities.Roles.FirstOrDefault(s => s.RoleName.ToLower() == value.ToLower());
                        break;

                    case "pickList":
                        tableObject = cVCEntities.PickLists.FirstOrDefault(s => s.PickListName.ToLower() == value.ToLower());
                        break;

                    case "supplier":
                        tableObject = cVCEntities.Suppliers.FirstOrDefault(s => s.SupplierName.ToLower() == value.ToLower());
                        break;

                    case "tablet":
                        tableObject = cVCEntities.TabletDetails.FirstOrDefault(s => s.TabletName.ToLower() == value.ToLower());
                        break;

                    case "bottle":
                        tableObject = cVCEntities.Bottles.FirstOrDefault(s => s.BottleName.ToLower() == value.ToLower());
                        break;

                    case "cap":
                        tableObject = cVCEntities.Caps.FirstOrDefault(s => s.CapName.ToLower() == value.ToLower());
                        break;

                    case "cotton":
                        tableObject = cVCEntities.Cotton.FirstOrDefault(s => s.CottonName.ToLower() == value.ToLower());
                        break;

                    case "desiccant":
                        tableObject = cVCEntities.Desiccants.FirstOrDefault(s => s.DesiccantName.ToLower() == value.ToLower());
                        break;

                    case "outsert":
                        tableObject = cVCEntities.Outserts.FirstOrDefault(s => s.OutsertName.ToLower() == value.ToLower());
                        break;

                    case "label":
                        tableObject = cVCEntities.Labels.FirstOrDefault(s => s.LabelName.ToLower() == value.ToLower());
                        break;

                    case "endOfLine":
                        tableObject = cVCEntities.EndOfLines.FirstOrDefault(s => s.EndOfLineName.ToLower() == value.ToLower());
                        break;

                    case "city":
                        tableObject = cVCEntities.CityDetails.FirstOrDefault(s => s.City.ToLower() == value.ToLower());
                        break;

                    case "machine":
                        tableObject = cVCEntities.Machines.FirstOrDefault(s => s.MachineName.ToLower() == value.ToLower());
                        break;

                    case "machineParameter":
                        tableObject = cVCEntities.MachineParameters.FirstOrDefault(s => s.ParameterName.ToLower() == value.ToLower());
                        break;

                    case "attribute":
                        tableObject = cVCEntities.Attributes.FirstOrDefault(s => s.Name.ToLower() == value.ToLower());
                        break;

                    case "dataType":
                        tableObject = cVCEntities.DataTypes.FirstOrDefault(s => s.DataTypeName.ToLower() == value.ToLower());
                        break;

                    case "pickListValue":
                        tableObject = cVCEntities.PickListValues.FirstOrDefault(s => s.PickListValueName.ToLower() == value.ToLower());
                        break;

                    case "protocol":
                        tableObject = cVCEntities.Protocols.FirstOrDefault(s => s.ProtocolName.ToLower() == value.ToLower());
                        break;

                    case "department":
                        tableObject = cVCEntities.Departments.FirstOrDefault(s => s.DepartmentName.ToLower() == value.ToLower());
                        break;



                }
            }

            return tableObject;
        }

        public void DeleteRowFromDataTable(DataTable dt, string serialNumber)
        {
            //var rows = dt.AsEnumerable()
            //      .Where(r => r.Field<string>("serialNumber") == serialNumber);
            //var rows1 = dt.AsEnumerable()
            //     .Where(r => r.Field<int>("serialNumber") ==Convert.ToInt32( serialNumber));



            DataRow dataRow = dt.AsEnumerable().FirstOrDefault(r =>r["serialNumber"].ToString() == serialNumber);
            if (dataRow != null)
            {
                dataRow.Delete();
            }


            //DataRow[] rows = dt.Select(expression);
            //dt.Rows[].Delete();
            //foreach (var row in rows)
            //{
            //    row.Delete();
            //}
            dt.AcceptChanges();
        }

        private void DeleteImportedFileData(string serialNumber)
        {
            var dt = new DataTable();
            var cacheData = clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileData);
            if (cacheData != null)
            {
              dt = (DataTable)cacheData;
            }

            string expression = $"serialNumber={serialNumber}";
            DataRow[] rows = dt.Select(expression);

            foreach (var row in rows)
            {
                row.Delete();
            }
            dt.AcceptChanges();
        }

        public string GetFileType(string fileExtension)
        {
            var fileType = string.Empty;
            switch(fileExtension)
            {
                case "csv":
                    fileType = Enum.GetName(typeof(RecordAddedSorceType), 1);
                    break;

                case "xls":
                case "xlsx":
                    fileType = Enum.GetName(typeof(RecordAddedSorceType), 2);
                    break;

            }
            return fileType;
        }

        public bool AddToImportLog(string action,int? userId=null,string formName=null)
        {
            var loggedUserIdCache = GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);
            var formNameCache = GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileFormName);

            using (CVCEntities cvcEntities = new CVCEntities())
            {
                ImportLog importLog = new ImportLog();
                importLog.UserId =loggedUserIdCache;
                importLog.FormName =formName==null?formNameCache:formName;
                importLog.Action = action;
                importLog.CreatedOn = DateTime.Now;
                cvcEntities.ImportLogs.Add(importLog);
                cvcEntities.SaveChanges();
            }
            return true;
        }

        #region Add Error Log
        public bool AddExceptionLog(string type,bool isProtected, int duplicateCount = 1,string host=null,string url=null,string httpMethod=null,string ipAddress=null,string sorce=null,string message=null,string detail=null,int? statusCode=null,string sql=null,string fullJson=null,int? errorHash=null)
        {
            try
            {            
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    Exception exception = new Exception
                    {
                        GUID = Convert.ToString(System.Guid.NewGuid()),
                        ApplicationName = "CVC IPC App",
                        MachineName = "NA",
                        CreationDate = DateTime.Now,
                        Type = type,
                        IsProtected = isProtected,
                        Host = host,
                        Url = url,
                        HTTPMethod = httpMethod,
                        IPAddress = ipAddress,
                        Source = sorce,
                        Message = message,
                        Detail = detail,
                        StatusCode = statusCode,
                        SQL = sql,
                        DeletionDate = DateTime.Now,
                        FullJson = fullJson,
                        ErrorHash = errorHash,
                        DuplicateCount = duplicateCount

                    };

                    cvcEntities.Exceptions.Add(exception);
                    cvcEntities.SaveChanges();
                }
            }
            catch(System.Exception ex)
            {
                return false;
            }
            return true;
        }
        #endregion

        public dynamic GetCacheData(string cacheKey)
        {
            object cacheData=null;
            switch(cacheKey)
            {
                case ClsCacheConfig.CacheKeys.LoggedUserId:
                cacheData =(int) clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);
                break;

                case ClsCacheConfig.CacheKeys.ImportedFilePreviousPageUrl:
                cacheData =(string) clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFilePreviousPageUrl);
                break;

                case ClsCacheConfig.CacheKeys.ImportedFileFormName:
                cacheData = (string)clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileFormName);
                break;

                case ClsCacheConfig.CacheKeys.ImportedFileData:
                cacheData = (DataTable)clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileData);
                break;

                case ClsCacheConfig.CacheKeys.ImportedFileColumnFieldMappingList:
                cacheData = (List<ColumnFieldMappingList>)clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileColumnFieldMappingList);
                break;

                case ClsCacheConfig.CacheKeys.ImportedFileDataAfterColumnFieldMapping:
                    cacheData = (DataTable)clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileDataAfterColumnFieldMapping);
                    break;

                case ClsCacheConfig.CacheKeys.ImportedFileName:
                    cacheData = (string)clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileName);
                    break;

                case ClsCacheConfig.CacheKeys.NextSessionRenewalTime:
                    cacheData = (DateTime)clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.NextSessionRenewalTime);
                    break;

                case ClsCacheConfig.CacheKeys.OPCUaConfigurationParameter:
                    cacheData = (MachineCommunicationViewModel)clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.OPCUaConfigurationParameter);
                    break;
                case ClsCacheConfig.CacheKeys.MachineCommunication:
                    cacheData = (MachineCommunicationViewModel)clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);
                    break;


            }
            return cacheData;

        }

        public string[] SplitByCapitalLetter(string str)
        {
            string[] split = Regex.Split(str, @"(?<!^)(?=[A-Z])");

            return split;

        }
        
        public string FirstCharToUpper(string str)
        {
            return str?.First().ToString().ToUpper() + str?.Substring(1).ToLower();
        }

        public CVC.Data.EDMX.User CheckUserLogin(string userName,string password)
        {
            CVC.Data.EDMX.User users = new CVC.Data.EDMX.User();
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                users = cVCEntities.Users.FirstOrDefault(u => u.Username == userName);

                if(users==null)
                {
                    return users;
                }
                if (WebSecurityHelper.Authenticate(ref userName,password, false))
                {
                    return users;
                }
                else
                {
                    users = null;
                }
                
            }
            return users;
        }

        public string GetRolePermissionKey(string type)
        {
            string permissionKey = string.Empty;
            switch (type)
            {
                case "role":
                    permissionKey = "Administration:Role:Import:Modify";
                    break;

                case "pack":
                    permissionKey = "PackSettings:Pack:Import:Modify";
                    break;

                case "outsert":
                    permissionKey = "PackSettings:Outsert:Import:Modify";
                    break;

                case "label":
                    permissionKey = "PackSettings:Label:Import:Modify";
                    break;

                case "endOfLine":
                    permissionKey = "PackSettings:EndOfLine:Import:Modify";
                    break;

                case "desiccant":
                    permissionKey = "PackSettings:Desiccant:Import:Modify";
                    break;

                case "cotton":
                    permissionKey = "PackSettings:Cotton:Import:Modify";
                    break;

                case "cap":
                    permissionKey = "PackSettings:Cap:Import:Modify";
                    break;

                case "bottle":
                    permissionKey = "PackSettings:Bottle:Import:Modify";
                    break;

                case "machineParameter":
                    permissionKey = "MachineCustomization:MachineParameter:Import:Modify";
                    break;

                case "machine":
                    permissionKey = "MachineCustomization:Machine:Import:Modify";
                    break;

                case "alarm":
                    permissionKey = "MachineCustomization:Alarm:Import:Modify";
                    break;

                case "protocol":
                    permissionKey = "ExternalApplicationInterface:Protocol:Import:Modify";
                    break;

                case "machineCommunication":
                    permissionKey = "ExternalApplicationInterface:MachineCommunication:Import:Modify";
                    break;

                case "ipcParameter":
                    permissionKey = "ExternalApplicationInterface:IpcParameter:Import:Modify";
                    break;

                case "supplier":
                    permissionKey = "Configuration:Supplier:Import:Modify";
                    break;

                case "shift":
                    permissionKey = "Configuration:Shift:Import:Modify";
                    break;

                case "department":
                    permissionKey = "Configuration:Department:Import:Modify";
                    break;

                case "cityDetails":
                    permissionKey = "Configuration:CityDetails:Import:Modify";
                    break;

                case "userManagement":
                    permissionKey = "Administration:User:Import:Modify";
                    break;

                case "pickListValue":
                    permissionKey = "Configuration:PickListValue:Import:Modify";
                    break;

                case "tabletDetails":
                    permissionKey = "PackSettings:TabletDetails:Import:Modify";
                    break;

                case "Restart PC":
                    permissionKey = "Administration:Role:RestartPC:Modify";
                    break;

                case "ShutDown PC":
                    permissionKey = "Administration:Role:ShutDownPC:Modify";
                    break;


            }
            return permissionKey;
        }

        public bool IsFieldExist(string param1,int param2=0,int param3=0)
        {
            View view=null;

            switch (param1)
            {
                case "IsCommandPanel":
                     view= cvcEntities.Views.FirstOrDefault(x => x.IsCommandPanel==true && x.ModuleId == param2);
                    break;
                case "IsMachineSummary":
                    view = cvcEntities.Views.FirstOrDefault(x => x.IsMachineSummary == true && x.ModuleId == param2);
                    break;
                case "IsMachineSettings":
                    view = cvcEntities.Views.FirstOrDefault(x => x.IsMachineSettings == true && x.ModuleId == param2);
                    break;
                case "IslabelRoll":
                    view = cvcEntities.Views.FirstOrDefault(x => x.IslabelRoll == true && x.ModuleId == param2);

                    break;

            }
            if (view != null)
            {
              
                  if(view.ViewsId==param3)
                    {
                        return false;
                    }
                                 
                return true;
            }
            else
            {
                return false;
            }

        }

        public string GetParsedValueForOperationType(string ParaValue, string OperationTypeName, decimal OperationValue)
        {
            try
            {
                switch (OperationTypeName?.ToLower())
                {
                    case "minus(-)":
                        ParaValue = (Decimal.Parse(ParaValue) - OperationValue).ToString();
                        break;
                    case "plus(+)":
                        ParaValue = (Decimal.Parse(ParaValue) + OperationValue).ToString();
                        break;
                    case "divide(/)":
                        ParaValue = (Math.Round(Decimal.Parse(ParaValue) / OperationValue, 2)).ToString();
                        break;
                    case "multiply(*)":
                        ParaValue = (Decimal.Parse(ParaValue) * OperationValue).ToString();
                        break;
                    default:

                        break;
                }
                return ParaValue;
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                ParaValue = null;
            }
            return ParaValue;


        }

        public DashBoardViewModel GetDashBoardViewModel(MachineCommunication machineCommunication)
        {
            DashBoardViewModel dashBoardViewModel = new DashBoardViewModel
            {
                IPAddress = machineCommunication?.IPAddress,
                TCPIPPort = machineCommunication?.TCPIPPort,
                Rack = machineCommunication?.Rack,
                Slot = machineCommunication?.Slot,
                CpuType = machineCommunication?.PickListValue6?.PickList?.PickListName,
            };
            return dashBoardViewModel;
        }


    }
    public static class ExtensionMethods
    {
        public static Int64 ParseInt64(this string value, int defaultInt64Value = 0)
        {
            long parsedInt64;
            if (Int64.TryParse(value, out parsedInt64))
            {
                return parsedInt64;
            }

            return defaultInt64Value;
        }
    }

}
