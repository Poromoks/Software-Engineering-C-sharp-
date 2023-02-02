using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба3
{
    public class Task3
    {
        public void Quest3()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter x_{0} = ", i + 1);
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter y = ");
            int y = int.Parse(Console.ReadLine());

            int left = 0;
            int right = n - 1;
            int mid = (right - left) / 2;
            int temp = 0;
            while (left < right)
            {
                if (x[mid] == y)
                    break;

                if (x[mid] > y)
                    right = mid + 1;
                else
                    left = mid - 1;

                temp = mid;
                mid = left + (right - left) / 2;

                if (temp == mid)
                    break;
            }

            if (temp == mid)
                Console.WriteLine("Not Found");
            else
                Console.Write("i = {0} ", mid + 1);
        }
    }
}
