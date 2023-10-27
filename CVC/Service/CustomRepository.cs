using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using CVC.Models;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Collections;

namespace CVC.Service
{
  public class CustomRepository : IHttpHandler
  {
    /// <summary>
    /// You will need to configure this handler in the Web.config file of your 
    /// web and register it with IIS before being able to use it. For more information
    /// see the following link: https://go.microsoft.com/?linkid=8101007
    /// </summary>
    #region IHttpHandler Members

    string connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

    public string md5_string(string password)
    {
      string md5_password = string.Empty;
      using (MD5 hash = MD5.Create())
      {
        md5_password = string.Join("", hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("x2")));
      }

      return md5_password;
    }

    /// getAllData with tblName
    public async Task<ResponseModel<string>> GetAllData(string tblName)
    {
      ResponseModel<string> response = new ResponseModel<string>();

      try
      {
        using (SqlConnection conn = new SqlConnection(connectionstring))
        {
          SqlCommand cmd = new SqlCommand();
          string str = string.Format("Select * FROM {0}", tblName);
          cmd.CommandText = str;
          cmd.Connection = conn;

          SqlDataAdapter da = new SqlDataAdapter(cmd);
          DataTable dt = new DataTable();
          await Task.Run(() => da.Fill(dt));

          response.Data = JsonConvert.SerializeObject(dt);
          response.resultCode = dt.Rows.Count > 0 ? 200 : 200; // 204 for No Content
        }
      }
      catch (SqlException ex) // SQL Server returned an error
      {
        response.message = "Error accessing the database: " + ex.Message;
        response.resultCode = 500;
      }
      catch (Exception ex) // Other general error
      {
        response.message = "Unexpected error: " + ex.Message;
        response.resultCode = 500;
      }
      return response;
    }
    /// </getAllData>
    /// 

    public async Task<ResponseModel<string>> GetSomeRowsById(string tblName, int id, string idName)
    {
      ResponseModel<string> response = new ResponseModel<string>();

      try
      {
        using (SqlConnection conn = new SqlConnection(connectionstring))
        {
          SqlCommand cmd = new SqlCommand();
          string str = string.Format("Select * FROM {0} WHERE {1}={2}", tblName, idName, id);
          cmd.CommandText = str;
          cmd.Connection = conn;

          SqlDataAdapter da = new SqlDataAdapter(cmd);
          DataTable dt = new DataTable();
          await Task.Run(() => da.Fill(dt));

          response.Data = JsonConvert.SerializeObject(dt);
          response.resultCode = dt.Rows.Count > 0 ? 200 : 200; // 204 for No Content
        }
      }
      catch (SqlException ex) // SQL Server returned an error
      {
        response.message = "Error accessing the database: " + ex.Message;
        response.resultCode = 500;
      }
      catch (Exception ex) // Other general error
      {
        response.message = "Unexpected error: " + ex.Message;
        response.resultCode = 500;
      }
      return response;
    }

    public async Task<ResponseModel<string>> GetAllDataTypes(string tblName)
    {
      ResponseModel<string> response = new ResponseModel<string>();
      try
      {
        using (SqlConnection conn = new SqlConnection(connectionstring))
        {
          SqlCommand cmd = new SqlCommand();
          string query = "USE CVCUXDEV;" +
                       "SELECT t.name AS DataType, c.name AS ColumnName " +
                       "FROM sys.columns c " +
                       "JOIN sys.types t ON c.user_type_id = t.user_type_id " +
                       "WHERE c.object_id = OBJECT_ID('{0}');";
          string str = string.Format(query, tblName);
          cmd.CommandText = str;
          cmd.Connection = conn;

          SqlDataAdapter da = new SqlDataAdapter(cmd);
          DataTable dt = new DataTable();
          await Task.Run(() => da.Fill(dt));

          response.Data = JsonConvert.SerializeObject(dt);
          response.resultCode = dt.Rows.Count > 0 ? 200 : 204; // 204 for No Content
        }
      }
      catch (SqlException ex) // SQL Server returned an error
      {
        response.message = "Error accessing the database: " + ex.Message;
        response.resultCode = 500;
      }
      catch (Exception ex) // Other general error
      {
        response.message = "Unexpected error: " + ex.Message;
        response.resultCode = 500;
      }
      return response;
    }



    /////////////////Manage FieldFilter Database//////////////////////


    public bool IsReusable
    {
      // Return false in case your Managed Handler cannot be reused for another request.
      // Usually this would be false in case you have some state information preserved per request.
      get { return true; }
    }

    public void ProcessRequest(HttpContext context)
    {
      //write your handler implementation here.
    }
    #endregion
  }
}
