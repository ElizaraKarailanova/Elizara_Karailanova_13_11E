using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;

namespace DataLayer
{
    public class RestaurantContext : IDb<Restaurant, int>
    {
        private readonly RestaurantDbContext dbContext;
        public RestaurantContext(RestaurantDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Restaurant item)
        {
            try
            {
                dbContext.Restaurants.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Restaurant Read(int key)
        {
            try
            {
                return dbContext.Restaurants.Find(key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Restaurant> ReadAll()
        {
            try
            {
                return dbContext.Restaurants.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Restaurant item)
        {
            try
            {
                Restaurant restaurant = dbContext.Restaurants.Find(item.Id);
                dbContext.Entry(restaurant).CurrentValues.SetValues(item);
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
                Restaurant restaurant = dbContext.Restaurants.Find(key);
                dbContext.Restaurants.Remove(restaurant);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
