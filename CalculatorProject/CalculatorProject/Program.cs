
var stack  = new Stack<double>();

// user entry
var entry = string.Empty;
var answer = string.Empty;
//Console.Write("Enter a number, operator, C to clear or X to quit: ");
Console.Write("Enter the RPN statement: ");
answer = Console.ReadLine();

var operands = answer.Split(",");

foreach (var op in operands)
{
    double num;
    // returns boolean if it can parse
    var isNumber = double.TryParse(op, out num);
    if (isNumber)
    {
        stack.Push(num);
        continue;
    }
    var num1 = stack.Pop();
    var num2 = stack.Pop();
    var result = op switch
    {
        "+" => num2 + num1,
        "-" => num2 - num1,
        "*" => num2 * num1,
        "/" => num2 / num1,
        "^" => Math.Pow(num2,num1)
    };
    stack.Push(result);
}
var finalResult = stack.Pop();
Console.WriteLine(finalResult);

/*
do
{
    if (answer.ToLower() == "c")
    {
        stack.Clear();
        Console.WriteLine("Cleared");
    }
    else if(answer == "+")
    {
        int num1 = stack.Pop();
        int num2 = stack.Pop();
        Console.WriteLine(num1 + num2);
        stack.Push(num1 + num2);
    }
    else if (answer == "-")
    {
        int num1 = stack.Pop();
        int num2 = stack.Pop();
        Console.WriteLine(num2 - num1);
        stack.Push(num2 - num1);
    }
    else if (answer == "*")
    {
        int num1 = stack.Pop();
        int num2 = stack.Pop();
        Console.WriteLine(num1 * num2);
        stack.Push(num1 * num2);
    }
    else if (answer == "/")
    {
        int num1 = stack.Pop();
        int num2 = stack.Pop();
        Console.WriteLine(num2 / num1);
        stack.Push(num2 / num1);
    }
    else
    {
        int num = Convert.ToInt32(answer);
        stack.Push(num);
    }
    Console.Write("Enter a number, operator, C to clear or X to quit: ");
    answer = Console.ReadLine();
} while (answer.ToLower() != "x");
*/