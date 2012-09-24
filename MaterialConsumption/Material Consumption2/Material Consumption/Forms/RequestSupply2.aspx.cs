using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Material_Consumption.Forms
{
    public partial class RequestSupply2 : System.Web.UI.Page
    {
        Request2 sql;

        protected void Page_Load(object sender, EventArgs e)
        {
            sql = new Request2();
            sql.Open();


            if (!IsPostBack)
            {
                SqlDataReader drrr = sql.GetRequestSupplies();
                GridView1.DataSource = drrr;
                GridView1.DataBind();
                drrr.Close();


                SqlDataReader dr1 = sql.GetSupply();

                ddl1.DataSource = dr1;
                ddl1.DataTextField = "Name";
                ddl1.DataValueField = "Name";
                ddl1.DataBind();
                dr1.Close();

                lbld.Text = DateTime.Now.ToShortDateString();
            }
        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            
            //sql = new Request2();
            sql.Open();

            validation v1 = new validation();

            v1.Quantity = int.Parse(qty.Text);


            sql.AddRequestSupplies(ddl1.SelectedValue, int.Parse(qty.Text), DateTime.Parse(date.Text));

            SqlDataReader daa = sql.GetRequestSupplies();
            GridView1.DataSource = daa;
            GridView1.DataBind();
            sql.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //sql = new Request2();
            sql.Open();

            validation v1 = new validation();

            v1.Quantity = int.Parse(qty.Text);

            sql.EditRequestSupplies(int.Parse(oid.Text), ddl1.SelectedValue, int.Parse(qty.Text), DateTime.Parse(date.Text), ddlp.SelectedValue);

            SqlDataReader daa = sql.GetRequestSupplies();
            GridView1.DataSource = daa;
            GridView1.DataBind();
            sql.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //sql = new Request2();
            sql.Open();

            sql.DeleteRequestSupplies(GridView1.SelectedRow.Cells[1].Text);

            SqlDataReader daa = sql.GetRequestSupplies();
            GridView1.DataSource = daa;
            GridView1.DataBind();
            sql.Close();
        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            oid.Text = GridView1.SelectedRow.Cells[1].Text;
            ddl1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
            qty.Text = GridView1.SelectedRow.Cells[3].Text;
            date.Text = GridView1.SelectedRow.Cells[4].Text;
        }

        //protected void Button3_Click(object sender, EventArgs e)
        //{
        //    sql = new Request2();
        //    sql.Open();

        //    SqlDataReader da = sql.SearchRequestSupplies(oid.Text);
        //    GridView1.DataSource = da;
        //    GridView1.DataBind();
        //    sql.Close();
        //}
    }
}