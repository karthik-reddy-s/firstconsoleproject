using System;
using System.Collections.Generic;
using System.Text;

namespace firstconsoleproject
{
    class loop
    {
        //public void UseWhile()
        //{
        //    Console.WriteLine("enter a number for loop");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    while (num > 0)
        //    {
        //        Console.WriteLine(num);
        //        num--;
        //    }
        //}
        //public void UseDoWhile()
        //{
        //    Console.WriteLine("enter a number for doloop");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    do
        //    {

        //        Console.WriteLine(num);
        //        num--;
        //    } while (num > 0);
        //    }
        //public int UseForLoop()
        //{
        //    Console.WriteLine("enter a number for forloop");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    int f = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        f = f * i;
        //        Console.WriteLine(f);
        //    }
        //    return f;

        //}
        //public void UseForEach()
        //{

        //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    foreach (var item in arr)
        //    {

        //        Console.WriteLine(item);
        //    }
        //}
        //    public void UsePalindrome()
        //    {
        //    Console.WriteLine("enter a string for palindrome");
        //        string san = Console.ReadLine();
        //        int num4 = san.Length;
        //        int flag = 0;
        //    for (int i = 0; i < num4 / 2; i++)
        //    {
        //        if (san[i] == san[num4 - 1 - i])
        //        {
        //            flag = 1;
        //        }
        //        else
        //        {
        //            flag = 0;
        //        }
        //    }
        //        if (flag == 1)
        //        {
        //            Console.WriteLine("palindrome");

        //        }
        //        else
        //        {
        //            Console.WriteLine("not a palindrome");
        //        }
        //        }
        //    }
        public void UseFibonaci()
        {
            Console.WriteLine("enter the levelvalue for fibonaci series");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int n1 = 0; int n2 = 1; int n3;
            for (int i = 0; i <=num5; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n1);
                n1 = n2;
                n2 = n3;
                
            }
           

        }
        public string UseIfElseIf(int a)
        {
            Console.WriteLine("enter a value for a");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 10)
            {
                return "a is greater than 10";

            }
            else if(a<10)
            { 
                return "a is lees  to 10";
            }
            else
            {
                return "a is equal to 10";
            }
            
        }
        public void UseSwitch(char a)
        {
            switch (a)
            {
                case '+':
                    Console.WriteLine("Enter 2 values");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int num3 = num1 + num2;
                    Console.Write("addition value is");
                    Console.WriteLine(num3);
                    break;
                case '-':
                    Console.WriteLine("Enter 2 values");
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    int num5 = Convert.ToInt32(Console.ReadLine());
                    int num6 = num4 - num5;
                    Console.Write("subtraction  value is");
                    Console.WriteLine(num6);
                    break;
                case '/':
                    Console.WriteLine("Enter 2 values");
                    int num7 = Convert.ToInt32(Console.ReadLine());
                    int num8 = Convert.ToInt32(Console.ReadLine());
                    int num9 = num7 / num8;
                    Console.Write("divison value is");
                    Console.WriteLine(num9);
                    break;
                case '*':
                    Console.WriteLine("Enter 2 values");
                    int num10 = Convert.ToInt32(Console.ReadLine());
                    int num11 = Convert.ToInt32(Console.ReadLine());
                    int num12 = num10 * num11;
                    Console.Write("multiplication value is");
                    Console.WriteLine(num12);
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;


            }
        }
        public void UseForPrime()
        {
            Console.WriteLine("enter the value for prime number");
            int num6 = Convert.ToInt32(Console.ReadLine());
            int a1; int a2 = 0;
            a1 = num6 / 2;
            if (num6 <= 1) { Console.WriteLine("it is not a prime number"); a2 = 1; }
            for (int i = 2; i <= a1; i++)
            {
                if (num6 % i == 0)
                {
                    Console.WriteLine("it is not a prime number");
                    a2 = 1;
                    break;

                }
            }
            if (a2 == 0)
            {
                Console.WriteLine("it is a prime number");
            }
        }
        public void UseForPrimelist()
        {
            Console.WriteLine("enter the 1st value for prime number");
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("to");
            Console.WriteLine("enter the 2nd value for prime number");
            int num7 = Convert.ToInt32(Console.ReadLine());

            for (int i = num6; i <= num7; i++)
            {
                int flag = 0;
                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        
                        flag = 1;
                        break;

                    }
                }
                if (i > 1 && flag == 0)
                {
                    Console.WriteLine(+i);
                }
            }
        }
        public void UseForHcfnLcm()
        {
            Console.WriteLine("enter two values for finding hcf and lcm ");
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = Convert.ToInt32(Console.ReadLine());

            int a1 = num7;int a2 = num8;int a3;

            while (num8 != 0)
            {
                a3 = num8;
                num8 = num7 % num8;
                num7 = a3;
            }
            int gcd = num7;
            int lcm = (a1 * a2) / gcd;
            Console.WriteLine(gcd);
            Console.WriteLine(lcm);




        }
        public void UseForComb()
        {
            Console.WriteLine("enter a two numbers for forcomb");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            int f = 1; int h = 1; int c = n - r; int j = 1;int k = 1;int l = 1;
            for (int i = 1; i <= n; i++)
            {f = f * i;}
            for (int i = 1; i <= r; i++)
            {h = h * i;} 
            for (int i = 1; i <= c; i++)
            {j = j * i;}
            k= (f / (h * j));
            l = (f / j);
            Console.WriteLine("permutation of 2 nos is ");
            //npr=(fact n)/(fact (n-r));
            Console.WriteLine(l);
            Console.WriteLine("combination of 2 nos is ");
            //ncr=(fact n)/((fact r)*(fact (n-r)));
            Console.WriteLine(k);

        }
        public void UseTernary(int a,int b)
        {
            string result=a>b?"a is bigger":"b is bigger";
            Console.WriteLine(result);
        }
       public void UseForBubble() 
        {
            
            int[] a = {2,8,-1,6 };
            int b;
            for(int p = 0; p < a.Length - 1; p++) {
                for (int i = 0; i < a.Length - 1; i++)
                {

                    if (a[i] > a[i + 1])
                    {
                        b = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = b;
                    }
                } 
            }foreach(int aa in a)
            Console.WriteLine(aa+"");
        }
        public void Bubble2()
        {
            int[] a = { 3, 0, 2, 5, -1, 4, 1 };
            int t;
            Console.WriteLine("Original array :");
            foreach (int aa in a)
                Console.Write(aa + " ");
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int aa in a)
                Console.Write(aa + " ");
            Console.Write("\n");
        }
        public void UseHL()
        {
            int a, b,c,d,e,f,g;
            Console.WriteLine("enter the number of heads");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of legs");
            b = Convert.ToInt32(Console.ReadLine());
            
            c = a * 2;
            d = b - c;
            e = c - d;
            f = e / 2;
            g = a - f;
            
            if ((b % 2 == 0) | (a % 2 == 0))
            {
                Console.Write("the no of chickens are:");
                Console.WriteLine(f);
                Console.Write("the no of rabits are:");
                Console.WriteLine(g);
            }
            else
            {
                
                Console.WriteLine("it is invalid data");
            }
        }

        public void UseBank()
        {
            int a, b, c, d, e;
            Console.WriteLine("enter the account number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the balance in account");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the required loan amount");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the no of EMIs");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the salary");
            e = Convert.ToInt32(Console.ReadLine());
            
            if ((a >  999) && (a <=1999))
            {
                if (b < 1000) { Console.WriteLine("minimum balance is less"); }
                else
                {
                    if (e >= 2500 && e < 50000)
                    {
                        if ((c <= 500000) | (d <= 36))
                        {
                            Console.WriteLine("account number is" + a);
                            Console.WriteLine("the eligible loan amount is" + 500000);
                            Console.WriteLine("the requested loan amount is" + c);
                            Console.WriteLine("the eligible no of EMIs is" + 36);
                            Console.WriteLine("the requested no of EMIs is" + d);
                        }
                        else { Console.WriteLine("sorry,not eligible"); }
                    }
                    else if (e >= 50000 && e < 75000)
                    {
                        if ((c <= 6000000) | (d <= 60))
                        {
                            Console.WriteLine("account number is" + a);
                            Console.WriteLine("the eligible loan amount is" + 6000000);
                            Console.WriteLine("the requested loan amount is" + c);
                            Console.WriteLine("the eligible no of EMIs is" + 60);
                            Console.WriteLine("the requested no of EMIs is" + d);
                        }
                        else { Console.WriteLine("sorry,not eligible"); }
                    }
                    else if (e >= 75000)
                    {
                        if ((c <= 7500000) | (d <= 84))
                        {
                            Console.WriteLine("account number is" + a);
                            Console.WriteLine("the eligible loan amount is" + 7500000);
                            Console.WriteLine("the requested loan amount is" + c);
                            Console.WriteLine("the eligible no of EMIs is" + 84);
                            Console.WriteLine("the requested no of EMIs is" + d);
                        }
                        else { Console.WriteLine("sorry,not eligible"); }
                    }
                    else { Console.WriteLine("sorry,something went wrong"); }
                }
            }
            else { Console.WriteLine("Account number not valid"); }

        }

        }
        }

        

    


