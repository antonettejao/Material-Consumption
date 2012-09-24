using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Material_Consumption
{
    public class BatchofSupplies
    {
        string ConnString;
        SqlConnection sql;

        public BatchofSupplies()
        {
            ConnString = "SERVER=Chelo-PC; DATABASE=Dentista, Inc.; UID=chelo; INTEGRATED SECURITY=TRUE";
            sql = new SqlConnection(ConnString);
        }

        public void Open()
        {
            sql.Open();
        }

        public void Close()
        {
            sql.Close();
        }

        public SqlDataReader GetBatchSupply()
        {
            string select = "SELECT * FROM [Batch of Supplies]";
            SqlCommand command = new SqlCommand(select, sql);
            SqlDataReader daaa = command.ExecuteReader();
            return daaa;
        }

        public SqlDataReader GetSupply()
        {
            string select = "SELECT Name FROM Supply";
            SqlCommand command = new SqlCommand(select, sql);
            SqlDataReader daaa = command.ExecuteReader();
            return daaa;
        }

        public void AddBatchSupply(string SupplyName, int Quantity, DateTime ExpirationDate)
        {
             
            string add = "AddBatchSupply '" + SupplyName + "','" + Quantity + "','" + ExpirationDate + "' ";

            SqlCommand com = new SqlCommand(add, sql);
            com.ExecuteNonQuery();
            com.Dispose();

        }

        public void EditBatchSupply(int BatchID, string SupplyName, int Quantity, DateTime ExpirationDate)
        {
            string edit = "EditBatchSupply '" + BatchID  + "','" + SupplyName + "','" + Quantity + "','" + ExpirationDate + "' ";

            SqlCommand com = new SqlCommand(edit, sql);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        public void DeleteBatchSupply(string BatchID)
        {
            string remove = "DeleteBatchSupply '" + BatchID + "'";
            SqlCommand removed = new SqlCommand(remove, sql);
            removed.ExecuteNonQuery();
        }

        public SqlDataReader SearchBatchSupply(string BatchID)
        {
            string select = "SELECT * FROM [Batch of Supplies] ";
            select += "WHERE BatchID ='" + BatchID + "'";
            SqlCommand com = new SqlCommand(select, sql);
            SqlDataReader da = com.ExecuteReader();

            return da;
        }

    }
}