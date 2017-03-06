<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Default2" %>
<link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
        <asp:Label ID="label" Text="Select file to upload: " runat="server"></asp:Label>
    </div> 
<asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Label ID="label1"  runat="server"></asp:Label>
<asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
<hr />
<asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
    AutoGenerateColumns="false" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="File Name"/>
        <asp:TemplateField ItemStyle-HorizontalAlign = "Center">
            <ItemTemplate>
                <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" OnClick="lnkDownload_Click"
                    CommandArgument='<%# Eval("Id") %>'></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>

    <!--   <div id="blanket" style="display:none"></div>
<div id="popUpDiv" style="display:none">

<a href="#" onclick="popup('popUpDiv')" >Click to Close CSS Pop Up</a>
</div>
<a href="#" onclick="popup('popUpDiv')">Click to Open CSS Pop Up</a> -->
    </form>
</body>
</html>
