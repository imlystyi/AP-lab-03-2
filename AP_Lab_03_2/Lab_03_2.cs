// Lab_03_2.cs
// Якубовський Владислав
// Лабораторна робота № 3.2
// Розгалуження, задане формулою: функція з параметрами.
// Варіант 24
using System;

namespace AP_Lab_03_2
{
    internal class Lab_03_2
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            double F = 0;

            Console.Write("Введіть змінні \"a\", \"b\", \"c\" та \"x\" по черзі через крапку з комою: ");

            string[] varArray = Console.ReadLine().Split(';');

            double a = Double.Parse(varArray[0].Replace('.', ',')),
                b = Double.Parse(varArray[1].Replace('.', ',')),
                c = Double.Parse(varArray[2].Replace('.', ',')),
                x = Double.Parse(varArray[3].Replace('.', ','));

            // Спосіб 1: розгалуження в скороченій формі.
            if (c < 0 && x != 0)
                F = (-a * x) - c;

            if (c > 0 && x == 0)
                F = (x - a) / -c;

            if ((c > 0 && x != 0) || (c < 0 && x == 0))
                F = (b * x) / (c - a);

            Console.Write($"Отримане першим спосбом значення для \"F\": {F};\n");

            // Спосіб 2: розгалуження в повній формі.
            if (c < 0 && x != 0)
                F = (-a * x) - c;

            else
            {
                if (c > 0 && x == 0)
                    F = (x - a) / -c;

                else F = (b * x) / (c - a);
            }

            Console.Write($"отримане другим способом значення для \"F\": {F}");

            Console.ReadLine();
        }
    }
}
