using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_compare_Int
{
    class Program
    {
        static void Main(string[] args)
        {
                int num1 = GetInteger("Enter a Number");
                int num2 = GetInteger("Enter a Number");
                bool value = CompareInt(num1, num2);
        }



        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static int GetInteger(string message)
        {
            PrintMessage(message);
            int number = int.Parse(Console.ReadLine());
            return number;

        }
        public static bool CompareInt(int a, int b)
        {
            return a == b;

        }
    }
}
