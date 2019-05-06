﻿namespace SimpleCalculatorLibrary
{
    public class Calculator
    {
        public int Execute(IOperation operation, int x, int y)
        {
            return operation.Execute(x, y);
        }
    }
}
