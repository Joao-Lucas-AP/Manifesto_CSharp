public class CircleIntersection
{
    public static bool CirclesIntersect(Circle circle1, Circle circle2)
    {   
        float distance = (float)Math.Sqrt(Math.Pow(circle2.X - circle1.X, 2) + Math.Pow(circle2.Y - circle1.Y, 2));
        
        float radiusSum = circle1.Radius + circle2.Radius;
        
        return distance <= radiusSum;
    }
}