<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: justify">
            <br />
            Are You Sure You Want To Delete This Record?<br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" height="26px" Width="54px" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" height="26px" width="54px" />
            <br />
        </div>
    </form>
</body>
</html>
