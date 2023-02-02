using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба5
{
    public class Example
    {
        static int min_element(int[,] a)
        {
            int min_elt = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < min_elt)
                        min_elt= a[i, j];
                }
            }
            return min_elt;
        }

        static void zamena(ref int[,] a)
        {
            int n = a.GetLength(1);

            for (int i = 0; i < a.GetLength(0); i++)
            {
                a[i, n - i - 1] = 0;
            }
        }

        static void print_matrica(int[,] a)
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

        public void Primer()
        {
            string line;
            char[] delimiterChars = { ' ', ',', '\t' };
            int n;
            int[,] matr;
            int i, j;

            using (StreamReader file = new StreamReader("dat.txt"))
            {
                n = int.Parse(file.ReadLine());
                matr = new int[n, n];

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
                    Console.WriteLine("2. Нахождение минимального элемента");
                    Console.WriteLine("3. Замена побочной диагонали нулями");
                    Console.WriteLine("4. Выход");
                    Console.WriteLine(" ");
                    Console.WriteLine("Введите номер пункта меню: ");

                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Печать матрицы");
                            print_matrica(matr);
                            Console.WriteLine();
                            break;

                        case "2":
                            Console.WriteLine("Мин. элемент = {0}", min_element(matr));
                            Console.WriteLine();
                            break;

                        case "3":
                            Console.WriteLine("Произведена замена");
                            zamena(ref matr);
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
