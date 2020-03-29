using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2903
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            // integer : -100, ... 0, 1, 2, 3
            // byte 0-255
            // long (large integer) : ....
            // float : 5.57
            // double : (large decimal number)
            // decimal
            // string

            int y = 8;
            int z;
            int x = 12;
            z = 10;

            Console.WriteLine(y);

            Console.WriteLine(z);

            Console.WriteLine($"z = {z}");
            //Console.WriteLine(z);

            // 1
            Console.Write("y = ");
            Console.WriteLine(y);
            // 2
            Console.WriteLine("y = " + y);
            // 3
            Console.WriteLine(String.Format("y = {0}", y));
            // 4
            Console.WriteLine($"y = {y} and x = {x} and x + y = {x + y}");

            Console.WriteLine("===================================");
            Console.WriteLine();

            long l1 = 10283836272;

            Console.WriteLine($"l1 = {l1}");

            float f1 = 8.7f; // double (64 bits) float (32 bits) explicitly
            double d1 = 9.87; // double (64 bits)
            double d2 = 9.6f; // 32 --> 64

            string name = "itay"; // string builder
            Console.WriteLine($"my name is {name}");
            //x = "itay"; // memory cell not correct format

            int a = 1;
            int b = 0;
            //int c = a / b;

            Console.WriteLine(x + y);

            /*
            Console.WriteLine("==============================");
            Console.WriteLine("Please enter a number:");
            string num1_string = Console.ReadLine();
            //int num1 = Convert.ToInt32(num1_string);
            int.TryParse(num1_string, out int num1);
            Console.WriteLine($"num1 is {num1}");

            //int.Parse()
            //int.TryParse()

            //int num1_ = Convert.ToInt32(Console.ReadLine()); // one-liner

            Console.WriteLine("Please enter a second number:");
            //string num2_string = Console.ReadLine();
            //int.TryParse(num1_string, out int num2); // define num2 inside the TryParse

            // 1 readline
            // 2 define int num2
            // 3 try parse to int
            int.TryParse(Console.ReadLine(), out int num2); // define num2 inside the TryParse

            Console.WriteLine($"num2 is {num2}");

            Console.WriteLine($"The sum of numebers is {num1} + {num2} = {num1+num2}");

            Console.WriteLine("Please enter a float number:");
            float.TryParse(Console.ReadLine(), out float num1f);
            Console.WriteLine("Please enter a second float number:");
            float.TryParse(Console.ReadLine(), out float num2f);
            Console.WriteLine($"The sum of numebers is {num1f} + {num2f} = {num1f + num2f}");
            */

            Console.WriteLine("==============================");
            Console.WriteLine("Please enter a number:");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.WriteLine("Please enter a second number:");
            int.TryParse(Console.ReadLine(), out int num2);

            //Console.WriteLine($"num1 / num2 = {num1/Convert.ToDouble(num2)}"); // 9:5 = 1.8
            //Console.WriteLine($"num1 % num2 = {num1%num2}"); // 9:3 = 3.0
            //Console.WriteLine($"num1 / num2 = {num1 / num2} {num1%num2}/{num2}"); // 9:3 = 3.0
            // 8 : 3 = 2 2/3

            // 98 -- 98 / 10 = 9
            // 98 -- 98 % 10 = 9 8/10 => 8
            
            /*
            if (num1 > num2)
            {
                // what to do it the condition is true
                Console.WriteLine($"first number {num1} is bigger than second number {num2}");
            }
            else if (num1 == num2)
            {
                // what to do it the condition is true
                Console.WriteLine($"number {num1} is equal to {num2}");
            }
            else
            {
                // if both conditions are false
                Console.WriteLine($"second number {num2} is bigger than first number {num1}");
            }
            */

            // == equal ?
            // != not equal ?
            // && and
            // || or

            // divide the bigger number with the smaller (zero not allowed)
            if (num1 == 0 || num2 == 0)
            {
                // there was a zero involved in the denominator
                Console.WriteLine("cannot divide by zero!");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"{num1}/{num2} = {num1 / Convert.ToDouble(num2)}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"{num1}/{num2} = 1");
            }
            else 
            {
                Console.WriteLine($"{num2}/{num1} = {num2 / Convert.ToDouble(num1)}");
            }

            Console.ReadLine();
        }
    }
}
