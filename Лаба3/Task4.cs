using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба3
{
    public class Task4
    {
        public void Quest4()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter x_{0} = ", i + 1);
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter y = ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAns:");

            for (int i = 0; i < n; i++)
                if (x[i] <= y)
                    Console.Write("{0} ", x[i]);

            Console.Write("|{0}| ", y);

            for (int i = 0; i < n; i++)
                if (x[i] > y)
                    Console.Write("{0} ", x[i]);
        }
    }
}
