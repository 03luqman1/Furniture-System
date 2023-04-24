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
            <asp:Label ID="orderId" runat="server" height="19px" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Order Number" width="90px"></asp:Label>
            <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; left: 129px; top: 57px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="OrderQuantity" runat="server" height="19px" style="z-index: 1; left: 11px; top: 90px; position: absolute" Text="Total Quanity" width="90px"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 128px; top: 90px; position: absolute; margin-bottom: 16px"></asp:TextBox>
        </div>
</body>
    <p>
        <asp:Label ID="orderDate" runat="server" height="19px" style="z-index: 1; left: 12px; top: 126px; position: absolute" Text="Order Date" width="90px"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 126px; top: 125px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 123px; top: 164px; position: absolute"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="orderConfirm" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Order Confirm"></asp:Label>
    </p>
    <p>
        <asp:Label ID="orderStatus" runat="server" height="19px" style="z-index: 1; left: 12px; top: 210px; position: absolute" Text="Order Status" width="90px"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 116px; top: 211px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 10px; top: 262px; position: absolute; right: 387px" Text="Active" />
    </p>
    <p id="Error">
        [lblError]</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 338px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 60px; top: 339px; position: absolute" Text="Cancel" />
    </p>
</html</form>
