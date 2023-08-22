using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp;

// USING INHERITANCE VS COMPOSITION (SEE CHECKING CLASS)
internal class Savings : Account
{
    public decimal InterestRate { get; set; } = 0.12m;

    // Calculate and deposit interest
    public decimal CalculateInterestByMonths(int months)
    {
        var Interest = Balance * (InterestRate / 12) * months;
        Deposit(Interest);
        return Interest;
        
    }

    // call the base constructor
    public Savings() : base() {  
    }


}
