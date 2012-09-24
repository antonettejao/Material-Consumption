using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace Material_Consumption
{
    public class Supply1
    {
        string cs;
        SqlConnection con;
    
        public Supply1()
        {
            cs = "SERVER=BAGSS-PC; DATABASE=Dentista, Inc.; UID=sa;  PWD=12345";
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
        
             public SqlDataReader GetSupply()
        {
            string select = "SELECT * FROM Supply";
            SqlCommand com = new SqlCommand(select, con);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
      
        public void AddSupply(string name)
        {
            string add = "AddSupply '" + name + "'";

            SqlCommand com = new SqlCommand(add, con);
            com.ExecuteNonQuery();
            com.Dispose();
        }
   
        public void EditSupply(string name, int supplyID)
        {
            string edit = "EditSupply '" + supplyID + "', '" + name + "' ";
            
            SqlCommand com = new SqlCommand(edit, con);
            com.ExecuteNonQuery();
            com.Dispose(); ;
        }
       
        public void DeleteSupply(string supplyID)
        {
            string delete = "DeleteSupply '" + supplyID + "'";

            SqlCommand com = new SqlCommand(delete, con);
            com.ExecuteNonQuery();
            com.Dispose(); ;
        }
        
        public SqlDataReader SearchSupply(string searchName)
        {
            string search = "SearchSupply '" + searchName + "'";
            
            SqlCommand com = new SqlCommand(search, con);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

    }
}
