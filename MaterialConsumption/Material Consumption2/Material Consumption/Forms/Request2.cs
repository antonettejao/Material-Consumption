using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Material_Consumption.Forms
{
    public class Request2
    {
        string cs;
        SqlConnection sql;

        public Request2()
        {
            cs = "SERVER=BAGSS-PC; DATABASE=Dentista, Inc.; UID=sa; Password=12345";
            sql = new SqlConnection(cs);
        }

        public void Open()
        {
            sql.Open();
        }

        public void Close()
        {
            sql.Close();
        }

        public SqlDataReader GetRequestSupplies()
        {
            string select = "SELECT * FROM [Request of Supplies]";
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

        public void AddRequestSupplies(string SupplyName, int Quantity, DateTime Date)
        {

            string add = "AddRequestSupplies '" + SupplyName + "','" + Quantity + "','" + Date + "' ";

            SqlCommand com = new SqlCommand(add, sql);
            com.ExecuteNonQuery();
            com.Dispose();

        }

        public void EditRequestSupplies(int OID, string SupplyName, int Quantity, DateTime Date, string Remarks)
        {
            string edit = "EditRequestSupplies '" + OID + "','" + SupplyName + "','" + Quantity + "','" + Date + "','" + Remarks + "' ";

            SqlCommand com = new SqlCommand(edit, sql);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        public void DeleteRequestSupplies(string OID)
        {
            string remove = "DeleteRequestSupplies '" + OID + "'";
            SqlCommand removed = new SqlCommand(remove, sql);
            removed.ExecuteNonQuery();
        }

        public SqlDataReader SearchRequestSupplies(string OID)
        {
            string select = "SELECT * FROM [Request of Supplies] ";
            select += "WHERE OID ='" + OID + "'";
            SqlCommand com = new SqlCommand(select, sql);
            SqlDataReader da = com.ExecuteReader();

            return da;
        }
    }
}