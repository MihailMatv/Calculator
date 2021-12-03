using System;

namespace Calcuuuuulator
{   
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите первое число: ");
                decimal a = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Введите второе число: ");
                decimal b = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Введите один из символов * / + -  ");
                char c = Convert.ToChar(Console.ReadLine());

                var constructor = new Constructor();
                var smth = constructor.CreateCount(c);
                smth.CountEquations(a, b);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}