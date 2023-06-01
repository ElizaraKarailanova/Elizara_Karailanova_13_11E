using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;

namespace DataLayer
{
    public class ClientContext : IDb<Client, int>
    {
        private readonly RestaurantDbContext dbContext;
        public ClientContext(RestaurantDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Client item)
        {
            try
            {
                dbContext.Clients.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Client Read(int key)
        {
            try
            {
                return dbContext.Clients.Find(key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Client> ReadAll()
        {
            try
            {
                return dbContext.Clients.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Client item)
        {
            try
            {
                Client client = dbContext.Clients.Find(item.Id);
                dbContext.Entry(client).CurrentValues.SetValues(item);
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
                Client client = dbContext.Clients.Find(key);
                dbContext.Clients.Remove(client);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
