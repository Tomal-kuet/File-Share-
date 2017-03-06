<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Src="~/Header.ascx" TagName="header" TagPrefix="T_header" %>
<%@ Reference Control="~/Menu_header.ascx"  %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    </title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
</head>
<body background="images.jpg">
    <form id="form1" runat="server">
    <div>
        <div>
    <T_header:header ID="header1" runat="server" />
    </div> <br />
        <div>
            &nbsp;</div>
            <img src="img.png" runat="server" class="img" /></div>
    </form>
    </body>
</html>