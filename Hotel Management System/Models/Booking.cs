using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string Status { get; set; }
    }
}
