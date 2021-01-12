using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturanto.Models
{
    public class Table
    {
        public int Id { get; set; }
        
        public bool Reserved { get; set; }

        public int RestaurantId { get; set; }
        public Models.Restaurant Restaurant { get; set; }

        public IColecction<Reservation> Reservations { get; set; }
    }
}