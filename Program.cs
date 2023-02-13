using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Assignment01
{
    public class Master
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Currently Running: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Assignment01");
            
            bool flag = true;
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\n\nPlease enter a choice from the given menu:");
                sb.AppendLine("      1. Simple Calculator");
                sb.AppendLine("      2. Highest Marks Finder");
                sb.AppendLine("      3. Sum of Array Elements");
                sb.AppendLine("      4. Swap two numbers");
                sb.AppendLine("      5. Area and Circumference of a Circle");
                sb.AppendLine("      6. Book Management System");
                sb.AppendLine("      7. Exit");
                Console.WriteLine(sb.ToString());
                Console.ResetColor();
            
                int choice;
                Console.Write("\nEnter your choice: ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            new SimpleCalculator();
                            break;
                        case 2:
                            new HMF();
                            break;
                        case 3:
                            new ArrElementSum();
                            break;
                        case 4:
                            new SwapNumbers();
                            break;
                        case 5:
                            new CircleMensuration();
                            break;
                        case 6:
                            new BMS();
                            break;
                        case 7:
                            flag = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Enter a number between [1-7]");
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Enter a valid integer");
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nThanks for using the app ;)\nExiting the program...");
            Console.ReadKey();
        }
    }
}
