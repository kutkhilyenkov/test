using Shapes;

IShape[] shapes = { new Triangle(3, 4, 5), new Circle(10), new Triangle(6, 5, 5), new Triangle(8, 5, 5), new Circle(1) };


Console.WriteLine("All shapes:");

foreach (var shape in shapes)
    Console.WriteLine($"{shape} square={shape.Square}");

Console.WriteLine();
Console.WriteLine("Right triangles:");

foreach (var triangle in shapes.Where(s => s is Triangle t && t.IsRigth))
    Console.WriteLine(triangle);
