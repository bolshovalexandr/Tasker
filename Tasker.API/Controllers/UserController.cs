using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tasker.API.Models.User;
using Tasker.Logic;

namespace Tasker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<UserModel> Get(int id)
        {
            var user = _userService.Get(id);
            var userModel = new UserModel(user);
            return Ok(userModel);

        }
    }
}
