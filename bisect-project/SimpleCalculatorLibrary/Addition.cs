namespace SimpleCalculatorLibrary
{
    public class Addition : IOperation
    {
        public int Execute(int x, int y)
        {
            return x + y;
        }
    }
}
