using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Material_Consumption.Forms
{
    public partial class Batch : System.Web.UI.Page
    {

        BatchofSupplies sql;

        protected void Page_Load(object sender, EventArgs e)
        {
            sql = new BatchofSupplies();
            sql.Open();

            SqlDataReader drrr = sql.GetBatchSupply();
            GridView1.DataSource = drrr;
            GridView1.DataBind();
            drrr.Close();
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}