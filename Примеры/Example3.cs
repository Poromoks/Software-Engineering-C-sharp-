using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Примеры
{
    // Даны натуральное n и действительные числа a_1 -> a_n.
    // Все члены этой последовательности, начиная с первого положительного, уменьшить на 0,5.
    public class Example3
    {
        public void DecreaseBy05()
        {
            byte    n;
            double  a;
            int     count;

            Console.Write("Введите значение n: ");
            n = byte.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Значение n должно быть >0");
                return;
            }

            Console.Write("Введите значение a: ");
            a = double.Parse(Console.ReadLine());
            count = 1;

            while ((count < n) && (a <= 0))
            {
                Console.Write("Введите значение a: ");
                a = double.Parse(Console.ReadLine());
                count++;
            }

            if (a > 0)
            {
                a -= 0.5;
                Console.WriteLine("Изменённое значение a = {0}", a);

                while (count < n)
                {
                    Console.Write("Введите значение a: ");
                    a = double.Parse(Console.ReadLine());
                    count++;
                    a -= 0.5;
                    Console.WriteLine("Изменённое значение a = {0}", a);
                }

            }
            Console.ReadKey();
        }
    }
}
