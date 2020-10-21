using System;
using System.Collections.Generic;
using System.Text;

namespace number_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure cube = new Figure("cube");
            Console.WriteLine(cube.CalculatePerimeter());
            Console.ReadKey();
        }
    }