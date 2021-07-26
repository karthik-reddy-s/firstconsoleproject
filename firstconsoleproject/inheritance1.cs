using System;
using System.Collections.Generic;
using System.Text;

namespace firstconsoleproject
{
    class inheritance1
    {
         public int a=1;public int b = 3;
    }
    class B : Super
    {
        public void display()
        {
           
            Console.WriteLine("values of a & b{0},{1}", a, b);
        }
    }
}
