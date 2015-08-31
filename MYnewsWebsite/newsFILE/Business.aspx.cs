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
                SqlDataAdapter da = new SqlDataAdapter("select * from kk", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // --------------------------------html news body------------------------------------------
                string html = "<table>";
                int j = 30;
                while (j < 36)
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
                        html += "<a href =\"" + dt.Rows[j][1].ToString() + "\">";
                        html += "Read more";
                        html += "</a>";
                        html += "</div>";
                        html += "</th>";
                        j++;
                    }

                    else if (j % 3 == 1)
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
                        html += "</div>";
                        html += "</th>";
                        j++;
                    }

                    else if (j % 3 == 2)
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
                        html += "</div>";
                        html += "</th>";
                        html += "</tr>";
                        j++;
                    }
                }
                html += "</table>";
                business.InnerHtml = html;
                //-----End of the news body----------------------------- 

            }
        }
    }
}