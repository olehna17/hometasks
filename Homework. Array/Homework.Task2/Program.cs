using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article();

            Console.WriteLine("Enter Index of goods(1-4)");
            int n = int.Parse(Console.ReadLine());

            article.Index(n);
            Console.WriteLine(article.Index(n));



            Console.WriteLine("Enter Goods name(pen, book, table, door, flat)");
            string index = Console.ReadLine();

            article.Value(index);
            Console.WriteLine("Article       Store       Price");
            Console.WriteLine(article.Value(index));

            Console.ReadKey();
            
            
        }
    }
}
