using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Caching;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using CVC.BusinessServices.Common;
using CVC.BusinessServices.DAL;
using CVC.ViewModels;
using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;
using static CVC.BusinessServices.Common.ClsConstants;

namespace CVC.OpcUaClient
{
    public class ClsOpcUaClient
    {
       // public string ServerAddress { get; set; }
       // public string ServerPortNumber { get; set; }
        public bool SecurityEnabled { get; set; }
        public string ApplicationName { get; set; } = "CVCApplication";
        public Session OPCSession { get; set; }
        public Session OPCSessionForAddressSpace { get; set; }
        ClsCacheConfig clsCacheConfig = new ClsCacheConfig();
        //public ClsOpcUaClient(string serverAddres, string serverport,bool sessionrenewalRequired, double sessionRenewalMinutes, string nameSpace)
        //{
        //    ServerAddress = serverAddres;
        //    ServerPortNumber = serverport;
        //    MyApplicationName = "OpcUaClient";
        //    SessionRenewalRequired = sessionrenewalRequired;
        //    SessionRenewalPeriodMins = sessionRenewalMinutes;
        //    OPCNameSpace = nameSpace;
        //    LastTimeOPCServerFoundAlive = DateTime.Now;
        //    InitializeOPCUAClient();
        //    if (SessionRenewalRequired)
        //    {
        //        LastTimeSessionRenewed = DateTime.Now;
        //       // RenewerTHread = new Thread(renewSessionThread);
        //        RenewerTHread.Start();
        //    }
        //}

        #region OPC Ua Client Communication
       // public bool cConnetoOPCUaClient(string ServerAddress, string ServerPortNumber, string userName, string password, string RequestType = null)

        public Tuple<bool,string> ConnetoOPCUaClient(MachineCommunicationViewModel machineCommunicationViewModel)
        {

            CommonServices commonServices = new CommonServices();
            var status = false;
            var message = string.Empty;
            var autoAcceptUntrustedCertificates = true;
            var model = machineCommunicationViewModel;
            string filepath = $"{AppDomain.CurrentDomain.BaseDirectory}";
            var isSecurityPolicyApplied = false;
            int? userId = null;
            var cachedLoggedUserId = clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);
            if (cachedLoggedUserId != null)
            {
                userId = (int)cachedLoggedUserId;
            }

            /* if (machineCommunicationViewModel?.SecurityMode?.ToLower()== OpcUaClientSecurityMode.Sign.ToLower() || machineCommunicationViewModel?.SecurityMode?.ToLower()==OpcUaClientSecurityMode.SignAndEncrypt.ToLower())
             {
                 isSecurityPolicyApplied = true;
                 var trustedStorePath = filepath + @"\Cert\TrustedIssuer";

                 if (Directory.Exists(trustedStorePath))
                 {
                     if (Directory.GetFiles($"{trustedStorePath}\\certs").Length == 0)
                     {
                         autoAcceptUntrustedCertificates = false;
                     }

                 }
                 else
                 {
                     autoAcceptUntrustedCertificates = false;
                 }
             }*/

            //  var config = new ApplicationConfiguration();
            try
            {
                var securityConfiguration = new SecurityConfiguration();

               /* if (isSecurityPolicyApplied)
                {
                    if (machineCommunicationViewModel.CertificateType == OpcUaClientCertificateType.TrustedIssuer)
                    {
                        securityConfiguration = new SecurityConfiguration
                        {
                            ApplicationCertificate = new CertificateIdentifier
                            {
                                StoreType = @"Directory",
                                StorePath = filepath + @"\Cert\TrustedIssuer",
                                //StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\MachineDefault",
                                SubjectName = Utils.Format(@"CN={0}, DC={1}", ApplicationName, model.IPAddress)
                            },
                            TrustedIssuerCertificates = new CertificateTrustList
                            {
                                StoreType = @"Directory",
                                StorePath = filepath + @"\Cert\TrustedIssuer",
                                // StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Certificate Authorities"
                            },
                            TrustedPeerCertificates = new CertificateTrustList
                            {
                                StoreType = @"Directory",
                                StorePath = filepath + @"\Cert\TrustedIssuer",
                                //StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Applications"
                            },
                            
                            AutoAcceptUntrustedCertificates = autoAcceptUntrustedCertificates,
                            AddAppCertToTrustedStore = true,
                           // RejectSHA1SignedCertificates = false
                        };
                    }
                    else if (machineCommunicationViewModel.CertificateType == OpcUaClientCertificateType.Rejected)
                    {
                        securityConfiguration = new SecurityConfiguration
                        {
                            ApplicationCertificate = new CertificateIdentifier
                            {
                                StoreType = @"Directory",
                                StorePath = filepath + @"\Cert\TrustedIssuer",
                                //StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\MachineDefault",
                                SubjectName = Utils.Format(@"CN={0}, DC={1}", ApplicationName, model.IPAddress)
                            },
                            TrustedIssuerCertificates = new CertificateTrustList
                            {
                                StoreType = @"Directory",
                                StorePath = filepath + @"\Cert\TrustedIssuer",
                                // StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Certificate Authorities"
                            },
                            TrustedPeerCertificates = new CertificateTrustList
                            {
                                StoreType = @"Directory",
                                StorePath = filepath + @"\Cert\TrustedIssuer",
                                //StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Applications"
                            },

                            RejectedCertificateStore = new CertificateTrustList
                            {
                                StoreType = @"Directory",
                                StorePath = filepath + @"\Cert\RejectedCertificates",
                                // StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\RejectedCertificates"
                            },
                             AutoAcceptUntrustedCertificates = autoAcceptUntrustedCertificates,
                           // AddAppCertToTrustedStore = true,
                           // RejectSHA1SignedCertificates = false
                        };

                    }
                    else
                    {
                        securityConfiguration = new SecurityConfiguration
                        {
                            ApplicationCertificate = new CertificateIdentifier(),
                            AutoAcceptUntrustedCertificates = autoAcceptUntrustedCertificates
                        };
                    }
                }
                else
                {
                     securityConfiguration = new SecurityConfiguration
                    {
                        ApplicationCertificate = new CertificateIdentifier(),
                        AutoAcceptUntrustedCertificates=autoAcceptUntrustedCertificates
                        
                    };
                }*/

              ApplicationConfiguration  config = new ApplicationConfiguration()
                {
                    ApplicationName = ApplicationName,
                    ApplicationUri = Utils.Format(@"urn:{0}:" + ApplicationName + "", model.IPAddress),
                    ApplicationType = ApplicationType.Client,
                    // SecurityConfiguration =securityConfiguration,
                    SecurityConfiguration = new SecurityConfiguration
                    {
                        ApplicationCertificate=new CertificateIdentifier(),
                        /* ApplicationCertificate = new CertificateIdentifier
                        {
                            StoreType = @"Directory",
                            StorePath = filepath + @"\Cert\TrustedIssuer",
                            //StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\MachineDefault",
                            SubjectName = Utils.Format(@"CN={0}, DC={1}", ApplicationName, model.IPAddress)
                        },
                        TrustedIssuerCertificates = new CertificateTrustList
                        {
                            StoreType = @"Directory",
                            StorePath = filepath + @"\Cert\TrustedIssuer",
                            // StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Certificate Authorities"
                        },
                        TrustedPeerCertificates = new CertificateTrustList
                        {
                            StoreType = @"Directory",
                            StorePath = filepath + @"\Cert\TrustedIssuer",
                            //StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Applications"
                        },
                        RejectedCertificateStore = new CertificateTrustList
                        {
                            StoreType = @"Directory",
                            StorePath = filepath + @"\Cert\RejectedCertificates",
                            // StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\RejectedCertificates"
                        },*/

                        AutoAcceptUntrustedCertificates = true,
                        AddAppCertToTrustedStore = true,
                        RejectSHA1SignedCertificates = false
                    },

                    TransportConfigurations = new TransportConfigurationCollection(),
                    TransportQuotas = new TransportQuotas { OperationTimeout = 15000 },
                   ClientConfiguration = new ClientConfiguration (),

                 // ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 60000 },
                    // TraceConfiguration = new TraceConfiguration()
                    TraceConfiguration = new TraceConfiguration
                    {
                        DeleteOnLoad = true
                    },
                    DisableHiResClock = false
                };

                config.Validate(ApplicationType.Client).GetAwaiter().GetResult();

                if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    config.CertificateValidator.CertificateValidation += (s, e) => { e.Accept = (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted); };
                }

                var application = new ApplicationInstance
                {
                    ApplicationName = ApplicationName,
                    ApplicationType = ApplicationType.Client,
                    ApplicationConfiguration = config
                };

                application.CheckApplicationInstanceCertificate(false, 2048).GetAwaiter().GetResult();

                UserIdentity userIdentity =null;

                if (model?.UserIdentity?.ToLower() ==OpcUaClientUserIdentity.UserName.ToLower())
                {                    
                    userIdentity = new UserIdentity(model.UserName, model.Password);
                    SecurityEnabled = false;                   
                }

            /*   EndpointDescription endpointDescription;

                try
                {
                    endpointDescription = CoreClientUtils.SelectEndpoint("opc.tcp://DESKTOP-6O2ORNE:53530/", true);
                }
                catch
                {
                    return false;
                }



                endpointDescription.SecurityPolicyUri = SecurityPolicies.None;
                endpointDescription.SecurityMode = MessageSecurityMode.SignAndEncrypt;
               // endpointDescription.

                EndpointConfiguration endpointConfiguration = EndpointConfiguration.Create(config);

                ConfiguredEndpoint endpoint = new ConfiguredEndpoint(null, endpointDescription, endpointConfiguration);*/


                // var selectedEndpoint = CoreClientUtils.SelectEndpoint("opc.tcp://" + ServerAddress + ":" + ServerPortNumber + "", useSecurity: SecurityEnabled, discoverTimeout: 15000);

                var selectedEndpoint = CoreClientUtils.SelectEndpoint(model.IPAddress + ":" + model.TCPIPPort + "", useSecurity: SecurityEnabled, discoverTimeout: 15000);
                // selectedEndpoint.SecurityMode = MessageSecurityMode.None;
                // selectedEndpoint.SecurityPolicyUri = SecurityPolicies.None;
                ObjectCache cache = MemoryCache.Default;

                if (string.IsNullOrEmpty(model.RequestType))
                {
                    OPCSession = Opc.Ua.Client.Session.Create(config, new ConfiguredEndpoint(null, selectedEndpoint, EndpointConfiguration.Create(config)), false, "", 60000, userIdentity, null).GetAwaiter().GetResult();
                    {

                    }

                        cache.Remove(ClsCacheConfig.CacheKeys.OPCUaClientSession);
                        CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                        cacheItemPolicy.AbsoluteExpiration = ClsCacheConfig.CacheExpiry.CacheExpiryTime;
                        cache.Add(ClsCacheConfig.CacheKeys.OPCUaClientSession,OPCSession, cacheItemPolicy);
                    
                   // System.Web.HttpContext.Current.Cache.Remove("OPCUaClientSession");
                   // System.Web.HttpContext.Current.Cache["OPCUaClientSession"] = OPCSession;
                }
                else
                {
                    OPCSessionForAddressSpace = Opc.Ua.Client.Session.Create(config, new ConfiguredEndpoint(null, selectedEndpoint, EndpointConfiguration.Create(config)), false, "", 60000, userIdentity, null).GetAwaiter().GetResult();

                    cache.Remove(ClsCacheConfig.CacheKeys.OPCUaClientSession);
                    CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                    cacheItemPolicy.AbsoluteExpiration = ClsCacheConfig.CacheExpiry.CacheExpiryTime;
                    cache.Add(ClsCacheConfig.CacheKeys.OPCUaClientSession, OPCSessionForAddressSpace, cacheItemPolicy);
                   // System.Web.HttpContext.Current.Cache.Remove("OPCUaClientSession");
                   // System.Web.HttpContext.Current.Cache["OPCUaClientSession"] = OPCSessionForAddressSpace;
                }


                status = true;
                commonServices.UpdateMachineCommunication((int)machineCommunicationViewModel.MachineId, status);        
                commonServices.AddToAuditLog("Opc Ua Client Connected Successfully","Machine Communication","", MachineId: machineCommunicationViewModel.MachineId,UserId:userId);
                clsCacheConfig.AddItemToCache(ClsCacheConfig.CacheKeys.NextSessionRenewalTime, DateTime.Now.AddMinutes(10));
                clsCacheConfig.AddItemToCache(ClsCacheConfig.CacheKeys.OPCUaConfigurationParameter, machineCommunicationViewModel);
                return Tuple.Create(status,message);
            }
            catch (Exception ex)
            {
                commonServices.UpdateMachineCommunication((int)machineCommunicationViewModel.MachineId, status);
                commonServices.AddToAuditLog("Opc Ua Client Connection Failed", "Machine Communication", "", MachineId: machineCommunicationViewModel.MachineId, UserId: userId);

                return Tuple.Create(status, ex.Message);
            }
            finally
            {

            }

        }
        #endregion
       
        #region Read Command Panel
        public CommandPanelPageModel ReadCommandPanel(CommandPanelPageModel commandPanelPageModel)
        {
            try
            {
               
                //Session OPCSessionCache = null;
                //List<ReadValueId> lstReadValueId = null;
                //ReadValueId readValueId = null;
                //ReadValueIdCollection nodesToRead = null;
                //DataValueCollection values = null;
                //DiagnosticInfoCollection diagnosticInfos = null;
                //ResponseHeader responseHeader = null;

                // ConnetoOPCUaClient(commandPanelPageModel.IPAddress, commandPanelPageModel.TcpipPort.ToString());

                CheckOpcSession(commandPanelPageModel.IPAddress, commandPanelPageModel.TcpipPort.ToString(),commandPanelPageModel.UserName,commandPanelPageModel.Password,commandPanelPageModel.MachineId);
                    if (OPCSession != null)
                {
                    List<ReadValueId> lstReadValueId = new List<ReadValueId>();

                    foreach (var item in commandPanelPageModel.ViewFieldList)
                    {
                        ReadValueId readValueId = new ReadValueId
                        {
                            NodeId = new NodeId(item.NodeId),
                            AttributeId = (uint)item.AttributeId
                        };
                        lstReadValueId.Add(readValueId);
                    }

                    ReadValueIdCollection nodesToRead = new ReadValueIdCollection();
                    nodesToRead.AddRange(lstReadValueId);

                    DiagnosticInfoCollection diagnosticInfos = null;
                    DataValueCollection values = null;

                    ResponseHeader responseHeader = OPCSession.
                    Read(
                    null,
                    0,
                    TimestampsToReturn.Both,
                    nodesToRead,
                    out values,
                    out diagnosticInfos);

                    for (int i = 0; i < values.Count; i++)
                    {
                        commandPanelPageModel.ViewFieldList.OrderBy(v => v.ReadValueSequence).Where(v => v.ReadValueSequence == i)
                                  .Select(v =>
                                  {
                                      v.Value = values[i].ToString();
                                      return v;
                                  }).ToList();
                    }
                    // ClientBase.ValidateResponse(values, nodesToRead);
                    // ClientBase.ValidateDiagnosticInfos(diagnosticInfos, nodesToRead);

                    //  OPCSession = null;
                }


            
           
          
                //if (System.Web.HttpContext.Current.Cache["OPCUaClientSession"] != null)
                //{
                //    OPCSessionCache = (Session)HttpContext.Current.Cache["OPCUaClientSession"];
                //}
                //else
                //{
                //    ConnetoOPCUaClient(commandPanelPageModel.IPAddress, commandPanelPageModel.TcpipPort.ToString());
                //    OPCSessionCache = (Session)HttpContext.Current.Cache["OPCUaClientSession"];
                //}
                //if (OPCSessionCache != null)
                //{
                //   lstReadValueId = new List<ReadValueId>();

                //    foreach (var item in commandPanelPageModel.ViewFieldList)
                //    {
                //        readValueId = new ReadValueId
                //        {
                //            NodeId = new NodeId(item.NodeId),
                //            AttributeId = (uint)item.AttributeId
                //        };
                //        lstReadValueId.Add(readValueId);
                //    }

                //    nodesToRead = new ReadValueIdCollection();
                //    nodesToRead.AddRange(lstReadValueId);

                //        responseHeader = OPCSessionCache.
                //        Read(
                //        null,
                //        0,
                //        TimestampsToReturn.Both,
                //        nodesToRead,
                //        out values,
                //        out diagnosticInfos);

                //    for (int i = 0; i < values.Count; i++)
                //    {
                //        commandPanelPageModel.ViewFieldList.OrderBy(v => v.ReadValueSequence).Where(v => v.ReadValueSequence == i)
                //                  .Select(v =>
                //                  {
                //                      v.Value = values[i].ToString();
                //                      return v;
                //                  }).ToList();
                //    }
                //    // ClientBase.ValidateResponse(values, nodesToRead);
                //    // ClientBase.ValidateDiagnosticInfos(diagnosticInfos, nodesToRead);

                //    //  OPCSession = null;
                //}
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    if (ex.Message.ToLower() == "badsessionclosed")
                        RenewSessionThread(OPCSession, ex.Message);
                }
                throw ex;
            }
            finally
            {
              //  OPCSessionCache.Close();
               // OPCSessionCache.Dispose();
               // OPCSessionCache = null;
               // lstReadValueId = null;
               // readValueId = null;
               // nodesToRead = null;
               // values = null;
              //  diagnosticInfos = null;
              //  responseHeader = null;

            }
            return commandPanelPageModel;


        }
        #endregion

        #region Read Machine Summary Panel
        public MachineSummaryPageModel ReadMachineSummaryPanel(MachineSummaryPageModel machineSummaryPageModel)
        {
            try
            {
                CheckOpcSession(machineSummaryPageModel.IPAddress, machineSummaryPageModel.TcpipPort.ToString(),machineSummaryPageModel.UserName,machineSummaryPageModel.Password,machineSummaryPageModel.MachineId);

                if (OPCSession != null)
                {
                    List<ReadValueId> lstReadValueId = new List<ReadValueId>();

                    foreach (var item in machineSummaryPageModel.ViewFieldList)
                    {
                        ReadValueId readValueId = new ReadValueId
                        {
                            NodeId = new NodeId(item.NodeId),
                            AttributeId = (uint)item.AttributeId
                        };
                        lstReadValueId.Add(readValueId);
                    }

                    ReadValueIdCollection nodesToRead = new ReadValueIdCollection();
                    nodesToRead.AddRange(lstReadValueId);

                    DiagnosticInfoCollection diagnosticInfos = null;
                    DataValueCollection values = null;

                    ResponseHeader responseHeader = OPCSession.
                    Read(
                    null,
                    0,
                    TimestampsToReturn.Both,
                    nodesToRead,
                    out values,
                    out diagnosticInfos);

                    for (int i = 0; i < values.Count; i++)
                    {
                        machineSummaryPageModel.ViewFieldList.OrderBy(v => v.ReadValueSequence).Where(v => v.ReadValueSequence == i)
                                  .Select(v =>
                                  {
                                      v.Value = values[i].ToString();
                                      return v;
                                  }).ToList();
                    }

                    if (machineSummaryPageModel.IsLabelRoll && (HttpContext.Current.Cache["LabelRollNumber"] != null || System.Web.HttpContext.Current.Cache["LabelRollNumber"] != null))
                    {

                        if (machineSummaryPageModel.ViewFieldList.Any(v => v.IPCAddress == "NA") == true)
                        {
                            machineSummaryPageModel.ViewFieldList.Where(v => v.IPCAddress == "NA")
                                .Select(v =>
                                {
                                    v.Value = (System.Web.HttpContext.Current.Cache["LabelRollNumber"]).ToString();
                                    return v;
                                }).ToList();
                        }
                        else
                        {
                            machineSummaryPageModel.ViewFieldList.Add(
                                new DashBoardField()
                                {
                                    ParameterName = "Label Roll",
                                    Value = (System.Web.HttpContext.Current.Cache["LabelRollNumber"]).ToString(),
                                    IPCAddress = "NA"
                                });
                        }

                    }

                    foreach (var item in machineSummaryPageModel.ViewFieldList.Where(a => a.IPCAddress != "NA"))
                    {
                        if (item.IsLabelRollIPC == true)
                        {
                            var LabelRemaining = 0;
                            LabelRemaining = Convert.ToInt32(item.Value);
                            item.BackgroundColor = LabelRemaining <= 500 ? "red" : LabelRemaining <= 1000 ? "yellow" : "green";
                        }

                        if (item.IsGoodBottles == true)
                        {
                            var GoodBottles = 0;
                            var BatchSize = 0;
                            GoodBottles = Convert.ToInt32(item.Value);
                          //  BatchSize = item.BatchSizeIPCAddress != null ? Convert.ToInt32(modbusTCP.Read(item.BatchSizeIPCAddress)) : 0;
                            item.BackgroundColor = GoodBottles == BatchSize ? "green" : "yellow";

                        }

                        if (item.IsRejectBottles == true)
                        {
                            var TotalBottles = 0;
                            var GoodBottles = 0;
                            var RejectBottles = 0;

                            RejectBottles = Convert.ToInt32(item.Value);
                            GoodBottles = Convert.ToInt32(machineSummaryPageModel.ViewFieldList.Where(vf => vf.IsGoodBottles == true)?.FirstOrDefault()?.Value ?? "0");
                            TotalBottles = GoodBottles + RejectBottles;
                            var RejectBottlesPercentage = Math.Round(((RejectBottles / (TotalBottles + 0.00)) * 100.00), 2);
                            item.BackgroundColor = RejectBottlesPercentage <= 2 ? "green" : RejectBottlesPercentage <= 4 ? "yellow" : "red";

                        }


                    }
                }

            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    if (ex.Message.ToLower() == "badsessionclosed")
                        RenewSessionThread(OPCSession, ex.Message);
                }
                throw ex;
            }
            finally
            {
               
            }
            return machineSummaryPageModel;
        }
        #endregion

        #region Read Machine Settings Panel
        public RenderViewFieldsPageModel ReadSettingsPanel(RenderViewFieldsPageModel renderViewFieldsPageModel)
        {
            try
            {
                   CheckOpcSession(renderViewFieldsPageModel.IPAddress, renderViewFieldsPageModel.TcpipPort.ToString(),renderViewFieldsPageModel.UserName,renderViewFieldsPageModel.Password,1);
             
                    if (OPCSession != null)
                    {
                        List<ReadValueId> lstReadValueId = new List<ReadValueId>();

                        foreach (var item in renderViewFieldsPageModel.ViewFieldList)
                        {
                            ReadValueId readValueId = new ReadValueId
                            {
                                NodeId = new NodeId(item.NodeId),
                                AttributeId = (uint)item.AttributeId
                            };
                            lstReadValueId.Add(readValueId);
                        }

                        ReadValueIdCollection nodesToRead = new ReadValueIdCollection();
                        nodesToRead.AddRange(lstReadValueId);

                        DiagnosticInfoCollection diagnosticInfos = null;
                        DataValueCollection values = null;

                        ResponseHeader responseHeader = OPCSession.
                        Read(
                        null,
                        0,
                        TimestampsToReturn.Both,
                        nodesToRead,
                        out values,
                        out diagnosticInfos);

                        for (int i = 0; i < values.Count; i++)
                        {
                            renderViewFieldsPageModel.ViewFieldList.OrderBy(v => v.ReadValueSequence).Where(v => v.ReadValueSequence == i)
                                      .Select(v =>
                                      {
                                          v.Value = values[i].ToString();
                                          return v;
                                      }).ToList();
                        }

                    }


            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    if (ex.Message.ToLower() == "badsessionclosed")
                        RenewSessionThread(OPCSession, ex.Message);
                }
                throw ex;
            }
            finally
            {

            }
            return renderViewFieldsPageModel;


        }
        #endregion

        #region Read Alarm Panel
        public List<AlarmViewModel> ReadAlarmPanel()
        {
            var alarmData = new List<AlarmViewModel>();

            try
            {
               // CheckOpcSession(alarmViewModel.ip, commandPanelPageModel.TcpipPort.ToString(), commandPanelPageModel.UserName, commandPanelPageModel.Password);
                if (OPCSession != null)
                {

                    alarmData = (List<AlarmViewModel>)System.Web.HttpContext.Current.Cache["AlarmPanelCache"];
                    List<ReadValueId> lstReadValueId = new List<ReadValueId>();

                    foreach (var item in alarmData)
                    {
                        ReadValueId readValueId = new ReadValueId
                        {
                            NodeId = new NodeId(item.NodeId),
                            AttributeId = (uint)item.AttributeId
                        };
                        lstReadValueId.Add(readValueId);
                    }

                    ReadValueIdCollection nodesToRead = new ReadValueIdCollection();
                    nodesToRead.AddRange(lstReadValueId);

                    DiagnosticInfoCollection diagnosticInfos = null;
                    DataValueCollection values = null;

                    ResponseHeader responseHeader = OPCSession.
                    Read(
                    null,
                    0,
                    TimestampsToReturn.Both,
                    nodesToRead,
                    out values,
                    out diagnosticInfos);

                    for (int i = 0; i < values.Count; i++)
                    {
                        alarmData.OrderBy(v => v.ReadValueSequence).Where(v => v.ReadValueSequence == i)
                                  .Select(v =>
                                  {
                                      return v;
                                  }).ToList();
                    }

                }

                
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    if (ex.Message.ToLower() == "badsessionclosed")
                        RenewSessionThread(OPCSession, ex.Message);
                }
                throw ex;
            }
            finally
            {
               
            }
            return alarmData;


        }
        #endregion

        public string Read(OPCUaClientViewModel oPCUaClientViewModel)
        {
            DataValueCollection values = null;
            DiagnosticInfoCollection diagnosticInfos = null;
            ReadValueId readValueId = null;
            ReadValueIdCollection nodesToRead = null;
            ResponseHeader responseHeader = null;
            try
            {
                CheckOpcSession(oPCUaClientViewModel.ServerAddress, oPCUaClientViewModel.ServerPortNumber,oPCUaClientViewModel.UserName,oPCUaClientViewModel.Password,oPCUaClientViewModel.MachineId);

                if (OPCSession != null)
                {                                
                        readValueId = new ReadValueId
                        {
                            NodeId = new NodeId(oPCUaClientViewModel.NodeId),
                            AttributeId = oPCUaClientViewModel.AttributeId,

                        };
                        nodesToRead = new ReadValueIdCollection();
                        nodesToRead.Add(readValueId);

                        responseHeader = OPCSession.
                        Read(
                        null,
                        0,
                        TimestampsToReturn.Both,
                        nodesToRead,
                        out values,
                        out diagnosticInfos);

                    }                

            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    if (ex.Message.ToLower() == "badsessionclosed")
                        RenewSessionThread(OPCSession, ex.Message);
                }
                // throw ex;
            }
            finally
            {
               // OPCSessionCache.Close();
              //  OPCSessionCache.Dispose();
              //  OPCSessionCache = null;
                //values = null;
                //readValueId = null;
                //nodesToRead = null;
                //diagnosticInfos = null;
                //responseHeader = null;
            }
            return values?.FirstOrDefault()?.Value?.ToString();

        }

        public void Write(OPCUaClientViewModel oPCUaClientViewModel)
        {
            CheckOpcSession(oPCUaClientViewModel.ServerPortNumber, oPCUaClientViewModel.ServerPortNumber, oPCUaClientViewModel.UserName, oPCUaClientViewModel.Password,1);

            WriteValue writeValue = new WriteValue();
            WriteValueCollection nodesToWrite = new WriteValueCollection();
            StatusCodeCollection results = null;
            DiagnosticInfoCollection diagnosticInfos = null;
            ResponseHeader responseHeader = null;
            try
            {
                writeValue.NodeId = new NodeId(oPCUaClientViewModel.NodeId);
                writeValue.AttributeId = oPCUaClientViewModel.AttributeId;

                if (oPCUaClientViewModel.DataTypeId == 14 || oPCUaClientViewModel.DataTypeId==6)
                {
                    writeValue.Value.Value =Convert.ToInt16(oPCUaClientViewModel.Value);
                }
                else if (oPCUaClientViewModel.DataTypeId == 15 || oPCUaClientViewModel.DataTypeId == 8)
                {
                    writeValue.Value.Value = Convert.ToUInt16(oPCUaClientViewModel.Value);
                }
                else if (oPCUaClientViewModel.DataTypeId == 16 || oPCUaClientViewModel.DataTypeId == 10)
                {
                    writeValue.Value.Value = Convert.ToInt32(oPCUaClientViewModel.Value);
                }
                else if (oPCUaClientViewModel.DataTypeId == 17 || oPCUaClientViewModel.DataTypeId == 5)
                {
                    writeValue.Value.Value = Convert.ToUInt32(oPCUaClientViewModel.Value);
                }
                else if (oPCUaClientViewModel.DataTypeId == 18)
                {
                    writeValue.Value.Value = Convert.ToInt64(oPCUaClientViewModel.Value);
                }
                else if (oPCUaClientViewModel.DataTypeId == 19)
                {
                    writeValue.Value.Value = Convert.ToUInt64(oPCUaClientViewModel.Value);
                }
                else if (oPCUaClientViewModel.DataTypeId == 20 || oPCUaClientViewModel.DataTypeId==21|| oPCUaClientViewModel.DataTypeId==9 )
                {
                    writeValue.Value.Value =Convert.ToDouble(oPCUaClientViewModel.Value);
                }
                if (oPCUaClientViewModel.DataTypeId == 2) 
                {
                    writeValue.Value.Value = oPCUaClientViewModel.Value;
                }
                else if (oPCUaClientViewModel.DataTypeId == 3) 
                {
                    writeValue.Value.Value = false;
                }
                else if (oPCUaClientViewModel.DataTypeId == 4) // Bit Set
                {
                    writeValue.Value.Value = true;
                }
                else if (oPCUaClientViewModel.DataTypeId == 7)
                {
                    writeValue.Value.Value =oPCUaClientViewModel.Value;
                }
                nodesToWrite.Add(writeValue);

                responseHeader = OPCSession.Write(
                 null,
                 nodesToWrite,
                 out results,
                 out diagnosticInfos);
                var re = results;
            }
            catch (Exception ex)
            {
                if(!string.IsNullOrEmpty(ex.Message))
                {
                    if (ex.Message.ToLower() == "badsessionclosed")
                        RenewSessionThread(OPCSession, ex.Message);
                }

                throw ex;
            }
            finally
            {
              //  OPCSessionCache.Close();
              //  OPCSessionCache.Dispose();
              //  OPCSessionCache = null;
                //writeValue = null;
                //nodesToWrite = null;
                //results = null;
                //diagnosticInfos = null;
                //responseHeader = null;
            }

        }

        public void Write(string nodeId,UInt32 attributeId,object value)
        {
          //  CheckOpcSession(oPCUaClientViewModel.ServerPortNumber, oPCUaClientViewModel.ServerPortNumber);

            WriteValue writeValue = new WriteValue();
            WriteValueCollection nodesToWrite = new WriteValueCollection();
            StatusCodeCollection results = null;
            DiagnosticInfoCollection diagnosticInfos = null;
            ResponseHeader responseHeader = null;
            try
            {
                writeValue.NodeId = nodeId;
                writeValue.AttributeId =attributeId;
              //  writeValue.Value.Value =value;


                nodesToWrite.Add(writeValue);

                responseHeader = OPCSession.Write(
                 null,
                 nodesToWrite,
                 out results,
                 out diagnosticInfos);
                var re = results;
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    if (ex.Message.ToLower() == "badsessionclosed")
                        RenewSessionThread(OPCSession, ex.Message);
                }
                throw ex;
            }
            finally
            {
                //  OPCSessionCache.Close();
                //  OPCSessionCache.Dispose();
                //  OPCSessionCache = null;
                //writeValue = null;
                //nodesToWrite = null;
                //results = null;
                //diagnosticInfos = null;
                //responseHeader = null;
            }

        }

        public void WriteValueCollection(OPCUaClientViewModel oPCUaClientViewModel)
        {
            CheckOpcSession(oPCUaClientViewModel.ServerAddress, oPCUaClientViewModel.ServerPortNumber,oPCUaClientViewModel.UserName,oPCUaClientViewModel.Password,1);

            StatusCodeCollection results = null;
            DiagnosticInfoCollection diagnosticInfos = null;
            ResponseHeader responseHeader = null;
            try
            {
                List<WriteValue> lstWriteValues = new List<WriteValue>();

                foreach (var item in oPCUaClientViewModel.lstWriteValues)
                {
                    WriteValue writeValue = new WriteValue();
                    writeValue.NodeId = item.NodeId;
                    writeValue.AttributeId = item.AttributeId;
                    if (oPCUaClientViewModel.DataTypeId == 14 || oPCUaClientViewModel.DataTypeId == 6)
                    {
                        writeValue.Value.Value = Convert.ToInt16(oPCUaClientViewModel.Value);
                    }
                    else if (oPCUaClientViewModel.DataTypeId == 15 || oPCUaClientViewModel.DataTypeId == 8)
                    {
                        writeValue.Value.Value = Convert.ToUInt16(oPCUaClientViewModel.Value);
                    }
                    else if (oPCUaClientViewModel.DataTypeId == 16 || oPCUaClientViewModel.DataTypeId == 10)
                    {
                        writeValue.Value.Value = Convert.ToInt32(oPCUaClientViewModel.Value);
                    }
                    else if (oPCUaClientViewModel.DataTypeId == 17 || oPCUaClientViewModel.DataTypeId == 5)
                    {
                        writeValue.Value.Value = Convert.ToUInt32(oPCUaClientViewModel.Value);
                    }
                    else if (oPCUaClientViewModel.DataTypeId == 18)
                    {
                        writeValue.Value.Value = Convert.ToInt64(oPCUaClientViewModel.Value);
                    }
                    else if (oPCUaClientViewModel.DataTypeId == 19)
                    {
                        writeValue.Value.Value = Convert.ToUInt64(oPCUaClientViewModel.Value);
                    }
                    else if (oPCUaClientViewModel.DataTypeId == 20 || oPCUaClientViewModel.DataTypeId == 21 || oPCUaClientViewModel.DataTypeId == 9)
                    {
                        writeValue.Value.Value = Convert.ToDouble(oPCUaClientViewModel.Value);
                    }
                    if (oPCUaClientViewModel.DataTypeId == 2)
                    {
                        writeValue.Value.Value = oPCUaClientViewModel.Value;
                    }
                    else if (oPCUaClientViewModel.DataTypeId == 3)
                    {
                        writeValue.Value.Value = false;
                    }
                    else if (oPCUaClientViewModel.DataTypeId == 4) 
                    {
                        writeValue.Value.Value = true;
                    }
                    else if (oPCUaClientViewModel.DataTypeId == 7)
                    {
                        writeValue.Value.Value = oPCUaClientViewModel.Value;
                    }

                    // writeValue.Value.Value = item.Value;
                    lstWriteValues.Add(writeValue);
                }

                WriteValueCollection nodesToWrite = new WriteValueCollection();
                nodesToWrite.AddRange(lstWriteValues);

                DataValueCollection values = null;

                
                responseHeader = OPCSession.Write(
                 null,
                 nodesToWrite,
                 out results,
                 out diagnosticInfos);
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    if (ex.Message.ToLower() == "badsessionclosed")
                        RenewSessionThread(OPCSession, ex.Message);
                }
                throw ex;
            }
            finally
            {
                //  OPCSessionCache.Close();
                //  OPCSessionCache.Dispose();
                //  OPCSessionCache = null;
                //writeValue = null;
                //nodesToWrite = null;
                //results = null;
                //diagnosticInfos = null;
                //responseHeader = null;
            }

        }

        public OPCUaClientViewModel ReadValueCollection(OPCUaClientViewModel oPCUaClientViewModel)
        {
            DataValueCollection values = null;
            DiagnosticInfoCollection diagnosticInfos = null;
            ReadValueIdCollection nodesToRead = null;
            ResponseHeader responseHeader = null;
            try
            {
               CheckOpcSession(oPCUaClientViewModel.ServerAddress, oPCUaClientViewModel.ServerPortNumber,oPCUaClientViewModel.UserName,oPCUaClientViewModel.Password,1);

                List<ReadValueId> lstReadValueId = new List<ReadValueId>();

                foreach (var item in oPCUaClientViewModel.lstReadValues)
                {
                   ReadValueId readValueId = new ReadValueId

                   {
                        NodeId = new NodeId(oPCUaClientViewModel.NodeId),
                        AttributeId = oPCUaClientViewModel.AttributeId
                    };
                    lstReadValueId.Add(readValueId);
                }
                   
                    nodesToRead = new ReadValueIdCollection();
                    nodesToRead.AddRange(lstReadValueId);

                    responseHeader = OPCSession.
                    Read(
                    null,
                    0,
                    TimestampsToReturn.Both,
                    nodesToRead,
                    out values,
                    out diagnosticInfos);

                for (int i = 0; i < values.Count; i++)
                {
                    oPCUaClientViewModel.lstReadValues.OrderBy(v => v.ReadValueSequence).Where(v => v.ReadValueSequence == i)
                              .Select(v =>
                              {
                                  v.Value = values[i].ToString();
                                  return v;
                              }).ToList();
                }

            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    if (ex.Message.ToLower() == "badsessionclosed")
                        RenewSessionThread(OPCSession, ex.Message);
                }
                // throw ex;
            }
            finally
            {
                // OPCSessionCache.Close();
                //  OPCSessionCache.Dispose();
                //  OPCSessionCache = null;
                //values = null;
                //readValueId = null;
                //nodesToRead = null;
                //diagnosticInfos = null;
                //responseHeader = null;
            }
            return oPCUaClientViewModel;

        }

        private bool CheckOpcSession(string serverAddress,string serverPortNumber,string userName,string password,int? machineId)
        {
            ObjectCache cache = MemoryCache.Default;

            if (cache.Contains(ClsCacheConfig.CacheKeys.OPCUaClientSession))

            // if (System.Web.HttpContext.Current.Cache["OPCUaClientSession"] != null)
            {
                OPCSession = (Session)(cache.Get(ClsCacheConfig.CacheKeys.OPCUaClientSession));

                // OPCSession = (Session)HttpContext.Current.Cache["OPCUaClientSession"];
                RenewSessionThread(OPCSession);

                return true;
            }
            else
            {
                CommonServices objCommonServices = new CommonServices();
                var machineCommunicationDetails = objCommonServices.GetMachineCommunicationDetailsByMachineId((int)machineId);
                var response =ConnetoOPCUaClient(machineCommunicationDetails);

                // var isConnected=cConnetoOPCUaClient(serverAddress,serverPortNumber,userName,password);
                // OPCSession = (Session)HttpContext.Current.Cache["OPCUaClientSession"];
                // return isConnected;
                RenewSessionThread(OPCSession);

                return true;
            }

        }

        private void RenewSessionThread(Session OPCRenewalSession,string requestType=null)
        {
              CommonServices objCommonServices = new CommonServices();
              var nextSessionRenewalTimeCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.NextSessionRenewalTime);

            if (string.IsNullOrEmpty(requestType))
            {
                if ((DateTime.Now > nextSessionRenewalTimeCache))
                {
                    try
                    {
                        OPCRenewalSession.Close();
                        OPCRenewalSession.Dispose();
                    }
                    catch { }

                    var opcUaConfigurationParameterCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.OPCUaConfigurationParameter);
                    ConnetoOPCUaClient(opcUaConfigurationParameterCache);

                }
            }
            else
            {
                try
                {
                    OPCRenewalSession.Close();
                    OPCRenewalSession.Dispose();
                }
                catch { }

                var opcUaConfigurationParameterCache = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.OPCUaConfigurationParameter);
                ConnetoOPCUaClient(opcUaConfigurationParameterCache);

            }

        }




        public OPCUaClientAddressSpace GetAddressSpace(MachineCommunicationViewModel machineCommunicationViewModel)
        {
            var model = machineCommunicationViewModel;
            OPCUaClientAddressSpace oPCUaClientAddressSpace=null;
            List<NodeDetails> lstNodeDetails = new List<NodeDetails>();
            OPCUaClientDAL oPCUaClientDAL = new OPCUaClientDAL();
            int? userId = null;
            var cachedLoggedUserId = clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);
            if (cachedLoggedUserId != null)
            {
                userId = (int)cachedLoggedUserId;
            }

            try
            {
                var response=ConnetoOPCUaClient(machineCommunicationViewModel);

                if (response.Item1)
                {
                    ReferenceDescriptionCollection refs;
                    Byte[] cp;
                    if (string.IsNullOrEmpty(model.NodeId))
                    {
                        OPCSessionForAddressSpace.Browse(null, null, (ObjectIds.RootFolder), 0u,BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.DataType | (uint)NodeClass.Method | (uint)NodeClass.Object |(uint) NodeClass.ObjectType | (uint)NodeClass.ReferenceType|(uint)NodeClass.Unspecified|(uint)NodeClass.Variable|(uint)NodeClass.VariableType|(uint)NodeClass.View, out cp, out refs);

                        //OPCSessionForAddressSpace.Browse(null, null, ObjectIds.ObjectsFolder, 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method, out cp, out refs);
                        
                    }
                    else
                    {
                       // OPCSessionForAddressSpace.Browse(null, null, ExpandedNodeId.ToNodeId(model.NodeId, OPCSessionForAddressSpace.NamespaceUris), 100u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.DataType | (uint)NodeClass.Method | (uint)NodeClass.Object | (uint)NodeClass.ObjectType | (uint)NodeClass.ReferenceType | (uint)NodeClass.Unspecified | (uint)NodeClass.Variable | (uint)NodeClass.VariableType | (uint)NodeClass.View, out cp, out refs);

                        // OPCSessionForAddressSpace.Browse(null, null, ExpandedNodeId.ToNodeId(model.NodeId, OPCSessionForAddressSpace.NamespaceUris), 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.DataType | (uint)NodeClass.Method | (uint)NodeClass.Object | (uint)NodeClass.ObjectType | (uint)NodeClass.ReferenceType | (uint)NodeClass.Unspecified | (uint)NodeClass.Variable | (uint)NodeClass.VariableType | (uint)NodeClass.View, out cp, out refs);

                        Byte[] rp;
                        ReferenceDescriptionCollection referenceDescriptions;
                        OPCSessionForAddressSpace.Browse(null, null, ExpandedNodeId.ToNodeId(model.NodeId, OPCSessionForAddressSpace.NamespaceUris), 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.DataType | (uint)NodeClass.Method | (uint)NodeClass.Object | (uint)NodeClass.ObjectType | (uint)NodeClass.ReferenceType | (uint)NodeClass.Unspecified | (uint)NodeClass.Variable | (uint)NodeClass.VariableType | (uint)NodeClass.View, out cp, out refs);

                        browsenextLabel:
                        if (cp != null)
                        {
                            OPCSessionForAddressSpace.BrowseNext(null, false, cp, out rp, out referenceDescriptions);
                            cp = rp;
                            rp = null;
                            refs.AddRange(referenceDescriptions);
                            referenceDescriptions = null;
                            goto browsenextLabel;
                        }
                    }
                    var nodeData = new Node();
                    object accessRestrictions = string.Empty;
                    object dataLock = string.Empty;
                    object handle = string.Empty;
                    object nodeClass = string.Empty;
                    object references = string.Empty;
                    object accessLevel = string.Empty;
                    object dataType = string.Empty;
                    var accessLevelDescription = "NA";

                    if (!string.IsNullOrEmpty(model.NodeId))
                    {
                        var getNodeId = (NodeId)model.NodeId;
                        nodeData = OPCSessionForAddressSpace.ReadNode(getNodeId);
                        //var type = nodeData.GetType();
                        // var hasProperty = ClsExtensionMethods.HasProperty(type,"DataType");
                        accessRestrictions = ClsExtensionMethods.GetPropValue(nodeData, "AccessRestrictions");
                        dataLock = ClsExtensionMethods.GetPropValue(nodeData, "DataLock");
                        handle = ClsExtensionMethods.GetPropValue(nodeData, "Handle");
                        nodeClass = ClsExtensionMethods.GetPropValue(nodeData, "NodeClass");
                        references = ClsExtensionMethods.GetPropValue(nodeData, "References");
                        accessLevel = ClsExtensionMethods.GetPropValue(nodeData, "AccessLevel");
                        dataType = ClsExtensionMethods.GetPropValue(nodeData, "DataType");


                    }

                    var isFirst = true;
                    foreach (var rd in refs)
                    {
                        if (string.IsNullOrEmpty(model.NodeId))
                        {
                            if (isFirst)
                            {
                                var defaultNodeId = (NodeId)rd.NodeId;
                                nodeData = OPCSessionForAddressSpace.ReadNode(defaultNodeId);
                                accessRestrictions = ClsExtensionMethods.GetPropValue(nodeData, "AccessRestrictions");
                                dataLock = ClsExtensionMethods.GetPropValue(nodeData, "DataLock");
                                handle = ClsExtensionMethods.GetPropValue(nodeData, "Handle");
                                nodeClass = ClsExtensionMethods.GetPropValue(nodeData, "NodeClass");
                                references = ClsExtensionMethods.GetPropValue(nodeData, "References");
                                dataType = ClsExtensionMethods.GetPropValue(nodeData, "DataType");


                            }
                            isFirst = false;

                        }

                        var data = nodeData;
                        // The value for which you want to get string 
                        //if (dataType != null)
                        //{
                           
                        //    PropertyInfo[] myPropertyInfo;
                        //    myPropertyInfo = Type.GetType(dataType.ToString()).GetProperties();
                        //    for (int i = 0; i < myPropertyInfo.Length; i++)
                        //    {
                        //        Console.WriteLine(myPropertyInfo[i].ToString());
                        //    }


                        //    int enumValue =Convert.ToInt32(dataType);
                        //    string enumName = Enum.GetName(typeof(OpcUaClientDataType), enumValue);
                        //}

                        ReferenceDescriptionCollection refs1;
                        Byte[] cp1;
                        OPCSessionForAddressSpace.Browse(null, null, ExpandedNodeId.ToNodeId(rd.NodeId, OPCSessionForAddressSpace.NamespaceUris), 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.DataType | (uint)NodeClass.Method | (uint)NodeClass.Object | (uint)NodeClass.ObjectType | (uint)NodeClass.ReferenceType | (uint)NodeClass.Unspecified | (uint)NodeClass.Variable | (uint)NodeClass.VariableType | (uint)NodeClass.View, out cp1, out refs1);

                       // OPCSessionForAddressSpace.Browse(null, null, ExpandedNodeId.ToNodeId(rd.NodeId, OPCSessionForAddressSpace.NamespaceUris), 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method, out cp1, out refs1);

                        var displayName = Convert.ToString(rd.DisplayName);
                        var getNodeId = Convert.ToString(rd.NodeId);
                        var nodeIdWithouSpecialCharacter = Regex.Replace(getNodeId, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
                        var displayNameIdWithouSpecialCharacter = Regex.Replace(displayName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);


                        bool isRead=false, isWrite = false;
                        var getNodeDetails = OPCSessionForAddressSpace.ReadNode(getNodeId);

                        accessLevel = ClsExtensionMethods.GetPropValue(getNodeDetails, "AccessLevel");

                        if (accessLevel != null)
                        {
                            CommonServices objCommonServices = new CommonServices();
                            accessLevelDescription = objCommonServices.GetAccessLevel(machineCommunicationViewModel.ProtocolTypeId, accessLevel.ToString());
                            if(accessLevelDescription.ToLower().Contains("read"))
                            {
                                isRead = true;
                            }
                            if (accessLevelDescription.ToLower().Contains("write"))
                            {
                                isWrite = true;
                            }
                        }

                        NodeDetails nodeDetails = new NodeDetails
                        {
                            BrowseName = Convert.ToString(rd.BrowseName),
                            DisplayName = Convert.ToString(rd.DisplayName),
                            NodeId = getNodeId,
                            UniqueId = $"{nodeIdWithouSpecialCharacter}{displayNameIdWithouSpecialCharacter}",
                            NodeIdWithouSpecialCharacter = nodeIdWithouSpecialCharacter,
                            HasChildElement = refs1.Count > 0 ? true : false,
                            isChecked = oPCUaClientDAL.CheckNodeExist((int)model.MachineId, getNodeId),
                            machineParameterId = oPCUaClientDAL.GetMachineParameterIdByNode((int)model.MachineId, getNodeId),
                            isRead=isRead,
                            isWrite=isWrite

                        };
                        lstNodeDetails.Add(nodeDetails);
                        /*  ReferenceDescriptionCollection nextRefs;
                          byte[] nextCp;
                          OPCSession.Browse(null, null, ExpandedNodeId.ToNodeId(rd.NodeId, OPCSession.NamespaceUris), 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method, out nextCp, out nextRefs);
                          foreach (var nextRd in nextRefs)
                          {
                              Console.WriteLine("{0}: {1}, {2}", rd.DisplayName, rd.BrowseName, rd.NodeClass);
                              ReferenceDescriptionCollection nextRefs1;
                              byte[] nextCp1;
                              OPCSession.Browse(null, null, ExpandedNodeId.ToNodeId(nextRd.NodeId, OPCSession.NamespaceUris), 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method, out nextCp1, out nextRefs1);
                              foreach (var nextRd1 in nextRefs1)
                              {
                                  var node = nextRd1.NodeId;
                                  Console.WriteLine("+ {0}: {1}, {2}", nextRd1.DisplayName, nextRd1.BrowseName, nextRd1.NodeClass);
                              }
                          }*/
                    }

                   

                    oPCUaClientAddressSpace = new OPCUaClientAddressSpace
                    {
                        AccessRestrictions =accessRestrictions==null?"NA":accessRestrictions,
                        BrowseName = nodeData?.BrowseName?.Name ?? "NA",
                       // DataLock =nodeData?.BrowseName?.Name??"NA",
                        Description = nodeData?.Description?.Text ?? "NA",
                        DisplayName = nodeData?.DisplayName?.Text ?? "NA",
                        Handle = handle==null?"NA":handle,
                        NodeClass =nodeClass,
                        NodeId = nodeData?.NodeId.ToString(),
                        References =nodeData?.References.Count==0?"NA":references,
                        RolePermissions = nodeData?.RolePermissions.Count==0?"NA":"",
                        //TypeDefinitionId = nodeData.TypeDefinitionId.ToString(),
                        //TypeId = nodeData.TypeId.ToString(),
                        UserRolePermissions= nodeData.UserRolePermissions.Count==0?"NA":"",
                       // UserWriteMask = nodeData.UserWriteMask.ToString(),
                       // WriteMask = nodeData.WriteMask.ToString(),
                        AccessLevel=accessLevelDescription,
                        LstNodeDetails = lstNodeDetails
                    };

                    if (string.IsNullOrEmpty(model.NodeId))
                    {
                        CommonServices commonServices = new CommonServices();
                        commonServices.AddToAuditLog("Address Space Fetched Successfully", "Machine Communication", "",MachineId: machineCommunicationViewModel.MachineId, UserId: userId);

                    }


                }
                else
                {
                    oPCUaClientAddressSpace = new OPCUaClientAddressSpace
                    {
                        Message = "Invalid username or password"
                    };
                }
            }
            catch(Exception ex)
            {
                //oPCUaClientAddressSpace = new OPCUaClientAddressSpace
                //{
                //    Message = "Invalid username or password"
                //};

                CommonServices commonServices = new CommonServices();
                commonServices.AddToAuditLog("Address Space Fetching Failed", "Machine Communication", "", MachineId: machineCommunicationViewModel.MachineId, UserId: userId);
                if (!string.IsNullOrEmpty(ex.Message))
                {
                    if (ex.Message.ToLower() == "badsessionclosed")
                        RenewSessionThread(OPCSessionForAddressSpace, ex.Message);
                }
            }
            return oPCUaClientAddressSpace;


        }

        public Node GetNodeDetails(string nodeId)
        {
           return OPCSessionForAddressSpace.ReadNode(nodeId);

        }

        ~ClsOpcUaClient()
        {
            try
            {

                //OPCSession.Close();
                //OPCSession.Dispose();
                //OPCSession = null;
                //ServerPortNumber = null;
                //SecurityEnabled = false;
                //ApplicationName = null;

            }
            catch { }

        }

    }

}

