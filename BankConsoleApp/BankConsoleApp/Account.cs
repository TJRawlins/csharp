using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp
{
    internal class Account
    {
        public static string RoutingNumber { get; set; } = "123 456 789";
        private static int NextAccountNo = 1;
        public int AccountNo { get; set; }
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        
        public string TimeStamp()
        {
            var TimeStamp = Convert.ToString(DateTime.Now);
            return TimeStamp;
        }

       public bool Deposit(decimal Amount)
        {
            if(!AmountIsPositive(Amount)) return false;
            Balance += Amount;
            string NewTimeStamp = TimeStamp();
            Console.Write(NewTimeStamp);
            Console.WriteLine(" Deposit successful");
            return true;
        }

        public bool Withdraw(decimal Amount)
        {

            if (!AmountIsPositive(Amount)) return false;
            if (Balance < Amount)
            {
                throw new InsufficientFundsException(Amount, Balance, $" Balance is ${Balance}, Amount is ${Amount}: Insufficient Funds");
                //return false;
            }
            Balance -= Amount;
            string NewTimeStamp = TimeStamp();
            Console.Write(NewTimeStamp);
            Console.WriteLine(" Withdraw successful");
            return true;



        }

        // can use the class name as the type to call another instance of the class
        public void Transfer(decimal Amount, Account ToAccount) 
        {
            if(this.Withdraw(Amount))
            {
                ToAccount.Deposit(Amount);
                string NewTimeStamp = TimeStamp();
                Console.Write(NewTimeStamp);
                Console.WriteLine(" Transfer successful");
                return;
            }
            Console.WriteLine("Transfer failed!");
        }

        private bool AmountIsPositive(decimal Amount)
        {
            if (Amount > 0)
            {
                return true;
            }

            Console.WriteLine("Amount must be greater than $0.00!");
            return true;
        }

        public void Print()
        {
            Console.Write($"AccountNo = {AccountNo}, ");
            Console.Write($"Description = [{Description}], ");
            Console.WriteLine($"Balance = ${Balance}, ");
            //Console.WriteLine($"Created = {DateCreated}, ");
        }

        public Account()
        {
            // the ++ is on the right so it increments AFTER it's been assigned
            this.AccountNo += NextAccountNo++;
        }

    }
}
