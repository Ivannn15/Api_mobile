using Microsoft.AspNetCore.Mvc;
using Api_mobile.Models;

namespace Api_mobile.Controllers
{
    /// <summary>
    /// Контроллер для работы с информацией о девайсах пользователя
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserDevicesController : ControllerBase
    {
        // Экземпляр контекста базы данных.
        private readonly My_dbContext _dbContext;

        /// <summary>
        /// Конструктор для инициализации контекста базы данных
        /// </summary>
        /// <param name="dbContext"></param>
        public UserDevicesController(My_dbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Получить информацию о девайсах пользователя по его ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
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
