using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        Author Author { get; set; }
        Title Title { get; set; }
        Content Content { get; set; }
        public Book(Author author, Title tutle, Content content)
        {
            Author = author;
            Title = tutle;
            Content = content;
        }

        public void Show()
        {
            Author.Show();
            Title.Show();
            Content.Show();
        }
    
      


    }
}
