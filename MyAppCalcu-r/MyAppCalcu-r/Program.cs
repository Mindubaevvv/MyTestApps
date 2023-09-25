using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppCalcu_r
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome my user ! *****");
            Console.WriteLine("Enter your name, please:");
            string name = Console.ReadLine();
            Console.WriteLine(name.ToUpper());
            string again = "yes";
            while (again == "yes")
            {
                double number1;
                double number2;
                string oper;
                double result;

                Console.WriteLine("Enter your first number: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your operator '+', '-', '*', '/': ");
                oper = Console.ReadLine();

                Console.WriteLine("Enter your second number, please: ");
                number2 = Convert.ToDouble(Console.ReadLine());

                switch (oper)
                {
                    case "+":
                        result = number1 + number2;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{number1} + {number2} = {result}");
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{number1} - {number2} = {result}");
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{number1} * {number2} = {result}");
                        break;
                    case "/":
                        result = number1 / number2;
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"{number1} / {number2} = {result}");
                        if (number2 == 0)
                        {
                            Console.WriteLine("Error!");
                        }
                        break;
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Do you want continue ? 'yes' or 'no'");
                again = Console.ReadLine();
                Console.Clear();

                if (again == "no")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("The end program!");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                
            }
        }
    }
}
