
// List
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


// SortedList
var names2 = new SortedList<string,int>();
names2.Add("Tony", 39);
names2.Add("Tom", 20);
names2.Add("Jane", 45);

foreach (KeyValuePair<string, int> name in names2)
{
    Console.WriteLine($"Name: {name.Key}, Age: {name.Value} ");
}