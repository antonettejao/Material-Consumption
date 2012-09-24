using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Material_Consumption
{
    public partial class Register2 : System.Web.UI.Page
    {
        Register reg;

        protected void Page_Load(object sender, EventArgs e)
        {
            reg = new Register();
            reg.Open();

            if (!IsPostBack)
            {
                SqlDataReader dr = reg.GetEmployee();
                dr.Close();


                SqlDataReader dr1 = reg.GetEmployee();
                pstn.DataSource = dr1;
                pstn.DataTextField = "Position";
                pstn.DataValueField = "Position";
                pstn.DataBind();
                dr1.Close();
            }
            reg.Close();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //reg = new Register();

            reg.Open();

            validation v1 = new validation();

            v1.LN = ln.Text;
            v1.FN = fn.Text;
            v1.MN = mn.Text;
            v1.PWD = pwd.Text;
            v1.EID = int.Parse(eid.Text);
            v1.Add = address.Text;
            v1.CNO = int.Parse(cno.Text);
            v1.TNO = int.Parse(telno.Text);
            v1.EAD = eadd.Text;



            reg.AddEmployee(int.Parse(eid.Text), pwd.Text, ln.Text, fn.Text, mn.Text, address.Text, cno.Text, telno.Text, pstn.SelectedValue, eadd.Text);

            

            
            SqlDataReader dr = reg.GetEmployee();

            reg.Close();
        }

       
    }
}