using System;

namespace WindowCalculator
{
    class Program8
    {
        public static void Solve8()
        {
            // Входные данные
            int width = 0;
            int height = 0;
            bool isTurnAndTilt = false;
            bool hasFixation = false;
            bool hasMicroVent = false;
            bool hasMosquitoNet = false;

            // Цены на опции
            const double FixationPrice = 100;
            const double MicroVentPrice = 250;
            const double MosquitoNetPrice = 400;

            // Цены на стеклопакеты
            const double SingleGlassPrice = 1000;
            const double DoubleGlassPrice = 1500;
            const double TripleGlassPrice = 2000;

            // Стоимость
            double totalPrice = 0;

            // Ввод данных пользователем
            Console.Write("Введите ширину окна в мм: ");
            width = int.Parse(Console.ReadLine());

            Console.Write("Введите высоту окна в мм: ");
            height = int.Parse(Console.ReadLine());

            Console.Write("Укажите тип механизма открывания (1 - поворотный, 2 - поворотно-откидной): ");
            int mechanismType = int.Parse(Console.ReadLine());
            isTurnAndTilt = mechanismType == 2;

            Console.Write("Есть ли у вас опции (фиксатор, микропроветривание, москитная сетка)? Да/Нет: ");
            string answer = Console.ReadLine();
            bool hasOptions = answer == "да" || answer == "yes";

            if (hasOptions)
            {
                Console.Write("Есть ли фиксатор? Да/Нет: ");
                answer = Console.ReadLine();
                hasFixation = answer == "да" || answer == "yes";

                Console.Write("Есть ли микропроветривание? Да/Нет: ");
                answer = Console.ReadLine();
                hasMicroVent = answer == "да" || answer == "yes";

                Console.Write("Есть ли москитная сетка? Да/Нет: ");
                answer = Console.ReadLine();
                hasMosquitoNet = answer == "да" || answer == "yes";
            }

            // Вычисление стоимости стеклопакета
            int glassCount = isTurnAndTilt ? 2 : 1;

            switch (glassCount)
            {
                case 1:
                    totalPrice = SingleGlassPrice;
                    break;
                case 2:
                    totalPrice = DoubleGlassPrice;
                    break;
                case 3:
                    totalPrice = TripleGlassPrice;
                    break;
            }

            // Учет опций
            if (hasFixation)
            {
                totalPrice += FixationPrice;
            }

            if (hasMicroVent)
            {
                totalPrice += MicroVentPrice;
            }

            if (hasMosquitoNet)
            {
                totalPrice += MosquitoNetPrice;
            }

            // Подсчет стоимости всех стеклопакетов
            double totalCost = (double)(width * height) / 1000000 * totalPrice;

            // Вывод результата
            Console.WriteLine("Стоимость вашего стеклопакета: " + totalCost.ToString("F2") + " рублей");
            Console.ReadLine();
        }
    }
}