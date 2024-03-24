using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Api_mobile.special_classes
{
    /// <summary>
    /// Пользовательский конвертер для сериализации и десериализации объектов DateTime в JSON.
    /// Использует указанный формат даты.
    /// </summary>
    public class JsonDateTimeConverter : JsonConverter<DateTime>
    {
        // Формат даты, используемый в JSON.
        private readonly string _dateFormat;

        /// <summary>
        /// Конструктор для установки формата даты.
        /// </summary>
        /// <param name="format">Формат даты. По умолчанию "yyyy-MM-dd".</param>
        public JsonDateTimeConverter(string format = "yyyy-MM-dd")
        {
            _dateFormat = format;
        }

        /// <summary>
        /// Чтение и преобразование строки JSON в объект DateTime.
        /// </summary>
        /// <param name="reader">Читатель JSON.</param>
        /// <param name="typeToConvert">Тип конвертируемых данных.</param>
        /// <param name="options">Опции сериализатора.</param>
        /// <returns>Объект DateTime.</returns>
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Преобразование строки JSON в DateTime с использованием заданного формата.
            return DateTime.ParseExact(reader.GetString(), _dateFormat, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Запись объекта DateTime в строку JSON.
        /// </summary>
        /// <param name="writer">Писатель JSON.</param>
        /// <param name="value">Значение DateTime для записи.</param>
        /// <param name="options">Опции сериализатора.</param>
        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            // Сериализация DateTime в строку JSON с использованием заданного формата.
            writer.WriteStringValue(value.ToString(_dateFormat));
        }
    }
}
