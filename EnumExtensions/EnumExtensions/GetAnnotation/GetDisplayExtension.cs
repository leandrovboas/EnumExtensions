using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace EnumExtensions
{
    internal static class GetDisplayExtension
    {
        internal static string GetDisplayExt(this Enum enumValue) =>
            enumValue.GetType()
                   .GetMember(enumValue.ToString())
                   .First()
                   .GetCustomAttribute<DisplayAttribute>()
                   .Name;
    }
}
