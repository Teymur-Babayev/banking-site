using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Employee : Person{


    private static DateTime employeeJoinedDate;

    public Employee(string firstName1, string lastName1, string addressOne1, string addressTwo1, string addressThree1, string city1, string postCode1, string county1, string country1, char mobileNumber1, char homeNumber1, string email1, DateTime dOB1, DateTime employeeJoinedDate1) : base(firstName1, lastName1, addressOne1, addressTwo1, addressThree1, city1, postCode1, county1, country1, mobileNumber1, homeNumber1, email1, dOB1)
    {
        employeeJoinedDate1 = employeeJoinedDate;
    }
        public static DateTime EmployeejoinedDate
    {
        get
        {
            return employeeJoinedDate;
        }

        set
        {
            employeeJoinedDate = value;
        }
    }

}
