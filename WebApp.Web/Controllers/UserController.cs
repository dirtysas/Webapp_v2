using Microsoft.AspNetCore.Mvc;
using WebApp.BLL.Services;
using WebApp.DAL.Entities;

namespace WebApp.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) => _userService = userService;

        public async Task<IActionResult> Index() => View(await _userService.GetAllUsersAsync());

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Save(User user)
        {
            if (user.Id == 0)
                await _userService.CreateUserAsync(user);
            else
                await _userService.UpdateUserAsync(user);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return View(user);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _userService.DeleteUserAsync(id);
            return RedirectToAction("Index");
        }
    }
}
