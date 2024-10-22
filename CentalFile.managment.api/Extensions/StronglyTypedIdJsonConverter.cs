using System.Text.Json.Serialization;
using System.Text.Json;

namespace CentalFile.managment.api.Extensions
{
    public class StronglyTypedIdJsonConverter<T> : JsonConverter<T> where T : notnull
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var guid = reader.GetGuid();
            return (T)Activator.CreateInstance(typeof(T), guid);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var guidValue = (Guid)typeof(T).GetProperty("Value")!.GetValue(value)!;
            writer.WriteStringValue(guidValue);
        }
    }
}
