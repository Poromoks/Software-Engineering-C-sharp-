using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба5
{
    public class Task
    {
        static float Max_element(float[,] a)
        {
            float product = 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                float max_elt = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max_elt)
                        max_elt = a[i, j];
                }
                product *= max_elt;
            }
            return product;
        }

        static void Division(ref float[,] a)
        {
            float product = 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                float max_elt = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max_elt)
                        max_elt = a[i, j];
                }
                product *= max_elt;
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] /= product;
                }
            }
        }

        static void Print_matrica(float[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} \t", a[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Task23()
        {
            string line;
            char[] delimiterChars = { ' ', ',', '\t' };
            int n, m;
            float[,] matr;
            int i, j;

            using (StreamReader file = new StreamReader("dat.txt"))
            {
                n = int.Parse(file.ReadLine());
                m = int.Parse(file.ReadLine());
                matr = new float[n, m];

                for (i = 0; (i < n) && (line = file.ReadLine()) != null; i++)
                {
                    string[] numbers = line.Split(delimiterChars);
                    j = 0;

                    foreach (string numString in numbers)
                    {
                        int x;
                        bool canConvert = int.TryParse(numString, out x);

                        if (canConvert == true)
                        {
                            matr[i, j] = x;
                            j++;
                        }
                    }
                }

                string choice = "0";

                while (choice != "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Печать матрицы");
                    Console.WriteLine("2. Нахождение произведения максимальных элементов строк");
                    Console.WriteLine("3. Деление матрицы на произведение");
                    Console.WriteLine("4. Выход");
                    Console.WriteLine(" ");
                    Console.WriteLine("Введите номер пункта меню: ");

                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Печать матрицы");
                            Print_matrica(matr);
                            Console.WriteLine();
                            break;

                        case "2":
                            Console.WriteLine("Произведение = {0}", Max_element(matr));
                            Console.WriteLine();
                            break;

                        case "3":
                            Console.WriteLine("Матрица поделена");
                            Division(ref matr);
                            break;

                        case "4":
                            Console.WriteLine("До свидания!");
                            break;

                        default:
                            Console.WriteLine("Введите 1, 2, 3 или 4");
                            Console.WriteLine();
                            break;
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
