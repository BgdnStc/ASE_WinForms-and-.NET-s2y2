using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationsExam2023
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Beds { get; set; }

        public Room()
        {
            Id = 0;
            Number = 0;
            Beds = 0;
        }

        public Room(int id, int number, int beds)
        {
            Id = id;
            Number = number;
            Beds = beds;
        }
    }
}
