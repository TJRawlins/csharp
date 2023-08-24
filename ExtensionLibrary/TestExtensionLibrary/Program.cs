// See https://aka.ms/new-console-template for more information
using ExtensionLibrary;

/*
var s = "agsKKSDFIJGHasjdf";
var sAllCaps = s.AllCaps();
var sAllSmall = sAllCaps.AllSmall();
Console.WriteLine($"{s} as all caps is {sAllCaps} and all small is {sAllSmall}");
*/

var s = "   $123,456.78";
Console.WriteLine($"{s} as a decimal is {s.ToDecimal():C}");