
using OOGeometricShapes;

var quad1 = new Quad(2, 5, 7, 9);

Console.WriteLine($"Quad AREA: {quad1.Area()} PERIMETER {quad1.Perimeter()}");

var rect1 = new Rect(3, 7);

Console.WriteLine($"Rectangle AREA: {rect1.Area()} PERIMETER {rect1.Perimeter()}");

var sqr1 = new Square(3);

Console.WriteLine($"Square AREA: {sqr1.Area()} PERIMETER {sqr1.Perimeter()}");