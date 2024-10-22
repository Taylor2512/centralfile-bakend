using CentalFile.managment.api.Extensions;

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CentalFile.managment.api.DtaAcces.StronglyTypedIDs
{
    [TypeConverter(typeof(ContactIdTypeConverter))]
    [JsonConverter(typeof(StronglyTypedIdJsonConverter<ContactId>))]

    public sealed record ContactId(long Value)
    {
   
        public static implicit operator long(ContactId contactId)
        {
            return contactId.Value;
        }

        public static implicit operator ContactId(long value)
        {
            return new(value);
        }

        public static implicit operator string(ContactId contactId)
        {
            return contactId.Value.ToString();
        }

        public static implicit operator ContactId(string value)
        {
            return new(long.Parse(value));
        }
    }
    public class ContactIdTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object? ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return value is string strValue ? new ContactId(int.Parse(strValue)) : base.ConvertFrom(context, culture, value);
        }
    }

}
