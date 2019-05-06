using SimpleCalculatorLibrary;
using System;

namespace SimpleCalculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var operationSign = args[0];
            var x = int.Parse(args[1]);
            var y = int.Parse(args[2]);
            var calculator = new Calculator();
            IOperation operation;
            switch (operationSign.ToLower())
            {
                case "add":
                    operation = new Addition();
                    break;
                case "subtract":
                    operation = new Addition();
                    break;
                case "multiply":
                    operation = new Multiplication();
                    break;
                case "divide":
                    operation = new Division();
                    break;
                default:
                    throw new ArgumentException("Operation unknown");
            }

            System.Console.WriteLine(calculator.Execute(operation, x, y));
        }
    }
}
