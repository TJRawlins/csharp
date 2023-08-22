
using BankConsoleApp;
using System.Xml.Linq;

//var acctChecking = new Account();
//var acctSavings = new Account();

//acctSavings.Deposit(500);
//acctSavings.Withdraw(313);
//acctSavings.Transfer(187, acctChecking);
//acctChecking.Withdraw(200);
//acctSavings.Deposit(-100);

//acctChecking.Transfer(287, acctSavings);

//acctChecking.Print();
//acctSavings.Print();


var chk1 = new Checking();
var chk2 = new Checking();
var sav1 = new Savings();   

chk1.Description = "Checking Account";
chk1.Deposit(300);
chk1.Withdraw(50);
chk1.WriteCheck(25);
chk1.Transfer(100, chk2);
chk1.Withdraw(500);

chk2.Description = "Slush Fund";

sav1.Description = "Savings Account";
sav1.Deposit(400);
sav1.Withdraw(50);


chk1.Print();
chk2.Print();
sav1.Print();