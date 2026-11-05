
using BankApp.Classes;
BankAccount account1 = new BankAccount("Savings", "Alex");

Console.WriteLine("Bank Account Project");
Console.WriteLine("--------------------");

Console.WriteLine("Account Name: " + account1.Name);
Console.WriteLine("Owner: " + account1.Owner);

account1.Deposit(500);
account1.ShowBalance();

account1.Withdraw(200);
account1.ShowBalance();

Console.WriteLine("Has positive balance: " + account1.HasPositiveBalance);
