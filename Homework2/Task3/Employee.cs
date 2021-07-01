using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Employee
    {
        private string _name { get; set; }
        private string _surname { get; set; }
        public double res { get; set; }
        public double taxPayment { get; set; }


        public Employee(string Name, string Surname)
        {
            _name = Name;
            _surname = Surname; 
        }
        public void Salary(string Position, double Expirience) // 
        {
            double calc = 0;
            switch (Position)
            {
                case PositionTax.director:
                    calc = PositionTax.salaryDirector * (Expirience);
                    break;
                case PositionTax.manager:
                    calc = PositionTax.salaryManager * (Expirience);
                    break;
                case PositionTax.intern:
                    calc = PositionTax.salaryIntern * (Expirience);
                    break;
                default:
                    Console.WriteLine("You entered invalid position in our company");
                    break;
            }
            taxPayment = calc * PositionTax.Tax;
            res = calc * 0.8;
        }
    }
}
