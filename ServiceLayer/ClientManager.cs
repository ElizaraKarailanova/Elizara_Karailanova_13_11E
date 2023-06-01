using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class ClientManager
    {
        private static ClientContext clientContext;
        public ClientManager(RestaurantDbContext dbContext)
        {
            clientContext = new ClientContext(dbContext);
        }

        public static void Create(Client client)
        {
            try
            {
                clientContext.Create(client);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Client Read(int key)
        {
            try
            {
                return clientContext.Read(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ICollection<Client> ReadAll()
        {
            try
            {
                return clientContext.ReadAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Update(Client client)
        {
            try
            {
                clientContext.Update(client);
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
                clientContext.Delete(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
