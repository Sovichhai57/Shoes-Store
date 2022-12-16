<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="addNew.aspx.cs"
Inherits="addNew" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminContent" Runat="Server">
    <h1>Complete The Information To Add A New Watch</h1>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label runat="server" ForeColor="Red" ID="lblMes"  Text=""></asp:Label> 
 <table style="width:90%">
 
 <tr>
 <td style="width:20%; padding:15px;">Watch ID</td>
 <td style="width:30%"> <asp:TextBox runat="server" ID="wId" Width="180"></asp:TextBox> </td>
 <td style="width:20%"> Product of</td>
 <td style="width:30%"> <asp:DropDownList runat="server" ID="wCountry" Width="180px" DataSourceID="SqlDataSource1" DataTextField="ProCountry" DataValueField="Countryid" ></asp:DropDownList>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBWatchesConnectionString13 %>" SelectCommand="SELECT * FROM [tblCountry]"></asp:SqlDataSource>
 </td>
 </tr>
 <tr>
 <td style="width:20%; padding:15px;">Model</td>
 <td> <asp:TextBox runat="server" ID="wModel" Width="180"></asp:TextBox> </td>
 <td>Brand</td>
 <td> <asp:DropDownList runat="server" ID="wBr" Width="180px" DataSourceID="SqlDataSource2" DataTextField="Brand" DataValueField="Brandid" ></asp:DropDownList> 
     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DBWatchesConnectionString13 %>" SelectCommand="SELECT * FROM [tblWatchBrand]"></asp:SqlDataSource>
     </td>
 </tr>
 <tr>
 <td style="width:20%; padding:15px;">Price </td>
 <td> <asp:TextBox runat="server" ID="wPr" Width="180"></asp:TextBox>
 </td>
 <td>For Boy/Girl</td>
 <td><asp:DropDownList runat="server" ID="wBGl" Width="180px" DataSourceID="SqlDataSource3" DataTextField="Types" DataValueField="bgid" ></asp:DropDownList>
     <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DBWatchesConnectionString13 %>" SelectCommand="SELECT * FROM [tblType]"></asp:SqlDataSource>
 </td>
 </tr>
 <tr>
 <td style="width:20%; padding:15px; vertical-align:top">Description</td>
 <td colspan="3"><asp:TextBox runat="server" ID="wDes" TextMode="MultiLine" Columns="68" Rows="5"></asp:TextBox></td>
 </tr> 
 <tr>
 <td style="width:20%; padding:15px;">Choose an Image</td>
 <td colspan="3">
 <asp:FileUpload ID="ImgUpload" runat="server" /><asp:Label runat="server" ForeColor="Orange"  ID="lblImgMes" Text=""></asp:Label></td>

 </tr> 
 <tr>
 <td style="width:20%; padding:15px;"></td>
 <td colspan="3">
 <asp:CheckBox runat="server" ID="chkAgree" Text="Checked mean that you have agreed to our terms and policy." 
     OnCheckedChanged="chkAgree_CheckedChanged1" AutoPostBack="true"/>
 </td>
    
 </tr> 
 <tr>
 <td style="width:20%; padding:25px;"></td>
 <td>
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
     <asp:Button runat="server" ID="btnAddNew" Text="Add New Watch" OnClick="btnAddNew_Click"  />
 </td>

  <td><asp:Button runat="server" ID="btnCancel" Text="Cancel" /></td>
 
 
 

 
 </tr>
 </table>
</asp:Content>

