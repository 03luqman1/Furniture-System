<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerNo" runat="server" Text="Customer Number "></asp:Label>
            <asp:TextBox ID="txtCustomerNo" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblName" runat="server" Text="Full Name " width="117px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address " width="117px"></asp:Label>
            <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number " width="117px"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth " width="117px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkVerified" runat="server" Text="Verified" width="123px" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="height: 29px" Text="OK" width="73px" />
            <asp:Button ID="btnCancel" runat="server" height="29px" Text="Cancel" width="73px" />
        </p>
    </form>
</body>
</html>
