using BankConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp;

    internal class Checking
{
    // COMPOSITION (different than inheritance) - Creates new instance of Account class to pull data from. Underscore indicates this is private (not required, but for better reading)
    private Account _Account { get; set; }
    private static int NextCheckNo = 100;
    public int CheckNo { get; set; } = 100;

    //NEWER WAY - get the account number from the instance
    //public int AccountNo => _Account.AccountNo;

    // OLDER WAY - easier to follow
    public int AccountNo 
    { 
        get { return _Account.AccountNo; }
    }

    public string Description
    {
        get {  return _Account.Description; }
        set { _Account.Description = value; }
    }

    public decimal Balance
    {
        get { return _Account.Balance; }
    }

    public bool WriteCheck(decimal Amount)
    {
        try
        {
            if(!Withdraw(Amount)) return false;
            var checkNo = NextCheckNo++;
            string NewTimeStamp = _Account.TimeStamp();
            Console.Write(NewTimeStamp);
            Console.WriteLine($" Check no: {checkNo} for ${Amount}");
            return true;

        }
        catch (InsufficientFundsException)
        {
            throw new InsufficientFundsException("Amount is not greater than $0!");
        }
    }

    public bool Deposit(decimal Amount)
    {
       return _Account.Deposit(Amount);
    }

    public bool Withdraw(decimal Amount)
    {
        return _Account.Withdraw(Amount);
    }

    public void Transfer(decimal Amount, Checking checking)
    {

        if(this.Withdraw(Amount))
        {
            checking.Deposit(Amount);
            string NewTimeStamp = _Account.TimeStamp();
            Console.Write(NewTimeStamp);
            Console.WriteLine(" Transfer successful");
            return;
        }
    }


    public void Print()
    {
        _Account.Print();
    }

    public Checking()
    {
        _Account = new Account();
    }
}
