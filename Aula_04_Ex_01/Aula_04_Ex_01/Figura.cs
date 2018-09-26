using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Ex_01
{
    abstract class Figura
    {
        private int x, y;

        public Figura(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public override string ToString()
        {
            return "[" + X + ", " + Y + "]";
        }

        abstract public double Area();
        

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        
    }
}
