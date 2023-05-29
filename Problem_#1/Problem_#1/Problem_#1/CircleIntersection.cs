using System.Xml.Serialization;

public class CircleIntersection
{
    public static bool CirclesIntersect(Circle circle1, Circle circle2)
    {   
        float distance = (float)Math.Sqrt(Math.Pow(circle2.X - circle1.X, 2) + Math.Pow(circle2.Y - circle1.Y, 2)); //cálculo de distância euclidiana para saber a distância entre o centro dos círculos.
        
        float radiusSum = circle1.Radius + circle2.Radius;
        
        return distance <= radiusSum; //Se a soma dos raios dos círculos for menor que a distância eles intersectam.
    }
}