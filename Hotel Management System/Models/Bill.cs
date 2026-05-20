using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public decimal Total { get; set; }
        public string Date { get; set; }
    }
}
