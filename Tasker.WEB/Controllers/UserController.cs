using Microsoft.AspNetCore.Mvc;
using Tasker.Logic;
using Tasker.WEB.Models.User;

namespace Tasker.WEB.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// конструктор по умолчанию, в котором инициализируется зависимость UserService
        /// </summary>
        private readonly UserService _userService;

        public UserController(UserService userService) { 
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int Id) 
        {
            var user = _userService.Get(Id);
            var model = new UserViewModel(user);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(UserEditViewModel updatedUser)
        {
            return RedirectToAction("Edit", new { id = updatedUser.Id });
        }

        [HttpGet]
        public IActionResult List()
        {
            var user = _userService.Get(1);
            var userViewModel = new UserViewModel(user);
            UserViewModel[] users = new UserViewModel[1] { userViewModel };
            return View(users);
        }
    }
}
