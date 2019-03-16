using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amaryllis.Models.BindingTargets;
using Amaryllis.Models.Cars;
using Amaryllis.Models.Orders;
using Amaryllis.Models.Users;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Amaryllis.Controllers
{
    [Route("api/orders")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository orderRepository;
        private readonly IUserRepository userRepository;
        private readonly ICarRepository carRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await orderRepository.GetAllOrdersAsync();
        }

        [HttpGet("{id}")]
        public async Task<Order> FindOrderAsync(long id){
            return await orderRepository.FindOrderByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody]OrderData data)
        {
            if (ModelState.IsValid)
            {
                return Ok(await orderRepository.CreateOrderAsync(data));
            }
            else
                return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(long id)
        {
            try
            {
                await orderRepository.DeleteOrderAsync(id);
                return Ok();
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, [FromBody]OrderData data)
        {
            if (ModelState.IsValid)
            {
                // Order order = await orderRepository.FindOrderByIdAsync(id);
                // if (order == null)
                // {
                //     return NotFound();
                // }
                Order order = new Order();
                order.OrderId = id;
                order.StartOfRental = data.StartOfRental;
                order.EndOfRental = data.EndOfRental;
                order.Comment = data.Comment;
                order.Car = data.Car;
                order.User = data.User;
                await orderRepository.UpdateOrderAsync(order);

                return Ok();
            }

            return BadRequest(ModelState);
        }
    }
}