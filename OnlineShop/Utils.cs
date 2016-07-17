using System;
using System.Collections.Generic;

namespace OnlineShop
{
    public class ProductPrinter
    {
        public static void PrintProductsList(IEnumerable<Product> items, string listTitle = null)
        {
            if (!string.IsNullOrEmpty(listTitle))
            {
                Console.WriteLine();
                Console.WriteLine(listTitle);
            }

            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public class ProductByPriceComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.Price > y.Price)
            {
                return 1;
            }
            else if (x.Price < y.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class ProductByNameComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return string.Compare(x.Name, y.Name, true);
        }
    }

    public class ProductByStockPileComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.StockPile > y.StockPile)
            {
                return 1;
            }
            else if (x.StockPile < y.StockPile)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
