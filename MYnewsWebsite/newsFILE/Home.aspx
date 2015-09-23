<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MYnewsWebsite.newsFILE.Home" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ශ්‍රී ලංකා සිංහල පුවත් එකතුව</title>
   <link href="../CSS/StyleSheet.css" rel="stylesheet" type="text/css" />    
</head>
<body>
 
    <form id="form1" runat="server">
        <div class="header">
            <h1 class="headlable">ශ්‍රී ලංකා සිංහල පුවත් එකතුව</h1>
            <div class="headlink"><a href ="#">මුල් පිටුව</a> |  <a href ="Sport.aspx">ක්‍රිඩා පුවත්</a>  |
                    <a href ="Politics.aspx">දේශපාලන පුවත්</a> |  <a href ="Business.aspx">ව්‍යාපාරික පුවත්</a> |
                    <a href ="DefenceAndLow.aspx">ආරක්ෂක හා නීති පුවත්</a> |  <a href ="ArtAndCulture.aspx">කලා හා සංස්කෘතික පුවත්</a>
                
                    <asp:Button ID="addnews" runat="server" Text="පුවත් ඇතුලත් කරන්න" OnClick="Button1_Click" />
                    <input id="search" type="text" placeholder="සොයන්න" />

                      <asp:Button ID="login" runat="server" Text="ඇතුලත්වීම" class="button" OnClick ="Buttonlog_Click"/>
                      <asp:Button ID="signup" runat="server" Text="ලියාපදිංචිය" class="button" OnClick ="Buttonreg_Click"/>
            </div>
         </div>
            <div  id="Div1" runat="server"></div> 
           <div  id="news" runat="server"></div> 
        
    </form>
</body>
</html>


