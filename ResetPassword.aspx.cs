using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResetPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //this button enables users password to be changed
    protected void Button1_Click(object sender, EventArgs e)
    {
        Reset();

        lblMessage.Text = "Your password has been updated. You will now be taken to the Login page.";
        //timer that redirects to login page after 3 seconds
        Response.AddHeader("REFRESH", "3;URL=LoginPage.aspx");           
    }

    public void Reset()
    {
        string strcon = DBConnection.ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("ResetPassword", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter p1 = new SqlParameter("@password", passwordTextBox.Text);
        SqlParameter p2 = new SqlParameter("@email", email.Text);

        var returnParameter = com.Parameters.Add("@ReturnVal", SqlDbType.Int);
        returnParameter.Direction = ParameterDirection.ReturnValue;

        com.Parameters.Add(p1);
        com.Parameters.Add(p2);

        com.Connection.Open();

        try
        {
            com.ExecuteNonQuery();
        }

        catch (Exception ex)
        {
            lblMessage.Text = Convert.ToString(ex);
        }
    }
}