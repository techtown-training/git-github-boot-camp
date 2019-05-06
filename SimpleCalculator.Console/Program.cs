using SimpleCalculatorLibrary;

namespace SimpleCalculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = args[0];
            var x = int.Parse(args[1]);
            var y = int.Parse(args[2]);
            var calculator = new Calculator();
            switch (operation.ToLower())
            {
                case "add":
                    System.Console.WriteLine(calculator.Add(x, y));
                    break;
                case "subtract":
                    System.Console.WriteLine(calculator.Subtract(x, y));
                    break;
                case "multiply":
                    System.Console.WriteLine(calculator.Multiply(x, y));
                    break;
                case "divide":
                    System.Console.WriteLine(calculator.Divide(x, y));
                    break;
                default:
                    break;
            }
        }
    }
}
