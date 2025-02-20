<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="ForgotPassword" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <div id="key">

    <p>Please enter your email to reset your password</p>
        
    <br />
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="SendEmail" runat="server" Text="Submit" OnClick="SendEmail_Click"/>
    <br />
    <br />
    <br />
    <asp:Label ID="lblmessage" runat="server" ForeColor="#FF5050"></asp:Label>

        </div>

</asp:Content>

