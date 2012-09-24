using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Material_Consumption;
using System.Data;

namespace Dentista__Inc.LogIn
{
    public partial class Log_In : System.Web.UI.Page
    {
        string cs = "SERVER=Chelo-PC; DATABASE=Dentista, Inc.; UID=chelo; INTEGRATED SECURITY=TRUE";
        SqlConnection sql;
        Proj form;
        protected void Page_Load(object sender, EventArgs e)
        {
            sql = new SqlConnection(cs);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            sql.Open();
            form = new Proj();
            string select = "GetLogin '" + eid.Text + "','" + pwd.Text + "'";
            SqlCommand com = new SqlCommand(select, sql);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {

                Response.Redirect("Homepage1.aspx");

            }
            else
            {
                Label5.Visible = true;
            }

            DataTable dt = form.Login(int.Parse(eid.Text), pwd.Text);
            Label5.Visible = true;
            if (dt.Rows.Count != 0)
            {
                Label5.Text = "Login failed";
                Response.Redirect("Homepage2.aspx");
            }
            else
            {
                Label5.Visible = true;
            }

            sql.Close();


        }
    }
}