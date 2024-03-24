using Api_mobile.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_mobile.Controllers
{
    /// <summary>
    /// Контроллер для работы с информацией о пользователе
    /// </summary>
    [ApiController]
    [Route("api/[controller]")] // Маршрутизация запроса к этому контроллеру
    public class UserInfoController : ControllerBase
    {
        // Экземпляр контекста базы данных.
        private readonly My_dbContext _dbContext;

        /// <summary>
        /// Конструктор для инициализации контекста базы данных
        /// </summary>
        /// <param name="dbContext"></param>
        public UserInfoController(My_dbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Получить информациб о пользователе по его ID
        /// </summary>
        /// <param name="userId"> Идентификатор пользователя </param>
        /// <returns> Информация о пользователе </returns>
        [HttpGet]
        public IActionResult GetInfoByUser(int userId)
        {
            var info = _dbContext.Users
                .Where(us => us.IdUser == userId);

            return Ok(value: info);
        }

    }
}
