using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    public class Task5
    {
        public void Min()
        {
            byte n;
            int count = 0;
            double min = double.MaxValue;

            Console.Write("Введите n: ");
            n = byte.Parse(Console.ReadLine());

            double[] a = new double[n];

            if (n == 0)
            {
                Console.WriteLine("Значение n должно быть >0");
                return;
            }

            while (count < n)
            {
                Console.Write("Введите a[{0}]: ", count);
                a[count] = double.Parse(Console.ReadLine());
                if (Math.Pow(a[count], 3) < min)
                    min = Math.Pow(a[count], 3);
                count++;
            }

            Console.WriteLine("min = {0}", min);
        }
    }
}
