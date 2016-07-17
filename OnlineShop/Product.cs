using System;
using System.Collections.Generic;

namespace OnlineShop
{
    public struct Product: IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockPile { get; set; }

        public Product(string name, double price, int stockPile)
        {
            Name = name;
            Price = price;
            StockPile = stockPile;
        }

        public override string ToString()
        {
            return $"Item: {Name} | Price: {Price} | Amount in Stock: {StockPile}";
        }

        public int CompareTo(Product obj)
        {
            return string.Compare(this.Name, obj.Name, true);
        }

        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                Product p = (Product)obj;
                return p.Name.Equals(this.Name, StringComparison.InvariantCultureIgnoreCase) && p.Price == this.Price;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hash = 17;
            
            hash = (hash * 23) + this.Name.ToLower().GetHashCode();
            hash = (hash * 31) + this.Price.GetHashCode();

            return hash;
        }
    }
}
