using System;

namespace Calkulator.SingleOperations
{
    public class NaturalLogarithm : ISingleOperation
    {
        public double Calculate(double first)
        {
            if (first <= 0)
            {
                throw new Exception("Натуральный логарифм сломался");
            }
            double result = Math.Log(first, Math.E);
            return result;
        }
    }
}