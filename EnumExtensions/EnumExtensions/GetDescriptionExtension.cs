using System;
using System.ComponentModel;

namespace EnumExtensions
{
    internal class GetDescriptionExtension<T>
    {
        internal static string GetEnumDescription(Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());

            var attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            return attributes != null &&
                attributes.Length > 0 ? attributes[0].Description : value.ToString();

        }
    }
}