using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name of employee");
            string _name = Console.ReadLine();

            Console.WriteLine("Enter Surname of employee");
            string _surname = Console.ReadLine();

            Console.WriteLine("Enter Position of employee: President, Manager or Intern");
            string Position = Console.ReadLine();

            Console.WriteLine("Enter Experience of this employee");
            double Experience = double.Parse(Console.ReadLine());

            Employee employee = new Employee(_name, _surname);

            string creds = _name + _surname;

            employee.Salary(Position, Experience);

            Console.WriteLine($"Credentials:{creds}, Position: {Position} Employee salary:{employee.res} Tax:{employee.taxPayment}");

            Console.ReadKey();
        }
    }
}
