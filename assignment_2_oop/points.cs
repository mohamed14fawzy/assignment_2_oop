using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_oop
{
    public struct point
    {
        public int X;
        public int Y;

        public point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X} , {Y})";
        }
    }

}
