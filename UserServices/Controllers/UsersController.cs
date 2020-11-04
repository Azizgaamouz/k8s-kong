using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UserServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly string[] Users = new[]
        {
            "Azizg", "Anas", "Reda", "Idriss", "Bachir", "Madiha","Imane","Tawfiq","Abdou"
        };

        private readonly ILogger<UsersController> _logger;
       public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Users> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 6).Select(index => new Users
            {
               User = Users[rng.Next(Users.Length)]
            })
            .ToArray();
        }
    }
}
