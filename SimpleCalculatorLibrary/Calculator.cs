using System;

namespace SimpleCalculatorLibrary
{
    public class Calculator
    {
        public int Execute(IOperation operation, int x, int y)
        {
            Console.WriteLine($"Executing {operation.GetType()} for x = {x} and y = {y}.");
            var result = operation.Execute(x, y);
            Console.WriteLine($"Executed {operation.GetType()} for x = {x} and y = {y}. Result was {result}.");
            return result;
        }
    }
}
