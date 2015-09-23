<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MYnewsWebsite.newsFILE.Add_Database.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../CSS/StyleSheet.css" rel="stylesheet" type="text/css" /> 
</head>
<body>
   <form id="form1" runat="server">
    <div>
        <h1>Registation</h1>

        <div>
            <table>
                <tr>
                    <th>Name</th>
                    <th><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></th>
                    
                </tr>

                <tr>
                    <th>User Name</th>
                    <th><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></th>
                </tr>

                <tr>
                    <th>Email</th>
                    <th><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></th>
                </tr>
                
                 <tr>
                    <th>Password</th>
                    <th> <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></th>      
                </tr>
            </table>

            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"  />
            
        </div>
    </div>
    </form>
</body>
</html>
