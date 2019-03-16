using Amaryllis.Models.Cars.CarAttributes;

namespace Amaryllis.Models.Cars
{
    public class Car
    {
        public long CarId { get; set; }
        public CarClass CarClass { get; set; }
        public CarModel Model { get; set; }
        public WhoManufacturerCar WhoManufacturerCar { get; set; }
        public int YearOfIssue { get; set; }

        public string RegistrationNumber { get; set; }
    }
}