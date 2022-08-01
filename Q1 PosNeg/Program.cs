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
            Console.WriteLine(PosNeg(number));
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
        public static string PosNeg(int a)
        {

            return a > 0 ? "postive" : (a < 0 ? "negative" : "zero");

    }
}}
