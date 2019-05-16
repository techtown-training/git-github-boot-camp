using SimpleCalculatorLibrary;
using System;

namespace SimpleCalculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = GetOperation(args[0]);
            var x = int.Parse(args[1]);
            var y = int.Parse(args[2]);
            var calculator = new Calculator();

            System.Console.WriteLine(calculator.Execute(operation, x, y));
        }
        
        private static IOperation GetOperation(string operationSign)
        {
            switch (operationSign.ToLower())
            {
                case "add":
                    return new Addition();
                case "subtract":
                    return new Addition();
                case "multiply":
                    return new Multiplication();
                case "divide":
                    return new Division();
                default:
                    throw new ArgumentException("Operation unknown");
            }
        }
    }
}
