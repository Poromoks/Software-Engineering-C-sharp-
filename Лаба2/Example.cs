using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2
{
    public class Example
    {
        public void ExampleTask()
        {
            float x;
            float e;
            double slag = 1, sum = 1 / 3;
            int i = 0;

            Console.Write("x = ");
            x = float.Parse(Console.ReadLine());
            Console.Write("e = ");
            e = float.Parse(Console.ReadLine());

            Console.WriteLine("i    slag    sum");
            Console.WriteLine("{0}      {1:0.000}     {2:0.000}", i, slag, sum);

            while (Math.Abs(slag / (i + 2)) > e)
            {
                i++;
                slag = slag * (-1) * x / i;
                sum = sum + slag / (i + 2);
                Console.WriteLine("{0}      {1:0.000}     {2:0.000}", i, slag, sum);
            }
        }
    }
}
