<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="allWatches.aspx.cs" Inherits="allWatches" %>

<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" Runat="Server">
    <table style="width:900px">
    <tr>
        <td style="width:900px; padding:10px">
         &nbsp;&nbsp;&nbsp;&nbsp; Brand :
            &nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList AutoPostBack="True"  runat="server" ID="wBrS" DataSourceID="SqlDataSource1" DataTextField="Brand" DataValueField="BrandId" OnSelectedIndexChanged="wBrS_SelectedIndexChanged" ></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBWatchesConnectionString13 %>" SelectCommand="SELECT * FROM [tblWatchBrand]"></asp:SqlDataSource>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; 
            Suppliers :
            &nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList AutoPostBack="true"  runat="server" ID="wSupS" DataSourceID="SqlDataSource2" DataTextField="ProCountry" DataValueField="CountryId" OnSelectedIndexChanged="wSupS_SelectedIndexChanged" ></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DBWatchesConnectionString13 %>" SelectCommand="SELECT * FROM [tblCountry]"></asp:SqlDataSource> 
        </td>
    </tr>
    <tr>
        <td style="width:900px; padding:10px">
 
           <table style="width:900px">
               <asp:ListView ID="ListView1"  runat="server" OnItemCommand="ListView1_ItemCommand" >
                   <ItemTemplate>
                       <tr>
                           <td style="width: 350px; vertical-align: top; padding: 10px; text-align: center">
                               <asp:Image Width="300px" ImageAlign="Middle" ID="ImgUrlLabel" runat="server" ImageUrl='<%# Eval("ImgUrl") %>' />
                           </td>
                           <td style="width: 550px; vertical-align: top; padding: 10px">
                               <asp:TextBox ID="txtwId" runat="server"   Visible="false"  Text='<%# Eval("wId") %>' />
                               <br />
                               Brand :
                               <asp:Label Font-Bold="true" Font-Size="30" ForeColor="#0000ff" ID="BrandLabel" runat="server" Text='<%# Eval("Brand") %>' />
                               <br />
                               Model :
                               <asp:Label ID="wModelLabel" runat="server" Text='<%# Eval("wModel") %>' />
                               <br />
                               Price : USD
                               <asp:Label ID="wPriceLabel" runat="server" Text='<%# Eval("wPrice") %>' />
                               <br />
                               <br />
                               <asp:LinkButton runat="server" ID="cmdDetail" CommandName="detail"
                                   Text="More Detail" >
                               </asp:LinkButton>
                           </td>
                       </tr>
                   </ItemTemplate>
               </asp:ListView>
               
           </table>

        </td>
    </tr>
</table>
</asp:Content>

