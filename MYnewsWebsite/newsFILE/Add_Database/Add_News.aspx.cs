﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MYnewsWebsite.newsFILE.Add_Database
{
    public partial class Add_News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String First_Name =  TextBox1.Text;
            String Last_Name  =  TextBox2.Text;
            String Email      =  TextBox3.Text;

            Response.Redirect("../Home.aspx");
           

        }
    }
}