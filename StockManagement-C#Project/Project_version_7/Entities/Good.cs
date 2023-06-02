using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_version_7 
{
    public class Good
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Quantity { get; set; }
        public long SupplierId { get; set; }

        public Good() { }

        public Good(string name, long quantity, long supplierId)
        {
            Name = name;
            Quantity = quantity;
            SupplierId = supplierId;
        }

        public Good(long id, string name, long quantity, long supplierId)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            SupplierId = supplierId;
        }
    }
}