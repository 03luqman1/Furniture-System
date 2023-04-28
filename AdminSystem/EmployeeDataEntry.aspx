<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 27px; top: 430px; position: absolute; width: 77px" Text="OK" />
        <asp:Label ID="lblDoesNotExist" runat="server" style="z-index: 1; left: 628px; top: 33px; position: absolute" Text="Employee ID Does Not Exist"></asp:Label>
        <asp:Label ID="lblEmployeeId" runat="server" style="z-index: 1; left: 31px; top: 28px; position: absolute" Text="Employee ID"></asp:Label>
        <asp:TextBox ID="txtEmployeeID" runat="server" style="z-index: 1; left: 312px; top: 26px; position: absolute" OnTextChanged="TxtEmployeeID_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtEmployeeName" runat="server" style="z-index: 1; left: 311px; top: 70px; position: absolute; right: 924px"></asp:TextBox>
        <asp:Label ID="lblEmployeeName" runat="server" style="z-index: 1; left: 27px; top: 74px; position: absolute" Text="Employee Name"></asp:Label>
        <asp:TextBox ID="txtEmployeeContentNo" runat="server" style="z-index: 1; left: 310px; top: 112px; position: absolute"></asp:TextBox>
        <asp:Label ID="LblEmployeeJobPosition" runat="server" style="z-index: 1; left: 30px; top: 164px; position: absolute" Text="Employee Job Position"></asp:Label>
        <asp:TextBox ID="txtEmployeeJobPosition" runat="server" style="z-index: 1; left: 310px; top: 163px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmployeeSalary" runat="server" style="z-index: 1; left: 33px; top: 205px; position: absolute" Text="Employee Salary"></asp:Label>
        <asp:TextBox ID="txtEmployeeSalary" runat="server" style="z-index: 1; left: 310px; top: 201px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmployeeStartDate" runat="server" style="z-index: 1; left: 28px; top: 248px; position: absolute; margin-bottom: 0px" Text="Employee Start Date"></asp:Label>
        <asp:TextBox ID="txtEmployeeStartDate" runat="server" style="z-index: 1; left: 309px; top: 245px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkCurrentEmployeeStatus" runat="server" style="z-index: 1; left: 27px; top: 308px; position: absolute" Text="Current Employee Status" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 361px; position: absolute"></asp:Label>
        <asp:Label ID="lblEmployeeContentNo" runat="server" style="z-index: 1; left: 29px; top: 116px; position: absolute" Text="Employee Content Number"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 529px; top: 25px; position: absolute; height: 41px; width: 76px" Text="Find" />
        <asp:Button ID="btnCancel0" runat="server" style="z-index: 1; left: 105px; top: 430px; position: absolute; width: 81px; height: 35px; right: 1117px;" Text="Cancel" OnClick="btnCancel0_Click" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click1" style="z-index: 1; left: 192px; top: 431px; position: absolute; height: 34px; width: 77px" Text="Clear" />
    </form>
</body>
</html>
