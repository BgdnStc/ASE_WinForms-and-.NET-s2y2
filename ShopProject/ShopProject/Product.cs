using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class Product : IComparable<Product>
    {
        internal int Id;
        internal string Name;
        internal int Units;
        internal double Price;
        internal int CategoryId;

        public Product()
        {
            Id = 0;
            Name = string.Empty;
            Units = 0;
            Price = 0;
            CategoryId = 0;
        }

        public Product(int id, string name, int units, double price, int categoryId) 
        {
            Id = id;
            Name = name;
            Units = units;
            Price = price;
            CategoryId = categoryId;
        }

        public static explicit operator double(Product p)
        {
            return p.Units * p.Price;
        }

        public int CompareTo(Product other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
