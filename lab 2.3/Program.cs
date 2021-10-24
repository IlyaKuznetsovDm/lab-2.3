using System;

namespace lab_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //2.3 - базовый уровень - вариант 8
                Console.WriteLine("Введите 1,2 или 3");
                double n = double.Parse(Console.ReadLine());
                double a = 0, b = 0, c = 0;
                switch (n)
                {
                    case 1: a = 3; b = 3.5; c = 1.1; break;
                    case 2: a = 3; b = 6.55; c = 6.55; break;
                    case 3: a = 0.9; b = 0.9; c = 0.9; break;
                    default: Console.WriteLine("Нет такого типа"); break;
                }
                if ((a == b) || (a == c) || (b == c))
                    Console.WriteLine("Треуголник равнобедренный");
                else
                    Console.WriteLine("Треуголник неравнобедренный");

            }
            catch (Exception)
            {
                Console.WriteLine("Введите корректно переменную");
            }
        }
    }
}
