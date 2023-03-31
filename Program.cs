/* 
Задача 41
using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0; // счетчик чисел больше 0

        Console.Write("Введите количество чисел: ");
        int M = int.Parse(Console.ReadLine());

        for (int i = 0; i < M; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел больше 0: {count}");
    }
}

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double k1, b1, k2, b2;
        Console.Write("Введите k1: ");
        k1 = double.Parse(Console.ReadLine());

        Console.Write("Введите b1: ");
        b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите k2: ");
        k2 = double.Parse(Console.ReadLine());

        Console.Write("Введите b2: ");
        b2 = double.Parse(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
    }
}
