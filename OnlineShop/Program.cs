using System.Collections.Generic;
using System.Linq;

namespace OnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product("Book", 1.0, 10),
                new Product("Pen", 0.1, 12),
                new Product("Notebook", 1.5, 5),
                new Product("folder", 0.3, 45),
                new Product("clip", 0.5, 7)
            };

            ProductPrinter.PrintProductsList(products, "Original list:");

            ProductByPriceComparer pc = new ProductByPriceComparer();
            IEnumerable<Product> items = products.OrderBy((p => p), pc);            
            ProductPrinter.PrintProductsList(items, "List sorted by price (asc):");

            ProductByNameComparer nc = new ProductByNameComparer();
            items = products.OrderBy((p => p), nc);
            ProductPrinter.PrintProductsList(items, "List sorted by name (case ignored):");

            ProductByStockPileComparer spc = new ProductByStockPileComparer();
            items = products.OrderByDescending((p => p), spc).ToList();
            ProductPrinter.PrintProductsList(items, "List sorted by amount in stock (desc):");

            List<Product> sortedList = products.ToList();
            sortedList.Sort();
            ProductPrinter.PrintProductsList(sortedList, "List sorted by name (asc):");

            Product[] products2 = new Product[]
            {
                new Product("Notebook", 1.5, 0),
                new Product("Clip", 0.5, 0)
            };

            ProductPrinter.PrintProductsList(products.Intersect(products2), "Intersect 2 lists:");
        }
    }
}
