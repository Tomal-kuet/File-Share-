<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="Header" %>
<link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
<div>
<div class="menu">
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button5" runat="server" Height="38px" style="margin-left: 0px" Text="Home" Width="103px" Font-Bold="true" OnClick="Button5_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="Button1" runat="server" Text="Menu" Width="116px" Font-Bold="true"  Height="41px" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button2" runat="server" Text="My Drive" Width="116px" Height="41px" Font-Bold="true" OnClick="Button2_Click" />&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button3" runat="server" Text="Login" Width="116px" Font-Bold="true"  Height="42px" OnClick="Button3_Click" />&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="Button4" runat="server" Text="Register" Width="116px" Height="41px" Font-Bold="true" OnClick="Button4_Click1"   />
</div>
    <script type="text/javascript">
        function myFunction() {
            var person = confirm("You have to login first")

            if(person ==true)
            {
                window.location = "Login.aspx";
            }
            else
                window.location = "Default.aspx";
        }
</script>
</div>