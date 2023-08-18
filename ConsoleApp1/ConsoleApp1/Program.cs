int[] collection = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (var idx = 0; collection.Length < 10; idx++)
{
    var item = collection[idx];
    Console.WriteLine(item);
}

foreach (var item in collection)
{
    Console.WriteLine(item);
}