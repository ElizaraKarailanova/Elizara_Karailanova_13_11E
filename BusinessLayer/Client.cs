using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    public class Client
    {
        public Client()
        {
            Reservations = new List<Reservation>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1,100)]
        public int Age { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
