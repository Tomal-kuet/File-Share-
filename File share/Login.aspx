<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<%@ Register Src="~/Header.ascx" TagName="header" TagPrefix="T_header" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css/">
</head>
<body background="images.jpg">
    <form id="form1" runat="server">
    <div>
            <div>
    <T_header:header ID="header1" runat="server" />
    </div>
                  <div >
             <h1 style="color:black;position:absolute;margin-left:500px;">Login</h1>
            <br/>
              <br/>
            <asp:Label ID="Name" Text="User Name : " runat="server" ForeColor="black" CssClass="name"></asp:Label>
            <asp:TextBox ID="textbox1" runat="server" CssClass="namebox"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="text1" CssClass="namee" ControlToValidate="textbox1" 
                 runat="server" ErrorMessage="User name is Empty !" Font-Bold="true" 
                ForeColor="black" EnableClientScript="false"></asp:RequiredFieldValidator>   
           <br />
          
                        <asp:Label ID="password" Text="Password :" runat="server" ForeColor="black" CssClass="pass"></asp:Label>
            <asp:TextBox ID="textbox5"  TextMode="Password" 
                runat="server" CssClass="passbox"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="text5" CssClass="passs" ControlToValidate="textbox5" 
                runat="server" ErrorMessage="Password is Empty !" ForeColor="black" Font-Bold="true"
                 EnableClientScript="false"></asp:RequiredFieldValidator>
            <br />
            <br /> <br/>
          </div> 
        <div>
            <asp:CheckBox ID="check" runat="server" Text="Remember me" OnCheckedChanged="check_CheckedChanged" CssClass="remember" />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Login" CssClass="submit_button" OnClick="Button1_Click" />         
    </div>
    </form>
</body>
</html>
