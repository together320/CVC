using CVC.Data.EDMX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
//using ParS7Comm;
namespace CVC.AlarmWindowsService
{
    public partial class Service1 : ServiceBase
    {
     // static  ParS7Comm.S7Comm s7comm;


        Timer timer = new Timer();
       // int count;
        List<string> lstIPCAddress = new List<string>();
       // int? BatchId = null;
        public Service1()
        {
            InitializeComponent();

           // MyFunction();
        }


       static  void Main()
        {
           

            //if (!IS_DEBUG)
            //{
            //    System.ServiceProcess.ServiceBase[] ServicesToRun;
            //    ServicesToRun = new System.ServiceProcess.ServiceBase[] { new Service1() };
            //    System.ServiceProcess.ServiceBase.Run(ServicesToRun);
            //}
            // else
            {
                // Debug code: this allows the process to run as a non-service.

                // It will kick off the service start point, but never kill it.

                // Shut down the debugger to exit

                Service1 service = new Service1();
               // service.MyFunction();
                //service.Outcome(0);
                //service.Write();
                // Put a breakpoint on the following line to always catch
                // your service when it has finished its work
                //System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
            }
        }
        public void WorkProcess(object sender, System.Timers.ElapsedEventArgs e)
        {
          //  WriteToFile("Call Connect Function2");
          //  MyFunction();
           // Connect();
           // CheckAlarmNew1();
       
        }

        protected  override  void OnStart(string[] args)
        {
           // WriteToFile("Service is started at " + DateTime.Now);
           // s7comm = new S7Comm();
            //s7comm.Outcome += Outcome;
            //  WriteToFile("Service is started at " + DateTime.Now);
            //timer.Elapsed += new ElapsedEventHandler(WorkProcess);
            //timer.Interval = 1000; //number in milisecinds  
            //timer.Enabled = true;
            // LogService("Service is Started");
            //aTimer.Enabled = true;
        }

        protected override void OnStop()
        {
            WriteToFile("Service is stopped at " + DateTime.Now);
            // LogService("Service Stoped");
            //aTimer.Enabled = false;

        }


////        public void MyFunction()
////        {
////           // WriteToFile("my function2");

////            //try
////            //{
//////WriteToFile("Connect Started");

////                s7comm = new S7Comm();
////           // s7comm.Demo = false;
////          //  WriteToFile("S7 object");

////            s7comm.Outcome += Outcome;
////            s7comm.Protocol = ParS7Comm.ProtocolTypes.ISOTCP;
////            s7comm.m_Protocol = ProtocolTypes.ISOTCP;
////            s7comm.IPAddr = "192.168.0.1";
////            s7comm.IPPort = 102;
////            s7comm.Rack = 0;
////            s7comm.Slot = 1;
////            s7comm.TimeOut = 100000;
////            s7comm.Open();
////          //  WriteToFile("Connect Finished");
////            //}
////            //catch (System.Exception ex)
////            //{
////            //    WriteToFile("Connect exception " + ex.Message);

////            //}
////        }

        #region Parijat S7

        //public void Connect()
        //{
        //    try
        //    {
        //        WriteToFile("Connect Started");

        //        s7comm = new S7Comm();
        //        s7comm.Outcome += Outcome;
        //        s7comm.Protocol = ParS7Comm.ProtocolTypes.ISOTCP;
        //        s7comm.m_Protocol = ProtocolTypes.ISOTCP;
        //        s7comm.IPAddr = "192.168.0.1";
        //        s7comm.IPPort = 102;
        //        s7comm.Rack = 0;
        //        s7comm.Slot = 1;
        //        s7comm.TimeOut = 100000;
        //        s7comm.Open();
        //       // WriteToFile("Connect Finished");
        //    }
        //    catch(System.Exception ex)
        //    {
        //       // WriteToFile("Connect exception "+ ex.Message);

        //    }
        //}

        //public  void Outcome(int Result)
        //{
        //  //  WriteToFile("Outcome started");
        //    if (Result == 0)
        //    {
        //        if (s7comm.PLCFunction == ParS7Comm.PLCFunctionTypes.WRITE)
        //        {
        //           // Write();
        //        }
        //    }
        //}

        //private void Write()
        //{
        //    // var access = (ParS7Comm.S7Comm)Session["par"];
        //    s7comm.Outcome += Outcome;

        //    s7comm.Protocol = ParS7Comm.ProtocolTypes.ISOTCP;
        //    s7comm.TimeOut = 100000;
        //    s7comm.PLCFunction = ParS7Comm.PLCFunctionTypes.WRITE;
        //    s7comm.DataType = ParS7Comm.DataTypes.Short;
        //    s7comm.MemType = ParS7Comm.MemTypes.DB;
        //    s7comm.StartAddr = 308;
        //    s7comm.DataLength = 1;
        //    // s7Comm.ShowMsg = true;
        //    s7comm.DBNumber = 1;
        //    s7comm.BitNumber = 0;
        //    s7comm.PLCAddr = 1;

        //    DataToWrite();


        //    s7comm.RefreshInfo();
        //    WriteToFile("write finished");

        //}

        private void DataToWrite()
        {
            for (int i = 0; i < 10; i++)
            {
               // s7comm.set_InfoShort((short)(i * 2), 169);


            }

            WriteToFile("data write finished");
        }


        #endregion



        //private void AlarmService()
        //{
        //    new CVC.Modules.Common.Dashboard.DashboardCommon().CheckAlarmNew();
        //}

        //public string ReverseString(string val)
        //{
        //    return new string(val.ToCharArray().Reverse().ToArray());
        //}

        //public void CheckAlarmNew()
        //{
           
        //    try
        //    {
        //        CVCEntities cvcEntities = new CVCEntities();

        //        //   WriteToFile("cvcEntities started at " + DateTime.Now);
        //        var data = (from i in cvcEntities.IPCParameters
        //                    join a in cvcEntities.Alarms on i.MachineParameterId equals a.MachineParameterId
        //                    where i.IsBitWise==true && i.IsAlarm==true
        //                    select new { IPCAddress = i.IPCAddress }).ToList();
        //        IEnumerable<string> IPCAddressList = data.Select(x => x.IPCAddress).Distinct().ToList();
        //      //  WriteToFile("data count " + data.Count());
        //        foreach (var IPCAddress in IPCAddressList)
        //        {
        //            var MachineParameterId = cvcEntities.IPCParameters.Where(i => i.IPCAddress == IPCAddress).FirstOrDefault()?.MachineParameterId ?? 0;
        //            string GetAlarmBits = new CVC.PLC.Operations().ReadAlarm(IPCAddress, MachineParameterId);
        //            GetAlarmBits = ReverseString(GetAlarmBits);
        //            if (GetAlarmBits.Contains("1"))
        //            {
        //                for (int i = 0; i < GetAlarmBits.Length-1; i++)
        //                {
        //                    if (GetAlarmBits[i].ToString() == "1")
        //                    {
        //                        var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
        //                        var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //                        if (updateAlarm != null)
        //                        {
        //                            updateAlarm.lastvalue = true;
        //                            cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //                            cvcEntities.SaveChanges();

        //                            AddAlarmLog(updateAlarm, true, cvcEntities);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
        //                        var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //                        if (updateAlarm != null)
        //                        {
        //                            updateAlarm.lastvalue = false;
        //                            cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //                            cvcEntities.SaveChanges();
        //                        }
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                for (int i = 0; i < GetAlarmBits.Length-1; i++)
        //                {

        //                    var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
        //                    var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //                    if (updateAlarm != null)
        //                    {
        //                        updateAlarm.lastvalue = false;
        //                        cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //                        cvcEntities.SaveChanges();

        //                        UpdateAlarmLog(updateAlarm, false, cvcEntities);
        //                    }


        //                }
        //            }
        //        }

        //    }
        //    catch (System.Exception ex)
        //    {
        //        WriteToFile("exception" + ex.Message);
        //    }

        //    finally
        //    {
        //        GC.Collect();
        //    }
        //}

        //public void CheckAlarmNew1()
        //{

        //    try
        //    {
        //        if (lstIPCAddress.Count == 0)
        //        {
        //            using (CVCEntities cvcEntities = new CVCEntities())
        //            {
        //                var data = (from i in cvcEntities.IPCParameters
        //                            join a in cvcEntities.Alarms on i.MachineParameterId equals a.MachineParameterId
        //                            where  i.IsAlarm == true
        //                            select new { IPCAddress = i.IPCAddress }).ToList();
        //                lstIPCAddress = data.Select(a => a.IPCAddress).Distinct().ToList();




        //               // cvcEntities.Dispose();


        //            }
                    
        //        }


        //        foreach (var IPCAddress in lstIPCAddress)
        //            {
        //            using (CVCEntities cvcEntities = new CVCEntities())
        //            {
        //                var MachineParameterId = cvcEntities.IPCParameters.Where(i => i.IPCAddress == IPCAddress).FirstOrDefault()?.MachineParameterId ?? 0;
        //                var GetAlarmBits = new CVC.PLC.AlarmOperation().ReadAlarm(IPCAddress, MachineParameterId);

        //                GetAlarmBits = ReverseString(GetAlarmBits);

        //                if (GetAlarmBits.Contains("1"))
        //                {
        //                    for (int i = 0; i < GetAlarmBits.Length - 1; i++)
        //                    {
        //                        if (GetAlarmBits[i].ToString() == "1")
        //                        {
        //                            var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
        //                            var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //                            if (updateAlarm != null)
        //                            {
        //                                updateAlarm.lastvalue = true;
        //                                cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //                                cvcEntities.SaveChanges();

        //                                AddAlarmLog(updateAlarm, true, cvcEntities);
        //                            }
        //                        }
        //                        else
        //                        {
        //                            var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
        //                            var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //                            if (updateAlarm != null)
        //                            {
        //                                updateAlarm.lastvalue = false;
        //                                cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //                                cvcEntities.SaveChanges();
        //                            }
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    for (int i = 0; i < GetAlarmBits.Length - 1; i++)
        //                    {

        //                        var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
        //                        var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //                        if (updateAlarm != null)
        //                        {
        //                            updateAlarm.lastvalue = false;
        //                            cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //                            cvcEntities.SaveChanges();

        //                            UpdateAlarmLog(updateAlarm, false, cvcEntities);
        //                        }


        //                    }
        //                }

        //                cvcEntities.Dispose();

        //            }
                  

        //        }

        //    }
        //    catch (System.Exception ex)
        //    {
        //        WriteToFile("exception" + ex.Message);
        //    }

        //    finally
        //    {
        //         GC.Collect();
        //    }
        //}

        //private void LogService(string content)
        //{
        //    FileStream fs = new FileStream(@ "d:\TestServiceLog.txt", FileMode.OpenOrCreate, FileAccess.Write);
        //    StreamWriter sw = new StreamWriter(fs);
        //    sw.BaseStream.Seek(0, SeekOrigin.End);
        //    sw.WriteLine(content);
        //    sw.Flush();
        //    sw.Close();
        //}

        public void WriteToFile(string Message)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
                if (!File.Exists(filepath))
                {
                    // Create a file to write to.   
                    using (StreamWriter sw = File.CreateText(filepath))
                    {
                        sw.WriteLine(Message);
                        sw.Dispose();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        sw.WriteLine(Message);
                        sw.Dispose();
                    }
                }
            }
            catch (System.Exception ex)
            {

            }
            finally
            {
                GC.Collect();
              //  GC.WaitForPendingFinalizers();
            }
        }

        //public void AddAlarmLog(Alarm updateAlarm, bool IsaAlarmActive,CVCEntities cvcEntities)
        //{
        //    var AlarmLog = cvcEntities.AlarmLogs.Where(a => a.AlarmId == updateAlarm.AlarmId && a.IsAlarmActive == true).OrderByDescending(a => a.AlarmDateTime).FirstOrDefault();
        //    if (AlarmLog == null)
        //    {
        //        //Save Alarm Log
        //        AlarmLog log = new AlarmLog();
        //        log.MachineId = updateAlarm.MachineId;
        //        log.AlarmId = updateAlarm.AlarmId;
        //        log.LoggedUserId = null;
        //        log.AlarmDateTime = DateTime.Now;
        //        log.BatchId =GetCurrentRunningBatch();
        //        log.IsAlarmActive = IsaAlarmActive;
        //        cvcEntities.AlarmLogs.Add(log);
        //        cvcEntities.SaveChanges();
        //    }
        //}

        //public void UpdateAlarmLog(Alarm updateAlarm, bool IsaAlarmActive, CVCEntities cvcEntities)
        //{
        //    var AlarmLog = cvcEntities.AlarmLogs.Where(a => a.AlarmId == updateAlarm.AlarmId && a.IsAlarmActive == true).OrderByDescending(a => a.AlarmDateTime).FirstOrDefault();
        //    if (AlarmLog != null)
        //    {
        //        AlarmLog.IsAlarmActive = IsaAlarmActive;
        //        cvcEntities.Entry<AlarmLog>(AlarmLog).State = System.Data.Entity.EntityState.Modified;
        //        cvcEntities.SaveChanges();
        //    }
        //}

        //public int? GetCurrentRunningBatch()
        //{
        //    using (CVCEntities cvcEntities = new CVCEntities())
        //    {
        //        if (cvcEntities.Batches.Any(a => a.BatchStatus == "Batch Started"))
        //        {
        //          return  cvcEntities.Batches.Where(a => a.BatchStatus == "Batch Started").OrderByDescending(a => a.BatchId)?.FirstOrDefault()?.BatchId??null;
        //        }
        //    }
        //    return null;
        //}

    }
}
