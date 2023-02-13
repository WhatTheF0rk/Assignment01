using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class SwapNumbers
    {
        int a, b;

        public SwapNumbers()
        {
            Console.Write("\n\nWelcome to the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("SwapNumbers App");
            Console.ResetColor();

            bool flag = true;
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\nPlease select one of the options given below:");
                sb.AppendLine("      1. Swap two numbers");
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
                    Console.Write("\nEnter first number: ");
                    a = int.Parse(Console.ReadLine());                    
                    Console.Write("\nEnter second number: ");
                    b = int.Parse(Console.ReadLine());
                    SwapUs(out a,out b);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The first element now is {a} and the second element is {b}");
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

        public void SwapUs(out int a,out int b)
        {
            int temp = this.a;
            a = this.b;
            b = temp;
        }
    }
}
