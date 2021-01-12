using Resturanto.Models;
using System.Collections.Generic;


namespace Resturanto.Services
{
    public interface IReservationData
    {
        IEnumerable<Reservation> GetAll();
        IEnumerable<Reservation> GetAll(int id);
    }
}
