<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="WelcomePage.aspx.cs" Inherits="WelcomePage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="container">

<header>
   <h1>Welcome to your account summary
    </h1>
          <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
</header>
  
<nav >
  <ul>
    <li><a href="Statement">Statement</a></li>
    <li><a href="#article2">Overdraft</a></li>
    <li><a href="Preferences">Security Preferences</a></li>
     <li><a href="Payment.aspx">Make Payment</a></li>
      <li><a href="CreateAccount.aspx">Open an Account</a></li>
  </ul>
</nav>

    <div id="article1">
<article>
  <h1>Statement</h1>
  <p>Your family funds are secure&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      </p>
</article>
    </div>

       <div id="article2">
<article>
  <h1>Overdraft</h1>
  <p>London is the capital city of England. It is the most populous city in the  United Kingdom, with a metropolitan area of over 13 million inhabitants.</p>
</article>
    </div>
           <div id="article3">
<article>
  <h1>Security Preferences</h1>
  <p>London is the capital city of England. It is the most populous city in the  United Kingdom, with a metropolitan area of over 13 million inhabitants.</p>
  <p>Standing on the River Thames, London has been a major settlement for two millennia, its history going back to its founding by the Romans, who named it Londinium.</p>
</article>
    </div>



</div>








</asp:Content>

