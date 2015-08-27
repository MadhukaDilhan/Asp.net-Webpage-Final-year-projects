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
     

    public partial class Home : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DIL;Initial Catalog=finalyear;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Get_Data_From_Database();
                
            }
        }

        private void Get_Data_From_Database()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select * from kk", con);
            DataTable dt = new DataTable();
            da.Fill(dt);


            // --------------------------------html news body------------------------------------------
            string html = "";
            int i = 25;
            while (i<45)
            {
                html += "<div class=\"test" + 1 + "\">";
                html += "<h2>";
                html += dt.Rows[i][0].ToString() +" ";
                html += "</h2>";
                html += "<p>";
                html += dt.Rows[i][2].ToString() + " ";
                html += "</p>";
                html += "</div>";
                i++;
            }
            news.InnerHtml = html;
           //-----End of the news body----------------------------- 
            
        }

    }

   
}