using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HamedStack.TheEnumeration.EntityFrameworkCore;

public class EnumerationValueConverter<TEnumeration> : ValueConverter<TEnumeration, long>
    where TEnumeration : Enumeration<TEnumeration>
{
    public EnumerationValueConverter() : base(
        v => v.Value,
        v => Enumeration<TEnumeration>.FromValue(v))
    {
    }
}