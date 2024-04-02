using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HamedStack.TheEnumeration.EntityFrameworkCore;

public class EnumerationNameConverter<TEnumeration> : ValueConverter<TEnumeration, string>
    where TEnumeration : Enumeration<TEnumeration>
{
    public EnumerationNameConverter() : base(
        v => v.Name,
        v => Enumeration<TEnumeration>.FromName(v, false))
    {
    }
}