using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;

namespace DataLayer
{
    public class ReservationContext : IDb<Reservation, int>
    {
        private readonly RestaurantDbContext dbContext;
        public ReservationContext(RestaurantDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Reservation item)
        {
            try
            {
                dbContext.Reservations.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Reservation Read(int key)
        {
            try
            {
                return dbContext.Reservations.Find(key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Reservation> ReadAll()
        {
            try
            {
                return dbContext.Reservations.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Reservation item)
        {
            try
            {
                Reservation reservation = dbContext.Reservations.Find(item.Id);
                dbContext.Entry(reservation).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Reservation reservation = dbContext.Reservations.Find(key);
                dbContext.Reservations.Remove(reservation);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
