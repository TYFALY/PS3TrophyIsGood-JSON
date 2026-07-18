using System;
using System.Globalization;
using Newtonsoft.Json;

namespace PS3TrophyIsGood
{
    public class TrophyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Unlocked { get; set; }

        [JsonConverter(typeof(TimestampJsonConverter))]
        public DateTime Timestamp { get; set; }
    }

    public sealed class TimestampJsonConverter : JsonConverter
    {
        private const string TimestampFormat = "yyyy-MM-dd HH:mm:ss";
        private static readonly string[] AlternateFormats = new[]
        {
            "yyyy-MM-ddTHH:mm:ss",
            "yyyy-MM-ddTHH:mm:ssZ",
            "yyyy-MM-dd HH:mm",
            "yyyy-MM-ddTHH:mm",
            "yyyy/MM/dd HH:mm:ss",
            "yyyy/MM/dd"
        };

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime) || objectType == typeof(DateTime?);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is DateTime dateTime)
            {
                writer.WriteValue(dateTime.ToString(TimestampFormat, CultureInfo.InvariantCulture));
            }
            else
            {
                writer.WriteNull();
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return DateTime.MinValue;
            }

            if (reader.TokenType == JsonToken.String)
            {
                var text = reader.Value?.ToString();
                if (string.IsNullOrWhiteSpace(text))
                {
                    return DateTime.MinValue;
                }

                if (DateTime.TryParseExact(text, TimestampFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsed))
                {
                    return parsed;
                }

                if (DateTime.TryParseExact(text, AlternateFormats, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal | DateTimeStyles.AllowWhiteSpaces, out parsed))
                {
                    return parsed;
                }

                if (DateTime.TryParse(text, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out parsed))
                {
                    return parsed;
                }

                return DateTime.MinValue;
            }

            if (reader.TokenType == JsonToken.Date && reader.Value is DateTime dateTime)
            {
                return dateTime;
            }

            return DateTime.MinValue;
        }
    }
}
