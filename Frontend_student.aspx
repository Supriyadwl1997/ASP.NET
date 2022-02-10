<%@Page Language="C#" AutoEventWireup="true" Codefile="Emp_Database_conn.cs" Inherits="_Default" %>

<!DOCTYPE html>

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>FirstName</td> 
                    <td><asp:TextBox ID="firstname" runat="server">
                    </asp:TextBox></td>
                </tr>
                <tr>
                    <td>LastName</td>
                    <td><asp:TextBox ID="Lastname" runat="server">
                    </asp:TextBox></td>
                </tr>
                <tr>
                    <td>ClassName</td>
                    <td><asp:TextBox ID="ClassName" runat="server">
                    </asp:TextBox></td>
                </tr>
                <tr>
                    <td>Rollno</td>
                    <td><asp:TextBox ID="Rollno" runat="server">
                    </asp:TextBox></td>
                </tr>
                <tr>
                    <td>Percentage</td>
                    <td><asp:TextBox ID="Percentage" runat="server">
                    </asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                    <asp:Button ID="Button1" runat="server" Text="Submit"></asp:Button>
                    <asp:Button ID="Button2" runat="server" Text="Filter"></asp:Button>
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>