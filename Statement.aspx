<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Statement.aspx.cs" Inherits="Statement" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <!--everthing within this 'asp:content' tag can be HTML-->

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#hideshow').click(function () {
                $('#searchStatement').toggle('show');
            });
            $('#hideshow1').click(function () {
                $('#searchStatement').toggle('show');
            });
        });
    </script>
    <script>
        function printStatement() {
            window.print();
        }
    </script>

    <br />

    <div id="Summary">

        <div class="statementLeft">
            <p>
                <button type="button" onclick="printStatement()">Print Statement</button></p>
            <p>
                <button type="button">Export Statement</button></p>
            <asp:Button ID="withdraw" runat="server" Text="withdraw" OnClick="withdraw_Click" />
            <asp:Button ID="deposit" runat="server" Text="deposit" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>

        <div class="statementMiddle">
            <div id="statementSummary">
                <!--This student could be any other account - will have to connect to C# later-->
                <p><u>"Student" Account Summary</u></p>

                <h4>Account No:</h4> <asp:Label ID="accountNumber" runat="server" Text="Label"></asp:Label>
                <h4>Sort Code:</h4> <asp:Label ID="sortCode" runat="server" Text="Label"></asp:Label>

                <!--this balance will have to be pulled in by c# code-->
                <p>Balance:</p>
                <asp:Label ID="balanceLabel" runat="server" Text="Label"></asp:Label>
                <p>Available:</p>
                <asp:Label ID="availableLabel" runat="server" Text="Label"></asp:Label>
                <p>Overdraft Limit:</p>
                <asp:Label ID="overdraftLimit" runat="server" Text="Label"></asp:Label>
                <p>Charges:</p>
                <asp:Label ID="chargesLabel" runat="server" Text="Label"></asp:Label>

            </div>
        </div>

        <div class="statementRight">
            <button class="rightButton" type="button" id="hideshow" value="hide/show">Search Statement</button>
            <p></p>
            <br />
            <p></p>
            <button class="rightButton" type="button">Switch Account</button>
        </div>
    </div>

    <br />

    <div id="key">
        <a href="#openModal1"><u>Click here</u></a> to see what the different types of payment acronyms mean.
    </div>

    <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>

    <!--popup box-->
    <div id="openModal1" class="modalDialog">
        <div>
            <a href="#close" title="Close" class="close">X</a>

            <h2>Payment Types</h2>
            <p>BAC - Electronic Payment System</p>
            <p>BGC - Bank Giro Credit</p>
            <p>BP  - Bill Payment</p>
            <p>CHG - Charge</p>
            <p>CPT - Cashpoint</p>
            <p>CSH - Cash </p>
            <p>OTH - Other</p>
            <p>SAL - Salary</p>
            <p>SPB - Cashpoint</p>
            <p>SO  - Standing Order </p>
        </div>
    </div>

    <br />

    <div id="searchStatement" style="display: none">
        <b>Search your statement:</b>
        <div id="closeButton">
            <button type="button" id='hideshow1' value='hide/show'>X</button>
        </div>
        <div id="search">
            <p>Time Period:
                <input type="text" placeholder="Number of days">
                Days</p>
            <p>Between:
                <input type="text" placeholder="Date From">
                To
                <input type="text" placeholder="Date To"></p>
            <p>Description:
                <input type="text" placeholder="Transaction Name"></p>
            <button type="button">Search</button>
        </div>
    </div>

    <br />

    <!--we will be pulling data in this table from backend-->
    <div id="statementMain">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="TransactionName" HeaderText="Description" SortExpression="TransactionName" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="TransactionTypeID" HeaderText="Type" SortExpression="TransactionTypeID" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="PaymentTotal" HeaderText="Total" SortExpression="PaymentTotal" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ToAccount" HeaderText="ToAccount" SortExpression="ToAccount" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [TransactionName], [TransactionDate], [PaymentTotal], [TransactionTypeID], [ToAccount], [FromAccount] FROM [tblTransaction]"></asp:SqlDataSource>

    </div>

</asp:Content>