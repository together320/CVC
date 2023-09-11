using CVC.License.Algorithms.DBCONNECTIONS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
namespace CVC.License.Algorithms
{
    public class CustomerManage
    {
        private ErrorManagement errorManagement;
        private DBConnections dBConnections;
        public readonly ModelCompany modelCompany;
        public CustomerManage(ModelCompany _company)
        {
            errorManagement = new ErrorManagement();
            modelCompany = _company;
        }

        public ModelCompany Create()
        {
            return CustomerCreate(modelCompany);
        }
        public ModelCompany Read()
        {
            return CustomerRead(modelCompany);
        }
        public ModelCompany Update()
        {
            return CustomerUpdate(modelCompany);
        }
        public ModelCompany Delete()
        {
            return CustomerDelete(modelCompany);
        }
        private ModelCompany CustomerCreate(ModelCompany modelCompany)
        {

            bool flag = false;
            try
            {
                if (modelCompany != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    modelCompany.DbAction = "Create";
                    DataSet ds = dBConnections.SendData<ModelCompany>(modelCompany, "SP_NEW_CUSTOMER_MANAGEMENT");
                    if (ds != null)
                    {
                        int index = 0;
                        foreach (DataTable table in ds.Tables)
                        {
                            if (ds.Tables.Count > 0)
                            {
                                if (index == 0)
                                {
                                    List<ModelCompany> modelCompanylist = ToList<ModelCompany>(ds.Tables[0]);
                                    if (modelCompanylist != null)
                                    {
                                        if (modelCompanylist.Count > 0)
                                        {
                                            modelCompany = modelCompanylist[0];
                                        }
                                        else
                                        {
                                            modelCompany = new ModelCompany();
                                        }
                                        flag = true;
                                    }

                                }
                                //else if (index == 1)
                                //{
                                //    List<ModelAddressType> modelAddressType = ToList<ModelAddressType>(table);
                                //    modelCustomer.ModelAddressType = modelAddressType;
                                //    flag = true;
                                //}
                            }
                            index++;
                        }
                    }
                }
                if (!flag)
                {
                    modelCompany = new ModelCompany();
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return modelCompany;
        }
        private ModelCompany CustomerDelete(ModelCompany modelCompany)
        {
            bool flag = false;
            try
            {
                if (modelCompany != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    modelCompany.DbAction = "Delete";
                    DataSet ds = dBConnections.SendData<ModelCompany>(modelCompany, "SP_NEW_CUSTOMER_MANAGEMENT");
                    if (ds != null)
                    {
                        int index = 0;
                        foreach (DataTable table in ds.Tables)
                        {
                            if (ds.Tables.Count > 0)
                            {
                                if (index == 0)
                                {
                                    List<ModelCompany> modelCompanylist = ToList<ModelCompany>(ds.Tables[0]);
                                    if (modelCompanylist != null)
                                    {
                                        if (modelCompanylist.Count > 0)
                                        {
                                            modelCompany = modelCompanylist[0];
                                        }
                                        else
                                        {
                                            modelCompany = new ModelCompany();
                                        }
                                        flag = true;
                                    }

                                }
                                //else if (index == 1)
                                //{
                                //    List<ModelAddressType> modelAddressType = ToList<ModelAddressType>(table);
                                //    modelCustomer.ModelAddressType = modelAddressType;
                                //    flag = true;
                                //}
                            }
                            index++;
                        }
                    }
                }
                if (!flag)
                {
                    modelCompany = new ModelCompany();
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return modelCompany;
        }
        private ModelCompany CustomerUpdate(ModelCompany modelCompany)
        {
            bool flag = false;
            try
            {
                if (modelCompany != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    modelCompany.DbAction = "Update";
                    DataSet ds = dBConnections.SendData<ModelCompany>(modelCompany, "SP_NEW_CUSTOMER_MANAGEMENT");
                    if (ds != null)
                    {
                        int index = 0;
                        foreach (DataTable table in ds.Tables)
                        {
                            if (ds.Tables.Count > 0)
                            {
                                if (index == 0)
                                {
                                    List<ModelCompany> modelCompanylist = ToList<ModelCompany>(ds.Tables[0]);
                                    if (modelCompanylist != null)
                                    {
                                        if (modelCompanylist.Count > 0)
                                        {
                                            modelCompany = modelCompanylist[0];
                                        }
                                        else
                                        {
                                            modelCompany = new ModelCompany();
                                        }
                                        flag = true;
                                    }

                                }
                                //else if (index == 1)
                                //{
                                //    List<ModelAddressType> modelAddressType = ToList<ModelAddressType>(table);
                                //    modelCustomer.ModelAddressType = modelAddressType;
                                //    flag = true;
                                //}
                            }
                            index++;
                        }
                    }
                }
                if (!flag)
                {
                    modelCompany = new ModelCompany();
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return modelCompany;
        }
        private ModelCompany CustomerRead(ModelCompany modelCompany)
        {
            try
            {
                if (modelCompany != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    modelCompany.DbAction = "Read";
                    dBConnections.SendData<ModelCompany>(modelCompany, "SP_NEW_CUSTOMER_MANAGEMENT");
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return modelCompany;
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
        //        if (property.Name == "LicenseModuleModel")
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
    }
}