using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Square
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public int Perimeter() { return Side1 + Side2; }

        public int Area() {  return Side1 * Side2; }
    }
}
