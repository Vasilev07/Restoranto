using Resturanto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturanto.ViewModels
{
    public class ReservationsViewModel
    {

        public Reservation Reservations { get; set; }
        public int TableId { get; set; }
        public string RestaurantName { get;set; }
    }
}