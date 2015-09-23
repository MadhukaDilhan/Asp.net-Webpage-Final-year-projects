using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MYnewsWebsite.newsFILE.Add_Database
{

    public partial class login : System.Web.UI.Page

    {
        SqlConnection con = new SqlConnection("Data Source=DIL;Initial Catalog=finalyear;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            Response.Redirect("../Home.aspx");
        }
    }
}