using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба3
{
    public class Task5
    {
        public void Quest5()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            bool OddNextEven = false;


            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a_{0} = ", i + 1);
                a[i] = int.Parse(Console.ReadLine());

                if (i > 0)
                    if (a[i] % 2 == 0 && Math.Abs(a[i - 1]) % 2 == 1)
                        OddNextEven = true;
            }

            Console.WriteLine("\nAns:\n");
            if (!OddNextEven)
            {
                for (int i = n - 1; i >= 0; i--)
                    if (a[i] < 0)
                        Console.Write("{0} ", a[i]);
            }
            else
            {
                for (int i = 0; i < n; i++)
                    if (a[i] > 0)
                        Console.Write("{0} ", a[i]);
            }
        }
    }
}
