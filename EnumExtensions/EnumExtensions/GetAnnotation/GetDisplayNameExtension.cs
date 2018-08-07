using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace EnumExtensions
{
    internal static class GetDisplayNameExtension
    {
        internal static string GetDisplayNameExt(this Enum enumValue) =>
            enumValue.GetType()
                   .GetMember(enumValue.ToString())
                   .First()
                   .GetCustomAttribute<DisplayNameAttribute>()
                    .DisplayName;
    }
}
