
using ExceptionExamples;

// ---------- THROW EXCEPTIONS
/*
int n = 1;
int d = 0;


if (d == 0)
{ 
    var bcex = new BootcampException("Dividing by zero is a NO NO!");
    // this will show in the "View Details" of the exception pop-up
    bcex.Numerator = n;
    bcex.Denominator = d;
    // Must throw it
    throw bcex;
}

var a = n / d;
*/


// ---------- TRY CATCH - THROW EXCEPTIONS
/*
int n = 1;
int d = 0;

try
{
    // this will throw first and will go down to the last catch to general Exception message
    throw new Exception("WHY?");
    var a = n / d;
}
// if the divide by zero exception occurs, do this
catch (DivideByZeroException)
{
    Console.WriteLine("Don't divide by zero!");
}
// this base exception will catch everything else
catch (Exception)
{
    Console.WriteLine("This is a general exception!");
} 
// not normally used
finally
{
    Console.WriteLine("This is always be executed after a catch!!");
}
*/


// ---------- EXCEPTIONS THROWN LEVELS DEEP - DEBUG TRAVERSES DOWN AND UP THE TREE BEFORE IT'S CAUGHT
method1();
void method1() { 
    try
    {
    method2(); 
    } catch (Exception) { Console.WriteLine("Caught!"); }
}
void method2() { method3(); }
void method3() { method4(); }
void method4() {
    var d = 0;
    var e = 1 / d;
}













