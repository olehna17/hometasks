using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Converter
    {

        private double _usd { get; set; }
        private double _eur { get; set; }
        private double _rub { get; set; }
        public double res { get; set; }

        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public void Convert(double sum, string curr)
        {
            double cof = 0;
            switch (curr)
            {
                case Const.cur_usd:
                    cof = _usd;
                    break;

                case Const.cur_eur:
                    cof = _eur;
                    break;

                case Const.cur_rub:
                    cof = _rub;
                    break;
                default:
                    Console.WriteLine("YUH V SRAKU");
                    break;
            }

            res = sum / cof;
        }      

        public void Convertback(double sum, string curr)
        {
            double cof = 0;
            switch (curr)
            {
                case Const.cur_usd:
                    cof = _usd;
                    break;

                case Const.cur_eur:
                    cof = _eur;
                    break;

                case Const.cur_rub:
                    cof = _rub;
                    break;
                default:
                    Console.WriteLine("YUH V SRAKU");
                    break;
            }

            res = sum * cof;
        }

    }
}
