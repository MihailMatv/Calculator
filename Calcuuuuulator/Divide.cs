using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcuuuuulator
{
    public class Divide : ICalculate
    {
        public bool CountEquations(decimal a, decimal b)
        {
            try
            {
                decimal result = a / b;
                Console.WriteLine($"Результат вычисления: {result}");
                return true;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нелья!");
                return false;
            }
        }
    }
}
