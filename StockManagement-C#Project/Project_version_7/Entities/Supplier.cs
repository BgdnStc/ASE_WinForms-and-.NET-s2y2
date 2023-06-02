using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_version_7.Entities
{
    internal class Supplier
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Supplier() { }   

        public Supplier(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public Supplier(long id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
