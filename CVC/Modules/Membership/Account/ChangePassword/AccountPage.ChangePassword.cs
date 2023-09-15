

using CVC.Administration;
using CVC.Administration.Entities;
using CVC.Administration.Repositories;
//using CVC.BusinessServices.Common;
using CVC.BusinessServices.DAL;
using CVC.Common;
using CVC.Data;
using CVC.Data.EDMX;
using CVC.Modules.Common.CommonServices;
using CVC.Modules.Common.Dashboard;
using CVC.SiemensS7Net;
using CVC.ViewModels;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web;
using Serenity.Web.Providers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using static CVC.BusinessServices.Common.ClsConstants;
using bs = CVC.BusinessServices.Common;
using ms = CVC.Modules.Common.CommonServices;
namespace CVC.Membership.Pages
{
    [RoutePrefix("Account")]
    [Route("{action=index}")]

    public class AccountController : ServiceEndpoint
    {
        public static bool UseAdminLTELoginBox;
        ms.CommonServices msCommonServices = new ms.CommonServices();
        bs.CommonServices bsCommonServices = new bs.CommonServices();

        TerminalMasterDAL terminalMasterDAL;
        MachineDAL machineDAL;
        bs.ClsCacheConfig clsCacheConfig = new bs.ClsCacheConfig();

        public AccountController()
        {
            terminalMasterDAL = new TerminalMasterDAL();
            machineDAL = new MachineDAL();
        }

        [HttpGet]
        // [Authorize]
        public ActionResult ChangePassword()
        {
            if (Session["CVCUserId_ForChangePassword"] == null)
            {
                Session["CVCUserId_ForChangePassword"] = Serenity.Authorization.UserId;
                Session["CVCUserName_ForChangePassword"] = Serenity.Authorization.Username;
            }


            return (ActionResult)this.View("~/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml");
        }


        #region Change Password
        [HttpPost]
        [JsonFilter]
        // [ServiceAuthorize]
        public Result<ServiceResponse> ChangePassword(ChangePasswordRequest request)
        {

            return this.InTransaction<ServiceResponse>("Default", (Func<IUnitOfWork, ServiceResponse>)(uow =>
            {
                int CVCUserId = Convert.ToInt32(Session["CVCUserId_ForChangePassword"]);
                request.CheckNotNull();
                if (string.IsNullOrEmpty(request.OldPassword))
                    throw new ArgumentNullException("oldPassword");
                string username = Session["CVCUserName_ForChangePassword"].ToString();
                // string username = Authorization.Username;
                if (!Dependency.Resolve<IAuthenticationService>().Validate(ref username, request.OldPassword))
                    throw new Serenity.Services.ValidationError("CurrentPasswordMismatch", (string)CVC.Texts.Validation.CurrentPasswordMismatch);
                if (request.ConfirmPassword != request.NewPassword)
                    throw new Serenity.Services.ValidationError("PasswordConfirmMismatch", LocalText.Get("Validation.PasswordConfirm"));

                CheckPreviousPasswordLimit(CVCUserId, request.NewPassword);

                request.NewPassword = UserRepository.ValidatePassword(username, request.NewPassword, false);
                string password = System.Web.Security.Membership.GeneratePassword(5, 1);
                string shA512 = SiteMembershipProvider.ComputeSHA512(request.NewPassword + password);
                //int num1 = int.Parse(Authorization.UserId);

                UserRepository.CheckPublicDemo(new int?(CVCUserId));
                IDbConnection connection = uow.Connection;
                UserRow row = new UserRow();
                row.UserId = new int?(CVCUserId);
                row.PasswordSalt = password;
                row.PasswordHash = shA512;
                row.IsPasswordChangeOnLogin = false;
                int num2 = 0;
                // Update Password Expiry 
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var environment = cvcEntities.EnvironmentVariables.FirstOrDefault();
                    if (environment != null)
                    {

                        row.PasswordExpiryDate = DateTime.Now.AddDays(environment.PasswordExpiryInDays.Value);
                    }
                }

                // End
                User objUser = new User
                {
                    UserId = Convert.ToInt32(Session["CVCUserId_ForChangePassword"]),
                    Username = Session["CVCUserName_ForChangePassword"].ToString()

                };

                PasswordViewModel objPasswordViewModel = new PasswordViewModel
                {
                    UserId = CVCUserId,
                    PasswordHash = shA512,
                    PasswordSalt = password,
                    CreatedOn = DateTime.Now

                };

                CVC.BusinessServices.Common.CommonServices objCommonServices = new CVC.BusinessServices.Common.CommonServices();

                bool Response = objCommonServices.CreatePassword(objPasswordViewModel);

                ms.CommonServices.AddAuditLog("Change Password", "", "", "", "", "", null, null, objUser);

                connection.UpdateById<UserRow>(row, (ExpectedRows)num2);
                BatchGenerationUpdater.OnCommit(uow, UserRow.Fields.GenerationKey);
                Session["CVCUserName_ForChangePassword"] = null;
                Session["CVCUserId_ForChangePassword"] = null;
                return new ServiceResponse();
            }));
        }
        #endregion

        [HttpGet]
        public ActionResult ForgotPassword()
        {
            if (AccountController.UseAdminLTELoginBox)
                return (ActionResult)this.View("~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.AdminLTE.cshtml");
            return (ActionResult)this.View("~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml");
        }
        [HttpGet]
        public ActionResult LDAP()
        {
            return (ActionResult)this.View("~/Modules/Membership/Account/LDAP/AccountLDAP.cshtml");

        }

        #region ForgotPassword
        [HttpPost]
        [JsonFilter]
        public Result<ServiceResponse> ForgotPassword(ForgotPasswordRequest request)
        {
            return this.UseConnection<ServiceResponse>("Default", (Func<IDbConnection, ServiceResponse>)(connection =>
            {
                request.CheckNotNull();
                if (string.IsNullOrEmpty(request.Username))
                    throw new ArgumentNullException("email");
                UserRow userRow = connection.TryFirst<UserRow>((ICriteria)((Field)UserRow.Fields.Username == request.Username));
                if (userRow == null)
                    throw new Serenity.Services.ValidationError("CantFindUserWithUsername", (string)CVC.Texts.Validation.CantFindUserWithUsername);
                if (request.PasswordConfirm != request.Password)
                    throw new Serenity.Services.ValidationError("PasswordConfirmMismatch", "Password and Confirm Password does not match");
                UserRepository.ValidatePassword(request.Username, request.Password, false);

                UserRow securityq = connection.TryFirst<UserRow>((ICriteria)((Field)UserRow.Fields.Username == request.Username && (Field)UserRow.Fields.QuestionId == request.QuestionId && (Field)UserRow.Fields.QuestionAns == request.QuestionAns));
                if (securityq == null)
                    throw new Serenity.Services.ValidationError("CantFindUserWithUsername", "Please enter correct details");

                CheckPreviousPasswordLimit((int)securityq.UserId, request.PasswordConfirm);


                UserRow row = new UserRow();
                row.UserId = securityq.UserId;
                string salt = (string)null;
                row.PasswordHash = UserRepository.GenerateHash(request.Password, ref salt);
                row.PasswordSalt = salt;
                int num2 = 0;

                PasswordViewModel objPasswordViewModel = new PasswordViewModel
                {
                    UserId = (int)securityq.UserId,
                    PasswordHash = row.PasswordHash,
                    PasswordSalt = salt,
                    CreatedOn = DateTime.Now

                };

                CVC.BusinessServices.Common.CommonServices objCommonServices = new CVC.BusinessServices.Common.CommonServices();
                bool Response = objCommonServices.CreatePassword(objPasswordViewModel);
                User objUser = new User
                {
                    UserId = (int)securityq.UserId,
                    Username = request.Username

                };
                ms.CommonServices.AddAuditLog("Forgot Password", "", "", "", "", "", null, null, objUser);
                connection.UpdateById<UserRow>(row, ExpectedRows.One);



                //byte[] array;
                //using (MemoryStream memoryStream = new MemoryStream())
                //{
                //    using (BinaryWriter binaryWriter1 = new BinaryWriter((Stream)memoryStream))
                //    {
                //        BinaryWriter binaryWriter2 = binaryWriter1;
                //        DateTime dateTime = DateTime.UtcNow;
                //        dateTime = dateTime.AddHours(3.0);
                //        long binary = dateTime.ToBinary();
                //        binaryWriter2.Write(binary);
                //        binaryWriter1.Write(userRow.UserId.Value);
                //        binaryWriter1.Flush();
                //        array = memoryStream.ToArray();
                //    }
                //}
                //Convert.ToBase64String(MachineKey.Protect(array, "ResetPassword"));
                //if (Config.Get<EnvironmentSettings>().SiteExternalUrl == null)
                //{
                //    string str = this.Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");
                //}
                return new ServiceResponse();
            }));
        }
        #endregion

        [HttpGet]
        public ActionResult ResetPassword(string t)
        {
            int num;
            try
            {
                using (MemoryStream memoryStream = new MemoryStream(MachineKey.Unprotect(Convert.FromBase64String(t), nameof(ResetPassword))))
                {
                    using (BinaryReader binaryReader = new BinaryReader((Stream)memoryStream))
                    {
                        if (DateTime.FromBinary(binaryReader.ReadInt64()) < DateTime.UtcNow)
                            return this.Error((string)CVC.Texts.Validation.InvalidResetToken);
                        num = binaryReader.ReadInt32();
                        memoryStream.Dispose();
                    }
                }
            }
            catch (System.Exception ex)
            {
                return this.Error((string)CVC.Texts.Validation.InvalidResetToken);
            }
            using (IDbConnection connection = SqlConnections.NewFor<UserRow>())
            {
                if (connection.TryById<UserRow>((object)num) == null)
                    return this.Error((string)CVC.Texts.Validation.InvalidResetToken);
            }
            if (AccountController.UseAdminLTELoginBox)
                return (ActionResult)this.View("~/Modules/Membership/Account/ResetPassword/AccountResetPassword.AdminLTE.cshtml", (object)new ResetPasswordModel()
                {
                    Token = t
                });
            return (ActionResult)this.View("~/Modules/Membership/Account/ResetPassword/AccountResetPassword.cshtml", (object)new ResetPasswordModel()
            {
                Token = t
            });
        }

        [HttpPost]
        [JsonFilter]
        public Result<ServiceResponse> ResetPassword(ResetPasswordRequest request)
        {
            return this.InTransaction<ServiceResponse>("Default", (Func<IUnitOfWork, ServiceResponse>)(uow =>
            {
                request.CheckNotNull();
                if (string.IsNullOrEmpty(request.Token))
                    throw new ArgumentNullException("token");
                int num1;
                using (MemoryStream memoryStream = new MemoryStream(MachineKey.Unprotect(Convert.FromBase64String(request.Token), nameof(ResetPassword))))
                {
                    using (BinaryReader binaryReader = new BinaryReader((Stream)memoryStream))
                    {
                        if (DateTime.FromBinary(binaryReader.ReadInt64()) < DateTime.UtcNow)
                            throw new Serenity.Services.ValidationError((string)CVC.Texts.Validation.InvalidResetToken);
                        num1 = binaryReader.ReadInt32();
                    }
                }
                UserRow userRow;
                using (IDbConnection connection = SqlConnections.NewFor<UserRow>())
                {
                    userRow = connection.TryById<UserRow>((object)num1);
                    if (userRow == null)
                        throw new Serenity.Services.ValidationError((string)CVC.Texts.Validation.InvalidResetToken);
                }
                if (request.ConfirmPassword != request.NewPassword)
                    throw new Serenity.Services.ValidationError("PasswordConfirmMismatch", LocalText.Get("Validation.PasswordConfirm"));
                request.NewPassword = UserRepository.ValidatePassword(userRow.Username, request.NewPassword, false);
                string password = System.Web.Security.Membership.GeneratePassword(5, 1);
                string shA512 = SiteMembershipProvider.ComputeSHA512(request.NewPassword + password);
                UserRepository.CheckPublicDemo(userRow.UserId);
                IDbConnection connection1 = uow.Connection;
                UserRow row = new UserRow();
                row.UserId = new int?(userRow.UserId.Value);
                row.PasswordSalt = password;
                row.PasswordHash = shA512;
                int num2 = 0;
                connection1.UpdateById<UserRow>(row, (ExpectedRows)num2);
                BatchGenerationUpdater.OnCommit(uow, UserRow.Fields.GenerationKey);
                return new ServiceResponse();
            }));
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            if (AccountController.UseAdminLTELoginBox)
                return (ActionResult)this.View("~/Modules/Membership/Account/SignUp/AccountSignUp.AdminLTE.cshtml");
            return (ActionResult)this.View("~/Modules/Membership/Account/SignUp/AccountSignUp.cshtml");
        }

        [HttpPost]
        [JsonFilter]
        public Result<ServiceResponse> SignUp(SignUpRequest request)
        {
            return this.UseConnection<ServiceResponse>("Default", (Func<IDbConnection, ServiceResponse>)(connection =>
            {
                request.CheckNotNull();
                Check.NotNullOrWhiteSpace(request.Email, "email");
                Check.NotNullOrEmpty(request.Password, "password");
                UserRepository.ValidatePassword(request.Email, request.Password, true);
                Check.NotNullOrWhiteSpace(request.FirstName, "firstName");
                Check.NotNullOrWhiteSpace(request.FirstName, "lastName");
                if (connection.Exists<UserRow>((ICriteria)((Field)UserRow.Fields.Username == request.Email | (Field)UserRow.Fields.Email == request.Email)))
                    throw new Serenity.Services.ValidationError("EmailInUse", (string)CVC.Texts.Validation.EmailInUse);
                using (UnitOfWork unitOfWork = new UnitOfWork(connection))
                {
                    string salt = (string)null;
                    string hash = UserRepository.GenerateHash(request.Password, ref salt);
                    string empty1 = request.FirstName.TrimToEmpty();
                    string empty2 = request.LastName.TrimToEmpty();
                    string email1 = request.Email;
                    string email2 = request.Email;
                    UserRow.RowFields fields = UserRow.Fields;
                    int num = (int)connection.InsertAndGetID<UserRow>(new UserRow()
                    {
                        Username = email2,
                        FirstName = empty1,
                        LastName = empty2,
                        Email = email1,
                        PasswordHash = hash,
                        PasswordSalt = salt,
                        StatusId = new short?((short)2)
                    }).Value;
                    byte[] array;
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (BinaryWriter binaryWriter1 = new BinaryWriter((Stream)memoryStream))
                        {
                            BinaryWriter binaryWriter2 = binaryWriter1;
                            DateTime dateTime = DateTime.UtcNow;
                            dateTime = dateTime.AddHours(3.0);
                            long binary = dateTime.ToBinary();
                            binaryWriter2.Write(binary);
                            binaryWriter1.Write(num);
                            binaryWriter1.Flush();
                            array = memoryStream.ToArray();
                        }
                    }
                    string str = Serenity.UriHelper.Combine(Config.Get<EnvironmentSettings>().SiteExternalUrl ?? this.Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/"), "Account/Activate?t=") + Uri.EscapeDataString(Convert.ToBase64String(MachineKey.Protect(array, "Activate")));
                    EmailHelper.Send(CVC.Texts.Forms.Membership.SignUp.ActivateEmailSubject.ToString(), TemplateHelper.RenderTemplate<ActivateEmailModel>("~/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml", new ActivateEmailModel()
                    {
                        Username = email2,
                        FirstName = empty1,
                        LastName = empty2,
                        ActivateLink = str
                    }), email1, "");
                    unitOfWork.Commit();
                    UserRetrieveService.RemoveCachedUser(new int?(num), email2);
                    return new ServiceResponse();
                }
            }));
        }

        [HttpGet]
        public ActionResult Activate(string t)
        {
            using (IDbConnection connection1 = SqlConnections.NewByKey("Default"))
            {
                using (UnitOfWork unitOfWork = new UnitOfWork(connection1))
                {
                    int num1;
                    try
                    {
                        using (MemoryStream memoryStream = new MemoryStream(MachineKey.Unprotect(Convert.FromBase64String(t), nameof(Activate))))
                        {
                            using (BinaryReader binaryReader = new BinaryReader((Stream)memoryStream))
                            {
                                if (DateTime.FromBinary(binaryReader.ReadInt64()) < DateTime.UtcNow)
                                    return this.Error((string)CVC.Texts.Validation.InvalidActivateToken);
                                num1 = binaryReader.ReadInt32();
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        return this.Error((string)CVC.Texts.Validation.InvalidActivateToken);
                    }
                    UserRow userRow = unitOfWork.Connection.TryById<UserRow>((object)num1);
                    if (userRow != null)
                    {
                        short? statusId = userRow.StatusId;
                        int? nullable = statusId.HasValue ? new int?((int)statusId.GetValueOrDefault()) : new int?();
                        int num2 = 0;
                        if ((nullable.GetValueOrDefault() == num2 ? (!nullable.HasValue ? 1 : 0) : 1) == 0)
                        {
                            IDbConnection connection2 = unitOfWork.Connection;
                            UserRow row = new UserRow();
                            row.UserId = new int?(userRow.UserId.Value);
                            row.StatusId = new short?((short)1);
                            int num3 = 0;
                            connection2.UpdateById<UserRow>(row, (ExpectedRows)num3);
                            BatchGenerationUpdater.OnCommit((IUnitOfWork)unitOfWork, UserRow.Fields.GenerationKey);
                            unitOfWork.Commit();
                            return (ActionResult)new RedirectResult("~/Account/Login?activated=" + Uri.EscapeDataString(userRow.Email));
                        }
                    }
                    return this.Error((string)CVC.Texts.Validation.InvalidActivateToken);
                }
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
        public ActionResult Login(string activated)
        {
            //DashBoardField dashBoardField = new DashBoardField
            //{
            //    IPCAddress = "",
            //    DataTypeName = ""
            //};
            //List<DashBoardField> dashBoardFields = new List<DashBoardField>();
            //dashBoardFields.Add(dashBoardField);
            //DashBoardViewModel dashBoardViewModel = new DashBoardViewModel
            //{
            //    IPAddress = "",
            //    TCPIPPort = 1,
            //    Rack = 0,
            //    Slot = 1,
            //    ViewFieldList=dashBoardFields
            //};

            //var result= new ClsSiemensS7Net( ).Read(dashBoardViewModel);
            this.ViewData["Activated"] = (object)activated;
            this.ViewData["HideLeftNavigation"] = (object)true;
            if (AccountController.UseAdminLTELoginBox)
                return (ActionResult)this.View("~/Modules/Membership/Account/AccountLogin.AdminLTE.cshtml");
            return (ActionResult)this.View("~/Modules/Membership/Account/AccountLogin.cshtml");
        }

        [HttpGet]
        public ActionResult AccessDenied(string returnURL)
        {
            this.ViewData["HideLeftNavigation"] = (object)!Authorization.IsLoggedIn;
            return (ActionResult)this.View("~/Views/Errors/AccessDenied.cshtml", (object)returnURL);
        }

        [HttpPost]
        [JsonFilter]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
        // [ValidateAntiForgeryToken]
        public JsonResult Login(LoginRequest request)
        {
            try
            {
              
                request.CheckNotNull();
                if (string.IsNullOrEmpty(request.Username))
                    throw new ArgumentNullException("username");
                //CVCEntities cvcEntities = new CVCEntities();
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var messageDetails = new MessageMaster();

                    var userDetails = cvcEntities.Users.FirstOrDefault(a => a.Username.ToLower() == request.Username.ToLower());

                    HttpContext.Cache["MessageMasrerCache"] = cvcEntities.MessageMasters.Where(mm => mm.IsActive).ToList();
                    List<CVC.Data.EDMX.MessageMaster> messageMasterCache = (List<CVC.Data.EDMX.MessageMaster>)HttpContext.Cache["MessageMasrerCache"];
                    ViewBag.MessageMasrerData = messageMasterCache.ToList();
                    var pickListValue = "Alert Message";

                    #region Find requested client Mac Address
                    CVC.BusinessServices.Common.CommonServices commonServices = new BusinessServices.Common.CommonServices();

                    var IpAddress = Request.UserHostAddress;
                    ms.CommonServices.AddAuditLog($"{IpAddress} is ip address of machine", "Login", "", "", "", "", null, null, userDetails);

                    var getClientMacAddress = string.Empty;
                    var macAddressAfterHypen = string.Empty;
                    if (IpAddress == GetIpAddress.LocalIpAddress || IpAddress == GetIpAddress.LocalIpAddress1 || IpAddress == GetIpAddress.LocalIpAddress2)
                    {
                        getClientMacAddress = commonServices.GetServerMacAddress();
                        macAddressAfterHypen = Hyphenate(getClientMacAddress, 2);
                    }
                    else
                    {
                        macAddressAfterHypen = commonServices.GetClientMacAddress(IpAddress);
                    }
                    //macAddressAfterHypen = "FC-AA-14-AE-9E-10";
                    // GetMacAddress("192.168.1.218");
                    if (!string.IsNullOrEmpty(macAddressAfterHypen))
                    {

                        MasterTerminlsModel masterTerminlsModel = new MasterTerminlsModel
                        {
                            MacAddress = macAddressAfterHypen

                        };
                        object response = "";
                        response = terminalMasterDAL.GetTerminalDetails(masterTerminlsModel);
                        var status = commonServices.GetPropertyValue(response, "status");
                        var message = commonServices.GetPropertyValue(response, "message");
                        object data = commonServices.GetPropertyValue(response, "data");
                        // object getStatus = false;
                        object getMessage = message;
                        bool getStatus = Convert.ToBoolean(status);

                        if (getStatus == false)
                        {

                            //MessageMaster messageMaster = new MessageMaster()
                            //{
                            //    MessageMasterId =(int) MessageType.NonRegisteredTerminal,
                            //    IsActive = (int)StatusType.Active == 1 ? true : false
                            //};
                            messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.NonRegisteredTerminal);

                            ms.CommonServices.AddAuditLog($"{macAddressAfterHypen} Terminal is not registered", "Login", "", "", "", "", null, null, userDetails);

                            return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText.Replace("#MacAddress", macAddressAfterHypen) }, JsonRequestBehavior.AllowGet);
                            // throw new Serenity.Services.ValidationError("Error", $"{messageDetails.MessageText}");
                        }
                        else
                        {
                            ms.CommonServices.AddAuditLog($"{macAddressAfterHypen} Terminal is Login", "Login", "", "", "", "", null, null, userDetails);

                            CVC.ViewModels.MasterTerminlsModel objmasterTerminlsModel = (CVC.ViewModels.MasterTerminlsModel)data;
                            Session["TerminalId"] = objmasterTerminlsModel.ID;
                            if (objmasterTerminlsModel.IsActiveTerminalType == false)
                            {
                                ms.CommonServices.AddAuditLog($"Terminal type ({objmasterTerminlsModel.TerminalType}) of {objmasterTerminlsModel.TerminalName} is In-Active", "Login", "", "", "", "", null, null, userDetails);
                                messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.InActiveTerminalType);
                                return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                                // throw new Serenity.Services.ValidationError("Error", $"{messageDetails.MessageText}");

                            }
                            else if (objmasterTerminlsModel.IsActiveTerminalType == true)
                            {
                                if (objmasterTerminlsModel.IsActive == 2)
                                {
                                    ms.CommonServices.AddAuditLog($"{objmasterTerminlsModel.TerminalName} is In-Active", "Login", "", "", "", "", null, null, userDetails);
                                    messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.InActiveTerminal);
                                    return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText.Replace("#MacAddress", macAddressAfterHypen) }, JsonRequestBehavior.AllowGet);

                                    //  throw new Serenity.Services.ValidationError("Error", $"{messageDetails.MessageText}");
                                }
                                else
                                {
                                    MachineTerminalMapping machineTerminalMapping = new MachineTerminalMapping
                                    {
                                        TerminalId = (int)objmasterTerminlsModel.ID
                                    };
                                    var getMappedMacines = terminalMasterDAL.GetMachinesByTerminalId(machineTerminalMapping);

                                    if (getMappedMacines.Count == 0)
                                    {
                                        ms.CommonServices.AddAuditLog($"No machine mapped to {objmasterTerminlsModel.TerminalName}", "Login", "", "", "", "", null, null, userDetails);
                                        messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.NoMachineMappedToTerminal);

                                        return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText.Replace("#MacAddress", macAddressAfterHypen) }, JsonRequestBehavior.AllowGet);

                                        // throw new Serenity.Services.ValidationError("Error", $"{messageDetails.MessageText}");
                                    }
                                    else
                                    {
                                        if (userDetails == null)
                                        {
                                            ms.CommonServices.AddAuditLog("Invalid UserName or Password for Login Page", "", "", "", "", "", null, null, null);
                                            messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.InvalidCredentials);
                                            return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);
                                        }

                                        MachineUserMapping machineUserMapping = new MachineUserMapping
                                        {
                                            UserId = userDetails.UserId
                                        };
                                        var getMachineMappedByUser = machineDAL.GetMachinesByUserId(machineUserMapping);

                                        if (getMachineMappedByUser.Count == 0)
                                        {

                                            ms.CommonServices.AddAuditLog($"No machine mapped to user {userDetails.Username}", "Login", "", "", "", "", null, null, userDetails);
                                            messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.NoUserMappedToTerminal);
                                            return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                                            //throw new Serenity.Services.ValidationError("Error", $"{messageDetails.MessageText}");

                                        }
                                        else
                                        {
                                            var machineMappedUser = getMachineMappedByUser.Select(mmu => mmu.ModuleId).ToArray();
                                            var machineAccessUser = cvcEntities.ModuleAccesses.Where(ma => ma.RoleId == userDetails.RoleId).Select(ma => (int)ma.ModuleId).ToArray();

                                            var commonModuleId = machineMappedUser.Intersect(machineAccessUser);
                                            if (commonModuleId.Count() == 0)
                                            {
                                                var roleName = userDetails.Role.RoleName;
                                                ms.CommonServices.AddAuditLog($"{roleName} role don't have any machine access", "Login", "", "", "", "", null, null, userDetails);
                                                messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.NoMachineAccessToRole);

                                                return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                                                // throw new Serenity.Services.ValidationError("Error", $"{roleName} role don't have any machine access");
                                            }
                                        }
                                    }
                                }
                            }
                        }


                        //else if (responsstatus == true)
                        //{

                        //}
                        //throw new Serenity.Services.ValidationError("Error", "Invalid");

                    }
                    #endregion




                    if (request.IsADUser)
                    {
                        ActiveDirectoryService ADireService = new ActiveDirectoryService();
                        CVC.Administration.DirectoryEntry de = new CVC.Administration.DirectoryEntry();
                        de = ADireService.Validate(request.Username, request.Password);
                        string output = string.Empty;
                        if (de == null)
                        {

                            throw new Serenity.Services.ValidationError("AuthenticationError", "User does not exist in active directory");


                        }

                        string salt = (string)null;
                        string hashAD = "";
                        var ADUser = cvcEntities.Users.FirstOrDefault(a => a.StatusId == 1 && a.Username.ToLower() == request.Username.ToLower());
                        if (ADUser != null)
                        {
                            hashAD = UserRepository.GenerateHash(request.Password, ref salt);
                            if (ADUser.Username == request.Username && ADUser.IsActiveDirectory == true && ADUser.StatusId == 1)
                            {

                                ADUser.PasswordHash = hashAD;
                                ADUser.PasswordSalt = salt;
                                cvcEntities.Entry<User>(ADUser).State = System.Data.Entity.EntityState.Modified;
                                cvcEntities.SaveChanges();
                            }
                        }
                        else
                        {
                            User user = new User();

                            string AUsername = "";
                            string AFname = "";
                            string ALname = "";
                            string AEmail = "";
                            if (!string.IsNullOrEmpty(de.Username))
                            {
                                AUsername = de.Username;
                            }
                            if (!string.IsNullOrEmpty(de.FirstName))
                            {
                                AFname = de.FirstName;
                            }

                            if (!string.IsNullOrEmpty(de.LastName))
                            {
                                ALname = de.LastName;
                            }

                            if (!string.IsNullOrEmpty(de.Email))
                            {
                                AEmail = de.Email;
                            }

                            user.Username = AUsername;
                            user.FirstName = AFname;
                            user.LastName = ALname;
                            user.Email = AEmail;
                            string hash = UserRepository.GenerateHash(request.Password, ref salt);
                            user.PasswordHash = hash;
                            user.PasswordSalt = salt;
                            user.StatusId = 1;
                            user.RoleId = 2;
                            user.CityId = 17;
                            user.DepartmentId = 2;
                            user.QuestionId = 57;
                            user.QuestionAns = "ADU";
                            user.IsActiveDirectory = true;
                            cvcEntities.Users.Add(user);
                            cvcEntities.SaveChanges();
                        }

                    }
                    string username = request.Username;


                    var users = cvcEntities.Users.FirstOrDefault(a => a.Username.ToLower() == request.Username.ToLower());

                    #region Sr.No.105 Date:10/02/2020
                    if (users == null)
                    {
                        // messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.NoUserMappedToTerminal);

                        throw new Serenity.Services.ValidationError("AuthenticationError", "Invalid User");
                    }
                    #endregion

                    else
                    {
                        #region Sr.No.106 Date:10/02/2020
                        if (users.StatusId == 2)
                        {
                            messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.InActiveUser);
                            return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                            // throw new Serenity.Services.ValidationError("AuthenticationError", "User is InActive");

                        }
                        #endregion
                    }

                    var env = cvcEntities.EnvironmentVariables.FirstOrDefault();
                    if (users != null)
                    {
                        Session["CVCRoleId"] = users.RoleId;
                        Session["CVCUserId"] = users.UserId;
                        // HttpContext.Cache["LoggedUserId"] = users.UserId;
                       clsCacheConfig.AddItemToCache(bs.ClsCacheConfig.CacheKeys.LoggedUserId, users.UserId);

                        HttpContext.Cache.Remove("PackId");
                        var DateFormat = msCommonServices.GetDateFormatFromEnvironmentVariable();
                        ConfigurationManager.AppSettings["DateFormat"] = DateFormat;

                        //#region Write UserName to PLC
                        //var dashObj = new DashboardCommon();
                        //var machinePara = CVCDaoFactory.GetMachineParameter(cvcEntities.MachineParameters.FirstOrDefault().MachineParameterId);
                        //var result = new ConnectMachine().Write("405602", "1");
                        //#endregion

                        //Session["CVCUserName_ForSessionTimeOut"] = users.Username;
                        // Session.Timeout = objCommonServices.GetSessionTimeOutFromEnvironmentVariable();
                        var user = CVCDaoFactory.GetUser(username);
                        #region Sr.No:111 17/02/2020
                        if (user.RoleId != (int)BusinessServices.Common.ClsConstants.RoleType.Administrator)
                        {
                            if (user.PasswordExpiryDate != null)
                            {
                                if (user.PasswordExpiryDate < DateTime.Now)
                                {
                                    Session["CVCUserId_ForChangePassword"] = users.UserId;
                                    Session["CVCUserName_ForChangePassword"] = users.Username;
                                    messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.PasswordExpired);
                                    return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                                    // throw new Serenity.Services.ValidationError("AuthenticationError", "Your Password Expired Please Change");
                                }
                            }
                        }
                        #endregion

                        //changes done by Vinayak On 20.07.2018
                        if (user.RoleId != (int)BusinessServices.Common.ClsConstants.RoleType.Administrator)
                        {
                            if (user.IsPasswordChangeOnLogin == true)           //@MT- 11.Sept.2019--This code was found commented ,Reset password on first login was not working
                            {
                                Session["CVCUserId_ForChangePassword"] = users.UserId;          //@MT- 11.Sept.2019-Bug Fixed for reset password on first login
                                Session["CVCUserName_ForChangePassword"] = users.Username;      //@MT- 11.Sept.2019-Bug Fixed for reset password on first login
                                messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.ChangePasswordOnFirstLogin);
                                return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                                // throw new Serenity.Services.ValidationError("AuthenticationError", "Your Password Need to Change for First Login");
                            }
                        }

                        #region Code for account lock 

                        if (user.IsLockOut == true && env.IsUnLockAfterTime == false)
                        {
                            messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.LockAccount);
                            return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                            // throw new Serenity.Services.ValidationError("AuthenticationError", "Your Account is Locked");
                        }

                        else if (user.IsLockOut == true && env.IsUnLockAfterTime == true && env.UnLockTime != null && user.LockOutDateTime != null)
                        {
                            if (user.LockOutDateTime.Value.AddMinutes(env.UnLockTime.Value) >= DateTime.Now)
                            {
                                messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.LockAccount);
                                return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                                //  throw new Serenity.Services.ValidationError("AuthenticationError", "Your Account is Locked");
                            }
                            else
                            {
                                ms.CommonServices.AddAuditLog("Account Is UnLocked", "", "", "", "", "", null, null, users);

                            }
                        }
                        #endregion

                        // List<Alarm> items = cvcEntities.Alarms.Where(a => a.Machine.MachineCommunications.Any(c => (c.ProtocolTypeId == 4 || c.ProtocolTypeId == 1) && c.StatusId == 1)).ToList();
                        // Session["alarmitems"] = items;

                    }
                    // var env1 = cvcEntities.EnvironmentVariables.FirstOrDefault();


                    if (WebSecurityHelper.Authenticate(ref username, request.Password, false))
                    {
                        var user = CVCDaoFactory.GetUser(username);

                        users.LogInAttempt = 0;
                        users.IsLockOut = false;
                        cvcEntities.Entry<User>(users).State = System.Data.Entity.EntityState.Modified;
                        cvcEntities.SaveChanges();

                        new DashboardCommon().AddAuditLog("UserLogin", "Membership", "Login", user: user);
                        new DashboardCommon().AddUserLog("UserLogin", "Membership", "Login", user: user);

                        if (user.PasswordExpiryDate != null)
                        {
                            DateTime DtPasswordExpiryDate = (DateTime)user.PasswordExpiryDate;
                            System.DateTime ExpiryDate = new System.DateTime(DtPasswordExpiryDate.Year, DtPasswordExpiryDate.Month, DtPasswordExpiryDate.Day);
                            System.DateTime TodaysDate = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                            var TotalDays = (ExpiryDate - TodaysDate).TotalDays;
                            var PasswordExpiryNotification = cvcEntities.EnvironmentVariables.FirstOrDefault().PasswordExpiryNotification;

                            #region Password Expiry Notification
                            if (PasswordExpiryNotification != null)
                            {
                                if (TotalDays <= PasswordExpiryNotification)
                                {

                                    messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.PasswordExpiryNotification);
                                    return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText.Replace("#days#", TotalDays.ToString()) }, JsonRequestBehavior.AllowGet);

                                    //return this.Json(new { MessageType = "PasswordExpiryNotification", Message = "Your Password will exipre in next " + TotalDays + " days." }, JsonRequestBehavior.AllowGet);

                                }

                            }
                            #endregion


                        }
                        #region Database Limit
                        if (env.DatabaseLimit != null)
                        {
                            int DatabaseLimit = Convert.ToInt16(env.DatabaseLimit);
                            var CurrentDatabaseSize = CVCDaoFactory.GetDbSize().Replace(" MB", "");
                            double Size = Convert.ToDouble(CurrentDatabaseSize);

                            if (Size > DatabaseLimit)
                            {
                                messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.DatabaseLimitNotification);
                                return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                                // return this.Json(new { MessageType = "DatabaseLimitNotification", Message = "Database almost full" }, JsonRequestBehavior.AllowGet);
                            }
                        }
                        #endregion


                        return this.Json(new { MessageType = "NA", Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                        //return this.Json((object)user);
                    }
                    else if (request.IsADUser)
                    {
                        var user = CVCDaoFactory.GetUser(username);

                        users.LogInAttempt = 0;
                        users.IsLockOut = false;
                        cvcEntities.Entry<User>(users).State = System.Data.Entity.EntityState.Modified;
                        cvcEntities.SaveChanges();

                        new DashboardCommon().AddAuditLog("UserLogin", "Membership", "Login", user: user);
                        return this.Json((object)user);

                    }

                    else
                    {
                        // Log In Attempt

                        if (users != null)
                        {
                            //var env = cvcEntities.EnvironmentVariables.FirstOrDefault();
                            if (users.LogInAttempt == null)
                                users.LogInAttempt = 0;
                            users.LogInAttempt++;
                            if (users.LogInAttempt >= env.LockInAttempt)
                            {
                                users.LockOutDateTime = DateTime.Now;
                                users.IsLockOut = true;
                            }
                            cvcEntities.Entry<User>(users).State = System.Data.Entity.EntityState.Modified;
                            cvcEntities.SaveChanges();
                            if (users.LogInAttempt >= env.LockInAttempt)
                            {
                                ms.CommonServices.AddAuditLog("Account Is Locked", "", "", "", "", "", null, null, users);

                            }
                        }

                        ms.CommonServices.AddAuditLog("Invalid UserName or Password for Login Page", "", "", "", "", "", null, null, users);


                        messageDetails = messageMasterCache.Find(m => m.MessageMasterId == (int)MessageType.InvalidCredentials);
                        return this.Json(new { MessageType = pickListValue, Message = messageDetails.MessageText }, JsonRequestBehavior.AllowGet);

                        // throw new Serenity.Services.ValidationError("AuthenticationError", (string)CVC.Texts.Validation.AuthenticationError);


                    }
                }
            }
            catch (System.Exception ex)
            {
                return null;
            }


        }

        //private void AddAuditLog()
        //{
        //    AuditLog auditLog = new AuditLog
        //    {
        //        Action = "Terminal Mapping",
        //        Module = "Login",
        //        Page = "Login",
        //        FieldName = propertyName,
        //        OldValue = oldValue,
        //        NewValue = Convert.ToString(propertyValue),
        //        User = userDetails,
        //        // UserName= userDetails.Username,
        //        // UserId = Convert.ToInt32(HttpContext.Current.Session["CVCUserId"].ToString()),
        //    };
        //    lstAuditLog.Add(auditLog);
        //}

        private string Hyphenate(string str, int pos)
        {
            return String.Join("-", Regex.Split(str, @"(?<=\G.{" + pos + "})(?!$)"));
        }


        private void CheckPreviousPasswordLimit(int CVCUserId, string NewPassword)
        {
            #region Previous Password Limit 
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                CVC.BusinessServices.Common.CommonServices objCommonServices = new CVC.BusinessServices.Common.CommonServices();
                var PreviousPasswordLimit = objCommonServices.GetPreviousPasswordLimit();

                if (PreviousPasswordLimit > 0)
                {
                    var Passwords = cvcEntities.Passwords.Where(p => p.UserId == CVCUserId).OrderByDescending(p => p.CreatedOn).Take(PreviousPasswordLimit);

                    foreach (var item in Passwords)
                    {
                        var NewPasswordHash = UserRepository.CalculateHash(NewPassword, item.PasswordSalt);
                        if (NewPasswordHash == item.PasswordHash)
                        {
                            throw new Serenity.Services.ValidationError("PreviousPasswordError", (string)CVC.Texts.Validation.PreviousPasswordError.ToString().Replace("Number", PreviousPasswordLimit.ToString()));

                        }

                    }
                }

            }
            #endregion
        }

        private ActionResult Error(string message)
        {
            return (ActionResult)this.View("~/Views/Errors/ValidationError.cshtml", (object)new Serenity.Services.ValidationError((string)CVC.Texts.Validation.InvalidResetToken));
        }

        public ActionResult Signout(bool isStopBatch = false)
        {
            var ModuleId = 0;
            if (Session["ModuleId"] != null)
            {
                ModuleId = Convert.ToInt32(Session["ModuleId"]);

            }
            new DashboardCommon().AddAuditLog("UserLogOut", "Membership", "Login");
            new DashboardCommon().AddUserLog("UserLogOut", "Membership", "Login");
            Session["CVCRoleId"] = null;
            this.Session.Abandon();
            // HttpContext.Cache.Remove("CommandPanel");
            HttpContext.Cache.Remove("MachineSummary");
            HttpContext.Cache.Remove("MachineSettings");
            HttpContext.Cache.Remove("ActiveModuleId");
            HttpContext.Cache.Remove("AlarmPanelCache");
            HttpContext.Cache.Remove("AlarmIPCAddressCache");
           // HttpContext.Cache.Remove("OPCUaClientSession");


            FormsAuthentication.SignOut();
            ms.CommonServices commonServices = new ms.CommonServices();
            var machineId = (int)new DashboardCommon().GetMachineId(Convert.ToString(ModuleId));
            commonServices.WriteValuesToAllMachinesAsync("IsWriteToPLC", "1");
            
            if (isStopBatch) // If User Opt to Stop Batch 
            {
                //CVCEntities cvcEntities = new CVCEntities();
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    DashboardCommon.StartStopBatch(cvcEntities.Batches.OrderByDescending(a => a.BatchId).FirstOrDefault().BatchId, 0, ModuleId);
                }
            }

            return (ActionResult)new RedirectResult("~/");
        }
        [HttpPost]
        public JsonResult ResetSession(Parameter parameter)
        {
            string UserName = parameter.UserName;
            if (WebSecurityHelper.Authenticate(ref UserName, parameter.Password, false))
            {
                User objUser = new Data.EDMX.User();
                objUser.Username = UserName;
                // objUser.UserId = UserName;
                int? BatchId = null;
                int? MachineId = null;
                ms.CommonServices.AddAuditLog("Session TimeOut", "", "", "", "", "", BatchId, MachineId, objUser);
            }
            else
            {

                return Json("Invalid Password", JsonRequestBehavior.AllowGet);

            }

            //Session["CVCUserName_ForSessionTimeOut"] = UserName;
            // Session.Timeout = objCommonServices.GetSessionTimeOutFromEnvironmentVariable();
            return Json("Login Successfull", JsonRequestBehavior.AllowGet);

        }

        //  [HttpPost]
        #region Screen Lock TimeOut
        public JsonResult CheckLogin(Parameter parameter)
        {
            User objUser = new Data.EDMX.User();
            string UserName = "";
            try
            {

                objUser.Username = parameter.UserName;
                // objUser.UserId = UserName;
                //int? BatchId = null;
                // int? MachineId = null;
                UserName = parameter.UserName;
                if (WebSecurityHelper.Authenticate(ref UserName, parameter.Password, false))
                {

                    AddAuditLog(UserName + " User LogIn Successfully for Screen Lock TimeOut Window", "", "", "", "", "", null, null, objUser);
                }
                else
                {
                    AddAuditLog(UserName + " User entered Invalid Password for Screen Lock TimeOut Window", "", "", "", "", "", null, null, objUser);

                    return Json("Invalid Password", JsonRequestBehavior.AllowGet);

                }

                // Session["CVCUserName_ForSessionTimeOut"] = UserName;
                //Session.Timeout = objCommonServices.GetSessionTimeOutFromEnvironmentVariable();
                return Json("Login Successfull", JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                ex = null;

            }
            finally
            {
                parameter = null;
                objUser = null;
                UserName = null;
            }
            return Json("Login Successfull", JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region AuditLog For Screen Lock TimeOut
        [HttpPost]
        public JsonResult AddAuditLogForScreenLockTimeOut(Parameter parameter)
        {
            string UserName = parameter.UserName;
            // int? BatchId = null;
            // int? MachineId = null;
            // User objUser = new Data.EDMX.User();
            try
            {
                //  objUser.Username = UserName;
                //  objUser.UserId = Convert.ToInt32(Session["CVCUserId"]);
                AddAuditLog("Screen Lock TimeOut for " + UserName + " User", "", "", "", "", "", null, null);
                return null;
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                parameter = null;
                UserName = null;
                // BatchId = null;
                //MachineId = null;
                //objUser = null;
            }
            return null;
        }
        #endregion
        public void AddAuditLog(string Action, string Module, string Page, string FieldName, string OldValue, string NewValue, int? BatchId, int? MachineId, User user = null, int? PickListValueId = null, string Comments = null, int? AuthenticationId = null)
        {
            AuditLog log = new AuditLog();
            UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {

                    if (userDefinition != null)
                    {
                        log.UserId = userDefinition.UserId;
                        log.UserName = userDefinition.Username;
                    }
                    else if (user != null)
                    {
                        log.UserId = user.UserId;
                        log.UserName = user.Username;
                    }

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

                    if (log.UserId == 0)
                    {
                        log.UserId = null;
                    }

                    cvcEntities.AuditLogs.Add(log);
                    cvcEntities.SaveChanges();
                }
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                log = null;
                userDefinition = null;
                Action = null;
                Module = null;
                Page = null;
                FieldName = null;
                OldValue = null;
                NewValue = null;
                BatchId = null;
                MachineId = null;
                user = null;
                PickListValueId = null;
                Comments = null;
                AuthenticationId = null;
            }


        }


        //  [HttpPost]
        public JsonResult GetScreenLockTimeOut()
        {
            int ScreenLockTimeOut = msCommonServices.GetScreenLockTimeOutFromEnvironmentVariable();
            var ConvertMinutesToMilliseconds = TimeSpan.FromMinutes(ScreenLockTimeOut).TotalMilliseconds;
            return Json(ConvertMinutesToMilliseconds, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult SaveADUser(DirectoryEntry parameter)
        {

            string UName = "";
            string Email = "";
            string LName = "";
            string FName = parameter.FirstName.Trim().ToString();
            if (parameter.LastName == null)
            {
                LName = "";
            }
            else
            {
                LName = parameter.LastName.Trim();
            }



            if (!string.IsNullOrEmpty(FName))
            {

                //CVCEntities cvcEntities = new CVCEntities();
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    User usr = new User();
                    string userdetails = FName + " " + LName;
                    CVC.Models.ADUser aDUser = new Models.ADUser();
                    string strAD = aDUser.UserDetails(userdetails);
                    string[] strwords = strAD.Split(' ');

                    usr.FirstName = FName;
                    usr.LastName = LName;
                    if (strwords.Length > 1)
                    {
                        UName = strwords[2];
                        Email = strwords[3];
                    }
                    if (!string.IsNullOrEmpty(UName))
                    {
                        usr.Username = UName;
                    }
                    else
                    {
                        usr.Username = FName;
                    }
                    if (!string.IsNullOrEmpty(Email))
                    {
                        usr.Email = Email;

                    }

                    var ADUser = cvcEntities.Users.FirstOrDefault(a => a.IsActiveDirectory == true && a.Username.ToLower() == usr.Username);
                    if (ADUser == null)
                    {
                        string salt = (string)null;

                        string hash = UserRepository.GenerateHash("Pass@123", ref salt);
                        usr.PasswordHash = hash;
                        usr.PasswordSalt = salt;
                        usr.StatusId = 1;
                        usr.RoleId = 2;
                        usr.CityId = 17;
                        usr.DepartmentId = 2;
                        usr.QuestionId = 57;
                        usr.QuestionAns = "ADU";
                        usr.IsActiveDirectory = true;
                        cvcEntities.Users.Add(usr);
                        cvcEntities.SaveChanges();
                        return Json("AD User Saved Successfully", JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json("User already exist", JsonRequestBehavior.AllowGet);
                        //throw new Serenity.Services.ValidationError("AuthenticationError", "User already exist");
                    }
                }
            }
            else
            {

                return Json("Invalid", JsonRequestBehavior.AllowGet);

            }


        }


    }
}
