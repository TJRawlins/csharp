using LoopsProject;

int[] collection = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

/*
// ---> Typical way to iterate through collection
for (var idx = 0; collection.Length < 10; idx++)
{
    var item = collection[idx];
    Console.WriteLine(item);
}
*/

/*
// ---> Better way to iterate through collection, unless you need to preset an index condition
foreach (var item in collection)
{
    Console.WriteLine(item);
}
*/


int[] nbrs = {
754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
435, 643, 809, 874, 906, 620, 328, 369, 426, 561
};

// ---> FOREACH LOOP
/*
int maxNbrs = int.MinValue;
int minNbrs = int.MaxValue;

foreach (var item in nbrs)
{
    if(item > maxNbrs)
    {
        maxNbrs = item;
    } else if (item < maxNbrs && item < minNbrs)
    {
        minNbrs = item;
    }
}

Console.WriteLine($"The max num is {maxNbrs} and min num is {minNbrs}");
*/

// ---> FOREACH LOOP
/*
int totalNbr = 0;

foreach (var item in nbrs)
{
    totalNbr += item;
}

Console.WriteLine($"The average num is {totalNbr / nbrs.Length}");
*/

// WHILE LOOP
/*
int num = 1;
while (num <= 25)
{
    if (num % 2 == 1)
    {
        Console.WriteLine($"Odd number {num} cubed is {num * num * num}");
    } 
    num += 2;
}
*/

// ---> SWITCH STATEMENT - Older way
/*
var stateCode = "OH";
var stateName = "";

switch (stateCode)
{
    case "OH": 
        stateName = "Ohio"; 
        break;
    case "KY": 
        stateName = "Kentucky"; 
        break;
    case "IN": 
        stateName = "Indiana"; 
        break;
    case "AZ": 
        stateName = "Arizona"; 
        break;
    case "CA": 
        stateName = "California"; 
        break;
    default: 
        stateName = "Unknown"; 
        break;
}

Console.WriteLine(stateName);
*/


// ---> SWITCH EXPRESSION - Newer way
/*
var stateCode = "IN";
var stateName = "";

stateName = stateCode switch
{
    "OH" => "Ohio",
    "KY" => "Kentucky",
    "IN" => "Indiana",
    _ => "Unknown"
};
Console.WriteLine(stateName);
*/

// ---> TERNARY
/*
bool colorIsRed = false;
var colorName = (colorIsRed == true) ? "Red" : "Black";
*/

// ---> FIZZBUZ excersize
/*
for (int i = 0; i <= 30; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    { 
        Console.WriteLine($"{i} FIZZBUZZ");
        continue;
    } else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} BUZZ");
        continue;
    } else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} FIZZ");
        continue;
    }
}
*/

// Construct new instance of class object (constructor)
var megan = new Student("Megan");

var tony = new Student("Tony", "AZ");
tony.ChangeName("Anthony");

var david = new Student("David");

var greg = new Instructor();

// change a static property
Student.CohortNumber = 40;

// call static method from class object
Student.Print("This is a static method display"); 

Console.WriteLine($"ID [{david.Id}] Name is [{david.Name}] State is [{david.State}] Cohort is [{Student.CohortNumber}]");
Console.WriteLine($"ID [{tony.Id}] Name is [{tony.Name}] State is [{tony.State}] Cohort is [{Student.CohortNumber}]");
Console.WriteLine($"ID [{megan.Id}] Name is [{megan.Name}] State is [{megan.State}] Cohort is [{Student.CohortNumber}]");