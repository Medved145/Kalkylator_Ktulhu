﻿using System;

namespace Calkulator.BinaryOperations
{
    public class SquareRoot : IBinaryOperation
    {

         public double Calculate(double first, double second)
         {
             if (first < 0)
             {
                 throw new Exception("Корень не является собой");
             }
             double result = Math.Pow(first, 1.0/second);
             return result;
         }
    }
}
