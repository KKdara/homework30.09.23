using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void MaxNumber(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("The biggest:" + a);
            }
            else if (a < b)
            {
                Console.WriteLine("The biggest:" + b);
            }
            else
            {
                Console.WriteLine("Wrong format");
            }
        }
        static void Change(double num1, double num2)
        {
            double buffer = num1;
            num1 = num2;
            num2 = buffer;
            Console.WriteLine($"Result: {num1}, {num2}");
        }
        static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                int result = number * Factorial(number - 1);
                return result;
                
            }
        }
        static int NOD(int c, int d)
        {
            if (d == 0)
            {
                return c;
            }
            else
            {
                return NOD(d, c % d);
            }
        }
        static int NOD(int c, int d, int f)
        {
            if ( f == 0)
            {
                return NOD(c, d);
            }
            else
            {
                return NOD(NOD(c, d), f);
            }
        }
        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return n;
            }
            else if (n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 5.1");
            Console.WriteLine("Enter the first integer:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer:");
            int b = int.Parse(Console.ReadLine());
            MaxNumber(a, b);

            Console.WriteLine("\nTask 5.2");
            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());
            Change(num1, num2);

            Console.WriteLine("\nTask 5.4");
            Console.WriteLine("Enter a number:");
            int number  = int.Parse(Console.ReadLine());
            Factorial(number);
            Console.WriteLine("Result:" + Factorial(number));

            Console.WriteLine("\nHome task 5.1");
            {
                Console.WriteLine("Enter the first integer:");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second integer:");
                int d = int.Parse(Console.ReadLine());
                NOD(c, d);
                Console.WriteLine("NOD of two integers: " + NOD(c, d));
            }
            {
                Console.WriteLine("\nEnter the first integer:");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second integer:");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the third integer:");
                int f = int.Parse(Console.ReadLine());
                NOD(c, d, f);
                Console.WriteLine("NOD of three integers: " + NOD(c, d, f));
            }

            Console.WriteLine("\nHome task 5.2");
            Console.WriteLine("Enter an integer:");
            int n = int.Parse(Console.ReadLine());
            Fibonachi(n);
            Console.WriteLine("Result: " + Fibonachi(n));


            Console.WriteLine("Press any key to continue work.");
            Console.ReadKey();
        }
    }
}
