using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace EnumExtensions
{
    internal static class GetDescriptionExtension
    {
        internal static string GetEnumDescriptionExt(this Enum value) =>
            value.GetType()
                   .GetMember(value.ToString())
                   .First()
                   .GetCustomAttribute<DescriptionAttribute>()
                   .Description;
    }
}