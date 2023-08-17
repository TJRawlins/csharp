
var quit = false;

while (!quit)
{
    Console.Write("Enter an integer: ");
    var answer = Console.ReadLine();
    Console.WriteLine($"Answer is {answer}");
    var number = Convert.ToInt32(answer);

    string evenOrOdd;

    if  (number % 2 == 0)
    {
        evenOrOdd = "EVEN";
    } else
    {
        evenOrOdd = "ODD";
    }

    Console.WriteLine($"The number {number} is {evenOrOdd}");

    Console.Write("Do you want to quit? (y/N): ");
    var quitAnswer = Console.ReadLine();
    if( quitAnswer == "Y" || quitAnswer == "y")
        {
            quit = true;
        }
}

Console.WriteLine("Done...");