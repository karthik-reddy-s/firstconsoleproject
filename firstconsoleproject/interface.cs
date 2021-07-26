using System;
using System.Collections.Generic;
using System.Text;

namespace firstconsoleproject
{
    class inter : IA
    {
        

        void ShowData()
        {
            Console.WriteLine("interface");
        }

        void IA.ShowData()
        {
            throw new NotImplementedException();
        }
    }
    class Super { public int a = 1; public int b = 3; void Get() { Console.WriteLine("happy boy"); } }
    interface IA { void ShowData(); }
}
