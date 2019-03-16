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