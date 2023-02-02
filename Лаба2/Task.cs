using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2
{
    public class Task
    {
        public void Task1()
        {
            float x, e;
            double slag, sum;
            int i = 0;

            Console.Write("x = ");
            x = float.Parse(Console.ReadLine());

            Console.Write("e = ");
            e = float.Parse(Console.ReadLine());

            slag = x;
            sum = x;

            Console.WriteLine("i    slag    sum");
            Console.WriteLine("{0}      {1:0.000}     {2:0.000}", i, slag, sum);

            while (Math.Abs(slag / (2 * i + 1)) > e)
            {
                i++;
                slag = slag * (-1) * Math.Pow(x, 2) / i;
                sum = sum + slag / (2 * i + 1);
                Console.WriteLine("{0}      {1:0.000}     {2:0.000}", i, slag, sum);
            }

        }
    }
}
