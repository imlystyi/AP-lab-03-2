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

            Console.Write("Введіть змінні \"a\", \"b\", \"c\" та \"x\" по черзі через крапку з комою: ");

            string[] varArray = Console.ReadLine().Split(';');

            double a = Double.Parse(varArray[0].Replace('.', ',')),
                b = Double.Parse(varArray[1].Replace('.', ',')),
                c = Double.Parse(varArray[2].Replace('.', ',')),
                x = Double.Parse(varArray[3].Replace('.', ','));

            // Спосіб 1: розгалуження в скороченій формі.
            double A;

            if (c < 0 && x != 0)
                A = (-a * x) - c;

            else if (c > 0 && x == 0)
                A = (x - a) / -c;

            else A = (b * x) / (c - a);

            // Спосіб 2: розгалуження в повній формі.
            double B;

            if (c < 0 && x != 0)
                B = (-a * x) - c;

            else
            {
                if (c > 0 && x == 0)
                    B = (x - a) / -c;

                else B = (b * x) / (c - a);
            }

            // Частина виведення.
            Console.Write($"Отримане першим спосбом значення для \"F\": {A};\n" +
                $"отримане другим способом значення для \"F\": {B}");

            Console.ReadLine();
        }
    }
}
