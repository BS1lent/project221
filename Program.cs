using System;
using GasStation;
using CurrencyConverter;
using WindowCalculator;
using PhotoOrder;
using FreightCost;

namespace project221
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("3 = GasStation");
            Console.WriteLine("4 = CurrencyConverter");
            Console.WriteLine("8 = WindowCalculator");
            Console.WriteLine("9 = PhotoOrder");
            Console.WriteLine("13 = FreightCost");
            Console.Write("Введите желаемую программу: ");
            string input = Console.ReadLine();
            
            switch (input) {
                case "3" : Program3.Solve3(); break;
                case "4" : Program4.Solve4(); break;
                case "8" : Program8.Solve8(); break;
                case "9" : Program9.Solve9(); break;
                case "13" : Program13.Solve13(); break;
                default : Console.WriteLine("Sosi hui nazarov"); break;
            }
        }
    }
}