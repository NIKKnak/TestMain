namespace Marcet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(1,"Яблоко",5,"простое яблоко", true);
            CD cd = new CD(2,"CD - R",10, "диск для записи информации","в коробке");
            TV tv = new TV(3,"Телевизор",5,"ууу БОЛЬШОЙ");

             List<Product> probuctsAll = new List<Product>();
             probuctsAll.Add(apple);
             probuctsAll.Add(cd);
             probuctsAll.Add(tv);


            Greetings greetings = new Greetings();
            greetings.GreetingStart();
            foreach (var item in probuctsAll)
            {
                Console.WriteLine(item.PrintProduct(item.Id, item.Name, item.Price, item.Description));
            }


            
        }
    }
}
