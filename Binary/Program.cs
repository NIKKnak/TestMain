namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //бинарный поиск
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            int x = 56;
            BinarySearch binary = new BinarySearch();
            int result = binary.BinarySearchElement(arr, x);
            if (result == -1)
                Console.WriteLine("Элемент не найден");
            else
                Console.WriteLine("Элемент найден в позиции " + result);
        }
    }
}
