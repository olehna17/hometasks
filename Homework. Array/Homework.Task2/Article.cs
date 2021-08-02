using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Task2
{
    class Article
    {

        private string[] name = new string[5];
        private string[] store = new string[5];
        private double[] price = new double[5]; 

        public Article()
        {
            name[0] = "pen"; store[0] = "Rozetka1"; price[0] = 5;
            name[1] = "book"; store[1] = "Rozetka2"; price[1] = 15;
            name[2] = "table"; store[2] = "Rozetka3"; price[2] = 500;
            name[3] = "door"; store[3] = "Rozetka4"; price[3] = 1000;
            name[4] = "flat"; store[4] = "Ukrbud"; price[4] = 500000;

        }


        public string Value(string index)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == index)
                {
                    return name[i] + "   -   " + store[i] + "   -   " + price[i];
                }
            }

            return string.Format("{0} - Article does not exist.", index);
        }

        public string Index(int n)
        {
            for (int i = n; i < name.Length; i++)
            {
                return name[i] + "   -   " + store[i] + "   -   " + price[i];
            }
            return "Error, incorrect index";
        }
    }
}

