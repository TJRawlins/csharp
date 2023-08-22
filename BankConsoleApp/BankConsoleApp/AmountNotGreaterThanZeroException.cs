using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp
{
    internal class AmountNotGreaterThanZeroException : Exception
{
    public decimal Amount { get; set; }
    public AmountNotGreaterThanZeroException() : base() { }
    public AmountNotGreaterThanZeroException(string message) : base(message) { }

    public AmountNotGreaterThanZeroException(decimal amount, string message) : base(message) {
        Amount = amount;
    }
    public AmountNotGreaterThanZeroException(string message, Exception exception) : base(message, exception) { }
}
}
