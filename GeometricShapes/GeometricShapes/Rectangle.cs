using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Rectangle : Quad
    {

        public int Area()
        {
            return Side1 * Side2;
        }

        // handles for just 2 sides values
        public Rectangle(int s1,int s2) : base(s1,s2,s1,s2) 
        {
            
        }
    }
}
