using System.Collections.Generic;
using System.Threading.Tasks;
using Amaryllis.Models.Cars;
using Amaryllis.Models.Cars.CarAttributes;
using Microsoft.AspNetCore.Mvc;

namespace Amaryllis.Controllers
{

    [Route("api/cars")]
    public class CarController : Controller
    {
        private readonly ICarRepository repository;
        public CarController(ICarRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Car>> GetAllCars()
        {
            return await repository.GetAllCarsAsync();
        }
    }
}