using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Material_Consumption.Forms
{
    public partial class Batch2 : System.Web.UI.Page
    {
        BatchofSupplies sql;

        protected void Page_Load(object sender, EventArgs e)
        {
            sql = new BatchofSupplies();
            sql.Open();

            if (!IsPostBack)
            {
                SqlDataReader drrr = sql.GetBatchSupply();
                Grid1.DataSource = drrr;
                Grid1.DataBind();
                drrr.Close();


                SqlDataReader dr1 = sql.GetSupply();

                ddlbs.DataSource = dr1;
                ddlbs.DataTextField = "Name";
                ddlbs.DataValueField = "Name";
                ddlbs.DataBind();
                dr1.Close();


                exdate.Text = DateTime.Now.ToShortDateString();

            }
        }

       

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            //sql = new BatchofSupplies();
            sql.Open();

            //sql.AddBatchSupply(ddlbs.SelectedValue, int.Parse(qty.Text), DateTime.Parse(exdate.Text));


            validation v1 = new validation();

            v1.Quantity = int.Parse(qty.Text);
            v1.Date = DateTime.Parse(exdate.Text);

            sql.AddBatchSupply(ddlbs.SelectedValue, int.Parse(qty.Text), DateTime.Parse(exdate.Text));

            SqlDataReader daa = sql.GetBatchSupply();
            Grid1.DataSource = daa;
            Grid1.DataBind();
            sql.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //sql = new BatchofSupplies();
            sql.Open();


            validation v1 = new validation();

            v1.Quantity = int.Parse(qty.Text);
            v1.Date = DateTime.Parse(exdate.Text);


            sql.EditBatchSupply(int.Parse(Grid1.SelectedRow.Cells[1].Text), ddlbs.SelectedValue, int.Parse(qty.Text), DateTime.Parse(exdate.Text));

            SqlDataReader daa = sql.GetBatchSupply();
            Grid1.DataSource = daa;
            Grid1.DataBind();
            sql.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bid.Text = Grid1.SelectedRow.Cells[1].Text;
            ddlbs.SelectedValue = Grid1.SelectedRow.Cells[2].Text;
            qty.Text = Grid1.SelectedRow.Cells[4].Text;
            exdate.Text = Grid1.SelectedRow.Cells[3].Text;
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //sql = new BatchofSupplies();
            sql.Open();

            sql.DeleteBatchSupply(Grid1.SelectedRow.Cells[1].Text);

            SqlDataReader daa = sql.GetBatchSupply();
            Grid1.DataSource = daa;
            Grid1.DataBind();
            sql.Close();
        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {
            SqlDataReader drrr = sql.GetBatchSupply();
            Grid1.DataSource = drrr;
            Grid1.DataBind();
            drrr.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //sql = new BatchofSupplies();
            //sql.Open();

            //SqlDataReader da = sql.SearchBatchSupply(bid.Text);
            //Grid1.DataSource = da;
            //Grid1.DataBind();
            //sql.Close();
        }
    }
}