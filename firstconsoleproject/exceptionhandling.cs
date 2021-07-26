using System;
using System.Collections.Generic;
using System.Text;

namespace firstconsoleproject
{
    class exceptionhandling
    {
        int num1 = 5, num2 = 0;
        public void divide()
        {
            try
            {
                int result = num1 / num2;
                Console.WriteLine("result is{0}", result);
            }
            catch(DivideByZeroException e) { Console.WriteLine(e.Message); }
            catch (Exception e) { Console.WriteLine(e.StackTrace);Console.WriteLine( e.Message); }
        } }
    }

