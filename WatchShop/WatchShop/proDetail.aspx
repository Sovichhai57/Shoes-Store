<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="proDetail.aspx.cs" Inherits="proDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" Runat="Server">
    <h1>Show Product Detail</h1>
    <table>
    <asp:ListView ID="ListView1" runat="server"   >
        <ItemTemplate>
            <tr>
                <td style="width:900px; text-align:center; padding:10px">
                    <asp:Image Width="300px" Height="300px" ImageAlign="Middle" ID="ImgUrlLabel" runat="server" ImageUrl='<%# Eval("ImgUrl") %>' />
                </td>
 
            </tr>
            <tr>
                <td style="padding:10px">
                    <asp:textbox ID="wIdS" Visible="false" runat="server" Text='<%# Eval("wId") %>' />
                    <br />
                    <asp:Label ID="BrandLabel" runat="server" Text='<%# Eval("Brand") %>' />
                    <br /> Model : 
                    <asp:Label ID="wModelLabel" runat="server" Text='<%# Eval("wModel") %>' />
                    <br /> For : 
                    <asp:Label ID="TypesLabel" runat="server" Text='<%# Eval("Types") %>' />
                    <br /> Product of :
                    <asp:Label ID="ProCountryLabel" runat="server" Text='<%# Eval("ProCountry") %>' />
                    <br /> Price : 
                    <asp:Label ID="wPriceLabel" runat="server" Text='<%# Eval("wPrice") %>' />
                    <br /> Description : 
                    <asp:Label ID="wDesLabel" runat="server" Text='<%# Eval("wDes") %>' />
                </td>
            </tr>
         </ItemTemplate>
    </asp:ListView>
        
        
               <tr>
            <td colspan="2">
                <hr />
                <asp:ListView ID="LView2" runat="server" DataKeyNames="ImgId"  GroupItemCount="3" >   

                 <ItemTemplate>
                    <td id="Td1" runat="server" style="padding:10px; text-align:center">
                    <asp:TextBox Visible="False" ID="txtImgIds" runat="server" Text='<%# Eval("ImgId") %>' />
                    <asp:TextBox Visible="False" ID="TextBox1" runat="server" Text='<%# Eval("wId") %>' />
                    <br />
                    <asp:Image ImageAlign="Middle" ID="Image2" runat="server" Width="220" ImageUrl='<%# Eval("ImgUrls") %>' />
                    </td>
                </ItemTemplate>
 
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <LayoutTemplate>
                <table id="Table1" runat="server">
                  <tr id="Tr1" runat="server">
                    <td id="Td2" runat="server">
                        <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                            <tr id="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                  </tr>
                  <tr id="Tr2" runat="server">
                    <td id="Td3" runat="server" style="">
                    </td>
                  </tr>
                </table>
                </LayoutTemplate>
                </asp:ListView>

            </td>
        </tr>
   </table>


</asp:Content>

