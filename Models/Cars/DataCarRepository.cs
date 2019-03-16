using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Amaryllis.Models.Cars
{
    public class DataCarRepository : ICarRepository
    {
        public readonly DataContext context;
        public DataCarRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<Car> FindCarByIdAsync(long id)
        {
            return await context.Cars
            .Include(x=>x.CarClass)
            .Include(x=>x.Model)
            .Include(x=>x.WhoManufacturerCar)
            .FirstOrDefaultAsync(x=>x.CarId==id);
        }

        public async Task<IEnumerable<Car>> GetAllCarsAsync()
        {
            return await context.Cars
            .Include(x=>x.CarClass)
            .Include(x=>x.Model)
            .Include(x=>x.WhoManufacturerCar)
            .ToListAsync();
        }
    }
}