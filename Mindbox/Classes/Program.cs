namespace Mindbox;

class Program
{
    static void Main()
    {
        var circle = new Circle(5);
        Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

        var triangle = new Triangle(3, 4, 5);
        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
        Console.WriteLine($"Прямоугольный треугольник: {triangle.IsRightAngled()}");
    }
}