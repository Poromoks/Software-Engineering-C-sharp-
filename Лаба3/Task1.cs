using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба3
{
    public class Task1
    {
        public void Quest1()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a_{0} = ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter m = ");
            int m = int.Parse(Console.ReadLine());
            int[] b = new int[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write("Enter b_{0} = ", i + 1);
                b[i] = int.Parse(Console.ReadLine());
            }

            int[] c = new int[n > m ? n : m];
            int k = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (a[i] == b[j])
                        c[k++] = a[i];

            Console.WriteLine("\nCross points:");
            for (int i = 0; i < k; i++)
                Console.Write("{0}\t", c[i]);
        }
    }
}
