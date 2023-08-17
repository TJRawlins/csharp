// See https://aka.ms/new-console-template for more information
using TestConsoleAppProject;

Console.WriteLine("Hello, World!");

// While loop with a counter
int j = 0;
while (j < 5)
{
    Console.WriteLine("Count a: " + j);
    j++;
}

// For loop on array
int[] arr = new int[] {5,3,7,8,9,3,2};
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Count b: " + arr[i]);
}

// Create a randum number
var random = new Random();
int num = random.Next(1, 800);
Console.WriteLine(num.ToString());

// Get today's date
DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime.ToString());

// String array
string[] names = { "Tony", "Greg", "Megan", "Josh", "David", "Grant", "Drew" };
Console.WriteLine(names[0]);

// Create instance of a class
Program2 pgm2 = new Program2();

// Call a class function
decimal d = 5000.58m;
Console.WriteLine(d.ToString());
Program2.GetDiscountPercent(d);

//Allow int to be nullable - all datatypes nullable by default
int? n = null;

//Interpolation - Like template literal
string s = $"This is a string with {n}";

//Verbatum - don't have to escape special characters
string s2 = @"C:\filename.xyz";


// Increment: ++i increments first then assinged, i++ increments after it's assigned
int o = 5;
int p = o++;
Console.WriteLine($"o = {o}, p {p}");

//Modulo
var a = 11 % 3; // a is 2
var b = 6 % 2; // b is 0
var c = 17 % 2 == 0; // c is 1 so FALSE!

// LAMDA with LINQ
int[] ints = { 1, 2, 3, 4, 5 };
// returns all the odd numbers into
// a new collection called odds
var odds = ints.Where(i => i % 2 == 0);

