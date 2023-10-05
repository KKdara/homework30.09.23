using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework30._09._23
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            Console.WriteLine("Array");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            int index1 = Array.IndexOf(array, num1);
            int index2 = Array.IndexOf(array, num2);
            int buffer = array[index1];
            array[index1] = array[index2];
            array[index2] = buffer;
            Console.WriteLine("\nNew array\n");
            foreach (int i in array) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press any key to continue work.");
            Console.ReadKey();
        }
    }
}
