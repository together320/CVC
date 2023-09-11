using CVC.License.Algorithms.DBCONNECTIONS;
using CVC.License.Algorithms.Forms.License_New;
using CVC.License.Algorithms.License;
using CVC.License.Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using CVC.License.Algorithms.CustomFilters;
using System.Linq.Expressions;

namespace CVC.License.Algorithms.Template
{
    [CustomActionFilter1]
    public class NewLicenseManage
    {
        private ModelNewLicense modelNewLicense;
        private DBConnections dBConnections;
        ErrorManagement errorManagement = new ErrorManagement();
        public NewLicenseManage(ModelNewLicense _modelNewLicense)
        {
            modelNewLicense = _modelNewLicense;
        }
        public ModelNewLicense Create()
        {
            return NewLicenseCreate();
        }
        public ModelNewLicense Read()
        {
            return NewLicenseRead();
        }
        public ModelNewLicense Update()
        {
            return NewLicenseUpdate();
        }
        public ModelNewLicense Delete()
        {
            return NewLicenseDelete();
        }
        public bool UpdateFileLicenseDetails(LicenseFile licenseFile)
        {
            return UpdateLicenseFileDetails(licenseFile);
        }
        private bool UpdateLicenseFileDetails(LicenseFile licenseFile)
        {
            if (licenseFile != null)
            {
                dBConnections = new DBConnections();
                try
                {
                    DataSet ds = dBConnections.SendData<LicenseFile>(licenseFile, "SP_LICENSE_UPDATE_LICENSE_FILE_DETAILS");
                    if (ds != null)
                    {
                        int index = 0;
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
                }
            }
            return false;
        }
        private ModelNewLicense NewLicenseCreate()
        {
            bool flag = false;
            try
            {
                if (modelNewLicense != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    modelNewLicense.DbAction = "Create";
                    DataSet ds = dBConnections.SendData<ModelNewLicense>(modelNewLicense, "SP_NEW_LICENSE_MANAGEMENT");
                    if (ds != null)
                    {
                        int index = 0;
                        foreach (DataTable table in ds.Tables)
                        {
                            if (table.Rows.Count > 0)
                            {
                                if (index == 0)
                                {
                                    List<ModelNewLicense> modelNewLicenses = ToList<ModelNewLicense>(table);
                                    if (modelNewLicenses != null)
                                    {
                                        if (modelNewLicenses.Count > 0)
                                        {
                                            modelNewLicense = modelNewLicenses[0];
                                        }
                                        else
                                        {
                                            modelNewLicense = new ModelNewLicense();
                                        }
                                        flag = true;
                                    }
                                }
                                else if (index == 1)
                                {
                                    List<ModelLicenseModule> modelLicenseModule = ToList<ModelLicenseModule>(table);
                                    modelNewLicense.ModelLicenseModules = modelLicenseModule;
                                    flag = true;
                                }
                                else if (index == 2)
                                {
                                    List<ModelCompany> modelCompanylist = ToList<ModelCompany>(table);
                                    if (modelCompanylist != null)
                                    {
                                        if (modelCompanylist.Count > 0)
                                        {
                                            modelNewLicense.CustomerDetails = modelCompanylist[0];
                                        }
                                        else
                                        {
                                            modelNewLicense.CustomerDetails = new ModelCompany();
                                        }
                                        flag = true;
                                    }
                                }
                                else if (index == 3)
                                {
                                    List<LicenseFile> licenseFile = ToList<LicenseFile>(table);
                                    if (licenseFile != null)
                                    {
                                        if (licenseFile.Count > 0)
                                        {
                                            modelNewLicense.LicenseFile = licenseFile[0];
                                        }
                                        else
                                        {
                                            modelNewLicense.LicenseFile = new LicenseFile();
                                        }
                                        flag = true;
                                    }
                                }
                            }
                            index++;
                        }
                    }
                    else
                    {
                        NullReferenceException ex = new NullReferenceException();
                        ErrorManagement errorManagement = new ErrorManagement();
                        errorManagement.ErrorMessage("Licensed Module", ex);
                    }
                    if (ds.Tables.Count > 1)
                    {
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            GenerateLicenseFile(ds.Tables[1], modelNewLicense.UID, modelNewLicense.LicenseStartDate, modelNewLicense.LicenseEndDate,modelNewLicense.LicenseType);
                        }
                        else
                        {
                            NullReferenceException ex = new NullReferenceException();
                            ErrorManagement errorManagement = new ErrorManagement();
                            errorManagement.ErrorMessage("Licensed Module", ex);
                        }
                    }
                    else
                    {
                        NullReferenceException ex = new NullReferenceException();
                        ErrorManagement errorManagement = new ErrorManagement();
                        errorManagement.ErrorMessage("Licensed Module", ex);
                    }

                }
                if (!flag)
                {
                    modelNewLicense = new ModelNewLicense();
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return modelNewLicense;
        }
        public void GenerateLicenseFile(DataTable dataTable, string UID, string StartDate, string EndDate, string LicenseType)
        {
            try
            {
                var filename = modelNewLicense.LicenseName + DateTime.Now.ToFileTimeUtc();
                string FileType = ".lic";
                string FilePath = Properties.Settings.Default.LicenseSaveFilePath;
                // Create a new license file
                LicenseFile newLicenseFile = new NewLicenseManagement().GenerateLicense(dataTable, UID, StartDate, EndDate, filename, FilePath, FileType, LicenseType);
                newLicenseFile.LicenseID = modelNewLicense.Id.ToString();
                UpdateFileLicenseDetails(newLicenseFile);
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
        }
        private ModelNewLicense NewLicenseDelete()
        {
            bool flag = false;
            try
            {
                if (modelNewLicense != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    modelNewLicense.DbAction = "Delete";
                    DataSet ds = dBConnections.SendData<ModelNewLicense>(modelNewLicense, "SP_NEW_LICENSE_MANAGEMENT");
                    if (ds != null)
                    {
                        int index = 0;
                        foreach (DataTable table in ds.Tables)
                        {
                            if (table.Rows.Count > 0)
                            {
                                if (index == 0)
                                {
                                    List<ModelNewLicense> modelNewLicenses = ToList<ModelNewLicense>(table);
                                    if (modelNewLicenses != null)
                                    {
                                        if (modelNewLicenses.Count > 0)
                                        {
                                            modelNewLicense = modelNewLicenses[0];
                                        }
                                        else
                                        {
                                            modelNewLicense = new ModelNewLicense();
                                        }
                                        flag = true;
                                    }
                                }
                                else if (index == 1)
                                {
                                    List<ModelLicenseModule> modelLicenseModule = ToList<ModelLicenseModule>(table);
                                    modelNewLicense.ModelLicenseModules = modelLicenseModule;
                                    flag = true;
                                }
                                else if (index == 2)
                                {
                                    List<ModelCompany> modelCompanylist = ToList<ModelCompany>(table);
                                    if (modelCompanylist != null)
                                    {
                                        if (modelCompanylist.Count > 0)
                                        {
                                            modelNewLicense.CustomerDetails = modelCompanylist[0];
                                        }
                                        else
                                        {
                                            modelNewLicense.CustomerDetails = new ModelCompany();
                                        }
                                        flag = true;
                                    }
                                }
                                else if (index == 3)
                                {
                                    List<LicenseFile> licenseFile = ToList<LicenseFile>(table);
                                    if (licenseFile != null)
                                    {
                                        if (licenseFile.Count > 0)
                                        {
                                            modelNewLicense.LicenseFile = licenseFile[0];
                                        }
                                        else
                                        {
                                            modelNewLicense.LicenseFile = new LicenseFile();
                                        }
                                        flag = true;
                                    }
                                }
                            }
                            index++;
                        }
                    }
                }
                if (!flag)
                {
                    modelNewLicense = new ModelNewLicense();
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return modelNewLicense;
        }
        private ModelNewLicense NewLicenseUpdate()
        {
            bool flag = false;
            try
            {
                if (modelNewLicense != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    //modelNewLicense.LicenseDescription = "My NEW TEMPLATE";
                    modelNewLicense.DbAction = "Update";
                    //  modelNewLicense.Status = "Active";
                    DataSet ds = dBConnections.SendData<ModelNewLicense>(modelNewLicense, "SP_NEW_LICENSE_MANAGEMENT");
                    if (ds != null)
                    {
                        int index = 0;
                        foreach (DataTable table in ds.Tables)
                        {
                            if (table.Rows.Count > 0)
                            {
                                if (index == 0)
                                {
                                    List<ModelNewLicense> modelNewLicenses = ToList<ModelNewLicense>(table);
                                    if (modelNewLicenses != null)
                                    {
                                        if (modelNewLicenses.Count > 0)
                                        {
                                            modelNewLicense = modelNewLicenses[0];
                                        }
                                        else
                                        {
                                            modelNewLicense = new ModelNewLicense();
                                        }
                                        flag = true;
                                    }
                                }
                                else if (index == 1)
                                {
                                    List<ModelLicenseModule> modelLicenseModule = ToList<ModelLicenseModule>(table);
                                    modelNewLicense.ModelLicenseModules = modelLicenseModule;
                                    flag = true;
                                }
                                else if (index == 2)
                                {
                                    List<ModelCompany> modelCompanylist = ToList<ModelCompany>(table);
                                    if (modelCompanylist != null)
                                    {
                                        if (modelCompanylist.Count > 0)
                                        {
                                            modelNewLicense.CustomerDetails = modelCompanylist[0];
                                        }
                                        else
                                        {
                                            modelNewLicense.CustomerDetails = new ModelCompany();
                                        }
                                        flag = true;
                                    }
                                }
                                else if (index == 3)
                                {
                                    List<LicenseFile> licenseFile = ToList<LicenseFile>(table);
                                    if (licenseFile != null)
                                    {
                                        if (licenseFile.Count > 0)
                                        {
                                            modelNewLicense.LicenseFile = licenseFile[0];
                                        }
                                        else
                                        {
                                            modelNewLicense.LicenseFile = new LicenseFile();
                                        }
                                        flag = true;
                                    }
                                }
                            }
                            index++;
                        }
                        GenerateLicenseFile(ds.Tables[1], modelNewLicense.UID, modelNewLicense.LicenseStartDate, modelNewLicense.LicenseEndDate,modelNewLicense.LicenseType);
                    }
                }
                if (!flag)
                {
                    modelNewLicense = new ModelNewLicense();
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return modelNewLicense;
        }
        private ModelNewLicense NewLicenseRead()
        {
            try
            {
                if (modelNewLicense != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    modelNewLicense.DbAction = "Read";
                    dBConnections.SendData<ModelNewLicense>(modelNewLicense, "SP_NEW_LICENSE_MANAGEMENT");
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return modelNewLicense;
        }
        public List<T> ToList<T>(DataTable table) where T : new()
        {
            List<T> result = new List<T>();
            try
            {
                IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();

                foreach (var row in table.Rows)
                {
                    var item = CreateItemFromRow<T>((DataRow)row, properties);
                    result.Add(item);
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);

            }
            return result;
        }
        private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
        {
            T item = new T();
            try
            {
                string projectName = Assembly.GetCallingAssembly().GetName().Name;
                //  string prs;

                foreach (var property in properties)
                {
                    if (!row.Table.Columns.Contains(property.Name))
                    {
                        property.SetValue(item, null, null);
                        continue;
                    }
                    if (property.PropertyType == typeof(System.DayOfWeek))
                    {
                        DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), row[property.Name].ToString());
                        property.SetValue(item, day, null);
                    }
                    if (property.GetMethod.ToString().Contains(projectName))
                    {
                        property.SetValue(item, null, null);
                    }
                    else
                    {
                        if (row[property.Name] == DBNull.Value)
                            property.SetValue(item, null, null);
                        // else if()
                        else
                            property.SetValue(item, row[property.Name], null);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);

            }
            return item;
        }
    }
}
