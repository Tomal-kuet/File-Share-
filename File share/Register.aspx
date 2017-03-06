<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>
<%@ Register Src="~/Header.ascx" TagName="header" TagPrefix="T_header" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body background="images.jpg">
    <form id="form1" runat="server">
    <div>
        <div>
    <T_header:header ID="header1" runat="server" />
    </div>
        <div>

            <h1 style="color:black;position:absolute;margin-left:400px;">Create Your Account</h1>
            </br>
            <asp:Label ID="Name" Text="First Name : " runat="server" ForeColor="black" CssClass="name"></asp:Label>
            <asp:TextBox ID="textbox1" placeholder="First Name" runat="server" CssClass="namebox"></asp:TextBox>
            <br />
            <br />
            <asp:RequiredFieldValidator ID="text1" CssClass="rtext1" ControlToValidate="textbox1" 
                 runat="server" ErrorMessage="Error:The textbox can't be blank !" 
                ForeColor="black" EnableClientScript="false"></asp:RequiredFieldValidator>
           
           <br />
           <br />
            <asp:Label ID="last_name"  Text="Last Name : " runat="server" ForeColor="black" CssClass="lastname"></asp:Label>
            <asp:TextBox ID="textbox2" placeholder="Last Name" runat="server" CssClass="lastnamebox"></asp:TextBox>
            <br /> <br />
            <asp:RequiredFieldValidator ID="text2" CssClass="rtext2" ControlToValidate="textbox2" 
                runat="server" ErrorMessage="Error:The textbox can't be blank !" ForeColor="Black"
                 EnableClientScript="false"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Phone" Text="Phone No    : " runat="server" ForeColor="black" CssClass="phone"></asp:Label>
            <asp:TextBox ID="textbox3" placeholder="Phone No" runat="server" CssClass="phonebox"></asp:TextBox>
            <br />
      
            <asp:RequiredFieldValidator ID="text3" CssClass="rtext3" ControlToValidate="textbox3" 
                runat="server" ErrorMessage="Error:The textbox can't be blank !" ForeColor="black" 
                EnableClientScript="false"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="email" Text="Email  :  " runat="server" ForeColor="black" CssClass="emails"></asp:Label>
            <asp:TextBox ID="textbox4" placeholder="you@gmail.com" runat="server" CssClass="emailbox"></asp:TextBox>
            <br />
             <asp:RegularExpressionValidator
        id="regEmail"
        ControlToValidate="textbox4" ErrorMessage="Error:Invalid email"
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Runat="server" EnableClientScript="false" CssClass="rtext4" ForeColor="Red" ></asp:RegularExpressionValidator>
            
             <asp:RequiredFieldValidator ID="text4" CssClass="rtext4" ControlToValidate="textbox4" 
                runat="server" ErrorMessage="Error:The textbox can't be blank !" ForeColor="black"
                  EnableClientScript="false"></asp:RequiredFieldValidator>
            
            <br />
            <br />
            <asp:Label ID="password" Text="Password :" runat="server" ForeColor="black" CssClass="pass"></asp:Label>
            <asp:TextBox ID="textbox5" placeholder="**********" TextMode="Password" 
                runat="server" CssClass="passbox"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="text5" CssClass="rtext5" ControlToValidate="textbox5" 
                runat="server" ErrorMessage="Error:The textbox can't be blank !" ForeColor="black"
                 EnableClientScript="false"></asp:RequiredFieldValidator>

            <br />
            <br />
            <asp:Label ID="confirmpass" Text="Confirm Password :" runat="server" ForeColor="black"
                 CssClass="conpass"></asp:Label>
            <asp:TextBox ID="textbox6" placeholder="**********" TextMode="Password" 
                runat="server" CssClass="conpassbox"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="text6" CssClass="rtext6" ControlToValidate="textbox6" 
                runat="server" ErrorMessage="Error:The textbox can't be blank !" 
                ForeColor="black" EnableClientScript="false"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" ID="confirmpassword" CssClass="rtext6" 
                ControlToCompare="textbox5" ControlToValidate="textbox6" EnableClientScript="false" 
                ForeColor="black" ErrorMessage="Error:your password do not match up"></asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="submit" Text="SUBMIT" OnClick="submit_Click" runat="server" CssClass="submit_button" />
            <asp:Button ID="reset" Text="RESET" OnClick="reset_Click" runat="server" CssClass="reset_button" />
             </div>
    </div>
    </form>
</body>
</html>
