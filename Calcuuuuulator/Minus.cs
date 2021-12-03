using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcuuuuulator
{
    public class Minus : ICalculate
    {
        public bool CountEquations(decimal a, decimal b)
        {
            decimal result = a - b;
            Console.WriteLine($"Результат вычитания: {result}");
            return true;
        }
    }
}
