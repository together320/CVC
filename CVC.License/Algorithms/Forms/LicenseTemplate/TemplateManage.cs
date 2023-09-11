using CVC.License.Algorithms.DBCONNECTIONS;
using CVC.License.Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CVC.License.Algorithms.Template
{
    public class TemplateManage
    {
        private ModelTemplate templateModel;
        private DBConnections dBConnections;
        ErrorManagement errorManagement = new ErrorManagement();

        public TemplateManage(ModelTemplate _templateModel)
        {
            templateModel = _templateModel;
        }
        public string Create()
        {
           var Data= templateModelCreate(templateModel);
            return Data.ID.ToString();
        }
        public void Read()
        {
            templateModelRead(templateModel);
        }
        public string Update()
        {
            var Data = templateModelUpdate(templateModel);
            return Data.ID.ToString();
        }
        public string Delete()
        {
            var Data = templateModelDelete(templateModel);
            return Data.ID.ToString();

        }
        private ModelTemplate templateModelCreate(ModelTemplate templateModel)
        {
            bool flag = false;
            try
            {
                if (templateModel != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    templateModel.DbAction = "Create";
                    DataSet ds = dBConnections.SendData<ModelTemplate>(templateModel, "SP_TEMPLATE_MANAGEMENT");
                    if (ds != null)
                    {
                        int index = 0;
                        foreach (DataTable table in ds.Tables)
                        {
                            if (ds.Tables.Count > 0)
                            {
                                if (index == 0)
                                {
                                    List<ModelTemplate> templateModels = ToList<ModelTemplate>(ds.Tables[0]);
                                    if (templateModels != null)
                                    {
                                        if (templateModels.Count > 0)
                                        {
                                            templateModel = templateModels[0];
                                        }
                                        else
                                        {
                                            templateModel = new ModelTemplate();
                                        }
                                        flag = true;
                                    }

                                }
                                else if (index == 1)
                                {
                                    List<ModelLicenseModule> modelLicenseModule = ToList<ModelLicenseModule>(table);
                                    templateModel.ModelLicenseModules = modelLicenseModule;
                                    flag = true;
                                }
                            }
                            index++;
                        }
                    }
                }
                if (!flag)
                {
                    templateModel = new ModelTemplate();
                }
            }catch(Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return templateModel;
        }
        private ModelTemplate templateModelDelete(ModelTemplate templateModel)
        {
            bool flag = false;
            try
            {
                if (templateModel != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    templateModel.DbAction = "Delete";
                    DataSet ds = dBConnections.SendData<ModelTemplate>(templateModel, "SP_TEMPLATE_MANAGEMENT");
                    if (ds != null)
                    {
                        int index = 0;
                        foreach (DataTable table in ds.Tables)
                        {
                            if (ds.Tables.Count > 0)
                            {
                                if (index == 0)
                                {
                                    List<ModelTemplate> templateModels = ToList<ModelTemplate>(ds.Tables[0]);
                                    if (templateModels != null)
                                    {
                                        if (templateModels.Count > 0)
                                        {
                                            templateModel = templateModels[0];
                                        }
                                        else
                                        {
                                            templateModel = new ModelTemplate();
                                        }
                                        flag = true;
                                    }

                                }
                                else if (index == 1)
                                {
                                    List<ModelLicenseModule> modelLicenseModule = ToList<ModelLicenseModule>(table);
                                    templateModel.ModelLicenseModules = modelLicenseModule;
                                    flag = true;
                                }
                            }
                            index++;
                        }
                    }
                }
                if (!flag)
                {
                    templateModel = new ModelTemplate();
                }
            }catch(Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return templateModel;
        }
        private ModelTemplate templateModelUpdate(ModelTemplate templateModel)
        {
            bool flag = false;
            try
            {
                if (templateModel != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    templateModel.DbAction = "Update";
                    DataSet ds = dBConnections.SendData<ModelTemplate>(templateModel, "SP_TEMPLATE_MANAGEMENT");
                    if (ds != null)
                    {
                        int index = 0;
                        foreach (DataTable table in ds.Tables)
                        {
                            if (ds.Tables.Count > 0)
                            {
                                if (index == 0)
                                {
                                    List<ModelTemplate> templateModels = ToList<ModelTemplate>(ds.Tables[0]);
                                    if (templateModels != null)
                                    {
                                        if (templateModels.Count > 0)
                                        {
                                            templateModel = templateModels[0];
                                        }
                                        else
                                        {
                                            templateModel = new ModelTemplate();
                                        }
                                        flag = true;
                                    }

                                }
                                else if (index == 1)
                                {
                                    List<ModelLicenseModule> modelLicenseModule = ToList<ModelLicenseModule>(table);
                                    templateModel.ModelLicenseModules = modelLicenseModule;
                                    flag = true;
                                }
                            }
                            index++;
                        }
                    }
                }
                if (!flag)
                {
                    templateModel = new ModelTemplate();
                }
            }catch(Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return templateModel;
        }
        private ModelTemplate templateModelRead(ModelTemplate templateModel)
        {
            try
            {
                if (templateModel != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    templateModel.DbAction = "Read";
                    dBConnections.SendData<ModelTemplate>(templateModel, "SP_TEMPLATE_MANAGEMENT");
                }
            }catch(Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return templateModel;
        }

        public List<T> ToList<T>(DataTable table) where T : new()
        {
            List<T> result = new List<T>();
            try { 
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
        //private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
        //{
        //    T item = new T();
        //    foreach (var property in properties)
        //    {
        //        if (property.PropertyType == typeof(System.DayOfWeek))
        //        {
        //            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), row[property.Name].ToString());
        //            property.SetValue(item, day, null);
        //        }
        //        if (property.Name == "ModelLicenseModule")
        //        {
        //            property.SetValue(item, null, null);
        //        }
        //        else
        //        {
        //            if (row[property.Name] == DBNull.Value)
        //                property.SetValue(item, null, null);
        //            else
        //                property.SetValue(item, row[property.Name], null);
        //        }
        //    }
        //    return item;
        //}
        private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
        {
            T item = new T();
            try { 
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
