using Microsoft.AspNetCore.Mvc;
using WebApp.BLL.Services;
using WebApp.DAL.Entities;

namespace WebApp.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public OrderController(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        public async Task<IActionResult> Index() => View(await _orderService.GetAllOrdersAsync());

        public async Task<IActionResult> Create()
        {
            ViewBag.Users = await _userService.GetAllUsersAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(Order order)
        {
            if (order.Id == 0)
                await _orderService.CreateOrderAsync(order);
            else
                await _orderService.UpdateOrderAsync(order);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var order = await _orderService.GetOrderByIdAsync(id);
            ViewBag.Users = await _userService.GetAllUsersAsync();
            return View(order);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var order = await _orderService.GetOrderByIdAsync(id);
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _orderService.DeleteOrderAsync(id);
            return RedirectToAction("Index");
        }
    }
}

