<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Business.aspx.cs" Inherits="MYnewsWebsite.newsFILE.Business" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ව්‍යාපාරික පුවත්</title>
    <link href="../CSS/StyleSheet.css" rel="stylesheet" type="text/css" /> 

</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <div class="header">
            <h1 class="headlable">ශ්‍රී ලංකා සිංහල පුවත් එකතුව</h1>
            <div class="headlink"><a href ="Home.aspx">මුල් පිටුව</a> |  <a href ="Sport.aspx">ක්‍රිඩා පුවත්</a>  |
                 <a href ="Politics.aspx">දේශපාලන පුවත්</a> |  <a href ="Business.aspx">ව්‍යාපාරික පුවත්</a> |
                 <a href ="DefenceAndLow.aspx">ආරක්ෂක හා නීති පුවත්</a> |  <a href ="ArtAndCulture.aspx">කලා හා සංස්කෘතික පුවත්</a> 
            </div>
        </div>
        <h1>ව්‍යාපාරික පුවත්</h1>
        <div  id="business" runat="server"></div> 
           
    </div>
    </form>
</body>
</html>