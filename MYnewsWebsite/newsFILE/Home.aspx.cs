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

            //get data length ----------------

            SqlCommand cmd = new SqlCommand("select count(*) from kk",con);
            cmd.Connection.Open();
            Div1.InnerHtml = cmd.ExecuteScalar().ToString();
            int aa = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cmd.Connection.Close();
            //Div1.InnerHtml = "a";

            // --------------------------------html news body------------------------------------------
            string html = "<table>";
            int j = 27;
            while (j < aa)
            {

                if (j % 3 == 0)
                {
                    html += "<tr>";
                    html += "<th>";
                    html += "<div class=\"test" + 1 + "\">";
                    html += "<h2 class=\"test" + 2 + "\">";
                    html += dt.Rows[j][0].ToString() + " ";
                    html += "</h2>";
                    html += "<p>";
                    html += dt.Rows[j][2].ToString() + " ";
                    html += "</p>";
                    html += "<a  href =\"" + dt.Rows[j][1].ToString() + "\">";
                    html += "Read more";
                    html += "</a>";
                    html += "<footer><button>Like</button> <button>Comment</button></footer>";
                    html += "</div>";
                    html += "</th>";
                    j++;
                }

                if (j % 3 == 1)
                {
                    html += "<th>";
                    html += "<div class=\"test" + 1 + "\">";
                    html += "<h2 class=\"test" + 2 + "\">";
                    html += dt.Rows[j][0].ToString() + " ";
                    html += "</h2>";
                    html += "<p>";
                    html += dt.Rows[j][2].ToString() + " ";
                    html += "</p>";
                    html += "<a href =\"" + dt.Rows[j][1].ToString() + "\">";
                    html += "Read more";
                    html += "</a>";
                    html += "<footer><button>Like</button> <button>Comment</button></footer>";
                    html += "</div>";
                    html += "</th>";
                    j++;
                }

                if (j % 3 == 2)
                {
                    html += "<th>";
                    html += "<div class=\"test" + 1 + "\">";
                    html += "<h2 class=\"test" + 2 + "\">";
                    html += dt.Rows[j][0].ToString() + " ";
                    html += "</h2>";
                    html += "<p>";
                    html += dt.Rows[j][2].ToString() + " ";
                    html += "</p>";
                    html += "<a href =\"" + dt.Rows[j][1].ToString() + "\">";
                    html += "Read more";
                    html += "</a>";
                    html += "<footer><button id=\"test" + j + "\">Like</button> <button>Comment</button></footer>";
                    html += "</div>";
                    html += "</th>";
                    html += "</tr>";
                    j++;
                }
            }
            html += "</table>";
            news.InnerHtml = html;
            //-----End of the news body----------------------------- 
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_database/Add_News.aspx");
        }

    }

   
}