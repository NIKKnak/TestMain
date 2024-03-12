namespace Singlton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Launch("Windows 11","5.4");
            Console.WriteLine(comp.OS.Name);
            Console.WriteLine(comp.OS.Version);


        }
    }
}
