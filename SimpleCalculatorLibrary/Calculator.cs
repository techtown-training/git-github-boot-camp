using System;

namespace SimpleCalculatorLibrary
{
    public class Calculator
    {
        /// <summary>
        /// Executes a simple mathematical operation with two integers.
        /// </summary>
        /// <param name="operation">The operation to execute</param>
        /// <param name="x">The first number</param>
        /// <param name="y">The second number</param>
        /// <returns>An integer that is the result of the given operation.</returns>
        public int Execute(IOperation operation, int x, int y)
        {
            Console.WriteLine($"Executing {operation.GetType()} for x = {x} and y = {y}.");
            var result = operation.Execute(x, y);
            Console.WriteLine($"Executed {operation.GetType()} for x = {x} and y = {y}. Result was {result}.");
            return result;
        }
    }
}
