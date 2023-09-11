// Decompiled with JetBrains decompiler
// Type: CVC.Data.CVCDaoFactory
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll
using CVC.Data.DTO;
using CVC.Data.EDMX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CVC.Data
{
    public static class CVCDaoFactory
    {
        public static Machine GetLabelingMachine()
        {
            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                Machine machine = (Machine)null;
                IList<Machine> list = (IList<Machine>)cvcEntities.Machines.Where<Machine>((Expression<Func<Machine, bool>>)(m => m.MachineTypeID == (int?)9)).ToList<Machine>();
                if (list.Count > 0)
                    machine = list.First<Machine>();
                return machine;
            }
        }

        public static Machine GetMachine(int MachineId)
        {
            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                return cvcEntities.Machines.Where<Machine>((Expression<Func<Machine, bool>>)(m => m.MachineId == MachineId)).ToList<Machine>().First<Machine>();
            }
        }

        public static string GetAddress(int MachineId, int ScreenFieldId)
        {
            new CVCEntities().ScreenFields.Find((object)ScreenFieldId);
            return "";
        }

        public static MachineCommunication GetMachineCommunication(int MachineId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
               // CVCEntities cvcEntities = new CVCEntities();
                MachineCommunication machineCommunication = (MachineCommunication)null;
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)MachineId && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
                    machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)MachineId && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();
               // cvcEntities.Dispose();
               // GC.Collect();
                return machineCommunication;
            }
        }

        public static IList<ScreenField> GetScreenFieldList(int ScreenSectionId)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                IList<ScreenField> screenFieldList = (IList<ScreenField>)new List<ScreenField>();
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                return (IList<ScreenField>)cvcEntities.ScreenFields.Where<ScreenField>((Expression<Func<ScreenField, bool>>)(s => s.ScreenSectionId == (int?)ScreenSectionId)).ToList<ScreenField>();
            }
        }

        //public static IList<Alarm> GetAlarmList(int MachineId)
        //{
        //    CVCEntities cvcEntities = new CVCEntities();
        //    IList<Alarm> alarmList = (IList<Alarm>)new List<Alarm>();
        //    return (IList<Alarm>)cvcEntities.Alarms.Where<Alarm>((Expression<Func<Alarm, bool>>)(s => s.MachineId == (int?)MachineId && s.StatusId == (int?)1 && s.IPCParameterId != new int?())).ToList<Alarm>();
        //}

        //public static IList<Alarm> GetAlarmListOnMachineStartup(int MachineId)
        //{
        //    CVCEntities cvcEntities = new CVCEntities();
        //    IList<Alarm> alarmList = (IList<Alarm>)new List<Alarm>();
        //    return (IList<Alarm>)cvcEntities.Alarms.Where<Alarm>((Expression<Func<Alarm, bool>>)(s => s.MachineId == (int?)MachineId && s.StatusId == (int?)1 && s.IPCParameterId != new int?() && s.IsCheckAtMachineStart == (bool?)true)).ToList<Alarm>();
        //}

        //public static Alarm GetAlarmDetails(int AlarmId)
        //{
        //    CVCEntities cvcEntities = new CVCEntities();
        //    Alarm alarm = new Alarm();
        //    return cvcEntities.Alarms.Where<Alarm>((Expression<Func<Alarm, bool>>)(s => s.AlarmId == AlarmId && s.StatusId == (int?)1 && s.IPCParameterId != new int?())).ToList<Alarm>().First<Alarm>();
        //}

        public static MachineParameter GetMachineParameter(int id)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
                return cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == id);


        }


        public static BatchDTO GetBatchDetails()
        {
            int MachineLineId = 0;
            string strBottle = string.Empty;
            var line = CVCDaoFactory.GetMachineLine();
            if (line != null)
                MachineLineId = line.MachineLineId;

            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {

                var PickListId = cvcEntities.PickLists?.FirstOrDefault(pl => pl.PickListName.ToUpper() == "BOTTLE")?.PickListId ?? null;
                if (PickListId != null)
                {
                    strBottle = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListId == PickListId)?.PickListValueName ?? "Bottle";
                }

                BatchDTO batchDto = (BatchDTO)null;
                IList<Batch> list = (IList<Batch>)cvcEntities.Batches.Where<Batch>((Expression<Func<Batch, bool>>)(c => c.MachineLineId == (int?)MachineLineId)).OrderByDescending<Batch, int>((Expression<Func<Batch, int>>)(c => c.BatchId)).ToList<Batch>();
                if (list.Count > 0)
                {
                    Batch batch = list.First<Batch>();

                    batch.TotalGoodBottles = !batch.TotalGoodBottles.HasValue ? new int?(0) : batch.TotalGoodBottles;
                    batch.TotalRejectedBottles = !batch.TotalRejectedBottles.HasValue ? new int?(0) : batch.TotalRejectedBottles;
                    batch.ProductionSpeed = batch.ProductionSpeed == null ? "" : batch.ProductionSpeed;
                    batchDto = new BatchDTO();
                    batchDto.BatchId = batch.BatchId;
                    batchDto.BatchName = batch.BatchName;
                    batchDto.BatchSize = batch.BatchSize;
                    batchDto.BatchFor = batch.BatchFor;
                    batchDto.NumberOfBottles = batch.NumberOfBottles;
                    batchDto.TotalGoodBottles = batch.TotalGoodBottles;
                    batchDto.TotalRejectedBottles = batch.TotalRejectedBottles;
                    batchDto.BatchStartDateTime = batch.BatchStartDateTime;
                    batchDto.BatchEndDateTime = batch.BatchEndDateTime;
                    batchDto.BatchStatus = batch.BatchStatus;
                    batchDto.ProductionSpeed = batch.ProductionSpeed;
                    if (batch.MachineLine != null)
                        batchDto.PackageLine = batch.MachineLine.LineName;
                    batchDto.Pack = new PackDTO();
                    batchDto.Pack.PackId = batch.Pack.PackId;
                    batchDto.Pack.PackName = batch.Pack.PackName;
                    batchDto.Pack.TabletId = batch.Pack.TabletId;
                    batchDto.Pack.TabletDetail = new TabletDTO();
                    batchDto.Pack.TabletDetail.TabletName = batch.Pack.TabletDetail.TabletName;
                    batchDto.lblBottle = strBottle;
                    HttpContext.Current.Cache["PackId"] = batch.Pack.PackId;
                }
                return batchDto;
            }
        }

        public static IList<ViewField> GetViewFieldList(int ViewId)
        {
            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                IList<ViewField> viewFieldList = (IList<ViewField>)new List<ViewField>();
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                return (IList<ViewField>)cvcEntities.ViewFields.Where<ViewField>((Expression<Func<ViewField, bool>>)(s => s.ViewsId == (int?)ViewId)).ToList<ViewField>();
            }
        }

        public static IList<MachineRecipeParameter> GetMachineRecipeParameterList(int MachineRecipeId)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                IList<MachineRecipeParameter> machineRecipeParameterList = (IList<MachineRecipeParameter>)new List<MachineRecipeParameter>();
                return (IList<MachineRecipeParameter>)cvcEntities.MachineRecipeParameters.Where<MachineRecipeParameter>((Expression<Func<MachineRecipeParameter, bool>>)(s => s.MachineRecipeId == (int?)MachineRecipeId && s.StatusId == (int?)1)).ToList<MachineRecipeParameter>();
            }
        }

        public static string SaveMachineRecipeParameter(IList<MachineRecipeParameter> MachineRecipeParameterList)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                string str = "";
                try
                {
                    foreach (MachineRecipeParameter machineRecipeParameter in (IEnumerable<MachineRecipeParameter>)MachineRecipeParameterList)
                    {
                        machineRecipeParameter.CreatedDate = new DateTime?(DateTime.Now);
                        machineRecipeParameter.UpdatedDate = new DateTime?(DateTime.Now);
                        machineRecipeParameter.StatusId = new int?(1);
                        cvcEntities.MachineRecipeParameters.Add(machineRecipeParameter);
                        cvcEntities.SaveChanges();
                    }
                }
                catch (SystemException ex)
                {
                    str = ex.Message;
                }
                return str;
            }
        }

        public static IList<RecipeSettingsParameter> GetRecipeSettingsParameterList(int RecipeSettingsId)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                IList<RecipeSettingsParameter> settingsParameterList = (IList<RecipeSettingsParameter>)new List<RecipeSettingsParameter>();
                return (IList<RecipeSettingsParameter>)cvcEntities.RecipeSettingsParameters.Where<RecipeSettingsParameter>((Expression<Func<RecipeSettingsParameter, bool>>)(s => s.RecipeSettingsId == (int?)RecipeSettingsId && s.StatusId == (int?)1)).ToList<RecipeSettingsParameter>();
            }
        }

        public static string SaveBatchDetails(Batch aBatch)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                string str;
                try
                {
                    str = "1";
                    cvcEntities.Batches.Add(aBatch);
                    cvcEntities.SaveChanges();
                }
                catch (System.Exception ex)
                {
                    str = ex.Message;
                }
                return str;
            }
        }






        public static IList<Batch> GetBatchList(int MachineLineId)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                IList<Batch> batchList = (IList<Batch>)new List<Batch>();
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                return (IList<Batch>)cvcEntities.Batches.Where<Batch>((Expression<Func<Batch, bool>>)(c => c.MachineLineId == (int?)MachineLineId)).OrderByDescending<Batch, DateTime?>((Expression<Func<Batch, DateTime?>>)(c => c.BatchStartDateTime)).ToList<Batch>();
            }
        }

        public static IPCParameter GetIPCParameter(int IPCParameterId)
        {
            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                IPCParameter ipcParameter = new IPCParameter();
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                return cvcEntities.IPCParameters.Where<IPCParameter>((Expression<Func<IPCParameter, bool>>)(c => c.IPCParameterId == IPCParameterId)).ToList<IPCParameter>().First<IPCParameter>();
            }
        }

        public static User GetUser(string sUserName)
        {
            // CVCEntities cvcEntities = new CVCEntities();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    cvcEntities.Configuration.ProxyCreationEnabled = false;
                    var user = cvcEntities.Users.Where<User>((Expression<Func<User, bool>>)(u => u.Username == sUserName)).ToList<User>().First<User>();
                    if (user != null)
                        return cvcEntities.Users.Where<User>((Expression<Func<User, bool>>)(u => u.Username == sUserName)).ToList<User>().First<User>();
                    else
                        return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static User GetUser(int UserID)
        {
            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                return cvcEntities.Users.Where<User>((Expression<Func<User, bool>>)(u => u.UserId == UserID)).ToList<User>().First<User>();
            }
        }

        public static IList<Product> GetProductList()
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                IList<Product> productList = (IList<Product>)new List<Product>();
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                return (IList<Product>)cvcEntities.Products.ToList<Product>();
            }
        }

        public static IList<Pack> GetPackList()
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                IList<Pack> packList = (IList<Pack>)new List<Pack>();
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                return (IList<Pack>)cvcEntities.Packs.ToList<Pack>();
            }
        }

        public static MachineLine GetMachineLine()
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                MachineLine machineLine = (MachineLine)null;
                if (cvcEntities.MachineLines.Where<MachineLine>((Expression<Func<MachineLine, bool>>)(m => m.Status.StatusId == 1)).ToList<MachineLine>().Count > 0)
                    machineLine = cvcEntities.MachineLines.Where<MachineLine>((Expression<Func<MachineLine, bool>>)(m => m.Status.StatusId == 1)).ToList<MachineLine>().First<MachineLine>();
                return machineLine;
            }
        }

        public static string GetDbSize()

        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var sqlConn = cvcEntities.Database.Connection as SqlConnection;
                var cmd = new SqlCommand("sp_spaceused")
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Connection = sqlConn as SqlConnection
                };
                var adp = new SqlDataAdapter(cmd);
                var dataset = new DataSet();
                sqlConn.Open();
                adp.Fill(dataset);
                var result = dataset.Tables[0].Rows[0][1];
                sqlConn.Close();
                return Convert.ToString(result);
            }
        }
    }
}
