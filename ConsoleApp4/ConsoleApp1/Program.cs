using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Author");
            string text1 = Console.ReadLine();
            Console.WriteLine("Enter Title");
            string text2 = Console.ReadLine();
            Console.WriteLine("Enter Content");
            string text3 = Console.ReadLine();
            Author author = new Author { Text = text1 };
            Title title = new Title { Text = text2 };
            Content content = new Content { Text = text3 };
            Book book = new Book(author, title, content);

            book.Show();

            Console.ReadKey();
        }
    }
}
