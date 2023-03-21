
using banking;
using banking.Exceptions;

var s1 = new Savings();

s1.AccountId = "Jake";
s1.Description = "My Savings Account.";
s1.Balance = 1000;

try {
    s1.Deposit(-100);
    s1.Withdraw(10000);
}
catch (InsufficientFundsException ex) {
    Console.WriteLine(ex.Message);
}
catch (CantBeZeroException ex) {
    Console.WriteLine(ex.Message);
}



//s1.Deposit(100);
//s1.Withdraw(50);
//s1.Deposit(50);
//var interest = s1.PayInterest(3);

//Console.WriteLine($"S1 paid interest of {interest}");
Console.WriteLine($"S1 balance is {s1.Balance:C}");
