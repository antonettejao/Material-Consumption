using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace Material_Consumption
{
    public class Request
    {
        SqlConnection sqlcon;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;
        string connect = WebConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public GridView getOrder(GridView gv)
        {
            string select = "Select * From [Request of Supplies]";
            adapter = new SqlDataAdapter(select, connect);
            dt = new DataTable();
            adapter.Fill(dt);
            gv.DataSource = dt;
            gv.DataBind();

            return gv;
        }

        public void insertToRequestDetail(int supplyID, int quantity, int employeeID, DateTime date, string remark)
        {
            sqlcon = new SqlConnection(connect);
            sqlcon.Open();
            string insert = "INSERT INTO [Request of Supplies] VALUES ('"+supplyID+"','"+quantity+"','"+employeeID+"','"+date+"','"+remark+"') ";
            command = new SqlCommand();
        }

        public DropDownList getSupply(DropDownList ddl)
        {
            string select = "Select * From Supply";
            adapter = new SqlDataAdapter(select, connect);
            dt = new DataTable();
            adapter.Fill(dt);
            ddl.DataSource = dt;
            ddl.DataTextField = "Name";
            ddl.DataValueField = "SupplyID";
            ddl.DataBind();

            return ddl;
        }

        //public GridView
    }
}