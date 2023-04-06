<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 484px;
            width: 1276px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 5px; width: 740px">
            <asp:AdRotator ID="AdRotator1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; right: 1279px" />
            <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 231px; top: 35px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 23px; top: 38px; position: absolute" Text="Supplier ID"></asp:Label>
            <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 24px; top: 99px; position: absolute" Text="SupplierName"></asp:Label>
            <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 230px; top: 95px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblSupplierIteam" runat="server" style="z-index: 1; left: 25px; top: 155px; position: absolute; right: 1277px" Text="Supplier Iteam"></asp:Label>
            <asp:TextBox ID="txtSupplierIteam" runat="server" style="z-index: 1; left: 232px; top: 160px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblEstimateDelivery" runat="server" style="z-index: 1; left: 28px; top: 223px; position: absolute; right: 1102px" Text="Estimate Delivery"></asp:Label>
            <asp:TextBox ID="txtEstimateDelivery" runat="server" style="z-index: 1; left: 234px; top: 222px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkSupplierIteamStatus" runat="server" style="z-index: 1; left: 26px; top: 308px; position: absolute; margin-bottom: 0px" Text="Supplier Iteam Status" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 34px; top: 374px; position: absolute"></asp:Label>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 19px; top: 426px; position: absolute; height: 43px; width: 69px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 89px; top: 426px; position: absolute; height: 43px; width: 93px" Text="Cancel" />
        </div>
    </form>
</body>
</html>
