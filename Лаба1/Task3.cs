using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    // Дано натуральное число n, действительные числа a_1, ..., a_n.
    // Вычислить:
    // a) a_1 - a_2 + a_3 - ... + (-1)^n+1 * a_n;
    // b) 2 * (a_1 + ... + a_n)^2;
    // c) sin |a_1 + ... + a_n|.
    public class Task3
    {
        public void Calculate()
        {
            byte n;
            int count = 0;
            double solutionA = 0, solutionB = 0, solutionC = 0;

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
                solutionA -= Math.Pow(-1, count + 1) * a[count];
                solutionB += a[count];
                solutionC += a[count];
                count++;
            }

            solutionB = Math.Pow(solutionB, 2) * 2;
            solutionC = Math.Sin(Math.Abs(solutionC));

            Console.WriteLine("a) {0}\nb) {1}\nc) {2:0.000}", solutionA, solutionB, solutionC);
        }
    }
}
