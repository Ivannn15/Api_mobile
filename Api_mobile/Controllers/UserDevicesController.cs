using Microsoft.AspNetCore.Mvc;
using Api_mobile.Models;

namespace Api_mobile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserDevicesController : ControllerBase
    {
        private readonly My_dbContext _dbContext;

        public UserDevicesController(My_dbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Test(int userId)
        {

            // Получаем ID скриптов, связанных с пользователем
            var scriptIds = _dbContext.UserScripts
                .Where(us => us.IdUser == userId)
                .Select(us => us.IdScript)
                .ToList();

            // Используем эти ID для поиска устройств через DevicesScript
            var devices = _dbContext.DevicesScripts
                .Where(ds => scriptIds.Contains(ds.IdScript))
                .Select(ds => ds.IdDevicesNavigation)
                .Distinct()
                .ToList();

            return Ok(value: devices);
        }
    }
}
