using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0m)
        {
            return 3.213f;
        }
        else if ((balance >= 0m) && (balance < 1000m))
        {
            return 0.5f;
        }
        else if ((balance >= 1000m) && (balance < 5000m))
        {
            return 1.621f;
        }
        else
        {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance) => (balance * (decimal)InterestRate(balance)) / 100;


    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);



    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        decimal newBalance = 0;

        newBalance += AnnualBalanceUpdate(balance);
        years++;

        while (newBalance <= targetBalance)
        {
            newBalance = AnnualBalanceUpdate(newBalance);
            years++;
        }

        return years;
    }
}