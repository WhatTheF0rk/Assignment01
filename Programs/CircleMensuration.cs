using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class CircleMensuration
    {
        double r, area, c;
        public CircleMensuration()
        {
            Console.Write("\n\nWelcome to the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("CircleMensuration App");
            Console.ResetColor();

            bool flag = true;
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\nPlease select an operation from the options given below:");
                sb.AppendLine("      1. Find Area");
                sb.AppendLine("      2. Find Circumference");
                sb.AppendLine("      3. Find Both");
                sb.AppendLine("      4. Exit this app");
                Console.Write(sb.ToString());
                Console.ResetColor();


                Console.Write("\nEnter choice number: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 4)
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

                Console.Write("Enter the radius of the circle: ");
                r = double.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"\nArea of the circle is: {Area(r)}");
                        break;
                    case 2:
                        Console.WriteLine($"\nCircumference of the circle is: {Circumference(r)}");
                        break;
                    case 3:
                        Console.WriteLine($"\nArea of the circle is: {Area(r)}");
                        Console.WriteLine($"Circumference of the circle is: {Circumference(r)}");
                        break;
                }
            }
        }

        public double Area(double r)
        {
            return Math.PI * r * r;
        }
        public double Circumference(double r)
        {
            return 2 * Math.PI * r;
        }
    }
}
