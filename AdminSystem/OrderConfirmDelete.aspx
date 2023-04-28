<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Are You Sure You Want To Delete This Record?"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 29px; top: 54px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click1" style="z-index: 1; left: 82px; top: 55px; position: absolute; width: 30px" Text="No" />
        </p>
    </form>
</body>
</html>
