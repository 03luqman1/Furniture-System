﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 237px; width: 1179px">
            <br />
            <br />
            Are You Sure To Delete This Record?<asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 88px; top: 151px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 142px; top: 151px; position: absolute; width: 49px" Text="No" />
        </div>
    </form>
</body>
</html>
