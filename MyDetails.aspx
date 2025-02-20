<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MyDetails.aspx.cs" Inherits="MyDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    
    <br />

    <h1>My Details(Teymur Babayev)</h1>
    <h2>Address</h2>
    <p>

        <asp:TextBox  ID="Address1" runat="server" AutoPostBack="false"></asp:TextBox>
        <asp:TextBox  ID="Address2" runat="server" AutoPostBack="false"></asp:TextBox>
        <asp:TextBox  ID="Address3" runat="server" AutoPostBack="false"></asp:TextBox>
        <asp:TextBox  ID="PostCode" runat="server" AutoPostBack="false"></asp:TextBox>

    </p>
    <h2>Phone Number</h2>
    <asp:TextBox  ID="homePhone" runat="server" AutoPostBack="false"></asp:TextBox>
    <asp:TextBox ID ="mobile" runat="server" AutoPostBack="false"></asp:TextBox>

    <h2> Email Address </h2>

    <asp:TextBox  ID="email" runat="server" AutoPostBack="false"></asp:TextBox>

    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="lblError" runat="server"></asp:Label>
    <br />
    
</asp:Content>

