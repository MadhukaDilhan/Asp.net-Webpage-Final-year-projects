<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_News.aspx.cs" Inherits="MYnewsWebsite.newsFILE.Add_Database.Add_News" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add news</title>
    <link href="../../CSS/StyleSheet.css" rel="stylesheet" type="text/css" /> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Add new news</h1>

        <div>
            <table>
                <tr>
                    <th>First Name</th>
                    <th><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></th>
                    
                </tr>

                <tr>
                    <th>Last Name</th>
                    <th><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></th>
                </tr>

                <tr>
                    <th>Email</th>
                    <th><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></th>
                </tr>
                <tr>
                    <th>News Header</th>
                    <th><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></th>
                </tr>
                 <tr>
                    <th>News Body</th>
                    <th> <textarea id="TextArea2" cols="20" rows="2"></textarea></th>
                      
                </tr>
               

            </table>
            
        </div>
    </div>
    </form>
</body>
</html>
