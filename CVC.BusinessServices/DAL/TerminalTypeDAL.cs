 using CVC.BusinessServices.Interface;
using CVC.Data.EDMX;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace CVC.BusinessServices.DAL
{
    public class TerminalTypeDAL
    {
        Common.CommonServices commonServices;
        public TerminalTypeDAL()
        {
            commonServices = new Common.CommonServices();
        }

        public List<TerminalTypeViewModel> GetAllTerminalType()
        {
            var lstterminalTypeViewModel = new List<TerminalTypeViewModel>();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var terminalTypes = cvcEntities.TerminalTypes.ToList();

                    lstterminalTypeViewModel = terminalTypes.Select((item, index) => new TerminalTypeViewModel
                    {
                        Id = index+1,
                        TerminalTypeId = item.TerminalTypeId,
                        TerminalTypeName = item.TerminalTypeName,
                        Description = item.Description,
                        IsActive = item.IsActive,
                        IsRead = item.IsRead,
                        IsWrite = item.IsWrite

                    }).ToList();
                }
                return lstterminalTypeViewModel;
            }
            catch (System.Exception ex)
            {
                return lstterminalTypeViewModel;
            }
        }

        public List<TerminalTypeViewModel> GetAllActiveTerminalType(TerminalTypeViewModel terminalTypeViewModel)
        {
            var lstterminalTypeViewModel = new List<TerminalTypeViewModel>();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var terminalTypes = cvcEntities.TerminalTypes.Where(tt=>tt.IsActive==terminalTypeViewModel.IsActive).ToList();

                    lstterminalTypeViewModel = terminalTypes.Select((item, index) => new TerminalTypeViewModel
                    {
                        Id = index + 1,
                        TerminalTypeId = item.TerminalTypeId,
                        TerminalTypeName = item.TerminalTypeName,
                        Description = item.Description,
                        IsActive = item.IsActive,
                        IsRead = item.IsRead,
                        IsWrite = item.IsWrite

                    }).ToList();
                }
                return lstterminalTypeViewModel;
            }
            catch (System.Exception ex)
            {
                return lstterminalTypeViewModel;
            }
        }


        public TerminalTypeViewModel GetTerminalType(TerminalTypeViewModel terminalTypeViewModel)
        {
            var terminalType = new TerminalTypeViewModel();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var terminalTypeDetails = cvcEntities.TerminalTypes.FirstOrDefault(t => t.TerminalTypeId == terminalTypeViewModel.TerminalTypeId);

                    terminalType.TerminalTypeId = terminalTypeDetails.TerminalTypeId;
                    terminalType.TerminalTypeName = terminalTypeDetails.TerminalTypeName;
                    terminalType.Description = terminalTypeDetails.Description;
                    terminalType.IsActive = terminalTypeDetails.IsActive;
                    terminalType.IsRead = terminalTypeDetails.IsRead;
                    terminalType.IsWrite = terminalTypeDetails.IsWrite;

                }
                return terminalType;
            }
            catch (System.Exception ex)
            {
                return terminalType;
            }
        }

        public object SaveTerminalType(TerminalTypeViewModel terminalTypeViewModel)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var isExist = cvcEntities.TerminalTypes.FirstOrDefault(tt => tt.TerminalTypeName.ToLower() == terminalTypeViewModel.TerminalTypeName.ToLower());

                    if(isExist!=null)
                    {
                        return new { status = false, message = "Terminal type already exist" };
                    }
                    int? userId = null;
                    if (HttpContext.Current.Session["CVCUserId"] != null)
                    {
                        userId = Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString());
                    }
                    var terminalType = new TerminalType
                    {
                        TerminalTypeName = terminalTypeViewModel.TerminalTypeName,
                        Description = terminalTypeViewModel.Description,
                        IsRead = terminalTypeViewModel.IsRead,
                        IsWrite = terminalTypeViewModel.IsWrite,
                        IsActive = terminalTypeViewModel.IsActive,
                        CreatedOn = DateTime.Now,
                        CreatedBy = userId
                    };
                    cvcEntities.TerminalTypes.Add(terminalType);
                    cvcEntities.SaveChanges();
                    AddAuditLog(terminalTypeViewModel);
                    return new { status = true, message = "Data saved successfully" };

                }
            }
            catch (System.Exception ex)
            {
                return new { status = false, message = "Error while saving data" };
            }
        }

        public object UpdateTerminalType(TerminalTypeViewModel terminalTypeViewModel)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var isExist = cvcEntities.TerminalTypes.FirstOrDefault(tt => tt.TerminalTypeName.ToLower() == terminalTypeViewModel.TerminalTypeName.ToLower() && tt.TerminalTypeId!=terminalTypeViewModel.TerminalTypeId);

                    if (isExist != null)
                    {
                        return new { status = false, message = "Terminal type already exist" };
                    }
                    int? userId = null;
                    if (HttpContext.Current.Session["CVCUserId"] != null)
                    {
                        userId = Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString());
                    }
                    var terminalTypes = cvcEntities.TerminalTypes.SingleOrDefault(m => m.TerminalTypeId == terminalTypeViewModel.TerminalTypeId);

                    terminalTypeViewModel.OldTerminalTypeName = terminalTypes.TerminalTypeName;
                    terminalTypeViewModel.OldDescription = terminalTypes.Description;
                    terminalTypeViewModel.OldIsRead = terminalTypes.IsRead;
                    terminalTypeViewModel.OldIsWrite = terminalTypes.IsWrite;
                    terminalTypeViewModel.OldIsActive = terminalTypes.IsActive;

                    terminalTypes.TerminalTypeName = terminalTypeViewModel.TerminalTypeName;
                    terminalTypes.Description = terminalTypeViewModel.Description;
                    terminalTypes.IsRead = terminalTypeViewModel.IsRead;
                    terminalTypes.IsWrite = terminalTypeViewModel.IsWrite;
                    terminalTypes.IsActive = terminalTypeViewModel.IsActive;
                    terminalTypes.EditedOn = DateTime.Now;
                    terminalTypes.EditedBy =userId;
                    cvcEntities.SaveChanges();
                }
                AddAuditLog(terminalTypeViewModel);
                return new { status = true, message = "Data saved successfully" };

            }
            catch (System.Exception ex)
            {
                return new { status = true, message = "Error while saving data" };
            }
        }

        private void AddAuditLog(TerminalTypeViewModel terminalTypeViewModel)
        {
            var propertyInfos = terminalTypeViewModel.GetType().GetProperties();
            int userId = HttpContext.Current.Session["CVCUserId"] != null ? Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString()) : 0;
            var userDetails = commonServices.GetUserDetailsByUserId(userId);

            //var userDetails = commonServices.GetUserDetailsByUserId(Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString()));
            List<AuditLog> lstAuditLog = new List<AuditLog>();
            foreach (PropertyInfo pInfo in propertyInfos)
            {
                string propertyName = pInfo.Name; 
                var propertyValue = (pInfo.GetValue(terminalTypeViewModel, null));
                var oldValue = "";
                if (terminalTypeViewModel.TerminalTypeId > 0)
                {
                    if (propertyName == "TerminalTypeName")
                    {
                        oldValue = terminalTypeViewModel.OldTerminalTypeName;
                    }
                    if (propertyName == "Description")
                    {
                        oldValue = terminalTypeViewModel.OldDescription;

                    }
                    if (propertyName == "IsRead")
                    {
                        oldValue = terminalTypeViewModel.OldIsRead ? "True" : "False";
                    }
                    if (propertyName == "IsWrite")
                    {
                        oldValue = terminalTypeViewModel.OldIsWrite ? "True" : "False";
                    }
                    if (propertyName == "IsActive")
                    {
                        oldValue = terminalTypeViewModel.OldIsActive ? "True" : "False";

                    }
                }
                
                if (propertyName == "TerminalTypeName" || propertyName == "Description" || propertyName == "IsRead" || propertyName == "IsWrite" || propertyName == "IsActive")
                {
                    AuditLog auditLog = new AuditLog
                    {
                        Action = "Add Terminal Type",
                        Module = "Machine Customization",
                        Page = "Terminal Type",
                        FieldName = propertyName,
                        OldValue = oldValue,
                        NewValue = Convert.ToString(propertyValue),
                        User = userDetails,
                        // UserName= userDetails.Username,
                        // UserId = Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString()),
                    };
                    lstAuditLog.Add(auditLog);

                }

            }
            commonServices.AddAuditLog(lstAuditLog);
        }
    }

}
