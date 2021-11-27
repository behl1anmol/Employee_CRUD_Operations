<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeCRUD.aspx.cs" Inherits="Client.EmployeeCRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 4px;
            background-color: #C0C0C0;
        }
        .auto-style6 {
            height: 47px;
            width: 541px;
        }
        .auto-style7 {
            height: 45px;
            width: 541px;
        }
        .auto-style8 {
            height: 51px;
            width: 541px;
        }
        .auto-style9 {
            height: 147px;
            width: 541px;
        }
        .auto-style10 {
            height: 47px;
            width: 1051px;
        }
        .auto-style11 {
            height: 45px;
            width: 1051px;
        }
        .auto-style12 {
            height: 51px;
            width: 1051px;
        }
        .auto-style13 {
            height: 147px;
            width: 1051px;
        }
        .auto-style14 {
            width: 432px;
        }
    </style>
</head>
<body>
    <form id="EmployeeCRUDForm" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style6">Employee ID</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="EmpIDBox" runat="server" OnTextChanged="EmpIDBox_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="EmpIDBox" ErrorMessage="Field Required [Enter Random value in case of GET Employee]" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style14" rowspan="6">
                        <asp:GridView ID="ResGrid" runat="server" CellSpacing="30" Height="222px" HorizontalAlign="Center" Width="542px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Employee Name</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="EmpNameBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Employee Phone Number</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="EmpPhNoBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Employee Email</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="EmpEmailBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Employee Address</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="EmpAddrBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="ResLbl" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:Button ID="BtnAdd" runat="server" Height="33px" OnClick="BtnAdd_Click" Text="Add Employee" Width="176px" />
                        <asp:Button ID="UpdateBtn" runat="server" Height="32px" OnClick="UpdateBtn_Click" Text="Update Employee" Width="186px" />
                        <asp:Button ID="BtnDel" runat="server" Height="33px" OnClick="BtnDel_Click" Text="Delete Employee" Width="176px" />
                        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find Employee" Width="186px" />
                        <asp:Button ID="BtnGetAll" runat="server" OnClick="BtnGetAll_Click" Text="Get All Employees" Width="178px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
