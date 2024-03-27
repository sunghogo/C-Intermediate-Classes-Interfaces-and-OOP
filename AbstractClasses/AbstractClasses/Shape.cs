using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    // abstract keyword to define abstract classes containing abstract methods (useful for forcing a class design)
    // abstract methods must be overrided in derived classes
    // abstract classes cannot be initialized as objects
    // sealed keyword for classes and methods makes it so that they cannot be inherited
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }
}
