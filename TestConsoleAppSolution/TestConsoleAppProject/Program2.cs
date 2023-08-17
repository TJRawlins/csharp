using System;

namespace TestConsoleAppProject
{
    internal class Program2
    {
        // This is a comment
        public static void GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500) 
            {
                discountPercent = .2m;
            } else
            {
                discountPercent = .1m;
            }
            Console.WriteLine(discountPercent);
        }
    }

}
