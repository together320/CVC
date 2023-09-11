using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;

using System.Data;
using System.Data.OleDb;

namespace CVC.MDB
{
    public class InterDBData
    {
        public int DataArrey { get; set; }

        public int WriteRequest { get; set; }

        public int RowID { get; set; }
    }

    public class InterDB
    {
       // private Database db;

        public InterDB()
        {
            //this.db = DatabaseFactory.CreateDatabase();
        }

        public List<InterDBData> GetLocalLabelData(string path)
        {
            OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Jet OLEDB:Database Password=slkfnsdfkn2148sad;");
            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.Connection = oleDbConnection;
            oleDbCommand.CommandText = "select * from interDB";
            oleDbConnection.Open();
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load((IDataReader)oleDbDataReader);
            oleDbConnection.Close();

            List<InterDBData> interDbDataList = new List<InterDBData>();
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
                interDbDataList.Add(new InterDBData()
                {
                    DataArrey = Convert.ToInt32(row["DataArrey"]),
                    WriteRequest = Convert.ToInt32(row["WriteRequest"]),
                    RowID = Convert.ToInt32(row["RowID"])
                });

            return interDbDataList;
        }

        public bool SetLocalLabelData(string path, int QueryType, int rowIdOrCoilId, string Data, int queryTypeRowId)
        {
            try
            {
                OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Jet OLEDB:Database Password=slkfnsdfkn2148sad;");
                OleDbCommand oleDbCommand1 = new OleDbCommand();
                oleDbCommand1.Connection = oleDbConnection;
                oleDbCommand1.CommandText = "update interDB set [WriteRequest] = @ID where [RowID] = " + (queryTypeRowId + 2) + ";";
                oleDbCommand1.Parameters.AddWithValue("@ID", (object)Data);
                oleDbConnection.Open();
                oleDbCommand1.ExecuteNonQuery();
                OleDbCommand oleDbCommand2 = new OleDbCommand();
                oleDbCommand2.Connection = oleDbConnection;
                oleDbCommand2.CommandText = "update interDB set [WriteRequest] = @ParameterNo where [RowID] = " + (queryTypeRowId + 1) + ";";
                oleDbCommand2.Parameters.AddWithValue("@ParameterNo", (object)rowIdOrCoilId);
                oleDbCommand2.ExecuteNonQuery();
                OleDbCommand oleDbCommand3 = new OleDbCommand();
                oleDbCommand3.Connection = oleDbConnection;
                oleDbCommand3.CommandText = "update interDB set [WriteRequest] = @QueryType where [RowID] = " + queryTypeRowId + ";";
                oleDbCommand3.Parameters.AddWithValue("@QueryType", (object)QueryType);
                oleDbCommand3.ExecuteNonQuery();
                oleDbConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable GetMDBDataRowIdWise(string path, int? RowID)
        {
            using (OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Jet OLEDB:Database Password=slkfnsdfkn2148sad;"))
            {
                OleDbCommand oleDbCommand = new OleDbCommand();
                oleDbCommand.Connection = oleDbConnection;
                oleDbCommand.CommandText = "select DataArrey from interDB where RowID=" + RowID + "";
                oleDbConnection.Open();
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load((IDataReader)oleDbDataReader);
                oleDbConnection.Close();

                return dataTable;
            }
        }
    }
}
