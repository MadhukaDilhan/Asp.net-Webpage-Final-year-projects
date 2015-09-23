<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MYnewsWebsite.newsFILE.Add_Database.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>lohin</title>
    <link href="../../CSS/StyleSheet.css" rel="stylesheet" type="text/css" /> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Login</h1>

        <div>
            <table>
                <tr>
                    <th>USER NAME</th>
                    <th><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></th>
                    
                </tr>

                <tr>
                    <th>PASSWORD</th>
                    <th><input id="Password1" type="password" /></th>

               </tr>

                <tr>
                    <th><asp:Button ID="Button2" runat="server" Text="Forget Password" /></th>
                    <th><asp:Button ID="Button1" runat="server" Text="Sign  In" OnClick="Button1_Click" /></th>
                </tr>
                
            </table>

            
            
        </div>
    </div>
    </form>
</body>
</html>
