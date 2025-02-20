using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CurrentAccount
/// </summary>
public class CurrentAccount: BankAccount
{
    double interest;
    double charges;
    double overdraftLimit;

    public CurrentAccount(double startBalance) : base(initialBalance)
    {
        initialBalance = startBalance;
        overdraftLimit = 200;
    }

    public double setInterest()
    {
        
        charges = getBalance()+overdraftLimit;
        interest = Math.Abs(charges * 0.02 * 12);//200*0.02*12

        return interest;
    }

     public new double getBalance(){

        return initialBalance;
    }

    public double getOverdraftLimit()
    {

        return overdraftLimit;
    }

}