<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="telcontacts._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Безымянная страница</title>
    <style type="text/css">
        input
        {
            width: 100%;
            float: right;
        }
        input[text]
        {
            width: 100%;
        }
        input
        {
            width: 98%;
        }
        input
        {
            width: 99%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:telCatalogConnectionString %>" 
        SelectCommand="prcViewContacts" 
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
        
        SelectCommand="SELECT * FROM [tblContacts] WHERE ([idContact] = @idContact)" 
        DeleteCommand="DELETE FROM [tblContacts] WHERE [idContact] = @idContact" 
        InsertCommand="INSERT INTO [tblContacts] ([organization], [address], [telephone], [fax], [email], [site], [idUser], [idGroup]) VALUES (@organization, @address, @telephone, @fax, @email, @site, @idUser, @idGroup)" 
        
        
        UpdateCommand="UPDATE [tblContacts] SET [organization] = @organization, [address] = @address, [telephone] = @telephone, [fax] = @fax, [email] = @email, [site] = @site, [idUser] = @idUser, [idGroup] = @idGroup WHERE [idContact] = @idContact">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="idContact" 
                PropertyName="SelectedValue" Type="Int32" />
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
    <div style="padding: 5px; font-size: large; color: #D9ECFF; background-color: #1E3557;">
        <span style="color: #FFFFFF">Имя пользователя: </span><asp:Label 
            ID="lblNameUser" runat="server"></asp:Label>
        <span style="color: #FFFFFF">&nbsp;Группа: </span>
        <asp:Label 
            ID="lblNameGroup" runat="server"></asp:Label>
&nbsp; <asp:Button ID="btnLogout0" runat="server" Text="Выйти из системы" BackColor="#1EA7C8" 
            BorderColor="#CCCCCC" BorderWidth="1px" Font-Size="Medium" ForeColor="White" 
            onclick="btnLogout_Click" Width="200px" /> <asp:Button ID="btnViewUsers" 
            runat="server" Text="Пользователи" BackColor="#1EA7C8" 
            BorderColor="#CCCCCC" BorderWidth="1px" Font-Size="Medium" ForeColor="White" 
            onclick="btnViewUsers_Click" Width="200px" /></div> 
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" 
        AutoGenerateColumns="False" DataKeyNames="idContact" 
        DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" AllowPaging="True" 
        Width="100%">
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="organization" HeaderText="organization" 
                SortExpression="organization" />
            <asp:BoundField DataField="address" HeaderText="address" 
                SortExpression="address" />
            <asp:BoundField DataField="telephone" HeaderText="telephone" 
                SortExpression="telephone" />
            <asp:BoundField DataField="fax" HeaderText="fax" SortExpression="fax" />
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            <asp:BoundField DataField="site" HeaderText="site" SortExpression="site" />
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
        CellPadding="4" DataKeyNames="idContact" DataSourceID="SqlDataSource2" 
        ForeColor="#333333" Height="50px" Width="100%" 
        onitemdeleted="DetailsView1_ItemDeleted" 
        oniteminserted="DetailsView1_ItemInserted" 
        onitemupdated="DetailsView1_ItemUpdated">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" Width="250px" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <Fields>
            <asp:BoundField DataField="organization" HeaderText="Название организации" 
                SortExpression="organization" />
            <asp:BoundField DataField="address" HeaderText="Адрес" 
                SortExpression="address" />
            <asp:BoundField DataField="telephone" HeaderText="Телефон" 
                SortExpression="telephone" />
            <asp:BoundField DataField="fax" HeaderText="Факс" SortExpression="fax" />
            <asp:BoundField DataField="email" HeaderText="E-mail" SortExpression="email" />
            <asp:BoundField DataField="site" HeaderText="Site" SortExpression="site" />
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
