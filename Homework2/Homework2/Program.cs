using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set amount");
            double sum = double.Parse(Console.ReadLine());

            Console.WriteLine("Set Currency USD");
            double _usd = double.Parse(Console.ReadLine());
            Console.WriteLine("Set Currency EUR");
            double _eur = double.Parse(Console.ReadLine());
            Console.WriteLine("Set Currency RUB");
            double _rub = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter converted currency: uah, usd, eur, rub");
            string inputCurrency = Console.ReadLine();

            Console.WriteLine("Enter currency in what you need to convert: uah, usd, eur, rub");
            string resultCurrency = Console.ReadLine();

            Converter converter = new Converter(_usd, _eur, _rub);

            if (inputCurrency == Const.cur_uah && resultCurrency != Const.cur_uah)
            {
                converter.Convert(sum, resultCurrency);
            }
            else
            {
                converter.Convertback(sum, inputCurrency);
            }

            Console.WriteLine(converter.res);

            Console.ReadKey();

        }
    }
}
