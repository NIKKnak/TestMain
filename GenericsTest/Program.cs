namespace GenericsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prod1 = new Product<int>("apple", 100, 200);
            var prod2 = new Product<decimal>("banan", 50.1M, 350.0M);

            



        }
    }
}
