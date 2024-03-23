using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point() { }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Overloaded methods
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Call other methods instead of repeating code
        // Defensive programming with checking for null exception
        public void Move(Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            Move(newLocation.X, newLocation.Y);
        }
    }
}
