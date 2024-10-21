// See https://aka.ms/new-console-template for more information


using Enscapsulation;

Saving bankSaving = new Saving();
bankSaving.setBalance(1000);
Console.WriteLine(bankSaving.getBalance());

Stocks stock = new Stocks();
//tidak bisa access interestRate karena interestRate adalah protected
