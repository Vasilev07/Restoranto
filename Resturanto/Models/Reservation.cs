using System;

namespace Resturanto.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationTime { get; set; }

        public string ReservationName { get; set; }
        public string ReservationNumber { get; set; }

        public Models.Table Table { get; set; }

        public int TableId { get; set; }
    }
}