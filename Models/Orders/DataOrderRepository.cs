using System.Threading.Tasks;
using System;
using Amaryllis.Models.BindingTargets;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace Amaryllis.Models.Orders
{
    public class DataOrderRepository : IOrderRepository
    {
        private readonly DataContext context;
        public DataOrderRepository(DataContext context)
        {
            this.context = context;
        }
        public async Task<long> CreateOrderAsync(OrderData data)
        {
            Order order = data.GetOrder();
            context.Attach(order.User);
            context.Attach(order.Car);
            await context.AddAsync(order);
            await context.SaveChangesAsync();
            return order.OrderId;
        }

        public async Task DeleteOrderAsync(long id)
        {
            var order = await FindOrderByIdAsync(id);
            if (order == null)
                throw new ArgumentNullException("$Order with this id:{id} is not found");

            context.Orders.Remove(order);
            await context.SaveChangesAsync();
        }

        public async Task<Order> FindOrderByIdAsync(long id)
        {
            return await context.Orders
                .Include(x => x.Car)
                .Include(p => p.User)
                .Include(x => x.Car.CarClass)
                .Include(x => x.Car.Model)
                .Include(x => x.Car.WhoManufacturerCar)
                .FirstOrDefaultAsync(x => x.OrderId == id);
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await context.Orders
            .Include(x => x.User)
            .Include(x => x.Car)
            .Include(x => x.Car.CarClass)
            .Include(x => x.Car.Model)
            .Include(x => x.Car.WhoManufacturerCar)
            .ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetFilterOrdersAsync(string filter, DateTime fromDate, DateTime toDate)
        {
            IEnumerable<Order> res;
            if (filter != null)
            {
                res = await context.Orders
               .Include(x => x.User)
               .Include(x => x.Car)
               .Include(x => x.Car.CarClass)
               .Include(x => x.Car.Model)
               .Include(x => x.Car.WhoManufacturerCar)
               .Where(x => x.User.FirstName.Contains(filter) ||
               x.User.LastName.Contains(filter) ||
               x.Car.Model.Model.Contains(filter) ||
               x.Car.WhoManufacturerCar.WhoManufacturer.Contains(filter))
               .ToListAsync();
                return await GetFilterOrdersByDateAsync(res, fromDate, toDate);
            }
            else
            {
                res = await GetAllOrdersAsync();
                return await GetFilterOrdersByDateAsync(res, fromDate, toDate);
            }
        }

        public async Task<IEnumerable<Order>> GetFilterOrdersByDateAsync(IEnumerable<Order> orders, DateTime fromDate, DateTime toDate)
        {
            if (fromDate.ToString() == "1/1/01 12:00:00 AM" && toDate.ToString() == "1/1/01 12:00:00 AM")
            {
                return orders;
            }
            else if (fromDate.ToString() == "1/1/01 12:00:00 AM" && toDate.ToString() != "1/1/01 12:00:00 AM")
            {
                return orders.Where(x => x.EndOfRental < toDate);
            }
            else if (fromDate.ToString() != "1/1/01 12:00:00 AM" && toDate.ToString() == "1/1/01 12:00:00 AM")
            {
                return orders.Where(x => x.StartOfRental > fromDate);
            }
            else return orders.Where(x => x.StartOfRental > fromDate && x.EndOfRental < toDate);
        }

        public async Task UpdateOrderAsync(Order order)
        {

            context.Attach(order.User);
            context.Attach(order.Car);
            context.Attach(order.Car.Model);
            context.Attach(order.Car.CarClass);
            context.Attach(order.Car.WhoManufacturerCar);
            context.Update(order);
            await context.SaveChangesAsync();
        }
    }
}