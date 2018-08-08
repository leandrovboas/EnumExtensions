using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace EnumExtensions
{
    internal static class GetDisplayExtension
    {
        internal static string GetDisplayExt(this Enum source) =>
            source.GetType()
                   .GetMember(source.ToString())
                   .First()
                   .GetCustomAttribute<DisplayAttribute>()
                   .Name;
    }
}
