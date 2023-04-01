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
<body style="height: 502px; width: 1254px">
    <form id="form1" runat="server">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 21px; top: 427px; position: absolute; width: 77px" Text="OK" />
        <asp:Label ID="lblEmployeeId" runat="server" style="z-index: 1; left: 26px; top: 26px; position: absolute" Text="Employee ID"></asp:Label>
        <asp:TextBox ID="TxtEmployeeID" runat="server" style="z-index: 1; left: 312px; top: 26px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmployeeName" runat="server" style="z-index: 1; left: 311px; top: 70px; position: absolute; right: 766px"></asp:TextBox>
        <asp:Label ID="lblEmployeeName" runat="server" style="z-index: 1; left: 27px; top: 74px; position: absolute" Text="Employee Name"></asp:Label>
        <asp:TextBox ID="txtEmployeeContentNo" runat="server" style="z-index: 1; left: 310px; top: 112px; position: absolute"></asp:TextBox>
        <asp:Label ID="LblEmployeeJobPosition" runat="server" style="z-index: 1; left: 30px; top: 164px; position: absolute" Text="Employee Job Position"></asp:Label>
        <asp:TextBox ID="txtEmployeeJobPostion" runat="server" style="z-index: 1; left: 310px; top: 163px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmployeeSalary" runat="server" style="z-index: 1; left: 33px; top: 205px; position: absolute" Text="Employee Salary"></asp:Label>
        <asp:TextBox ID="txtEmployeeSalary" runat="server" style="z-index: 1; left: 310px; top: 201px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmployeeStartDate" runat="server" style="z-index: 1; left: 28px; top: 248px; position: absolute; margin-bottom: 0px" Text="Employee Start Date"></asp:Label>
        <asp:TextBox ID="txtEmployeeStartDate" runat="server" style="z-index: 1; left: 309px; top: 245px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="ChkEmployeeCurrentStatus" runat="server" style="z-index: 1; left: 27px; top: 308px; position: absolute" Text="Employee Current Status" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 361px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 115px; top: 427px; position: absolute; width: 81px; height: 35px" Text="Cancel" />
        <asp:Label ID="lblEmployeeContentNo" runat="server" style="z-index: 1; left: 29px; top: 116px; position: absolute" Text="Employee Content Number"></asp:Label>
    </form>
</body>
</html>
