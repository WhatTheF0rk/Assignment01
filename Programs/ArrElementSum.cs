using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class ArrElementSum
    {
        public ArrElementSum()
        {
            Console.Write("\n\nWelcome to the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ArrElementSum App");
            Console.ResetColor();

            bool flag = true;
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\nPlease select one of the options given below:");
                sb.AppendLine("      1. Find the sum of array elements");
                sb.AppendLine("      2. Exit this app");
                Console.Write(sb.ToString());
                Console.ResetColor();


                Console.Write("\nEnter choice number: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 2)
                {
                    flag = false;
                    Console.WriteLine("Exiting the App...");
                    continue;
                }
                else if (choice == 1)
                {
                    Console.Write("\nPlease enter the array elements separated by comma: ");
                    string[] str = Console.ReadLine().Split(',');
                    SumMyElements(str);
                }
                else if (choice < 1 || choice > 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nEnter a valid choice...");
                    Console.ResetColor();
                    continue;
                }
            }
        }

        public void SumMyElements(params string[] str)
        {
            int sum = 0;
            foreach (string i in str)
            {
                sum += int.Parse(i);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sum of the given array elements is: {sum}");
        }
    }
}
