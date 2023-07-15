using Api.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult SaveUser([FromBody] UserDto userDto)
        {
            // Ovde bi pozvali vašu SaveUserCommand komandu

            return Ok(); // Vraća HTTP 200 OK za sada
        }
    }
}
