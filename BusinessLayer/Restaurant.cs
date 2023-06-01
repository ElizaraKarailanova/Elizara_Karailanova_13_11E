using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    public class Restaurant
    {
        public Restaurant()
        {
            Reservations = new List<Reservation>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public decimal YearlyIncome { get; set; }
    }
}
