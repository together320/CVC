using CVC.License.Algorithms.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace CVC.License.Algorithms.DBCONNECTIONS
{
    public class DBConnections : IDisposable
    {
        private SqlConnection _connection;
        private string connectionString;
        ErrorManagement errorManagement = new ErrorManagement();
        public DBConnections()
        {
            connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        }

        public DataSet ReceiveData(string data,string SPNAME)
        {
            DataSet Ds = new DataSet();
            try
            {
                // string xmldata = Serialize(data);
                using (_connection = new SqlConnection(connectionString))
                {

                    SqlDataAdapter da;
                    _connection.Open();
                    var cmd = _connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = SPNAME;
                    cmd.CommandTimeout = 10000;
                    if (!string.IsNullOrWhiteSpace(data))
                    {
                        cmd.Parameters.AddWithValue("@ID", data);
                    }
                    using (da = new SqlDataAdapter(cmd))
                    {
                        da.SelectCommand = cmd;
                        da.Fill(Ds);
                        //Da.Dispose();
                    }
                }
            }catch(Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Ds;

        }
        public DataSet ReceiveDataUsingObject(JObject data,string SPNAME)
        {
            DataSet Ds = new DataSet();
            
            try
            {
                using (_connection = new SqlConnection(connectionString))
                {
                    string xmldata = ConvertJObjectToXml(data, "root");
                    SqlDataAdapter da;
                    _connection.Open();
                    var cmd = _connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = SPNAME;
                    cmd.CommandTimeout = 10000;
                    if (!string.IsNullOrWhiteSpace(xmldata))
                    {
                        cmd.Parameters.AddWithValue("@XMLString", xmldata);
                    }
                    using (da = new SqlDataAdapter(cmd))
                    {
                        da.SelectCommand = cmd;
                        da.Fill(Ds);
                        //Da.Dispose();
                    }
                }
            }catch(Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Ds;

        }

        public DataSet SendData<T>(T data,string SPNAME)
        {
            DataSet Ds = new DataSet();
            try
            {
                string xmldata = Serialize<T>(data);
                using (_connection = new SqlConnection(connectionString))
                {

                    SqlDataAdapter da;
                    _connection.Open();
                    var cmd = _connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = SPNAME;
                    cmd.CommandTimeout = 10000;
                    cmd.Parameters.AddWithValue("@XMLSTRING", xmldata);
                    using (da = new SqlDataAdapter(cmd))
                    {
                        da.SelectCommand = cmd;
                        da.Fill(Ds);
                        //Da.Dispose();
                    }
                }
            }catch(Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Ds;
        }
        public string Serialize<T>(T dataToSerialize)
        {
            var stringwriter = new System.IO.StringWriter();
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
            }
            catch(Exception ex)
            {
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return stringwriter.ToString();
        }
        private static string ConvertJObjectToXml(JObject jo, string rootElementName)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                XmlDocument doc = JsonConvert.DeserializeXmlNode(jo.ToString(), rootElementName);
                StringWriter sr = new StringWriter(sb);
                XmlTextWriter xw = new XmlTextWriter(sr);
                xw.Formatting = System.Xml.Formatting.Indented;
                doc.WriteTo(xw);
            }catch(Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return sb.ToString();
        }
        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}