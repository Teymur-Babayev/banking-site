using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SendEmail_Click(object sender, EventArgs e)
    {

        if(TextBox1.Text != "")
        {
            SendMail();
        }
        else
        {
            lblmessage.Text = "Please enter something!";
        }
    }

    public void SendMail()
    {
        string email = TextBox1.Text;

        MailMessage message = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        string emailTo = email;
        try
        {
            message.To.Add(new MailAddress(emailTo));
        }
        catch
        {
            lblmessage.Text = "not valid email";
        }

        message.Subject = "Password Reset";
        string link = String.Format("<a href=\"http://localhost:54158/ResetPassword\">Click here to reset your password.</a>");
        //message.Body = "Please click the following link to reset your banking password" + Environment.NewLine + "<a href=\"ResetPassword.aspx>";
        message.Body = link;
        message.IsBodyHtml = true;
        try
        {
            smtp.Send(message);
            lblmessage.Text = "Email sent - Please check your email";
        }
        catch (Exception ex)
        {
            lblmessage.Text = "Please enter a valid email";
        }
    }
}