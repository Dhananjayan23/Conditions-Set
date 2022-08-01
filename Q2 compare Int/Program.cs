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
            #region 2



            ////int num1 = GetInteger("Enter a Number");
            ////int num2 = GetInteger("Enter a Number");
            ////Console.WriteLine(ComInt(num1,num2));
            #endregion
            #region 3
            //float number1 = GetFloat("Enter a Number");
            //float number2 = GetFloat("Enter a Number");
            //Console.WriteLine(SameOrNotSame(number1,number2));

            #endregion
            #region 4
            //int n = GetInteger("Enter the number: ");
            //Console.WriteLine(IsEven(n));

            #endregion
            #region 5
            //int year = GetInteger("Enter the year: ");
            //Console.WriteLine(IsLeapYear(year));

            #endregion
            #region 6
            //float height = GetFloat("Enter the height in cm: ");
            //Console.WriteLine(IsTallOrMedOrShort(height));

            #endregion
            #region 7
            //float height = GetFloat("Enter Your height");
            //Console.WriteLine(IsTallOrMedOrShort(height));
            #endregion
            #region 8
            //int num1 = GetInteger("Enter a Number");
            //int num2 = GetInteger("Enter a Number");
            //int num3 = GetInteger("Enter a Number");
            //Console.WriteLine(LargeAmongThree(num1, num2, num3) + " is the largest");


            #endregion





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
        public static string ComInt(int a, int b)
        {

            return a == b ? "same" : "not same";

        }
        public static string SameOrNotSame(float A, float B)
        {
            return Math.Abs(A - B) <= 0.5 ? "Same" : "Notsame";
        }
        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        public static bool IsTypicalLeapYear(int yr)
        {
            return yr % 4 == 0;
        }
        public static bool IsATypicalLeapYear(int yr)
        {
            return yr % 100 == 0 && yr % 400 != 0;
        }
        public static bool IsLeapYear(int yr)
        {
            return IsTypicalLeapYear(yr) && !(IsATypicalLeapYear(yr));
        }
        public static string IsTallOrMedOrShort(float cm)
        {
            return cm >= 170 ? "Tall" : (cm >= 150 ? "medium" : "short");

        }
        public static float GetFloat(string message)
        {
            PrintMessage(message);
            float number = float.Parse(Console.ReadLine());
            return number;

        }
        public static int LargeAmongThree(int a, int b, int c)
        {
            int largest = a;
            if (largest < b)
            {
                largest = b;
            }
            if (largest < c)
            {
                largest = c;
            }
            return largest; 
        }



   }

    }


