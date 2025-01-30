using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class StudentAccount: BankAccount
{

    double interest;
    double charges;
    double overdraftLimit;
    double startBalance;

    public StudentAccount(double balance) : base(initialBalance)
    {
        initialBalance = startBalance;
        overdraftLimit = 500;
    }

    public double setInterest()
    {

        charges = getBalance();
        interest = Math.Abs(charges * 0.02 * 12);

        return interest;
    }

    //public new double getBalance()
    //{

    //    return initialBalance;
    //}

    public double getOverdraftLimit()
    {

        return overdraftLimit;
    }
}