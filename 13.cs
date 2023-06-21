using System;

namespace FreightCost
{
    class Program13
    {
        public static void Solve13()
        {
            // Входные данные
            const double PerKmCost = 10.0;
            double distance = 0;
            string includeLoading;

            Console.Write("Введите расстояние в километрах: ");
            distance = double.Parse(Console.ReadLine());

            Console.Write("Нужны ли грузчики (да/нет)? ");
            includeLoading = Console.ReadLine();

            // Расчет затрат на грузоперевозки
            double totalCost = distance * PerKmCost;

            if (includeLoading.ToLower() == "да")
            {
                const double LoadingCost = 100.0;
                totalCost += LoadingCost;
            }

            // Вывод результата
            Console.WriteLine("Затраты на грузоперевозки: " + totalCost.ToString("F2") + " рублей");
            Console.ReadLine();
        }
    }
}