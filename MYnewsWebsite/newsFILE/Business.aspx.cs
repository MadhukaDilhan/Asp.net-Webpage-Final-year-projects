using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MYnewsWebsite.newsFILE
{


    public partial class Business : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DIL;Initial Catalog=finalyear;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from ARTICALS where Category_ID='4'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Label1.Text = dt.Rows[0][0].ToString();
                Label2.Text = dt.Rows[0][2].ToString();

                Label3.Text = dt.Rows[1][0].ToString();
                Label4.Text = dt.Rows[1][2].ToString();

                Label5.Text = dt.Rows[2][0].ToString();
                Label6.Text = dt.Rows[2][2].ToString();

                Label7.Text = dt.Rows[3][0].ToString();
                Label8.Text = dt.Rows[3][2].ToString();




            }
        }
    }
}