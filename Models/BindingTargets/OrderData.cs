using System;
using System.ComponentModel.DataAnnotations;
using Amaryllis.Models.Cars;
using Amaryllis.Models.Orders;
using Amaryllis.Models.Users;

namespace Amaryllis.Models.BindingTargets
{
    public class OrderData
    {
        [Required]
        public DateTime StartOfRental { get; set; }
        public DateTime EndOfRental { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public Car Car { get; set; }
        [Required]
        public User User { get; set; }

        public Order GetOrder() => new Order
        {
            StartOfRental = StartOfRental,
            EndOfRental = EndOfRental,
            Comment = Comment,
            Car = Car,
            User = User
        };

    }
}