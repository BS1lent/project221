using System;

namespace CurrencyConverter
{
    class Program4
    {
        public static void Solve4()
        {
            // Входные данные
            const double RublesInDollar = 74.52;
            double amount = 0;
            bool convertToDollars = false;

            // Ввод данных пользователем
            Console.Write("Введите сумму: ");
            amount = double.Parse(Console.ReadLine());

            Console.Write("Вы хотите пересчитать сумму в рублях (1) или в долларах (2): ");
            int convert = int.Parse(Console.ReadLine());
            convertToDollars = convert == 2;

            // Вычисление результата
            double result = convertToDollars ? amount / RublesInDollar : amount * RublesInDollar;

            // Вывод результата
            Console.WriteLine("Результат: " + result.ToString("F2") + " " + (convertToDollars ? "$" : "₽"));
            Console.ReadLine();
        }
    }
}