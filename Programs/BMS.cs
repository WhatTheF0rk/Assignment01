using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class BMS
    {
        public struct Book
        {
            string bookId;
            string title;
            float price;
            string totb;
            enum bookType
            {
                Magazine,
                Novel,
                ReferenceBook,
                Miscellaneous
            }

            public void SetDetails(string bookId, string title, float price, int c)
            {
                this.bookId = bookId;
                this.title = title;
                this.price = price;
                totb = Convert.ToString((bookType)c);
            }
            public void GetDetails()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"BookId: {bookId}");
                sb.AppendLine($"Title: {title}");
                sb.AppendLine($"Price: {price}");
                sb.AppendLine($"Book Type: {totb}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(sb.ToString());
                Console.ResetColor();
            }
        }
        public BMS()
        {
            Console.Write("\n\nWelcome to the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("BMS App");
            Console.ResetColor();

            Book b = new Book();
            bool flag = true;
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\nPlease select an operation from the options given below:");
                sb.AppendLine("      1. Enter Book Details");
                sb.AppendLine("      2. Retrieve Book Details");
                sb.AppendLine("      3. Exit this app");
                Console.Write(sb.ToString());
                Console.ResetColor();


                Console.Write("\nEnter choice number: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 3)
                {
                    flag = false;
                    Console.WriteLine("Exiting the App...");
                    continue;
                }
                else if (choice < 1 || choice > 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nEnter a valid choice...");
                    Console.ResetColor();
                    continue;
                }
                //r = double.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the Book ID: ");
                        string bookId = Console.ReadLine();
                        Console.Write("Enter the title of the book: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter the price of the book: ");
                        float price = float.Parse(Console.ReadLine());
                        Console.Write("Enter the type of the book:\n  1. Magazine\n  2. Novel\n  3. ReferenceBook\n  4. Miscellaneous\n\nEnter your choice: ");
                        int c = int.Parse(Console.ReadLine());

                        b.SetDetails(bookId, title, price, --c);
                        break;
                    case 2:
                        b.GetDetails();
                        break;
                }
            }
        }
    }
}
