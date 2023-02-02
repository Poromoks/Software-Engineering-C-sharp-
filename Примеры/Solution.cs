using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Примеры;

namespace Примеры
{
    internal class Solution
    {
        static void Main()
        {
            HelloWorld helloWorld = new HelloWorld();
            Example1 example1 = new Example1();
            Example2 example2 = new Example2();
            Example3 example3 = new Example3();
            Example4 example4 = new Example4();
            Example5 example5 = new Example5();

            //helloWorld.WriteHelloWorld();
            //example1.RotateAB();
            //example2.CompareABC();
            //example3.DecreaseBy05();
            //example4.EvenNumbers();
            example5.MinA();

            Console.ReadKey();
        }
    }
}
