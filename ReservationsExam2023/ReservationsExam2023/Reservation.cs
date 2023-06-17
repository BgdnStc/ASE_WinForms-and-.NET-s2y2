using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationsExam2023
{
    public class Reservation : IComparer<Reservation>
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set;}
        public int Persons { get; set; }

        public Reservation()
        {
            Id = 0;
            RoomId = 0;
            CheckInDate = DateTime.MinValue;
            CheckOutDate = DateTime.MinValue;
            Persons = 0;
        }

        public Reservation(int id, int roomId, DateTime checkInDate, DateTime checkOutDate, int persons)
        {
            Id = id;
            RoomId = roomId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Persons = persons;
        }

        public static Reservation operator ++(Reservation reservation)
        {
            reservation.Id++;
            return reservation;
        }

        public override string ToString()
        {
            return "Reservation id: " + Id.ToString();
        }

        int IComparer<Reservation>.Compare(Reservation r1, Reservation r2)
        {
            if (r1.Id > r2.Id)
            {
                return -1;
            }
            else if (r1.Id < r2.Id)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
