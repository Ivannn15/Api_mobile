using Api_mobile.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_mobile.Controllers
{
    /// <summary>
    /// Контроллер для работы с пользовательскими скриптами.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")] // Маршрутизация запроса к этому контроллеру
    public class UserScriptsController : ControllerBase
    {
        // Экземпляр контекста базы данных.
        private readonly My_dbContext _dbContext;

        /// <summary>
        /// Конструктор для инициализации контекста базы данных.
        /// </summary>
        /// <param name="dbContext">Контекст базы данных.</param>
        public UserScriptsController(My_dbContext dbContext)
        {
            _dbContext = dbContext; // Сохранение контекста базы данных.
        }

        /// <summary>
        /// Получить названия скриптов, связанных с пользователем.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Список названий скриптов пользователя.</returns>
        [HttpGet] // Обработка GET запросов.
        public IActionResult GetInfoByUserScripts(int userId)
        {
            // Запрос к базе данных для поиска скриптов, связанных с пользователем.
            var userScripts = _dbContext.UserScripts
                .Where(us => us.IdUser == userId) // Фильтрация по ID пользователя
                .Select(us => us.IdScriptNavigation.NameScript) // Выборка названий скриптов
                .ToList(); // Преобразование в список

            // Возвращаем результат запроса клиенту.
            return Ok(value: userScripts);
        }
    }
}
