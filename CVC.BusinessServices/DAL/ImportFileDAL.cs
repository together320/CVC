using CVC.BusinessServices.Common;
using CVC.Data.EDMX;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace CVC.BusinessServices.DAL
{
    public class ImportFileDAL
    {
        ObjectCache cache = MemoryCache.Default;
        ClsCacheConfig clsCacheConfig = new ClsCacheConfig();
        CommonServices commonServices = new CommonServices();
        int failedRecordCount = 0;
        int succededRecordCount = 0;
        //public ImportFileDAL()
        //{ 

        //    var failedRecordCount = 0;
        //    var succededRecordCount = 0;
        //}


        public void ClearImportCacheItem()
        {
            var fieldInfos = ClsExtensionMethods.GetFieldInfo();
            foreach (FieldInfo item in fieldInfos)
            {
                if (item.Name.Contains("Import"))
                {
                    clsCacheConfig.RemoveItemFromCache(item.Name);
                }
            }


        }
        public void Data()
        {
            var formName = clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileFormName);
            if (formName != null)
            {
                formName = (string)formName;
            }

            var dt = new DataTable();

            var importedFileDataAfterColumnFieldMapping = clsCacheConfig.GetCacheData(ClsCacheConfig.CacheKeys.ImportedFileDataAfterColumnFieldMapping);
            if (importedFileDataAfterColumnFieldMapping != null)
            {
                dt = (DataTable)importedFileDataAfterColumnFieldMapping;
            }

            ImportCityData(dt);
        }

        public void ImportCityData(DataTable dt)
        {

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                  try
                 {
                    CityDetail cityDetail = new CityDetail();
                    cityDetail.Country = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CityFormField), 1)]);
                    cityDetail.State = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CityFormField), 2)]);
                    cityDetail.City = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CityFormField), 3)]);
                    cityDetail.Status.StatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CityFormField), 4)]);

                    if(string.IsNullOrEmpty(cityDetail.Country) && string.IsNullOrEmpty(cityDetail.State) && string.IsNullOrEmpty(cityDetail.City) && string.IsNullOrEmpty(cityDetail.Status.StatusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var statusData =(Status)CheckValidation("status", cityDetail.Status.StatusName);
                    if (statusData== null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    cityDetail.StatusId = statusData.StatusId;
                   // var response =new CommonController().GetMessageDetailsById((int)MessageType.FileUploadedSuccessfully);

                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }

                    
                }
            
        }

        public void ImportRoleData(DataTable dt)
        {

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    Role role = new Role();

                    role.RoleName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.RoleFormField), 1)]);
                    var parentRoleName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.RoleFormField), 2)]);
                    role.Status.StatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.RoleFormField), 3)]);

                    if (string.IsNullOrEmpty(role.RoleName) && string.IsNullOrEmpty(role.Status.StatusName))
                    {
                        failedRecordCount++;
                        continue;
                    }
                    var parentRoleData = (Role)CheckValidation("role", parentRoleName);
                    if (parentRoleData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    
                    var statusData = (Status)CheckValidation("status", role.Status.StatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                                   
                    role.StatusId = statusData.StatusId;

                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }

        public void ImportDepartmentData(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                   Department department = new Department();

                   department.DepartmentCode = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DepartmentFormField), 1)]);
                   department.DepartmentName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DepartmentFormField), 2)]);
                   department.Status.StatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DepartmentFormField), 3)]);

                    if (string.IsNullOrEmpty(department.DepartmentCode) && string.IsNullOrEmpty(department.DepartmentName) && string.IsNullOrEmpty(department.Status.StatusName))
                    {
                        failedRecordCount++;
                        continue;
                    }
                   
                    var statusData = (Status)CheckValidation("status", department.Status.StatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    department.StatusId = statusData.StatusId;

                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }

        public void ImportProtocolData(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    Protocol protocol = new Protocol();
                    protocol.ProtocolName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.ProtocolFormField), 1)]);
                    protocol.Status.StatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.ProtocolFormField), 2)]);

                    if (string.IsNullOrEmpty(protocol.ProtocolName) && string.IsNullOrEmpty(protocol.Status.StatusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var statusData = (Status)CheckValidation("status", protocol.Status.StatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    protocol.StatusId = statusData.StatusId;

                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }

        public void ImportPickListData(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    PickListValue pickListValue = new PickListValue();

                    pickListValue.PickList.PickListName= Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PickListValueFormField), 1)]);
                    pickListValue.PickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PickListValueFormField), 2)]);
                    pickListValue.Status.StatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PickListValueFormField), 3)]);

                    if (string.IsNullOrEmpty(pickListValue.PickList.PickListName) && string.IsNullOrEmpty(pickListValue.PickListValueName) && string.IsNullOrEmpty(pickListValue.Status.StatusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var pickListData = (PickList)CheckValidation("pickList", pickListValue.PickList.PickListName);
                    if (pickListData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }


                    var statusData = (Status)CheckValidation("status", pickListValue.Status.StatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    pickListValue.PickListId = pickListData.PickListId;
                    pickListValue.StatusId = statusData.StatusId;

                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }

        public void ImportBottleData(DataTable dt)
        {         
            var bottleCCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 2)));
            var bottleHeightExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 3)));
            var bottleDiameterExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 4)));
            var bottleMouthOpening_IDExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 5)));
            var bottleMouthOpening_ODExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.BottleFormField), 6)));


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                     Bottle bottle = new Bottle();
                     bottle.BottleName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 1)]);
                     bottle.PickListValue.PickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 3)]);                 
                     bottle.Supplier.SupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 8)]);
                     bottle.Status.StatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PickListValueFormField), 9)]);

                    if (string.IsNullOrEmpty(bottle.BottleName) && string.IsNullOrEmpty(bottle.Status.StatusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    if (bottleCCExist)
                    {
                        bottle.BottleCC = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 2)]);
                    }
                    if (bottleHeightExist)
                    {
                        bottle.BottleHeight = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 4)]);
                    }
                    if (bottleDiameterExist)
                    {
                        bottle.BottleDiameter = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 5)]);
                    }
                    if (bottleMouthOpening_IDExist)
                    {
                       bottle.BottleMouthOpening_ID = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 6)]);
                    }
                    if (bottleMouthOpening_ODExist)
                    {
                        bottle.BottleMouthOpening_OD = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.BottleFormField), 7)]);
                    }
                    
                    var pickListData = (PickList)CheckValidation("pickList", bottle.PickListValue.PickListValueName);
                    if (pickListData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    bottle.ContainerTypeId = pickListData.PickListId;

                    var statusData = (Status)CheckValidation("status", bottle.Status.StatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    bottle.StatusId = statusData.StatusId;

                    var supplierData = (Supplier)CheckValidation("supplier", bottle.Supplier.SupplierName);
                    if (supplierData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    bottle.SupplierId = supplierData.SupplierId;

                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }

        public void ImportCapData(DataTable dt)
        {
            var capCCExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.CapFormField), 2)));
            var supplierExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.CapFormField), 6)));
         

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    Cap cap = new Cap();

                    cap.CapName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 1)]);
                    cap.PickListValue.PickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 3)]);
                    cap.CapDiameter = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 4)]);
                    cap.CapHeight = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 5)]);
                    cap.Status.StatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 7)]);

                    if (string.IsNullOrEmpty(cap.CapName) && string.IsNullOrEmpty(cap.PickListValue.PickListValueName) && string.IsNullOrEmpty(cap.CapDiameter) && string.IsNullOrEmpty(cap.CapHeight) && string.IsNullOrEmpty(cap.Status.StatusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    if (capCCExist)
                    {
                        cap.CapCC = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 2)]);
                    }
                    if (supplierExist)
                    {
                        cap.Supplier.SupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CapFormField), 7)]);
                    }
                   

                    var pickListData = (PickList)CheckValidation("pickList", cap.PickListValue.PickListValueName);
                    if (pickListData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var statusData = (Status)CheckValidation("status", cap.Status.StatusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    cap.StatusId = statusData.StatusId;

                    var supplierData = (Supplier)CheckValidation("supplier", cap.Supplier.SupplierName);
                    if (supplierData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    cap.SupplierId = supplierData.SupplierId;

                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }
            }
        }

        public void ImportCottonData(DataTable dt)
        {

            var supplierExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.CottonFormField), 4)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    Cotton cotton = new Cotton();

                    cotton.CottonName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 1)]);
                    cotton.PickListValue.PickListValueName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 2)]);
                    cotton.GmOrYard = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 3)]);
                    cotton.Supplier.SupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 4)]);
                    cotton.Status.StatusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 5)]);

                    if (string.IsNullOrEmpty(cotton.CottonName) && string.IsNullOrEmpty(cotton.PickListValue.PickListValueName) && string.IsNullOrEmpty(cotton.GmOrYard) && string.IsNullOrEmpty(cotton.Status.StatusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    if (supplierExist)
                    {
                        cotton.Supplier.SupplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.CottonFormField), 4)]);
                    }

                    var pickListData = (PickList)CheckValidation("pickList", cotton.PickListValue.PickListValueName);
                    if (pickListData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    

                    //var statusData = (Status)CheckValidation("status", cotton.Status.StatusId);
                    //if (statusData == null)
                    //{
                    //    failedRecordCount++;
                    //    continue;
                    //}

                    //var supplierData = (Supplier)CheckValidation("supplier", supplierName);
                    //if (supplierData == null)
                    //{
                    //    failedRecordCount++;
                    //    continue;
                    //}

                    //Cotton cotton = new Cotton
                    //{


                    //};




                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }

        public void desiccant(DataTable dt)
        {
            var failedRecordCount = 0;
            var succededRecordCount = 0;

            var desiccantName = string.Empty;
            var desiccantType = string.Empty;
            var grammage = string.Empty;
            var lengthOrHeight = string.Empty;
            var diameterOrWidth = string.Empty;
            var identification = string.Empty;
            var supplierName = string.Empty;
            var statusName = string.Empty;

            var supplierExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.DesiccantFormField), 7)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    desiccantName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 1)]);
                    desiccantType = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 2)]);
                    grammage = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 3)]);
                    lengthOrHeight = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 4)]);
                    diameterOrWidth = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 5)]);
                    identification = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 6)]);
                    supplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 7)]);
                    statusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 8)]);

                    if (string.IsNullOrEmpty(desiccantName) && string.IsNullOrEmpty(desiccantType) && string.IsNullOrEmpty(grammage) && string.IsNullOrEmpty(lengthOrHeight) && string.IsNullOrEmpty(diameterOrWidth) && string.IsNullOrEmpty(identification) && string.IsNullOrEmpty(statusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    if (supplierExist)
                    {
                        supplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 7)]);
                    }


                    var pickListData = (PickList)CheckValidation("pickList", desiccantType);
                    if (pickListData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }


                    var statusData = (Status)CheckValidation("status", statusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var supplierData = (Supplier)CheckValidation("supplier", supplierName);
                    if (supplierData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    Desiccant desiccant = new Desiccant
                    {


                    };




                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }

        public void label(DataTable dt)
        {
            var failedRecordCount = 0;
            var succededRecordCount = 0;

            var labelName = string.Empty;
            var labelLength = string.Empty;
            var labelHeight = string.Empty;
            var labelType = string.Empty;
            var supplierName = string.Empty;
            var statusName = string.Empty;

            var supplierExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.LabelFormField), 5)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    labelName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 1)]);
                    labelLength = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 2)]);
                    labelHeight = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 3)]);
                    labelType = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 4)]);
                    supplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 5)]);
                    statusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 6)]);

                    if (string.IsNullOrEmpty(labelName) && string.IsNullOrEmpty(labelLength) && string.IsNullOrEmpty(labelHeight) && string.IsNullOrEmpty(labelType) && string.IsNullOrEmpty(statusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    if (supplierExist)
                    {
                        supplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 5)]);
                    }


                    var pickListData = (PickList)CheckValidation("pickList", labelType);
                    if (pickListData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var statusData = (Status)CheckValidation("status", statusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var supplierData = (Supplier)CheckValidation("supplier", supplierName);
                    if (supplierData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    Label label = new Label
                    {


                    };




                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }

        public void outsert(DataTable dt)
        {
            var failedRecordCount = 0;
            var succededRecordCount = 0;

            var outsertName = string.Empty;
            var outsertLength = string.Empty;
            var outsertWidth = string.Empty;
            var outsertThickness = string.Empty;
            var supplierName = string.Empty;
            var statusName = string.Empty;

            var supplierExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.OutsertFormField), 5)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    outsertName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 1)]);
                    outsertLength = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 2)]);
                    outsertWidth = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 3)]);
                    outsertThickness = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 4)]);
                    supplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 5)]);
                    statusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 6)]);

                    if (string.IsNullOrEmpty(outsertName) && string.IsNullOrEmpty(outsertLength) && string.IsNullOrEmpty(outsertWidth) && string.IsNullOrEmpty(outsertThickness) && string.IsNullOrEmpty(statusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    if (supplierExist)
                    {
                        supplierName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.OutsertFormField), 5)]);
                    }

                    var statusData = (Status)CheckValidation("status", statusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var supplierData = (Supplier)CheckValidation("supplier", supplierName);
                    if (supplierData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    Outsert outsert = new Outsert
                    {


                    };

                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }

        public void pack(DataTable dt)
        {
            var failedRecordCount = 0;
            var succededRecordCount = 0;

            var packCode = string.Empty;
            var productName = string.Empty;
            var productQuantity = string.Empty;
            var bottleName = string.Empty;
            var capName = string.Empty;
            var cottonName = string.Empty;
            var cottonLength = string.Empty;
            var cottonPieces = string.Empty;
            var desiccantName = string.Empty;
            var desiccantPieces = string.Empty;
            var outsertName = string.Empty;
            var labelName = string.Empty;
            var endOfLineName = string.Empty;
            var statusName = string.Empty;

            var productQuantityExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var bottleNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var capNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var cottonNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var cottonLengthExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var cottonPiecesExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var desiccantNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var desiccantPiecesExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var outsertNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var labelNameExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));
            var endOfLineExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.PackFormField), 5)));


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    packCode = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 1)]);
                    productName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 2)]);
                    productQuantity = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 3)]);
                    bottleName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 4)]);
                    capName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 5)]);
                    cottonName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 6)]);
                    cottonLength = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 7)]);
                    cottonPieces = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 8)]);
                    desiccantName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 9)]);
                    desiccantPieces = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 10)]);
                    outsertName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 11)]);
                    labelName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 12)]);
                    endOfLineName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 13)]);
                    statusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 14)]);

                    if (string.IsNullOrEmpty(packCode) && string.IsNullOrEmpty(productName) && string.IsNullOrEmpty(statusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    if (productQuantityExist)
                    {
                        productQuantity = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 3)]);
                    }
                    if (bottleNameExist)
                    {
                        bottleName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 4)]);
                    }
                    if (capNameExist)
                    {
                        capName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 5)]);
                    }
                    if (cottonNameExist)
                    {
                        cottonName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 6)]);
                    }
                    if (cottonLengthExist)
                    {
                        cottonLength = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 7)]);
                    }
                    if (cottonPiecesExist)
                    {
                        cottonPieces = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 8)]);
                    }
                    if (desiccantNameExist)
                    {
                        desiccantName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 9)]);
                    }
                    if (desiccantPiecesExist)
                    {
                        desiccantPieces = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 10)]);
                    }
                    if (outsertNameExist)
                    {
                        outsertName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 11)]);
                    }
                    if (labelNameExist)
                    {
                        labelName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 12)]);
                    }

                    if (endOfLineExist)
                    {
                        endOfLineName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.PackFormField), 13)]);
                    }

                    var statusData = (Status)CheckValidation("status", statusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var productData = (TabletDetail)CheckValidation("tablet", productName);
                    if (productData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var bottleData = (Bottle)CheckValidation("bottle", bottleName);
                    if (bottleData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var capData = (Cap)CheckValidation("cap", capName);
                    if (capData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var cottonData = (Cotton)CheckValidation("cotton", cottonName);
                    if (cottonData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                    var desiccantData = (Desiccant)CheckValidation("cotton", desiccantName);
                    if (desiccantData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var outsertData = (Desiccant)CheckValidation("outsert", outsertName);
                    if (outsertData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var labelData = (Label)CheckValidation("label", labelName);
                    if (labelData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }

                    var endOfLineData = (EndOfLine)CheckValidation("endOfLine", endOfLineName);
                    if (endOfLineData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                   
                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }

        //public void product(DataTable dt)
        //{
        //    var failedRecordCount = 0;
        //    var succededRecordCount = 0;

        //    var productName = string.Empty;
        //    var productStrength = string.Empty;
        //    var productType = string.Empty;
        //    var characteristicsOne = string.Empty;
        //    var characteristicsTwo = string.Empty;
        //    var productShapeId = string.Empty;
        //    var productLength = string.Empty;
        //    var productThickness = string.Empty;
        //    var productWidth = string.Empty;
        //    var statusName = string.Empty;

        //    var productStrengthExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.ProductDetailsFormField), 2)));
        //    var productTypeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.ProductDetailsFormField), 3)));
        //    var characteristicsOneExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.ProductDetailsFormField), 4)));
        //    var characteristicsTwoExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.ProductDetailsFormField), 5)));
        //    var productShapeIdExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.ProductDetailsFormField), 5)));
        //    var productLengthExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.ProductDetailsFormField), 5)));
        //    var productThicknessExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.ProductDetailsFormField), 5)));
        //    var productWidthExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.ProductDetailsFormField), 5)));

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        try
        //        {
        //            productName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.ProductDetailsFormField), 1)]);
        //            productStrength = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 2)]);
        //            productType = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 3)]);
        //            characteristicsOne = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 4)]);
        //            characteristicsTwo = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 5)]);
        //            productShapeId = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 6)]);
        //            productLength = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 7)]);
        //            productThickness = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 8)]);
        //            productWidth = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.LabelFormField), 9)]);
        //            statusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.DesiccantFormField), 10)]);

        //            if (string.IsNullOrEmpty(productName) && string.IsNullOrEmpty(statusName))
        //            {
        //                failedRecordCount++;
        //                continue;
        //            }


        //            var pickListData = (PickList)CheckValidation("pickList", labelType);
        //            if (pickListData == null)
        //            {
        //                failedRecordCount++;
        //                continue;
        //            }

        //            var statusData = (Status)CheckValidation("status", statusName);
        //            if (statusData == null)
        //            {
        //                failedRecordCount++;
        //                continue;
        //            }

        //            var supplierData = (Supplier)CheckValidation("supplier", supplierName);
        //            if (supplierData == null)
        //            {
        //                failedRecordCount++;
        //                continue;
        //            }

        //            Label label = new Label
        //            {


        //            };




        //            succededRecordCount++;
        //        }

        //        catch (System.Exception ex)
        //        {
        //            failedRecordCount++;
        //            continue;
        //        }


        //    }

        //}


        public void machine(DataTable dt)
        {

            var failedRecordCount = 0;
            var succededRecordCount = 0;

            var machineName = string.Empty;
            var accessIpAddress = string.Empty;
            var machineSequence = string.Empty;
            var description = string.Empty;
            var modelNumber = string.Empty;
            var serialNumber = string.Empty;
            var make = string.Empty;
            var year = string.Empty;
            var plcMake = string.Empty;
            var plcModelNumber = string.Empty;
            var plcSerialNumber = string.Empty;
            var plcAddress = string.Empty;
            var statusName = string.Empty;
            var timerForAlarm = string.Empty;


            var descriptionExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 4)));
            var modelNumberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 5)));
            var serialNuberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 6)));
            var makeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 7)));
            var yearExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 8)));
            var plcMakeExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 9)));
            var plcModelNumberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 10)));
            var plcSerialNumberExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 11)));
            var plcAddressExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 12)));
            var timerForAlarmExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.MachineFormField), 13)));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    machineName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 1)]);
                    accessIpAddress = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 2)]);
                    machineSequence = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 3)]);
                    modelNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 5)]);
                    serialNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 6)]);
                    make = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 7)]);
                    year = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 8)]);
                    plcMake = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 9)]);
                    plcModelNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 10)]);
                    plcSerialNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 11)]);
                    plcAddress = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 12)]);
                    timerForAlarm = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 13)]);
                    statusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 14)]);

                    if (string.IsNullOrEmpty(machineName) && string.IsNullOrEmpty(accessIpAddress) && string.IsNullOrEmpty(machineSequence) && string.IsNullOrEmpty(plcMake) && string.IsNullOrEmpty(statusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    if (descriptionExist)
                    {
                        description = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 4)]);
                    }
                    if (modelNumberExist)
                    {
                        modelNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 5)]);
                    }
                    if (serialNuberExist)
                    {
                        serialNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 6)]);
                    }
                    
                    if (makeExist)
                    {
                        make = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 6)]);
                    }
                    if (yearExist)
                    {
                        year = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 6)]);
                    }
                    if (plcModelNumberExist)
                    {
                        plcModelNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 6)]);
                    }
                    if (plcMakeExist)
                    {
                        plcMake = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 6)]);
                    }
                    if (plcSerialNumberExist)
                    {
                        plcSerialNumber = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 6)]);
                    }

                    if (plcAddressExist)
                    {
                        plcAddress = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 6)]);
                    }
                    if (timerForAlarmExist)
                    {
                        timerForAlarm = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.MachineFormField), 6)]);
                    }
                    var statusData = (Status)CheckValidation("status", statusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }
                   
                  

                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }


        public void alarm(DataTable dt)
        {

            var failedRecordCount = 0;
            var succededRecordCount = 0;

            var alarmName = string.Empty;
            var machineName =string.Empty;
            var machineParameterName = string.Empty;
            var message = string.Empty;
            var description = string.Empty;
            var isResetRequired = string.Empty;
            var isCommentRequired = string.Empty;
            var isMachineRequired = string.Empty;
            var machineStopParameter = string.Empty;
            var isCountForReject = string.Empty;
            var bitValue = string.Empty;
            var isCheckAtMachineStart = string.Empty;
            var statusName = string.Empty;
            var isRefreshMachineSettings = string.Empty;
            var isHideEdit = string.Empty;
            var isAlarmForCounter = string.Empty;



            var descriptionExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
            var isResetRequiredExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
            var isCommentRequiredExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
            var isMachineRequiredExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
            var machineStopParameterExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
            var isCountForRejectExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
            var bitValueExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
            var isCheckAtMachineStartExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
            var isRefreshMachineSettingsExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
            var isHideEditExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
            var isAlarmForCounterExist = commonServices.CheckColumnExistInDataTable(dt, Convert.ToString(Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)));
           

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    alarmName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 1)]);
                    machineName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 1)]);
                    machineParameterName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 1)]);
                    message = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 1)]);
                    statusName = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 1)]);


                    if (string.IsNullOrEmpty(alarmName) && string.IsNullOrEmpty(machineName) && string.IsNullOrEmpty(machineParameterName) && string.IsNullOrEmpty(message) && string.IsNullOrEmpty(statusName))
                    {
                        failedRecordCount++;
                        continue;
                    }

                    if (descriptionExist)
                    {
                        description = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 4)]);
                    }
                    if (isResetRequiredExist)
                    {
                        isResetRequired = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 5)]);
                    }
                    if (isCommentRequiredExist)
                    {
                        isCommentRequired = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]);
                    }

                    if (isMachineRequiredExist)
                    {
                        isMachineRequired = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]);
                    }
                    if (machineStopParameterExist)
                    {
                        machineStopParameter = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]);
                    }
                    if (isAlarmForCounterExist)
                    {
                        isAlarmForCounter = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]);
                    }
                    if (isCountForRejectExist)
                    {
                        isCountForReject = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]);
                    }
                    if (isCommentRequiredExist)
                    {
                        isCommentRequired = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]);
                    }

                    if (bitValueExist)
                    {
                        bitValue = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]);
                    }
                    if (isCheckAtMachineStartExist)
                    {
                        isCheckAtMachineStart = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]);
                    }
                    if (isRefreshMachineSettingsExist)
                    {
                        isRefreshMachineSettings = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]);
                    }
                    if (isHideEditExist)
                    {
                        isHideEdit = Convert.ToString(dt.Rows[i][Enum.GetName(typeof(ClsEnum.AlarmFormField), 6)]);
                    }


                    var statusData = (Status)CheckValidation("status", statusName);
                    if (statusData == null)
                    {
                        failedRecordCount++;
                        continue;
                    }



                    succededRecordCount++;
                }

                catch (System.Exception ex)
                {
                    failedRecordCount++;
                    continue;
                }


            }

        }


        public object CheckValidation(string type,string value)
        {
            object tableObject=null;
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                switch (type)
                {
                    case "status":
                    tableObject= cVCEntities.Status.FirstOrDefault(s => s.StatusName.ToLower() == value.ToLower());
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

                }
            }

            return tableObject;
        }

        //public void  addingDetails(dynamic data)
        //{
        //    using (CVCEntities cVCEntities = new CVCEntities())
        //    {
        //        cVCEntities.CityDetails.Add(data);
        //    }

        //}

    }
}
