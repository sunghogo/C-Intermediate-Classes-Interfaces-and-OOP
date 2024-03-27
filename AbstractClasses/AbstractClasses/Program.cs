namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cannot instantiate abstract classes as objects
            //var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
