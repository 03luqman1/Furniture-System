<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="126px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="height: 29px; width: 48px" Text="Find" />
            &nbsp;&nbsp;
            <asp:Label ID="lblDoesNotExist" runat="server"></asp:Label>
        </p>
        <asp:Label ID="lblName" runat="server" Text="Full Name " width="126px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address " width="126px"></asp:Label>
            <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number " width="126px"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth " width="126px"></asp:Label>
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkVerified" runat="server" Text="Verified" width="123px" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="height: 29px" Text="OK" width="73px" />
            <asp:Button ID="btnCancel" runat="server" height="29px" Text="Cancel" width="73px" OnClick="btnCancel_Click" />
            <asp:Button ID="btnClear" runat="server" height="29px" OnClick="btnClear_Click" Text="Clear" width="73px" />
        </p>
    </form>
</body>
</html>
