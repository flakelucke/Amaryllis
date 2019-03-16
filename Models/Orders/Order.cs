using System;
using Amaryllis.Models.Cars;
using Amaryllis.Models.Users;

namespace Amaryllis.Models.Orders
{
    public class Order
    {
        public long OrderId {get;set;}
        public DateTime StartOfRental {get;set;}
        public DateTime EndOfRental {get;set;}
        public string Comment {get;set;}
        public Car Car {get;set;}
        public User User {get;set;}
    }
}