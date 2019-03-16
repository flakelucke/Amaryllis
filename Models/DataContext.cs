using Amaryllis.Models.Cars;
using Amaryllis.Models.Cars.CarAttributes;
using Amaryllis.Models.Orders;
using Amaryllis.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Amaryllis.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
        : base(opts) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }


        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarClass> CarClasses { get; set; }
        public DbSet<WhoManufacturerCar> Manufacturers { get; set; }
    }
}