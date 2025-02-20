using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {

        ActivateAccount();

        lblMessage.Text = "Account Created Successfully";
     
    }

    public void ActivateAccount ()
    {
        DateTime dt = DateTime.Today;
        string strcon = DBConnection.ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("CreateAccount", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter p1 = new SqlParameter("@accountName", accountName.Value);
        SqlParameter p2 = new SqlParameter("@accountTypeID", accountType.Value);
        SqlParameter p3 = new SqlParameter("@openedDate", dt);
        SqlParameter p4 = new SqlParameter("@customerID", Session["id"]);
        SqlParameter p5 = new SqlParameter("@branchID", branch.Value);


        var returnParameter = com.Parameters.Add("@ReturnVal", SqlDbType.Int);
        returnParameter.Direction = ParameterDirection.ReturnValue;

        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        com.Parameters.Add(p3);
        com.Parameters.Add(p4);
        com.Parameters.Add(p5);


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