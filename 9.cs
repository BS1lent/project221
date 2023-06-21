using System;

namespace PhotoOrder
{
    class Program9
    {
        public static void Solve9()
        {
            // Входные данные
            string size = "";
            int quantity = 0;

            // Цены на печать фотографий
            const double Size9x12Price = 3.5;
            const double Size12x15Price = 5.0;
            const double Size18x24Price = 8.0;
            const double Discount = 0.1;

            // Стоимость
            double totalPrice = 0;

            // Ввод данных пользователем
            Console.Write("Введите размер фотографий (9×12, 12×15, 18×24): ");
            size = Console.ReadLine();

            Console.Write("Введите количество фотографий: ");
            quantity = int.Parse(Console.ReadLine());

            // Вычисление стоимости заказа
            switch (size.ToLower())
            {
                case "9x12":
                    totalPrice = quantity * Size9x12Price;
                    break;
                case "12x15":
                    totalPrice = quantity * Size12x15Price;
                    break;
                case "18x24":
                    totalPrice = quantity * Size18x24Price;
                    break;
                default:
                    Console.WriteLine("Некорректный размер фотографий!");
                    Console.ReadLine();
                    return;
            }

            // Учет скидки при большом количестве фотографий
            if (quantity > 20)
            {
                totalPrice = totalPrice * (1 - Discount);
            }

            // Вывод результата
            Console.WriteLine("Стоимость вашего заказа: " + totalPrice.ToString("F2") + " рублей");
            Console.ReadLine();
        }
    }
}