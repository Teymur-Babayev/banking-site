using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Statement : System.Web.UI.Page
{

    static double displayBalance = 50;
    CurrentAccount ba = new CurrentAccount(displayBalance);


    StudentAccount st = new StudentAccount(displayBalance);

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }

        pullStatementDetails();

            //DateTime dt = DateTime.Today;

            //string connString = DBConnection.ConnectionString;

            //using (SqlConnection conn = new SqlConnection(connString))

            //{
            //    string query = "INSERT into tblTransaction (TransactionName, TransactionDate, PaymentTotal, TransactionTypeID, FromAccount, ToAccount) values (@transactionName, @transactionDate, @paymentTotal, @transactionTypeID, @fromAccount, @toAccount);";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@transactionName", reference.Value);
            //    cmd.Parameters.AddWithValue("@transactionDate", dt);
            //    cmd.Parameters.AddWithValue("@paymentTotal", amount.Value);
            //    cmd.Parameters.AddWithValue("@transactionTypeID", 3);
            //    cmd.Parameters.AddWithValue("@fromAccount", Session["id"]);
            //    cmd.Parameters.AddWithValue("@toAccount", accountNo.Value);


            //    cmd.Connection.Open();
            //    try
            //    {
            //        cmd.ExecuteNonQuery();
            //        lblMessage.Text = "Payment made successfully";
            //    }
            //    catch (Exception ex)
            //    {
            //        lblMessage.Text = Convert.ToString(ex);
            //        throw new Exception("Error " + ex.Message);
            //    }
            //}





            balanceLabel.Text = "£" + Convert.ToString(ba.getBalance());

            double x = ba.getBalance();

            if (x < 0)
            {

                availableLabel.Text = "£0";
                chargesLabel.Text = "£" + Convert.ToString(ba.setInterest());
            }

            else
            {
                availableLabel.Text = "£" + Convert.ToString(ba.getBalance());
                chargesLabel.Text = "£0";
            }

            overdraftLimit.Text = "£" + Convert.ToString(ba.getOverdraftLimit());
        }
    
    public void pullStatementDetails()
    {
        string strcon = DBConnection.ConnectionString;

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("StatementDetails", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter p1 = new SqlParameter("@customerID", Session["id"]);

        var returnParameter = com.Parameters.Add("@ReturnVal", SqlDbType.Int);
        returnParameter.Direction = ParameterDirection.ReturnValue;

        com.Parameters.Add(p1);

        com.Connection.Open();

        try
        {
            com.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.SelectCommand = com;
            dataAdapter.Fill(dataTable);
            com.Dispose();

            if (dataTable.Rows.Count > 0)
            {
                var accountID = dataTable.Rows[0]["AccountID"];

                var branchID = dataTable.Rows[0]["BranchID"];

                accountNumber.Text = Convert.ToString(accountID);
                sortCode.Text = Convert.ToString(branchID);

            }
            else
            {
                lblError.Text = "error";
            }
        }
        catch (Exception ex)
        {
            lblError.Text = Convert.ToString(ex);
            throw new Exception("Error " + ex.Message);
        }
    }




    public static double getx()
    {

        return displayBalance;
    }

    protected void withdraw_Click(object sender, EventArgs e)
    {
        ba.setWithdraw(Convert.ToDouble(TextBox1.Text));
        balanceLabel.Text = "£" + Convert.ToString(ba.getBalance());
    }




    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
}

