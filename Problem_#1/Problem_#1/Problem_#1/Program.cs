using System;

class Program
{
    static void Main()
    {
        Circle circle1 = new Circle(0, 0, 3);
        Circle circle2 = new Circle(4, 0, 2);

        bool intersect = CircleIntersection.CirclesIntersect(circle1, circle2);
        Console.WriteLine($"Os círculos se intersectam? {intersect}");
    }
}