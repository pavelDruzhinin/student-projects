<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="telcontacts.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Безымянная страница</title>
</head>
<body>
    <form id="form1" runat="server" method="post">
    <div style="padding: 10px; border: 1px solid #003366; width: 300px; height: 100px; margin-top: 10%; margin-right: auto; margin-left: auto; background-color: #A6D2FF;">
        <table>
            <tr>
                <td>Логин:
                </td>
                <td>
                    <asp:TextBox ID="Login1" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Пароль:
                </td>
                <td>
                    <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" 
            Text="Войти" />
    </div>
    </form>
</body>
</html>
