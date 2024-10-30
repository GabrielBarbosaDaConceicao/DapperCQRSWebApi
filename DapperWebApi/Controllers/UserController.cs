using DapperWebApi.Entities;
using DapperWebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DapperWebApi.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userService;

        public UserController(IUserRepository userService)
        {
            _userService = userService;
        }

        [HttpGet("users")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _userService.GetUsers();

            if (users is null)
                return NotFound();

            return Ok(users);
        }

        [HttpGet("user/{id:int}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);

            if (user is null)
                return NotFound();
  
            if (user.Id != id)
                return NotFound();

            return Ok(user);
        }

        [HttpPost("user/create")]
        public async Task<ActionResult<IEnumerable<User>>> CreateUser([FromBody] User user)
        {
            if ( user is null)
            {
                return BadRequest();
            }

            var result = await _userService.AddUser(user);

            return Ok(result);
        }
    }
}
