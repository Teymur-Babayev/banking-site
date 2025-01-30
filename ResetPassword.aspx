<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="ResetPassword" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    

   

    <h3>Please enter your new password to reset it</h3>
        
    <br />
    <br />
    <br />

        Email:
    <asp:TextBox ID="email" runat="server"></asp:TextBox>

     <br />
    <br />
    <br />
    
        Password and Confirmation:<br />
            <asp:TextBox ID="passwordTextBox" runat="server"
                TextMode="Password" />
            <asp:RequiredFieldValidator ID="passwordReq"
                runat="server"
                ControlToValidate="passwordTextBox"
                ErrorMessage="Password is required!"
                SetFocusOnError="True" Display="Dynamic" />
            <asp:TextBox ID="confirmPasswordTextBox" runat="server"
                TextMode="Password" />
            <asp:RequiredFieldValidator ID="confirmPasswordReq"
                runat="server"
                ControlToValidate="confirmPasswordTextBox"
                ErrorMessage="Password confirmation is required!"
                SetFocusOnError="True"
                Display="Dynamic" />
            <asp:CompareValidator ID="comparePasswords"
                runat="server"
                ControlToCompare="passwordTextBox"
                ControlToValidate="confirmPasswordTextBox"
                ErrorMessage="Peak!"
                Display="Dynamic" />
            <asp:RegularExpressionValidator ID="regexValidate" runat="server"
                ErrorMessage="Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters."
                ControlToValidate="passwordTextBox"
                ValidationExpression="^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$" />
        
         <br />
    <br />
    <br />

    <asp:Button ID="Button1" runat="server" Text="Change Password" OnClick="Button1_Click" />

    <asp:Label ID="lblMessage" runat="server" ForeColor="#FF0066"></asp:Label>
        

</asp:Content>

