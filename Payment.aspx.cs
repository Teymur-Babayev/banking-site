using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Payment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }

    protected void btnPayment_Click(object sender, EventArgs e)
    {
        MakePayment();
        lblMessage.Text = "Payment made successfully";
    }

    public void MakePayment()
    {
        DateTime dt = DateTime.Today;
        string strcon = DBConnection.ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("Payment", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter p1 = new SqlParameter("transactionName", reference.Value);
        SqlParameter p2 = new SqlParameter("transactionDate", dt);
        SqlParameter p3 = new SqlParameter("paymentTotal", amount.Value);
        SqlParameter p4 = new SqlParameter("transactionTypeID", 3);
        SqlParameter p5 = new SqlParameter("fromAccount", Session["id"]);
        SqlParameter p6 = new SqlParameter("toAccount", accountNo.Value);

        var returnParameter = com.Parameters.Add("@ReturnVal", SqlDbType.Int);
        returnParameter.Direction = ParameterDirection.ReturnValue;

        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        com.Parameters.Add(p3);
        com.Parameters.Add(p4);
        com.Parameters.Add(p5);
        com.Parameters.Add(p6);

        com.Connection.Open();

        try
        {
            com.ExecuteNonQuery();
        }

        catch (Exception ex)
        {
            lblMessage.Text = Convert.ToString(ex);
            throw new Exception("Error " + ex.Message);
        }
    }
}
