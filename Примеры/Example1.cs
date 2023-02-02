using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Примеры
{
    // Даны две целые переменные a, b.
    // Составить программу, после исполнения которой значения перменных поменялись бы местами.
    public class Example1
    {
        public void RotateAB()
        {
            int a, b, d;

            Console.Write("Введите значение a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            b = int.Parse(Console.ReadLine());

            d = a;
            a = b;
            b = d;

            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.ReadKey();
        }
    }
}
