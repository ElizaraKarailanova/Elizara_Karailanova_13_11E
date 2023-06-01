using System;
using DataLayer;
using BusinessLayer;
using System.Collections.Generic;

namespace TestingLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientContext clientsDbContext = new ClientContext(new RestaurantDbContext());
            ReservationContext reservationsDbContext = new ReservationContext(new RestaurantDbContext());

            Client client = new Client();
            client.Id = 1;
            client.Name = "Ivan";
            client.Age = 54;
            client.Reservations = new List<Reservation>();
            clientsDbContext.Create(client);

            Reservation reservation = new Reservation();
            reservation.Id = 1;
            reservation.NumberOfRooms = 2;
            reservation.NumberOfDays = 7;
            reservation.Date = DateTime.UtcNow;
            reservation.Price = 1000;
            reservationsDbContext.Create(reservation);
        }
    }
}
