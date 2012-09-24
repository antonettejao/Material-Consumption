using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Material_Consumption.Forms
{
    public partial class Supply_Information2 : System.Web.UI.Page
    {
        Supply1 supply;

        protected void Page_Load(object sender, EventArgs e)
        {
            supply = new Supply1();
        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            supply = new Supply1();
            supply.Open();

            supply.AddSupply(Name.Text);

            SqlDataReader dr = supply.GetSupply();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            supply.Close();
        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {
            supply = new Supply1();
            supply.Open();

            supply.EditSupply(Name.Text, int.Parse(sid.Text));

            SqlDataReader dr = supply.GetSupply();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            supply.Close();
        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {
            supply = new Supply1();
            supply.Open();

            supply.DeleteSupply(sid.Text);

            SqlDataReader dr = supply.GetSupply();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            supply.Close();
        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {
            supply = new Supply1();
            supply.Open();

            SqlDataReader dr = supply.GetSupply();

            GridView1.DataSource = dr;
            GridView1.DataBind();
            supply.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            supply = new Supply1();
            supply.Open();

            SqlDataReader dr = supply.SearchSupply(TextBox1.Text);
            GridView1.DataSource = dr;
            GridView1.DataBind();
            supply.Close();
        }
    }
}