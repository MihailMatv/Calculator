using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcuuuuulator
{
    public class Constructor
    {
        public ICalculate CreateCount(char c)
        {
            switch (c)
            {
                case '+':
                    return new Summ();
                case '-':
                    return new Minus();
                case '*':
                    return new Multiply();
                case '/':
                    return new Divide();
            }
            return default;
        }
    }
}
