using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistrationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TEST1_Click(object sender, EventArgs e)
    {
        Register();

        RegistrationEmail();      
    }

    public void Register()
    {
        string strcon = DBConnection.ConnectionString;

        DateTime dt = DateTime.Today;

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("Registration", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter p1 = new SqlParameter("title", title.Value);
        SqlParameter p2 = new SqlParameter("firstName", firstName.Value);
        SqlParameter p3 = new SqlParameter("lastName", surName.Value);
        SqlParameter p4 = new SqlParameter("gender", gender.Value);
        SqlParameter p5 = new SqlParameter("maritalStatus", mStatus.Value);
        SqlParameter p6 = new SqlParameter("dOB", dob.Value);
        SqlParameter p7 = new SqlParameter("birthCountry", cob.Value);
        SqlParameter p8 = new SqlParameter("nationality", nationality.Value);
        SqlParameter p9 = new SqlParameter("addressOne", houseNO.Value);
        SqlParameter p10 = new SqlParameter("addressTwo", addressLine2.Value);
        SqlParameter p11 = new SqlParameter("addressThree", addressLine3.Value);
        SqlParameter p12 = new SqlParameter("city", city.Value);
        SqlParameter p13 = new SqlParameter("county", county.Value);
        SqlParameter p14 = new SqlParameter("country", country.Value);
        SqlParameter p15 = new SqlParameter("postCode", postCode.Value);
        SqlParameter p16 = new SqlParameter("homePhone", phoneNo.Value);
        SqlParameter p17 = new SqlParameter("mobile", mobile.Value);
        SqlParameter p18 = new SqlParameter("email", txtEmail.Text);
        SqlParameter p19 = new SqlParameter("password", passwordTextBox.Text);
        SqlParameter p20 = new SqlParameter("securityq", securityq.Value);
        SqlParameter p21 = new SqlParameter("securityans", securityans.Value);
        SqlParameter p22 = new SqlParameter("joinedDate", dt);

        var returnParameter = com.Parameters.Add("@ReturnVal", SqlDbType.Int);
        returnParameter.Direction = ParameterDirection.ReturnValue;

        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        com.Parameters.Add(p3);
        com.Parameters.Add(p4);
        com.Parameters.Add(p5);
        com.Parameters.Add(p6);
        com.Parameters.Add(p7);
        com.Parameters.Add(p8);
        com.Parameters.Add(p9);
        com.Parameters.Add(p10);
        com.Parameters.Add(p11);
        com.Parameters.Add(p12);
        com.Parameters.Add(p13);
        com.Parameters.Add(p14);
        com.Parameters.Add(p15);
        com.Parameters.Add(p16);
        com.Parameters.Add(p17);
        com.Parameters.Add(p18);
        com.Parameters.Add(p19);
        com.Parameters.Add(p20);
        com.Parameters.Add(p21);
        com.Parameters.Add(p22);

        con.Open();

        com.ExecuteNonQuery();
        var result = returnParameter.Value;

        SqlDataReader rd = com.ExecuteReader();   
        errorLabel.Text = "Successful Registration.";

        //if there is already a record with same details
        if (Convert.ToString(result) == "1")
        {
          errorLabel.Text = "A record with this email already exists!";
        }    
    }

    //this method sends confirmation email
    public void RegistrationEmail()
    {        
        MailMessage message = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        string emailTo = txtEmail.Text;
        message.To.Add(new MailAddress(emailTo));
        message.Subject = "Bank Confirmation";
        message.Body = "Welcome to our bank. Thanks for registering!";

        try
        {
            smtp.Send(message);
        }
        catch (Exception ex)
        {
            emailLabel.Text = ex.Message;
        }
    }
}