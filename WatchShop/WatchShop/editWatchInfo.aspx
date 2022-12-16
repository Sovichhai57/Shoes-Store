<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="editWatchInfo.aspx.cs" Inherits="editInformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminContent" Runat="Server">
    <h2>Search For The Watch By ID To Edit The Watch Information </h2>
 <table style="width:90%">
      <tr>
            <td colspan="4" style="text-align:center"><asp:Label runat="server" ID="lblMes" ForeColor="#CC3300" Font-Bold="True" Font-Italic="True" BackColor="#FFFFCC"></asp:Label></td>
        </tr>
 <tr>
 <td style="width:20%; padding:15px;">Watch ID</td>
 <td style="width:30%"> <asp:TextBox runat="server" ID="wId" Width="180"></asp:TextBox> </td>
 <td style="width:20%"> Product of</td>
 <td style="width:30%"> <asp:DropDownList runat="server" ID="wCountry" Width="180px" DataSourceID="SqlDataSource1" DataTextField="ProCountry" DataValueField="Countryid" ></asp:DropDownList> 
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBWatchesConnectionString %>" SelectCommand="SELECT * FROM [tblCountry]"></asp:SqlDataSource>
     </td>
 </tr>
 <tr>
 <td style="width:20%; padding:15px;">Model</td>
 <td> <asp:TextBox runat="server" ID="wModel" Width="180"></asp:TextBox> </td>
 <td>Brand</td>
 <td><asp:DropDownList runat="server" ID="wBr" Width="180px" DataSourceID="SqlDataSource2" DataTextField="Brand" DataValueField="Brandid" ></asp:DropDownList>
     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DBWatchesConnectionString13 %>" SelectCommand="SELECT * FROM [tblWatchBrand]"></asp:SqlDataSource>
     </td>
 </tr>
 <tr>
 <td style="width:20%; padding:15px;">Price</td>
 <td> <asp:TextBox runat="server" ID="wPr" Width="180"></asp:TextBox> </td>
 <td>For Boy/Girl</td>
 <td><asp:DropDownList runat="server" ID="wBGT" Width="180px" DataSourceID="SqlDataSource3" DataTextField="Types" DataValueField="bgid" ></asp:DropDownList> 
     <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DBWatchesConnectionString13 %>" SelectCommand="SELECT * FROM [tblType]"></asp:SqlDataSource>
     </td>
 </tr>
 <tr>
 <td style="width:20%; padding:15px; vertical-align:top">Description</td>
 <td colspan="3"><asp:TextBox runat="server" ID="wDes" TextMode="MultiLine" Columns="68" Rows="5"></asp:TextBox></td>
 </tr> 
 <tr>
 <td style="width:20%; padding:15px;"></td>
 <td colspan="3">
 <asp:CheckBox runat="server" ID="chkAgree" Text="Checked mean that you have agrred to our terms and policy." />
 </td>
 </tr> 
 <tr>
 <td style="width:20%; padding:25px;"></td>
 <td colspan="3">
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 <asp:Button runat="server" ID="btnSearch" Text="Search" OnClick="btnSearch_Click"  />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 <asp:Button runat="server" ID="btnUpdate" Text="Update" OnClick="btnUpdate_Click"  />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 <asp:Button runat="server" ID="btnCancel" Text="Cancel" />
 </td>
 </tr>
 </table>
</asp:Content>

