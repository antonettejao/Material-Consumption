using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Material_Consumption
{
    public class Proj
    {
        SqlConnection con = new SqlConnection("SERVER=Chelo-PC; DATABASE=Dentista, Inc.; UID=chelo; INTEGRATED SECURITY=TRUE");

        public void Open()
        {
            con.Open();
        }

        public void Close()
        {
            con.Close();
        }

        public DataTable Login(int EID, string Password)
        {
            string select = "GetLogin " + EID + ", " + Password;
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getSupply()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Name from Supply", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

       
    }
}