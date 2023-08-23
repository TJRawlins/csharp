using System.Threading.Channels;

// List
/*
var names = new List<string>();

names.Add("Tony");
names.Add("Megan");
names.Add("Grant");
names.Add("Drew");
names.Add("David");
names.Add("Josh");

names.Remove("Josh");

foreach (var name in names)
{
    Console.Write($"{name} ");
}
Console.WriteLine();
*/



// SORTED LIST
/*
var names2 = new SortedList<string,int>();
names2.Add("Tony", 39);
names2.Add("Tom", 20);
names2.Add("Jane", 45);

foreach (KeyValuePair<string,int> name in names2)
{
    Console.WriteLine($"Name: {name.Key}, Age: {name.Value} ");
}
*/


/*
var frames = new SortedList<int,int>();
foreach (var frame in frames)
{
    var score = Console.Read();

}
*/



// DICTIONARY
/*
var dictionary = new Dictionary<int, string>();
dictionary.Add(1, "Red");
dictionary.Add(2, "White");
dictionary.Add(3, "Blue");
dictionary.Add(4, "Orange");
Console.WriteLine($"The color for 4 is {dictionary[4]}");
*/
/*
// FIRST WAY - get occurances of each number
var numbers = "6846846585443848850076817997663322135798778963311141718552227894";
// dictionary preload
var numberDictionary = new Dictionary<string, int>
{
    ["0"] = 0,
    ["1"] = 0,
    ["2"] = 0,
    ["3"] = 0,
    ["4"] = 0,
    ["5"] = 0,
    ["6"] = 0,
    ["7"] = 0,
    ["8"] = 0,
    ["9"] = 0
};
// tunrs numbers string into an array of characters
foreach (var ch in numbers.ToCharArray())
{
    // return value for each character and increments it to get the next value
    numberDictionary[ch.ToString()]++;
}
foreach(var key in numberDictionary.Keys)
{
    Console.WriteLine($"For key {key} occurs {numberDictionary[key]} times.");
}
*/
/*
// SECOND WAY - get occurances of each number
var numbers = "68468465854438488576817997663322135798778963311141718552227894";
// dictionary preload
var numberDictionary = new Dictionary<string, int>();
// tunrs numbers string into an array of characters
foreach (var ch in numbers.ToCharArray())
{
    // determine if the key isn't in the dictionary, if not, then add it
    if (!numberDictionary.ContainsKey(ch.ToString()))
    {
        numberDictionary[ch.ToString()] = 0;
    }
    // return value for each character and increments it to get the next value
    numberDictionary[ch.ToString()]++;
}
foreach (var key in numberDictionary.Keys)
{
    Console.WriteLine($"For key {key} occurs {numberDictionary[key]} times.");
}
*/


/*
var aList = new List<int>();
// added 4 slots
aList.Add(1);
// add a range
aList.AddRange(new int[] {1,2,3,4,5 });
Console.WriteLine($"Default capacity is {aList.Capacity}");
Console.WriteLine($"Default capacity is {aList.Count}");
*/


