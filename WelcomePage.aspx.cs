using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class WelcomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }
        else
        {
            pullData();
        }     
    }

    public void pullData()
    {
        string strcon = DBConnection.ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("WelcomePage", con);
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
                var firstName = dataTable.Rows[0]["FirstName"];
                var lastName = dataTable.Rows[0]["LastName"];
                //space should appear between first name and last name
                Label1.Text = Convert.ToString (firstName) + " " + (lastName);
                
            }
            else
            {
               Label1.Text = "error";
            }
        }

        catch (Exception ex)
        {
            Label1.Text = Convert.ToString(ex);
        }
            
        
    }
}



    
