using System;
using System.IO; 

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
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
    }
}
