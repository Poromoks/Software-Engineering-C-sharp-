using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Примеры
{
    // Даны целые числа a, b, c.
    // Найти максимальное из этих трёх чисел.
    public class Example2
    {
        public void CompareABC()
        {
            int a, b, c;

            Console.Write("Введите значение a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Введите значение c: ");
            c = int.Parse(Console.ReadLine());

            if ((a >= b) && (a >= c))
            {
                Console.WriteLine("Максимальное значение = {0}", a);
            }

            else
            {
                if ((b >= c) && (b >= a))
                {
                    Console.WriteLine("Максимальное значение = {0}", b);
                }

                if ((c >= a) && (c >= b))
                {
                    Console.WriteLine("Максимальное значение = {0}", c);
                }
            }
            Console.ReadKey();
        }
    }
}
