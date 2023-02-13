using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class SimpleCalculator
    {
        double a;
        double b;

        public SimpleCalculator()
        {
            Console.Write("\n\nWelcome to the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Simple Calculator Console Application");
            Console.ResetColor();

            bool flag = true;
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\nPlease select an operation from the options given below:");
                sb.AppendLine("      1. Addition");
                sb.AppendLine("      2. Subtraction");
                sb.AppendLine("      3. Multiplication");
                sb.AppendLine("      4. Division");
                sb.AppendLine("      5. Exit this App");
                Console.Write(sb.ToString());
                Console.ResetColor();


                Console.Write("\nEnter choice number: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 5)
                {
                    flag = false;
                    Console.WriteLine("Exiting the App...");
                    continue;
                }
                else if (choice < 1 || choice > 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nEnter a valid choice...");
                    Console.ResetColor();
                    continue;
                }
                
                Console.Write("Enter first number: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                b = double.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"\nSum is: {Addition(a, b)}");
                        break;
                    case 2:
                        Console.WriteLine($"\nDifference is: {Subtraction(a, b)}");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Note: The difference will always be positive due to use of Math.Abs");
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.WriteLine($"\nProduct is: {Multiplication(a, b)}");
                        break;
                    case 4:
                        Console.WriteLine($"\nQuotient is: {Division(a, b)}");
                        
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Note: For sake of creativity, the quotient will always be greater than 1 due to use of ternary operator to find the greater dividend");
                        Console.ResetColor();
                        break;
                }
            }
        }

        public double Addition(double a, double b)
        {
            return a + b;
        }
        public double Subtraction(double a, double b)
        {
            return Math.Abs(a - b);
        }        
        public double Multiplication(double a, double b)
        {
            return a * b;
        }        
        public double Division(double a, double b)
        {
            return ((a / b) >= 1)? a/b : b/a ;
        }
    }
}
