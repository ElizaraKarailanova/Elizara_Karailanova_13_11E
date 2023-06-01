using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Reservation
    {
        public Reservation()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required, Range(0,int.MaxValue)]
        public int NumberOfRooms { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int NumberOfDays { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required, Range(0, 1000000)]
        public decimal Price { get; set; }
    }
}
