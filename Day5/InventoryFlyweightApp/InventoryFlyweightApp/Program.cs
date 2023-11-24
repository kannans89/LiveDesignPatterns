namespace InventoryFlyweightApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventorySystem ims = new InventorySystem();

            ims.TakeOrder("Roomba", 221);
            ims.TakeOrder("Bose Headphones", 361);
            ims.TakeOrder("Samsung TV", 432);
            ims.TakeOrder("Samsung TV", 323);
            ims.TakeOrder("Roomba", 563);
            ims.TakeOrder("Bose Headphones", 321);
            ims.TakeOrder("Roomba", 234);
            ims.TakeOrder("Samsung TV", 54);
            ims.TakeOrder("Roomba", 34);
            ims.TakeOrder("Bose Headphones", 365);
            ims.TakeOrder("Samsung TV", 332);
            ims.TakeOrder("Roomba", 456);

            ims.Process();

            Console.WriteLine(ims.Report());


        }
    }
}