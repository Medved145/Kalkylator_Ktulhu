using System;

namespace Calkulator.BinaryOperations
{
    public class ArcCotangent : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Pow(Math.Atan(first), (-1.0));
            return result.ToString();
        }
    }
}