

<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminContent" Runat="Server">
    <asp:Login ID="Login1" runat="server">
    </asp:Login>
   
    <asp:HyperLink ID="Hyperlink" runat="server" NavigateUrl="~/SignUp.aspx"
        Text ="Sign Up" />
</asp:Content>

