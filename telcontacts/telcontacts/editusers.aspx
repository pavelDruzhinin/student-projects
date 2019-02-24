<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editusers.aspx.cs" Inherits="telcontacts.editusers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Безымянная страница</title>
    <style type="text/css">
        input
        {
            width: 99%;
            float: right;
        }
     </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:telCatalogConnectionString %>" 
        SelectCommand="prcViewUsers" 
        DeleteCommand="DELETE FROM [tblContacts] WHERE [idContact] = @idContact" 
        InsertCommand="INSERT INTO [tblContacts] ([organization], [address], [telephone], [fax], [email], [site], [idUser], [idGroup]) VALUES (@organization, @address, @telephone, @fax, @email, @site, @idUser, @idGroup)" 
        
        UpdateCommand="UPDATE [tblContacts] SET [organization] = @organization, [address] = @address, [telephone] = @telephone, [fax] = @fax, [email] = @email, [site] = @site, [idUser] = @idUser, [idGroup] = @idGroup WHERE [idContact] = @idContact" 
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:SessionParameter Name="nameGroup" SessionField="nameGroup" Type="String" />
        </SelectParameters>
        <DeleteParameters>
            <asp:Parameter Name="idContact" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="organization" Type="String" />
            <asp:Parameter Name="address" Type="String" />
            <asp:Parameter Name="telephone" Type="String" />
            <asp:Parameter Name="fax" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="site" Type="String" />
            <asp:Parameter Name="idUser" Type="Int32" />
            <asp:Parameter Name="idGroup" Type="Int32" />
            <asp:Parameter Name="idContact" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="organization" Type="String" />
            <asp:Parameter Name="address" Type="String" />
            <asp:Parameter Name="telephone" Type="String" />
            <asp:Parameter Name="fax" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="site" Type="String" />
            <asp:Parameter Name="idUser" Type="Int32" />
            <asp:Parameter Name="idGroup" Type="Int32" />
        </InsertParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:telCatalogConnectionString %>" 
        
        
        SelectCommand="SELECT * FROM [tblUsers] WHERE ([idGroup] = @idGroup)" 
        DeleteCommand="DELETE FROM [tblUsers] WHERE [idUser] = @idUser" 
        InsertCommand="INSERT INTO [tblUsers] ([nameUser], [login], [password], [idGroup]) VALUES (@nameUser, @login, @password, @idGroup)" 
        UpdateCommand="UPDATE [tblUsers] SET [nameUser] = @nameUser, [login] = @login, [password] = @password, [idGroup] = @idGroup WHERE [idUser] = @idUser">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="idGroup" 
                PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
        <DeleteParameters>
            <asp:Parameter Name="idUser" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="nameUser" Type="String" />
            <asp:Parameter Name="login" Type="String" />
            <asp:Parameter Name="password" Type="String" />
            <asp:Parameter Name="idGroup" Type="Int32" />
            <asp:Parameter Name="idUser" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="nameUser" Type="String" />
            <asp:Parameter Name="login" Type="String" />
            <asp:Parameter Name="password" Type="String" />
            <asp:Parameter Name="idGroup" Type="Int32" />
        </InsertParameters>
    </asp:SqlDataSource>
    <div style="padding: 5px; font-size: large; color: #D9ECFF; background-color: #1E3557;">
        <span style="color: #FFFFFF">Имя пользователя: </span><asp:Label 
            ID="lblNameUser" runat="server"></asp:Label>
        <span style="color: #FFFFFF">&nbsp;Группа: </span>
        <asp:Label 
            ID="lblNameGroup" runat="server"></asp:Label>
&nbsp; <asp:Button ID="btnLogout0" runat="server" Text="Выйти из системы" BackColor="#1EA7C8" 
            BorderColor="#CCCCCC" BorderWidth="1px" Font-Size="Medium" ForeColor="White" 
            onclick="btnLogout_Click" Width="200px" /> 
        <asp:Button ID="btnViewUsers" 
            runat="server" Text="Контакты" BackColor="#1EA7C8" 
            BorderColor="#CCCCCC" BorderWidth="1px" Font-Size="Medium" ForeColor="White" 
            onclick="btnViewUsers_Click" Width="200px" /></div> 
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" 
        AutoGenerateColumns="False" DataKeyNames="idUser" 
        DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" AllowPaging="True" 
        Width="100%">
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="nameUser" HeaderText="Имя пользователя" 
                SortExpression="nameUser" />
            <asp:BoundField DataField="login" HeaderText="Логин" 
                SortExpression="login" />
            <asp:BoundField DataField="idGroup" HeaderText="Группа" 
                SortExpression="idGroup" />
        </Columns>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        CellPadding="4" DataSourceID="SqlDataSource2" 
        ForeColor="#333333" Height="50px" Width="100%" 
        onitemdeleted="DetailsView1_ItemDeleted" 
        oniteminserted="DetailsView1_ItemInserted" 
        onitemupdated="DetailsView1_ItemUpdated" DataKeyNames="idUser">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" Width="250px" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <Fields>
            <asp:BoundField DataField="nameUser" HeaderText="Имя пользователя" 
                SortExpression="nameUser" />
            <asp:BoundField DataField="login" HeaderText="Логин" 
                SortExpression="login" />
            <asp:BoundField DataField="password" HeaderText="Пароль" 
                SortExpression="password" />
            <asp:BoundField DataField="idGroup" HeaderText="Группа" 
                SortExpression="idGroup" />
            <asp:CommandField ButtonType="Button" EditText="Изменить" 
                InsertText="Сохранить" SelectText="Выбрать" ShowDeleteButton="True" 
                ShowEditButton="True" ShowInsertButton="True" UpdateText="Сохранить">
                <ControlStyle BackColor="#009EBF" Font-Bold="False" Font-Size="Large" 
                    ForeColor="White" Width="200px" />
            </asp:CommandField>
        </Fields>
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <InsertRowStyle BackColor="#CCCCCC" />
        <EditRowStyle BackColor="#CCCCCC" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:DetailsView>
    <br />
    </form>
</body>
</html>
