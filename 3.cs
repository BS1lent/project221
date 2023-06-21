using System;

namespace GasStation //3
{
    class Program3
    {
        public static void Solve3()
        {
            // Входные данные
            int litersCount = 0;
            int gasolineMark = 0;
            bool hasDiscountCard = false;

            // Цены на бензин
            const double Gasoline92Price = 42.20;
            const double Gasoline95Price = 45.50;
            const double Gasoline98Price = 49.80;

            // Стоимость
            double totalPrice = 0;

            // Ввод данных пользователем
            Console.Write("Введите количество литров бензина: ");
            litersCount = int.Parse(Console.ReadLine());

            Console.Write("Введите марку бензина (92, 95 или 98): ");
            gasolineMark = int.Parse(Console.ReadLine());

            Console.Write("Есть ли у вас дисконтная карта (да/нет): ");
            string answer = Console.ReadLine();
            hasDiscountCard = answer == "да" || answer == "yes";

            // Вычисление стоимости бензина
            switch(gasolineMark)
            {
                case 92:
                    totalPrice = litersCount * Gasoline92Price;
                    break;
                case 95:
                    totalPrice = litersCount * Gasoline95Price;
                    break;
                case 98:
                    totalPrice = litersCount * Gasoline98Price;
                    break;
                default:
                    Console.WriteLine("Вы ввели недопустимую марку бензина!");
                    Console.ReadLine();
                    return;
            }

            // Учет скидки
            if (hasDiscountCard)
            {
                totalPrice *= 0.95;
            }

            // Вывод результата
            Console.WriteLine("Стоимость вашего заказа составляет: " + totalPrice.ToString("F2") + " рублей");
            Console.ReadLine();
        }
    }
}