using ExternalFancyProductLib;

namespace ShoppingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();
            var hat = new Hat("Golden Hat", "Gold premium hat", 100);
            var book = new Book();
            cart.Add(book);

            cart.Add(new HatToItemAdapter(hat));


            foreach (var item in cart.Items)
            {
                Console.WriteLine(item.ItemName());
                Console.WriteLine(item.ItemPrice());

            }
        }
    }

   
}