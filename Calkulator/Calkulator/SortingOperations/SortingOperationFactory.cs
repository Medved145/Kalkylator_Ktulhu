using System;

namespace Calkulator.SortingOperations
{
    public static class SortingOperationFactory
    {
        public static ISortingOperation CreateSortingOperation(string operationName)
        {
            switch (operationName)
            {
                case ">":
                    return new SortingAscending();
                case "<":
                    return new SortingDicending();
                default:
                    throw new ArgumentException("Неизвестная операция!", "operationName");
            }
        }
    }
}
