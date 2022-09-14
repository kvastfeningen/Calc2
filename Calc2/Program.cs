using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Calc2
{
    class Program: CalcClass
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();

            }
        }

        static bool MainMenu()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1)  Calculator");

            Console.Write("\n\n");

            Console.WriteLine("s)  Sluta");
            Console.WriteLine(" ");

            Console.Write("\r\nVälj en funktion: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Calculator();
                    return true;

                case "s":
                    return false;
                default:
                    return true;
            }

        }


       


        

        public static void Calculator()
        {

            bool endCalc = false;

            Console.Clear();
            Console.Write("\n\n");
            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("------------------------\n");


            while (!endCalc)
            {

                string more = "";
                Console.WriteLine("Om du vill addera flera tal, kör ++ och Enter");
                Console.WriteLine("Om du vill subtrahera flera tal, kör -- och Enter");
                more = Console.ReadLine();
                if (more == "++")
                {
                    AddSeveral();
                }
                else if (more == "--")
                {
                    SubSeveral();
                }

                else
                {

                    double num1;
                    double num2;
                    do
                    {
                        Console.WriteLine("Skriv ett nummer och tryck Enter");
                    } while (!double.TryParse(Console.ReadLine(), out num1));

                    do
                    {
                        Console.WriteLine("Skriv ett nummer och tryck Enter");
                    } while (!double.TryParse(Console.ReadLine(), out num2));

                    Console.WriteLine("Välj operator:");
                    Console.WriteLine("\t+ - Add");
                    Console.WriteLine("\t- - Subtract");
                    Console.WriteLine("\t* - Multiply");
                    Console.WriteLine("\t/ - Divide");
                    Console.Write("Your option? ");



                    switch (Console.ReadLine())
                    {

                        case "+":
                            Console.WriteLine("Resultatet blir: " + Addition(num1, num2));
                            break;
                        case "-":
                            Console.WriteLine("Resultatet blir: " + Subtraction(num1, num2));
                            break;
                        case "*":
                            Console.WriteLine("Resultatet blir: " + Multiplication(num1, num2));
                            break;
                        case "/":
                            Console.WriteLine("Resultatet blir: " + Division(num1, num2));
                            break;

                        default:
                            Console.Write("\n\n");
                            Console.WriteLine("Välj operator nästa gång! ");
                            break;
                    }
                }
                Console.Write("\n\n");
                Console.Write("Tryck s + Enter för att avsluta, eller Enter för att fortsätta: ");
                Console.Write("\n\n");
                if (Console.ReadLine() == "s") endCalc = true;


            }

        }


    }
}
