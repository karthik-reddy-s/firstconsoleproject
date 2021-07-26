using System;
using System.Text;


namespace firstconsoleproject
{

    class Program
    {

        public static void Main(string[] args)
        {
            //Nqueen queen = new Nqueen();
            //queen.SolveBQ();
            //int n = 4;
            //towerOfHanoi(n, 'A', 'C', 'B');
            //int a = 5;
            //string s = "this is a string";
            //double b = 1.2;
            //bool c = true;
            //char d = 'g';
            //var e = 9.8;
            //e = 8.9;
            //dynamic f = 6;
            //f = "gogo";
            //int y = 10;
            //int z = a + y;
            //int[] num = new int[3];
            //num[0] = 3;
            //num[1] = 2;
            //num[2] = 1;

            // for(int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //int[] num1 = { 10, 20, 30 };
            //for (int i = 0; i < num1.Length; i++)
            //{
            //    Console.WriteLine(num1[i]);
            //}
            //int[] num2 = new int[3] { 40, 50, 60 };
            //for (int i = 0; i < num2.Length; i++)
            //{
            //    Console.WriteLine(num2[i]);
            //}
            // string[] solo = new string[2] { "hi", "hello" };
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(solo[i]);
            //}
            //Console.WriteLine("enter a number");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter a string");
            //string solo1 = Console.ReadLine();
            //Console.WriteLine("value is {0}", num3);
            //Console.WriteLine("value is {0}", solo1);


            // Console.WriteLine("Hello World!");
            // Console.Write("hi" );
            //Console.WriteLine(s);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);
            //Console.WriteLine("hello" + a + "" + z);
            //Console.WriteLine("{0} {1}",a ,z );

            loop lobj = new loop();
            //lobj.UseWhile();
            //lobj.UseDoWhile();
            ////int fact;
            ////fact=lobj.UseForLoop();
            ////Console.WriteLine(fact);
            //lobj.UseForLoop();
            //lobj.UseForEach();
            //lobj.UsePalindrome();
            //lobj.UseFibonaci();
            //string san=lobj.UseIfElseIf(50);
            //Console.WriteLine(san);
            // Console.WriteLine("enter an operator");
            //char opr = Convert.ToChar(Console.ReadLine());
            //lobj.UseSwitch(opr);
            // lobj.UseForPrime();
            //lobj.UseForHcfnLcm();
            //lobj.UseForComb();
            //lobj.UseForPrimelist();
            //lobj.UseTernary(5,7);
            //string str1 = "this is a string";
            //Console.WriteLine(str1.Length);
            //if (str1.Contains("is")) { Console.WriteLine("str1 contains is"); } else { Console.WriteLine("str1 doesnt contain is"); }
            //var substr = str1.Substring(5, 4);
            //Console.WriteLine(substr);


            //string str = "hello";
            //Console.WriteLine(str);
            //str = "hello world";
            //Console.WriteLine(str);
            //str = str + "first add";
            //Console.WriteLine(str);
            //str = str + "second add";
            //Console.WriteLine(str);


            //StringBuilder sb = new StringBuilder();
            //string[] solo = new string[2] { "hi", "hello" };
            //for(int i = 0; i < solo.Length; i++)
            //{

            //    sb.Append(solo[i]);
            //}
            //Console.WriteLine(sb);

            //char ch = 'a';
            //char[] chs = {'s','o','m','e' };
            //string word = new string(chs);
            //Console.WriteLine(word);
            //lobj.UseForBubble();
            //lobj.Bubble2();
            //lobj.UseHL();
            //lobj.UseBank();
            user p1 = new user(1,"ab",1234,"us",new DateTime(1990,1,1));
            //p1.GetData();
            //p1.ID();
            //p1.GetDob();
            //p1.GetContact();
            //p1.GetPlace();
            //p1.GetID();
            //p1.GetUserName();
            B p2 = new B();
            //p2.display();

            inter p3 = new inter();
            Super p4 = new Super();
            Super p5 = new B();//example
            
            
            exceptionhandling eh = new exceptionhandling();
           // eh.divide();
            collections cl = new collections();
           // cl.UseCollections();
            cl.CreateLists();
            
           
        }
        static void towerOfHanoi(int n, char first_rod, char last_rod, char middle_rod)
        {
            if (n == 1)
            {
                Console.WriteLine("move disk 1 from rod" + first_rod + "to rod" + last_rod);
                return;
            }
            towerOfHanoi(n - 1, first_rod, middle_rod, last_rod);
            Console.WriteLine("move disk" + n + "from rod" + first_rod + "to_rod" + last_rod);
            towerOfHanoi(n - 1, middle_rod, last_rod, first_rod);
        }
        

    }
}


