<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 503px;
            width: 1245px;
            margin-right: 0px;
        }
    </style>
</head>
<body style="height: 496px; width: 1277px">
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" />
        </div>
        <asp:Label ID="lblEmployeeId" runat="server" style="z-index: 1; left: 10px; top: 22px; position: absolute" Text="Employee ID"></asp:Label>
        <p>
            <asp:TextBox ID="txtEmployeeId" runat="server" style="z-index: 1; left: 274px; top: 18px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmployeeName" runat="server" style="z-index: 1; left: 7px; top: 74px; position: absolute" Text="Employee Name"></asp:Label>
        <p>
            <asp:TextBox ID="txtEmployeeName" runat="server" style="z-index: 1; left: 273px; top: 76px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmployeeDOB" runat="server" style="z-index: 1; left: 9px; top: 122px; position: absolute" Text="Employee DOB"></asp:Label>
        <asp:TextBox ID="txtEmployeeDOB" runat="server" style="z-index: 1; left: 274px; top: 120px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmployeeEmail" runat="server" style="z-index: 1; left: 12px; top: 172px; position: absolute; right: 989px" Text="Employee Email"></asp:Label>
        <asp:TextBox ID="txtEmployeeEmail" runat="server" style="z-index: 1; left: 275px; top: 173px; position: absolute"></asp:TextBox>
        <p style="height: 336px; width: 1254px">
            <asp:Label ID="lblEmployeePhone" runat="server" style="z-index: 1; left: 8px; top: 232px; position: absolute; right: 1013px" Text="Employee Phone No"></asp:Label>
        </p>
        <asp:TextBox ID="txtEmployeePhoneNo" runat="server" style="z-index: 1; left: 276px; top: 234px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="ChkEmployeeVerfication" runat="server" style="z-index: 1; left: 4px; top: 305px; position: absolute" Text="Employee Verfication" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 342px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 31px; top: 412px; position: absolute; width: 55px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 123px; top: 412px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
