<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    order data entry page!
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="orderId" runat="server" height="19px" style="z-index: 1; left: 14px; top: 58px; position: absolute; bottom: 468px;" Text="Order Id" width="90px"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 130px; top: 57px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="OrderName" runat="server" height="19px" style="z-index: 1; left: 12px; top: 95px; position: absolute" Text="Order Name" width="90px"></asp:Label>
            <asp:TextBox ID="txtOrderName" runat="server" style="z-index: 1; left: 129px; top: 95px; position: absolute; margin-bottom: 16px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 278px; top: 55px; position: absolute" Text="Find" />
        </div>
</body>
    <p>
        <asp:Label ID="OrderDate" runat="server" height="19px" style="z-index: 1; left: 16px; top: 130px; position: absolute" Text="Order Date" width="90px"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 131px; top: 131px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderQuantity" runat="server" style="z-index: 1; left: 129px; top: 165px; position: absolute"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="OrderQuantity" runat="server" style="z-index: 1; left: 14px; top: 163px; position: absolute; height: 31px; width: 109px;" Text="Order Quantity"></asp:Label>
        <asp:Label ID="OrderCost" runat="server" style="z-index: 1; left: 14px; top: 196px; position: absolute" Text="Order Cost" height="19px" width="90px"></asp:Label>
        <asp:TextBox ID="txtOrderCost" runat="server" style="z-index: 1; left: 131px; top: 196px; position: absolute"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:CheckBox ID="chkOrderConfirm" runat="server" style="z-index: 1; left: 14px; top: 233px; position: absolute; right: 383px" Text="Confirm" />
    </p>
    <p id="lblError">
        [lblError]</p>
    <p>
        <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 137px; top: 340px; position: absolute" Text="Clear" />
    </p>
    <p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 338px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 60px; top: 339px; position: absolute" Text="Cancel" />
    </p>
</html</form>
