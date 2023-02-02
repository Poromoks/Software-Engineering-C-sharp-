using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    // Треугольник задан координатами своих вершин.
    // Найти площадь и периметр треугольника.
    public class Task1
    {
        public void Triangle()
        {
            double a1, a2, b1, b2, c1, c2;

            Console.WriteLine("Введите координаты: ");
            Console.Write("a1: ");
            a1 = double.Parse(Console.ReadLine());
            Console.Write("a2: ");
            a2 = double.Parse(Console.ReadLine());
            Console.Write("b1: ");
            b1 = double.Parse(Console.ReadLine());
            Console.Write("b2: ");
            b2 = double.Parse(Console.ReadLine());
            Console.Write("c1: ");
            c1 = double.Parse(Console.ReadLine());
            Console.Write("c2: ");
            c2 = double.Parse(Console.ReadLine());

            double[] pointA = new double[2] {a1, a2}; // координаты
            double[] pointB = new double[2] {b1, b2};
            double[] pointC = new double[2] {c1, c2};

            double a = Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2)); // стороны
            double b = Math.Sqrt(Math.Pow(pointC[0] - pointB[0], 2) + Math.Pow(pointC[1] - pointB[1], 2));
            double c = Math.Sqrt(Math.Pow(pointC[0] - pointA[0], 2) + Math.Pow(pointC[1] - pointA[1], 2));

            double P = a + b + c; // периметр
            double p = P / 2; // полупериметр
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // площадь

            Console.WriteLine("Площадь треугольника = {0}, Периметр треугольника = {1:0.000}", S, P);
        }
    }
}
