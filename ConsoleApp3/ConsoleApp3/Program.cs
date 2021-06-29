using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MyClass
    {
        public string field;
        public void Method()
        {
            Console.WriteLine(field);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello Class";
            MyClass instance = new MyClass();
            instance.field = "Hello world";

            Console.WriteLine(instance.field);

            instance.Method()
            Console.ReadKey();
        }
    }
}
