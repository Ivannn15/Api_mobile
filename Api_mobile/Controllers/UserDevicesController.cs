using Microsoft.AspNetCore.Mvc;
using Api_mobile.Models;

namespace Api_mobile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserDevicesController : ControllerBase
    {
        private readonly My_dbContext _dbContext;


        [HttpGet]
        public IActionResult Test(int userId)
        {
            var UserDevices = _dbContext.Users
                .Where(d => d.IdUser == userId)
                .SelectMany(d => d.User)
            // Замените на соответствующую логику, возвращающую данные
            return Ok();
        }
    }
}
