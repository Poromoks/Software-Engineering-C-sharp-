using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    // Даны натуральное число n, целые числа p, q, a_1, ..., a_n;
    // p > q >= 0;
    // В последовательности a_1, ..., a_n заменить нулями члены, модуль которых при делении на p даёт в остатке q.
    public class Task4
    {
        public void Module()
        {
            byte n;
            int p, q, count = 0;

            Console.Write("Введите n: ");
            n = byte.Parse(Console.ReadLine());

            Console.Write("Введите p: ");
            p = int.Parse(Console.ReadLine());

            Console.Write("Введите q: ");
            q = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            if (n == 0)
            {
                Console.WriteLine("Значение n должно быть >0");
                return;
            }

            while (count < n)
            {
                Console.Write("Введите a[{0}]: ", count);
                a[count] = int.Parse(Console.ReadLine());
                if (Math.Abs(a[count]) % p == q)
                    a[count] = 0;
                Console.WriteLine("Результат равен {0}", a[count]);
                count++;
            }
        }
    }
}
