using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        //static void Greet()
        //{
        //    Console.WriteLine("Good morning");
        //}

        //static int Sum(int x, int y) {
        //return x + y;
        //}
        static void Main(string[] args)
        {
            //this is importent for debuging
            //int num = 45;
            //string inp = Console.ReadLine();
            //Console.WriteLine(inp);
            /*Console.WriteLine("Hello word");
            Console.Write("hello Shatadal");
            Console.WriteLine("I love c#");
            Console.WriteLine("The number is: " + num);*/

            //int a = 34;
            //float b = 34.67f;
            //double c = 35.5d;
            //bool d = false;
            //char e = 'a';
            //string f = "hello";
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.ReadLine();
            // casting
            // 1.implecit casting
            //char to int to long to float to double
            //int a = 1;
            //double b = a;
            //float c = 'b';
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //

            //2. explacit casting
            //int a1 = (int)5.6;
            //Console.WriteLine(a1);
            //float varr = Convert.ToInt32(45.6);
            //string sx = "Random string";

            //taking input
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("hey hello "+name);
            //Console.Write("How many candis do you want: ");
            //string name2 = Console.ReadLine();
            //Console.WriteLine("You will get four more candis "+(Convert.ToInt32(name2)+4));
            //


            /* opretors in c#
             1. Arithmatic 
            2. Assigment
            3. logical
            4. comparsion
             */

            //Arithmatic
            //int a = 1;
            //int b = 2;
            //Console.WriteLine(a + b);f
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);

            //Assigment
            //int a = 1;
            //int b = a;
            //b += 4;
            //Console.WriteLine(b);

            //logical opertor
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //comprasion operator
            //Console.WriteLine(344 > 34); 
            //Console.WriteLine(344 < 34); 
            //Console.WriteLine(344 >= 34); 
            //Console.WriteLine(344 <= 34);
            //Console.WriteLine(344 != 34);
            //Console.WriteLine(5 == 5);

            //Math class
            //int a = Math.Max(1, 4);
            //int a = Math.Min(1, 4);
            //double a = Math.Sqrt(41);
            //int a = Math.Abs(-41);
            //Console.WriteLine(a);

            //string

            //string hello = "Hey my name is been";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(string.Concat(hello,"You are nice"));

            //string name = Console.ReadLine();
            //string candis = Console.ReadLine();
            //Console.WriteLine($"Your name is { name}. You will get {candis} candis");

            //string hello = "Hey my name is been";
            //Console.WriteLine(hello[0]);
            //Console.WriteLine(hello[1]);
            //Console.WriteLine(hello[2]);
            //Console.WriteLine(hello[3]);
            //Console.WriteLine(hello.IndexOf("been"));
            //Console.WriteLine(hello.Substring(1));

            //condition
            //Console.WriteLine("Enter your age: ");
            //string str = Console.ReadLine();

            //int age = Convert.ToInt32(str);
            //if (age > 18)
            //{
            //    Console.WriteLine("You can drive");
            //}
            //else
            //{
            //    Console.WriteLine("Your can't deive");
            //}

            //int age = 20;
            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("please wait for an year");
            //        break;
            //    case 20:
            //        Console.WriteLine("your are 20");
            //        break;
            //    default:
            //        Console.WriteLine("enjoy");
            //        break;
            //}

            //loops in c#

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} 
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //}
            //while (i < 5);
            //for (int i = 0; i < 100; i++) { 
            //Console.WriteLine(i);
            //}


            //break and continue


            //methods or function
            //Greet();
            //Console.WriteLine(Sum(1, 2));

            // oops class and object

            Player Been = new Player();
            Console.WriteLine(Been.getHealth());
            Been.setHealth(50);
            Console.WriteLine(Been.getHealth());
            Console.WriteLine(Been.name);

            


            Console.ReadLine();
        }
    }
}
