namespace SimpleCalculatorLibrary
{
    class Exponentation : IOperation
    {
        public int Execute(int x, int y)
        {
            return x ^ y;
        }
    }
}
