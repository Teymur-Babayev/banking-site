using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                pullData();
            }
        }      
    }

    //this method pulls data in
    public void pullData()
    {
        string strcon = DBConnection.ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("MyDetails", con);
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
                var addressOne = dataTable.Rows[0]["AddressOne"];
                var addressTwo = dataTable.Rows[0]["AddressTwo"];
                var addressThree = dataTable.Rows[0]["AddressThree"];
                var homePhone1 = dataTable.Rows[0]["HomePhone"];
                var postCode = dataTable.Rows[0]["PostCode"];
                var mobile1 = dataTable.Rows[0]["Mobile"];
                var email1 = dataTable.Rows[0]["Email"];
                //space should appear between first name and last name
                Address1.Text = Convert.ToString(addressOne);
                Address2.Text = Convert.ToString(addressTwo);
                Address3.Text = Convert.ToString(addressThree);
                homePhone.Text = Convert.ToString(homePhone1);
                PostCode.Text = Convert.ToString(postCode);
                mobile.Text = Convert.ToString(mobile1);
                email.Text = Convert.ToString(email1);

            }
            else
            {
                lblError.Text = "error";
            }
        }

        catch (Exception ex)
        {
            lblError.Text = Convert.ToString(ex);
        }
    }    

    //update code within this button click
    protected void Button1_Click(object sender, EventArgs e)
    {
        UpdateDetails();
    }

    public void UpdateDetails()
    {
        string strcon = DBConnection.ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("UpdateDetails", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter p1 = new SqlParameter("@address1", Address1.Text);
        SqlParameter p2 = new SqlParameter("@address2", Address2.Text);
        SqlParameter p3 = new SqlParameter("@address3", Address3.Text);
        SqlParameter p4 = new SqlParameter("@postcode", PostCode.Text);
        SqlParameter p5 = new SqlParameter("@homePhone", homePhone.Text);
        SqlParameter p6 = new SqlParameter("@mobile", mobile.Text);
        SqlParameter p7 = new SqlParameter("@email", email.Text);

        var returnParameter = com.Parameters.Add("@ReturnVal", SqlDbType.Int);
        returnParameter.Direction = ParameterDirection.ReturnValue;

        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        com.Parameters.Add(p3);
        com.Parameters.Add(p4);
        com.Parameters.Add(p5);
        com.Parameters.Add(p6);
        com.Parameters.Add(p7);

        com.Connection.Open();

        try
        {
            com.ExecuteNonQuery();
        }

        catch (Exception ex)
        {
            lblError.Text = Convert.ToString(ex);
        }
    }
}