

using Project_Sensey.Classes;
using Project_Sensey.Classes.Inheritence;

class Program
{
    public static void Main()
    {
        BankAccount bankAccount = new BankAccount(50000);

        Console.WriteLine("Initial Balance: " + bankAccount.Balance);

        bankAccount.Withdraw(50000);
        Console.WriteLine("First Withdraw Balance: " + bankAccount.Balance);

        Console.WriteLine("--------------------------------------");

        QA qa = new QA(10000);
        Console.WriteLine("QA Salary: " + qa.Salary);
        Console.WriteLine("QA Bonus: " + qa.Bonus);

        Developer developer = new Developer(15000);
        Console.WriteLine("Developer Salary: " + developer.Salary);
        Console.WriteLine("Developer Bonus: " + developer.Bonus);
             

    }
}
