<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sqldataconectivity.aspx.cs" Inherits="WebApplication4.sqldataconectivity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Position Id:
            <asp:TextBox ID="txtpid" runat="server"></asp:TextBox>
            Position Name:
            <asp:TextBox ID="txtpname" runat="server"></asp:TextBox>
            
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </div>
        <p>
            
            <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="count" />
        </p>
    </form>
</body>
</html>
