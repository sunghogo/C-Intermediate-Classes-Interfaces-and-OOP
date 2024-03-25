using System.Collections;
using System.IO;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            // Upcasting, implicit coercion
            // Refers to the same object in memory, but upcasted variable is limited in view
            Shape shape = text;
            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width); // 100

            // Polymorphism uses
            // Takes a System.IO.Stream object,so can upcast FileStream or MemoryStream objects
            //var reader = new StreamReader(new FileStream());
            var reader = new StreamReader(new MemoryStream());

            // ArrayList takes in any object
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(new Text());

            // Generic list
            var anotherList = new List<Shape>();

            // Downcasting, explicit conversion using casting (causes compiler error if not convertible)
            Text text2 = (Text)shape;
            text2.FontSize = 10;

            // Using as to downcast (value becomes null if not convertible)
            // Using is to compare object classes
            var text3 = shape as Text;
            Console.WriteLine(text3 is Text);
            Console.WriteLine(text3 is Shape);
        }
    }
}
