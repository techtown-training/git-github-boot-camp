using SimpleCalculatorLibrary;

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
                    System.Console.WriteLine(calculator.Execute(operation, x, y));
                    break;
                case "subtract":
                    operation = new Subtraction();
                    System.Console.WriteLine(calculator.Execute(operation, x, y));
                    break;
                case "multiply":
                    operation = new Multiplication();
                    System.Console.WriteLine(calculator.Execute(operation, x, y));
                    break;
                case "divide":
                    operation = new Division();
                    System.Console.WriteLine(calculator.Execute(operation, x, y));
                    break;
                default:
                    break;
            }
        }
    }
}
