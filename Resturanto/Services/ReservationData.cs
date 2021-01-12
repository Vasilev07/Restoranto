using Resturanto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturanto.Services
{
    public class ReservationData : IReservationData
    {
        private readonly Restoranto db;

        public ReservationData(Restoranto db)
        {
            this.db = db;
        }
        public IEnumerable<Reservation> GetAll()
        {
            return from r in db.Reservation
                    select r;
        }

        public IEnumerable<Reservation> GetAll(int id)
        {
            throw new NotImplementedException();
        }
    }
}