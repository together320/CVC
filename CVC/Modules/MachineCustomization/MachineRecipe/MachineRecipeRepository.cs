// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineRecipeRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data.EDMX;
using CVC.MachineCustomization.Entities;
using CVC.Modules.Common.Dashboard;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;
using System.Web;
using Serenity.Web;
using System;

namespace CVC.MachineCustomization.Repositories
{
    //public class MachineRecipeListRequest : ListRequest
    //{
    //    public int? Moduleid { get; set; }
    //}

    public class MachineRecipeRepository
    {
        private static MachineRecipeRow.RowFields fld
        {
            get
            {
                return MachineRecipeRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineRecipeRow> request)
        {
          
            //int machineViewId = 1;
            int machineViewId = 1;
            // CVCEntities cvcEntities = new CVCEntities();
            //changes added By Vinayak On 21.07.2018
            var moduleId = HttpContext.Current.Session["ModuleIdRecipe"].ToString();
            int? machineId = new DashboardCommon().GetMachineId(moduleId);
            //var aa = machineId;
            int ModuleID = Convert.ToInt32(moduleId);
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                machineViewId = cvcEntities.Views.Where(i => i.ModuleId == ModuleID && i.IsMachineSettings == true)?.FirstOrDefault()?.ViewsId ?? 0;
            }
            //changes ended By Vinayak On 21.07.2018

            ////changes added by Vinayak On 25.07.2018

            //var batchForLabel = new DashboardCommon().GetBatchForLebelRollCurrent();
            //request.Entity.RecipeSettingsId = batchForLabel;
            ////changes ended by Vinayak On 25.07.2018

            request.Entity.StatusId = 1;
            request.Entity.MachineId = machineId;// cvcEntities.Views.FirstOrDefault(a => a.ViewsId == machineViewId).Module.MachineId;
            int? PackId = 0;
            if (HttpContext.Current.Cache["PackId"] != null)
            {
                PackId = Convert.ToInt32(HttpContext.Current.Cache["PackId"]);
                request.Entity.PackId = PackId;
            }

            #region Sr.No.94 Date: 05/02/2020 Code added to ensure only unique recipe name for one packname/packcode
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var checkRecipeExist = cvcEntities.MachineRecipes.FirstOrDefault(i => i.RecipeName == request.Entity.RecipeName && i.PackId == PackId);
                if (checkRecipeExist != null)
                {
                    throw new System.ArgumentException("Recipe name already exist!");
                }
            }

            #endregion
            var ret = new MachineRecipeRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
           
          
            new DashboardCommon().SaveMachineRecipe(uow, int.Parse(ret.EntityId.ToString()), machineViewId, machineId);
           
            return ret;
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineRecipeRow> request)
        {
           // CVCEntities cvcEntities = new CVCEntities();
           // int machineViewId = 1;
            int machineViewId = 1;
            //changes added By Vinayak On 21.07.2018
            var moduleId = HttpContext.Current.Session["ModuleId"].ToString();
            int? machineId = new DashboardCommon().GetMachineId(moduleId);
            //changes ended by Vinayak On 21.07.2018
            int ModuleID = Convert.ToInt32(moduleId);
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                machineViewId = cvcEntities.Views.Where(i => i.ModuleId == ModuleID && i.IsMachineSettings == true)?.FirstOrDefault()?.ViewsId ?? 0;
            }
            if (HttpContext.Current.Cache["PackId"] != null)
            {
                int? PackId = Convert.ToInt32(HttpContext.Current.Cache["PackId"]);
                request.Entity.PackId = PackId;
            }

            var ret = new MachineRecipeRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
            new DashboardCommon().SaveMachineRecipe(uow, int.Parse(ret.EntityId.ToString()), machineViewId, machineId);
            return ret;
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MachineRecipeRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MachineRecipeRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {

            return new MachineRecipeRepository.MyRetrieveHandler().Process(connection, request);
        }

        public HttpSessionStateWrapper get()
        {
            return new HttpSessionStateWrapper(HttpContext.Current.Session);
        }

        #region Dispaly Recipe MachineAndPackWise
        public ListResponse<MachineRecipeRow> List(IDbConnection connection, ListRequest request)
        {
            if (HttpContext.Current.Session["RequestRecipeSection"]!=null)
            {
              //  HttpContext.Current.Session["RequestRecipeSection"] = null;

              var moduleId = HttpContext.Current.Session["ModuleIdRecipe"].ToString();

                //var batchForLabel = new DashboardCommon().GetBatchForLebelRoll();

               // CVCEntities cvcEntities = new CVCEntities();

                int? machineId = new DashboardCommon().GetMachineId(moduleId);
                ListResponse<MachineRecipeRow> lst = new MachineRecipeRepository.MyListHandler().Process(connection, request);
                
                //var machineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == modId).MachineId;

                int? PackId = Convert.ToInt32(HttpContext.Current.Cache["PackId"]);

                foreach (var item in lst.Entities.ToList())
                {
                    if (item.MachineId != machineId)
                    {
                        lst.Entities.Remove(item);
                    }
                    else
                    {
                        if (item.PackId != PackId)
                        {
                            lst.Entities.Remove(item);
                        }
                    }
                }


                //foreach (var item in lst.Entities.ToList())
                //{
                //    if (item.RecipeSettingsId != batchForLabel)
                //    {
                //        lst.Entities.Remove(item);
                //    }
                //}
                return lst;
                //return new MachineRecipeRepository.MyListHandler().Process(connection, request);

            }
            else
            {
                ListResponse<MachineRecipeRow> lst = new MachineRecipeRepository.MyListHandler().Process(connection, request);

                return new MachineRecipeRepository.MyListHandler().Process(connection, request);

            }

        }
        #endregion

        private class MySaveHandler : SaveRequestHandler<MachineRecipeRow>
        {
         
        }
       
        private class MyDeleteHandler : DeleteRequestHandler<MachineRecipeRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<MachineRecipeRow>
        {
        }

        private class MyListHandler : ListRequestHandler<MachineRecipeRow>
        {
            readonly int PackId = Convert.ToInt32(HttpContext.Current.Cache["PackId"]);
            readonly int MachineId = Convert.ToInt32(HttpContext.Current.Cache["ActiveMachineId"]);
            protected override void ApplyFilters(SqlQuery query)
            {
                if (HttpContext.Current.Session["RequestRecipeSection"] != null)
                {
                    base.ApplyFilters(query);
                    // Ignore inactive records
                    query.Where(new Criteria(fld.MachineId) == MachineId && new Criteria(fld.PackId) == PackId);
                }
            }
        }
    }
}
