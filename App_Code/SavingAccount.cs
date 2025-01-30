using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SavingAccount
/// </summary>
public class SavingAccount: BankAccount
{
    private double annualInterestRate; 
    private double monthlyInterestRate;
    private double totalInterest;

    private SavingAccount(double startBalance, double annual_Interest_Rate) : base (initialBalance)
    {
        
        initialBalance = startBalance;
        annualInterestRate = annual_Interest_Rate;
    }

    private void calculateMonthlyInterest()
    {
        totalInterest = totalInterest + initialBalance * monthlyInterestRate;
        initialBalance = initialBalance + initialBalance * monthlyInterestRate;
    }

    private void setAnnualInterestRate(double annual_Interest_Rate)
    {
        monthlyInterestRate = annualInterestRate / 12;
    }
    
}