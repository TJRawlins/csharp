string txtMonthlyInvestment = "500.00";
string txtInterestRate = "4.75";
string txtYears = "20.0"; // This will triger the FormatException


try
{
    decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment); 
    decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate);     int years = Convert.ToInt32(txtYears);    Console.WriteLine($"Monthly Investment: {monthlyInvestment}");    Console.WriteLine($"Yearly Interest Rate: {yearlyInterestRate}%");    Console.WriteLine($"Years Of Investment: {txtYears}");}catch (FormatException) {Console.WriteLine("A format exception has occurred. Please check all entries.", "Entry Error");}catch (OverflowException) {Console.WriteLine("An overflow exception has occurred. Please enter smaller values.", "Entry Error");}catch (Exception ex)
{    Console.WriteLine(ex.Message, ex);}finally
{    Console.WriteLine("Completed"); // This always runs regardless}