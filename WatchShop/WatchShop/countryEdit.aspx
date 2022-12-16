<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="countryEdit.aspx.cs" Inherits="countryEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="Countryid" DataSourceID="SqlDataSource1" Width="446px" CellPadding="4" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Countryid" HeaderText="Countryid" ReadOnly="True" SortExpression="Countryid" />
            <asp:BoundField DataField="ProCountry" HeaderText="ProCountry" SortExpression="ProCountry" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBWatchesConnectionString13 %>" DeleteCommand="DELETE FROM [tblCountry] WHERE [Countryid] = @Countryid" InsertCommand="INSERT INTO [tblCountry] ([Countryid], [ProCountry]) VALUES (@Countryid, @ProCountry)" SelectCommand="SELECT * FROM [tblCountry]" UpdateCommand="UPDATE [tblCountry] SET [ProCountry] = @ProCountry WHERE [Countryid] = @Countryid">
        <DeleteParameters>
            <asp:Parameter Name="Countryid" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Countryid" Type="Int32" />
            <asp:Parameter Name="ProCountry" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ProCountry" Type="String" />
            <asp:Parameter Name="Countryid" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

