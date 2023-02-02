using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    // Дано действительное число a.
    // Вычислить f(a), если...
    // f(x) = 0 при x <= 0,
    // f(x) = x при 0 < x <= 1,
    // f(x) = x^4 в остальных случаях.
    internal class Task2
    {
        public void Func()
        {
            double a, x, f;

            Console.Write("Введите действительное число a: ");
            a = double.Parse(Console.ReadLine());

            x = a;

            if (x <= 0)
                f = 0;
            else if ((0 < x) && (x <= 1))
                f = x;
            else
                f = Math.Pow(x, 4);

            Console.WriteLine("f(a) = {0}", f);
        }
    }
}
