using KLDFishStall.Attributues;
using KLDFishStall.Model.DTO;
using KLDFishStall.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace KLDFishStall.Controllers
{
    [ExceptionHandler]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public UserDTO Login([FromBody]UserDTO user)
        {
            return _userService.Login(user);
        }

        [HttpPost]
        public UserDTO Register([FromBody]UserDTO user)
        {
            return _userService.Register(user);
        }

        [HttpPost]
        public UserDTO SocialNewtowkLogin([FromBody]UserDTO user)
        {
            return _userService.SocialNewtowkLogin(user);
        }
    }
}
