using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an article");
            string _article = Console.ReadLine();

            Console.WriteLine("Enter a price with VAT(NDS)");
            double Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter quantity");
            double _quantity = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Account //SHTO ETO REBYATA?????? ZACHEM???");
            int _account = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer");
            string _customer = Console.ReadLine();
            Console.WriteLine("Enter Provider");
            string _provider = Console.ReadLine();

            Invoice invoice = new Invoice(_account, _customer, _provider);

            invoice.VAT(Price);

            Console.WriteLine($"Sum with VAT(NDS):{invoice.sum}, Sum without VAT(NDS): {invoice.NDS}");

            Console.ReadKey();


            //ребята, пожалуйста, читайте задания которые отправляете студентам, что нужно делать с 3 полями акаунт кастомер и провайдер не понятно от слова вообще, зачем там поле артикл?
            //Исходя из конечного требования того, что программа должна выполнять - половина условия написана для красоты или же это полнейший бред который нормально не обьяснили.
        }
    }
}
