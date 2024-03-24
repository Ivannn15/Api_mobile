using System.Text.Json;
using System.Text.Json.Serialization;

namespace Api_mobile.special_classes
{
    /// <summary>
    /// Конвертер JSON для типа DateOnly.
    /// Этот класс позволяет сериализовать и десериализовать значения DateOnly в JSON.
    /// </summary>
    public class DateOnlyJsonConverter : JsonConverter<DateOnly>
    {
        // Формат даты для сериализации и десериализации.
        private const string Format = "yyyy-MM-dd";

        /// <summary>
        /// Читает и конвертирует JSON в DateOnly.
        /// </summary>
        /// <param name="reader">Читатель JSON.</param>
        /// <param name="typeToConvert">Тип данных для конвертации.</param>
        /// <param name="options">Опции сериализатора JSON.</param>
        /// <returns>Объект DateOnly.</returns>
        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Преобразование строки JSON в DateOnly с использованием определенного формата.
            return DateOnly.ParseExact(reader.GetString()!, Format);
        }

        /// <summary>
        /// Записывает DateOnly в JSON.
        /// </summary>
        /// <param name="writer">Писатель JSON.</param>
        /// <param name="value">Значение DateOnly для записи.</param>
        /// <param name="options">Опции сериализатора JSON.</param>
        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            // Сериализация объекта DateOnly в строку JSON с использованием определенного формата.
            writer.WriteStringValue(value.ToString(Format));
        }
    }
}
