using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    class RestaurantManager
    {
        private static RestaurantContext restaurantContext;
        public RestaurantManager(RestaurantDbContext dbContext)
        {
            restaurantContext = new RestaurantContext(dbContext);
        }

        public static void Create(Restaurant restaurant)
        {
            try
            {
                restaurantContext.Create(restaurant);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Restaurant Read(int key)
        {
            try
            {
                return restaurantContext.Read(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ICollection<Restaurant> ReadAll()
        {
            try
            {
                return restaurantContext.ReadAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Update(Restaurant restaurant)
        {
            try
            {
                restaurantContext.Update(restaurant);
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
                restaurantContext.Delete(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
