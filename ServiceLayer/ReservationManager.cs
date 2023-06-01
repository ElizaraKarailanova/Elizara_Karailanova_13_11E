using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    class ReservationManager
    {
        private static ReservationContext reservationContext;
        public ReservationManager(RestaurantDbContext dbContext)
        {
            reservationContext = new ReservationContext(dbContext);
        }

        public static void Create(Reservation reservation)
        {
            try
            {
                reservationContext.Create(reservation);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Reservation Read(int key)
        {
            try
            {
                return reservationContext.Read(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ICollection<Reservation> ReadAll()
        {
            try
            {
                return reservationContext.ReadAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Update(Reservation reservation)
        {
            try
            {
                reservationContext.Update(reservation);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Delete(int key)
        {
            try
            {
                reservationContext.Delete(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
