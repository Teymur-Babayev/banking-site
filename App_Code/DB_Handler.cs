using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DB_Handler
/// </summary>
public class DB_Handler
{
    // static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Yasar\\Documents\\Visual Studio 2015\\Projects\\New folder\\BankingWebsite\\App_Data\\BankingData.mdf;Integrated Security=True");
    //static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Alam\\Documents\\Banking_Project\\App_Data\\BankingData.mdf;Integrated Security=True");
    static SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=D:\\Lukasz\\programming\\Online Banking website\\App_Data\\BankingData.mdf;Integrated Security = True");
    // static SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\MTSheikh\\Desktop\\BankingWebsite\\App_Data\\BankingData.mdf;Integrated Security = True");

    static SqlCommand cmd;
    static SqlDataReader dr;
    public DB_Handler()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static void saveUser(string title, string fName, string lName, string gender1, string mStatus1, string dob1, string cob1, string
                                    nationality1, string postcode1, string houseno1, string phoneno1, string email1, string addressline_2,
                                    string addressline_3, string city1, string county1, string country1, string joinedDate1, string mobile1)
    {
        try
        {


            con.Open();
            cmd = new SqlCommand("INSERT into Customer (Title, FirstName, LastName, DOB, AddressOne, AddressTwo, AddressThree, City, County, Country, PostCode, JoinedDate, Email, HomePhone, Mobile, Gender, Nationality, MaritalStatus ) Values('" + title + "' , '" + fName + "', '" + lName + "', '" + dob1 + "', '" + houseno1 + "', '" + addressline_2 + "', '" + addressline_3 + "', '" + city1 + "', '" + county1 + "', '" + country1 + "', '" + postcode1 + "', '" + joinedDate1 + "', '" + email1 + "', '" + phoneno1 + "', '" + mobile1 + "', '" + gender1 + "', '" + nationality1 + "', '" + mStatus1 + "')", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            con.Close();
        }
        catch (InvalidOperationException e)
        {
            return;
        }
    }
}
//    public static bool loginCheck(string email2, string password1)
//    {
//        string email1 = "";

//        SqlConnection myConnection = GetConnection();
//        string myQuery = "(SELECT EmailAddress FROM Register WHERE EmailAddress = '" + email2 + "' AND Password1 = '" + password1 + "')";
//        SqlConnection myCommand = new SqlConnection(myQuery, myConnection);

//        try
//        {
//            myConnection.Open();
//            myCommand.ExecuteNonQuery();
//            SqlConnection read = myCommand.ExecuteReader();
//            while (read.Read())
//            {
//                email1 = read["EmailAddress"].ToString();
//                if (email1 == "")
//                    return false;
//                else
//                    return true;


//            }

//        }

//        catch (Exception ex)
//        {
//            Console.WriteLine("Exception in DBHandler", ex);

//        }

//        return false;
//    }
//}




//INSERT into Customer (Title, FirstName, LastName, DOB, AddressOne, AddressTwo, AddressThree, City, County, Country, PostCode, JoinedDate, Email, HomePhone, Mobile, Gender, Nationality, MaritalStatus ) Values('mr' , 'alam', 'ahmed', '2016-12-12', '66', 'gipsy road', 'adhd', 'Carlise', 'Beds', 'UK', 'sadf', '2016-12-13', 'gfsdf', 2144214141, 2144214141, 'neither', 'foreign', 'dc');