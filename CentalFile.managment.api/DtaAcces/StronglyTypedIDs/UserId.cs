using CentalFile.managment.api.Extensions;

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CentalFile.managment.api.DtaAcces.StronglyTypedIDs
{
    [TypeConverter(typeof(UserIdTypeConverter))]
    [JsonConverter(typeof(StronglyTypedIdJsonConverter<UserId>))]

    public sealed record UserId(Guid Value)
    {
        public static implicit operator Guid(UserId userId)
        {
            return userId.Value;
        }

        public static implicit operator UserId(Guid value)
        {
            return new(value);
        }

        public static implicit operator string(UserId userId)
        {
            return userId.Value.ToString();
        }

        public static implicit operator UserId(string value)
        {
            return new(Guid.Parse(value));
        }
    }

    public class UserIdTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object? ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return value is string strValue ? new UserId(Guid.Parse(strValue)) : base.ConvertFrom(context, culture, value);
        }
    }
}
