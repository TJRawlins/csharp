using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Square : Rectangle
    {
        // passes one side param and use that one param as the 2 base params
        public Square(int s1) : base(s1,s1)
        {

        }

    }
}
