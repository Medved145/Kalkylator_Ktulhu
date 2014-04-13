using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Calkulator.BinaryOperations
{
    public static class BinaryOperationFactory
    {
        public static IBinaryOperation CreateBinaryOperation(string operationName)
        {
            switch (operationName)
            {
                case "+":
                    return new Addition();
                case"-":
                    return  new Substraction();
                case"*":
                    return new Multiplication();
                case"/":
                    return new Division();
                case "^":
                    return new Involution();
                case "√":
                    return new SquareRoot();
                default:
                    throw new ArgumentException("Неизвестная операция!", "operationName");
            }
        }
    }
}
