using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Invoice
    {
    
        private int _account { get; }
        private string _customer { get; }
        private string _provider { get; }

        private string _article { get; set; }
        private double _quantity { get; set; }
        public double sum { get; set; }
        public double NDS { get; set; }


        public Invoice (int Account, string Customer, string Provider)
        {
            _account = Account;
            _customer = Customer;
            _provider = Provider;
        }

        public void VAT(double Price)
        {
            sum = Price * _quantity;
            NDS = sum * 1.2;

        }

    }
}
