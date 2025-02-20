<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

     <div id="containerLogin" >
                   
                  <p class="loginText" >Log in</p>        
                  Username:<input class="boxes1" type="text" name="firstname" value="" id="userName" runat="server">
                  <br>
                  <br>
                  Password:<input class="boxes1" type="password" name="firstname" value="" id="password" runat="server">
                  <br>
                  <br>  
                   <br>
                  <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                  <br>
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="loginASPX" runat="server" OnClick="loginASPX_Click" Text="Login" />
                  <br>
                  <p class="registerHere">
				  Don't have an account?
      			  <a href="RegistrationPage" class="to_register">Register Here</a>
				  </p>
            <a href="ForgotPassword" class="to_register">Forgotten Password?</a>
                
                  
                  </div>
                       




















</asp:Content>

