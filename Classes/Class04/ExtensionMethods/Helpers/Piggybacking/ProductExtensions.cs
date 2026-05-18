using ExtensionMethods.Models;

namespace ExtensionMethods.Helpers.Piggybacking
{
    public static class ProductExtensions
    {
        public static void PrintInfo(this Product product)
        {
            Console.WriteLine(product.GetInfo());
        }
    }
}
