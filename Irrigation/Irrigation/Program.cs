
using Irrigation;

var Pine = new Plant("Pine Tree", 35);

Console.WriteLine($"Plant: {Pine.Name} GAL: {Pine.GalPerWeek} GPM: {Pine.GalPerMonth()} GPY: {Pine.GalPerYear()}");
