using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Casting
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public void Draw() { }
    }
}
