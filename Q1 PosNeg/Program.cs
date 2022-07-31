using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_PosNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetInteger("Enter a Number");
            int value = PosNeg(number);
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
        public static int PosNeg(int a)
        {
            int number = a;
            if ( a > 0)
            { 
                Console.WriteLine("Given Number is Positive");
            }
            else if ( a<0)
            {
            Console.WriteLine("Given Number is Negative");
            }
            else
            {
                Console.WriteLine("Given Number equals zero");
            }
            return number;
    }
}}
