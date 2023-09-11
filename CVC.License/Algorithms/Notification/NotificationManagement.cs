using CVC.License.Algorithms.DBCONNECTIONS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace CVC.License.Algorithms.Notification
{
    public class NotificationManagement
    {
        int UserID;
        int type;
        private DBConnections dBConnections;
        private ErrorManagement errorManagement;
        public NotificationManagement()
        {
            errorManagement = new ErrorManagement();
        }
        public List<ModelNotification> GetNotificationbyUser(ModelGetNotification modelGetNotification)
        {
            bool Flag = false;
            DataTable dataTable = new DataTable();
            List<ModelNotification> notificationsList = new List<ModelNotification>();
            if (modelGetNotification != null)
            {
                modelGetNotification.DbAction = "GetNotification";
                dataTable = GetNotification(modelGetNotification);
            }
            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    notificationsList = ToList<ModelNotification>(dataTable);
                }
            }
            return notificationsList;
        }
        public bool Expire(ModelNotification modelNotification)
        {
            bool Flag = false;
            if (modelNotification != null)
            {
                modelNotification.DbAction = "Expire";
                Flag = NotificatioManage(modelNotification);
            }
            return Flag;
        }
        public bool Delete(ModelNotification modelNotification)
        {
            bool Flag = false;
            if (modelNotification != null)
            {
                modelNotification.DbAction = "Delete";
                Flag = NotificatioManage(modelNotification);
            }
            return Flag;
        }
        public bool Update(ModelNotification modelNotification)
        {
            bool Flag = false;
            if (modelNotification != null)
            {
                modelNotification.DbAction = "Update";
                Flag = NotificatioManage(modelNotification);
            }
            return Flag;
        }
        public bool Create(ModelNotification modelNotification)
        {
            bool Flag = false;
            if (modelNotification != null)
            {
                modelNotification.DbAction = "Create";
                Flag = NotificatioManage(modelNotification);
            }
            return Flag;
        }
        private bool NotificatioManage(ModelNotification modelNotification)
        {
            bool flag = false;
            try
            {
                if (modelNotification != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    DataSet ds = dBConnections.SendData<ModelNotification>(modelNotification, "[SP_NOTIFICATION_MANAGEMENT]");
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0] != null)
                            {
                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    flag = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Notification Creating Failed", ex);
            }
            return flag;
        }
        private DataTable GetNotification(ModelGetNotification modelGetNotification)
        {
            bool flag = false;
            DataTable dataTable = new DataTable();
            try
            {
                if (modelGetNotification != null)
                {
                    //Need to Validate Object code missing
                    dBConnections = new DBConnections();
                    DataSet ds = dBConnections.SendData<ModelGetNotification>(modelGetNotification, "[SP_NOTIFICATION_GET]");
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0] != null)
                            {
                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    dataTable = ds.Tables[0];
                                    flag = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Get Notification details Failed", ex);
            }
            return dataTable;
        }
        //Todo: Common Functions
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
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Binding to Model, Generic", ex);
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
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Binding to Model for a Row", ex);
            }
            return item;
        }
    }
}
