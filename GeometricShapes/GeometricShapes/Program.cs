
using GeometricShapes;
/*
var quad1 = new Quad()
{
    Side1 = 3,
    Side2 = 4,
    Side3 = 5,
    Side4 = 6
};

var perimeter = quad1.Perimeter();
Console.WriteLine($"Quad1 perimeter is {perimeter}");

var rect1 = new Rectangle() { Side1 = 3, Side2 = 5 };
Console.WriteLine($"Rect1 perimeter is {rect1.Perimeter()}, Area is {rect1.Area()}");

var square = new Square() { Side1 = 5};
Console.WriteLine($"Square perimeter is {square.Perimeter()}, Square is {square.Area()}");
*/

var quad1 = new Quad( 3, 4, 5, 6 );


var rect1 = new Rectangle(3,5);
Console.WriteLine(rect1.Area());
Console.WriteLine(rect1.Perimeter());
