public class Circle
{
    public float X { get; set; } // coordenada x do centro do círculo
    public float Y { get; set; } // coordenada y do centro do círculo
    public float Radius { get; set; } // raio do círculo

    public Circle(float x, float y, float radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }
}
