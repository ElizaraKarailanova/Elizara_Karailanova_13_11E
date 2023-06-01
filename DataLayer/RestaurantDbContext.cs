using System;
using System.Data.Entity;
using BusinessLayer;

namespace DataLayer
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("Restaurant")
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
