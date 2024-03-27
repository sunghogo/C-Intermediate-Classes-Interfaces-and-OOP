namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(
                new Circle
                {
                    Width = 100,
                    Height = 100,
                    Type = ShapeType.Circle
                }
            );
            shapes.Add(
                new Rectangle
                {
                    Width = 100,
                    Height = 100,
                    Type = ShapeType.Rectangle
                }
            );
            shapes.Add(
                new Triangle
                {
                    Width = 100,
                    Height = 100,
                    Type = ShapeType.Triangle
                }
            );

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
