<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MailPreferences.aspx.cs" Inherits="MailPreferences" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <br />
    <br />

    <h1>Emailing Preferences</h1>
    <h2>Statement Schedule</h2>
    <input id="nikeTick" type="checkbox" runat="server" required>
    Weekly
    <input id="nikeTick2" type="checkbox" runat="server" required>
    Monthly
    <input id="nikeTick3" type="checkbox" runat="server" required>
    Yearly

    <br>

    <h2>Changes to Account</h2>

    <select>

        <option value="Yes">Yes</option>
        <option value="No">No</option>

    </select>

    <br>

    <div class="centeredPage">
        <button type="button">Save Changes</button>
    </div>

</asp:Content>

