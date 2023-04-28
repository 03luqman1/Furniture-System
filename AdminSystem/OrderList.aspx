<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 12px; top: 303px; position: absolute" Text="Add" />
        <p>
            <asp:Label ID="lstOrderList" runat="server" Height="291px" style="z-index: 1; left: 13px; top: 24px; position: absolute; height: 270px; width: 184px" Text="Unbound" Width="230px"></asp:Label>
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="Button1_Click1" style="z-index: 1; left: 57px; top: 303px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 107px; top: 304px; position: absolute" Text="Delete" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 12px; top: 346px; position: absolute" Text="Enter Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 106px; top: 349px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 13px; top: 380px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 74px; top: 381px; position: absolute" Text="Clear" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 420px; position: absolute; height: 23px; width: 50px"></asp:Label>
    </form>
</body>
</html>
