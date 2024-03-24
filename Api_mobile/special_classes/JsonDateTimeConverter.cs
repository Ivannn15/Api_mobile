using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Api_mobile.special_classes
{
    public class JsonDateTimeConverter : JsonConverter<DateTime>
    {
        private readonly string _dateFormat;

        public JsonDateTimeConverter(string format = "yyyy-MM-dd")
        {
            _dateFormat = format;
        }

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.ParseExact(reader.GetString(), _dateFormat, CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(_dateFormat));
        }
    }
}
