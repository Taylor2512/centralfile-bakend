﻿using CentalFile.managment.api.Extensions;

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CentalFile.managment.api.DtaAcces.StronglyTypedIDs
{
    [TypeConverter(typeof(CompanyIdTypeConverter))]
    [JsonConverter(typeof(StronglyTypedIdJsonConverter<CompanyId>))]

    public sealed record CompanyId(Guid Value)
    {
        public CompanyId() : this(Guid.NewGuid())
        {
        }
        public static implicit operator Guid(CompanyId contactId)
        {
            return contactId.Value;
        }

        public static implicit operator CompanyId(Guid value)
        {
            return new(value);
        }

        public static implicit operator string(CompanyId contactId)
        {
            return contactId.Value.ToString();
        }

        public static implicit operator CompanyId(string value)
        {
            return new(Guid.Parse(value));
        }
    }
    public class CompanyIdTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object? ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return value is string strValue ? new CompanyId(Guid.Parse(strValue)) : base.ConvertFrom(context, culture, value);
        }
    }
}
