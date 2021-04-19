using System;
using System.IO;
using System.Linq;

namespace src
{
    class Program
    {
        private static int n;
        private static Trip[] Trips;

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размер массива: ");
                string n1 = Console.ReadLine();

                while (!Int32.TryParse(n1, out n)|| n < 0) 
                {
                    Console.WriteLine("Введите целое положительное число!");
                    Console.Write("Введите размер массива: ");
                    n1 = Console.ReadLine();
                }
                Trips = new Trip[n];
                ReadTrip();
                Sort();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }

        static public void ReadTrip()
        {
            for (int i = 0; i < n; i++)
            {
                Trips[i] = new Trip();

                Console.Write("Введите продолжительность туристической поездки №{0}: ", i + 1);
                string duration = Console.ReadLine();

                while (string.IsNullOrEmpty(duration))
                {
                    Console.Write("Введите продолжительность туристической поездки №{0}: ", i + 1);
                    duration = Console.ReadLine();
                }

                Trips[i].Duration = duration;

                Console.Write("Введите цену туристической поездки №{0}: ", i + 1);
                string price1 = Console.ReadLine();
                int price;

                while (string.IsNullOrEmpty(price1))
                {
                    Console.Write("Введите цену туристической поездки №{0}: ", i + 1);
                    price1 = Console.ReadLine();
                }

                while (!Int32.TryParse(price1, out price) || price < 0)
                {
                    Console.WriteLine("Введите целое положительное число!");
                    Console.Write("Введите цену туристической поездки №{0}: ", i + 1);
                    price1 = Console.ReadLine();
                }

                Trips[i].Price = price;

                Console.Write("Введите размер туристической группы №{0}: ", i + 1);
                string number_of_people1 = Console.ReadLine();
                int number_of_people;

                while (string.IsNullOrEmpty(number_of_people1))
                {
                    Console.Write("Введите размер туристической группы №{0}: ", i + 1);
                    number_of_people1 = Console.ReadLine();
                }

                while (!Int32.TryParse(number_of_people1, out number_of_people) || number_of_people < 0)
                {
                    Console.WriteLine("Введите целое положительное число!");
                    Console.Write("Введите размер туристической группы №{0}: ", i + 1);
                    number_of_people1 = Console.ReadLine();
                }

                Trips[i].Number = number_of_people;
            }
        }
        static public void Sort()
        {
            Trips = Trips.AsQueryable<Trip>().OrderBy(a => a.Price).ThenBy(a => a.Number).ToArray();

            Console.WriteLine("Отсортировано!");
        }
    }
}
