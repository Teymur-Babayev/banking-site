using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Person{

    private static String firstName;
    private static String lastName;
    private static String addressOne;
    private static String addressTwo;
    private static String addressThree;
    private static String city;
    private static String postCode;
    private static String county;
    private static String country;
    private static Char mobileNumber;
    private static Char homeNumber;
    private static String email;
    private static DateTime dOB;


    public Person(String firstName1, String lastName1, String addressOne1, String addressTwo1,
                 String addressThree1, String city1, String postCode1, String county1, String country1,
                 Char mobileNumber1, Char homeNumber1, String email1, DateTime DOB1)
    {

        firstName1 = FirstName;
        lastName1 = LastName;
        addressOne1 = AddressOne;
        addressTwo1 = AddressTwo;
        addressThree1 = AddressThree;
        city1 = City;
        postCode1 = PostCode;
        county1 = County;
        country1 = Country;
        mobileNumber1 = MobileNumber;
        homeNumber1 = HomeNumber;
        email1 = Email;
        DOB1 = DOB;



    }

   

    protected static string FirstName
    {
        get
        {
            return firstName;
        }

        set
        {
            firstName = value;
        }
    }

    protected static string LastName
    {
        get
        {
            return lastName;
        }

        set
        {
            lastName = value;
        }
    }

    protected static string AddressOne
    {
        get
        {
            return addressOne;
        }

        set
        {
            addressOne = value;
        }
    }

    protected static string AddressTwo
    {
        get
        {
            return addressTwo;
        }

        set
        {
            addressTwo = value;
        }
    }

    protected static string AddressThree
    {
        get
        {
            return addressThree;
        }

        set
        {
            addressThree = value;
        }
    }

    protected static string City
    {
        get
        {
            return city;
        }

        set
        {
            city = value;
        }
    }

    protected static string PostCode
    {
        get
        {
            return postCode;
        }

        set
        {
            postCode = value;
        }
    }

    protected static string County
    {
        get
        {
            return county;
        }

        set
        {
            county = value;
        }
    }

    protected static string Country
    {
        get
        {
            return country;
        }

        set
        {
            country = value;
        }
    }

    protected static char MobileNumber
    {
        get
        {
            return mobileNumber;
        }

        set
        {
            mobileNumber = value;
        }
    }

    protected static char HomeNumber
    {
        get
        {
            return homeNumber;
        }

        set
        {
            homeNumber = value;
        }
    }

    protected static string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
        }
    }

    protected static DateTime DOB
    {
        get
        {
            return dOB;
        }

        set
        {
            dOB = value;
        }
    }

   

}