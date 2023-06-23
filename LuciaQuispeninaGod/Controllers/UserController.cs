using LuciaQuispeninaGod.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LuciaQuispeninaGod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "Jorge" },
                new User { Id = 2, Name = "Jorge2" },
                new User { Id = 3, Name = "Jorge3" }

            };
        }
    }
}
