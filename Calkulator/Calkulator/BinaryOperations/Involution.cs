using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calkulator.BinaryOperations
{
    class Involution : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Pow(first, second);
            return result.ToString();
        }
    }
}
