using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
       public static Train[] trains = new Train[3];
       static void Main(string[] args)
        {
            Console.WriteLine("Enter Arrival Point, Train Numb and Arrival time");

            for (int i = 0; i < trains.Length; i++)
            {
                CreateTrain(i);
            }
            var sorted = trains.OrderBy(t => t.TrainNumb).ToArray();


            Console.WriteLine("Enter please TrainNumber");
            int TrainNumb = int.Parse(Console.ReadLine());

            SearchTrainNumb(TrainNumb);

            Console.ReadKey();

        }

        public static void CreateTrain(int i)
        {
            Console.WriteLine("Enter Arrival Point");
            string ArrivalPoint = Console.ReadLine();

            Console.WriteLine("Enter TrainNumb");
            int TrainNumb = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ArrivalTime");
            double ArrivalTime = double.Parse(Console.ReadLine());

            var train = new Train
            {
                ArrivalPoint = ArrivalPoint,
                TrainNumb = TrainNumb,
                ArrivalTime = ArrivalTime
            };

            trains[i] = train;
            
        }

        public static void SearchTrainNumb(int TrainNumb)
        {
            foreach (var train in trains)
            {
                if  (TrainNumb == train.TrainNumb)
                {
                    Console.WriteLine($"{train.ArrivalPoint}, {train.ArrivalTime}, {train.TrainNumb}");
                }
            }
        }
    }
}
