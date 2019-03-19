using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amaryllis.Models.BindingTargets;
using Microsoft.AspNetCore.JsonPatch;

namespace Amaryllis.Models.Orders
{
    public interface IOrderRepository
    {
         Task<long> CreateOrderAsync(OrderData data);
         Task DeleteOrderAsync(long id);
         Task<Order> FindOrderByIdAsync(long id);
         Task UpdateOrderAsync(Order order);
         Task<IEnumerable<Order>> GetAllOrdersAsync();
         Task<IEnumerable<Order>> GetFilterOrdersAsync(string filter,DateTime fromDate,DateTime toDate);
         Task<IEnumerable<Order>> GetFilterOrdersByDateAsync(IEnumerable<Order> orders,DateTime fromDate,DateTime toDate);
    }
}