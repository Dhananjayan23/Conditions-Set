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
            #region CompareInt



            ////int num1 = GetInteger("Enter a Number");
            ////int num2 = GetInteger("Enter a Number");
            ////Console.WriteLine(ComInt(num1,num2));
            #endregion
            #region CompareFloat
            //float number1 = GetFloat("Enter a Number");
            //float number2 = GetFloat("Enter a Number");
            //Console.WriteLine(SameOrNotSame(number1, number2));

            #endregion
            #region EvenOrOdd
            //int n = GetInteger("Enter the number: ");
            //Console.WriteLine(IsEven(n));

            #endregion
            #region LeapyearOrNot
            //int year = GetInteger("Enter the year: ");
            //Console.WriteLine(IsLeapYear(year));

            #endregion
            #region HeightDetermination
            //float height = GetFloat("Enter the height in cm: ");
            //Console.WriteLine(IsTallOrMedOrShort(height));

            #endregion
            #region LargestAmongThree
            //int num1 = GetInteger("Enter a Number");
            //int num2 = GetInteger("Enter a Number");
            //int num3 = GetInteger("Enter a Number");
            //Console.WriteLine(LargeAmongThree(num1, num2, num3) + " is the largest");


            #endregion
            #region LargestAmongFour
            
            //int num1 = GetInteger("Enter a Number");
            //int num2 = GetInteger("Enter a Number");
            //int num3 = GetInteger("Enter a Number");
            //int num4 = GetInteger("Enter a Number");
            //Console.WriteLine(LargeAmongFour(num1,num2,num3,num4) + " is the largest");

            #endregion
            #region Ageforvote

            //int age = GetInteger("Enter Your Age");
            //Console.WriteLine(AgeForVote(age));
		 
	#endregion
            #region SmallAmongThree
            //int num1 = GetInteger("Enter a Number");
            //int num2 = GetInteger("Enter a Number");
            //int num3 = GetInteger("Enter a Number");
            //Console.WriteLine(SmallAmongThree(num1,num2,num3) + " is the smallest");
            #endregion
            #region CloserNumbers

            //int num1 = GetInteger("Enter a Number");
            //int num2 = GetInteger("Enter a Number");
            //int num3 = GetInteger("Enter a Number");
            //CloserNumber(num1, num2, num3);


            #endregion
            #region SortedNumbers
            
            //int num1 = GetInteger("Enter a Number");
            //int num2 = GetInteger("Enter a Number");
            //int num3 = GetInteger("Enter a Number");
            //SortedNumbers(num1, num2, num3);
            #endregion
            #region RockPaperScissors

            //RoPaSc();

            #endregion
            #region FartherNumber

            //int num1 = GetInteger("Enter a Number");
            //int num2 = GetInteger("Enter a Number");
            //int num3 = GetInteger("Enter a Number");
            //FartherNumber(num1, num2, num3);
            #endregion
            #region Triangle Formation
            
          
            //float num1 = GetFloat("Enter the angle");
            //float num2 = GetFloat("Enter the angle");
            //float num3 = GetFloat("Enter the anlge");
            //Console.WriteLine(TriangleFormation(num1,num2,num3));
            #endregion
            #region FindQuadrant
            
            //int x = GetInteger("Enter x axis");
            //int y = GetInteger("Enter y axis");
            //Console.WriteLine(Quadrant(x, y));
            #endregion
            #region Vowel or Consonant

            //Console.WriteLine("Enter a Alphabet");
            //char alphabet = char.Parse(Console.ReadLine());
            //Console.WriteLine(VowelOrCons(alphabet));
            #endregion
            #region Shapes
            
            //int sides = GetInteger("Enter the number of sides");
            //Console.WriteLine("Shape for the given sides is " + Shapes(sides));
            #endregion
            #region NameOfTheMonth

            
            //Console.WriteLine("Enter the name of the month");
            //string month = Console.ReadLine();
            //Console.WriteLine(NumberofDays(month));
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
        public static int LargeAmongFour(int a, int b, int c, int d)
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
            if (largest < d)
            {
                largest = d;
            }
            return largest;
        }
        public static bool AgeForVote(int a)
        {
            return a <= 18;
        }
        public static int SmallAmongThree(int a, int b, int c)
        {
            int smallest = a;
            if (smallest > b)
            {
                smallest = b;
            }
            if (smallest > c)
            {
                smallest = c;
            }
            return smallest;
        }
        public static void CloserNumber(int a, int b, int c)
        {
           int n1 = a;
           int n2 = b;
           int diff = Math.Abs(a - b);

           if (Math.Abs(b - c) < diff)
           {
               n1 = b;
               n2 = c;
               diff = Math.Abs(b - c);

           }
           if (Math.Abs(a - c) < diff)
           {
               n1 = a;
               n2 = c;
               diff = Math.Abs(a - c);

           }
           Console.WriteLine( n1 + " and " + n2 + " are the closest" );
           }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void SortedNumbers(int a, int b, int c)
        {
            if (a > b)
            {
                Swap(ref a, ref b);
            }
            if (b > c)
            {
                Swap(ref b, ref c);
            }
            if (b > c)
            {
                Swap(ref b, ref c);
            }
            Console.WriteLine( a + " , " + b + " , " + c + " are the sorted numbers"  );
        }
        public static void RoPaSc()
        {
            int Userchoice = GetUserChoice();
            int Aichoice = GetAiChoice();

            if (Aichoice == Userchoice)
            {
                Console.WriteLine("Draw");
            }
            if (Userchoice==1)
            {
                if ( Aichoice == 2)
                {
                    Console.WriteLine("You lose");
                }
                if (Aichoice == 3)
                {
                    Console.WriteLine("Your Won");
                }
            }
            if (Userchoice == 2)
            {
                if (Aichoice == 1)
                {
                    Console.WriteLine("You Won");
                }
                if (Aichoice == 3)
                {
                    Console.WriteLine("You Lose");
                }
            }
            if (Userchoice == 3)
            {
                if (Aichoice == 1)
                {
                    Console.WriteLine("You Lose");
                }
                if (Aichoice == 2)
                {
                    Console.WriteLine("You Won");
                }
            }
        


        }
        public static int GetUserChoice()
        {
            Console.WriteLine("Rock = 1 , Paper = 2 , Scissor = 3");
            return int.Parse(Console.ReadLine());
        }
        public static int GetAiChoice()
        {
            Random r = new Random();
            int Aichoice = r.Next(1,4);
            return Aichoice;
        }
        public static void FartherNumber(int a, int b, int c)
        {
            int n1 = a;
            int n2 = b;
            int diff = Math.Abs(a - b);

            if (Math.Abs(b - c) > diff)
            {
                n1 = b;
                n2 = c;
                diff = Math.Abs(b - c);

            }
            if (Math.Abs(a - c) > diff)
            {
                n1 = a;
                n2 = c;
                diff = Math.Abs(a - c);

            }
            Console.WriteLine(n1 + " and " + n2 + " are farther");
        }
        public static bool TriangleFormation(float a, float b, float c)
        {
            return a + b + c == 180;
        }
        public static string Quadrant(int a, int b)
        {
            string value = " ";
            if (a > 0 && b > 0)
            {
                value = "1st Quadrant";
            }
            else if (a < 0 && b > 0)
            {
                value = "2nd Quadrant";
            }
            else if (a < 0 && b < 0)
            {
                value = "3rd Quadrant";
            }
            else if (a > 0 && b < 0)
            {
                value = "4th Quadrant";
            }
            else
            {
                value = "origin";
            }
            return value;
        }
        public static string VowelOrCons(char a)
        {
            string value = " ";

            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u' || a == 'A' || a == 'E' || a == 'I' || a == 'O' || a == 'U')
            {
                value = " Vowel ";
            }
            else
            {
                value = "Consonant";
            }
            return value;
        }
        public static string Shapes(int a)
        {
            string shape = " ";
            switch (a)
            {
                case 4:
                    shape = "Quadilateral";
                    break;

                case 5:
                    shape = "Pentagon";
                    break;

                case 6:
                    shape = "Hexagon";
                    break;
                case 7:
                    shape = "Heptagon";
                    break;
                case 8:
                    shape = "Octagon";
                    break;
                case 9:
                    shape = "Nonagon";
                    break;
                case 10:
                    shape = "Decagon";
                    break;
                default:
                    shape = "Invalid sides";
                    break;
            }
            return shape;
        }
        public static string NumberofDays(string a)
        { 
         string days = " ";
          if ( a == "January" || a == "March" || a== "May" || a== "July" || a == "August" || a == "October" || a == "December")
          {
              days = "31";
          }
          else if (a == "january" || a == "march" || a == "may" || a == "july" || a == "august" || a == "october" || a == "december")
          {
              days = "31";
          }
          else if ( a == "February")
          {
              days = "28";
          }
          else if (a == "february")
          {
              days = "28";
          }
          else
          {
              days = "30";
          }
            return days;
        }



}
        }


        






   

    


