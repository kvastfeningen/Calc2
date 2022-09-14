using System;
using System.Collections.Generic;
using System.Text;

namespace Calc2
{
    public class CalcClass
    {
        public static double Addition(double x, double y)
        {
            double result = x + y;
            return result;
        }

        static double Addition(double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
                result += numbers[i];
            return result;
        }

        public static double Subtraction(double x, double y)
        {
            return x - y;
        }

        static double Subtraction(double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
                result -= numbers[i];
            return result;
        }

        public static double Multiplication(double x, double y)
        {
            return x * y;
        }
        public static double Division(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                Console.WriteLine("Försök inte dela med 0, det blir alltid 0!: ");
                return 0;
            }
            else
            {
                return x / y;
            }

        }

        public static void AddSeveral()
        {
            int arrSize = 0;

            do
            {
                Console.WriteLine("Hur många tal vill du addera?");
            } while (!int.TryParse(Console.ReadLine(), out arrSize));


            double[] numbers = new double[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                //  while (!double.TryParse (numbers[i]), out double inumbers[i])
                //  {
                Console.Write("Skriv ett nummer {0}: ", i + 1);

                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Resultatet blir: " + Addition(numbers));

        }

        public static void SubSeveral()
        {
            int arrSize = 0;

            do
            {
                Console.WriteLine("Hur många tal vill du subtrahera?");
            } while (!int.TryParse(Console.ReadLine(), out arrSize));


            double[] numbers = new double[arrSize];
            for (int i = 0; i < arrSize; i++)
            {

                Console.Write("Skriv ett nummer {0}: ", i + 1);

                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Resultatet blir: " + Subtraction(numbers));

        }
    }
}
