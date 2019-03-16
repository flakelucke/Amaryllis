using System.ComponentModel.DataAnnotations;
using Amaryllis.Models.Cars;
using Amaryllis.Models.Cars.CarAttributes;

namespace Amaryllis.Models.BindingTargets
{
    public class CarData
    {

        [Required]
        public CarModel Model { get; set; }
        [Required]
        public CarClass CarClass { get; set; }
        [Required]
        public WhoManufacturerCar WhoManufacturerCar { get; set; }
        [Required]
        public int YearOfIssue { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }

        public Car GetCar() => new Car
        {
            Model = Model,
            WhoManufacturerCar = WhoManufacturerCar,
            CarClass = CarClass,
            YearOfIssue = YearOfIssue,
            RegistrationNumber = RegistrationNumber
        };

        public void UpdateCar(Car car)
        {
            car.Model = this.Model;
        }
    }
}