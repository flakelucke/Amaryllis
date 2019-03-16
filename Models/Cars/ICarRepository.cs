using System.Collections.Generic;
using System.Threading.Tasks;

namespace Amaryllis.Models.Cars
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllCarsAsync();
        Task<Car> FindCarByIdAsync(long id);
    }
}