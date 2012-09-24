using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Supply
{
    public class Class1
    {
        #region Connection
        string cs;
        SqlConnection con;
        #endregion

        #region Class1
        public Class1()
        {
            cs = "SERVER=Chelo-PC; DATABASE=Dentista, Inc.; UID=chelo;  INTEGRATED SECURITY=TRUE";
            con = new SqlConnection(cs);
        }

        public void Open()
        {
            con.Open();
        }

        public void Close()
        {
            con.Close();
        }
        #endregion

        #region GetSupply
        public SqlDataReader GetSupply()
        {
            string select = "SELECT * FROM Supply";
            SqlCommand com = new SqlCommand(select, con);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        #endregion

        #region AddSuply
        public void AddSupply(string name)
        {
            string add = "AddSupply '" + name + "'";

            SqlCommand com = new SqlCommand(add, con);
            com.ExecuteNonQuery();
            com.Dispose();
        }
        #endregion

        #region EditSupply
        public void EditSupply(string name, int supplyID)
        {
            string edit = "EditSupply '" + supplyID + "', '" + name + "' ";
            
            SqlCommand com = new SqlCommand(edit, con);
            com.ExecuteNonQuery();
            com.Dispose(); ;
        }
        #endregion

        #region DeleteSupply
        public void DeleteSupply(string supplyID)
        {
            string delete = "DeleteSupply '" + supplyID + "'";

            SqlCommand com = new SqlCommand(delete, con);
            com.ExecuteNonQuery();
            com.Dispose(); ;
        }
        #endregion

        #region SearchSupply
        public SqlDataReader SearchSupply(string searchName)
        {
            string search = "SearchSupply '" + searchName + "'";
            
            SqlCommand com = new SqlCommand(search, con);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        #endregion
    }
}