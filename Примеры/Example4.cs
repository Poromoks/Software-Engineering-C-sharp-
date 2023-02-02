using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Примеры
{
    // Даны натуральное n и целые числа a_1, ..., a_n.
    // Найти количество чётных членов последовательности.
    public class Example4
    {
        public void EvenNumbers()
        {
            byte    n;
            int     a;
            int     count, even_n;

            Console.Write("Введите значение n: ");
            n = byte.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Значение n должно быть >0");
                return;
            }

            count = 0;
            even_n = 0;

            while (count < n)
            {
                Console.Write("Введите значение a: ");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                    even_n++;
                count++;
            }

            Console.WriteLine("Количество чётных чисел = {0}", even_n);
            Console.ReadKey();
        }
    }
}
