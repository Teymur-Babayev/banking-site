<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CreateAccount.aspx.cs" Inherits="CreateAccount" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">


     <div class="containerPayment">

        <h2>Create an Account!</h2> 

        <br />

        <h5>Choose your account:</h5> 

        <br />
        <br />
        Account Name:<input class="boxes" type="text" name="AccountName" value="" id="accountName" runat="server">
        <br />
        <br />
       Account Type *
            <select class="boxes" name="accountType" id="accountType" runat="server" required>

        <option value="1">Current Account</option>
        <option value="2">Savings Account</option>
        <option value="3">Student Account</option>
       

    </select>

        <br />
        <br />
          Select Branch *
            <select class="boxes" name="branch" id="branch" runat="server" required>

        <option value="1">Central London</option>
        <option value="2">Main One</option>
        <option value="3">B'ham</option>
        <option value="5">Newcastle One</option>
        <option value="6">Manchester</option>

    </select>
         
        <br />
         <br />
         <br />
         <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCreate" runat="server" Text="Create Account" OnClick="btnCreate_Click" />
        

        

    </div>


</asp:Content>

