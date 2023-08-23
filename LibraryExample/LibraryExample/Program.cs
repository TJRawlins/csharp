using clib = ConsoleLibrary;

var x = 12;
var y = 4;

Console.WriteLine($"{x} + {y} = {clib.Math.Add(x,y)}");
Console.WriteLine($"{x} - {y} = {clib.Math.Sub(x, y)}");
Console.WriteLine($"{x} * {y} = {clib.Math.Mult(x, y)}");
Console.WriteLine($"{x} / {y} = {clib.Math.Div(x, y)}");
Console.WriteLine($"{x} % {y} = {clib.Math.Modulo(x, y)}");
Console.WriteLine($"{x} pow {y} = {clib.Math.Power(x, y)}");