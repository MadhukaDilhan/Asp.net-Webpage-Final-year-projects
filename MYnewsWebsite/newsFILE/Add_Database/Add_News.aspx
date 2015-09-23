﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_News.aspx.cs" Inherits="MYnewsWebsite.newsFILE.Add_Database.Add_News" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add news</title>
    <link href="../../CSS/StyleSheet.css" rel="stylesheet" type="text/css" /> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>පුවත් ඇතුලත් කරන්න</h1>

        <div>
            <table>
                <tr>
                    <th>මුල් නම</th>
                    <th><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></th>
                    
                </tr>

                <tr>
                    <th>අවසන් නම</th>
                    <th><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></th>
                </tr>

                <tr>
                    <th>ඊමේල්</th>
                    <th><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></th>
                </tr>
                
                 <tr>
                    <th>පුවත</th>
                    <th> <textarea id="TextArea1" cols="30" rows="30" runat="server"></textarea></th>      
                </tr>
            </table>

            <asp:Button ID="Button1" runat="server" Text="ඇතුලත් කරන්න" OnClick="Button1_Click" />
            
        </div>
    </div>
    </form>
</body>
</html>
