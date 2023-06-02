using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_version_7.Entities
{
    internal class Operation
    {
        public long Id { get; set; }
        public Good v_Good { get; set; }
        public Supplier v_Supplier { get; set; }
        public DateTime Date { get; set; }

        public Operation() { }

        public Operation(long id, Good v_Good, Supplier v_Supplier, DateTime date)
        {
            Id = id;
            this.v_Good = v_Good;
            this.v_Supplier = v_Supplier;
            Date = date;
        }
    }
}
