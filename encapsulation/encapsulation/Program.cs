BankAccount account = new BankAccount("Paul", 123321);
Console.WriteLine(account.Owner);
Console.WriteLine(account.Balance);
account.writeOff(1200);
Console.WriteLine(account.Balance);
account.replenishment(1599);
Console.WriteLine(account.Balance);