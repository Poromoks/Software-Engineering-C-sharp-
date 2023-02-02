using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Примеры
{
    // Даны целые числа a_1, a_2, ...
    // Известно, что a_1 > 0 и что среди a_2, a_3, ... есть хотя бы одно отрицательное число.
    // Пусть a_1, a_2, ..., a_n - члены данной последовательности, предшествующие первому отрицательному числу.
    // Найти min(a_1 + a_2, a_2 + a_3, ..., a_n-1 + a_n).
    public class Example5
    {
        public void MinA()
        {
            int pred, a, min;

            Console.Write("Введите значение a: ");
            pred = int.Parse(Console.ReadLine());

            Console.Write("Введите значение a: ");
            a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Значение минимума = {0}", pred);
                return;
            }

            min = pred + a;
            pred = a;

            Console.Write("Введите значение a: ");
            a = int.Parse(Console.ReadLine());

            while (a >= 0)
            {
                if ((a + pred) < min)
                    min = a + pred;

                pred = a;

                Console.Write("Введите значение a: ");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Значение минимума = {0}", min);
            Console.ReadKey();
        }
    }
}
