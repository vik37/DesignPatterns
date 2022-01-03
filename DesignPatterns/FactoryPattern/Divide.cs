using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Divide : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine($"a / b is: {a/b}");
        }
    }
}
