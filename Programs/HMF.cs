using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class HMF
    {
        double[] marks = new double[5];

        public HMF()
        {
            Console.Write("\n\nWelcome to the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Highest Marks Finder App");
            Console.ResetColor();

            bool flag = true;
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\nPlease select one of the options given below:");
                sb.AppendLine("      1. Find the highest marks obtained");
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
                else if (choice == 1){
                    Console.Write("\nPlease enter marks of 5 students separated by comma: ");
                    string[] str = Console.ReadLine().Split(',');
                    Finder(str);
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

        public void Finder(string[] str)
        {
            int z = 0;
            foreach (string i in str)
            {
                marks[z++] = double.Parse(i);
            }
            double highest = marks[0];
            foreach (double mark in marks)
            {
                if (highest < mark)
                {
                    highest = mark;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Highest marks obtained were: {highest}");
        }
    }
}
